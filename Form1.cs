namespace health
{
    public partial class Quest1 : Form
    {
        private int selectedValue1, selectedValue2, selectedValue3;
        public Quest1()
        {
            InitializeComponent();
            InitializeRadioButtons();

        }

        private void InitializeRadioButtons()
        {
            // Initialize radio buttons for Question 1
            Tidakpernah1.Tag = 1;
            Kadang1.Tag = 2;
            Sering1.Tag = 3;
            Hampirselalu1.Tag = 4;
            Tidakpernah1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            Kadang1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            Sering1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            Hampirselalu1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);

            // Initialize radio buttons for Question 2
            Tidakpernah2.Tag = 1;
            Sering2.Tag = 2;
            Sering2.Tag = 3;
            Hampirselalu2.Tag = 4;
            Tidakpernah2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            Sering2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            Sering2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            Hampirselalu2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);

            // Initialize radio buttons for Question 3
            Tidakpernah3.Tag = 1;
            Kadang3.Tag = 2;
            Sering3.Tag = 3;
            Hampirselalu3.Tag = 4;
            Tidakpernah3.CheckedChanged += new EventHandler(RadioButton3_CheckedChanged);
            Kadang3.CheckedChanged += new EventHandler(RadioButton3_CheckedChanged);
            Sering3.CheckedChanged += new EventHandler(RadioButton3_CheckedChanged);
            Hampirselalu3.CheckedChanged += new EventHandler(RadioButton3_CheckedChanged);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue1 = (int)radioButton.Tag;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue2 = (int)radioButton.Tag;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                selectedValue3 = (int)radioButton.Tag;
            }
        }

        // Continue similarly for other questions up to 15

        private void Swap1_Click(object sender, EventArgs e)
        {
            int totalScore = selectedValue1 + selectedValue2 + selectedValue3;

            Quest2 formQuest2 = new Quest2(totalScore);

            // Show the quest2 form
            formQuest2.Show();

            // Hide the current form (quest1)
            this.Hide();
        }

        private void P1_Click(object sender, EventArgs e)
        {

        }

        private void Quest1_Load(object sender, EventArgs e)
        {

        }
    }
}
