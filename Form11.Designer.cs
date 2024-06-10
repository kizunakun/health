namespace health
{
    partial class Form11
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
            btnBackhome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 56);
            label1.Name = "label1";
            label1.Size = new Size(240, 15);
            label1.TabIndex = 0;
            label1.Text = "Mengapa kesehatan mental sangat penting?";
            // 
            // btnBackhome
            // 
            btnBackhome.Location = new Point(12, 12);
            btnBackhome.Name = "btnBackhome";
            btnBackhome.Size = new Size(75, 23);
            btnBackhome.TabIndex = 1;
            btnBackhome.Text = "Kembali";
            btnBackhome.UseVisualStyleBackColor = true;
            btnBackhome.Click += btnBackhome_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackhome);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBackhome;
    }
}