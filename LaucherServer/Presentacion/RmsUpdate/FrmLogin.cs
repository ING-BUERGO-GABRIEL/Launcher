using System;
using System.Windows.Forms;
using LauncherServer.GestoresLaucher;
using LauncherServer.Resources.NomRecursos;
using RmsUpdateApiNet;

namespace LauncherServer.Presentacion.RmsUpdate
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RmsUpdateApiNetClient ClientRmsUpdate = new RmsUpdateApiNetClient(txtUsuario.Text,txtPassword.Text, GestionaConfig.ObtenerConfig(NomKeyConfig.UrlRmsUpdate));

            using (var loadingForm = new FrmCargando())
            {
                if (await ClientRmsUpdate.Autenticar())
                {
                    MessageBox.Show(ClientRmsUpdate.MsjDialog);
                    FrmActualizar frm = new FrmActualizar(ClientRmsUpdate);
                    frm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(ClientRmsUpdate.MsjDialog);
                }

                Limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Limpiar()
        {
            txtPassword.Text = "";
        }
    }
}
