using System;
using System.Reflection;

namespace LauncherRamses.Modelo
{
    public class ModeloMaquina
    {
        public string IdMaquina { get; set; }
        public string Estado { get; set; }
        public Version VersionCl { get; set; } = Assembly.GetEntryAssembly().GetName().Version;
        public override string ToString()
        {
            return $"ModeloMaquina[NombrePc={IdMaquina}, Estado={Estado}, VersionCl={VersionCl}]";
        }
    }
}
