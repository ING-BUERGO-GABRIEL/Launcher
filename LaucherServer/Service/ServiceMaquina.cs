using LauncherServer.GestoresLaucher;
using LauncherServer.Modelo;
using LauncherServer.Resources.NomRecursos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace LauncherServer.Service
{
    public static class ServiceMaquina
    {
        public static List<ModeloMaquina> ListaMaquinas = ListarMaquinas();

        public static DataTable ListaMaquina = ConvertirADataTable(ListaMaquinas);

        public static string PathListaCli
        {
            get
            {
                return Path.Combine(GestionaArchivos.dirRecJson, NomJson.ClientesMaquina);
            }
        }

        public static List<ModeloMaquina> ListarMaquinas()
        {
            List<ModeloMaquina> ListM = new List<ModeloMaquina>();
            
            if (GestionaArchivos.ExisteArchivo(PathListaCli))
            {
                ListM = JsonToList(PathListaCli);
            }

            return ListM;
        }

        public static List<ModeloMaquina> JsonToList(string filePath)
        {
            string contentJson = File.ReadAllText(filePath);
            List<ModeloMaquina> modulesList = JsonConvert.DeserializeObject<List<ModeloMaquina>>(contentJson);
            return modulesList;
        }

        public static void ActualizaMaquina(ModeloMaquina maquina)
        {
            bool existe = false;
            int cont =0;
            foreach (DataRow fila in ListaMaquina.Rows)
            {
                if (string.Equals(fila["Maquina"].ToString(), maquina.IdMaquina, StringComparison.OrdinalIgnoreCase))
                {
                    ListaMaquinas[cont] = maquina;
                    fila["IP"] = maquina.IpCLiente;
                    fila["Maquina"] = maquina.IdMaquina;
                    fila["Estado"] = maquina.Estado;
                    fila["HoraConexion"] = maquina.HoraConex;
                    fila["VerLauncher"] = maquina.VersionCl.ToString();
                    existe =true;
                    break;
                }
                cont++;
            }
            if (!existe)
            {
                ListaMaquinas.Add(maquina);
                ListaMaquina.Rows.Add(ConvetDataRow(maquina));
            }
            ActualizaJson(ListaMaquinas);
        }

        private static DataRow ConvetDataRow(ModeloMaquina maquina)
        {
            DataRow resul = ListaMaquina.NewRow();
            resul["IP"] = maquina.IpCLiente;
            resul["Maquina"] = maquina.IdMaquina;
            resul["Estado"] = maquina.Estado;
            resul["HoraConexion"] = maquina.HoraConex;
            resul["VerLauncher"] = maquina.VersionCl.ToString();
            return resul;
        }

        public static void ActualizaJson(List<ModeloMaquina> Lista)
        {
            string json = JsonConvert.SerializeObject(Lista);

            try
            {
                File.WriteAllText(PathListaCli, json);
            }
            catch (Exception e)
            {
                ServiceLauncher.Imprime(e.Message);
            }
        }

        public static DataTable ConvertirADataTable(List<ModeloMaquina> lista)
        {
            // Crea un DataTable con las columnas correspondientes
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("IP", typeof(string));
            dataTable.Columns.Add("Maquina", typeof(string));
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("HoraConexion", typeof(DateTime));
            dataTable.Columns.Add("VerLauncher", typeof(string));

            // Llena el DataTable con los datos de la lista
            foreach (var modelo in lista)
            {
                string version= modelo.VersionCl != null ? modelo.VersionCl.ToString(): "";
                dataTable.Rows.Add(modelo.IpCLiente,
                    modelo.IdMaquina, modelo.Estado,
                    modelo.HoraConex, version);
            }

            return dataTable;
        }
    }
}
