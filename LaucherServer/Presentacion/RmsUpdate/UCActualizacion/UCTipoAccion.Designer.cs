namespace LauncherServer.Presentacion.RmsUpdate.UCActualizacion
{
    partial class UCTipoAccion
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LvlContenido = new System.Windows.Forms.Label();
            this.LvlTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipoAccion = new System.Windows.Forms.ComboBox();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.lvDescripcion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDescripcion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(517, 16);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(102, 31);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(640, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.LvlContenido);
            this.panel2.Controls.Add(this.LvlTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 83);
            this.panel2.TabIndex = 6;
            // 
            // LvlContenido
            // 
            this.LvlContenido.AutoSize = true;
            this.LvlContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlContenido.Location = new System.Drawing.Point(40, 47);
            this.LvlContenido.Name = "LvlContenido";
            this.LvlContenido.Size = new System.Drawing.Size(333, 18);
            this.LvlContenido.TabIndex = 1;
            this.LvlContenido.Text = "Selecciones de tipo de accion que desea realizar:";
            // 
            // LvlTitulo
            // 
            this.LvlTitulo.AutoSize = true;
            this.LvlTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlTitulo.Location = new System.Drawing.Point(23, 19);
            this.LvlTitulo.Name = "LvlTitulo";
            this.LvlTitulo.Size = new System.Drawing.Size(134, 20);
            this.LvlTitulo.TabIndex = 0;
            this.LvlTitulo.Text = "Tipo de Accion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 61);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Accion:";
            // 
            // cbtipoAccion
            // 
            this.cbtipoAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbtipoAccion.FormattingEnabled = true;
            this.cbtipoAccion.Items.AddRange(new object[] {
            "Administrar Usuarios",
            "Subir Version",
            "Editar Version",
            "Descargar Version",
            "Aprobar Version"});
            this.cbtipoAccion.Location = new System.Drawing.Point(211, 152);
            this.cbtipoAccion.Name = "cbtipoAccion";
            this.cbtipoAccion.Size = new System.Drawing.Size(182, 24);
            this.cbtipoAccion.TabIndex = 9;
            this.cbtipoAccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Controls.Add(this.lvDescripcion);
            this.gbDescripcion.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbDescripcion.Location = new System.Drawing.Point(502, 83);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(269, 345);
            this.gbDescripcion.TabIndex = 10;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripcion";
            // 
            // lvDescripcion
            // 
            this.lvDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDescripcion.Location = new System.Drawing.Point(6, 18);
            this.lvDescripcion.Name = "lvDescripcion";
            this.lvDescripcion.Size = new System.Drawing.Size(257, 324);
            this.lvDescripcion.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbtipoAccion);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 345);
            this.panel3.TabIndex = 11;
            // 
            // UCTipoAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbDescripcion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UCTipoAccion";
            this.Size = new System.Drawing.Size(771, 489);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbDescripcion.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LvlContenido;
        private System.Windows.Forms.Label LvlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipoAccion;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Label lvDescripcion;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnSiguiente;
        public System.Windows.Forms.Button btnCancelar;
    }
}
