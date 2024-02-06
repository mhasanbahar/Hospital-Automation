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
    public partial class DoktorGirisiSayfasi : Form
    {
        public DoktorGirisiSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Anasayfa hst = new Anasayfa();
            hst.Show();
            this.Hide();
        }

        private void btn_DoktorSifre_Click(object sender, EventArgs e)
        {
            Doktor_SifreUnuttum hts = new Doktor_SifreUnuttum();
            hts.Show();
            this.Hide();
        }

        private void btn_DoktorKayit_Click(object sender, EventArgs e)
        {
            Doktor_Kayit hts = new Doktor_Kayit();
            hts.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sql = "select * from TDoktorlar where DoktorTcKimlikNo= @DoktorTcKimlikNo and DoktorSifre = @DoktorSifre";
            SqlParameter prm = new SqlParameter("DoktorTcKimlikNo", textDoktorTc.Text.Trim());
            SqlParameter prm2 = new SqlParameter("DoktorSifre", textDoktorSifre.Text.Trim());
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.Add(prm);
            cmd.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Doktor_Profil df = new Doktor_Profil();
                df.tcno = textDoktorTc.Text;
                df.Show();
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
