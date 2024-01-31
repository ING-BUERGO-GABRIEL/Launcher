namespace LauncherServer.Presentacion
{
    partial class FrmMonitor
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            this.lvlTitulo = new System.Windows.Forms.Label();
            this.LvMinimiced = new System.Windows.Forms.Label();
            this.LvV = new System.Windows.Forms.Label();
            this.LvVersion = new System.Windows.Forms.Label();
            this.ucGridViewMonitor1 = new LauncherServer.Presentacion.UserControll.UCGridViewMonitor();
            this.SuspendLayout();
            // 
            // lvlTitulo
            // 
            this.lvlTitulo.AutoSize = true;
            this.lvlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lvlTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.lvlTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lvlTitulo.Location = new System.Drawing.Point(186, 281);
            this.lvlTitulo.Name = "lvlTitulo";
            this.lvlTitulo.Size = new System.Drawing.Size(201, 30);
            this.lvlTitulo.TabIndex = 0;
            this.lvlTitulo.Text = "Launcher Server";
            // 
            // LvMinimiced
            // 
            this.LvMinimiced.AutoSize = true;
            this.LvMinimiced.BackColor = System.Drawing.Color.Transparent;
            this.LvMinimiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvMinimiced.Location = new System.Drawing.Point(562, 9);
            this.LvMinimiced.Name = "LvMinimiced";
            this.LvMinimiced.Size = new System.Drawing.Size(16, 18);
            this.LvMinimiced.TabIndex = 8;
            this.LvMinimiced.Text = "_";
            this.LvMinimiced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LvMinimiced.Click += new System.EventHandler(this.LvMinimiced_Click);
            this.LvMinimiced.MouseEnter += new System.EventHandler(this.LvMinimiced_MouseEnter);
            this.LvMinimiced.MouseLeave += new System.EventHandler(this.LvMinimiced_MouseLeave);
            // 
            // LvV
            // 
            this.LvV.AutoSize = true;
            this.LvV.BackColor = System.Drawing.Color.Transparent;
            this.LvV.Location = new System.Drawing.Point(5, 9);
            this.LvV.Name = "LvV";
            this.LvV.Size = new System.Drawing.Size(16, 16);
            this.LvV.TabIndex = 9;
            this.LvV.Text = "V";
            // 
            // LvVersion
            // 
            this.LvVersion.AutoSize = true;
            this.LvVersion.BackColor = System.Drawing.Color.Transparent;
            this.LvVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.LvVersion.Location = new System.Drawing.Point(23, 9);
            this.LvVersion.Name = "LvVersion";
            this.LvVersion.Size = new System.Drawing.Size(44, 16);
            this.LvVersion.TabIndex = 10;
            this.LvVersion.Text = "1.0.0.0";
            // 
            // ucGridViewMonitor1
            // 
            this.ucGridViewMonitor1.Location = new System.Drawing.Point(19, 312);
            this.ucGridViewMonitor1.Name = "ucGridViewMonitor1";
            this.ucGridViewMonitor1.Size = new System.Drawing.Size(558, 250);
            this.ucGridViewMonitor1.TabIndex = 11;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 574);
            this.ControlBox = false;
            this.Controls.Add(this.ucGridViewMonitor1);
            this.Controls.Add(this.LvV);
            this.Controls.Add(this.LvVersion);
            this.Controls.Add(this.LvMinimiced);
            this.Controls.Add(this.lvlTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher Server Monitor";
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlTitulo;
        private System.Windows.Forms.Label LvMinimiced;
        private System.Windows.Forms.Label LvV;
        private System.Windows.Forms.Label LvVersion;
        private UserControll.UCGridViewMonitor ucGridViewMonitor1;
    }
}