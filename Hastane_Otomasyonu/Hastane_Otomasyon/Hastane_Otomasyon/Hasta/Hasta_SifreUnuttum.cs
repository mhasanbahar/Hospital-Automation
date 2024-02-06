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
    public partial class Hasta_SifreUnuttum : Form
    {
        SqlConnection baglanti = new SqlConnection("server = .\\SQLEXPRESS; initial catalog = HastaneOtomasyon; Integrated Security = SSPI");
        public Hasta_SifreUnuttum()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            HastaGirisiSayfası hst = new HastaGirisiSayfası();
            hst.Show();
            this.Hide();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            HastaGirisiSayfası hst = new HastaGirisiSayfası();
            hst.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if(TxtTC.Text == "" || textSifreyeni.Text == "")
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Update THastalar set HastaTCKimlikNo='" + TxtTC.Text + "', HastaSifre='" + textSifreyeni.Text + "' where HastaTCKimlikNo='" + TxtTC.Text +"'",baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Güncellendi...");
                HastaGirisiSayfası hst = new HastaGirisiSayfası();
                hst.Show();
                this.Hide();
                baglanti.Close();
            }
        }
    }
}
