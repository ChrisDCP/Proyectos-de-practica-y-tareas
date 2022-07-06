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

namespace capapresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string r = Capanegocio.guardarcategoria(txtnomc.Text, txtdesc.Text);
            MessageBox.Show(r);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if ((txtid.Text.Length > 0) && (txtnomc.Text.Length > 0))
            {
                string r = Capanegocio.actualizarcategoria(int.Parse(txtid.Text), txtnomc.Text, txtdesc.Text);
                MessageBox.Show(r);
            }
            else
            {
                MessageBox.Show("debe ingresar datos validos");
            }
        }
        public void llenartBox()
        {
            DataTable tabla = Capanegocio.llenarcategoria(int.Parse(txtid.Text));
            int nr = tabla.Rows.Count;
            if (nr > 0)
            {
                txtnomc.DataBindings.Add("text", Capanegocio.llenarcategoria(int.Parse(txtid.Text)), "categoryname");
                txtdesc.DataBindings.Add("text", Capanegocio.llenarcategoria(int.Parse(txtid.Text)), "description");
            }
            else
            {
                MessageBox.Show("no se encontraron registros asocaiados a esta busqueda");
            }
            DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtnomc.DataBindings.Clear();
            txtdesc.DataBindings.Clear();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                llenartBox();
            }
        }
    }
}
