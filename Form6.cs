using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace health
{
    public partial class HasilSkor : Form
    {
        private int previousScore;
        public HasilSkor(int score)
        {
            InitializeComponent();
            previousScore = score;
        }

        private void HasilSkor_Load(object sender, EventArgs e)
        {
            Skor.Text = previousScore.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Skor_Click(object sender, EventArgs e)
        {

        }

        private void Berandabutton1_Click(object sender, EventArgs e)
        {
            Mulaites1 formMulaites1 = new Mulaites1();

            // Show the quest2 form
            formMulaites1.Show();

            // Hide the current form (quest1)
            this.Hide();
        }
    }
}
