using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness;

namespace SISGA
{
    public partial class frmcliente : Form
    {
        int row;
        string id;
        public frmcliente()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            menu men = new menu();
            men.Show();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
   

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

           /* if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }*/
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          int z=  Convert.ToInt32(id);
            if (btnGuardar.ButtonText=="Guadar")
            {
                string r = tblnCliente.GuardarCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
                MessageBox.Show("datos guardados");

                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
            }
            else
            {
                string h = tblnCliente.ActualizarCliente(z,txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                cargargrid();
                btnGuardar.ButtonText = "Guardar";
            }
 
                   
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtApellido_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtTelefono_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtDireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        public void cargargrid()
        {
            
            DataTable datos = tblnCliente.LlenarCliente();
            
           dgvDatos.AllowUserToAddRows = true;
            dgvDatos.DataSource = datos;
            dgvDatos.AllowUserToAddRows = false;

            if (datos.Rows.Count == 0)
            {
                dgvDatos.ContextMenuStrip = null;
            }
            else
            {
                
               dgvDatos.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            cargargrid();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

             id = dgvDatos.Rows[row].Cells[0].Value.ToString();
            txtNombre.Text = dgvDatos.Rows[row].Cells[1].Value.ToString().Trim();
            txtApellido.Text = dgvDatos.Rows[row].Cells[2].Value.ToString().Trim();
            txtTelefono.Text = dgvDatos.Rows[row].Cells[3].Value.ToString().Trim();
            txtDireccion.Text = dgvDatos.Rows[row].Cells[4].Value.ToString().Trim();
            btnGuardar.ButtonText = "Modifcar";
            txtNombre.Focus();


        }

        private void dgvDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string r = tblnCliente.EliminarCliente(int.Parse(dgvDatos.Rows[row].Cells[0].Value.ToString()));

                    MessageBox.Show("Datos eliminados", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargargrid();
               
            }

            else
            {
                MessageBox.Show("Error, el registro esta siendo utilizado", "Registro Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
            
    }
}

