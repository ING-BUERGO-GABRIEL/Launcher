using LauncherServer.Interfaces;
using RmsUpdateApiNet;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LauncherServer.Presentacion.RmsUpdate.UCActualizacion
{

    public partial class UCTipoAccion : UserControl, IUserControlActualizar
    {
        public event EventHandler BtnSiguienteClick;
        public event EventHandler BtnAtrasClick;
        public event EventHandler BtnGuardarClick;
        public event EventHandler BtnCancelarClick;

        public RmsUpdateApiNetClient ClienteRmsUpdate { get; }
        public string Accion;
        public UCTipoAccion(RmsUpdateApiNetClient clienteRmsUpdate)
        {
            InitializeComponent();
            ClienteRmsUpdate = clienteRmsUpdate;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BtnSiguienteClick?.Invoke(sender, e);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            BtnAtrasClick?.Invoke(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardarClick?.Invoke(sender, e);
        }

        private void btnCancelarClick(object sender, EventArgs e)
        {
            BtnCancelarClick?.Invoke(sender, e);
        }
        public bool Validar()
        {
            if (cbtipoAccion.Text == "")
            {
                MessageBox.Show("Seleccione El Tipo de Accion", "Faltan Datos");
                return false;            
            }
            else
            {
                return true;
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accion = cbtipoAccion.Text;
        }

        public List<UserControl> PreparaFlujo()
        {
            List<UserControl> listUCFlujo = new List<UserControl>();
            if (cbtipoAccion.Text == "Administrar Usuarios")
            {
                listUCFlujo.Add(new UCAdminUsuarios(ClienteRmsUpdate));
                //listUCFlujo.Add(new UCUsuarios(ClientRmsUpdate));
                //listUCFlujo.Add(new UCaprobarlista(ClientRmsUpdate));
                //listUCFlujo.Add(new UCSeleciona(ClientRmsUpdate));
            }
            else if (cbtipoAccion.Text == "Subir datos")
            {
                listUCFlujo.Add(new UCAdminUsuarios(ClienteRmsUpdate));
                //listUCFlujo.Add(new UCUsuarios(ClientRmsUpdate));
                //listUCFlujo.Add(new UCaprobarlista(ClientRmsUpdate));
                //listUCFlujo.Add(new UCSeleciona(ClientRmsUpdate));
            }
            else
            {
                MessageBox.Show($"No hay flujo para {cbtipoAccion.Text}", "Error");
                listUCFlujo = null;
            }
            return listUCFlujo;
        }
    }
}
