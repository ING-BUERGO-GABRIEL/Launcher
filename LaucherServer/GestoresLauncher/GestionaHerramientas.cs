using LauncherServer.Modelo;
using LauncherServer.Resources.NomRecursos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace LauncherServer.GestoresLauncher
{
    public static class GestionaHerramientas
    {
        public static string  ExtraerIps(CheckedListBox listIp)
        {
            string ips = "";
            int count = listIp.CheckedItems.Count;

            foreach (string ip in listIp.CheckedItems)
            {
                ips += ip;
                if (count > 1)
                {
                    ips += "|";
                }
                count--;
            }

            return ips;
        }

        public static List<string> ConvertirLista(string lista)
        {
            List<string> ipsLocales = lista.Split('|').ToList();
            return ipsLocales;
        }


        public static ModeloVersionClient GetVersionClient()
        {
            //Ruta de Aplicaciones
            string pathCliente = Path.Combine(NomCarpeta.AppCliente, NomJson.ExeCliente);
            string pathUpdate = Path.Combine(NomCarpeta.AppUpdate, NomJson.ExeUpdate);
            //Extraer version
            FileVersionInfo verClinete = FileVersionInfo.GetVersionInfo(pathCliente);
            FileVersionInfo verUpdate = FileVersionInfo.GetVersionInfo(pathUpdate);

            ModeloVersionClient versionClient = new ModeloVersionClient
            {
                VCliente = new Version(verClinete.FileVersion),
                VUpdate = new Version(verUpdate.FileVersion)
            };
            return versionClient;
        }
    }
}
