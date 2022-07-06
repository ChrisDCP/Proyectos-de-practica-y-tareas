using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGA
{
    public partial class uc2 : UserControl
    {
        public uc2()
        {
            InitializeComponent();
        }
        public void animateth()
        {
            hideCOntrols();
            animacion.Start();
        }

        private void animacion_Tick(object sender, EventArgs e)
        {
            animacion.Stop();

            showcontrols();
        }
        void showcontrols()
        {
            foreach (Control item in this.Controls)
            {
                animate.ShowSync(item);
                Application.DoEvents();
            }
        }
        public void hideCOntrols()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
                Application.DoEvents();
            }
        }

        private void uc2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            frmcliente fcli = new frmcliente();
            fcli.Show();

            this.Hide();
            
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            frmcampañacultivo fcc = new frmcampañacultivo();
            fcc.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            frmproveedor prv = new frmproveedor();
            prv.Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            frmsemilla fsm = new frmsemilla();
            fsm.Show();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            frmbodega fb = new frmbodega();
            fb.Show();
        }

        private void bunifuTileButton12_Click(object sender, EventArgs e)
        {
            frmproducto fpd = new frmproducto();
            fpd.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            frmproduccion fp = new frmproduccion();
            fp.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            frmventas frv = new frmventas();
            frv.Show();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            frmcontrolplagas fcp = new frmcontrolplagas();
            fcp.Show();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            frmmaquinaria fmq = new frmmaquinaria();
            fmq.Show();
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            frmcompra fcom = new frmcompra();
            fcom.Show();
        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            frmempleado fem = new frmempleado();
            fem.Show();
        }
    }
}
