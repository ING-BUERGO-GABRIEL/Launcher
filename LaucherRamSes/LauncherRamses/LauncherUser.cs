using System;
using System.Collections.Generic;
using System.IO;
using LauncherRamses.TCP;
using LauncherRamses.Presentacion.UserControll;
using LauncherRamses.Service;
using LauncherRamses.Modelo.TCP;
using LauncherRamses.Resources.NomRecursos;
using LauncherRamses.Modelo;
using LauncherRamses.GestoresLauncher;
using Newtonsoft.Json;

namespace LauncherRamses
{
    class LauncherUser
    {
        public void SincronizarServer()
        {
            try
            {
                ConexionServer();

                SincronizaJson();

                string PathJsonRms = Path.Combine(GestionaArchivo.dirRecJson, NomJson.JsonServerRms);

                if (GestionaArchivo.ExisteArchivo(PathJsonRms))
                {
                    GestionaArchivo.CrearDirectorio(GestionaArchivo.dirRms);
                    UpdateRamses(ModuloService.getListaModelo(GestionaArchivo.dirRms));
                }
                else
                {
                    UCNotificaciones.MostrarNotifiacion("Json Inexixtente", "El archivo " + NomJson.JsonServerRms + " no se encontro");
                }

                string PathJsonPDF = Path.Combine(GestionaArchivo.dirRecJson, NomJson.JsonServerPDF);

                if (GestionaArchivo.ExisteArchivo(PathJsonPDF))
                {
                    GestionaArchivo.CrearDirectorio(GestionaArchivo.dirPDF);
                    UpdatePDF(ModuloService.getListaModelo(GestionaArchivo.dirPDF));
                }
                else
                {
                    UCNotificaciones.MostrarNotifiacion("Json Inexixtente", "El archivo " + NomJson.JsonUerPDF + " no se encontro");
                }

            }
            catch (Exception e)
            {
                UCNotificaciones.MostrarNotifiacion("Excepcion", e.Message);
            }
            finally
            {
                RamsesService.ejecutarRamses();
            }
        }

        private void SincronizaJson()
        {
            try
            {
                using (TcpComunica tcp = new TcpComunica())
                {
                    var stream = tcp.GetStream();
                    string response = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor(MsjTCP.ExtraerJson);

                    BinaryReader reader = new BinaryReader(stream);
                    int numFiles = reader.ReadInt32();

                    tcp.enviaMsjServidor("Recibi la cantidad " + numFiles);

                    string pathJson = GestionaArchivo.dirRecJson;

                    for (int i = 0; i < numFiles; i++)
                    {
                        string file = tcp.ExtraeArchivo();

                        string directoryFile = Path.GetDirectoryName(file);
                        string directoryPath = Path.Combine(pathJson, directoryFile.Substring(1));
                        string fileName = Path.GetFileName(file);
                        tcp.enviaMsjServidor(directoryFile + "\\" + fileName);
                        Console.WriteLine("Sincroniza Json: " + directoryFile + "\\" + fileName);

                        GestionaArchivo.createDirectory(directoryPath);

                        string pahtArchivo = Path.Combine(pathJson, file.Substring(1));
                        string nomArchivo = Path.GetFileName(file);
                        GestionaArchivo.CreaArchivo(ref reader, pahtArchivo);

                        LauncherService.ActualizaProgreso(LauncherService.CalcularProgreso(i, numFiles));
                        LauncherService.ActualizaTexto("Sincroniza Json: " + directoryFile + "\\" + fileName);
                    }              
                }
            }
            catch (Exception e)
            {
                UCNotificaciones.MostrarNotifiacion("Excepcion", e.Message);
            }
        }

        private void UpdateRamses(List<ModeloModulo> modulesUser)
        {
            try
            {
                using (TcpComunica tcp = new TcpComunica())
                {
                    var stream = tcp.GetStream();
                    string response = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor(MsjTCP.ActualizaRms);

                    BinaryReader reader = new BinaryReader(stream);
                    int numFiles = reader.ReadInt32();

                    tcp.enviaMsjServidor("Cantidad recibida");

                    //Nombre de JSON
                    string nameJson = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor("JSON Recibido:" + nameJson);

                    int fileSize = reader.ReadInt32();
                    byte[] data = reader.ReadBytes(fileSize);

                    string PathJonServer = Path.Combine(GestionaArchivo.dirRecJson, Path.GetFileName(nameJson));

                    List<ModeloModulo> modulesServer = ModuloService.JsonToList(PathJonServer);

                    List<ModeloModulo> modulesWillUpdate = ModuloService.modulesActualizarRMS(modulesServer, modulesUser);

                    int cantidadActualizar = modulesWillUpdate.Count;
                    tcp.enviaMsjServidor(cantidadActualizar.ToString());

                    string mensaje = tcp.recibeMsjServidor();
                    int contar = 0;
                    foreach (ModeloModulo MArchivo in modulesWillUpdate)
                    {
                        tcp.enviaMsjServidor(GestionaArchivo.removeRoot(MArchivo.Path));

                        string directoryPath = Path.Combine(GestionaArchivo.dirRms, Path.GetDirectoryName(MArchivo.Path));
                        string pahtArchivo = Path.Combine(GestionaArchivo.dirRms, MArchivo.Path);

                        GestionaArchivo.createDirectory(directoryPath);
                        GestionaArchivo.CreaArchivoModif(reader, MArchivo, pahtArchivo);

                        contar++;
                        LauncherService.ActualizaProgreso(LauncherService.CalcularProgreso(contar, cantidadActualizar));
                        LauncherService.ActualizaTexto("Actualizando Rms: " + MArchivo.Path);
                    }

                }

            }
            catch (Exception e)
            {
                UCNotificaciones.MostrarNotifiacion("Excepcion", e.Message);
            }
        }

