using LauncherRamses.Presentacion;
using LauncherRamses.Resources;
using LauncherRamses.Resources.NomRecursos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LauncherRamses
{
    static class GestionaArchivo
    {

        public static string dirRms{ get { return Path.Combine(dirActual,NomCarpetas.dirRamses); } }
        public static string dirActual { get { return Directory.GetCurrentDirectory(); } }
        public static string dirPDF{get{return ConfigurationManager.AppSettings[NomKey.DirectoryPDF]; } }
        public static string dirRecJson { get { return Path.Combine(dirActual, NomCarpetas.RecJson); } }
        public static string dirUpdate { get { return Path.Combine(dirActual, NomCarpetas.DirUpdate); } }

        public static void CreaCopiaArchivo(string path)
        {
            string copyFile = path.Substring(0, path.Length - 4) + "_copia.dll";
            File.Delete(copyFile);
            File.Copy(path, copyFile);
        }
        public static void BorraArchivo(string path)
        {
            File.Delete(path);
        }
        public static string removeRoot(string path)
        {
            string pathWithoutDisco = path.Substring(Path.GetPathRoot(path).Length);
            return pathWithoutDisco;
        }

        public static void CreaArchivoModif(BinaryReader reader, ModeloModulo MArchivo, string Path ="")
        {
            int fileSize = reader.ReadInt32();
            byte[] data = reader.ReadBytes(fileSize);
            string pahtArchivo;
            if(Path!="")
            {
                pahtArchivo = Path;
            }
            else
            {
                pahtArchivo = MArchivo.Path;
            }
            File.WriteAllBytes(pahtArchivo, data);
            File.SetLastWriteTime(pahtArchivo, MArchivo.FechaModificacion);
        }

        public static void CreaArchivo(ref BinaryReader reader, string ArchivoPath)
        {
            int fileSize = reader.ReadInt32();
            byte[] data = reader.ReadBytes(fileSize);
            File.WriteAllBytes(ArchivoPath, data);
        }

        public static void CreaModif(ref BinaryReader reader, string ArchivoPath, DateTime FechaModf)
        {
            int fileSize = reader.ReadInt32();
            byte[] data = reader.ReadBytes(fileSize);
            File.WriteAllBytes(ArchivoPath, data);
            File.SetLastWriteTime(ArchivoPath, FechaModf);
        }


        public static void createJson(string pathExtraer,string dirJson,string NomJson)
        {

            List<ModeloModulo> listaModulos = ModuloService.getListaModelo(pathExtraer);

            string json = JsonConvert.SerializeObject(listaModulos);


            string filePath = Path.Combine(dirJson, NomJson);
            try
            {
                File.WriteAllText(filePath, json);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el archivo: {0}", e.Message);
            }
        }

        public static List<ModeloModulo> createJsonPdf()
        {
            List<ModeloModulo> listaMPDF = ModuloService.getListaModelo(dirPDF);

            string json = JsonConvert.SerializeObject(listaMPDF);
            string filePath = Path.Combine(dirPDF, NomJson.JsonUerPDF);
            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el archivo: {0}", e.Message);
            }
            return listaMPDF;
        }
        public static void createDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public static bool ExisteArchivo(string NomArchivo)
        {
           return File.Exists(NomArchivo);
        }

        public static string CreaDirectorio(string directoryPDF, string file)
        {
            string directoryFile = Path.GetDirectoryName(file);
            string directoryPath = Path.Combine(directoryPDF, directoryFile.Substring(1));
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return directoryPath;
        }

        public static void CrearDirectorio(string directoryPath)
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
    }
}
