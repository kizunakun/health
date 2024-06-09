namespace health
{
    partial class Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda));
            label1 = new Label();
            btnFact = new Button();
            btnAbout = new Button();
            btnGabung = new Button();
            btnStart = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 25);
            label1.TabIndex = 1;
            label1.Text = "Temukan Pentingnya Kesehatan Mental dengan Tes Kami";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnFact
            // 
            btnFact.BackColor = SystemColors.HighlightText;
            btnFact.ForeColor = SystemColors.Highlight;
            btnFact.Location = new Point(155, 45);
            btnFact.Name = "btnFact";
            btnFact.Size = new Size(209, 23);
            btnFact.TabIndex = 2;
            btnFact.Text = "Pelajari Tentang Kesehatan Mental";
            btnFact.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = SystemColors.HighlightText;
            btnAbout.ForeColor = SystemColors.MenuHighlight;
            btnAbout.Location = new Point(393, 45);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(113, 23);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "Tentang kami";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnGabung
            // 
            btnGabung.BackColor = SystemColors.Highlight;
            btnGabung.ForeColor = SystemColors.HighlightText;
            btnGabung.Location = new Point(550, 45);
            btnGabung.Name = "btnGabung";
            btnGabung.Size = new Size(75, 23);
            btnGabung.TabIndex = 4;
            btnGabung.Text = "Gabung";
            btnGabung.UseVisualStyleBackColor = false;
            btnGabung.Click += btnGabung_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.HighlightText;
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Turquoise;
            btnStart.Location = new Point(610, 11);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(90, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start Now";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnStart);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Mental_Health_Background;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.Highlight;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 376);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(77, 254);
            label5.Name = "label5";
            label5.Size = new Size(688, 45);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 309);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(223, 204);
            label2.Name = "label2";
            label2.Size = new Size(402, 34);
            label2.TabIndex = 1;
            label2.Text = "Mulai Tes Kesehatan Mental Anda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.abstrak;
            pictureBox2.Location = new Point(295, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.S__1_;
            pictureBox1.Location = new Point(25, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Beranda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGabung);
            Controls.Add(btnAbout);
            Controls.Add(btnFact);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Beranda";
            Text = "Beranda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnFact;
        private Button btnAbout;
        private Button btnGabung;
        private Button btnStart;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
    }
}