using LauncherServer.Presentacion.UserControll;
using LauncherServer.Service;
using System.Windows.Forms;

namespace LauncherServer.Presentacion
{
    public partial class FrmMonitorClientes : Form
    {
        private static FrmMonitorClientes _Instancia;

        public FrmMonitorClientes()
        {
            InitializeComponent();
            _Instancia = this;
            gvListaClientes.DataSource = ServiceMaquina.ListaMaquina;
        }

        public static FrmMonitorClientes GetInstance()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmMonitorClientes();
            }
            return _Instancia;
        }

        private void FrmMonitorClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
