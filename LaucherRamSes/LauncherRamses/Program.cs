using LauncherRamses.GestoresLauncher;
using LauncherRamses.Resources.NomRecursos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherRamses
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!GestionaConfig.AppEnEjecucion(NomApps.ProyectoActual))
            {
                if (GestionaPrivilegios.EsAdministrador)
                {
                    IniciarApp();
                }
                else
                {
                    GestionaPrivilegios.ElevarPrivilegios();
                }
            }
            else
            {
                IniciarApp();
            }
        }

        public static void IniciarApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmActualizacion());
        
        }

    }
}
