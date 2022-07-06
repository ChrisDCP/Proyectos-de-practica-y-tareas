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
namespace CapaPresentacion.INFORMES
{
    public partial class fInfInventario : Form
    {
        public fInfInventario()
        {
            InitializeComponent();
        }

        private void fInfInventario_Load(object sender, EventArgs e)
        {
            this.Show();

            CrInventario c = new CrInventario();



            c.SetDataSource(NInventario.Informe());


            crystalReportViewer1.ReportSource = c;

        }
    }
}
