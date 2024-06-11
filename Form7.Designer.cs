namespace health
{
    partial class Mulaites1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mulaites1));
            Tombolmulai1 = new Button();
            Logoutbutton1 = new Button();
            btnBeranda = new Button();
            SuspendLayout();
            // 
            // Tombolmulai1
            // 
            Tombolmulai1.BackColor = SystemColors.ActiveCaption;
            Tombolmulai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tombolmulai1.ForeColor = SystemColors.ControlLightLight;
            Tombolmulai1.Location = new Point(283, 107);
            Tombolmulai1.Name = "Tombolmulai1";
            Tombolmulai1.Size = new Size(98, 49);
            Tombolmulai1.TabIndex = 0;
            Tombolmulai1.Text = "Mulai Tes";
            Tombolmulai1.UseVisualStyleBackColor = false;
            Tombolmulai1.Click += Tombolmulai1_Click;
            // 
            // Logoutbutton1
            // 
            Logoutbutton1.BackColor = SystemColors.ControlLight;
            Logoutbutton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Logoutbutton1.ForeColor = SystemColors.ButtonHighlight;
            Logoutbutton1.Location = new Point(568, 12);
            Logoutbutton1.Name = "Logoutbutton1";
            Logoutbutton1.Size = new Size(84, 23);
            Logoutbutton1.TabIndex = 1;
            Logoutbutton1.Text = "Log Out";
            Logoutbutton1.UseVisualStyleBackColor = false;
            Logoutbutton1.Click += Logoutbutton1_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = SystemColors.ControlLight;
            btnBeranda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBeranda.ForeColor = SystemColors.ButtonHighlight;
            btnBeranda.Location = new Point(12, 12);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(75, 23);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // Mulaites1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(669, 369);
            Controls.Add(btnBeranda);
            Controls.Add(Logoutbutton1);
            Controls.Add(Tombolmulai1);
            Name = "Mulaites1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mulai Tes";
            ResumeLayout(false);
        }

        #endregion

        private Button Tombolmulai1;
        private Button Logoutbutton1;
        private Button btnBeranda;
    }
}