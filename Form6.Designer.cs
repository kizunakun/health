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
            SuspendLayout();
            // 
            // LabelSkor
            // 
            LabelSkor.AutoSize = true;
            LabelSkor.Location = new Point(90, 66);
            LabelSkor.Name = "LabelSkor";
            LabelSkor.Size = new Size(61, 15);
            LabelSkor.TabIndex = 0;
            LabelSkor.Text = "Skor Anda";
            LabelSkor.Click += label1_Click;
            // 
            // Skor
            // 
            Skor.AutoSize = true;
            Skor.Location = new Point(157, 66);
            Skor.Name = "Skor";
            Skor.Size = new Size(13, 15);
            Skor.TabIndex = 1;
            Skor.Text = "x";
            Skor.Click += Skor_Click;
            // 
            // Berandabutton1
            // 
            Berandabutton1.Location = new Point(90, 128);
            Berandabutton1.Name = "Berandabutton1";
            Berandabutton1.Size = new Size(75, 23);
            Berandabutton1.TabIndex = 2;
            Berandabutton1.Text = "Beranda";
            Berandabutton1.UseVisualStyleBackColor = true;
            Berandabutton1.Click += Berandabutton1_Click;
            // 
            // HasilSkor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Berandabutton1);
            Controls.Add(Skor);
            Controls.Add(LabelSkor);
            Name = "HasilSkor";
            Text = "Hasil Skor";
            Load += HasilSkor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSkor;
        private Label Skor;
        private Button Berandabutton1;
    }
}