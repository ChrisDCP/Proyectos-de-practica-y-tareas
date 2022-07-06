using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion.LOGIN
{
    public partial class frmLogin : Form
     {
        int a = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Blanca" && (txtpassword.Text) == "sequeira")
            {
                MessageBox.Show("Acceso Permitido a ", txtnombre.Text);

                //Muestra del Formulario Menu
                principal abrir = new principal();

                abrir.Show();
            }
            else
            {
                a = a + 1;
                if (a == 1)
                {
                    MessageBox.Show("Acceso Denegado");
                    a = 0;
                }

                txtpassword.Clear();
                txtpassword.Focus();
                txtpassword.Select();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    txtpassword.Focus();
                }
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(btnEntrar.Text))
                {
                    btnEntrar.Focus();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
