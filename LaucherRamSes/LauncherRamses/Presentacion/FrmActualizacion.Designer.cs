
namespace LauncherRamses
{
    partial class FrmActualizacion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizacion));
            this.lvVersionTitulo = new System.Windows.Forms.Label();
            this.LvVersion = new System.Windows.Forms.Label();
            this.LvCerrar = new System.Windows.Forms.Label();
            this.ucProgressBar1 = new LauncherRamses.Presentacion.UserControll.UCProgressBar();
            this.SuspendLayout();
            // 
            // lvVersionTitulo
            // 
            this.lvVersionTitulo.AutoSize = true;
            this.lvVersionTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lvVersionTitulo.Location = new System.Drawing.Point(12, 549);
            this.lvVersionTitulo.Name = "lvVersionTitulo";
            this.lvVersionTitulo.Size = new System.Drawing.Size(16, 16);
            this.lvVersionTitulo.TabIndex = 3;
            this.lvVersionTitulo.Text = "V";
            this.lvVersionTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LvVersion
            // 
            this.LvVersion.AutoSize = true;
            this.LvVersion.BackColor = System.Drawing.Color.Transparent;
            this.LvVersion.Location = new System.Drawing.Point(25, 549);
            this.LvVersion.Name = "LvVersion";
            this.LvVersion.Size = new System.Drawing.Size(44, 16);
            this.LvVersion.TabIndex = 4;
            this.LvVersion.Text = "1.0.0.0";
            this.LvVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LvCerrar
            // 
            this.LvCerrar.AutoSize = true;
            this.LvCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LvCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvCerrar.Location = new System.Drawing.Point(561, 11);
            this.LvCerrar.Name = "LvCerrar";
            this.LvCerrar.Size = new System.Drawing.Size(18, 18);
            this.LvCerrar.TabIndex = 6;
            this.LvCerrar.Text = "X";
            this.LvCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LvCerrar.Click += new System.EventHandler(this.LvCerrar_Click);
            this.LvCerrar.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.LvCerrar.MouseLeave += new System.EventHandler(this.LvCerrar_MouseLeave);
            // 
            // ucProgressBar1
            // 
            this.ucProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucProgressBar1.Location = new System.Drawing.Point(12, 375);
            this.ucProgressBar1.Name = "ucProgressBar1";
            this.ucProgressBar1.Size = new System.Drawing.Size(566, 68);
            this.ucProgressBar1.TabIndex = 7;
            // 
            // FrmActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 574);
            this.ControlBox = false;
            this.Controls.Add(this.ucProgressBar1);
            this.Controls.Add(this.LvCerrar);
            this.Controls.Add(this.LvVersion);
            this.Controls.Add(this.lvVersionTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher Ramses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvVersionTitulo;
        private System.Windows.Forms.Label LvVersion;
        private System.Windows.Forms.Label LvCerrar;
        private Presentacion.UserControll.UCProgressBar ucProgressBar1;
    }
}

