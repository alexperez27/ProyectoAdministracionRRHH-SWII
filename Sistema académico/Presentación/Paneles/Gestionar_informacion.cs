using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_académico.Datos;
using Sistema_académico.Negocio;
using System.Threading;

namespace Sistema_académico.Presentación.Paneles
{
    public partial class Gestionar_informacion : UserControl
    {
       
        public Gestionar_informacion()
        {
            InitializeComponent();
            cargarTablaEmpleados(); 
        }

        private void cargarTablaEmpleados()
        {
            Thread myThread = new Thread(() =>
            {
                DataTable datos = NEmpleados.reporteEmpleados();
                if (datos != null)
                {
                    this.Invoke(new Action(() => {
                        dataTableEstudiantes.Columns.Clear();
                        dataTableEstudiantes.DataSource = datos;
                        this.dataTableEstudiantes.Columns[0].IsVisible = false;
                    }));
                }
                else
                {
                    this.Invoke(new Action(() => {
                        MessageBox.Show(this, "No se pudo cargar la información de los empleados", "Error al cargar información");
                    }));
                }
            });
            myThread.Start();

        }

        /*-----------------------------PANEL DE ESTUDIANTES-----------------------------------------*/
        private void labelParentesco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cargo parent = new Cargo();
            parent.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
           
        }


        private void txtNombre_estudiante_TextChanged(object sender, EventArgs e)
        {
            txtNombre_estudiante.Text = Metodos.Metodo.convertirMayuscula(txtNombre_estudiante.Text);
            txtNombre_estudiante.SelectionStart = txtNombre_estudiante.Text.Length;
        }

        private void txtApellido_estudiante_TextChanged(object sender, EventArgs e)
        {
            txtApellido_estudiante.Text = Metodos.Metodo.convertirMayuscula(txtApellido_estudiante.Text);
            txtApellido_estudiante.SelectionStart = txtApellido_estudiante.Text.Length;
        }
    /*--------------------------------´PANEL DE DOCENTES---------------------------------------*/
        

        private void txtNombre_Docente_TextChanged(object sender, EventArgs e)
        {
            txtNombre_Docente.Text = Metodos.Metodo.convertirMayuscula(txtNombre_Docente.Text);
            txtNombre_Docente.SelectionStart = txtNombre_Docente.Text.Length;
        }

        private void txtApellido_Docente_TextChanged(object sender, EventArgs e)
        {
            txtApellido_Docente.Text = Metodos.Metodo.convertirMayuscula(txtApellido_Docente.Text);
            txtApellido_Docente.SelectionStart = txtApellido_Docente.Text.Length;
        }

       
   
     
        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            string nombre, apellido,direccion,cedula,telefono;
            int genero;
            DEmpleado empleado = new DEmpleado();
            nombre = this.txtNombre_estudiante.Text;
            apellido = this.txtApellido_estudiante.Text;
            direccion = this.radTextBox3.Text;
            cedula = this.radMaskedEditBox2.Text;
            telefono = this.radMaskedEditBox1.Value.ToString();

            if (this.radRadioButton1.IsChecked)//Radio Button Genero Masculino
            {
                genero = DEmpleado.Genero_Hombre;
            }
            else
            {
                genero = DEmpleado.Genero_Mujer;
            }

            if (nombre.Equals(String.Empty))
            {
                MessageBox.Show("El nombre no puede estar vacío");
                return;
            }
            if (apellido.Equals(String.Empty))
            {
                MessageBox.Show("El apellido no puede estar vacío");
                return;
            }
            if (direccion.Equals(String.Empty))
            {
                MessageBox.Show("El direccion no puede estar vacío");
                return;
            }
            if (cedula.Equals(String.Empty))
            {
                MessageBox.Show("La cedula no puede estar vacía");
                return;
            }
            if (telefono.Equals(String.Empty))
            {
                MessageBox.Show("El telefono no puede estar vacío");
                return;
            }


            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Direccion = direccion;
            empleado.Cedula = cedula;
            empleado.Telefono = telefono;
            empleado.Estado = this.radDropDownList1.SelectedItem.Text;
            empleado.IdFichaOcupacional = 1;
            empleado.FechaContratacion = this.radDateTimePicker1.Value;
            empleado.Genero = genero;            

            String resultado=NEmpleados.insertar(empleado);
            if (resultado.Equals("OK"))
            {
                MessageBox.Show("Guardado correctamente");
                this.txtNombre_estudiante.Text=String.Empty;
                this.txtApellido_estudiante.Text = String.Empty;
                this.radTextBox3.Text = String.Empty;
                this.radMaskedEditBox2.Text = String.Empty;
                this.radMaskedEditBox1.Text = String.Empty;
            }
            else
            {
                MessageBox.Show(resultado);
            }

        }
    }        
}
