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
    public partial class Doktor_Kayit : Form
    {
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        SqlCommand komut;
        public Doktor_Kayit()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DoktorGirisiSayfasi hts = new DoktorGirisiSayfasi();
            hts.Show();
            this.Hide();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textAd.Text) ||
                   string.IsNullOrEmpty(textSoyad.Text) ||
                   string.IsNullOrEmpty(textTC.Text) ||
                   string.IsNullOrEmpty(textYas.Text) ||
                   string.IsNullOrEmpty(cmbCinsiyet.Text) ||
                   string.IsNullOrEmpty(msktTelefon.Text) ||
                   string.IsNullOrEmpty(cmbBrans.Text) ||
                   string.IsNullOrEmpty(textEposta.Text) ||
                   string.IsNullOrEmpty(textSifre.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                String sorgu = "INSERT INTO TDoktorlar(DoktorAd,DoktorSoyad,DoktorTcKimlikNo,DoktorYas,DoktorCinsiyet,DoktorTelefonNo,DoktorUzmanlıkAlan,DoktorEposta,DoktorSifre) VALUES (@DoktorAd,@DoktorSoyad,@DoktorTcKimlikNo,@DoktorYas,@DoktorCinsiyet,@DoktorTelefonNo,@DoktorUzmanlıkAlan,@DoktorEposta,@DoktorSifre)";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@DoktorAd", textAd.Text);
                komut.Parameters.AddWithValue("@DoktorSoyad", textSoyad.Text);
                komut.Parameters.AddWithValue("@DoktorTcKimlikNo", textTC.Text);
                komut.Parameters.AddWithValue("@DoktorYas", textYas.Text);
                komut.Parameters.AddWithValue("@DoktorCinsiyet", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@DoktorTelefonNo", msktTelefon.Text);
                komut.Parameters.AddWithValue("@DoktorUzmanlıkAlan", cmbBrans.Text);
                komut.Parameters.AddWithValue("@DoktorEposta", textEposta.Text);
                komut.Parameters.AddWithValue("@DoktorSifre", textSifre.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + textSifre.Text);

                DoktorGirisiSayfasi gs = new DoktorGirisiSayfasi();
                gs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
