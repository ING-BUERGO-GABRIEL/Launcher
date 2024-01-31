namespace LauncherServer.Presentacion.UserControll
{
    partial class UCNotificaciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNotificaciones));
            this.NotifLaucher = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMenuStripNotific = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMActualizaJson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUbicacioRms = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMListaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStripNotific.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifLaucher
            // 
            this.NotifLaucher.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifLaucher.Icon")));
            this.NotifLaucher.Text = "LauncherServerRms";
            this.NotifLaucher.Visible = true;
            this.NotifLaucher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifLaucher_MouseClick);
            // 
            // cMenuStripNotific
            // 
            this.cMenuStripNotific.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuStripNotific.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMActualizaJson,
            this.TSMConfigurar,
            this.TSMUbicacioRms,
            this.TSMListaClientes,
            this.TSMActualizar});
            this.cMenuStripNotific.Name = "cMenuStripNotific";
            this.cMenuStripNotific.Size = new System.Drawing.Size(213, 120);
            // 
            // TSMActualizaJson
            // 
            this.TSMActualizaJson.Name = "TSMActualizaJson";
            this.TSMActualizaJson.Padding = new System.Windows.Forms.Padding(0);
            this.TSMActualizaJson.Size = new System.Drawing.Size(212, 22);
            this.TSMActualizaJson.Text = "Actualizar Ramses";
            // 
            // TSMConfigurar
            // 
            this.TSMConfigurar.Name = "TSMConfigurar";
            this.TSMConfigurar.Padding = new System.Windows.Forms.Padding(0);
            this.TSMConfigurar.Size = new System.Drawing.Size(212, 22);
            this.TSMConfigurar.Text = "Configuraciones";
            // 
            // TSMUbicacioRms
            // 
            this.TSMUbicacioRms.Name = "TSMUbicacioRms";
            this.TSMUbicacioRms.Size = new System.Drawing.Size(212, 24);
            this.TSMUbicacioRms.Text = "Directorio Ramses";
            // 
            // TSMListaClientes
            // 
            this.TSMListaClientes.Name = "TSMListaClientes";
            this.TSMListaClientes.Size = new System.Drawing.Size(212, 24);
            this.TSMListaClientes.Text = "Clientes Conectados";
            // 
            // TSMActualizar
            // 
            this.TSMActualizar.Name = "TSMActualizar";
            this.TSMActualizar.Size = new System.Drawing.Size(212, 24);
            this.TSMActualizar.Text = "Prueba";
            this.TSMActualizar.Visible = false;
            // 
            // UCNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "UCNotificaciones";
            this.Size = new System.Drawing.Size(26, 18);
            this.cMenuStripNotific.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifLaucher;
        private System.Windows.Forms.ContextMenuStrip cMenuStripNotific;
        private System.Windows.Forms.ToolStripMenuItem TSMActualizaJson;
        private System.Windows.Forms.ToolStripMenuItem TSMConfigurar;
        private System.Windows.Forms.ToolStripMenuItem TSMActualizar;
        private System.Windows.Forms.ToolStripMenuItem TSMUbicacioRms;
        private System.Windows.Forms.ToolStripMenuItem TSMListaClientes;
    }
}
