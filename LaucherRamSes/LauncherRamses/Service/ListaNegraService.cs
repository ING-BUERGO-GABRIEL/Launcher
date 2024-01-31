using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LauncherRamses
{
    static class ListaNegraService
    {
        public static List<ModeloListaNegra> JsonListaNegra(string filePath)
        {
            string contentJson = File.ReadAllText(filePath);
            List<ModeloListaNegra> modulesList = JsonConvert.DeserializeObject<List<ModeloListaNegra>>(contentJson);
            return modulesList;
        }
    }
}
