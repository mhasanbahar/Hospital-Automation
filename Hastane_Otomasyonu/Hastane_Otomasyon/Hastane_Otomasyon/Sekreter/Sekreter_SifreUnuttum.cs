using Hastane_Otomasyon.Hasta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon.Sekreter
{
    public partial class Sekreter_SifreUnuttum : Form
    {
        public Sekreter_SifreUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (textTC.Text == "" || textYenisifre.Text == "")
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Update TSekreterler set SekreterTcKimlikNo='" + textTC.Text + "', SekreterSifre='" + textYenisifre.Text + "' where SekreterTcKimlikNo='" + textTC.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Güncellendi...");
                SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
                hst.Show();
                this.Hide();
                baglanti.Close();
            }
        }
    }
}
