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
    public partial class frmcredito : Form
    {
        float abono_total;
        float total_Credito;
        int id_credito;
        int id_venta;
        public frmcredito()
        {
            InitializeComponent();
        }

        private void frmcredito_Load(object sender, EventArgs e)
        {
            this.Show();



            lista.DataSource = NCredito.ListarVentaCredito();
            lista.ValueMember = "ID_Credito";
            lista.DisplayMember = "ID_Venta";
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



            c.PrintToPrinter(1, true, 0, 0);

        }
        private void CargarGrid()
        {
            if (id_credito > 0 && id_venta > 0)
            {
                
                txtcantidad.Enabled = true;

                DataTable d = NVenta.LISTAR(id_venta);
                try
                {
                    DataRow fila = d.Rows[0];
                    lbcodigo.Text = string.Format("{0:00000}", id_venta);
                    txtcliente.Text = fila["Cli"].ToString().Trim();
                    datFecha.Value = DateTime.Parse(fila["FechaVenta"].ToString().Trim());
                    total_Credito = float.Parse(fila["Total"].ToString().Trim());
                    lbtotal.Text = string.Format("{0,-28:C2}", float.Parse(fila["Total"].ToString().Trim()));

                    gridview.AllowUserToAddRows = true;
                    gridview.DataSource = NAbono.ListarAbono(id_credito);
                    gridview.AllowUserToAddRows = false;

                    abono_total = 0;
                    for (int i = 0; i < gridview.Rows.Count; i++)
                    {
                        gridview.Rows[i].HeaderCell.Value = (i + 1).ToString();


                        abono_total += float.Parse(gridview.Rows[i].Cells[1].Value.ToString());
                    }
                    txtcantidad.Maximum = decimal.Parse((total_Credito - abono_total).ToString());

                }
                catch
                {

                }
                lbsaldo_actual.Text = string.Format("{0,-28:C2}", (total_Credito - abono_total));
               
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_credito = int.Parse(((DataRowView)lista.SelectedItem).Row.ItemArray[0].ToString());

            id_venta = int.Parse((((DataRowView)lista.SelectedItem)["ID_venta"]).ToString());

            txtcantidad.Value = 0;
            CargarGrid();
     
           

        }

        private void gridview_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.ReadOnly = true;

            switch (e.Column.DataPropertyName)
            {
                case "ID_Abono": e.Column.Visible = false; break;
                case "CantidadAbono": { e.Column.HeaderText = "Abono"; e.Column.Width = 180; break; }
                case "Fecha_abono": { e.Column.HeaderText = "Fecha de Abono"; e.Column.Width = 400; break; }
            }
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            btnuevo.Enabled = false;
            lbsaldo_actual.Text = string.Format("{0,-28:C2}", (total_Credito - abono_total));
            txtcantidad.Value = 0;
            gridview.Enabled = true;
            lista.Enabled = true;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (total_Credito > abono_total)
            {
                if (NAbono.GUARDAR(float.Parse(txtcantidad.Value.ToString()), databono.Value, id_credito) == 1)
                {
                    MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    
                    if (total_Credito == abono_total)
                    {
                        if (MessageBox.Show("La factura ha sido cancelada ¿Desea imprimirla?", "Petición de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Imprimir(id_venta);
                        }
                    }


                  
                    gridview.Enabled = false;
                    total_Credito = 0;
                    abono_total = 0;
                    lista.Enabled = false;
                    txtcantidad.Enabled = false;
                    databono.Enabled = false;
                    btguardar.Enabled = false;
                    btnuevo.Enabled = true;
                    btnuevo.Focus();
                }
                else
                {
                    MessageBox.Show("Error, al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcantidad.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se puede depositar mas abono ha este credito", "Credito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtcantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtcantidad.Value > 0)
                btguardar.Enabled = true;
            else
                btguardar.Enabled = false;
        }
    }
}
