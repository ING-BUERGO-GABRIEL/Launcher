using LauncherServer.Presentacion;
using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace LauncherServer.GestoresLaucher
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

        public static void EjecutarBathAdministrador(string appPath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c \"{appPath}\"";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }

        public static void ElevatePermissions()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";

                Process.Start(startInfo);

                FrmConfiguracion frm = FrmConfiguracion.UserControl;
                frm?.SetResultado(false);
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
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";
                Process.Start(startInfo);
                Environment.Exit(0);
            }
            catch (Exception)
            {
                // Manejar cualquier excepción si ocurre
            }
        }

    }
}
