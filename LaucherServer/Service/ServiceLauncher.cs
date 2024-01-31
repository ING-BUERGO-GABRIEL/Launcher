using LauncherServer.GestoresLaucher;
using LauncherServer.Presentacion.UserControll;
using LauncherServer.Resources.NomRecursos;

namespace LauncherServer.Service
{
    public static class ServiceLauncher
    {
        public static void GenerarJson()
        {
            //Crea los Json 
            Imprime("Creando JSON Rms");
            GestionaArchivos.createJSON(GestionaArchivos.dirRms,GestionaArchivos.dirRecJsonEnviar,NomJson.JsonServerRms);
            Imprime("Creando JSON PDF");
            GestionaArchivos.createJSON(GestionaArchivos.dirPDF,GestionaArchivos.dirRecJsonEnviar, NomJson.JsonPdfRms);
        }

        public static void Imprime(string mensaje) 
        {
            UCGridViewMonitor progreso = UCGridViewMonitor.UserControl;
            progreso?.Imprime(mensaje);
        }
    }
}
