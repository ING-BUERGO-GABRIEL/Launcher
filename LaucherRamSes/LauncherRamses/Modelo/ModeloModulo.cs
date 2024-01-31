using System;

namespace LauncherRamses
{
    public class ModeloModulo
    {
        public string Path { get; set; }
        public string Version { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Extension { get; set; }
        public override string ToString()
        {
            return $"ModeloModulo[Path={Path}, Version={Version}, FechaModificacion={FechaModificacion}, Extension={Extension}]";
        }
    }
}
