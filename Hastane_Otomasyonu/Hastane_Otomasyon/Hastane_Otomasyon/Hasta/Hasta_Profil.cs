using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyon.Hasta
{
    public partial class Hasta_Profil : Form
    {
        public Hasta_Profil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        public string tcno;

        private void Hasta_Profil_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Hasta bilgilerini çek
                SqlCommand komut = new SqlCommand("Select * From THastalar where HastaTCKimlikNo=@HastaTCNo", baglanti);
                komut.Parameters.AddWithValue("@HastaTCNo", tcno.Trim());
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    lblHastaİsimSoyisim.Text = dr["HastaAd"].ToString() + " " + dr["HastaSoyad"].ToString();
                    txteposta.Text = dr["HastaEposta"].ToString();
                    txtYas.Text = dr["HastaYas"].ToString();
                    masked_telefon.Text = dr["HastaTelefonNo"].ToString();
                    LblCinsiyet.Text = dr["HastaCinsiyet"].ToString();
                    txtSifre.Text = dr["HastaSifre"].ToString();
                    LblisimSoyisim.Text = dr["HastaAd"].ToString() + " " + dr["HastaSoyad"].ToString();
                    LblTC.Text = dr["HastaTCKimlikNo"].ToString();
                }
                dr.Close();

                // Geçmiş Randevu Çekme
                DataTable mb = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter("Select * from TRandevular where HastaID = (Select HastaID From THastalar where HastaTCKimlikNo = @HastaTCNo)", baglanti);
                data.SelectCommand.Parameters.AddWithValue("@HastaTCNo", tcno);
                data.Fill(mb);
                dataGridView1.DataSource = mb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta bilgileri veya geçmiş randevular çekilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }

            // Branş Çekme
            try
            {
                baglanti.Open();
                SqlCommand command2 = new SqlCommand("Select BransAd from TBranslar", baglanti);
                SqlDataReader dr2 = command2.ExecuteReader();
                while (dr2.Read()) // Veri okundukça combobox'a branşlar ekleniyor.
                {
                    CmbBrans.Items.Add(dr2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branşlar çekilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update THastalar set HastaYas = '" + Int32.Parse(txtYas.Text) + "', HastaEposta='" + txteposta.Text + "',HastaTelefonNo = '" + masked_telefon.Text + "',  HastaCinsiyet = '" + LblCinsiyet.Text + "', HastaSifre = '" + txtSifre.Text + "' where HastaTCKimlikNo = @HastaTCNo", baglanti);
            cmd.Parameters.AddWithValue("HastaTCNo", tcno.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            //Eklemeden önce geçmişte eklenmiş olan isimleri temizleme işlemi yapılıyor.
            CmbDoktor.Items.Clear();
            //Doktorlar tablosunda branşı Combobox'ta yer alan Doktor adları ve doktor soyadlarını gösterir.

            SqlCommand cmb = new SqlCommand("Select DoktorAd, DoktorSoyad from TDoktorlar where DoktorUzmanlıkAlan = @p1", baglanti);
            cmb.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = cmb.ExecuteReader();
            while (dr3.Read())//Veri okundukça Doktor ismini gösterecek combobox' a İsim boşluk soyisim şeklinde ekleniyor.
            {
                CmbDoktor.Items.Add(dr3["DoktorAd"].ToString() + " " + dr3["DoktorSoyad"].ToString());
            }
            baglanti.Close();
            // Burada, branş seçildiğinde CmbDoktor'u temizlenir.
            CmbDoktor.Text = "";
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TRandevular where RandevuBrans = '" + CmbBrans.Text + "'and RandevuDoktor = '" + CmbDoktor.Text + "' and RandevuDurum = 0 ", baglanti);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            // DataGridView'i güncelle
            dataGridView2.Refresh();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // HastaID'yi doğrudan veritabanından al
                SqlCommand getHastaIDCommand = new SqlCommand("SELECT HastaID FROM THastalar WHERE HastaTCKimlikNo = @p1", baglanti);
                getHastaIDCommand.Parameters.AddWithValue("@p1", tcno);
                int hastaID = Convert.ToInt32(getHastaIDCommand.ExecuteScalar());

                // Branş ve doktor bilgilerini ayır
                string[] doktorBilgisi = CmbDoktor.Text.Split(' ');
                string doktorAd = doktorBilgisi[0];
                string doktorSoyad = doktorBilgisi[1];

                // DoktorID'yi doğrudan veritabanından al
                SqlCommand getDoktorIDCommand = new SqlCommand("SELECT DoktorID FROM TDoktorlar WHERE DoktorAd = @p1 AND DoktorSoyad = @p2", baglanti);
                getDoktorIDCommand.Parameters.AddWithValue("@p1", doktorAd);
                getDoktorIDCommand.Parameters.AddWithValue("@p2", doktorSoyad);
                int doktorID = Convert.ToInt32(getDoktorIDCommand.ExecuteScalar());

                // Randevu eklemek için INSERT INTO kullan
                SqlCommand command = new SqlCommand("INSERT INTO TRandevular (HastaID, DoktorID, RandevuDurum, HastaTCKimlikNo, HastaSikayet, RandevuTarih, RandevuBrans, RandevuDoktor) VALUES (@p1, @p2, 1, @p3, @p4, @p5, @p6, @p7);", baglanti);
                command.Parameters.AddWithValue("@p1", hastaID);
                command.Parameters.AddWithValue("@p2", doktorID);
                command.Parameters.AddWithValue("@p3", LblTC.Text);
                command.Parameters.AddWithValue("@p4", RchSikayet.Text);
                command.Parameters.AddWithValue("@p5", DateTime.Now); // Şu anki tarih ve saat
                command.Parameters.AddWithValue("@p6", CmbBrans.Text);
                command.Parameters.AddWithValue("@p7", CmbDoktor.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Randevu alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Veriyi tekrar çek ve DataGridView'leri güncelle
                RefreshDataGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu alınırken bir hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }

        }
        private void RefreshDataGridViews()
        {
            // DataGridView1'i güncelle
            try
            {
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from TRandevular where HastaID = (Select HastaID From THastalar where HastaTCKimlikNo = @HastaTCNo)", baglanti);
                da1.SelectCommand.Parameters.AddWithValue("@HastaTCNo", tcno);
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridView1 güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // DataGridView2'yi güncelle
            try
            {
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("Select * from TRandevular where HastaID = (Select HastaID From THastalar where HastaTCKimlikNo = @HastaTCNo)", baglanti);
                da2.SelectCommand.Parameters.AddWithValue("@HastaTCNo", tcno);
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridView2 güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridviewde seçili olan randevunun id'sini getiriyor.

            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }
    }
}
