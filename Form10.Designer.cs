namespace health
{
    partial class Pelajari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelajari));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 15);
            label1.Name = "label1";
            label1.Size = new Size(428, 25);
            label1.TabIndex = 0;
            label1.Text = "\"MEMAHAMI TENTANG KESEHATAN MENTAL\"";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 90);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Lavender;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(31, 55);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(709, 88);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Lavender;
            textBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(29, 155);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 312);
            textBox2.TabIndex = 4;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Lavender;
            textBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(393, 154);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 313);
            textBox3.TabIndex = 5;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Submit.ForeColor = SystemColors.ButtonHighlight;
            Submit.Location = new Point(31, 471);
            Submit.Name = "Submit";
            Submit.Size = new Size(79, 33);
            Submit.TabIndex = 22;
            Submit.Text = "Kembali";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Pelajari
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Mental_Health_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 516);
            Controls.Add(Submit);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Pelajari";
            Text = "Form10";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Submit;
    }
}