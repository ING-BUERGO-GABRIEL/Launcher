using LauncherServer.GestoresLaucher;
using LauncherServer.Presentacion.RmsUpdate;
using LauncherServer.Resources.NomRecursos;
using LauncherServer.Service;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace LauncherServer.Presentacion.UserControll
{
    public partial class UCNotificaciones : UserControl
    {

        private static UCNotificaciones _Instancia;

        [Obsolete]
        public static UCNotificaciones GetInstance()
        {
            if (_Instancia == null)
            {
                _Instancia = new UCNotificaciones();
            }
            return _Instancia;
        }
        [Obsolete]
        public UCNotificaciones()
        {
            InitializeComponent();
            _Instancia = this;

            cMenuStripNotific.Items["TSMActualizaJson"].Click += ActualizarJson_Click;
            cMenuStripNotific.Items["TSMConfigurar"].Click += Configurar_Click;
            cMenuStripNotific.Items["TSMActualizar"].Click += ActualizarRmsUpdate_Click;
            cMenuStripNotific.Items["TSMUbicacioRms"].Click += AbrirDirRamses_Click;
            cMenuStripNotific.Items["TSMListaClientes"].Click += ListaClientes_Click;
            //TSMListaClientes

            Timer temporizadorJson = new Timer();
            Timer temporizadorContijencia = new Timer();

            int MinIntervalo = Convert.ToInt32(ConfigurationManager.AppSettings[NomKeyConfig.MinJson]);
            temporizadorJson.Interval = MinIntervalo * 60 * 1000;
            temporizadorJson.Tick += Temporizador_Tick;
            temporizadorJson.Start();
        }

        private void ListaClientes_Click(object sender, EventArgs e)
        {
            FrmMonitorClientes Frm = FrmMonitorClientes.GetInstance();
            Frm.Show();
        }

        [Obsolete]
        private void NotifLaucher_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMenuStripNotific.Show(Cursor.Position);
            }
            else if (e.Button == MouseButtons.Left)
            {
                FrmMonitor frm = FrmMonitor.GetInstance();
                frm.Maximizar();
                frm.Show();
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            ServiceLauncher.GenerarJson();
        }

        private void ActualizarJson_Click(object sender, EventArgs e)
        {
            ServiceLauncher.GenerarJson();
        }

        private void ActualizarRmsUpdate_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
        private void AbrirDirRamses_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", GestionaArchivos.dirRms);
        }

        private void Configurar_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion(true);
            try
            {
                frm.Show();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
