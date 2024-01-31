using LauncherServer.Modelo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LauncherServer.Service
{
    public static class ServiceListaExtenciones
    {
        public static List<ModeloListaExtenciones> GetListaExtenciones(string filePath)
        {
            string contentJson = File.ReadAllText(filePath);
            List<ModeloListaExtenciones> modulesList = JsonConvert.DeserializeObject<List<ModeloListaExtenciones>>(contentJson);
            return modulesList;
        }

    }
}
