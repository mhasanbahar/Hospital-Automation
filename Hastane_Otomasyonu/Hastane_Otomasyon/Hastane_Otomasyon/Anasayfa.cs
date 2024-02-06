using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane_Otomasyon.Doktor;
using Hastane_Otomasyon.Hasta;
using Hastane_Otomasyon.Sekreter;

namespace Hastane_Otomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        
        private void btn_Hasta_Girisi_Click(object sender, EventArgs e)
        {
            HastaGirisiSayfasý hst = new HastaGirisiSayfasý();
            hst.Show();
            this.Hide();
        }

        private void btn_Sekreter_grs_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi hst = new SekreterGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void btn_Doktor_grs_Click(object sender, EventArgs e)
        {
            DoktorGirisiSayfasi hst = new DoktorGirisiSayfasi();
            hst.Show();
            this.Hide();
        }

    }
}