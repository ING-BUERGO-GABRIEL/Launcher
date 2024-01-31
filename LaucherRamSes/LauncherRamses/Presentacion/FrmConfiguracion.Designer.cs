namespace LauncherRamses.Presentacion
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LvlContenido = new System.Windows.Forms.Label();
            this.LvlTitulo = new System.Windows.Forms.Label();
            this.lvlUbicaciones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPDF = new System.Windows.Forms.TextBox();
            this.BtnPathPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Location = new System.Drawing.Point(-10, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(575, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 28);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(465, 13);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(89, 28);
            this.BtnGuardar.TabIndex = 36;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.LvlContenido);
            this.panel2.Controls.Add(this.LvlTitulo);
            this.panel2.Location = new System.Drawing.Point(-10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 71);
            this.panel2.TabIndex = 1;
            // 
            // LvlContenido
            // 
            this.LvlContenido.AutoSize = true;
            this.LvlContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlContenido.Location = new System.Drawing.Point(40, 41);
            this.LvlContenido.Name = "LvlContenido";
            this.LvlContenido.Size = new System.Drawing.Size(338, 16);
            this.LvlContenido.TabIndex = 1;
            this.LvlContenido.Text = "Es necesario completar las configuraciones pendientes";
            // 
            // LvlTitulo
            // 
            this.LvlTitulo.AutoSize = true;
            this.LvlTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlTitulo.Location = new System.Drawing.Point(23, 15);
            this.LvlTitulo.Name = "LvlTitulo";
            this.LvlTitulo.Size = new System.Drawing.Size(218, 16);
            this.LvlTitulo.TabIndex = 0;
            this.LvlTitulo.Text = "Configuración de la Aplicación";
            // 
            // lvlUbicaciones
            // 
            this.lvlUbicaciones.AutoSize = true;
            this.lvlUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUbicaciones.Location = new System.Drawing.Point(17, 86);
            this.lvlUbicaciones.Name = "lvlUbicaciones";
            this.lvlUbicaciones.Size = new System.Drawing.Size(83, 16);
            this.lvlUbicaciones.TabIndex = 2;
            this.lvlUbicaciones.Text = "Directorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ubicacion PDF:";
            // 
            // txtPathPDF
            // 
            this.txtPathPDF.Location = new System.Drawing.Point(167, 130);
            this.txtPathPDF.Name = "txtPathPDF";
            this.txtPathPDF.ReadOnly = true;
            this.txtPathPDF.Size = new System.Drawing.Size(377, 22);
            this.txtPathPDF.TabIndex = 21;
            // 
            // BtnPathPDF
            // 
            this.BtnPathPDF.Location = new System.Drawing.Point(565, 128);
            this.BtnPathPDF.Name = "BtnPathPDF";
            this.BtnPathPDF.Size = new System.Drawing.Size(89, 28);
            this.BtnPathPDF.TabIndex = 6;
            this.BtnPathPDF.Text = "Examinar...";
            this.BtnPathPDF.UseVisualStyleBackColor = true;
            this.BtnPathPDF.Click += new System.EventHandler(this.BtnPathPDF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conexión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP Servidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puerto:";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(167, 236);
            this.txtIP1.MaxLength = 3;
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(40, 22);
            this.txtIP1.TabIndex = 31;
            this.txtIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtIP1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(222, 236);
            this.txtIP2.MaxLength = 3;
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(40, 22);
            this.txtIP2.TabIndex = 32;
            this.txtIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtIP2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // txtIP3
            // 
            this.txtIP3.Location = new System.Drawing.Point(278, 236);
            this.txtIP3.MaxLength = 3;
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(40, 22);
            this.txtIP3.TabIndex = 33;
            this.txtIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtIP3.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // txtIP4
            // 
            this.txtIP4.Location = new System.Drawing.Point(333, 236);
            this.txtIP4.MaxLength = 3;
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(40, 22);
            this.txtIP4.TabIndex = 34;
            this.txtIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtIP4.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(167, 282);
            this.txtPuerto.MaxLength = 4;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(52, 22);
            this.txtPuerto.TabIndex = 35;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtPuerto.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathPDF);
            this.Controls.Add(this.BtnPathPDF);
            this.Controls.Add(this.lvlUbicaciones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion - LauncherServerRms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfiguracion_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LvlTitulo;
        private System.Windows.Forms.Label LvlContenido;
        private System.Windows.Forms.Label lvlUbicaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPDF;
        private System.Windows.Forms.Button BtnPathPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.TextBox txtPuerto;
    }
}