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
using CrystalDecisions.CrystalReports.Engine;
using CapaPresentacion.INFORMES;
namespace CapaPresentacion.VENTAS
{
    public partial class frmventas : Form
    {
        float total;
        decimal precio_venta;
        public frmventas()
        {
            InitializeComponent();
        }

        private void frmventas_Load(object sender, EventArgs e)
        {
            this.Show();

            lbcodigo.Text = string.Format("{0:00000}", NVenta.CODIGO());

            cbcliente.DataSource = NCliente.LISTARCOMBO();
            cbcliente.ValueMember = "id_Cliente";
            cbcliente.DisplayMember = "Cli";

            cbproducto.DataSource = NProducto.LISTARCOMBO();
            cbproducto.ValueMember = "ID_Producto";
            cbproducto.DisplayMember = "Nombre";

            if (cbproducto.SelectedValue != null)
                txtidProducto.Text = string.Format("{0:00000}", int.Parse(cbproducto.SelectedValue.ToString().Trim()));

            cbcliente.Focus();
        }


        //Metodo para imprimir facturas
        private void Imprimir(int id)
        {
            CrFactura c = new CrFactura();

            TextObject lbcodigo = null;
            TextObject lbcliente = null;
            TextObject lbfecha = null;
            TextObject lbtotal = null;

            DataTable datos = NVenta.LISTAR(id);

            DataRow row = datos.Rows[0];

            lbcodigo = (TextObject)c.Section1.ReportObjects["lbcodigo"];
            lbcodigo.Text = string.Format("{0:00000}", int.Parse(row["ID_Venta"].ToString().Trim()));

            lbfecha = (TextObject)c.Section1.ReportObjects["lbfecha"];
            lbfecha.Text = DateTime.Parse(row["FechaVenta"].ToString().Trim()).ToShortDateString();

            lbtotal = (TextObject)c.Section1.ReportObjects["lbtotal"];
            lbtotal.Text = string.Format("{0,-28:C2}", float.Parse(row["Total"].ToString().Trim()));

            lbcliente = (TextObject)c.Section1.ReportObjects["lbcliente"];
            lbcliente.Text = row["Cli"].ToString().Trim();



            c.SetDataSource(NDetalles_Venta.LISTAR(id));



            c.PrintToPrinter(1, true,0,0);

        }
        private void cbcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbcliente.Text))
                {
                    cbcliente.Focus();
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

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_producto = int.Parse((((DataRowView)cbproducto.SelectedItem)["ID_Producto"]).ToString());
            txtidProducto.Text = string.Format("{0:00000}", id_producto);

            txtunidadMedida.Text = NUnidadMedida.MOSTRARUNIDAD(id_producto);
            DataTable d = NInventario.MOSTRAR_EXISTENCIA_PRECIO(id_producto);

            try
            {
                DataRow fila = d.Rows[0];

                txtexistencia.Text = fila["Cantidad"].ToString().Trim();
                decimal precioCompra = decimal.Parse(fila["precio_Compra"].ToString().Trim());
                decimal porc = decimal.Parse(fila["porc_venta"].ToString().Trim());


                //Obtenemos el porcentaje de venta en cordobas
                decimal porc_ventaCordoba = (precioCompra * porc) / 100;

                //Obtenemos el precio de venta
                precio_venta = precioCompra + porc_ventaCordoba;

                //Le damos el formato de cordoba definido por el sistema
                lbprecioVenta.Text = string.Format("{0,-28:C2}", precio_venta);

                
            }
            catch
            {

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
                    btagregar.Enabled = true;
                    btagregar.Focus();
                }
            }
        }

        private void txtcantidad_ValueChanged(object sender, EventArgs e)
        {
            lbsubtotal.Text = string.Format("{0,-28:C2}", txtcantidad.Value * precio_venta);
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            gridview.AllowUserToAddRows = true;
            gridview.Rows.Add(txtidProducto.Text.Trim(), cbproducto.Text.Trim(), txtcantidad.Value, precio_venta, (txtcantidad.Value * precio_venta));
            gridview.AllowUserToAddRows = false;

            for (int i = 0; i < gridview.Rows.Count; i++)
                gridview.Rows[i].HeaderCell.Value = (i + 1).ToString();


            total += float.Parse(txtcantidad.Value.ToString()) * float.Parse(precio_venta.ToString());

            //Le damos el formato de cordoba definido por el sistema
            lbtotal.Text = string.Format("{0,-28:C2}", total);

            cbproducto.SelectedIndex = 0;

            txtcantidad.Value = 0;
            btguardar.Enabled = true;

            cbproducto.Focus();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            btnuevo.Enabled = false;
            chcredito.Checked = false;
            group1.Enabled = true;
            group2.Enabled = true;
            group3.Enabled = true;
            lbcodigo.Text = string.Format("{0:00000}", NVenta.CODIGO());
            gridview.Rows.Clear();
            total = 0;
            lbtotal.Text = string.Format("{0,-28:C2}", total);
            txtcantidad.Value = 0;
            cbcliente.Focus();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (NVenta.GUARDAR(chcredito.Checked, int.Parse(cbcliente.SelectedValue.ToString()), datFecha.Value, total) == 1)
            {
                int id_venta = int.Parse(lbcodigo.Text);

                foreach (DataGridViewRow txt in gridview.Rows)
                {
                    NDetalles_Venta.GUARDAR(float.Parse(txt.Cells[2].Value.ToString()), float.Parse(txt.Cells[3].Value.ToString()), id_venta, int.Parse(txt.Cells[0].Value.ToString()), float.Parse(txt.Cells[4].Value.ToString()));
                }
                MessageBox.Show("Factura Realizada", "Facturar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("¿Desea imprimir la factura?", "Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Imprimir(id_venta);
                }
                group1.Enabled = false;
                group2.Enabled = false;
                group3.Enabled = false;
                btguardar.Enabled = false;
                btnuevo.Enabled = true;
                btnuevo.Focus();
            }else
            {
                MessageBox.Show("Error al factura","Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbproducto.Focus();
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
