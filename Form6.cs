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

            // Logika untuk menampilkan saran berdasarkan skor
            string saran;
            if (previousScore >= 46 && previousScore <= 60)
            {
                saran = "Oh no, anda mungkin mengalami stress atau kecemasan yang sangat tinggi";
            }
            else if (previousScore >= 36 && previousScore < 45)
            {
                saran = "Waduh, tingkat stress atau kecemasan anda cukup tinggi";
            }
            else if (previousScore >= 26 && previousScore < 35)
            {
                saran = "Hmm, sepertinya anda mengalami stress atau kecemasan yang moderat";
            }
            else if (previousScore >= 15 && previousScore < 25)
            {
                  saran = "Well, kesehatan mental anda cukup baik";
            }
            else
            {
                saran = "Invalid score! Jawaban harus terisi";
            }

            // Tampilkan saran di labelSaran
            labelSaran.Text = saran;
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
