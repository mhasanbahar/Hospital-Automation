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
using Hastane_Otomasyon.Hasta;

namespace Hastane_Otomasyon.Sekreter
{
    public partial class SekreterGirisSayfasi : Form
    {
        public SekreterGirisSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");

        private void bt_geri_Click(object sender, EventArgs e)
        {
            Anasayfa hst = new Anasayfa();
            hst.Show();
            this.Hide();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Sekreter_Kayıt hst = new Sekreter_Kayıt();
            hst.Show();
            this.Hide();
        }

        private void btn_Ssifre_Click(object sender, EventArgs e)
        {
            Sekreter_SifreUnuttum hst = new Sekreter_SifreUnuttum();
            hst.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String Sql = "SELECT * FROM TSekreterler WHERE SekreterTcKimlikNo = @SekreterTcKimlikNo AND SekreterSifre = @SekreterSifre";
            SqlCommand komut = new SqlCommand(Sql, baglanti);
            komut.Parameters.AddWithValue("SekreterTcKimlikNo", textTC.Text.Trim());
            komut.Parameters.AddWithValue("SekreterSifre", textSifre.Text.Trim());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Sekreter_Profil frm = new Sekreter_Profil();
                frm.tcno = textTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!!.");
            }
            baglanti.Close();
        }
    }
}
