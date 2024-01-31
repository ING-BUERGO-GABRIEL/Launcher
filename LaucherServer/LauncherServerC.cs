using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using LauncherServer.GestoresLaucher;
using LauncherServer.TCP;
using LauncherServer.Service;
using LauncherServer.Modelo.TCP;
using LauncherServer.Resources.NomRecursos;
using LauncherServer.Modelo;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;
using LauncherServer.GestoresLauncher;
using System.Runtime.InteropServices;

namespace LauncherServer
{
    public class LauncherServerC
    {
        private static LauncherServerC _Instance;

        private string ipCliente;
        public LauncherServerC()
        {
            _Instance = this;
            ipCliente = "";
        }

        [Obsolete]
        public static LauncherServerC GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new LauncherServerC();
            }
            return _Instance;
        }

        //[Obsolete]
        //public async Task runServer()
        //{
        //    //await ExtraerJson();
        //    TcpListener listener = null;
        //    while (true)
        //    {
        //        try
        //        {
        //            string ipLocal = ConfigurationManager.AppSettings["iplocal"];
        //            IPAddress ipAddress = IPAddress.Parse(ipLocal);

        //            using (TcpComunica tcp = new TcpComunica(ipAddress))
        //            {
        //                LauncherService.Imprime("Servidor Iniciado");
        //                listener = tcp.GetListener();
        //                List<TcpClient> tcpClients = tcp.GetTcpClientes();
        //                TcpClient client = await listener.AcceptTcpClientAsync();
        //                tcpClients.Add(client);
        //                Thread thread = new Thread(async () => await HandleClient(client));
        //                thread.Start();
        //                LauncherService.Imprime("Cliente desconectado");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            LauncherService.Imprime(ex.ToString());
        //            LauncherService.Imprime("Excepción el metodo: runServer");
        //            LauncherService.Imprime("Línea de código: " + ex.StackTrace);
        //        }
        //        finally
        //        {
        //            LauncherService.Imprime("Proceso Finalizado");
        //            listener.Stop();
        //        }
        //    }
        //}
        [Obsolete]
        public async Task RunServer(List<string> ipsLocales)
        {
            try
            {
                List<Task> tasks = new List<Task>();

                Parallel.ForEach(ipsLocales, async (ipLocal) =>
                {
                    IPAddress ipAddress = IPAddress.Parse(ipLocal);

                    using (TcpComunica tcp = new TcpComunica(ipAddress))
                    {
                        ServiceLauncher.Imprime("Servidor Iniciado en IP: " + ipLocal);
                        TcpListener listener = tcp.GetListener();
                        List<TcpClient> tcpClients = tcp.GetTcpClientes();

                        while (true)
                        {
                            TcpClient client = await listener.AcceptTcpClientAsync();
                            tcpClients.Add(client);

                            Task task = Task.Run(async () => await HandleClient(client));
                            tasks.Add(task);
                        }
                    }
                });

                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción en el método: runServer");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace);
            }
            finally
            {
                ServiceLauncher.Imprime("Proceso Finalizado");
            }
        }


        public async Task HandleClient(TcpClient Client)
        {
            try
            {
                using (TcpComunica tcp = new TcpComunica(Client))
                {
                    ipCliente = tcp.ObtenerDireccionIPCliente();
                    await tcp.enviaMsjAsync("Conectado");
                    string MsjCliente = await tcp.recibeMsjAsync();
                    ServiceLauncher.Imprime(MsjCliente);
                    if (MsjCliente == MsjTCP.ExtraerJson)
                    {
                        await ExtraerJson(tcp);
                    }
                    else if (MsjCliente == MsjTCP.ActualizaRms)
                    {
                        await UpdateRamses(tcp);
                    }
                    else if (MsjCliente == MsjTCP.ActualizaPdf)
                    {
                        await UpdatePDF(tcp);
                    }
                    else if (MsjCliente == MsjTCP.PruebaConex)
                    {
                        await ConectandoCliente(tcp);
                    }
                }
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ipCliente);
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción Metodo: HandleClient");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace);
            }
        }

        private async Task ConectandoCliente(TcpComunica tcp)
        {
            try
            {
                await tcp.enviaMsjAsync("Conexion Correcta");
                string msjCliente = await tcp.recibeMsjAsync();

                //Recive info Maquina
                ModeloMaquina Maquina = JsonConvert.DeserializeObject<ModeloMaquina>(msjCliente);
                Maquina.IpCLiente = tcp.ObtenerDireccionIPCliente();
                ServiceMaquina.ActualizaMaquina(Maquina);

                //Estraer Version  cliente
                ModeloVersionClient mVersionClinet = GestionaHerramientas.GetVersionClient();
                msjCliente = JsonConvert.SerializeObject(mVersionClinet);

                await tcp.enviaMsjAsync(msjCliente);

                msjCliente = await tcp.recibeMsjAsync();
                ServiceLauncher.Imprime(msjCliente);

                if (msjCliente==MsjTCP.Actualizar)
                {
                    NetworkStream stream = tcp.GetStream();
                    string[] files = GestionaArchivos.GetArchivos(GestionaArchivos.dirUpdate, "*");
                    
                    BinaryWriter writer = new BinaryWriter(stream);

                    int cantidadElementos = files.Length;
                    writer.Write(cantidadElementos);

                    msjCliente = await tcp.recibeMsjAsync();

                    ServiceLauncher.Imprime(msjCliente);
                    ServiceLauncher.Imprime("Elementos a actualizar " + cantidadElementos);

                    foreach (string file in files)
                    {
                        string pathArchivo = file.Substring(GestionaArchivos.dirUpdate.Length);
                        await tcp.enviaMsjAsync(pathArchivo);
                        msjCliente = await tcp.recibeMsjAsync();
                        ServiceLauncher.Imprime($"Actualizado: {msjCliente}" );
                        tcp.enviaArchivo(writer, file);
                    }
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ipCliente);
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción Metodo: ConectandoCliente");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace);
            }
        }

        public async Task ExtraerJson(TcpComunica tcp)
        {
            try
            {
                string dirEnvio = GestionaArchivos.dirRecJsonEnviar;
                string[] enviar = GestionaArchivos.GetArchivos(dirEnvio, "*.json");

                ServiceLauncher.Imprime("Enviando Json :" + enviar.Length);

                NetworkStream stream = tcp.GetStream();
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(enviar.Length);

                string MsjCliente = await tcp.recibeMsjAsync();

                ServiceLauncher.Imprime(MsjCliente);

                foreach (string file in enviar)
                {
                    string filePath = file.Substring(dirEnvio.Length);
                    await tcp.enviaMsjAsync(filePath);
                    MsjCliente = await tcp.recibeMsjAsync();
                    ServiceLauncher.Imprime("Enviado: " + MsjCliente);
                    tcp.enviaArchivo(writer, file);
                }
                writer.Flush();
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ipCliente);
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción Metodo: ExtraerJson");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace);
            }
        }

        public async Task UpdateRamses(TcpComunica tcp)
        {
            try
            {
                NetworkStream stream = tcp.GetStream();
                string[] files = GestionaArchivos.GetArchivosFiltrados(GestionaArchivos.dirRms, "*");
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(files.Length);

                string MsjCliente = await tcp.recibeMsjAsync();
                ServiceLauncher.Imprime(MsjCliente);

                string nombreJson = Path.Combine(GestionaArchivos.dirRecJsonEnviar, NomJson.JsonServerRms);
                await tcp.enviaMsjAsync(nombreJson);

                MsjCliente = await tcp.recibeMsjAsync();
                ServiceLauncher.Imprime(MsjCliente);

                tcp.enviaArchivo(writer, nombreJson);
                writer.Flush();

                int cantidadElementos = int.Parse(await tcp.recibeMsjAsync());
                ServiceLauncher.Imprime("Elementos a actualizar " + cantidadElementos);

                await tcp.enviaMsjAsync("Empezando a actualizar");

                for (int i = 0; i < cantidadElementos; i++)
                {
                    MsjCliente = await tcp.recibeMsjAsync();
                    ServiceLauncher.Imprime("Actualizado " + MsjCliente);
                    tcp.enviaArchivo(writer, Path.Combine(GestionaArchivos.dirRms, MsjCliente));
                }
                writer.Flush();
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ipCliente);
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción Metodo: updateRamses");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace);
            }

        }

        public async Task UpdatePDF(TcpComunica Tcp)
        {
            try
            {
                NetworkStream stream = Tcp.GetStream();
                string[] files = GestionaArchivos.GetArchivosFiltrados(GestionaArchivos.dirPDF, "*");
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(files.Length);

                await Tcp.recibeMsjAsync();
                string nombreJson = Path.Combine(GestionaArchivos.dirRecJsonEnviar, NomJson.JsonPdfRms);
                await Tcp.enviaMsjAsync(nombreJson);

                string MsjCliente = await Tcp.recibeMsjAsync();

                Tcp.enviaArchivo(writer, nombreJson);
                writer.Flush();

                int cantidadElementos = int.Parse(await Tcp.recibeMsjAsync());
                ServiceLauncher.Imprime("Elementos a actualizar " + cantidadElementos);
                await Tcp.enviaMsjAsync("Empezando a actualizar");
                for (int i = 0; i < cantidadElementos; i++)
                {
                    MsjCliente = await Tcp.recibeMsjAsync();
                    ServiceLauncher.Imprime("Actualizado " + MsjCliente);
                    Tcp.enviaArchivo(writer, Path.Combine(GestionaArchivos.dirPDF, MsjCliente));
                }
                writer.Flush();
            }
            catch (Exception ex)
            {
                ServiceLauncher.Imprime(ipCliente);
                ServiceLauncher.Imprime(ex.ToString());
                ServiceLauncher.Imprime("Excepción Metodo: updatePDF");
                ServiceLauncher.Imprime("Línea de código: " + ex.StackTrace); ;
            }

        }

    }
}
