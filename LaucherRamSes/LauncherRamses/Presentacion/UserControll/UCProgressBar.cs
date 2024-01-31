using System;
using System.Windows.Forms;

namespace LauncherRamses.Presentacion.UserControll
{
    public partial class UCProgressBar : UserControl
    {
        private static UCProgressBar _instance;

        public UCProgressBar()
        {
            InitializeComponent();
            _instance = this;
        }

        public static UCProgressBar UserControl
        {
            get
            {
                return _instance;
            }
        }

        public void ActualizarProgreso(int valor)
        {
            if (_instance != null)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<int>(ActualizarProgreso), valor);
                }
                else
                {
                    _instance.pBarActualizacion.Value = valor;
                }
            }
        }

        public void ActualizarTexto(string texto)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ActualizarTexto), texto);
            }
            else
            {
                LvlProgreso.Text = texto;
            }
        }

    }
}
