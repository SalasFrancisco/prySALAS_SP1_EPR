using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySALAS_SP1_EPR
{
    public partial class frmPrincipal : Form
    {
        int intentos = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mrcDatos_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private TextBox GetTxtUsuario()
        {
            return txtUsuario;
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" &&
                 txtPassword.Text == "@1a" &&
                 (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA")) ||
                 (txtUsuario.Text == "John" &&
                  txtPassword.Text == "*2b" &&
                  lstModulo.Text == "SIST") ||
                  (txtUsuario.Text == "Ceci" &&
                  txtPassword.Text == "*@3c" &&
                  (lstModulo.Text == "ADM" || lstModulo.Text == "VTA")) ||
                 (txtUsuario.Text == "God" &&
                  txtPassword.Text == "*@#4d" &&
                  (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA" || lstModulo.Text == "SIST")))
            {
                this.Hide();
                frmBienvenida f = new frmBienvenida();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
