using System;
using System.Drawing;
using System.Windows.Forms;

namespace LauncherServer.Presentacion.RmsUpdate
{
    public class FrmCargando : Form
    {
        private PictureBox pictureBox;
        public FrmCargando()
        {
            InitializeComponents();
            Show();
            Refresh();
        }

        private void InitializeComponents()
        {
            pictureBox = new PictureBox();

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Properties.Resources.cargando; 

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            Controls.Add(pictureBox);

            pictureBox.Dock = DockStyle.Fill; 

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MinimumSize = new Size(200, 100); 
            Size = new Size(Math.Max(pictureBox.Width, 200), Math.Max(pictureBox.Height, 100)); 
        }
    }
}
