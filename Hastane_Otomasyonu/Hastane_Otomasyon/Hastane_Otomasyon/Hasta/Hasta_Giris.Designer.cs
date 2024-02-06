namespace Hastane_Otomasyon.Hasta
{
    partial class HastaGirisiSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisiSayfası));
            pictureBox1 = new PictureBox();
            TcLabel = new Label();
            SifreLabel = new Label();
            TxtTC = new TextBox();
            TxtSfre = new TextBox();
            BtnGiris = new Button();
            BtnKayitOl = new Button();
            BtnSifremiUnuttum = new Button();
            BtnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 218);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TcLabel
            // 
            TcLabel.AutoSize = true;
            TcLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TcLabel.Location = new Point(191, 244);
            TcLabel.Name = "TcLabel";
            TcLabel.Size = new Size(136, 24);
            TcLabel.TabIndex = 1;
            TcLabel.Text = "T.C. Kimlik No";
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(191, 301);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(50, 24);
            SifreLabel.TabIndex = 2;
            SifreLabel.Text = "Şifre";
            // 
            // TxtTC
            // 
            TxtTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTC.Location = new Point(191, 267);
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(318, 32);
            TxtTC.TabIndex = 3;
            // 
            // TxtSfre
            // 
            TxtSfre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSfre.Location = new Point(191, 331);
            TxtSfre.Name = "TxtSfre";
            TxtSfre.Size = new Size(318, 32);
            TxtSfre.TabIndex = 4;
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = Color.DodgerBlue;
            BtnGiris.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGiris.Location = new Point(191, 386);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(318, 39);
            BtnGiris.TabIndex = 5;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = Color.DodgerBlue;
            BtnKayitOl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnKayitOl.Location = new Point(191, 431);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(154, 57);
            BtnKayitOl.TabIndex = 6;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = false;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // BtnSifremiUnuttum
            // 
            BtnSifremiUnuttum.BackColor = Color.DodgerBlue;
            BtnSifremiUnuttum.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSifremiUnuttum.Location = new Point(376, 431);
            BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            BtnSifremiUnuttum.Size = new Size(133, 57);
            BtnSifremiUnuttum.TabIndex = 7;
            BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            BtnSifremiUnuttum.Click += BtnSifremiUnuttum_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.BackColor = Color.DodgerBlue;
            BtnGeri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(49, 44);
            BtnGeri.TabIndex = 8;
            BtnGeri.Text = "<";
            BtnGeri.UseVisualStyleBackColor = false;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // HastaGirisiSayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(751, 547);
            Controls.Add(BtnGeri);
            Controls.Add(BtnSifremiUnuttum);
            Controls.Add(BtnKayitOl);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSfre);
            Controls.Add(TxtTC);
            Controls.Add(SifreLabel);
            Controls.Add(TcLabel);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "HastaGirisiSayfası";
            Text = "Hasta Girişi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label TcLabel;
        private Label SifreLabel;
        private TextBox TxtTC;
        private TextBox TxtSfre;
        private Button BtnGiris;
        private Button BtnKayitOl;
        private Button BtnSifremiUnuttum;
        private Button BtnGeri;
    }
}