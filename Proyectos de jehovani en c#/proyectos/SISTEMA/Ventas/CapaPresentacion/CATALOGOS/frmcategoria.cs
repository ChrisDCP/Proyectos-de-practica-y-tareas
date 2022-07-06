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
namespace CapaPresentacion.CATALOGOS
{
    public partial class frmcategoria : Form
    {
       //Inicio de la estructura Categoria
        int row = 0;
        public frmcategoria()
        {
            InitializeComponent();
        }

        private void frmcategoria_Load(object sender, EventArgs e)
        {
            this.Show();
            lbcodigo.Text =  string.Format("{0:00000}", NCategoria.CODIGO());
            CargarGrid();

            txtnombre.Focus();
        }

        private void CargarGrid(string texto ="")
        {

            DataTable datos = NCategoria.LISTAR(texto);
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;


            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    btguardar.Enabled = false;
                }
                else
                {
                    btguardar.Enabled = true;
                    btguardar.Focus();
                }
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                btguardar.Enabled = false;
            }
            else
            {

               
                btguardar.Enabled = true;
            }

            CargarGrid(txtnombre.Text);
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            btguardar.Text = "Guardar";
            lbcodigo.Text = string.Format("{0:00000}", NCategoria.CODIGO());
            btnuevo.Enabled = false;
            txtnombre.Clear();
            txtnombre.Enabled = true;
            txtnombre.Focus();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (btguardar.Text == "Guardar")
            {
                if (NCategoria.GUARDAR(txtnombre.Text.Trim()) == 1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtnombre.Enabled = false;
                    btnuevo.Enabled = true;
                    btguardar.Enabled = false;
                    btnuevo.Focus();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnombre.Focus();
                }
            }
            else
            {
                if (NCategoria.EDITAR(int.Parse(lbcodigo.Text), txtnombre.Text.Trim()) == 1)
                {
                    MessageBox.Show("Datos Actualizados", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    txtnombre.Enabled = false;
                    btnuevo.Enabled = true;
                    btguardar.Enabled = false;
                    btnuevo.Focus();
                }else
                {
                    MessageBox.Show("Error al actualizar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnombre.Focus();
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
                lbcodigo.Text = string.Format("{0:00000}", NCategoria.CODIGO());
                txtnombre.Clear();
                btguardar.Text = "Guardar";
                txtnombre.Focus();

            }
        }

        private void gridview_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void gridview_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.ReadOnly = true;

            switch (e.Column.DataPropertyName)
            {
                case "ID_Categoria":
                    {
                        e.Column.HeaderText = "Codigo";
                        e.Column.Width = 80;
                        break;
                    }
                case "Nombre":
                    {
                        e.Column.HeaderText = "Categorias";
                        e.Column.Width = 280;
                        break;
                    }
            }

           
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcodigo.Text = gridview.Rows[row].Cells[0].Value.ToString().Trim();
            txtnombre.Text = gridview.Rows[row].Cells[1].Value.ToString().Trim();

            btguardar.Text = "Modificar";


        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (NCategoria.ELIMINAR(int.Parse(gridview.Rows[row].Cells[0].Value.ToString().Trim())) == 1)
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

        
    }
}
