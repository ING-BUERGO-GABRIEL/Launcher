using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherRamses.Presentacion.MensajeBox
{
    public partial class FrmMensaje : Form
    {

        private int tiempoRestante;
        public Timer timer;

        private string Titulo;
        private string Mensaje;
        public FrmMensaje(string titulo,string mensaje,int segundos)
        {
            InitializeComponent();

            tiempoRestante = segundos;
            Titulo = titulo;
            Mensaje = mensaje;
            ActualizarMensaje();

            timer = new Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            if (tiempoRestante <= 0)
            {
                timer.Stop();
                Close();
            }
            else
            {
                ActualizarMensaje();
            }
        }

        private  void ActualizarMensaje()
        {
            lvTitulo.Text = Titulo;
            TimeSpan tiempoRestanteSpan = TimeSpan.FromSeconds(tiempoRestante);
            lvMensaje.Text = Mensaje + " " + tiempoRestanteSpan.Seconds;
            //string.Format("Ramses se bloqueará en {2:D2}", tiempoRestanteSpan.Seconds);
            //labelMensaje.Text = mensaje;
        }
    }
}
