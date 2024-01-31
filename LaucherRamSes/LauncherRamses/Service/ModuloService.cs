using LauncherRamses.Resources.NomRecursos;
using LauncherRamses.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LauncherRamses
{
    static class ModuloService
    {
        /// <summary>Convierte la lista de modulos en un json
        /// en una ruta especifica
        /// </summary>
        public static void ListToJSON(List<ModeloModulo> modulesList, string filePath)
        {
            string json = JsonConvert.SerializeObject(modulesList);
            json = json.Replace("}", "}\n");
            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el archivo: {0}", e.Message);
            }
        }

        public static List<ModeloModulo> JsonToList(string filePath)
        {
            string contentJson = File.ReadAllText(filePath);
            List<ModeloModulo> modulesList = JsonConvert.DeserializeObject<List<ModeloModulo>>(contentJson);
            return modulesList;
        }

        public static List<ModeloModulo> modulesActualizarRMS(List<ModeloModulo> lServer, List<ModeloModulo> lUsuario)
        {
            List<ModeloModulo> LResult = new List<ModeloModulo>();

            string pathListaN = Path.Combine(GestionaArchivo.dirRecJson, NomJson.JsonListaNegra);
            List<ModeloListaNegra> LListaNegra = ListaNegraService.JsonListaNegra(pathListaN);

            foreach (ModeloModulo ArchivoServer in lServer)
            {
                if (LListaNegra.Find(m => string.Equals(m.Path, ArchivoServer.Path, StringComparison.OrdinalIgnoreCase)) == null)
                {
                    ModeloModulo ArchivoUsuario = lUsuario.Find(m => string.Equals(m.Path, ArchivoServer.Path, StringComparison.OrdinalIgnoreCase));
                    if (ArchivoUsuario != null)
                    {
                        if (ArchivoServer.FechaModificacion != ArchivoUsuario.FechaModificacion)
                        {
                            LResult.Add(ArchivoServer);
                        }
                    }
                    else
                    {
                        LResult.Add(ArchivoServer);
                    }
                }

            }
            return LResult;
        }

        public static List<ModeloModulo> modulesActualizarPDF(List<ModeloModulo> lServer, List<ModeloModulo> lUsuario)
        {
            List<ModeloModulo> LResult = new List<ModeloModulo>();
            foreach (ModeloModulo ArchivoServer in lServer)
            {
                ModeloModulo ArchivoUsuario = lUsuario.Find(m => string.Equals(m.Path, ArchivoServer.Path, StringComparison.OrdinalIgnoreCase));
                if (ArchivoUsuario != null)
                {
                    if (ArchivoServer.FechaModificacion != ArchivoUsuario.FechaModificacion)
                    {
                        LResult.Add(ArchivoServer);
                    }
                }
                else
                {
                    LResult.Add(ArchivoServer);
                }

            }
            return LResult;
        }

        public static DateTime ExtraeFecha(List<ModeloModulo> modulesServer, string nameJson)
        {
            ModeloModulo ArchivoUsuario = modulesServer.Find(m => string.Equals(m.Path, nameJson, StringComparison.OrdinalIgnoreCase));
            return ArchivoUsuario.FechaModificacion;
        }

        public static List<ModeloModulo> getListaModelo(string folderPath)
        {
            List<ModeloModulo> modules = new List<ModeloModulo>();

            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories); ;

            //Crear un escritor para mandar informacion
            //Le manda la cantidad de archivos que va a revisar para actualizar

            int contar = 0;
            int cantidad = files.Length;
            LauncherService.ActualizaTexto($"Preparando Json {folderPath}");
            // Recorre el path de cada archivo para su revision
            foreach (string file in files)
            {
                // Nombre del archivo
                string filePath = file.Substring(folderPath.Length);

                // Obtiene la version del dll  y la manda para su comparacion
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(file);
                string fileVersion = !string.IsNullOrEmpty(fileVersionInfo.FileVersion) ? fileVersionInfo.FileVersion : "0.0.0";

                //Fecha de Modificacion
                FileInfo fileInfo = new FileInfo(file);
                // Obtener la fecha de modificación
                DateTime lastModified = fileInfo.LastWriteTime;

                //Extraer la Extencion
                string fileExtension = Path.GetExtension(file);

                // Lee la accion a realizar
                // Si la accion mandada por el cliente es actualizar o crear lo manda el archivo
                ModeloModulo module = new ModeloModulo()
                {
                    Path = GestionaArchivo.removeRoot(filePath),
                    Version = fileVersion,
                    FechaModificacion = lastModified,
                    Extension = fileExtension
                };
                modules.Add(module);

                contar=+1;
                LauncherService.ActualizaProgreso(LauncherService.CalcularProgreso(contar, cantidad));

            }
            return modules;
        }

    }
}
