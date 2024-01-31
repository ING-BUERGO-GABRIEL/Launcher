namespace LauncherServer.Presentacion
{
    partial class FrmMonitorClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitorClientes));
            this.gvListaClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaClientes
            // 
            this.gvListaClientes.AllowUserToAddRows = false;
            this.gvListaClientes.AllowUserToDeleteRows = false;
            this.gvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaClientes.Location = new System.Drawing.Point(28, 68);
            this.gvListaClientes.Name = "gvListaClientes";
            this.gvListaClientes.ReadOnly = true;
            this.gvListaClientes.RowHeadersVisible = false;
            this.gvListaClientes.RowHeadersWidth = 51;
            this.gvListaClientes.RowTemplate.Height = 24;
            this.gvListaClientes.Size = new System.Drawing.Size(707, 331);
            this.gvListaClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de clientes:";
            // 
            // FrmMonitorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvListaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMonitorClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Conectados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMonitorClientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaClientes;
        private System.Windows.Forms.Label label1;
    }
}