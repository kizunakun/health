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
    public partial class Mulaites1 : Form
    {
        public Mulaites1()
        {
            InitializeComponent();
        }

        private void Tombolmulai1_Click(object sender, EventArgs e)
        {
            Quest1 formQuest1 = new Quest1();

            // Show the quest2 form
            formQuest1.Show();

            // Hide the current form (quest1)
            this.Hide();
        }

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform frm1 = new Loginform();
            frm1.ShowDialog();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda frm1 = new Beranda();
            frm1.ShowDialog();
        }
    }
}
