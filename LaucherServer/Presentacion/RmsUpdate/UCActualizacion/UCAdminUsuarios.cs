using LauncherServer.Interfaces;
using RmsUpdateApiNet;
using RmsUpdateApiNet.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LauncherServer.Presentacion.RmsUpdate.UCActualizacion
{

    public partial class UCAdminUsuarios : UserControl, IUserControlActualizar
    {
        public event EventHandler BtnSiguienteClick;
        public event EventHandler BtnAtrasClick;
        public event EventHandler BtnGuardarClick;
        public event EventHandler BtnCancelarClick;

        public RmsUpdateApiNetClient ClienteRmsUpdate { get; }
        public UCAdminUsuarios(RmsUpdateApiNetClient clienteRmsUpdate)
        {
            InitializeComponent();
            ClienteRmsUpdate = clienteRmsUpdate;
            CargarDatos();
            //cbTipoPrivilegio.o
        }

        private async void CargarDatos()
        {
            GvListaUsuario.DataSource = await ClienteRmsUpdate.ListaUsuarios();
            cbTipoPrivilegio.DataSource = await ClienteRmsUpdate.ListaTipoPrivilegios();
           
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                BtnSiguienteClick?.Invoke(sender, e);
            }
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
            //if (cbtipoAccion.Text == "")
            //{
            //    MessageBox.Show("Seleccione El Tipo de Accion", "Faltan Datos");
            //    return false;            
            //}
            //else
            //{
                return true;
            //}
        }


    }
}
