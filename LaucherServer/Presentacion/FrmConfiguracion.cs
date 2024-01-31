using LauncherServer.GestoresLaucher;
using LauncherServer.GestoresLauncher;
using LauncherServer.Resources.NomRecursos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace LauncherServer.Presentacion
{
    public partial class FrmConfiguracion : Form
    {

        private bool isClosing = true;
        private bool AppIniciada = true;
        private static FrmConfiguracion _Instancia;

        public FrmConfiguracion(Boolean AppIni=false)
        {
            AppIniciada=AppIni;
            InitializeComponent();
            _Instancia = this;
        }

        public static FrmConfiguracion UserControl
        {
            get
            {
                return _Instancia;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // Configurar las opciones del diálogo
                dialog.Title = "Seleccionar ejecutable Ramses";
                dialog.Filter = "Archivos ejecutables (*.exe)|*.exe";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;

                // Mostrar el diálogo y comprobar si el usuario hizo clic en el botón "Aceptar"
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (string.Equals(Path.GetFileName(dialog.FileName), "ramses.exe", StringComparison.OrdinalIgnoreCase))
                    {
                        txtPathRamses.Text = dialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("El nombre del archivo no es 'ramses.exe'.");
                    }
                }
            }
        }

        private void BtnPathPDF_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // Configurar las opciones del diálogo
                dialog.Description = "Selecciona una carpeta PDF";
                dialog.RootFolder = Environment.SpecialFolder.Desktop;

                // Mostrar el diálogo y comprobar si el usuario hizo clic en el botón "Aceptar"
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta de la carpeta seleccionada por el usuario
                    txtPathPDF.Text = dialog.SelectedPath;
                }
            }
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguraciones();
        }

        private void CargarConfiguraciones()
        {
            string PathRms = GestionaConfig.ObtenerConfig(NomKeyConfig.DirectoryRms);
            string EjecutableRms = GestionaConfig.ObtenerConfig(NomKeyConfig.EjecutableRms);
            if (PathRms != "" && EjecutableRms != "")
            {
                txtPathRamses.Text = Path.Combine(PathRms, EjecutableRms);
            }
            txtPathPDF.Text = GestionaConfig.ObtenerConfig(NomKeyConfig.DirectoryPDF);

            CargarDireccionesIPv4();
            CargarCheklistobox(GestionaHerramientas.ConvertirLista(GestionaConfig.ObtenerConfig(NomKeyConfig.IPlocal)));

            MaskPuerto.Text = GestionaConfig.ObtenerConfig(NomKeyConfig.PortServer);

        }

        private void CargarDireccionesIPv4()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in interfaces)
            {
                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            if (ip.Address.ToString() != "127.0.0.1")
                            {
                                ckListIPS.Items.Add(ip.Address.ToString());
                            }
                        }
                    }
                }
            }
        }


        private void CargarCheklistobox(List<string> ipsSeleccionadas)
        {
            foreach (string ip in ipsSeleccionadas)
            {
                int index = ckListIPS.FindStringExact(ip);
                if (index != ListBox.NoMatches)
                {
                    ckListIPS.SetItemChecked(index, true);
                }
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                GestionaConfig.ModificarAppConfig(NomKeyConfig.DirectoryRms, Path.GetDirectoryName(txtPathRamses.Text));
                GestionaConfig.ModificarAppConfig(NomKeyConfig.DirectoryPDF, txtPathPDF.Text);
                GestionaConfig.ModificarAppConfig(NomKeyConfig.IPlocal, GestionaHerramientas.ExtraerIps(ckListIPS));
                GestionaConfig.ModificarAppConfig(NomKeyConfig.PortServer, MaskPuerto.Text);
                isClosing = false;
                GestionaPrivilegios.ReiniciarAplicacion();
            }

        }

        private bool ValidarDatos()
        {
            if (txtPathRamses.Text == "")
            {
                MessageBox.Show("Es nesesario especifiar la ruta del ejecutable de Ramses.exe", "Faltan Datos");
                return false;
            }

            if (txtPathPDF.Text == "")
            {
                MessageBox.Show("El directorio de los Reportes de facturacion son obligatorios, ruta por defecto C:\\Singleton", "Faltan Datos");
                return false;
            }


            string IPS = GestionaHerramientas.ExtraerIps(ckListIPS);

            if (IPS == "")
            {
                MessageBox.Show("La direccion IP del servidor es Obligatoria", "Faltan Datos");
                return false;
            }

            if (MaskPuerto.Text == "")
            {
                MessageBox.Show("El Puerto de la coneccion es obligatorio", "Faltan Datos");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (AppIniciada)
            {
                isClosing = false;
                Close();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("La aplicacion necesita todas las configuraciones para fucniona correctamente ¿Desea cerrar la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    isClosing = false;
                    Application.Exit();
                }
            }
        }

        private void FrmConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosing)
            {
                if (AppIniciada)
                {
                    isClosing = false;
                    Close();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("La aplicacion necesita todas las configuraciones para fucniona correctamente ¿Desea cerrar la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.No)
                    {
                        e.Cancel = true; // Cancelar el cierre del formulario
                    }
                    else
                    {
                        isClosing = false;
                        Application.Exit();
                    }
                }
            }
        }

        public Boolean GetResultado()
        {
            return isClosing;
        }

        public void SetResultado(Boolean isClo)
        {
            isClosing = isClo;
        }

        private void txtPathRamses_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
