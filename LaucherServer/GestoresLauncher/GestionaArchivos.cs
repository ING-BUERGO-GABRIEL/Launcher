using LauncherServer.Modelo;
using LauncherServer.Resources.NomRecursos;
using LauncherServer.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace LauncherServer.GestoresLaucher
{
    public static class GestionaArchivos
    {
        public static string dirRms{ get { return ConfigurationManager.AppSettings[NomKeyConfig.DirectoryRms];} }
        public static string dirPDF{ get { return ConfigurationManager.AppSettings[NomKeyConfig.DirectoryPDF];} }
        public static string dirActual{ get {return Directory.GetCurrentDirectory();}}
        public static string dirRecJson { get { return Path.Combine(dirActual, NomCarpeta.Json); } }
        public static string dirRecJsonEnviar { get { return Path.Combine(dirActual, NomCarpeta.JsonEnviar); } }
        public static string dirUpdate { get { return Path.Combine(dirActual, NomCarpeta.UpdateCliente); } }

        public static string removeRoot(string path)
        {
            string pathWithoutDisco = path.Substring(Path.GetPathRoot(path).Length);
            return pathWithoutDisco;
        }

        private static bool IsExcludedExtension(string file)
        {
            string PathDirectorioJson = Path.Combine(dirRecJson,NomJson.ListaNegraExtenciones);

            List<ModeloListaExtenciones> ListaExten = ServiceListaExtenciones.GetListaExtenciones(PathDirectorioJson);
            string extension = Path.GetExtension(file);
            string fileExtension = extension.TrimStart('.');

            return ListaExten.Any(ext => ext.Extencion.Equals("." + fileExtension, StringComparison.OrdinalIgnoreCase));
        }


        public static void createJSON(string pathExtraer, string pathJson, string nombre)
        {

            string filePath = Path.Combine(pathJson, nombre);

            List<ModeloModulo> listaArchivos = ModuloService.getListaArchivos(pathExtraer);

            string json = JsonConvert.SerializeObject(listaArchivos);
            
            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                ServiceLauncher.Imprime(e.Message);
            }
        }

        public static void CrearArchivo(string path, string data)
        {
            try
            {
                File.WriteAllText(path, data);
            }
            catch (Exception e)
            {
                ServiceLauncher.Imprime(e.Message);
            }
        }

        public static string[] GetArchivosFiltrados(string directoryPath, string filter)
        {
            return Directory.GetFiles(directoryPath, filter, SearchOption.AllDirectories)
                            .Where(file => !IsExcludedExtension(file)).ToArray();
        }

        public static string[] GetArchivosEspecifico(string directoryPath, string nomArchivo)
        {
            return Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories)
                            .Where(file => file.EndsWith(nomArchivo))
                            .Take(1).ToArray();
        }
        public static string[] GetArchivos(string directoryPath, string filter)
        {
            return Directory.GetFiles(directoryPath, filter, SearchOption.AllDirectories);
        }

        public static string[] OrdenaArchivo(string[] filesPDF, string nomArchivo)
        {
            Array.Sort(filesPDF, (a, b) =>
            {
                if (Path.GetFileName(a) == nomArchivo)
                    return -1;
                else if (Path.GetFileName(b) == nomArchivo)
                    return 1;
                else
                    return 0;
            });
            return filesPDF;
        }
        public static bool ExisteArchivo(string pahtArchivo)
        {
            return File.Exists(pahtArchivo);
        }

        public static void CreaCopiaArchivo(string PathOrigen, string PathDestino)
        {
            byte[] data;

            createDirectory(Path.GetDirectoryName(PathDestino));
            using (FileStream fileStream = new FileStream(PathOrigen, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    int fileSize = (int)reader.BaseStream.Length;
                    data = reader.ReadBytes(fileSize);
                }
            }

            File.WriteAllBytes(PathDestino, data);
        }
        public static void createDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public static void EliminarArchivo(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                ServiceLauncher.Imprime("Archivo eliminado correctamente.");
            }
            else
            {
                ServiceLauncher.Imprime("El archivo no existe.");
            }
        }

        public static void CrearDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
        public static void OcultarDitectory(string directoryPath)
        {
            DirectoryInfo carpetaInfo = new DirectoryInfo(directoryPath);
            carpetaInfo.Attributes |= FileAttributes.Hidden;
        }

        public static bool DirecExiste(string pathDir)
        {
            return Directory.Exists(pathDir);
        }

    }
}
