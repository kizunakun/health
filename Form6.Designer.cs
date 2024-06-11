namespace health
{
    partial class HasilSkor
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
            LabelSkor = new Label();
            Skor = new Label();
            Berandabutton1 = new Button();
            pictureBox1 = new PictureBox();
            labelSaran = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelSkor
            // 
            LabelSkor.AutoSize = true;
            LabelSkor.BackColor = SystemColors.ButtonHighlight;
            LabelSkor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSkor.Location = new Point(282, 198);
            LabelSkor.Name = "LabelSkor";
            LabelSkor.Size = new Size(132, 32);
            LabelSkor.TabIndex = 0;
            LabelSkor.Text = "Skor Anda";
            LabelSkor.Click += label1_Click;
            // 
            // Skor
            // 
            Skor.AutoSize = true;
            Skor.BackColor = SystemColors.ButtonHighlight;
            Skor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Skor.Location = new Point(444, 198);
            Skor.Name = "Skor";
            Skor.Size = new Size(27, 32);
            Skor.TabIndex = 1;
            Skor.Text = "x";
            Skor.Click += Skor_Click;
            // 
            // Berandabutton1
            // 
            Berandabutton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Berandabutton1.Location = new Point(340, 384);
            Berandabutton1.Name = "Berandabutton1";
            Berandabutton1.Size = new Size(117, 41);
            Berandabutton1.TabIndex = 2;
            Berandabutton1.Text = "Beranda";
            Berandabutton1.UseVisualStyleBackColor = true;
            Berandabutton1.Click += Berandabutton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mntll;
            pictureBox1.Location = new Point(2, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 123);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelSaran
            // 
            labelSaran.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSaran.AutoSize = true;
            labelSaran.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelSaran.Location = new Point(257, 277);
            labelSaran.Name = "labelSaran";
            labelSaran.Size = new Size(63, 25);
            labelSaran.TabIndex = 5;
            labelSaran.Text = "Saran";
            labelSaran.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HasilSkor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Mental_Health_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSaran);
            Controls.Add(pictureBox1);
            Controls.Add(Berandabutton1);
            Controls.Add(Skor);
            Controls.Add(LabelSkor);
            Name = "HasilSkor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasil Skor";
            Load += HasilSkor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSkor;
        private Label Skor;
        private Button Berandabutton1;
        private PictureBox pictureBox1;
        private Label labelSaran;
    }
}