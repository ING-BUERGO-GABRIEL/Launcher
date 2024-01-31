using Microsoft.Win32;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UpdarteLauncherRms.Resources;

namespace UpdarteLauncherRms.Logica
{
    internal class Actualizador
    {
        public Actualizador()
        { 

        }
        public void CerrarAplicacion(string nombreApp)
        {
            Process[] procesos = Process.GetProcessesByName(nombreApp);

            foreach (Process proceso in procesos)
            {
                try
                {
                    if (!proceso.HasExited)
                    {
                        proceso.Kill(); 
                        proceso.WaitForExit(); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cerrar proceso: {ex.Message}");
                }
            }
        }

        public void MigrarArchivos(string rutaAplicacion)
        {
            string rutaActualizacion = Path.Combine(rutaAplicacion, NomCarpetas.Actualizar);

            CopiarArchivosRecursivamente(rutaActualizacion, rutaAplicacion);
        }

        private void CopiarArchivosRecursivamente(string origen, string destino)
        {
            foreach (string dirPath in Directory.GetDirectories(origen, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(origen, destino));
            }

            foreach (string newPath in Directory.GetFiles(origen, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(origen, destino), true);
            }
        }
        public void ConfigurarAppConfig(string rutaAplicacionPrincipal)
        {
            // Obtener la ruta del archivo de configuración de la aplicación principal
            string rutaConfiguracion = Path.Combine(rutaAplicacionPrincipal, NomAplicaciones.LauncherCliente+".exe.config");

            // Obtener las claves y valores del registro
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(NomRegistro.ConfigLauncher))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    // Cargar el archivo de configuración
                    ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                    configFileMap.ExeConfigFilename = rutaConfiguracion;
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

                    // Actualizar las claves y valores en el archivo de configuración
                    foreach (string valueName in valueNames)
                    {
                        if (config.AppSettings.Settings.AllKeys.Contains(valueName))
                        {
                            string value = key.GetValue(valueName).ToString();
                            config.AppSettings.Settings[valueName].Value = value;
                        }
                    }

                    // Guardar los cambios en el archivo de configuración
                    config.Save(ConfigurationSaveMode.Modified);
                }
            }
        }
        public void IniciarAplicacionPrincipal(string rutaAplicacion)
        {
            try
            {
                if (!string.IsNullOrEmpty(rutaAplicacion))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = rutaAplicacion,
                        Verb = "runas" // Esto indica que se debe ejecutar como administrador
                    };

                    Process.Start(startInfo);
                }
                else
                {
                    // No se pudo obtener la ruta de la aplicación principal, maneja el error.
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra al intentar iniciar la aplicación principal.
            }
        }

    }
}
