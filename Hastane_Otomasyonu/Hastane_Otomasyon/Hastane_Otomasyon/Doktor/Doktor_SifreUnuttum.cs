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

namespace Hastane_Otomasyon.Doktor
{
    public partial class Doktor_SifreUnuttum : Form
    {
        public Doktor_SifreUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DoktorGirisiSayfasi hts = new DoktorGirisiSayfasi();
            hts.Show();
            this.Hide();
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            DoktorGirisiSayfasi hts = new DoktorGirisiSayfasi();
            hts.Show();
            this.Hide();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(textTc.Text == ""|| textYeniSifre.Text == "")
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Update TDoktorlar set DoktorTcKimlikNo = '" + textTc.Text + "', DoktorSifre='" + textYeniSifre.Text + "' where DoktorTcKimlikNo='" + textTc.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Güncellendi...");
                DoktorGirisiSayfasi hst = new DoktorGirisiSayfasi();
                hst.Show();
                this.Hide();
                baglanti.Close();
            }
        }
    }
}
