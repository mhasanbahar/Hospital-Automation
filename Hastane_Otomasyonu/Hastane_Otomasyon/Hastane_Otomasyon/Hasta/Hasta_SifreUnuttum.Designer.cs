namespace Hastane_Otomasyon.Hasta
{
    partial class Hasta_SifreUnuttum
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
            TxtTC = new TextBox();
            textSifreyeni = new TextBox();
            BtnGuncelle = new Button();
            BtnVazgec = new Button();
            SuspendLayout();
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.DodgerBlue;
            btn_geri.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_geri.Location = new Point(12, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(47, 38);
            btn_geri.TabIndex = 0;
            btn_geri.Text = "<";
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 93);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(196, 170);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 2;
            label2.Text = "Yeni Şifre";
            // 
            // TxtTC
            // 
            TxtTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTC.Location = new Point(203, 120);
            TxtTC.Margin = new Padding(3, 2, 3, 2);
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(377, 32);
            TxtTC.TabIndex = 3;
            // 
            // textSifreyeni
            // 
            textSifreyeni.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSifreyeni.Location = new Point(203, 197);
            textSifreyeni.Margin = new Padding(3, 2, 3, 2);
            textSifreyeni.Name = "textSifreyeni";
            textSifreyeni.Size = new Size(377, 32);
            textSifreyeni.TabIndex = 4;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.DodgerBlue;
            BtnGuncelle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(203, 257);
            BtnGuncelle.Margin = new Padding(3, 2, 3, 2);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(377, 40);
            BtnGuncelle.TabIndex = 5;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnVazgec
            // 
            BtnVazgec.BackColor = Color.DodgerBlue;
            BtnVazgec.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVazgec.Location = new Point(297, 311);
            BtnVazgec.Margin = new Padding(3, 2, 3, 2);
            BtnVazgec.Name = "BtnVazgec";
            BtnVazgec.Size = new Size(181, 40);
            BtnVazgec.TabIndex = 6;
            BtnVazgec.Text = "Vazgeç";
            BtnVazgec.UseVisualStyleBackColor = false;
            BtnVazgec.Click += BtnVazgec_Click;
            // 
            // Hasta_SifreUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVazgec);
            Controls.Add(BtnGuncelle);
            Controls.Add(textSifreyeni);
            Controls.Add(TxtTC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_geri);
            Name = "Hasta_SifreUnuttum";
            Text = "Hasta Şifre Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_geri;
        private Label label1;
        private Label label2;
        private TextBox TxtTC;
        private TextBox textSifreyeni;
        private Button BtnGuncelle;
        private Button BtnVazgec;
    }
}