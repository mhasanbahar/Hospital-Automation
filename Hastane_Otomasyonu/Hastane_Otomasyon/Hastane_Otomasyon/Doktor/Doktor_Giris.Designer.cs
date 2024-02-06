namespace Hastane_Otomasyon.Doktor
{
    partial class DoktorGirisiSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGirisiSayfasi));
            btn_Geri = new Button();
            pictureBox1 = new PictureBox();
            Tc_lable = new Label();
            lable_sifre = new Label();
            textDoktorTc = new TextBox();
            textDoktorSifre = new TextBox();
            btn_giris = new Button();
            btn_DoktorKayit = new Button();
            btn_DoktorSifre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Geri
            // 
            btn_Geri.BackColor = Color.DodgerBlue;
            btn_Geri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Geri.Location = new Point(12, 24);
            btn_Geri.Name = "btn_Geri";
            btn_Geri.Size = new Size(54, 40);
            btn_Geri.TabIndex = 0;
            btn_Geri.Text = "<";
            btn_Geri.UseVisualStyleBackColor = false;
            btn_Geri.Click += btn_Geri_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 217);
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
            // lable_sifre
            // 
            lable_sifre.AutoSize = true;
            lable_sifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable_sifre.Location = new Point(194, 326);
            lable_sifre.Name = "lable_sifre";
            lable_sifre.Size = new Size(50, 24);
            lable_sifre.TabIndex = 3;
            lable_sifre.Text = "Sifre";
            // 
            // textDoktorTc
            // 
            textDoktorTc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDoktorTc.Location = new Point(194, 291);
            textDoktorTc.Name = "textDoktorTc";
            textDoktorTc.Size = new Size(318, 32);
            textDoktorTc.TabIndex = 4;
            // 
            // textDoktorSifre
            // 
            textDoktorSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDoktorSifre.Location = new Point(194, 353);
            textDoktorSifre.Name = "textDoktorSifre";
            textDoktorSifre.Size = new Size(318, 32);
            textDoktorSifre.TabIndex = 5;
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.DodgerBlue;
            btn_giris.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giris.Location = new Point(194, 402);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(318, 39);
            btn_giris.TabIndex = 6;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_DoktorKayit
            // 
            btn_DoktorKayit.BackColor = Color.DodgerBlue;
            btn_DoktorKayit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DoktorKayit.Location = new Point(194, 447);
            btn_DoktorKayit.Name = "btn_DoktorKayit";
            btn_DoktorKayit.Size = new Size(154, 57);
            btn_DoktorKayit.TabIndex = 7;
            btn_DoktorKayit.Text = "Kayıt Ol";
            btn_DoktorKayit.UseVisualStyleBackColor = false;
            btn_DoktorKayit.Click += btn_DoktorKayit_Click;
            // 
            // btn_DoktorSifre
            // 
            btn_DoktorSifre.BackColor = Color.DodgerBlue;
            btn_DoktorSifre.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DoktorSifre.Location = new Point(358, 447);
            btn_DoktorSifre.Name = "btn_DoktorSifre";
            btn_DoktorSifre.Size = new Size(154, 57);
            btn_DoktorSifre.TabIndex = 8;
            btn_DoktorSifre.Text = "Şifremi Unuttum";
            btn_DoktorSifre.UseVisualStyleBackColor = false;
            btn_DoktorSifre.Click += btn_DoktorSifre_Click;
            // 
            // DoktorGirisiSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(655, 557);
            Controls.Add(btn_DoktorSifre);
            Controls.Add(btn_DoktorKayit);
            Controls.Add(btn_giris);
            Controls.Add(textDoktorSifre);
            Controls.Add(textDoktorTc);
            Controls.Add(lable_sifre);
            Controls.Add(Tc_lable);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Geri);
            Name = "DoktorGirisiSayfasi";
            Text = "Doktor Girişi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Geri;
        private PictureBox pictureBox1;
        private Label Tc_lable;
        private Label lable_sifre;
        private TextBox textDoktorTc;
        private TextBox textDoktorSifre;
        private Button btn_giris;
        private Button btn_DoktorKayit;
        private Button btn_DoktorSifre;
    }
}