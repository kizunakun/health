namespace health
{
    partial class Form8
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
            label1 = new Label();
            btnFact = new Button();
            btnAbout = new Button();
            btnGabung = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 16);
            label1.Name = "label1";
            label1.Size = new Size(304, 15);
            label1.TabIndex = 1;
            label1.Text = "Temukan pentingnya kesehatan mental dengan tes kami";
            // 
            // btnFact
            // 
            btnFact.Location = new Point(35, 45);
            btnFact.Name = "btnFact";
            btnFact.Size = new Size(209, 23);
            btnFact.TabIndex = 2;
            btnFact.Text = "Pelajari tentang kesehatan mental";
            btnFact.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(250, 45);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(113, 23);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "Tentang kami";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnGabung
            // 
            btnGabung.Location = new Point(369, 45);
            btnGabung.Name = "btnGabung";
            btnGabung.Size = new Size(75, 23);
            btnGabung.TabIndex = 4;
            btnGabung.Text = "Gabung";
            btnGabung.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(436, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start Now";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(btnGabung);
            Controls.Add(btnAbout);
            Controls.Add(btnFact);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnFact;
        private Button btnAbout;
        private Button btnGabung;
        private Button btnStart;
    }
}