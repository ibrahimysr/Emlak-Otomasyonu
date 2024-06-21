using EmlakOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class DetayForm : Form
    {

        String gelenEvDurumu;
        public DetayForm(string seciliDeger, String evDurumu)
        {
            InitializeComponent();
            string[] splitValues = seciliDeger.Split(',');
            gelenEvDurumu = evDurumu;
            txtEmlakNumarasi.Text = splitValues[0].Split(':')[1].Trim();
            txtOdaSayisi.Text = splitValues[1].Split(':')[1].Trim();
            txtKatNumarasi.Text = splitValues[2].Split(':')[1].Trim();
            cmbSemt.SelectedItem = splitValues[3].Split(':')[1].Trim();
            txtAlani.Text = splitValues[4].Split(':')[1].Trim();

            string tarihString = splitValues[5].Split(':')[1].Trim();
            dtpYapimTarihi.Value = DateTime.ParseExact(tarihString, "d.MM.yyyy", CultureInfo.InvariantCulture);

            cmEvTuru.SelectedItem = splitValues[6].Split(':')[1].Trim();
            txtAktiflik.Text = splitValues[7].Split(':')[1].Trim();
            if (evDurumu == "kiralik")
            {
                txtDepozito.Text = splitValues[8].Split(':')[1].Trim();
                txtKira.Text = splitValues[9].Split(':')[1].Trim();
            }
            else if (evDurumu == "satilik")
            {
                txtFiyat.Text = splitValues[8].Split(':')[1].Trim();
            }
        }

        private void DetayForm_Load(object sender, EventArgs e)
        {
            if (gelenEvDurumu == "kiralik")
            {
                txtFiyat.Enabled = false;
            }
            else if (gelenEvDurumu == "satilik")
            {
                txtKira.Enabled = false;
                txtDepozito.Enabled = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yeniOdaSayisi = Convert.ToInt32(txtOdaSayisi.Text);
            int yeniKatNumarasi = Convert.ToInt32(txtKatNumarasi.Text);
            string yeniSemt = cmbSemt.SelectedItem.ToString();
            double yeniAlani = Convert.ToDouble(txtAlani.Text);
            DateTime yeniYapimTarihi = dtpYapimTarihi.Value;
            EvTur yeniTuru = (EvTur)Enum.Parse(typeof(EvTur), cmEvTuru.SelectedItem.ToString());
            string aktiflik = txtAktiflik.Text;
            int yeniFiyat = string.IsNullOrEmpty(txtFiyat.Text) ? 0 : Convert.ToInt32(txtFiyat.Text);
            int yenidepozito = string.IsNullOrEmpty(txtDepozito.Text) ? 0 : Convert.ToInt32(txtDepozito.Text);
            int yenikira = string.IsNullOrEmpty(txtKira.Text) ? 0 : Convert.ToInt32(txtKira.Text);


            int seciliEmlakNumarasi = Convert.ToInt32(txtEmlakNumarasi.Text);

            String belgeAdi = gelenEvDurumu;
            string dosyaAdi = $"C:\\Users\\ibrah\\Desktop\\C#proje\\{belgeAdi}.txt";

            string[] satirlar = File.ReadAllLines(dosyaAdi);

            string yeniSatir = "";
            if (gelenEvDurumu == "satilik")
            {
                yeniSatir = $"Emlak Numarası: {seciliEmlakNumarasi}, Oda Sayısı: {yeniOdaSayisi}, Kat Numarası: {yeniKatNumarasi}, Semt: {yeniSemt}, Alanı: {yeniAlani}, Yapım Tarihi: {yeniYapimTarihi.ToString("dd.MM.yyyy")}, Türü: {yeniTuru},Aktif: {aktiflik} ,Fiyat: {yeniFiyat}";
            }
            else if (gelenEvDurumu == "kiralik")
            {
                yeniSatir = $"Emlak Numarası: {seciliEmlakNumarasi}, Oda Sayısı: {yeniOdaSayisi}, Kat Numarası: {yeniKatNumarasi}, Semt: {yeniSemt}, Alanı: {yeniAlani}, Yapım Tarihi: {yeniYapimTarihi.ToString("dd.MM.yyyy")}, Türü: {yeniTuru}, Aktif: {aktiflik},Depozito: {yenidepozito} , Kira: {yenikira}";
            }

            for (int i = 0; i < satirlar.Length; i++)
            {
                if (satirlar[i].Contains($"Emlak Numarası: {seciliEmlakNumarasi}"))
                {
                    satirlar[i] = yeniSatir;

                    File.WriteAllLines(dosyaAdi, satirlar);

                    MessageBox.Show("Seçili öğe başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }
            }



        }
    }
}
