using Sistema_académico.Presentación;
using Sistema_académico.Presentación.Paneles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_académico
{
    public partial class Principal : Telerik.WinControls.UI.RadForm
    {

        public String Usuario { get; set; }
        public Principal()
        {
            InitializeComponent();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            this.label_modo.Text = "Usuario: " + Usuario + " -> Modo Administrador";
            this.Mostrar_bienvenida();

        }

        public void Mostrar_bienvenida()
        {
            
            this.mensaje_bienvenida.ContentText = "Bienvenido(a)  "+Usuario+"  al Sistema.";
            this.mensaje_bienvenida.CaptionText = "BIENVENIDO";
            this.mensaje_bienvenida.Show();
            this.ShowInTaskbar = true;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?","Confirmación",MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void label_sesion_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_sesion.Font = new System.Drawing.Font("Arial Unicode MS", 9.75f,
                FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
        }

        private void label_sesion_MouseLeave(object sender, EventArgs e)
        {
            this.label_sesion.Font = new System.Drawing.Font("Arial Unicode MS", 9.75f,
               FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void mnuGestionar_informacion_Click(object sender, EventArgs e)
        {
            if (panel_conntenedor.Controls.Count != 0)
            {
                panel_conntenedor.Controls.RemoveAt(0);
            }
            Gestionar_informacion gestion = new Gestionar_informacion();
            gestion.Visible = true;
            panel_conntenedor.Controls.Add(gestion);

        }

        private void label_sesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Dispose();
            }
        }

        private void mnuVer_citas_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            cita.ShowDialog();          
        }

        private void reportesDeNómnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel_conntenedor.Controls.Count != 0)
            {
                panel_conntenedor.Controls.RemoveAt(0);
            }
            Reporte_de_nomina gestion = new Reporte_de_nomina();
            gestion.Visible = true;
            panel_conntenedor.Controls.Add(gestion);
        }

        private void reporteDeDeduccionesDeSalariosPorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel_conntenedor.Controls.Count != 0)
            {
                panel_conntenedor.Controls.RemoveAt(0);
            }
            Reporte_nomina_empleados gestion= new Reporte_nomina_empleados();
            gestion.Visible = true;
            panel_conntenedor.Controls.Add(gestion);
        }

        private void asistenciaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel_conntenedor.Controls.Count != 0)
            {
                panel_conntenedor.Controls.RemoveAt(0);
            }
            Gestion_de_asistencias gestion = new Gestion_de_asistencias();
            gestion.Visible = true;
            panel_conntenedor.Controls.Add(gestion);
        }

        private void mnuNomina_Click(object sender, EventArgs e)
        {
            if (panel_conntenedor.Controls.Count != 0)
            {
                panel_conntenedor.Controls.RemoveAt(0);
            }
            Nomina gestion = new Nomina();
            gestion.Visible = true;
            panel_conntenedor.Controls.Add(gestion);
        }

     }
   
    }

