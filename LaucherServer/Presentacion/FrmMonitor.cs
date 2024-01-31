using System;
using System.Configuration;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using LauncherServer.GestoresLauncher;
using LauncherServer.Presentacion.UserControll;
using LauncherServer.Resources.NomRecursos;
using LauncherServer.Service;

namespace LauncherServer.Presentacion
{
    public partial class FrmMonitor : Form
    {
        private static FrmMonitor _userControl;
        private LauncherServerC launcherServidor;
        [Obsolete]
        public FrmMonitor()
        {
            InitializeComponent();
            _userControl = this;
            Controls.Add(UCNotificaciones.GetInstance());
            Version version = Assembly.GetEntryAssembly().GetName().Version;         
            LvVersion.Text = version.ToString();
            launcherServidor = LauncherServerC.GetInstance();
        }

        [Obsolete]
        private async void FrmMonitor_Load(object sender, EventArgs e)
        {         
            ServiceConfig.VerificaAppConfig();
            ServiceConfig.VerificaListaNegra();
            ServiceConfig.ConfiguraPuertos();
          
            Visible = true;

            await Task.Run(async () =>
            {
                ServiceLauncher.GenerarJson();
                string ipLocal = ConfigurationManager.AppSettings[NomKeyConfig.IPlocal];
                await launcherServidor.RunServer(GestionaHerramientas.ConvertirLista(ipLocal));
            });

        }

        [Obsolete]
        public static FrmMonitor GetInstance()
        {
            if (_userControl == null)
            {
                _userControl = new FrmMonitor();
            }
            return _userControl;
        }

        private void LvCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        public void Cerrar()
        {
            Close();
            Application.Exit();
        }

        private void LvMinimiced_MouseEnter(object sender, EventArgs e)
        {
            LvMinimiced.BackColor = System.Drawing.Color.DarkGray;
        }

        private void LvMinimiced_MouseLeave(object sender, EventArgs e)
        {
            LvMinimiced.BackColor = System.Drawing.Color.Transparent;
        }

        private void LvMinimiced_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Visible = false;
        }

        public void Maximizar()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

    }
}
