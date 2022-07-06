using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion.OPERACIONES
{
    public partial class frmproveedor : Form
    {
        int row;
        public frmproveedor()
        {
            InitializeComponent();
        }

        private void frmproveedor_Load(object sender, EventArgs e)
        {
            this.Show();
            lbcodigo.Text = string.Format("{0:00000}", NProveedor.CODIGO());
            CargarGrid();
            txtruc.Focus();
        }

        private void CargarGrid(string compania = "")
        {
            DataTable datos = NProveedor.LISTAR(compania);
            gridview.AllowUserToAddRows = true;
            gridview.DataSource = datos;
            gridview.AllowUserToAddRows = false;

            if (datos.Rows.Count == 0)
            {
                gridview.ContextMenuStrip = null;
            }
            else
            {
                gridview.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtruc.MaskCompleted)
            {
                txtcompania.Enabled = true;
                txtcompania.Focus();
            }
            else
            {
                txtruc.Focus();
            }
        }

        private void txtcompania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtcompania.Text))
                {
                    txtcompania.Focus();
                }
                else
                {
                    txtprimerNombre.Enabled = true;
                    txtprimerNombre.Focus();
                }
            }
        }

        private void txtprimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtprimerNombre.Text))
                {
                    txtprimerNombre.Focus();
                }
                else
                {
                    txtSegundoNombre.Enabled = true;
                    txtSegundoNombre.Focus();
                }
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSegundoNombre.Text))
                {
                    txtSegundoNombre.Focus();
                }
                else
                {
                    txtprimerApellido.Enabled = true;
                    txtprimerApellido.Focus();
                }
            }
        }

        private void txtprimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtprimerApellido.Text))
                {
                    txtprimerApellido.Focus();
                }
                else
                {
                    txtsegundoApellido.Enabled = true;
                    txtsegundoApellido.Focus();
                }
            }
        }

        private void txtsegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtprimerApellido.Text))
                {
                    txtprimerApellido.Focus();
                }
                else
                {
                    txttelefono.Enabled = true;
                    txttelefono.Focus();
                }
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                txtcorreo.Enabled = true;
                txtcorreo.Focus();

            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtcorreo.Text))
                {
                    txtcorreo.Focus();
                }
                else
                {
                    txtdireccion.Enabled = true;
                    txtdireccion.Focus();
                }
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtdireccion.Text))
                {
                    txtdireccion.Focus();
                }
                else
                {
                    btguardar.Enabled = true;
                    btguardar.Focus();
                }
            }
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            lbcodigo.Text = string.Format("{0:00000}", NProveedor.CODIGO());
            btguardar.Text = "Guardar";
            btnuevo.Enabled = false;
            txtruc.Clear();
            txtcompania.Clear();
            txtprimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtprimerApellido.Clear();
            txtsegundoApellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtruc.Enabled = true;
            txtruc.Focus();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (btguardar.Text == "Guardar")
            {
                if (!(string.IsNullOrWhiteSpace(txtruc.Text) || string.IsNullOrWhiteSpace(txtcompania.Text) || string.IsNullOrWhiteSpace(txtprimerNombre.Text) || string.IsNullOrWhiteSpace(txtSegundoNombre.Text) || string.IsNullOrWhiteSpace(txtprimerApellido.Text) || string.IsNullOrWhiteSpace(txtsegundoApellido.Text) || string.IsNullOrWhiteSpace(txtcorreo.Text) || string.IsNullOrWhiteSpace(txtdireccion.Text)))
                {
                    if (NProveedor.GUARDAR(txtruc.Text.Trim(),txtcompania.Text.Trim(), txtprimerNombre.Text.Trim(), txtSegundoNombre.Text.Trim(), txtprimerApellido.Text.Trim(), txtsegundoApellido.Text.Trim(), txttelefono.Text.Trim(),txtcorreo.Text.Trim(), txtdireccion.Text.Trim()) == 1)
                    {
                        MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        txtruc.Enabled = false;
                        txtcompania.Enabled = false;
                        txtprimerNombre.Enabled = false;
                        txtSegundoNombre.Enabled = false;
                        txtprimerApellido.Enabled = false;
                        txtsegundoApellido.Enabled = false;
                        txttelefono.Enabled = false;
                        txtcorreo.Enabled = false;
                        txtdireccion.Enabled = false;
                        btguardar.Enabled = false;
                        btnuevo.Enabled = true;
                        btnuevo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtruc.Focus();
                    }
                }
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(txtruc.Text) || string.IsNullOrWhiteSpace(txtcompania.Text) || string.IsNullOrWhiteSpace(txtprimerNombre.Text) || string.IsNullOrWhiteSpace(txtSegundoNombre.Text) || string.IsNullOrWhiteSpace(txtprimerApellido.Text) || string.IsNullOrWhiteSpace(txtsegundoApellido.Text) || string.IsNullOrWhiteSpace(txtcorreo.Text) || string.IsNullOrWhiteSpace(txtdireccion.Text)))
                {
                    if (NProveedor.EDITAR(int.Parse(lbcodigo.Text), txtruc.Text.Trim(), txtcompania.Text.Trim(), txtprimerNombre.Text.Trim(), txtSegundoNombre.Text.Trim(), txtprimerApellido.Text.Trim(), txtsegundoApellido.Text.Trim(), txttelefono.Text.Trim(), txtcorreo.Text.Trim(), txtdireccion.Text.Trim()) == 1)
                    {
                        MessageBox.Show("Datos Actualizados", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        txtruc.Enabled = false;
                        txtcompania.Enabled = false;
                        txtprimerNombre.Enabled = false;
                        txtSegundoNombre.Enabled = false;
                        txtprimerApellido.Enabled = false;
                        txtsegundoApellido.Enabled = false;
                        txttelefono.Enabled = false;
                        txtcorreo.Enabled = false;
                        txtdireccion.Enabled = false;
                        btguardar.Enabled = false;
                        btnuevo.Enabled = true;
                        btnuevo.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtruc.Focus();
                    }
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtbuscar.Text.Trim());
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void gridview_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.ReadOnly = true;
            switch (e.Column.DataPropertyName)
            {
                case "ID_Proveedor": { e.Column.Width = 70; e.Column.Visible = false; break; }
                case "Num_Ruc": { e.Column.Width = 130; e.Column.HeaderText = "Nº Ruc"; break; }
                case "Nombre_Compañia": { e.Column.Width = 130; e.Column.HeaderText = "Compañia"; break; }
                case "Primer_Nombre": { e.Column.Width = 75; e.Column.HeaderText = "Primer Nombre"; break; }
                case "Segundo_Nombre": { e.Column.Width = 75; e.Column.HeaderText = "Segundo Nombre"; break; }
                case "Primer_Apellido": { e.Column.Width = 75; e.Column.HeaderText = "Primer Apellido"; break; }
                case "Segundo_Apellido": { e.Column.Width = 75; e.Column.HeaderText = "Segundo Apellido"; break; }
                case "Telefono": e.Column.Width = 80; break;
                case "Correo_Electronico": { e.Column.HeaderText = "Email"; break; }
                case "Direccion": e.Column.Width = 140; break;
            }
        }

        private void gridview_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcodigo.Text = string.Format("{0:00000}", int.Parse(gridview.Rows[row].Cells[0].Value.ToString()));

            txtruc.Text = gridview.Rows[row].Cells[1].Value.ToString().Trim();
            txtcompania.Text = gridview.Rows[row].Cells[2].Value.ToString().Trim();
            txtprimerNombre.Text = gridview.Rows[row].Cells[3].Value.ToString().Trim();
            txtSegundoNombre.Text = gridview.Rows[row].Cells[4].Value.ToString().Trim();
            txtprimerApellido.Text = gridview.Rows[row].Cells[5].Value.ToString().Trim();
            txtsegundoApellido.Text = gridview.Rows[row].Cells[6].Value.ToString().Trim();
            txttelefono.Text = gridview.Rows[row].Cells[7].Value.ToString().Trim();
            txtcorreo.Text = gridview.Rows[row].Cells[8].Value.ToString().Trim();
            txtdireccion.Text = gridview.Rows[row].Cells[9].Value.ToString().Trim();

            txtcompania.Enabled = true;
            txtprimerNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
            txtprimerApellido.Enabled = true;
            txtsegundoApellido.Enabled = true;
            txttelefono.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;

            btguardar.Text = "Modificar";
            btguardar.Enabled = true;
            txtruc.Focus();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (NProveedor.ELIMINAR(int.Parse(gridview.Rows[row].Cells[0].Value.ToString().Trim())) == 1)
                {
                    MessageBox.Show("Datos eliminados", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error, el registro esta siendo utilizado", "Registro Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            if (btguardar.Text == "Guardar")
            {
                this.Close();
            }
            else
            {
                lbcodigo.Text = string.Format("{0:00000}", NProveedor.CODIGO());
                btguardar.Text = "Guardar";
                btnuevo.Enabled = false;

                txtcompania.Enabled = false;
                txtprimerNombre.Enabled = false;
                txtSegundoNombre.Enabled = false;
                txtprimerApellido.Enabled = false;
                txtsegundoApellido.Enabled = false;
                txttelefono.Enabled = false;
                txtcorreo.Enabled = false;
                txtdireccion.Enabled = false;
                btguardar.Enabled = false;

                txtruc.Clear();
                txtcompania.Clear();
                txtprimerNombre.Clear();
                txtSegundoNombre.Clear();
                txtprimerApellido.Clear();
                txtsegundoApellido.Clear();
                txttelefono.Clear();
                txtcorreo.Clear();
                txtdireccion.Clear();
                txtruc.Enabled = true;
                txtruc.Focus();
            }
        }
    }
}
