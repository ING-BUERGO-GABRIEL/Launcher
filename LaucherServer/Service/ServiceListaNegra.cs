using LauncherServer.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherServer.Service
{
    public static class ServiceListaNegra
    {
        public static List<ModeloListaNegra> JsonToList(string filePath)
        {
            string contentJson = File.ReadAllText(filePath);
            List<ModeloListaNegra> modulesList = JsonConvert.DeserializeObject<List<ModeloListaNegra>>(contentJson);
            return modulesList;
        }

        public static List<ModeloListaNegra> AgregarItem(List<ModeloListaNegra> ListaNegra, string Item)
        {
            if (ListaNegra.Find(m => string.Equals(m.Path, Item, StringComparison.OrdinalIgnoreCase)) == null)
            {
                ModeloListaNegra Adiciona = new ModeloListaNegra {Path = Item};
                ListaNegra.Add(Adiciona);
            }
            return ListaNegra;
        }
    }
}
