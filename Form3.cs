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
    public partial class Quest3 : Form
    {
        private int previousScore;
        private int selectedValue7, selectedValue8, selectedValue9;
        public Quest3(int score)
        {
            InitializeComponent();
            InitializeRadioButtons();
            previousScore = score;
        }

        private void InitializeRadioButtons()
        {
            // Initialize radio buttons for Question 1
            Tidakpernah7.Tag = 1;
            Kadang7.Tag = 2;
            Sering7.Tag = 3;
            Hampirselalu7.Tag = 4;
            Tidakpernah7.CheckedChanged += new EventHandler(RadioButton7_CheckedChanged);
            Kadang7.CheckedChanged += new EventHandler(RadioButton7_CheckedChanged);
            Sering7.CheckedChanged += new EventHandler(RadioButton7_CheckedChanged);
            Hampirselalu7.CheckedChanged += new EventHandler(RadioButton7_CheckedChanged);

            // Initialize radio buttons for Question 2
            Tidakpernah8.Tag = 1;
            Sering8.Tag = 2;
            Sering8.Tag = 3;
            Hampirselalu8.Tag = 4;
            Tidakpernah8.CheckedChanged += new EventHandler(RadioButton8_CheckedChanged);
            Sering8.CheckedChanged += new EventHandler(RadioButton8_CheckedChanged);
            Sering8.CheckedChanged += new EventHandler(RadioButton8_CheckedChanged);
            Hampirselalu8.CheckedChanged += new EventHandler(RadioButton8_CheckedChanged);

            // Initialize radio buttons for Question 3
            Tidakpernah9.Tag = 1;
            Kadang9.Tag = 2;
            Sering9.Tag = 3;
            Hampirselalu9.Tag = 4;
            Tidakpernah9.CheckedChanged += new EventHandler(RadioButton9_CheckedChanged);
            Kadang9.CheckedChanged += new EventHandler(RadioButton9_CheckedChanged);
            Sering9.CheckedChanged += new EventHandler(RadioButton9_CheckedChanged);
            Hampirselalu9.CheckedChanged += new EventHandler(RadioButton9_CheckedChanged);
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue7 = (int)radioButton.Tag;
            }
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue8 = (int)radioButton.Tag;
            }
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue9 = (int)radioButton.Tag;
            }
        }

        private void Quest3_Load(object sender, EventArgs e)
        {
            //P7.Text = previousScore.ToString();
        }

        private void Swap3_Click(object sender, EventArgs e)
        {
            int totalScore = previousScore + selectedValue7 + selectedValue8 + selectedValue9;
            Quest4 formQuest4 = new Quest4(totalScore);

            // Show the quest2 form
            formQuest4.Show();

            // Hide the current form (quest1)
            this.Hide();
        }
    }
}
