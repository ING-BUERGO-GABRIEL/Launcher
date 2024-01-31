using System;
using System.Diagnostics;
using System.IO;

namespace LauncherRamses
{
    static class RamsesService
    {
        public static void ejecutarRamses()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd.exe";

            string rutaRamses = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ramses", "ramses.exe");
            string comando = $"/C \"{rutaRamses}\"";

            processStartInfo.WorkingDirectory = Path.GetDirectoryName(rutaRamses);
            processStartInfo.Arguments = comando;
            processStartInfo.CreateNoWindow = true; // establecer en true para ocultar la ventana de cmd
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();
        }

    }
}
