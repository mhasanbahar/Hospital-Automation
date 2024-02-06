namespace Hastane_Otomasyon.Hasta
{
    partial class Hasta_Kayit
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
            txt_isim = new TextBox();
            txt_Soyisim = new TextBox();
            txt_TC = new TextBox();
            txt_yas = new TextBox();
            txt_eposta = new TextBox();
            txt_sifre = new TextBox();
            BtnKaydiTamamla = new Button();
            cmb_Cinsiyet = new ComboBox();
            masked_telefon = new MaskedTextBox();
            SuspendLayout();
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.DodgerBlue;
            btn_geri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_geri.Location = new Point(12, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(51, 41);
            btn_geri.TabIndex = 0;
            btn_geri.Text = "<";
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 101);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 2;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(390, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 3;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 168);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 4;
            label3.Text = "T.C. Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(390, 168);
            label4.Name = "label4";
            label4.Size = new Size(42, 24);
            label4.TabIndex = 5;
            label4.Text = "Yaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 244);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 6;
            label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(390, 244);
            label6.Name = "label6";
            label6.Size = new Size(77, 24);
            label6.TabIndex = 7;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(104, 324);
            label7.Name = "label7";
            label7.Size = new Size(77, 24);
            label7.TabIndex = 8;
            label7.Text = "E-posta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(390, 324);
            label8.Name = "label8";
            label8.Size = new Size(50, 24);
            label8.TabIndex = 9;
            label8.Text = "Şifre";
            // 
            // txt_isim
            // 
            txt_isim.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_isim.Location = new Point(103, 128);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(220, 32);
            txt_isim.TabIndex = 10;
            // 
            // txt_Soyisim
            // 
            txt_Soyisim.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Soyisim.Location = new Point(380, 128);
            txt_Soyisim.Name = "txt_Soyisim";
            txt_Soyisim.Size = new Size(220, 32);
            txt_Soyisim.TabIndex = 11;
            // 
            // txt_TC
            // 
            txt_TC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TC.Location = new Point(104, 195);
            txt_TC.Name = "txt_TC";
            txt_TC.Size = new Size(220, 32);
            txt_TC.TabIndex = 12;
            // 
            // txt_yas
            // 
            txt_yas.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_yas.Location = new Point(380, 195);
            txt_yas.Name = "txt_yas";
            txt_yas.Size = new Size(220, 32);
            txt_yas.TabIndex = 13;
            // 
            // txt_eposta
            // 
            txt_eposta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eposta.Location = new Point(103, 351);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(220, 32);
            txt_eposta.TabIndex = 16;
            // 
            // txt_sifre
            // 
            txt_sifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sifre.Location = new Point(380, 351);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(220, 32);
            txt_sifre.TabIndex = 17;
            // 
            // BtnKaydiTamamla
            // 
            BtnKaydiTamamla.BackColor = Color.DodgerBlue;
            BtnKaydiTamamla.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKaydiTamamla.Location = new Point(262, 419);
            BtnKaydiTamamla.Name = "BtnKaydiTamamla";
            BtnKaydiTamamla.Size = new Size(158, 52);
            BtnKaydiTamamla.TabIndex = 18;
            BtnKaydiTamamla.Text = "Kaydı Tamamla";
            BtnKaydiTamamla.UseVisualStyleBackColor = false;
            BtnKaydiTamamla.Click += BtnKaydiTamamla_Click;
            // 
            // cmb_Cinsiyet
            // 
            cmb_Cinsiyet.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Cinsiyet.FormattingEnabled = true;
            cmb_Cinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmb_Cinsiyet.Location = new Point(104, 271);
            cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            cmb_Cinsiyet.Size = new Size(220, 32);
            cmb_Cinsiyet.TabIndex = 19;
            // 
            // masked_telefon
            // 
            masked_telefon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            masked_telefon.Location = new Point(380, 271);
            masked_telefon.Mask = "(999) 000-0000";
            masked_telefon.Name = "masked_telefon";
            masked_telefon.Size = new Size(220, 32);
            masked_telefon.TabIndex = 20;
            // 
            // Hasta_Kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(736, 532);
            Controls.Add(masked_telefon);
            Controls.Add(cmb_Cinsiyet);
            Controls.Add(BtnKaydiTamamla);
            Controls.Add(txt_sifre);
            Controls.Add(txt_eposta);
            Controls.Add(txt_yas);
            Controls.Add(txt_TC);
            Controls.Add(txt_Soyisim);
            Controls.Add(txt_isim);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_geri);
            Name = "Hasta_Kayit";
            Text = "Hasta Kayıt Olma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_geri;
        private Button BtnHastaGirisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_isim;
        private TextBox txt_Soyisim;
        private TextBox txt_TC;
        private TextBox txt_yas;
        private TextBox txt_eposta;
        private TextBox txt_sifre;
        private Button BtnKaydiTamamla;
        private ComboBox cmb_Cinsiyet;
        private MaskedTextBox masked_telefon;
    }
}