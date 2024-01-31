
namespace LauncherRamses.TCP
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Net.Sockets;
    using System.Text;

    public partial class TcpComunica : IDisposable
    {
        private string serverIP;
        private int serverPORT;
        private TcpClient client;
        private NetworkStream stream;

        public TcpComunica()
        {
            serverIP = ConfigurationManager.AppSettings["ipserver"];
            serverPORT = int.Parse(ConfigurationManager.AppSettings["portserver"]);
            client = new TcpClient(serverIP, serverPORT);
            stream = client.GetStream();
        }

        public NetworkStream GetStream()
        {
            return stream;
        }

        public string recibeMsjServidor()
        {
            byte[] message = new byte[1024];
            int bytesRead = stream.Read(message, 0, message.Length);
            return Encoding.UTF8.GetString(message, 0, bytesRead);
        }

        public int recibeNumFilasServidor()
        {
            BinaryReader reader = new BinaryReader(stream);
            return  reader.ReadInt32();
        }

        public void enviaMsjServidor(string Msj)
        {
            byte[] messageb = Encoding.UTF8.GetBytes(Msj);
            stream.Write(messageb, 0, messageb.Length);
        }

        public void Dispose()
        {
            stream?.Dispose();
            client?.Close();
        }

        public string ExtraeArchivo()
        {
            byte[] bMessage = new byte[1024];
            int bytesRead = stream.Read(bMessage, 0, bMessage.Length);
            return Encoding.UTF8.GetString(bMessage, 0, bytesRead);
        }
    }
}
