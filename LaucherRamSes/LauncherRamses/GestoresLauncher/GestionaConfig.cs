using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Windows.Forms;
using LauncherRamses.Presentacion;
using LauncherRamses.Presentacion.UserControll;
using LauncherRamses.Resources.NomRecursos;
using Microsoft.Win32;

namespace LauncherRamses.GestoresLauncher
{
    public static class GestionaConfig
    {
        public static bool ExistenReglasDeEntradaFirewall(string nomRegla)
        {
            Process process = new Process();
            process.StartInfo.FileName = "netsh";
            process.StartInfo.Arguments = "advfirewall firewall show rule name=all";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Contains(nomRegla);
        }

        public static void ModificarAppConfig(string NombreKey, string valor)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = config.AppSettings.Settings;

            // Verificar si la clave existe
            if (appSettings[NombreKey] != null)
            {
                // Cambiar el valor de la clave
                appSettings[NombreKey].Value = valor;

                // Guardar los cambios en el archivo
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                // registrar en el archivo de registro
                Registry.SetValue(NomRegistro.ConfigLauncher, NombreKey, valor);
            }
            else
            {
                MessageBox.Show("La clave '" + NombreKey + "' no existe en el archivo app.config.", "Error");
            }
        }

        public static bool HayVaciosAppConfig()
        {
            var appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
            {
                if (string.IsNullOrEmpty(appSettings[key]))
                {
                    return true; // Hay un value vacío
                }
            }

            return false; // No hay values vacíos
        }

        public static void ActualizarHora()
        {
            try
            {
                ActivarHoraAutomatica();
                CambiarConfiguracionRegional();
                //ActivarZonaHorariaAutomatica();

                var FechaWebZ  = ObtenerHoraWeb;
                DateTime fechaWeb = FechaWebZ.FechaHora;
                string ZonaHoraWeb = FechaWebZ.ZonaHoraria;

                var nusad = TimeZoneInfo.GetSystemTimeZones();

                if (ZonaHorariaPc!= ZonaHoraWeb)
                {
                    int IdZonaHoraria = Convert.ToInt32(ZonaHoraWeb.Substring(0, 3));
                    TimeZoneInfo timeZone = TimeZoneInfo.GetSystemTimeZones().LastOrDefault(tz => tz.BaseUtcOffset.TotalHours == IdZonaHoraria);

                    string Coman = "tzutil /s \"" + timeZone.Id + "\"";

                    EjecutarComandoCmd(Coman);

                    GestionaPrivilegios.ReiniciarAplicacion();
                }

                DateTime fechaWebZ = TruncarFraccionesDeSegundo(fechaWeb);
                DateTime fechaPC = TruncarFraccionesDeSegundo(DateTime.Now);

                if (fechaWebZ != fechaPC)
                {

                    string hora = fechaWeb.ToString("HH:mm:ss");
                    string fecha = fechaWeb.ToString("dd-MM-yyyy");

                    string comando = $"time {hora} & date {fecha}";

                    EjecutarComandoCmd(comando);
                }

            }
            catch (Exception ex)
            {
                UCNotificaciones.MostrarNotifiacion("Error al actualizar la fecha y hora: ", ex.Message);
            }
        }
        public static void EjecutarComandoCmd(string comando)
        {

            try
            {
                // Configurar el proceso de ejecución del comando
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/C " + comando);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                // Iniciar el proceso
                Process proceso = Process.Start(psi);
                proceso.WaitForExit();

            }
            catch (Exception ex)
            {
                UCNotificaciones.MostrarNotifiacion("Error al ejecutar el comando en la consola: ", ex.Message);
            }

        }


        public static void EjecutarComandoTzutil(string comando)
        {
            try
            {
                // Configurar el proceso de ejecución del comando
                ProcessStartInfo psi = new ProcessStartInfo("tzutil.exe", comando);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas";  // Ejecuta el comando con privilegios de administrador


                // Iniciar el proceso
                Process proceso = Process.Start(psi);
                proceso.WaitForExit();
            }
            catch (Exception ex)
            {
                UCNotificaciones.MostrarNotifiacion("Error al ejecutar el comando en la consola: ", ex.Message);
            }
        }

