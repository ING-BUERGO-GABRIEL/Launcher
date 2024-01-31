namespace LauncherRamses.Presentacion.UserControll
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNotificaciones));
            this.LaucherNotificaiones = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // LaucherNotificaiones
            // 
            this.LaucherNotificaiones.Icon = ((System.Drawing.Icon)(resources.GetObject("LaucherNotificaiones.Icon")));
            this.LaucherNotificaiones.Text = "Laucher Cliente";
            this.LaucherNotificaiones.Visible = true;
            this.LaucherNotificaiones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LaucherNotificaiones_MouseDown);
            // 
            // UCNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "UCNotificaciones";
            this.Size = new System.Drawing.Size(17, 16);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon LaucherNotificaiones;
    }
}
