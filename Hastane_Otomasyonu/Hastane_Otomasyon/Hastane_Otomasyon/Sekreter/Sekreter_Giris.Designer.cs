namespace Hastane_Otomasyon.Sekreter
{
    partial class SekreterGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterGirisSayfasi));
            bt_geri = new Button();
            pictureBox1 = new PictureBox();
            Tc_lable = new Label();
            Sifre_lable = new Label();
            textTC = new TextBox();
            textSifre = new TextBox();
            BtnGiris = new Button();
            BtnKayitOl = new Button();
            btn_Ssifre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_geri
            // 
            bt_geri.BackColor = Color.DodgerBlue;
            bt_geri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_geri.Location = new Point(12, 12);
            bt_geri.Name = "bt_geri";
            bt_geri.Size = new Size(56, 45);
            bt_geri.TabIndex = 0;
            bt_geri.Text = "<";
            bt_geri.UseVisualStyleBackColor = false;
            bt_geri.Click += bt_geri_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 218);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Tc_lable
            // 
            Tc_lable.AutoSize = true;
            Tc_lable.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Tc_lable.Location = new Point(194, 261);
            Tc_lable.Name = "Tc_lable";
            Tc_lable.Size = new Size(136, 24);
            Tc_lable.TabIndex = 2;
            Tc_lable.Text = "T.C. Kimlik No";
            // 
            // Sifre_lable
            // 
            Sifre_lable.AutoSize = true;
            Sifre_lable.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sifre_lable.Location = new Point(194, 326);
            Sifre_lable.Name = "Sifre_lable";
            Sifre_lable.Size = new Size(50, 24);
            Sifre_lable.TabIndex = 3;
            Sifre_lable.Text = "Şifre";
            // 
            // textTC
            // 
            textTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTC.Location = new Point(194, 291);
            textTC.Name = "textTC";
            textTC.Size = new Size(318, 32);
            textTC.TabIndex = 4;
            // 
            // textSifre
            // 
            textSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSifre.Location = new Point(194, 353);
            textSifre.Name = "textSifre";
            textSifre.Size = new Size(318, 32);
            textSifre.TabIndex = 5;
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = Color.DodgerBlue;
            BtnGiris.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGiris.Location = new Point(194, 402);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(318, 39);
            BtnGiris.TabIndex = 6;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = Color.DodgerBlue;
            BtnKayitOl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKayitOl.Location = new Point(194, 447);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(154, 57);
            BtnKayitOl.TabIndex = 7;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = false;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // btn_Ssifre
            // 
            btn_Ssifre.BackColor = Color.DodgerBlue;
            btn_Ssifre.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ssifre.Location = new Point(358, 447);
            btn_Ssifre.Name = "btn_Ssifre";
            btn_Ssifre.Size = new Size(154, 57);
            btn_Ssifre.TabIndex = 8;
            btn_Ssifre.Text = "Şifremi Unuttum";
            btn_Ssifre.UseVisualStyleBackColor = false;
            btn_Ssifre.Click += btn_Ssifre_Click;
            // 
            // SekreterGirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(655, 557);
            Controls.Add(btn_Ssifre);
            Controls.Add(BtnKayitOl);
            Controls.Add(BtnGiris);
            Controls.Add(textSifre);
            Controls.Add(textTC);
            Controls.Add(Sifre_lable);
            Controls.Add(Tc_lable);
            Controls.Add(pictureBox1);
            Controls.Add(bt_geri);
            Name = "SekreterGirisSayfasi";
            Text = "Sekreter_Giris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_geri;
        private PictureBox pictureBox1;
        private Label Tc_lable;
        private Label Sifre_lable;
        private TextBox textTC;
        private TextBox textSifre;
        private Button BtnGiris;
        private Button BtnKayitOl;
        private Button btn_Ssifre;
    }
}