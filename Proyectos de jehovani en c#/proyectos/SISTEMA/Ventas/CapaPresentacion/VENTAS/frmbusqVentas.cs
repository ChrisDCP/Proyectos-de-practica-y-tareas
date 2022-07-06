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
namespace CapaPresentacion.VENTAS
{
    public partial class frmbusqVentas : Form
    {
        public frmbusqVentas()
        {
            InitializeComponent();
        }

        private void frmbusqVentas_Load(object sender, EventArgs e)
        {
            this.Show();
            txtcodigo.Focus();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsUpper(e.KeyChar) || char.IsLower(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtcodigo.Text))
                {
                    DataTable d = NVenta.LISTAR(int.Parse(txtcodigo.Text));

                    try
                    {
                        DataRow fila = d.Rows[0];
                        txtcliente.Text = fila["Cli"].ToString().Trim();
                        datFecha.Value = DateTime.Parse(fila["FechaVenta"].ToString().Trim());
                        lbtotal.Text = string.Format("{0,-28:C2}", float.Parse(fila["Total"].ToString().Trim()));
                        bool credito = bool.Parse(fila["Credito"].ToString());
                        if (credito)
                            lbcredito.Visible = true;
                        else
                            lbcredito.Visible = false;

                        gridview.AllowUserToAddRows = true;
                        gridview.DataSource = NDetalles_Venta.LISTAR(int.Parse(txtcodigo.Text));
                        gridview.AllowUserToAddRows = false;

                        for (int i = 0; i < gridview.Rows.Count; i++)
                            gridview.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    }
                    catch { }

                }
            }
        }
    }
}
