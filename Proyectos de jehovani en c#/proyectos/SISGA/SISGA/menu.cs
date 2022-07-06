using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGA
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        private void line_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            line.Width = lbl1.Width;
            line.Left = lbl1.Left;
            us11.Visible = false;
            us11.BringToFront();
            transi.ShowSync(us11);
           
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            line.Width = lbl2.Width;
            line.Left = lbl2.Left;
            uc21.Visible = true;
            uc21.BringToFront();
            transi.ShowSync(uc21);

           
           
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            line.Width = lbl3.Width;
            line.Left = lbl3.Left;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            
            

            
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //timermenu.Start();
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void menu_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void menu_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fcs = new Form1();
            fcs.Show();
            this.Hide();
        }

        private void uc21_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncerrarCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
