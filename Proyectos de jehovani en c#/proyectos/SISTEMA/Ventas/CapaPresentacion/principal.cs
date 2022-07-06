using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            this.Show();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CATALOGOS.frmcategoria f = new CATALOGOS.frmcategoria();

            f.ShowDialog();
        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CATALOGOS.frmunidadesMedidas f = new CATALOGOS.frmunidadesMedidas();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CATALOGOS.frmproductos f = new CATALOGOS.frmproductos();
            f.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            OPERACIONES.frmclientes f = new OPERACIONES.frmclientes();
            f.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OPERACIONES.frmproveedor f = new OPERACIONES.frmproveedor();
            f.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            COMPRAS.frmcompras f = new COMPRAS.frmcompras();

            f.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            COMPRAS.frminventario f = new COMPRAS.frminventario();
            f.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            COMPRAS.frmbusqCompras f = new COMPRAS.frmbusqCompras();

            f.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            VENTAS.frmventas f = new VENTAS.frmventas();

            f.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            VENTAS.frmcredito f = new VENTAS.frmcredito();

            f.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            VENTAS.frmbusqVentas f = new VENTAS.frmbusqVentas();

            f.ShowDialog();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            INFORMES.fInfInventario f = new INFORMES.fInfInventario();
            f.ShowDialog();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            INFORMES.ffactura f = new INFORMES.ffactura();

            f.ShowDialog();
        }

        private void toolStripButton13_Click_1(object sender, EventArgs e)
        {
          

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
