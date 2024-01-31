
using RmsUpdateApiNet.Modelo;

namespace RmsUpdateApiNet.Http
{
    public class RmsUpdateHttpClient
    {
        public RmsUpdateHttpClient(string username, string password)
        {
            LoginModelo = new ModeloLogin { Usuario = username, Password = password };
        }

        public ModeloLogin LoginModelo { get; }
    }
}