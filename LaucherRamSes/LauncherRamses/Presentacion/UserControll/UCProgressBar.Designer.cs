namespace LauncherRamses.Presentacion.UserControll
{
    partial class UCProgressBar
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
            this.LvlProgreso = new System.Windows.Forms.Label();
            this.pBarActualizacion = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LvlProgreso
            // 
            this.LvlProgreso.AutoSize = true;
            this.LvlProgreso.BackColor = System.Drawing.Color.Transparent;
            this.LvlProgreso.Location = new System.Drawing.Point(25, 10);
            this.LvlProgreso.Name = "LvlProgreso";
            this.LvlProgreso.Size = new System.Drawing.Size(88, 16);
            this.LvlProgreso.TabIndex = 4;
            this.LvlProgreso.Text = "Preparando...";
            this.LvlProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBarActualizacion
            // 
            this.pBarActualizacion.BackColor = System.Drawing.Color.Coral;
            this.pBarActualizacion.ForeColor = System.Drawing.Color.Gold;
            this.pBarActualizacion.Location = new System.Drawing.Point(20, 29);
            this.pBarActualizacion.Margin = new System.Windows.Forms.Padding(4);
            this.pBarActualizacion.Name = "pBarActualizacion";
            this.pBarActualizacion.Size = new System.Drawing.Size(526, 22);
            this.pBarActualizacion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarActualizacion.TabIndex = 3;
            // 
            // UCProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LvlProgreso);
            this.Controls.Add(this.pBarActualizacion);
            this.Name = "UCProgressBar";
            this.Size = new System.Drawing.Size(568, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LvlProgreso;
        public System.Windows.Forms.ProgressBar pBarActualizacion;
    }
}
