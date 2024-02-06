namespace Hastane_Otomasyon.Doktor
{
    partial class Doktor_SifreUnuttum
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
            label1 = new Label();
            label2 = new Label();
            textTc = new TextBox();
            textYeniSifre = new TextBox();
            btn_guncelle = new Button();
            btn_vazgec = new Button();
            SuspendLayout();
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.DodgerBlue;
            btn_giris.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giris.Location = new Point(33, 17);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(47, 38);
            btn_giris.TabIndex = 0;
            btn_giris.Text = "<";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 58);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(196, 135);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // textTc
            // 
            textTc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTc.Location = new Point(203, 85);
            textTc.Name = "textTc";
            textTc.Size = new Size(377, 32);
            textTc.TabIndex = 3;
            // 
            // textYeniSifre
            // 
            textYeniSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textYeniSifre.Location = new Point(203, 162);
            textYeniSifre.Name = "textYeniSifre";
            textYeniSifre.Size = new Size(377, 32);
            textYeniSifre.TabIndex = 4;
            // 
            // btn_guncelle
            // 
            btn_guncelle.BackColor = Color.DodgerBlue;
            btn_guncelle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guncelle.Location = new Point(203, 222);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(377, 40);
            btn_guncelle.TabIndex = 5;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = false;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_vazgec
            // 
            btn_vazgec.BackColor = Color.DodgerBlue;
            btn_vazgec.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_vazgec.Location = new Point(297, 276);
            btn_vazgec.Name = "btn_vazgec";
            btn_vazgec.Size = new Size(181, 40);
            btn_vazgec.TabIndex = 6;
            btn_vazgec.Text = "Vazgeç";
            btn_vazgec.UseVisualStyleBackColor = false;
            btn_vazgec.Click += btn_vazgec_Click;
            // 
            // Doktor_SifreUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_vazgec);
            Controls.Add(btn_guncelle);
            Controls.Add(textYeniSifre);
            Controls.Add(textTc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_giris);
            Name = "Doktor_SifreUnuttum";
            Text = "Doktor Sifre Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_giris;
        private Label label1;
        private Label label2;
        private TextBox textTc;
        private TextBox textYeniSifre;
        private Button btn_guncelle;
        private Button btn_vazgec;
    }
}