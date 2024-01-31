using LauncherServer.Presentacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherServer.TCP
{
    public partial class TcpComunica : IDisposable
    {
        private string serverIP;
        private int serverPORT;
        private TcpClient client;
        private NetworkStream stream;
        private IPAddress ipAddress;
        private TcpListener listener;
        private List<TcpClient> tcpClients;

        public TcpComunica()
        {
            serverIP = ConfigurationManager.AppSettings["ipserver"];
            serverPORT = int.Parse(ConfigurationManager.AppSettings["portserver"]);
            client = new TcpClient(serverIP, serverPORT);
            stream = client.GetStream();
        }
        [Obsolete]
        public TcpComunica(IPAddress ipAddre)
        {
            ipAddress = ipAddre;
            serverPORT = int.Parse(ConfigurationManager.AppSettings["portserver"]);
            listener = new TcpListener(ipAddress, serverPORT);
            tcpClients = new List<TcpClient>();
            try
            {
                listener.Start();
            }
            catch
            {
                MessageBox.Show("Problema de Configuracion de ips escucha","Error Configuracion");
                FrmConfiguracion frm = new FrmConfiguracion();
                frm.ShowDialog();
            }
        }

        public TcpComunica(TcpClient Newclient)
        {
            client = Newclient;
            stream = Newclient.GetStream();
        }

        public TcpListener GetListener()
        {
            return listener;
        }

        public List<TcpClient> GetTcpClientes()
        {
            return tcpClients;
        }

        public NetworkStream GetStream()
        {
            return stream;
        }

        public string recibeMsj()
        {
            byte[] message = new byte[1024];
            int bytesRead = stream.Read(message, 0, message.Length);
            return Encoding.UTF8.GetString(message, 0, bytesRead);
        }

        public async Task<string> recibeMsjAsync()
        {

            byte[] message = new byte[1024];
            int bytesRead = await stream.ReadAsync(message, 0, message.Length);
            return Encoding.UTF8.GetString(message, 0, bytesRead);
        }

        public int recibeNumFilas()
        {
            BinaryReader reader = new BinaryReader(stream);
            return reader.ReadInt32();
        }

        public void enviaMsj(string Msj)
        {
            byte[] messageb = Encoding.UTF8.GetBytes(Msj);
            stream.Write(messageb, 0, messageb.Length);
        }

        public async Task enviaMsjAsync(string message)
        {
            byte[] version = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(version, 0, version.Length);
        }

        public string ExtraeArchivo()
        {
            byte[] bMessage = new byte[1024];
            int bytesRead = stream.Read(bMessage, 0, bMessage.Length);
            return Encoding.UTF8.GetString(bMessage, 0, bytesRead);
        }

        public void enviaArchivo(BinaryWriter writer, string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] data = System.IO.File.ReadAllBytes(filePath);
                writer.Write(data.Length);
                writer.Write(data);
            }
        }

        public string ObtenerDireccionIPCliente()
        {
            if (client != null && client.Connected)
            {
                var endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                return endPoint.Address.ToString();
            }

            return string.Empty;
        }


        public void Dispose()
        {
            stream?.Dispose();
            client?.Close();
            listener?.Stop();
        }
    }
}
