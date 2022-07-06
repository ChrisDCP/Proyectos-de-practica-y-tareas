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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag ed = new Bunifu.Framework.UI.Drag();

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(txtusu.Text=="Bernis Flores" & txtpas.Text=="bunifu")
            {
                menu men = new menu();
                men.Show();
                this.Hide();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/ServiceLogin/identifier?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F%3Ftab%3Dwm&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=AddSession/");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ed.Grab(this);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ed.Release();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ed.MoveObject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
