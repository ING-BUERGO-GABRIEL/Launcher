using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherRamses
{
    public class ModeloListaNegra
    {
        public string Path { get; set; }
        public override string ToString()
        {
            return $"ListaNegra[Path={Path}]";
        }
    }

}