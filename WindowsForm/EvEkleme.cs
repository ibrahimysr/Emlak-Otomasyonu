using EmlakOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class EvEkleme : Form
    {
        public EvEkleme()
        {
            InitializeComponent();
        }
        private Ev[] kayitlar = new Ev[1000];




        private void KiralikTemizle()
        {
            txtOdaSayisi.Clear();
            txtKatNumarasi.Clear();
            cmbSemt.SelectedIndex = -1;
            txtAlani.Clear();
            dtpYapimTarihi.Value = DateTime.Now;
            cmEvTuru.SelectedIndex = -1;
            txtDepozito.Clear();
            txtKira.Clear();
        }
        private void SatilikTemizle()
        {
            txtOdaSayisi1.Clear();
            txtKatNumarasi1.Clear();
            cmSemt1.SelectedIndex = -1;
            txtAlan1.Clear();
            dtTarih1.Value = DateTime.Now;
            cmTur1.SelectedIndex = -1;
            txtFiyat1.Clear();
        }

        private void btnKiralikEkle_Click(object sender, EventArgs e)
        {
            int odaSayisi = Convert.ToInt32(txtOdaSayisi.Text);
            int katNumarasi = Convert.ToInt32(txtKatNumarasi.Text);
            string semt = cmbSemt.SelectedItem.ToString();
            double alani = Convert.ToDouble(txtAlani.Text);
            DateTime yapimTarihi = dtpYapimTarihi.Value;
            int turu = cmEvTuru.SelectedIndex;
            int alinan_depozito = Convert.ToInt32(txtDepozito.Text);
            int alinan_kira = Convert.ToInt32(txtKira.Text);


            KiralikEv kiralikev = new KiralikEv(odaSayisi, katNumarasi, semt, alani, yapimTarihi, (EvTur)turu, alinan_depozito, alinan_kira);

            KayitlariEkle(kiralikev);

            GörüntüleriKaydet(kiralikev.EmlakNumarasi, true);

            MessageBox.Show("Ev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            KiralikTemizle();
        }
        private void KayitlariEkle(Ev ev)
        {

            for (int i = 0; i < kayitlar.Length; i++)
            {
                if (kayitlar[i] == null)
                {
                    kayitlar[i] = ev;
                    break;
                }
            }


            string dosyaAdi = (ev is KiralikEv) ? "C:\\Users\\ibrah\\Desktop\\C#proje\\kiralik.txt" : "C:\\Users\\ibrah\\Desktop\\C#proje\\satilik.txt";
            using (StreamWriter sw = new StreamWriter(dosyaAdi, true))
            {
                sw.WriteLine(ev.EvBilgileri());
            }
        }


        private void btnSatılıkEvEkle_Click(object sender, EventArgs e)
        {
            var odaSayisi = Convert.ToInt32(txtOdaSayisi1.Text);
            int katNumarasi = Convert.ToInt32(txtKatNumarasi1.Text);
            string semt = cmSemt1.SelectedItem.ToString();
            double alani = Convert.ToDouble(txtAlan1.Text);
            DateTime yapimTarihi = dtTarih1.Value;
            int turu = cmTur1.SelectedIndex;
            double fiyat = Convert.ToDouble(txtFiyat1.Text);


            SatilikEv satilikev = new SatilikEv(odaSayisi, katNumarasi, semt, alani, yapimTarihi, (EvTur)turu, fiyat);

            KayitlariEkle(satilikev);

            GörüntüleriKaydet(satilikev.EmlakNumarasi, false);


            MessageBox.Show("Ev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            SatilikTemizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KiralikTemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatilikTemizle();

        }
        private void GörüntüleriKaydet(int emlakNumarasi, bool isKiralikEv)
        {
            string klasorAdi = (isKiralikEv) ? "kiralik" : "satilik";

            string klasorYolu = $"C:\\Users\\ibrah\\Desktop\\C#proje\\Goruntuler\\{klasorAdi}\\Emlak_{emlakNumarasi}";


            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
        }

        private void EvEkleme_Load(object sender, EventArgs e)
        {

        }
    }

}
