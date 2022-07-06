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
namespace CapaPresentacion.INFORMES
{
    public partial class ffactura : Form
    {
        public ffactura()
        {
            InitializeComponent();
        }

        private void ffactura_Load(object sender, EventArgs e)
        {
            this.Show();

            CrFactura c = new CrFactura();

            TextObject lbcodigo = null;
            TextObject lbcliente = null;
            TextObject lbfecha = null;
            TextObject lbtotal = null;

            DataTable datos = NVenta.LISTAR(4);

            DataRow row = datos.Rows[0];

            lbcodigo = (TextObject)c.Section1.ReportObjects["lbcodigo"];
            lbcodigo.Text = string.Format("{0:00000}", int.Parse(row["ID_Venta"].ToString().Trim()));

            lbfecha = (TextObject)c.Section1.ReportObjects["lbfecha"];
            lbfecha.Text = DateTime.Parse(row["FechaVenta"].ToString().Trim()).ToShortDateString();

            lbtotal = (TextObject)c.Section1.ReportObjects["lbtotal"];
            lbtotal.Text = string.Format("{0,-28:C2}",float.Parse(row["Total"].ToString().Trim()));

            lbcliente = (TextObject)c.Section1.ReportObjects["lbcliente"];
            lbcliente.Text = row["Cli"].ToString().Trim();



            c.SetDataSource(NDetalles_Venta.LISTAR(4));




            crystalReportViewer1.ReportSource = c;
        }
    }
}
