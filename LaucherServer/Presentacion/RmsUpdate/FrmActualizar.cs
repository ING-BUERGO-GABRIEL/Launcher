using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using LauncherServer.Interfaces;
using LauncherServer.Presentacion.RmsUpdate.UCActualizacion;
using RmsUpdateApiNet;

namespace LauncherServer.Presentacion.RmsUpdate
{
    public partial class FrmActualizar : Form
    {
        public RmsUpdateApiNetClient ClientRmsUpdate { get; }       
        private UCTipoAccion ucTipoAccion;
        private List<UserControl> Flujo;
        private int currentIndex = -1;
        public FrmActualizar(RmsUpdateApiNetClient clientRmsUpdate)
        {
            InitializeComponent();
            ClientRmsUpdate = clientRmsUpdate;
            ucTipoAccion = new UCTipoAccion(clientRmsUpdate);
            PanelTab.Controls.Add(ucTipoAccion);
            ucTipoAccion.btnSiguiente.Click += BtnSiguiente_Click;
            ucTipoAccion.btnCancelar.Click += Canselar_Click;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (ucTipoAccion.Validar())
            {
                Flujo = ucTipoAccion.PreparaFlujo();
                CambiarUC(true);
            }
        }

        private void CambiarUC(bool direccion)
        {
            if (direccion)
            {
                currentIndex += 1;
            }
            else 
            { 
                currentIndex -=1; 
            }

            if (currentIndex >= 0 && currentIndex < Flujo.Count)
            {
                UserControl uc = Flujo[currentIndex];
                LimpiarPanel(PanelTab);
                PanelTab.Controls.Add(uc);

                if (uc is IUserControlActualizar controlNavegacion)
                {
                    controlNavegacion.BtnSiguienteClick += Siguiente_Click;
                    controlNavegacion.BtnAtrasClick += Atras_Click;
                    controlNavegacion.BtnCancelarClick += Canselar_Click;
                    controlNavegacion.BtnGuardarClick += Guardar_Click;
                }
            }
        }

        public void LimpiarPanel(Panel panel)
        {
            while (panel.Controls.Count > 0)
            {
                Control control = panel.Controls[0]; // Obtiene el primer control secundario
                panel.Controls.Remove(control);     // Elimina el control del panel
                control.Dispose();                  // Limpia los recursos del control
            }
        }


        private void Siguiente_Click(object sender, EventArgs e)
        {
            CambiarUC(true);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            CambiarUC(false);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Canselar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cancelar la actualizacion?", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
