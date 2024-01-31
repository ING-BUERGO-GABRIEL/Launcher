namespace LauncherServer.Presentacion
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
            this.BtnPathRms = new System.Windows.Forms.Button();
            this.txtPathRamses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPDF = new System.Windows.Forms.TextBox();
            this.BtnPathPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaskPuerto = new System.Windows.Forms.MaskedTextBox();
            this.ckListIPS = new System.Windows.Forms.CheckedListBox();
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
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(465, 13);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(89, 28);
            this.BtnGuardar.TabIndex = 16;
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
            // BtnPathRms
            // 
            this.BtnPathRms.Location = new System.Drawing.Point(565, 117);
            this.BtnPathRms.Name = "BtnPathRms";
            this.BtnPathRms.Size = new System.Drawing.Size(89, 28);
            this.BtnPathRms.TabIndex = 3;
            this.BtnPathRms.Text = "Examinar...";
            this.BtnPathRms.UseVisualStyleBackColor = true;
            this.BtnPathRms.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPathRamses
            // 
            this.txtPathRamses.Location = new System.Drawing.Point(167, 119);
            this.txtPathRamses.Name = "txtPathRamses";
            this.txtPathRamses.ReadOnly = true;
            this.txtPathRamses.Size = new System.Drawing.Size(377, 22);
            this.txtPathRamses.TabIndex = 20;
            this.txtPathRamses.TextChanged += new System.EventHandler(this.txtPathRamses_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ubicacion Ramses:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ubicacion PDF:";
            // 
            // txtPathPDF
            // 
            this.txtPathPDF.Location = new System.Drawing.Point(167, 159);
            this.txtPathPDF.Name = "txtPathPDF";
            this.txtPathPDF.ReadOnly = true;
            this.txtPathPDF.Size = new System.Drawing.Size(377, 22);
            this.txtPathPDF.TabIndex = 21;
            // 
            // BtnPathPDF
            // 
            this.BtnPathPDF.Location = new System.Drawing.Point(565, 157);
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
            this.label3.Location = new System.Drawing.Point(17, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conexión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP Servidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puerto:";
            // 
            // MaskPuerto
            // 
            this.MaskPuerto.Location = new System.Drawing.Point(167, 311);
            this.MaskPuerto.Mask = "####";
            this.MaskPuerto.Name = "MaskPuerto";
            this.MaskPuerto.Size = new System.Drawing.Size(80, 22);
            this.MaskPuerto.TabIndex = 26;
            // 
            // ckListIPS
            // 
            this.ckListIPS.FormattingEnabled = true;
            this.ckListIPS.Location = new System.Drawing.Point(167, 245);
            this.ckListIPS.Name = "ckListIPS";
            this.ckListIPS.Size = new System.Drawing.Size(164, 55);
            this.ckListIPS.TabIndex = 28;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.ckListIPS);
            this.Controls.Add(this.MaskPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathPDF);
            this.Controls.Add(this.BtnPathPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathRamses);
            this.Controls.Add(this.BtnPathRms);
            this.Controls.Add(this.lvlUbicaciones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion - LauncherServerRms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfiguracion_FormClosing);
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
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
        private System.Windows.Forms.Button BtnPathRms;
        private System.Windows.Forms.TextBox txtPathRamses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPDF;
        private System.Windows.Forms.Button BtnPathPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MaskPuerto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.CheckedListBox ckListIPS;
    }
}