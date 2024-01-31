using System;
using System.Threading;
using System.Windows.Forms;
using LauncherServer.GestoresLaucher;
using LauncherServer.Presentacion;

namespace LauncherServer
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        private static Mutex mutex = new Mutex(true, "{7BDA413D-95E1-4C53-915D-111111111111}");


        [STAThread]
        [Obsolete]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                return;
            }

            if (GestionaPrivilegios.EsAdministrador)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(FrmMonitor.GetInstance());
                mutex.ReleaseMutex();
            }
            else
            {
                GestionaPrivilegios.ElevatePermissions();
            }

        }
    }
}
