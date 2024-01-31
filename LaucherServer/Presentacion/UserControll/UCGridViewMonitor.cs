using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherServer.Presentacion.UserControll
{
    public partial class UCGridViewMonitor : UserControl
    {

        private const int MaxRowCount = 1000; // Número máximo de filas permitidas
        private static UCGridViewMonitor _userControl;

        public UCGridViewMonitor()
        {
            InitializeComponent();
            _userControl = this;
            GvMonitor.Rows.Clear(); // Limpiar las filas al inicializar el control
                                    //  GvMonitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar automáticamente las columnas al tamaño del DataGridView
        }

        public static UCGridViewMonitor UserControl
        {
            get
            {
                return _userControl;
            }
        }

        public void Imprime(string texto)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(Imprime), texto);
            }
            else
            {
                // Agregar una nueva fila al DataGridView con el texto
                int rowIndex = GvMonitor.Rows.Add(texto);

                // Verificar si se superó el número máximo de filas permitidas
                if (GvMonitor.Rows.Count > MaxRowCount)
                {
                    // Eliminar la fila más antigua del DataGridView
                    GvMonitor.Rows.RemoveAt(0);
                }

                // Desplazar hacia la última fila
                GvMonitor.FirstDisplayedScrollingRowIndex = GvMonitor.Rows.Count - 1;
            }
        }

    }
}
