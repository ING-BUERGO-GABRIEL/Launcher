using LauncherRamses.Presentacion.UserControll;
using System;
using System.Windows.Forms;
using System.IO;
using LauncherRamses.Resources.NomRecursos;
using LauncherRamses.GestoresLauncher;

namespace LauncherRamses.Service
{
    public static class LauncherService
    {

        public static int CalcularProgreso(int Progreso, int Total)
        {
            int porcentaje = (Progreso * 100) / Total;
            return porcentaje;
        }

        public static void ActualizaProgreso(int progr)
        {
            UCProgressBar progreso = UCProgressBar.UserControl;
            progreso?.ActualizarProgreso(progr);
        }

        public static void ActualizaTexto(string texto)
        {
            UCProgressBar progreso = UCProgressBar.UserControl;
            progreso?.ActualizarTexto(texto);
        }

        public static void Cerrar()
        {
            Application.Exit();
            Environment.Exit(0);
        }

        internal static void EjecutaUpdate()
        {
            string pathUpdate = Path.Combine(GestionaArchivo.dirUpdate,NomCarpetas.AutoUpdate,NomApps.AutoUpdate);
            GestionaPrivilegios.IniciaAppAdmin(pathUpdate);
            Cerrar();
        }
    }
}
