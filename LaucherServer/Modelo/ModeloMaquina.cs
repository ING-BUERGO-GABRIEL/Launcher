using System;
using System.IO;

namespace LauncherServer.Modelo
{
    public class ModeloMaquina
    {
        public string IpCLiente { get; set; }
        public string IdMaquina { get; set; }
        public string Estado { get;set ; }
        public Version VersionCl { get; set; }
        public DateTime HoraConex { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"Modulo[IpCLiente={IpCLiente}, IdMaquina={IdMaquina}, Estado={Estado}, VersionCl={VersionCl}, HoraConex={HoraConex}]";
        }
    }
}
