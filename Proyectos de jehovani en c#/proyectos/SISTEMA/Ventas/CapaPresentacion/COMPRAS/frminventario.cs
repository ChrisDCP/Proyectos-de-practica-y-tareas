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
namespace CapaPresentacion.COMPRAS
{
    public partial class frminventario : Form
    {
        int row;
        public frminventario()
        {
            InitializeComponent();
        }

        private void frminventario_Load(object sender, EventArgs e)
        {
            this.Show();

            CargarGrid();
         
        }

        private void CargarGrid(string producto = "")
        {
            DataTable datos = NInventario.ListarInventario(producto);
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

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtproducto.Text);
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            btnuevo.Enabled = false;

            txtprecio.Value = 0;
            txtporc.Value = 0;
            lbcodProducto.Text = "000000";
            lbproducto.Text = "XXXXXXXXXXXXXX";
            lbprecioVenta.Text = "C$000000";

            txtproducto.Clear();
            txtproducto.Enabled = true;
            txtproducto.Focus();


        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (txtprecio.Value > 0 && txtporc.Value > 0)
            {
               if (NInventario.EDITAR(int.Parse(lbcodProducto.Text),float.Parse(txtprecio.Value.ToString()), float.Parse(txtporc.Value.ToString())) == 1)
               {
                   MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   CargarGrid();
                   txtprecio.Enabled = false;
                   txtporc.Enabled = false;

                   txtproducto.Enabled = false;
                   btguardar.Enabled = false;
                   btnuevo.Enabled = true;
               }else
               {
                   MessageBox.Show("Error al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtprecio.Focus();
               }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                case "Codigo": e.Column.Width = 80; break;
                case "Producto": e.Column.Width = 160; break;
                case "precio_compra": { e.Column.HeaderText = "Precio de Compra"; break; }
                case "porc_venta": { e.Column.HeaderText = "Porc. de Venta"; break; }
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbcodProducto.Text = string.Format("{0:00000}", int.Parse(gridview.Rows[row].Cells[0].Value.ToString().Trim()));
            lbproducto.Text = gridview.Rows[row].Cells[1].Value.ToString();
            txtprecio.Value = decimal.Parse(gridview.Rows[row].Cells[3].Value.ToString());
            txtporc.Value = decimal.Parse(gridview.Rows[row].Cells[4].Value.ToString());

            txtprecio.Enabled = true;
            txtporc.Enabled = true;

            btguardar.Enabled = true;
            
        }
        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtprecio.Value > 0)
                {
                    txtporc.Focus();
                }
            }
        }

        private void txtporc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtporc.Value > 0)
                {
                    btguardar.Focus();
                }
            }
        }
        private void txtprecio_ValueChanged(object sender, EventArgs e)
        {
            //Obtenemos el porcentaje de venta en cordobas
            decimal porc_ventaCordoba = (txtprecio.Value * txtporc.Value) / 100;

            //Obtenemos el precio de venta
            decimal precio_venta = txtprecio.Value + porc_ventaCordoba;

            //Le damos el formato de cordoba definido por el sistema
            lbprecioVenta.Text = string.Format("{0,-28:C2}", precio_venta);
        }

        private void txtporc_ValueChanged(object sender, EventArgs e)
        {
            //Obtenemos el porcentaje de venta en cordobas
            decimal porc_ventaCordoba = (txtprecio.Value * txtporc.Value) / 100;

            //Obtenemos el precio de venta
            decimal precio_venta = txtprecio.Value + porc_ventaCordoba;

            //Le damos el formato de cordoba definido por el sistema
            lbprecioVenta.Text = string.Format("{0,-28:C2}", precio_venta);
        }

       

       
    }
}
