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
    public partial class frmcompras : Form
    {
        float total;
        public frmcompras()
        {
            InitializeComponent();
        }

        private void frmcompras_Load(object sender, EventArgs e)
        {
            this.Show();

            lbcodigo.Text = string.Format("{0:00000}", NCompra.CODIGO());

            cbproveedor.DataSource = NProveedor.LISTAR_COMBO();
            cbproveedor.ValueMember = "ID_Proveedor";
            cbproveedor.DisplayMember = "Compania";

            cbproducto.DataSource = NProducto.LISTARCOMBO();
            cbproducto.ValueMember = "ID_Producto";
            cbproducto.DisplayMember = "Nombre";
            
            if (cbproducto.SelectedValue != null)
                  txtidProducto.Text = string.Format("{0:00000}", int.Parse(cbproducto.SelectedValue.ToString().Trim()));


            cbproveedor.Focus();

            
        }

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_producto = int.Parse((((DataRowView)cbproducto.SelectedItem)["ID_Producto"]).ToString());
            txtidProducto.Text = string.Format("{0:00000}", id_producto);

            txtunidadMedida.Text = NUnidadMedida.MOSTRARUNIDAD(id_producto);

        }

        private void cbproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbproveedor.Text))
                {
                    cbproveedor.Focus();
                }
                else
                {
     
                    cbproducto.Focus();
                }
            }
        }

        private void cbproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbproducto.Text))
                {
                    cbproducto.Focus();
                }
                else
                {
                    txtcantidad.Enabled = true;
                    txtcantidad.Focus();
                }
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtcantidad.Text))
                {
                    txtcantidad.Focus();

                }
                else
                {
                    txtprecio.Enabled = true;
                    txtprecio.Focus();
                }
            }
        }

        private void txtprecio_ValueChanged(object sender, EventArgs e)
        {
            //Le damos el formato de cordoba definido por el sistema
            lbsubtotal.Text = string.Format("{0,-28:C2}", txtcantidad.Value * txtprecio.Value);

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            gridview.AllowUserToAddRows = true;
            gridview.Rows.Add(txtidProducto.Text.Trim(), cbproducto.Text.Trim(), txtcantidad.Value, txtprecio.Value, (txtcantidad.Value * txtprecio.Value).ToString());
            gridview.AllowUserToAddRows = false;

            for (int i = 0;i < gridview.Rows.Count;i++)
                gridview.Rows[i].HeaderCell.Value = (i + 1).ToString();


            total += float.Parse(txtcantidad.Value.ToString()) * float.Parse(txtprecio.Value.ToString());

            //Le damos el formato de cordoba definido por el sistema
            lbtotal.Text = string.Format("{0,-28:C2}", total);

            cbproducto.SelectedIndex = 0;
            txtcantidad.Value = 0;
            txtprecio.Value = 0;

            btguardar.Enabled = true;
           
            cbproducto.Focus();



        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            btnuevo.Enabled = false;
            group1.Enabled = true;
            group2.Enabled = true;
            group3.Enabled = true;
            lbcodigo.Text = string.Format("{0:00000}", NCompra.CODIGO());
            gridview.Rows.Clear();
            total = 0;
            lbtotal.Text = string.Format("{0,-28:C2}", total);
            txtcantidad.Value = 0;
            txtprecio.Value = 0;
            cbproveedor.Focus();

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (NCompra.GUARDAR(int.Parse(cbproveedor.SelectedValue.ToString()), datFecha.Value, total) == 1)
            {
                int id_compra = int.Parse(lbcodigo.Text);

                foreach (DataGridViewRow txt in gridview.Rows)
                {
                    
                    NDetalles_Compra.GUARDAR(float.Parse(txt.Cells[3].Value.ToString()), float.Parse(txt.Cells[2].Value.ToString()), float.Parse(txt.Cells[4].Value.ToString()), id_compra, int.Parse(txt.Cells[0].Value.ToString()));

                }
                MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                group1.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = false;
                btguardar.Enabled = false;
                btnuevo.Enabled = true;
                btnuevo.Focus();

                
            }
            else
            {
                MessageBox.Show("Error al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbproducto.Focus();
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
