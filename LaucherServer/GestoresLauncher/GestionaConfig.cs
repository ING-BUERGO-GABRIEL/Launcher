using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using LauncherServer.Modelo;
using LauncherServer.Resources.NomRecursos;
using Microsoft.Win32;
using NetFwTypeLib;
using System.Collections;
using System.Resources;
using System.Security.Cryptography;
using System.Text;

namespace LauncherServer.GestoresLaucher
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

        public static void EjecutaBAT(string nonBat)
        {     
            string appPathDestino = Path.Combine(GestionaArchivos.dirActual, nonBat );
            GestionaPrivilegios.EjecutarBathAdministrador(appPathDestino);
        }

        public static string ObtenerPathReglaFirewall(string nomRegla)
        {
            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(type);
            INetFwRules rules = fwPolicy2.Rules;

            foreach (INetFwRule rule in rules)
            {
                if (rule.Name == nomRegla)
                {
                    return rule.ApplicationName;
                }
            }

            return string.Empty;
        }



        public static void ModificarAppConfig(string NombreKey, string valor)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = config.AppSettings.Settings;

            if (appSettings[NombreKey] != null)
            {
                appSettings[NombreKey].Value = valor;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                Registry.SetValue(NomJson.PathRegistro, NombreKey, valor);
            }
            else
            {
                MessageBox.Show("La clave '"+NombreKey+"' no existe en el archivo app.config.", "Error");
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

        public static bool EsDireccionIPv4Valida(string ipv4)
        {
            string[] octetos = ipv4.Split('.');
            if (octetos.Length != 4)
            {
                return false;
            }

            foreach (string octeto in octetos)
            {
                if (!byte.TryParse(octeto, out byte valorOcteto))
                {
                    return false;
                }
            }

            return true;
        }

        public static string ObtenerConfig(string NombreKey)
        {
            string Resul = ConfigurationManager.AppSettings[NombreKey];
            if (Resul=="")
            {
                Resul = Registry.GetValue(NomJson.PathRegistro, NombreKey, "") as string;
                if (Resul == null)
                {
                    Resul = "";
                }
            }
            return Resul;            
        }

        public static ModeloConexion ConexionRms()
        {
            ModeloConexion conect = new ModeloConexion();
            var resourceFile = @"E:\Trabajo\AEG Ingenieria\Librerias\Rms.resx";

            using (var reader = new ResourceReader(resourceFile))
            {
                foreach (DictionaryEntry entry in reader)
                {
                    string key = entry.Key.ToString();
                    switch (key)
                    {
                        case "Gest":
                            conect.Gestor= entry.Value.ToString();
                            break;
                        case "Serv":
                            conect.Servidor = entry.Value.ToString();
                            break;
                        case "Accu":
                            conect.Usuario = DesenCriptarFinal(entry.Value.ToString());
                            break;
                        case "Accp":
                            conect.Password = DesenCriptarFinal(entry.Value.ToString());
                            break;
                        case "Bdts":
                            conect.IdMaquina = DesenCriptarFinal(entry.Value.ToString());
                            break;
                        default:
                            break;
                    }

                }
            }
            return conect;
        }

        private static string DesenCriptarFinal(string DesEncrip)
        {
            string pllave = "RamSes el mejor ERP";
            var arllave = new PasswordDeriveBytes(pllave, null).GetBytes(32);

            var desen = Convert.FromBase64String(DesEncrip);
            var result = Desencriptar(desen, arllave);

            return result;
        }

        private static string Desencriptar(byte[] DesEncrip, byte[] llave)
        {
            var enc = new RijndaelManaged();
            var encriptado = new byte[DesEncrip.Length - enc.IV.Length];
            var tempArray = new byte[enc.IV.Length];
            var resultado = string.Empty;

            enc.Key = llave;
            Array.Copy(DesEncrip, tempArray, tempArray.Length);
            Array.Copy(DesEncrip, tempArray.Length, encriptado, 0, encriptado.Length);
            enc.IV = tempArray;

            resultado = Encoding.GetEncoding(1252).GetString(
                enc.CreateDecryptor().TransformFinalBlock(encriptado, 0, encriptado.Length));

            return resultado;
        }

    }
}
