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
    public partial class frmempleado : Form
    {
        int row;
        string id;
        
        public frmempleado()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(id);
           
            if (btnGuardar.ButtonText == "Guadar")
            {
                string r = tblnEmpleado.insertar(txtcontra.Text,txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtcorreo.Text, txtDireccion.Text);
                MessageBox.Show("datos guardados");

                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                
                txtDireccion.Clear();
            }
            else
            {
                string h = tblnCliente.ActualizarCliente(z, txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                cargargrid();
                btnGuardar.ButtonText = "Guardar";
            }

        }
        public void cargargrid()
        {

            DataTable datos = tblnCliente.LlenarCliente();

            dgvDatosEm.AllowUserToAddRows = true;
            dgvDatosEm.DataSource = datos;
            dgvDatosEm.AllowUserToAddRows = false;

            if (datos.Rows.Count == 0)
            {
                dgvDatosEm.ContextMenuStrip = null;
            }
            else
            {

                //dgvDatosEm.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            cargargrid();
        }
    }
}
