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
    public partial class Quest2 : Form
    {
        private int previousScore;
        private int selectedValue4, selectedValue5, selectedValue6;

        // Constructor with an integer parameter
        public Quest2(int score)
        {
            InitializeComponent();
            InitializeRadioButtons();
            previousScore = score;
        }

        private void InitializeRadioButtons()
        {
            // Initialize radio buttons for Question 1
            Tidakpernah4.Tag = 1;
            Kadang4.Tag = 2;
            Sering4.Tag = 3;
            Hampirselalu4.Tag = 4;
            Tidakpernah4.CheckedChanged += new EventHandler(RadioButton4_CheckedChanged);
            Kadang4.CheckedChanged += new EventHandler(RadioButton4_CheckedChanged);
            Sering4.CheckedChanged += new EventHandler(RadioButton4_CheckedChanged);
            Hampirselalu4.CheckedChanged += new EventHandler(RadioButton4_CheckedChanged);

            // Initialize radio buttons for Question 2
            Tidakpernah5.Tag = 1;
            Sering5.Tag = 2;
            Sering5.Tag = 3;
            Hampirselalu5.Tag = 4;
            Tidakpernah5.CheckedChanged += new EventHandler(RadioButton5_CheckedChanged);
            Sering5.CheckedChanged += new EventHandler(RadioButton5_CheckedChanged);
            Sering5.CheckedChanged += new EventHandler(RadioButton5_CheckedChanged);
            Hampirselalu5.CheckedChanged += new EventHandler(RadioButton5_CheckedChanged);

            // Initialize radio buttons for Question 3
            Tidakpernah6.Tag = 1;
            Kadang6.Tag = 2;
            Sering6.Tag = 3;
            Hampirselalu6.Tag = 4;
            Tidakpernah6.CheckedChanged += new EventHandler(RadioButton6_CheckedChanged);
            Kadang6.CheckedChanged += new EventHandler(RadioButton6_CheckedChanged);
            Sering6.CheckedChanged += new EventHandler(RadioButton6_CheckedChanged);
            Hampirselalu6.CheckedChanged += new EventHandler(RadioButton6_CheckedChanged);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue4 = (int)radioButton.Tag;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue5 = (int)radioButton.Tag;
            }
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue6 = (int)radioButton.Tag;
            }
        }

        private void Swap2_Click(object sender, EventArgs e)
        {
            int totalScore = previousScore + selectedValue4 + selectedValue5 + selectedValue6;

            Quest3 formQuest3 = new Quest3(totalScore);

            // Show the quest2 form
            formQuest3.Show();

            // Hide the current form (quest1)
            this.Hide();
        }

        private void Quest2_Load(object sender, EventArgs e)
        {
            //P4.Text = previousScore.ToString();
        }

        private void P6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
