using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnBackhome_Click(object sender, EventArgs e)
        {
            Beranda frm1 = new Beranda();
            frm1.ShowDialog();
            this.Hide();
        }
    }
}
