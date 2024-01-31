using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using UpdarteLauncherRms.Logica;
using UpdarteLauncherRms.Resources;

namespace UpdarteLauncherRms.Presentacion
{
    public partial class FrmActualizar : Form
    {
        public FrmActualizar()
        {
            InitializeComponent();

            if (!IsRunningAsAdmin())
            {
                RestartAsAdmin();
            }
            Actualizar();
        }

        private void Actualizar()
        {
            Actualizador actualizador = new Actualizador();

            string rutaEjecucion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaAplicacionPrincipal = Path.GetFullPath(Path.Combine(rutaEjecucion, "..\\.."));
            string AppPrincipal = Path.Combine(rutaAplicacionPrincipal, NomAplicaciones.LauncherCliente + ".exe");

            try
            {
                actualizador.CerrarAplicacion(NomAplicaciones.LauncherCliente);

                actualizador.MigrarArchivos(rutaAplicacionPrincipal);

                actualizador.ConfigurarAppConfig(rutaAplicacionPrincipal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la aplicación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                actualizador.IniciarAplicacionPrincipal(AppPrincipal);
                Cerrar();
            }
        }

        private bool IsRunningAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void RestartAsAdmin()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";
                Process.Start(startInfo);
            }
            finally
            {
                Cerrar();
            }
        }

        private void Cerrar()
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
