using LauncherRamses.GestoresLauncher;
using LauncherRamses.Presentacion.UserControll;
using LauncherRamses.Resources.NomRecursos;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using static LauncherRamses.Modelo.ModeloTiempo;

namespace LauncherRamses
{
    public partial class FrmActualizacion : Form
    {
        public FrmActualizacion()
        {
            InitializeComponent();

            //GestionaMaquina.Bloquear(Minutos.Cinco);

            Controls.Add(UCNotificaciones.GetInstance());
                   
            GestionaConfig.VerificaAppConfig();

            LvVersion.Text = GestionaMaquina.VersionCli();

            LauncherUser Launcher = new LauncherUser();
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, e) =>
            {
                Launcher.SincronizarServer();
            };
            backgroundWorker.RunWorkerCompleted += (sender, e) =>
            {
                if (GestionaConfig.AppEnEjecucion(NomApps.ProyectoActual))
                {
                    Cerrar();
                }
                else
                {
                    this.Visible = false;
                }
            };

            this.Shown += (sender, e) =>
            {
                backgroundWorker.RunWorkerAsync();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Cerrar()
        {
            this.Close();
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            LvCerrar.BackColor = System.Drawing.Color.DarkGray;
        }

        private void LvCerrar_MouseLeave(object sender, EventArgs e)
        {
            LvCerrar.BackColor = System.Drawing.Color.Transparent;
        }

        private void LvCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}