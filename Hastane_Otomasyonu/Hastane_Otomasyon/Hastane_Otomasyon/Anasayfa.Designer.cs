namespace Hastane_Otomasyon
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            pictureBox1 = new PictureBox();
            HastaneAdiLable = new Label();
            btn_Hasta_Girisi = new Button();
            btn_Sekreter_grs = new Button();
            btn_Doktor_grs = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 213);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // HastaneAdiLable
            // 
            HastaneAdiLable.AutoSize = true;
            HastaneAdiLable.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            HastaneAdiLable.Location = new Point(83, 251);
            HastaneAdiLable.Name = "HastaneAdiLable";
            HastaneAdiLable.Size = new Size(588, 48);
            HastaneAdiLable.TabIndex = 0;
            HastaneAdiLable.Text = "KAYSERİ ŞEHİR HASTANESİ";
            // 
            // btn_Hasta_Girisi
            // 
            btn_Hasta_Girisi.BackColor = Color.PaleTurquoise;
            btn_Hasta_Girisi.FlatStyle = FlatStyle.Popup;
            btn_Hasta_Girisi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Hasta_Girisi.ForeColor = Color.Black;
            btn_Hasta_Girisi.Location = new Point(83, 330);
            btn_Hasta_Girisi.Name = "btn_Hasta_Girisi";
            btn_Hasta_Girisi.Size = new Size(165, 68);
            btn_Hasta_Girisi.TabIndex = 1;
            btn_Hasta_Girisi.Text = "Hasta Girişi";
            btn_Hasta_Girisi.UseVisualStyleBackColor = false;
            btn_Hasta_Girisi.Click += btn_Hasta_Girisi_Click;
            // 
            // btn_Sekreter_grs
            // 
            btn_Sekreter_grs.BackColor = Color.PaleTurquoise;
            btn_Sekreter_grs.FlatStyle = FlatStyle.Popup;
            btn_Sekreter_grs.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sekreter_grs.ForeColor = Color.Black;
            btn_Sekreter_grs.Location = new Point(305, 330);
            btn_Sekreter_grs.Name = "btn_Sekreter_grs";
            btn_Sekreter_grs.Size = new Size(165, 68);
            btn_Sekreter_grs.TabIndex = 2;
            btn_Sekreter_grs.Text = "Sekreter Girişi";
            btn_Sekreter_grs.UseVisualStyleBackColor = false;
            btn_Sekreter_grs.Click += btn_Sekreter_grs_Click;
            // 
            // btn_Doktor_grs
            // 
            btn_Doktor_grs.BackColor = Color.PaleTurquoise;
            btn_Doktor_grs.FlatStyle = FlatStyle.Popup;
            btn_Doktor_grs.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Doktor_grs.ForeColor = Color.Black;
            btn_Doktor_grs.Location = new Point(518, 330);
            btn_Doktor_grs.Name = "btn_Doktor_grs";
            btn_Doktor_grs.Size = new Size(165, 68);
            btn_Doktor_grs.TabIndex = 3;
            btn_Doktor_grs.Text = "Doktor Girişi";
            btn_Doktor_grs.UseVisualStyleBackColor = false;
            btn_Doktor_grs.Click += btn_Doktor_grs_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 489);
            Controls.Add(btn_Doktor_grs);
            Controls.Add(btn_Sekreter_grs);
            Controls.Add(btn_Hasta_Girisi);
            Controls.Add(HastaneAdiLable);
            Controls.Add(pictureBox1);
            Name = "Anasayfa";
            Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label HastaneAdiLable;
        private Button btn_Hasta_Girisi;
        private Button btn_Sekreter_grs;
        private Button btn_Doktor_grs;
    }
}