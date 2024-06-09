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
    public partial class Quest4 : Form
    {
        private int previousScore;
        private int selectedValue10, selectedValue11, selectedValue12;
        public Quest4(int score)
        {
            InitializeComponent();
            InitializeRadioButtons();
            previousScore = score;
        }

        private void InitializeRadioButtons()
        {
            // Initialize radio buttons for Question 1
            Tidakpernah10.Tag = 1;
            Kadang10.Tag = 2;
            Sering10.Tag = 3;
            Hampirselalu10.Tag = 4;
            Tidakpernah10.CheckedChanged += new EventHandler(RadioButton10_CheckedChanged);
            Kadang10.CheckedChanged += new EventHandler(RadioButton10_CheckedChanged);
            Sering10.CheckedChanged += new EventHandler(RadioButton10_CheckedChanged);
            Hampirselalu10.CheckedChanged += new EventHandler(RadioButton10_CheckedChanged);

            // Initialize radio buttons for Question 2
            Tidakpernah11.Tag = 1;
            Sering11.Tag = 2;
            Sering11.Tag = 3;
            Hampirselalu11.Tag = 4;
            Tidakpernah11.CheckedChanged += new EventHandler(RadioButton11_CheckedChanged);
            Sering11.CheckedChanged += new EventHandler(RadioButton11_CheckedChanged);
            Sering11.CheckedChanged += new EventHandler(RadioButton11_CheckedChanged);
            Hampirselalu11.CheckedChanged += new EventHandler(RadioButton11_CheckedChanged);

            // Initialize radio buttons for Question 3
            Tidakpernah12.Tag = 1;
            Kadang12.Tag = 2;
            Sering12.Tag = 3;
            Hampirselalu12.Tag = 4;
            Tidakpernah12.CheckedChanged += new EventHandler(RadioButton12_CheckedChanged);
            Kadang12.CheckedChanged += new EventHandler(RadioButton12_CheckedChanged);
            Sering12.CheckedChanged += new EventHandler(RadioButton12_CheckedChanged);
            Hampirselalu12.CheckedChanged += new EventHandler(RadioButton12_CheckedChanged);
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue10 = (int)radioButton.Tag;
            }
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue11 = (int)radioButton.Tag;
            }
        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue12 = (int)radioButton.Tag;
            }
        }
        private void Quest4_Load(object sender, EventArgs e)
        {
            //P10.Text = previousScore.ToString();
        }

        private void Swap4_Click(object sender, EventArgs e)
        {
            int totalScore = previousScore + selectedValue10 + selectedValue11 + selectedValue12;
            Quest5 formQuest5 = new Quest5(totalScore);

            // Show the quest2 form
            formQuest5.Show();

            // Hide the current form (quest1)
            this.Hide();
        }
    }
}
