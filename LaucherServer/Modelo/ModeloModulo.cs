using System;

namespace LauncherServer.Modelo
{
    public class ModeloModulo
    {
        public string Path { get; set; }
        public string Version { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Extension { get; set; }
        public override string ToString()
        {
            return $"Modulo[Path={Path}, Version={Version}, FechaModificacion={FechaModificacion}, Extension={Extension}]";
        }
    }
}
