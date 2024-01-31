using LauncherRamses.GestoresLauncher;
using LauncherRamses.Modelo;
using LauncherRamses.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LauncherRamses.Modelo.ModeloTiempo;

namespace LauncherRamses.Presentacion.UserControll
{
    public partial class UCNotificaciones : UserControl
    {
        private static UCNotificaciones _Instancia;
        public UCNotificaciones()
        {
            InitializeComponent();
            _Instancia = this;


            
            //var nue = GestionaConfig.ObtenerIdMaquina();
            //GestionaConfig.ActualizarHora();

            Timer temActualizaReloj = new Timer();
            temActualizaReloj.Interval = 30 * 60 * 1000;
            temActualizaReloj.Tick += Temporizador_Tick;
            temActualizaReloj.Start();
        }

        public static UCNotificaciones GetInstance()
        {
            if (_Instancia == null)
            {
                _Instancia = new UCNotificaciones();
            }
            return _Instancia;
        }

        public static void MostrarNotifiacion(string Titulo, string Contenido)
        {
            if (_Instancia != null)
            {
                _Instancia.LaucherNotificaiones.BalloonTipTitle = Titulo;
                _Instancia.LaucherNotificaiones.BalloonTipText = Contenido;
                _Instancia.LaucherNotificaiones.ShowBalloonTip(1 * 24 * 60 * 60 * 1000); //dos dias
            }
        }

        private void LaucherNotificaiones_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                LauncherService.Cerrar();
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            GestionaConfig.ActualizarHora();
        }
    }
}
