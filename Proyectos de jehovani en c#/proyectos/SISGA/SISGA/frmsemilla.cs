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
    public partial class frmsemilla : Form
    {
        public frmsemilla()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            us1 ru = new us1();
            ru.Show();
            this.Hide();
        }
    }
}
