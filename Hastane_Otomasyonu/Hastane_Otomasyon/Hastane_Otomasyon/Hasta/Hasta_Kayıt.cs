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

namespace Hastane_Otomasyon.Hasta
{
    public partial class Hasta_Kayit : Form
    {
        SqlCommand komut;
        public Hasta_Kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa hst = new Anasayfa();
            hst.Show();
            this.Hide();
        }

        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_isim.Text) ||
                    string.IsNullOrEmpty(txt_Soyisim.Text) ||
                    string.IsNullOrEmpty(txt_TC.Text) ||
                    string.IsNullOrEmpty(txt_yas.Text) ||
                    string.IsNullOrEmpty(cmb_Cinsiyet.Text) ||
                    string.IsNullOrEmpty(masked_telefon.Text) ||
                    string.IsNullOrEmpty(txt_eposta.Text) ||
                    string.IsNullOrEmpty(txt_sifre.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                String sorgu = "INSERT INTO  THastalar(HastaAd,HastaSoyad,HastaTCKimlikNo,HastaYas,HastaCinsiyet,HastaTelefonNo,HastaEposta,HastaSifre) VALUES (@HastaAd,@HastaSoyad,@HastaTCKimlikNo,@HastaYas,@HastaCinsiyet,@HastaTelefon,@HastaEposta,@HastaSifre)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@HastaAd", txt_isim.Text);
                komut.Parameters.AddWithValue("@HastaSoyad", txt_Soyisim.Text);
                komut.Parameters.AddWithValue("@HastaTCKimlikNo", txt_TC.Text);
                komut.Parameters.AddWithValue("@HastaYas", txt_yas.Text);
                komut.Parameters.AddWithValue("@HastaCinsiyet", cmb_Cinsiyet.Text);
                komut.Parameters.AddWithValue("@HastaTelefon", masked_telefon.Text);
                komut.Parameters.AddWithValue("@HastaEposta", txt_eposta.Text);
                komut.Parameters.AddWithValue("@HastaSifre", txt_sifre.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + txt_sifre.Text);

                HastaGirisiSayfası frm = new HastaGirisiSayfası();
                frm.Show();
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
