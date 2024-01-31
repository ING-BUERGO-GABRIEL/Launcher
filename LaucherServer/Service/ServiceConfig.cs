using LauncherServer.GestoresLaucher;
using System;
using System.IO;
using LauncherServer.Presentacion;
using LauncherServer.Resources.NomRecursos;

namespace LauncherServer.Service
{
    public static class ServiceConfig
    {
        public static void ConfiguraPuertos()
        {
            try
            {
                if (GestionaConfig.ExistenReglasDeEntradaFirewall(NomJson.NomReglaUDP) && GestionaConfig.ExistenReglasDeEntradaFirewall(NomJson.NomReglaTCP))
                {
                    string PathPuertoUDP = GestionaConfig.ObtenerPathReglaFirewall(NomJson.NomReglaUDP);
                    string PathPuertoTCP = GestionaConfig.ObtenerPathReglaFirewall(NomJson.NomReglaTCP);
                    string PathAplicacion = Path.Combine(GestionaArchivos.dirActual, NomJson.NomProyecto);
                    if (!PathPuertoUDP.Equals(PathAplicacion, StringComparison.OrdinalIgnoreCase) ||
                        !PathPuertoTCP.Equals(PathAplicacion, StringComparison.OrdinalIgnoreCase))
                    {
                        GestionaConfig.EjecutaBAT(NomJson.NomReglaBat);
                    }
                }
                else
                {
                    GestionaConfig.EjecutaBAT(NomJson.NomReglaBat);
                }
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime("Problema al actualizar o crear puertos");
                ServiceLauncher.Imprime(ex.Message);
            }
        }
        public static void VerificaAppConfig()
        {
            try
            {
                if (GestionaConfig.HayVaciosAppConfig())
                {
                    FrmConfiguracion frm = new FrmConfiguracion();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime("Problema al Congigurar archivo .Config");
                ServiceLauncher.Imprime(ex.Message);
            }
        }


        public static void VerificaListaNegra()
        {
            // PreparaCarpetasRms();
            try
            {
                string pathDestino = Path.Combine(GestionaArchivos.dirRecJsonEnviar, NomJson.JsonListaNegra);
                string pathOrigen;
                if (!GestionaArchivos.ExisteArchivo(pathDestino))
                {
                    pathOrigen = Path.Combine(GestionaArchivos.dirRecJson, NomJson.JsonListaNegra);
                    GestionaArchivos.CreaCopiaArchivo(pathOrigen, pathDestino);
                }

                pathDestino = Path.Combine(GestionaArchivos.dirRecJsonEnviar, NomJson.ListaNegraExtenciones);
                if (!GestionaArchivos.ExisteArchivo(pathDestino))
                {
                    pathOrigen = Path.Combine(GestionaArchivos.dirRecJson, NomJson.ListaNegraExtenciones);
                    GestionaArchivos.CreaCopiaArchivo(pathOrigen, pathDestino);
                }
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime("Problema con archivo de lista_negra o lista_extrenciones");
                ServiceLauncher.Imprime(ex.Message);
            }
        }

        /*   public static void PreparaCarpetasRms()
           {
               //GestionaArchivos.CrearDirectory(GestionaArchivos.dirRecRmsJson);

               //GestionaArchivos.OcultarDitectory(GestionaArchivos.dirBinRms);
           }*/
    }
}
