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
    public partial class Sekreter_Kayıt : Form
    {
        public Sekreter_Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        SqlCommand komut;

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void btn_SekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textAd.Text) ||
                    string.IsNullOrEmpty(textSoyad.Text) ||
                    string.IsNullOrEmpty(textTc.Text) ||
                    string.IsNullOrEmpty(textYas.Text) ||
                    string.IsNullOrEmpty(cmbCinsiyet.Text) ||
                    string.IsNullOrEmpty(mskTelefon.Text) ||
                    string.IsNullOrEmpty(textEposta.Text) ||
                    string.IsNullOrEmpty(textSifre.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                String sorgu = "INSERT INTO  TSekreterler(SekreterAd,SekreterSoyad,SekreterTcKimlikNo,SekreterYas,SekreterCinsiyet,SekreterTelefonNo,SekreterEposta,SekreterSifre) VALUES (@SekreterAd,@SekreterSoyad,@SekreterTcKimlikNo,@SekreterYas,@SekreterCinsiyet,@SekreterTelefonNo,@SekreterEposta,@SekreterSifre)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@SekreterAd", textAd.Text);
                komut.Parameters.AddWithValue("@SekreterSoyad", textSoyad.Text);
                komut.Parameters.AddWithValue("@SekreterTcKimlikNo", textTc.Text);
                komut.Parameters.AddWithValue("@SekreterYas", textYas.Text);
                komut.Parameters.AddWithValue("@SekreterCinsiyet", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@SekreterTelefonNo", mskTelefon.Text);
                komut.Parameters.AddWithValue("@SekreterEposta", textEposta.Text);
                komut.Parameters.AddWithValue("@SekreterSifre", textSifre.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + textSifre.Text);

                SekreterGirisSayfasi frm = new SekreterGirisSayfasi();
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
