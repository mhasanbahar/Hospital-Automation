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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyon.Sekreter
{
    public partial class Sekreter_Profil : Form
    {
        public Sekreter_Profil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        public string tcno;
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }

        private void Sekreter_Profil_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TSekreterler where SekreterTcKimlikNo = @SekreterTcKimlikNo", baglanti);
            cmd.Parameters.AddWithValue("SekreterTcKimlikNo", tcno.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblSekleterİsimSoyisim.Text = dr["SekreterAd"].ToString() + " " + dr["SekreterSoyad"].ToString();
                txteposta.Text = dr["SekreterEposta"].ToString();
                txtYas.Text = dr["SekreterYas"].ToString();
                masked_telefon.Text = dr["SekreterTelefonNo"].ToString();
                LblCinsiyet.Text = dr["SekreterCinsiyet"].ToString();
                txtSifre.Text = dr["SekreterSifre"].ToString();
                SekleterAdi.Text = dr["SekreterAd"].ToString() + " " + dr["SekreterSoyad"].ToString();
                LblTC.Text = dr["SekreterTcKimlikNo"].ToString();
            }
            baglanti.Close();

            //Branşları Datagridview' e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBranslar", baglanti);
            da1.Fill(dt1);
            dtBrans.DataSource = dt1;

            //Doktorları Datagridview' e aktarma (Doktorların isimlerini ad boşluk soyad şeklinde Doktorlar sütunu içerisine yazar
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as Doktorlar, DoktorUzmanlıkAlan from TDoktorlar", baglanti);
            da2.Fill(dt2);
            dtDoktor.DataSource = dt2;


            //Comboboxa Branşları aktarma
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("Select BransAd from TBranslar", baglanti);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            baglanti.Close();

            //duyuruları çekme
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TDuyurular", baglanti);
            da3.Fill(dt3);
            dataGridViewBrans.DataSource = dt3;

            //Doktorları Datagridview' e aktarma
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from TDoktorlar", baglanti);
            da4.Fill(dt4);
            dataGridViewDoktor.DataSource = dt4;

            //Formun ilk açılışında comboboxlara branşları aktarma
            baglanti.Open();
            SqlCommand command3 = new SqlCommand("Select BransAd from TBranslar", baglanti);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0]);
            }
            baglanti.Close();

            //Barnşalrı Datagridview' e aktarma
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("Select * from TBranslar", baglanti);
            da5.Fill(dt5);
            dataGridViewBrans.DataSource = dt5;

            //Randevu lisetesi Datagridview' e aktarma
            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter("Select * from TBranslar", baglanti);
            da6.Fill(dt6);
            dataGridViewRandevuListele.DataSource = dt6;

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TSekreterler set SekreterEposta='" + txteposta.Text + "', SekreterYas='" + Int32.Parse(txtYas.Text) + "',SekreterTelefonNo='" + masked_telefon.Text + "',  SekreterCinsiyet='" + LblCinsiyet.Text + "', SekreterSifre='" + txtSifre.Text + "' where SekreterTcKimlikNo=@SekreterTcKimlikNo", baglanti);
            komut.Parameters.AddWithValue("SekreterTcKimlikNo", tcno.Trim());
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into TRandevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1, @p2, @p3, @p4)", baglanti);
            DateTime randevuTarih;
            if (DateTime.TryParse(maskDate.Text, out randevuTarih))
            {
                // Geçerli bir tarih değeri varsa işlemi devam ettir
                command.Parameters.AddWithValue("@p1", randevuTarih);
            }
            else
            {
                // Hata durumu varsa ele alabilirsiniz
                MessageBox.Show("Geçersiz tarih formatı!");
                return; 
            }

            TimeSpan randevuSaat;
            if (TimeSpan.TryParse(maskTime.Text, out randevuSaat))
            {
                // Geçerli bir saat değeri varsa işlemi devam ettir
                command.Parameters.AddWithValue("@p2", randevuSaat);
            }
            else
            {
                // Hata durumu varsa ele alabilirsiniz
                MessageBox.Show("Geçersiz saat formatı!");
                return; 
            }
            command.Parameters.AddWithValue("@p3", cmbBranch.Text);
            command.Parameters.AddWithValue("@p4", cmbDoctor.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayRandevular();
            MessageBox.Show("Randevu oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void DisplayRandevular()
        {
            // DataGridView'e randevuları yükleme
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TRandevular", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRandevuListele.DataSource = dt;
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Branş Comboboxına tıklanınca direkt ilgili branşa ait doktorlar listelensin
            baglanti.Open();
            cmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DoktorAd, DoktorSoyad from TDoktorlar where DoktorUzmanlıkAlan = @p1", baglanti);
            command3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            baglanti.Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Duyuru oluşturma
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into TDuyurular (Duyuru) values (@p1)", baglanti);
            command.Parameters.AddWithValue("@p1", rtbDuyuru.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // Oluşturulan duyuruları DataGridView'e yükleyin
            LoadDuyurular();
            MessageBox.Show("Duyuru oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            rtbDuyuru.Clear();
        }

        private void LoadDuyurular()
        {
            // TDuyurular tablosundan verileri çek
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TDuyurular", baglanti);
            da.Fill(dt);

            // DataGridView3'e verileri yükle
            dataGridView3.DataSource = dt;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            //Doktor ekleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into TDoktorlar (DoktorAd, DoktorSoyad, DoktorUzmanlıkAlan, DoktorTcKimlikNo, DoktorYas, DoktorCinsiyet, DoktorEposta, DoktorSifre, DoktorTelefonNo) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglanti);
            command.Parameters.AddWithValue("@p1", textAd.Text);
            command.Parameters.AddWithValue("@p2", textSoyad.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p5", textYas.Text);
            command.Parameters.AddWithValue("@p6", comboBox2.Text);
            command.Parameters.AddWithValue("@p7", textEposta.Text);
            command.Parameters.AddWithValue("@p8", textSifre.Text);
            command.Parameters.AddWithValue("@p9", MskTelefonNO.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'e eklenen doktoru göster
            DisplayDoktorlar();
            MessageBox.Show("Doktor eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textAd.Clear();
            textSoyad.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textEposta.Clear();
            textYas.Clear();
            MskTelefonNO.Clear();
            maskedTextBox1.Clear();
            textSifre.Clear();

        }
        private void DisplayDoktorlar()
        {
            // DataGridView'e doktorları yükleme
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TDoktorlar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewDoktor.DataSource = dt;
        }

        private void dataGridViewDoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridviewde bir alana tıklandığında içerisindeki bilgilerin textboxlara aktarılması
            int chosen = dataGridViewDoktor.SelectedCells[0].RowIndex;
            textAd.Text = dataGridViewDoktor.Rows[chosen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridViewDoktor.Rows[chosen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridViewDoktor.Rows[chosen].Cells[9].Value.ToString();
            maskedTextBox1.Text = dataGridViewDoktor.Rows[chosen].Cells[3].Value.ToString();
            textSifre.Text = dataGridViewDoktor.Rows[chosen].Cells[10].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //Doktor silme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Delete from TDoktorlar where DoktorTcKimlikNo = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayDoktorlar();
            MessageBox.Show("Seçilen doktor silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textAd.Clear();
            textSoyad.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textEposta.Clear();
            textYas.Clear();
            MskTelefonNO.Clear();
            maskedTextBox1.Clear();
            textSifre.Clear();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            //TC Kimlik Numarası maskedtextbox' ta bulunan doktoru güncelleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Update TDoktorlar set DoktorAd = @p1, DoktorSoyad = @p2, DoktorUzmanlıkAlan = @p3, DoktorSifre = @p5, DoktorYas = @p6, DoktorTelefonNo = @p7, DoktorEposta = @p8 where DoktorTcKimlikNo = @p4", baglanti);
            command.Parameters.AddWithValue("@p1", textAd.Text);
            command.Parameters.AddWithValue("@p2", textSoyad.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p5", textSifre.Text);
            command.Parameters.AddWithValue("@p6", textYas.Text);
            command.Parameters.AddWithValue("@p7", MskTelefonNO.Text);
            command.Parameters.AddWithValue("@p8", textEposta.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayDoktorlar();
            MessageBox.Show("Doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textAd.Clear();
            textSoyad.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textEposta.Clear();
            textYas.Clear();
            MskTelefonNO.Clear();
            maskedTextBox1.Clear();
            textSifre.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into TBranslar (BransAd) values (@p1)", baglanti);
            command.Parameters.AddWithValue("@p1", textBrans.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayBranslar();
            MessageBox.Show("Branş eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBrans.Clear();
        }

        private void DisplayBranslar()
        {
            // DataGridView'e branşları yükleme
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBranslar", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewBrans.DataSource = dt;
        }

        private void dataGridViewBrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridviewde bir alana tıklandığında içerisindeki bilgilerin textboxlara aktarılması
            int chosen = dataGridViewBrans.SelectedCells[0].RowIndex;
            textID.Text = dataGridViewBrans.Rows[chosen].Cells[0].Value.ToString();
            textBrans.Text = dataGridViewBrans.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Baranş silme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Delete from TBranslar where BransID = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", textID.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayBranslar();
            MessageBox.Show("Seçilen branş silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textID.Clear();
            textBrans.Clear();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //ID' si txtID' de bulunan branşı güncelleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Update TBranslar set BransAd = @p2 where BransID = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", textID.Text);
            command.Parameters.AddWithValue("@p2", textBrans.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i güncelleme
            DisplayBranslar();
            MessageBox.Show("Branş güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textID.Clear();
            textBrans.Clear();
        }
    }
}
