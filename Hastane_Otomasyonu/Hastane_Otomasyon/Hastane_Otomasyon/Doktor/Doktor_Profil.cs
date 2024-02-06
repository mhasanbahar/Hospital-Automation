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

namespace Hastane_Otomasyon.Doktor
{
    public partial class Doktor_Profil : Form
    {
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        public string tcno;

        public Doktor_Profil()
        {
            InitializeComponent();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TDoktorlar set  DoktorEposta='" + txteposta.Text + "', DoktorYas='" + Int32.Parse(txtYas.Text) + "',DoktorTelefonNo='" + masked_telefon.Text + "',  DoktorCinsiyet='" + LblCinsiyet.Text + "', DoktorSifre='" + txtSifre.Text + "', DoktorUzmanlıkAlan='" + textUzmanlık.Text + "' where DoktorTcKimlikNo = @DoktorTcKimlikNo", baglanti);
            komut.Parameters.AddWithValue("DoktorTcKimlikNo", tcno.Trim());
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }

        private void Doktor_Profil_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TDoktorlar where DoktorTcKimlikNo = @DoktorTcKimlikNo", baglanti);
            cmd.Parameters.AddWithValue("DoktorTcKimlikNo", tcno.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblDoktorİsimSoyisim.Text = dr["DoktorAd"].ToString() + " " + dr["DoktorSoyad"].ToString();
                txteposta.Text = dr["DoktorEposta"].ToString();
                txtYas.Text = dr["DoktorYas"].ToString();
                masked_telefon.Text = dr["DoktorTelefonNo"].ToString();
                LblCinsiyet.Text = dr["DoktorCinsiyet"].ToString();
                txtSifre.Text = dr["DoktorSifre"].ToString();
                Doktoradi.Text = dr["DoktorAd"].ToString() + " " + dr["DoktorSoyad"].ToString();
                lblTc.Text = dr["DoktorTcKimlikNo"].ToString();
                textUzmanlık.Text = dr["DoktorUzmanlıkAlan"].ToString();
            }
            baglanti.Close();

            //Bu doktora ait randevu listesini getiren sorgu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TRandevular where RandevuDoktor = @RandevuDoktor", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@RandevuDoktor", Doktoradi.Text);
            da.Fill(dt);
            dtRandevuDetay.DataSource = dt;
            // Hasta şikayetlerini rtbRandevuDetay'e ekleyelim
            rtbRandevuDetay.Clear();
            foreach (DataRow row in dt.Rows)
            {
                rtbRandevuDetay.AppendText($"Hasta Şikayeti: {row["HastaSikayet"]}\n\n");
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TDuyurular", baglanti);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void dtRandevuDetay_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dtRandevuDetay.SelectedCells[0].RowIndex;
            rtbRandevuDetay.Text = dtRandevuDetay.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
