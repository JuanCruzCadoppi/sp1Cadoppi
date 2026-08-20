using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sp1Cadoppi
{
    public partial class frmLogin : Form
    {
        int intentos = 0; //contador de intentos de acceso
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == "Adm" && txtPassword.Text == "@1a") || 
                (txtUser.Text == "John" && txtPassword.Text == "*2b") || 
                (txtUser.Text == "Ceci" && txtPassword.Text == "@3c") || 
                (txtUser.Text == "God" && txtPassword.Text == "@#4d"))
            {
                this.Hide(); //Ocultar Formulario
                frmInicio f = new frmInicio(); //Crea el frmInicio
                f.Text = txtUser.Text; //asigna el texto del título
                f.ShowDialog(); //visualiza y ejecuta el frmInicio
                this.Show(); //visualiza nuevamente este formulario
            }
            else
            {
                MessageBox.Show("Datos Incorrectos. Acceso Denegado");
                intentos = intentos + 1; //incrementa el contador de intentos fallidos

                if (intentos == 3) //si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
