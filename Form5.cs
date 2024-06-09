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
    public partial class Quest5 : Form
    {
        private int previousScore;
        private int selectedValue13, selectedValue14, selectedValue15;
        public Quest5(int score)
        {

            InitializeComponent();
            InitializeRadioButtons();
            previousScore = score;
        }

        private void InitializeRadioButtons()
        {
            // Initialize radio buttons for Question 1
            Tidakpernah13.Tag = 1;
            Kadang13.Tag = 2;
            Sering13.Tag = 3;
            Hampirselalu13.Tag = 4;
            Tidakpernah13.CheckedChanged += new EventHandler(RadioButton13_CheckedChanged);
            Kadang13.CheckedChanged += new EventHandler(RadioButton13_CheckedChanged);
            Sering13.CheckedChanged += new EventHandler(RadioButton13_CheckedChanged);
            Hampirselalu13.CheckedChanged += new EventHandler(RadioButton13_CheckedChanged);

            // Initialize radio buttons for Question 2
            Tidakpernah14.Tag = 1;
            Sering14.Tag = 2;
            Sering14.Tag = 3;
            Hampirselalu14.Tag = 4;
            Tidakpernah14.CheckedChanged += new EventHandler(RadioButton14_CheckedChanged);
            Sering14.CheckedChanged += new EventHandler(RadioButton14_CheckedChanged);
            Sering14.CheckedChanged += new EventHandler(RadioButton14_CheckedChanged);
            Hampirselalu14.CheckedChanged += new EventHandler(RadioButton14_CheckedChanged);

            // Initialize radio buttons for Question 3
            Tidakpernah15.Tag = 1;
            Kadang15.Tag = 2;
            Sering15.Tag = 3;
            Hampirselalu15.Tag = 4;
            Tidakpernah15.CheckedChanged += new EventHandler(RadioButton15_CheckedChanged);
            Kadang15.CheckedChanged += new EventHandler(RadioButton15_CheckedChanged);
            Sering15.CheckedChanged += new EventHandler(RadioButton15_CheckedChanged);
            Hampirselalu15.CheckedChanged += new EventHandler(RadioButton15_CheckedChanged);
        }

        private void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue13 = (int)radioButton.Tag;
            }
        }

        private void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue14 = (int)radioButton.Tag;
            }
        }

        private void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue15 = (int)radioButton.Tag;
            }
        }
        private void Quest5_Load(object sender, EventArgs e)
        {
            //P13.Text = previousScore.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int totalScore = previousScore + selectedValue13 + selectedValue14 + selectedValue15;
            HasilSkor formQuest5 = new HasilSkor(totalScore);

            // Show the quest2 form
            formQuest5.Show();

            // Hide the current form (quest1)
            this.Hide();
        }
    }
}
