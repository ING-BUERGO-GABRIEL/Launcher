using LauncherRamses.GestoresLauncher;
using LauncherRamses.Resources;
using LauncherRamses.Resources.NomRecursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LauncherRamses.Presentacion
{
    public partial class FrmConfiguracion : Form
    {
        private bool isClosing = true;
        public FrmConfiguracion()
        {
            InitializeComponent();
            CargarConfiguraciones();
        }
        private void maskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            var maskedTextBox = (MaskedTextBox)sender;
            int valor;

            if (!int.TryParse(maskedTextBox.Text, out valor))
            {
                // No se pudo convertir el texto a un número entero válido
                MessageBox.Show("Ingrese un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (valor < 0 || valor > 255)
            {
                // El número está fuera del rango válido
                MessageBox.Show("El número debe estar entre 0 y 255.", "Error de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }



        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true; // Evitar que se ingrese el punto (.)
                SendKeys.Send("{TAB}");  // Cambiar el enfoque al siguiente TextBox
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Cancelar el evento para evitar ingresar el carácter
            }
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            var TextBox = (System.Windows.Forms.TextBox)sender;
            int valor;

            int maximo = 255;

            if (TextBox.MaxLength >= 4)
            {
                maximo = 9999;
            }


            if (!int.TryParse(TextBox.Text, out valor) && (TextBox.Text!=""))
            {
                // No se pudo convertir el texto a un número entero válido
                MessageBox.Show("Ingrese un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (valor < 0 || valor > maximo)
            {
                // El número está fuera del rango válido
                MessageBox.Show("El número debe estar entre 0 y 255.", "Error de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
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

        private void CargarConfiguraciones()
        {

            txtPathPDF.Text = GestionaConfig.ObtenerConfig(NomKey.DirectoryPDF);

            string[] octetos = GestionaConfig.ObtenerConfig(NomKey.IPlocal).Split('.');

            // Asegúrate de que haya exactamente cuatro partes
            if (octetos.Length == 4)
            {
                // Asigna cada parte a los TextBox correspondientes
                txtIP1.Text = octetos[0];
                txtIP2.Text = octetos[1];
                txtIP3.Text = octetos[2];
                txtIP4.Text = octetos[3];
            }

            txtPuerto.Text = GestionaConfig.ObtenerConfig(NomKey.PortServer);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                GestionaConfig.ModificarAppConfig(NomKey.DirectoryPDF, txtPathPDF.Text);
                GestionaConfig.ModificarAppConfig(NomKey.IPlocal, (txtIP1.Text +"."+ txtIP2.Text +"."+ txtIP3.Text+"." + txtIP4.Text));
                GestionaConfig.ModificarAppConfig(NomKey.PortServer, txtPuerto.Text);
                isClosing = false;
                Close();
            }
        }

        private bool ValidarDatos()
        {

            if (txtPathPDF.Text == "")
            {
                MessageBox.Show("El directorio de los Reportes de facturacion son obligatorios, ruta por defecto C:\\Singleton", "Faltan Datos");
                return false;
            }

            if (txtIP1.Text == "" || txtIP2.Text == "" || txtIP3.Text == "" || txtIP4.Text == "")
            {
                MessageBox.Show("La direccion IP del servidor es Obligatoria", "Faltan Datos");
                return false;
            }

            if (txtPuerto.Text == "")
            {
                MessageBox.Show("El Puerto de la coneccion es obligatorio", "Faltan Datos");
                return false;
            }

            return true;
        }

        private void FrmConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosing)
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
                    Environment.Exit(0);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("La aplicacion necesita todas las configuraciones para fucniona correctamente ¿Desea cerrar la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                isClosing = false;
                Application.Exit();
            }
        }

    }
}
