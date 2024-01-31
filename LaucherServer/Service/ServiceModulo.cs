using LauncherServer.GestoresLaucher;
using LauncherServer.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LauncherServer.Service
{
    public static class ModuloService
    {
        public static List<ModeloModulo> jsonToList(string rutaArchivo)
        {
            string contenidoArchivo = File.ReadAllText(rutaArchivo);
            List<ModeloModulo> listaModulos = JsonConvert.DeserializeObject<List<ModeloModulo>>(contenidoArchivo);
            return listaModulos;
        }

        public static List<ModeloModulo> getListaArchivos(string path)
        {
            List<ModeloModulo> modules = new List<ModeloModulo>();

            string[] files = GestionaArchivos.GetArchivosFiltrados(path, "*.*");

            foreach (string file in files)
            {
                //extencio del archivo
                string fileExtension = Path.GetExtension(file);

                if (fileExtension != "")
                {
                    // Nombre del archivo
                    string filePath = file.Substring(path.Length);

                    // Obtiene la version del dll  y la manda para su comparacion
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(file);
                    string fileVersion = !string.IsNullOrEmpty(fileVersionInfo.FileVersion) ? fileVersionInfo.FileVersion : "0.0.0";

                    FileInfo fileInfo = new FileInfo(file);
                    // Obtener la fecha de modificación
                    DateTime lastModified = fileInfo.LastWriteTime;

                    ModeloModulo module = new ModeloModulo()
                    {
                        Path = GestionaArchivos.removeRoot(filePath),
                        Version = fileVersion,
                        FechaModificacion = lastModified,
                        Extension = fileExtension
                    };
                    modules.Add(module);
                }

            }
            return modules;
        }

    }
}