        private static DateTime TruncarFraccionesDeSegundo(DateTime fecha)
        {
            TimeSpan tiempoSinFracciones = TimeSpan.FromSeconds(Math.Truncate(fecha.TimeOfDay.TotalSeconds));
            DateTime Resul = fecha.Date.Add(tiempoSinFracciones);
            return Resul.AddSeconds(-Resul.Second);
        }
        public static (DateTime FechaHora, string ZonaHoraria) ObtenerHoraWeb
        {
            get
            {
                string url = "https://worldtimeapi.org/api/ip";
                DateTime fechaHora = DateTime.Now;
                string zonaHoraria = ZonaHorariaPc;

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = client.GetAsync(url).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = response.Content.ReadAsStringAsync().Result;
                            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                            //string DatosFecha = result.datetime;

                            fechaHora = result.datetime;
                            zonaHoraria = result.utc_offset;

                            string desiredOffset = result.utc_offset; // Desplazamiento horario deseado
                            string desiredZoneName = result.timezone; // Nombre de la zona horaria deseada

                            return (fechaHora, zonaHoraria);
                        }
                        else
                        {
                            UCNotificaciones.MostrarNotifiacion("Problema con {url}", "No se pudo obtener la hora de Internet.");
                        }
                    }
                    catch
                    {
                        UCNotificaciones.MostrarNotifiacion("Problema con {url}", "No se pudo obtener la hora de Internet.");
                    }
                }
                return (fechaHora, zonaHoraria);
            }
        }


        public static string ZonaHorariaPc
        {
            get
            {
                TimeZoneInfo zonaHoraria = TimeZoneInfo.Local;
                string Zona = zonaHoraria.DisplayName;
                return Zona.Substring(4, 6);
            }
        }


        public static void CambiarConfiguracionRegional()
        {
            try
            {
                RegistryKey userRegistry = Registry.CurrentUser;
                RegistryKey intlRegistry = userRegistry.OpenSubKey(NomRegistro.PanelControl, true);

                if (intlRegistry != null)
                {
                    CultureInfo cultura = new CultureInfo(CultureInfo.CurrentCulture.Name);
                    NumberFormatInfo formatoNumerico = cultura.NumberFormat;
                    TextInfo formatoTexto = cultura.TextInfo;

                    var NumberDecimalSeparator = ".";
                    var NumberGroupSeparator = ",";
                    var ListSeparator = "|";
                    var CurrencySymbol = "Bs";

                    formatoNumerico.NumberDecimalSeparator = NumberDecimalSeparator;
                    formatoNumerico.NumberGroupSeparator = NumberGroupSeparator;
                    formatoTexto.ListSeparator = ListSeparator;
                    formatoNumerico.CurrencySymbol = CurrencySymbol;

                    intlRegistry.SetValue("sDecimal", NumberDecimalSeparator);
                    intlRegistry.SetValue("sList", ListSeparator);
                    intlRegistry.SetValue("sCurrency", CurrencySymbol);
                    intlRegistry.SetValue("sThousand", NumberGroupSeparator);


                    CultureInfo.DefaultThreadCurrentCulture = cultura;
                    CultureInfo.DefaultThreadCurrentUICulture = cultura;

                    // Reiniciar la aplicación o actualizar los controles afectados para reflejar los cambios en la configuración regional del usuario
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error al cambiar la configuración regional del usuario: " + ex.Message);
            }
        }
        public static string ObtenerConfig(string NombreKey)
        {
            string Resul = ConfigurationManager.AppSettings[NombreKey];
            if (Resul == "")
            {
                try
                {
                    Resul = Registry.GetValue(NomRegistro.ConfigLauncher, NombreKey, "") as string;
                    if (Resul == null)
                    {
                        Resul = "";
                    }

                }
                catch
                {
                    Resul = "";
                }
            }
            return Resul;
        }

        public static void VerificaAppConfig()
        {
            if (HayVaciosAppConfig())
            {
                FrmConfiguracion frm = new FrmConfiguracion();
                frm.ShowDialog();
            }
        }


        public static void ActivarHoraAutomatica()
        {
            using (var key = Registry.LocalMachine.OpenSubKey(NomRegistro.HoraAutomatica, true))
            {
                if (key != null)
                {
                    // Establece el valor de Type a "NTP" para habilitar la sincronización de hora automática
                    key.SetValue("Type", "NTP");

                    // Reinicia el servicio de hora de Windows para aplicar los cambios
                    var process = new System.Diagnostics.Process();
                    var startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "net",
                        Arguments = "stop w32time && net start w32time",
                        Verb = "runas",  // Ejecuta el comando con privilegios de administrador
                        CreateNoWindow = true,
                        WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    };
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();

                }
                else
                {
                    Console.WriteLine("No se pudo encontrar la clave de registro para la configuración de hora de Windows.");
                }
            }
        }

        public static bool AppEnEjecucion(string appName)
        {
            Process[] processes = Process.GetProcessesByName(appName);
            return processes.Length > 1;
        }

    }
}

