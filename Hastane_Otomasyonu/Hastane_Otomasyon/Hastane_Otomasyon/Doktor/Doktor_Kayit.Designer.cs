namespace Hastane_Otomasyon.Doktor
{
    partial class Doktor_Kayit
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
            btn_giris = new Button();
            btn_kayit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textAd = new TextBox();
            textSoyad = new TextBox();
            textTC = new TextBox();
            textYas = new TextBox();
            cmbCinsiyet = new ComboBox();
            msktTelefon = new MaskedTextBox();
            textEposta = new TextBox();
            textSifre = new TextBox();
            cmbBrans = new ComboBox();
            SuspendLayout();
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.DodgerBlue;
            btn_giris.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giris.Location = new Point(25, 26);
            btn_giris.Margin = new Padding(4, 3, 4, 3);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(51, 41);
            btn_giris.TabIndex = 0;
            btn_giris.Text = "<";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = Color.DodgerBlue;
            btn_kayit.Location = new Point(323, 493);
            btn_kayit.Margin = new Padding(4, 3, 4, 3);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(158, 52);
            btn_kayit.TabIndex = 2;
            btn_kayit.Text = "Kayıt Tamamla";
            btn_kayit.UseVisualStyleBackColor = false;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 106);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 3;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(439, 106);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 4;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 173);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 5;
            label3.Text = "T.C. Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(439, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 24);
            label4.TabIndex = 6;
            label4.Text = "Yaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 249);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 7;
            label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(439, 249);
            label6.Name = "label6";
            label6.Size = new Size(77, 24);
            label6.TabIndex = 8;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 329);
            label7.Name = "label7";
            label7.Size = new Size(77, 24);
            label7.TabIndex = 9;
            label7.Text = "E-posta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(439, 329);
            label8.Name = "label8";
            label8.Size = new Size(60, 24);
            label8.TabIndex = 10;
            label8.Text = "Branş";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(371, 402);
            label9.Name = "label9";
            label9.Size = new Size(50, 24);
            label9.TabIndex = 11;
            label9.Text = "Şifre";
            // 
            // textAd
            // 
            textAd.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAd.Location = new Point(152, 133);
            textAd.Name = "textAd";
            textAd.Size = new Size(220, 32);
            textAd.TabIndex = 12;
            // 
            // textSoyad
            // 
            textSoyad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSoyad.Location = new Point(429, 133);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(220, 32);
            textSoyad.TabIndex = 13;
            // 
            // textTC
            // 
            textTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTC.Location = new Point(152, 200);
            textTC.Name = "textTC";
            textTC.Size = new Size(220, 32);
            textTC.TabIndex = 14;
            // 
            // textYas
            // 
            textYas.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textYas.Location = new Point(429, 200);
            textYas.Name = "textYas";
            textYas.Size = new Size(220, 32);
            textYas.TabIndex = 15;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbCinsiyet.Location = new Point(153, 276);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(219, 32);
            cmbCinsiyet.TabIndex = 16;
            // 
            // msktTelefon
            // 
            msktTelefon.Cursor = Cursors.IBeam;
            msktTelefon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            msktTelefon.Location = new Point(429, 276);
            msktTelefon.Mask = "(999) 000-0000";
            msktTelefon.Name = "msktTelefon";
            msktTelefon.Size = new Size(220, 32);
            msktTelefon.TabIndex = 17;
            // 
            // textEposta
            // 
            textEposta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textEposta.Location = new Point(152, 356);
            textEposta.Name = "textEposta";
            textEposta.Size = new Size(220, 32);
            textEposta.TabIndex = 18;
            // 
            // textSifre
            // 
            textSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSifre.Location = new Point(247, 429);
            textSifre.Name = "textSifre";
            textSifre.Size = new Size(331, 32);
            textSifre.TabIndex = 20;
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Items.AddRange(new object[] { "Adli Tıp", "Ağız Diş Ve Çene Cerrahisi", "Ağız Diş Ve Çene Radyolojisi", "Ağız Yüz Ve Çene Cerrahisi", "Aile Danışmanlığı", "Aile Hekimliği", "Algoloji", "Akupunktur", "Anatomi", "Androloji", "Alerji Hastalıkları", "Beslenme ve Diyet Uzmanı", "Beyin Ve Sinir Cerrahisi", "Cerrahi Onkoloji", "Çocuk Alerjisi", "Çocuk Cerrahisi", "Çocuk Diş Hekimliği (Pedodonti)", "Çocuk Endokrinolojisi", "Çocuk Enfeksiyon Hastalıkları", "Çocuk Genetik Hastalıkları", "Çocuk Göğüs Hastalıkları", "Çocuk Hematolojisi", "Çocuk Immünolojisi", "Çocuk Kardiyolojisi", "Çocuk Kalp Ve Damar Cerrahisi", "Çocuk Metabolizma Hastalıkları", "Çocuk Nefrolojisi", "Çocuk Onkolojisi", "Çocuk Sağlığı Ve Hastalıkları", "Çocuk Ürolojisi", "Dermatoloji", "Diş Hastalıkları Ve Tedavisi", "Diş Hekimi", "Embriyoloji Ve Histoloji", "Endodonti", "Endokrinoloji Ve Metabolizma Hastalıkları", "Ergoterapi", "Fiziksel Tıp Ve Rehabilitasyon", "Fizyoloji", "Fizyoterapi Ve Rehabilitasyon", "Fitoterapi", "Gastroenteroloji", "Gastroenteroloji Cerrahisi", "Genel Cerrahi", "Geriatri", "Girişimsel Radyoloji", "Göğüs Cerrahisi", "Göğüs Hastalıkları", "Göz Hastalıkları", "İç Hastalıkları (Dahiliye)", "İmmünoloji", "Jinekolojik Onkoloji Cerrahisi", "Kadın Hastalıkları ve Doğum", "Kardiyoloji", "Kalp Ve Damar Cerrahisi", "KBB (Kulak Burun Boğaz)", "Kupa Terapi (Hacamat)", "Mezoterapi", "Medikal Estetik", "Medikal Onkoloji", "Neonatoloji (Yenidoğan Yoğun Bakım)", "Nefroloji", "Nöroloji", "Nükleer Tıp", "Onkoloji", "Ortopedi Ve Travmatoloji", "Ortodonti", "Ozon Terapi", "Perinatoloji", "Periodontoloji", "Plastik Rekonstrüktif Ve Estetik Cerrahi", "Pratisyen", "Protetik Diş Tedavisi", "Psikiyatri", "Psikoloji", "Psikolojik Danışma ve Rehberlik", "Radyasyon Onkolojisi", "Radyoloji", "Romatoloji", "Spor Hekimliği", "Tıbbi Biyokimya", "Tıbbi Genetik", "Tıbbi Mikrobiyoloji", "Tıbbi Onkoloji", "Tıbbi Patoloji", "Üreme Endokrinolojisi Ve İnfertilite", "Üroloji", "Yoğun Bakım", "Yenidoğan Yoğun Bakım" });
            cmbBrans.Location = new Point(429, 356);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(219, 32);
            cmbBrans.TabIndex = 21;
            // 
            // Doktor_Kayit
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(776, 603);
            Controls.Add(cmbBrans);
            Controls.Add(textSifre);
            Controls.Add(textEposta);
            Controls.Add(msktTelefon);
            Controls.Add(cmbCinsiyet);
            Controls.Add(textYas);
            Controls.Add(textTC);
            Controls.Add(textSoyad);
            Controls.Add(textAd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_kayit);
            Controls.Add(btn_giris);
            Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Doktor_Kayit";
            Text = "Doktor Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_giris;
        private Button btn_kayit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textAd;
        private TextBox textSoyad;
        private TextBox textTC;
        private TextBox textYas;
        private ComboBox cmbCinsiyet;
        private MaskedTextBox msktTelefon;
        private TextBox textEposta;
        private TextBox textSifre;
        private ComboBox cmbBrans;
    }
}