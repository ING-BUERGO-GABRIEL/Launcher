namespace LauncherRamses.Presentacion.MensajeBox
{
    partial class FrmMensaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensaje));
            this.lvTitulo = new System.Windows.Forms.Label();
            this.lvMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvTitulo
            // 
            this.lvTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTitulo.Location = new System.Drawing.Point(0, 0);
            this.lvTitulo.Name = "lvTitulo";
            this.lvTitulo.Size = new System.Drawing.Size(322, 30);
            this.lvTitulo.TabIndex = 0;
            this.lvTitulo.Text = "Titulo";
            this.lvTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvMensaje
            // 
            this.lvMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMensaje.Location = new System.Drawing.Point(0, 30);
            this.lvMensaje.Name = "lvMensaje";
            this.lvMensaje.Size = new System.Drawing.Size(322, 96);
            this.lvMensaje.TabIndex = 1;
            this.lvMensaje.Text = "Mensaje";
            this.lvMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 126);
            this.Controls.Add(this.lvMensaje);
            this.Controls.Add(this.lvTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMensajeTemporal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lvTitulo;
        private System.Windows.Forms.Label lvMensaje;
    }
}