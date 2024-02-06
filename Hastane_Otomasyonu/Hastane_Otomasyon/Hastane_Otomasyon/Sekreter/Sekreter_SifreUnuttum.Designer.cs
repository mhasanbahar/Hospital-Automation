namespace Hastane_Otomasyon.Sekreter
{
    partial class Sekreter_SifreUnuttum
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
            textTC = new TextBox();
            textYenisifre = new TextBox();
            btn_güncelle = new Button();
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
            label2.Size = new Size(95, 24);
            label2.TabIndex = 2;
            label2.Text = "Yeni Şifre";
            // 
            // textTC
            // 
            textTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTC.Location = new Point(203, 85);
            textTC.Name = "textTC";
            textTC.Size = new Size(377, 32);
            textTC.TabIndex = 3;
            // 
            // textYenisifre
            // 
            textYenisifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textYenisifre.Location = new Point(203, 162);
            textYenisifre.Name = "textYenisifre";
            textYenisifre.Size = new Size(377, 32);
            textYenisifre.TabIndex = 4;
            // 
            // btn_güncelle
            // 
            btn_güncelle.BackColor = Color.DodgerBlue;
            btn_güncelle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_güncelle.Location = new Point(203, 222);
            btn_güncelle.Name = "btn_güncelle";
            btn_güncelle.Size = new Size(377, 40);
            btn_güncelle.TabIndex = 5;
            btn_güncelle.Text = "Güncelle";
            btn_güncelle.UseVisualStyleBackColor = false;
            btn_güncelle.Click += btn_güncelle_Click;
            // 
            // BtnVazgec
            // 
            BtnVazgec.BackColor = Color.DodgerBlue;
            BtnVazgec.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVazgec.Location = new Point(297, 276);
            BtnVazgec.Name = "BtnVazgec";
            BtnVazgec.Size = new Size(181, 40);
            BtnVazgec.TabIndex = 6;
            BtnVazgec.Text = "Vazgeç";
            BtnVazgec.UseVisualStyleBackColor = false;
            BtnVazgec.Click += BtnVazgec_Click;
            // 
            // Sekreter_SifreUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(739, 421);
            Controls.Add(BtnVazgec);
            Controls.Add(btn_güncelle);
            Controls.Add(textYenisifre);
            Controls.Add(textTC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_geri);
            Name = "Sekreter_SifreUnuttum";
            Text = "Sekreter Şifre Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_geri;
        private Label label1;
        private Label label2;
        private TextBox textTC;
        private TextBox textYenisifre;
        private Button btn_güncelle;
        private Button BtnVazgec;
    }
}