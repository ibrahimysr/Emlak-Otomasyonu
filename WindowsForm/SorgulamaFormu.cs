using EmlakOtomasyonu;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class SorgulamaFormu : Form
    {

        public SorgulamaFormu()
        {
            InitializeComponent();
        }
        private List<Ev> aramaSonuclari = new List<Ev>();

        private void SorgulamaFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnKiralikEkle_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); 

            int arananOdaSayisi = (chkOdaSayisi.Checked) ? Convert.ToInt32(txtOdaSayisi.Text) : -1;
            int arananKatNumarasi = (chkKatNumarasi.Checked && int.TryParse(txtKatNumarasi.Text, out int katNumarasi)) ? katNumarasi : -1;

            double arananAlan = (chkAlan.Checked) ? Convert.ToDouble(txtAlani.Text) : -1;
            string arananSemt = (chkSemt.Checked) ? cmbSemt.SelectedItem.ToString() : "";
            DateTime arananYapimTarihi = (chkYapimTarihi.Checked) ? dtpYapimTarihi.Value : DateTime.MinValue;
            string arananTur = (chkTur.Checked) ? cmEvTuru.SelectedItem.ToString() : "";
            double arananFiyat = (chkFiyat.Checked && double.TryParse(txtFiyat.Text, out double fiyat)) ? fiyat : -1;
            int arananDepozito = (chkDepozito.Checked && int.TryParse(txtDepozito.Text, out int depozito)) ? depozito : -1;
            int arananKira = (chkKira.Checked && int.TryParse(txtKira.Text, out int kira)) ? kira : -1;





            string belgeAdi = cmbBelgeSecimi.SelectedItem.ToString();
            string dosyaAdi = $"C:\\Users\\ibrah\\Desktop\\C#proje\\{belgeAdi.ToLower()}.txt";

            string[] satirlar = File.ReadAllLines(dosyaAdi);

            listBox1.Items.Clear();

            foreach (string satir in satirlar)
            {

                if ((chkOdaSayisi.Checked && !satir.Contains($"Oda Sayısı: {arananOdaSayisi}")) ||
          (chkKatNumarasi.Checked && !satir.Contains($"Kat Numarası: {arananKatNumarasi}")) ||
          (chkAlan.Checked && !satir.Contains($"Alanı: {arananAlan}")) ||
          (chkSemt.Checked && !satir.Contains($"Semt: {arananSemt}")) ||
          (chkYapimTarihi.Checked && !satir.Contains($"Yapım Tarihi: {arananYapimTarihi}")) ||
          (chkTur.Checked && !satir.Contains($"Türü: {arananTur}")) ||
          (chkFiyat.Checked && !satir.Contains($"Fiyat: {arananFiyat}")) ||
          (chkDepozito.Checked && !satir.Contains($"Depozito: {arananDepozito}")) ||
          (chkKira.Checked && !satir.Contains($"Kira: {arananKira}")))
                {
                    continue;
                }
                if (cmbBelgeSecimi.SelectedItem.ToString() == "kiralik")
                {
                    KiralikEv ev = ParseKiralikEv(satir);
                    String deger = ev.EvBilgileri();
                    listBox1.Items.Add(deger);

                }
                else if (cmbBelgeSecimi.SelectedItem.ToString() == "satilik")
                {
                    SatilikEv ev = ParseSatilikEv(satir);
                    String deger = ev.EvBilgileri();
                    listBox1.Items.Add(deger);

                }

            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Aranan değer bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private SatilikEv ParseSatilikEv(string satir)
        {
            string[] splitValues = satir.Split(',');

            int emlakNumarasi = Convert.ToInt32(splitValues[0].Split(':')[1].Trim());
            int odaSayisi = Convert.ToInt32(splitValues[1].Split(':')[1].Trim());
            int katNumarasi = Convert.ToInt32(splitValues[2].Split(':')[1].Trim());
            string semt = splitValues[3].Split(':')[1].Trim();
            double alani = Convert.ToDouble(splitValues[4].Split(':')[1].Trim());
            string tarihString = splitValues[5].Split(':')[1].Trim();

            DateTime yapimTarihi = DateTime.ParseExact(tarihString, "d.MM.yyyy", CultureInfo.InvariantCulture);

            EvTur turu = (EvTur)Enum.Parse(typeof(EvTur), splitValues[6].Split(':')[1].Trim());
            int fiyat = Convert.ToInt32(splitValues[8].Split(':')[1].Trim());

            SatilikEv satilikEv = new SatilikEv( odaSayisi, katNumarasi, semt, alani, yapimTarihi, turu, fiyat);


            return satilikEv;
        }
        private KiralikEv ParseKiralikEv(string satir)
        {
            string[] splitValues = satir.Split(',');

            int emlakNumarasi = Convert.ToInt32(splitValues[0].Split(':')[1].Trim());
            int odaSayisi = Convert.ToInt32(splitValues[1].Split(':')[1].Trim());
            int katNumarasi = Convert.ToInt32(splitValues[2].Split(':')[1].Trim());
            string semt = splitValues[3].Split(':')[1].Trim();
            double alani = Convert.ToDouble(splitValues[4].Split(':')[1].Trim());
            string tarihString = splitValues[5].Split(':')[1].Trim();

            DateTime yapimTarihi = DateTime.ParseExact(tarihString, "d.MM.yyyy", CultureInfo.InvariantCulture);
            EvTur turu = (EvTur)Enum.Parse(typeof(EvTur), splitValues[6].Split(':')[1].Trim());
            int depozito = Convert.ToInt32(splitValues[8].Split(':')[1].Trim());
            int kira = Convert.ToInt32(splitValues[9].Split(':')[1].Trim());

            KiralikEv kiralikEv = new KiralikEv(odaSayisi, katNumarasi, semt, alani, yapimTarihi, turu, depozito, kira);



            return kiralikEv;
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string seciliDeger = listBox1.SelectedItem.ToString();

                DetayForm detayForm = new DetayForm(seciliDeger, cmbBelgeSecimi.Text);

                detayForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string seciliDeger = listBox1.SelectedItem.ToString();
                    string belgeAdi = cmbBelgeSecimi.SelectedItem.ToString().ToLower();
                    string dosyaAdi = $"C:\\Users\\ibrah\\Desktop\\C#proje\\{belgeAdi}.txt";

                    string[] satirlar = File.ReadAllLines(dosyaAdi);
                    List<string> guncelSatirlar = new List<string>();

                    foreach (string satir in satirlar)
                    {
                        if (!satir.Contains(seciliDeger))
                        {
                            guncelSatirlar.Add(satir);
                        }
                    }

                    File.WriteAllLines(dosyaAdi, guncelSatirlar.ToArray());

                    listBox1.Items.Remove(listBox1.SelectedItem);

                    MessageBox.Show("Seçili öğe başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnArşiv_Click(object sender, EventArgs e)
        {
            string seciliItem = listBox1.SelectedItem?.ToString();

            if (seciliItem != null)
            {
                if (cmbBelgeSecimi.SelectedItem.ToString() == "kiralik")
                {
                    KiralikEv seciliEv = ParseKiralikEv(seciliItem);
                    seciliEv.Aktif = !seciliEv.Aktif;

                    KayitlariGuncelle(seciliEv);
                    ArşivEkle(seciliEv, "C:\\Users\\ibrah\\Desktop\\C#proje\\arşiv_kiralik.txt");
                }
                else if (cmbBelgeSecimi.SelectedItem.ToString() == "satilik")
                {
                    SatilikEv seciliEv = ParseSatilikEv(seciliItem);
                    seciliEv.Aktif = !seciliEv.Aktif;

                    KayitlariGuncelle(seciliEv);
                    ArşivEkle(seciliEv, "C:\\Users\\ibrah\\Desktop\\C#proje\\arşiv_satilik.txt");
                }

                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen arşivlemek istediğiniz evi seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void KayitlariGuncelle(Ev ev)
        {
            string dosyaAdi = (ev is KiralikEv) ? "C:\\Users\\ibrah\\Desktop\\C#proje\\kiralik.txt" : "C:\\Users\\ibrah\\Desktop\\C#proje\\satilik.txt";
            string geciciDosyaAdi = Path.GetTempFileName(); // Geçici bir dosya oluştur

            using (StreamWriter sw = new StreamWriter(geciciDosyaAdi))
            {
                string[] satirlar = File.ReadAllLines(dosyaAdi);

                foreach (string satir in satirlar)
                {
                    if (satir.Contains($"Emlak Numarası: {ev.EmlakNumarasi}"))
                    {
                        // Aktif durumu tersine çevir
                        string guncellenmisSatir = satir.Replace($"Aktif: {ev.Aktif}", $"Aktif: {!ev.Aktif}");
                        sw.WriteLine(guncellenmisSatir);
                    }
                    else
                    {
                        sw.WriteLine(satir);
                    }
                }
            }

            // Geçici dosyayı orijinal dosya ile değiştir
            File.Copy(geciciDosyaAdi, dosyaAdi, true);
            File.Delete(geciciDosyaAdi);
        }

        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();


        }
        private void ArşivEkle(Ev ev, string arsivDosyaAdi)
        {
            using (StreamWriter sw = new StreamWriter(arsivDosyaAdi, true))
            {
                sw.WriteLine(ev.EvBilgileri());
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string seciliEvBilgisi = listBox1.SelectedItem.ToString();
                int seciliEmlakNumarasi = GetEmlakNumarasi(seciliEvBilgisi);

                GörüntüleriGoster(seciliEmlakNumarasi, cmbBelgeSecimi.Text.Trim());
            }
            else
            {
                MessageBox.Show("Lütfen bir ev seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int GetEmlakNumarasi(string evBilgisi)
        {
            int emlakNumarasi = -1;
            string[] splitValues = evBilgisi.Split(',');
            foreach (var value in splitValues)
            {
                if (value.Contains("Emlak Numarası"))
                {
                    emlakNumarasi = int.Parse(value.Split(':')[1].Trim());
                    break;
                }
            }
            return emlakNumarasi;
        }
        private void GörüntüleriGoster(int seciliEmlakNumarasi, string evTur)
        {
            string belgeTuru = (evTur == "satilik") ? "satilik" : "kiralik";
            string klasorYolu = $"C:\\Users\\ibrah\\Desktop\\C#proje\\Goruntuler\\{belgeTuru}\\Emlak_{seciliEmlakNumarasi}";

            Process.Start("explorer.exe", klasorYolu);
        }

    }
}
