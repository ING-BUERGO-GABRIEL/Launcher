using LauncherRamses.Modelo;
using LauncherRamses.Presentacion.MensajeBox;
using System;
using System.Diagnostics;
using System.Management;
using System.Reflection;
using System.Windows.Forms;

namespace LauncherRamses.GestoresLauncher
{
    public static class GestionaMaquina
    {
        public static string Estado { get; set; } = "Desbloqueado";

        public static void Bloquear(ModeloTiempo.Minutos tiempoModelo)
        {
           // tiempoRestante = 30;// (int)tiempoModelo.ValorTiempo * 60; // Convertir minutos a segundos
            Form frm = new FrmMensaje(" Actualizacion","Actualizacion en curso Ramses se detendra en",10);
            frm.FormClosed += Evento_CerrarMensaje;
            frm.ShowDialog();
        }

        private static void Evento_CerrarMensaje(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Ramses se ha desbloqueado", "Advertencia");
            Estado = "Desbloqueado";
            // Resto del código
        }

        public static void Bloc()
        {
            MessageBox.Show("funciona","titulo");
        }

        public static string ObtenerIdMaquina()
        {
            string informacionMaquina = string.Empty;

            // Consulta para obtener la información de la placa base
            string query = "SELECT Product, SerialNumber FROM Win32_BaseBoard";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            foreach (ManagementObject mo in searcher.Get())
            {
                string producto = mo["Product"].ToString();
                string idMaquina = mo["SerialNumber"].ToString();

                informacionMaquina = $"{producto} - {idMaquina}";
                break; // Obtén solo el primer resultado (placa base)
            }

            return informacionMaquina;
        }

        public static string VersionCli()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion;
        }

        internal static bool ValidaVersion(ModeloVersionClient vClinete)
        {
            Version vCli = new Version(VersionCli());
            Version vCli2 = vClinete.VCliente;
            return vCli != vCli2;
        }
    }
}
 