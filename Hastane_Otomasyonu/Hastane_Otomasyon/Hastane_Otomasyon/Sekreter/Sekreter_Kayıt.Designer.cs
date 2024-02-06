namespace Hastane_Otomasyon.Sekreter
{
    partial class Sekreter_Kayıt
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
            btn_geri = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textAd = new TextBox();
            textSoyad = new TextBox();
            textTc = new TextBox();
            textYas = new TextBox();
            textEposta = new TextBox();
            textSifre = new TextBox();
            mskTelefon = new MaskedTextBox();
            cmbCinsiyet = new ComboBox();
            BtnKaydiTamamla = new Button();
            btn_SekreterGiris = new Button();
            SuspendLayout();
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.DodgerBlue;
            btn_geri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_geri.Location = new Point(29, 19);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(56, 45);
            btn_geri.TabIndex = 0;
            btn_geri.Text = "<";
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 106);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 2;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(439, 106);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 3;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 173);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 4;
            label3.Text = "T.C. Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(439, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 24);
            label4.TabIndex = 5;
            label4.Text = "Yaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 249);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 6;
            label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(439, 249);
            label6.Name = "label6";
            label6.Size = new Size(77, 24);
            label6.TabIndex = 7;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 329);
            label7.Name = "label7";
            label7.Size = new Size(77, 24);
            label7.TabIndex = 8;
            label7.Text = "E-posta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(439, 329);
            label8.Name = "label8";
            label8.Size = new Size(50, 24);
            label8.TabIndex = 9;
            label8.Text = "Şifre";
            // 
            // textAd
            // 
            textAd.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAd.Location = new Point(152, 133);
            textAd.Name = "textAd";
            textAd.Size = new Size(220, 32);
            textAd.TabIndex = 10;
            // 
            // textSoyad
            // 
            textSoyad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSoyad.Location = new Point(429, 133);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(220, 32);
            textSoyad.TabIndex = 11;
            // 
            // textTc
            // 
            textTc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTc.Location = new Point(153, 200);
            textTc.Name = "textTc";
            textTc.Size = new Size(220, 32);
            textTc.TabIndex = 12;
            // 
            // textYas
            // 
            textYas.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textYas.Location = new Point(429, 200);
            textYas.Name = "textYas";
            textYas.Size = new Size(220, 32);
            textYas.TabIndex = 13;
            // 
            // textEposta
            // 
            textEposta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textEposta.Location = new Point(153, 361);
            textEposta.Name = "textEposta";
            textEposta.Size = new Size(220, 32);
            textEposta.TabIndex = 14;
            // 
            // textSifre
            // 
            textSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSifre.Location = new Point(429, 356);
            textSifre.Name = "textSifre";
            textSifre.Size = new Size(220, 32);
            textSifre.TabIndex = 15;
            // 
            // mskTelefon
            // 
            mskTelefon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefon.Location = new Point(429, 276);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(220, 32);
            mskTelefon.TabIndex = 16;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(153, 276);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(220, 32);
            cmbCinsiyet.TabIndex = 17;
            // 
            // BtnKaydiTamamla
            // 
            BtnKaydiTamamla.BackColor = Color.DodgerBlue;
            BtnKaydiTamamla.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydiTamamla.Location = new Point(323, 424);
            BtnKaydiTamamla.Name = "BtnKaydiTamamla";
            BtnKaydiTamamla.Size = new Size(158, 52);
            BtnKaydiTamamla.TabIndex = 18;
            BtnKaydiTamamla.Text = "Kaydı Tamamla";
            BtnKaydiTamamla.UseVisualStyleBackColor = false;
            BtnKaydiTamamla.Click += BtnKaydiTamamla_Click;
            // 
            // btn_SekreterGiris
            // 
            btn_SekreterGiris.BackColor = Color.DodgerBlue;
            btn_SekreterGiris.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SekreterGiris.Location = new Point(105, 19);
            btn_SekreterGiris.Name = "btn_SekreterGiris";
            btn_SekreterGiris.Size = new Size(147, 45);
            btn_SekreterGiris.TabIndex = 1;
            btn_SekreterGiris.Text = "Sekreter Giriş";
            btn_SekreterGiris.UseVisualStyleBackColor = false;
            btn_SekreterGiris.Click += btn_SekreterGiris_Click;
            // 
            // Sekreter_Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 595);
            Controls.Add(BtnKaydiTamamla);
            Controls.Add(cmbCinsiyet);
            Controls.Add(mskTelefon);
            Controls.Add(textSifre);
            Controls.Add(textEposta);
            Controls.Add(textYas);
            Controls.Add(textTc);
            Controls.Add(textSoyad);
            Controls.Add(textAd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_SekreterGiris);
            Controls.Add(btn_geri);
            Name = "Sekreter_Kayıt";
            Text = "Sekreter Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_geri;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textAd;
        private TextBox textSoyad;
        private TextBox textTc;
        private TextBox textYas;
        private TextBox textEposta;
        private TextBox textSifre;
        private MaskedTextBox mskTelefon;
        private ComboBox cmbCinsiyet;
        private Button BtnKaydiTamamla;
        private Button btn_SekreterGiris;
    }
}