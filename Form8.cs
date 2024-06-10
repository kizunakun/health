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
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform frm1 = new Loginform();
            frm1.ShowDialog();
        }

        private void btnGabung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform frm1 = new Loginform();
            frm1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tentangkami frm1 = new Tentangkami();
            frm1.ShowDialog();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {

        }
    }
}
