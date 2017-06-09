using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_académico.Negocio;

namespace Sistema_académico.Presentación.Paneles
{
    public partial class Reporte_de_nomina : UserControl
    {
        public Reporte_de_nomina()
        {
            InitializeComponent();
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {            
            DataTable datos= NEmpleados.reporteNominaEmpleados(this.radDateTimePicker1.Value);
            if (datos==null)
            {
                return;
            }
            this.radGridView1.Columns.Clear();
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.DataSource = datos;
        }
    }
}
