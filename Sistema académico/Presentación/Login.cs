using Sistema_académico.Datos;
using Sistema_académico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Sistema_académico.Presentación
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        private String Usuario, Contraseña;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcepta_Click(object sender, EventArgs e)
        {
            Usuario = this.txtUsuario.Text.Trim();
            Contraseña = this.txtContraseña.Text.Trim();
            this.Hide();
            Principal prop = new Principal();
            prop.Usuario = Usuario;
            prop.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelRegistrarNuevoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            this.labelRegistrarNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9f,
                FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
        }

        private void labelRegistrarNuevoUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.labelRegistrarNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9f,
              FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
