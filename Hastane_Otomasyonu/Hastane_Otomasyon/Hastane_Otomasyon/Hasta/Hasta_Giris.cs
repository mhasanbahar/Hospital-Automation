using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hastane_Otomasyon.Hasta
{
    public partial class HastaGirisiSayfası : Form
    {
        public HastaGirisiSayfası()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String Sql = "SELECT * FROM THastalar WHERE HastaTCKimlikNo = @HastaTCKimlikNo AND HastaSifre = @HastaSifre";
            SqlCommand komut = new SqlCommand(Sql, baglanti);
            komut.Parameters.AddWithValue("HastaTCKimlikNo",TxtTC.Text.Trim());
            komut.Parameters.AddWithValue("HastaSifre", TxtSfre.Text.Trim());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Hasta_Profil frm = new Hasta_Profil();
                frm.tcno = TxtTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!!.");
            }
            baglanti.Close();
        }
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Hasta_Kayit hst = new Hasta_Kayit();
            hst.Show();
            this.Hide();
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            Hasta_SifreUnuttum hst = new Hasta_SifreUnuttum();
            hst.Show();
            this.Hide();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa hst = new Anasayfa();
            hst.Show();
            this.Hide();
        }
    }
}