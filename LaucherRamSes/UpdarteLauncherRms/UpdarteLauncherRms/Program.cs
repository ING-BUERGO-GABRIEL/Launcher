﻿using System;
using System.Windows.Forms;
using UpdarteLauncherRms.Presentacion;

namespace UpdarteLauncherRms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmActualizar());
        }
    }
}