        private void UpdatePDF(List<ModeloModulo> modulesUserPDF)
        {
            try
            {
                using (TcpComunica tcp = new TcpComunica())
                {
                    var stream = tcp.GetStream();
                    string response = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor(MsjTCP.ActualizaPdf);

                    BinaryReader reader = new BinaryReader(stream);
                    int numFiles = reader.ReadInt32();

                    tcp.enviaMsjServidor("Cantidad recibida");

                    //Nombre de JSON
                    string nameJson = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor("JSON Recibido :" + nameJson);

                    int fileSize = reader.ReadInt32();
                    byte[] data = reader.ReadBytes(fileSize);

                    string PathJsonPdf = Path.Combine(GestionaArchivo.dirRecJson, Path.GetFileName(nameJson));

                    List<ModeloModulo> modulesServerPDF = ModuloService.JsonToList(PathJsonPdf);

                    List<ModeloModulo> modulesActualizar = ModuloService.modulesActualizarPDF(modulesServerPDF, modulesUserPDF);

                    int cantidadActualizar = modulesActualizar.Count;

                    tcp.enviaMsjServidor(cantidadActualizar.ToString());

                    string mensaje = tcp.recibeMsjServidor();
                    int contar = 0;
                    foreach (ModeloModulo MArchivo in modulesActualizar)
                    {
                        tcp.enviaMsjServidor(GestionaArchivo.removeRoot(MArchivo.Path));
                        string directoryPath = Path.Combine(GestionaArchivo.dirPDF, Path.GetDirectoryName(MArchivo.Path));
                        string pahtArchivo = Path.Combine(GestionaArchivo.dirPDF, MArchivo.Path);
                        GestionaArchivo.createDirectory(directoryPath);
                        GestionaArchivo.CreaArchivoModif(reader, MArchivo, pahtArchivo);

                        contar++;
                        LauncherService.ActualizaProgreso(LauncherService.CalcularProgreso(contar, cantidadActualizar));
                        LauncherService.ActualizaTexto("Acualizando PDF: " + pahtArchivo);
                    }
                    
                }

            }
            catch (Exception e)
            {
                UCNotificaciones.MostrarNotifiacion("Excepcion", e.Message);
            }
        }

        private void ConexionServer()
        {
            try
            {
                using (TcpComunica tcp = new TcpComunica())
                {
                    var stream = tcp.GetStream();
                    string RespServidor = tcp.recibeMsjServidor();

                    tcp.enviaMsjServidor(MsjTCP.PruebaConex);

                    RespServidor = tcp.recibeMsjServidor();

                    ModeloMaquina MoMAquina = new ModeloMaquina
                    {
                        IdMaquina = GestionaMaquina.ObtenerIdMaquina(),
                        Estado = GestionaMaquina.Estado
                    };

                    string Json = JsonConvert.SerializeObject(MoMAquina);

                    tcp.enviaMsjServidor(Json);

                    string msjServer = tcp.recibeMsjServidor();
                    ModeloVersionClient vClinete = JsonConvert.DeserializeObject<ModeloVersionClient>(msjServer);

                    if (GestionaMaquina.ValidaVersion(vClinete))
                    {
                        tcp.enviaMsjServidor(MsjTCP.Actualizar);

                        BinaryReader reader = new BinaryReader(stream);
                        int cantidadElementos = reader.ReadInt32();

                        tcp.enviaMsjServidor("Listo para actualizar");
                 
                        int contar = 0;
                        for (int i = 0; i < cantidadElementos; i++)
                        {
                            string pathArchivo = tcp.recibeMsjServidor();
                            string pathFinal = GestionaArchivo.dirUpdate + pathArchivo;
          
                            tcp.enviaMsjServidor(pathArchivo);
                            
                            GestionaArchivo.createDirectory(Path.GetDirectoryName(pathFinal));
                            GestionaArchivo.CreaArchivo(ref reader, pathFinal);

                            contar++;
                            LauncherService.ActualizaProgreso(LauncherService.CalcularProgreso(contar, cantidadElementos));
                            LauncherService.ActualizaTexto($"Acualizando PDF: {pathArchivo}");
                        }
                        LauncherService.EjecutaUpdate();
                    }
                    else
                    {
                        tcp.enviaMsjServidor("Termina comunicacion");
                    }
                }
            }
            catch (Exception e)
            {
                UCNotificaciones.MostrarNotifiacion("Excepcion", e.Message);
            }
        }
    }
}