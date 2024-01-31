using LauncherRamses.Presentacion.UserControll;
using LauncherRamses.Service;
using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace LauncherRamses.GestoresLauncher
{
    public static class GestionaPrivilegios
    {
        public static bool EsAdministrador
        {
            get
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public static void ElevarPrivilegios()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";

                Process.Start(startInfo);

                Application.Exit();
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        public static void ReiniciarAplicacion()
        {
            try
            {
                Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al reiniciar la aplicación: " + ex.Message);
            }

            Environment.Exit(0);
        }

        internal static void IniciaAppAdmin(string fileName)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas"; // Indica que se ejecute como administrador
            processInfo.FileName = fileName;

            try
            {
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                UCNotificaciones.MostrarNotifiacion("Problema de UpdateRms",$"Error al iniciar la aplicación como administrador: {ex.Message}" );
            }
        }
    }
}
