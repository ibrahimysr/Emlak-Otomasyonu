
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace EmlakOtomasyonu
{
    public enum EvTur
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil
    }

    public class Ev
    {
        private static int emlakNumaraCounter = 1;

        private int odaSayisi;
        private int katNumarasi;
        private string semti;
        private double alani;
        private DateTime yapimTarihi;
        private EvTur turu;
        private bool aktif;
        public int emlakNumarasi;

        public int OdaSayisi
        {
            get { return odaSayisi; }
            set
            {
                if (value < 0)
                {
                    odaSayisi = 0;
                    LogKaydiOlustur("Oda sayısı negatif değer alamaz. Oda sayısı sıfır olarak atanmıştır.");
                }
                else
                {
                    odaSayisi = value;
                }
            }
        }
        
        public int KatNumarasi { get; set; }
        public string Semti { get; set; }
        public double Alani { get; set; }
        public DateTime YapimTarihi { get; set; }
        public EvTur Turu { get; set; }
        public bool Aktif { get; set; }
        public int EmlakNumarasi { get;private set; }

        public Ev(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTur turu)
        {
           
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semti = semti;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = true;
            EmlakNumarasi = emlakNumaraCounter++;
        }



        public virtual string EvBilgileri()
        {
            return string.Format("Emlak Numarası: {0}, Oda Sayısı: {1}, Kat Numarası: {2}, Semt: {3}, " +
                            "Alanı: {4}, Yapım Tarihi: {5}, Türü: {6}, Aktif: {7}",
                            EmlakNumarasi, OdaSayisi, KatNumarasi, Semti, Alani,
                            YapimTarihi.ToShortDateString(), Turu, Aktif);
        }

        public virtual double FiyatHesapla()
        {
            double katsayi = 200;

            try
            {
                string[] lines = File.ReadAllLines("room_cost.txt");
                if (lines.Length > 0)
                {
                    katsayi = double.Parse(lines[0]);
                }
            }
            catch (Exception ex)
            {
                LogKaydiOlustur($"Dosya okuma hatası: {ex.Message}");
            }

            return OdaSayisi * katsayi;
        }

        private void LogKaydiOlustur(string mesaj)
        {
            string logDosyaYolu = "error_log.txt";
            using (StreamWriter sw = File.AppendText(logDosyaYolu))
            {
                sw.WriteLine($"{DateTime.Now} - {mesaj}");
            }
        }
    }

    public class KiralikEv : Ev
    {
        private int alinan_depozito;
        private int alinan_kira;

        public double Depozito { get; set; }
        public double Kira { get; set; }

        public KiralikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTur turu,double depozito,double kira)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            this.Depozito = depozito;
            this.Kira = kira;
        }

        

        public override string EvBilgileri()
        {
            return string.Format("{0}, Depozito: {1}, Kira: {2}", base.EvBilgileri(), Depozito, Kira);
        }
    }

    public class SatilikEv : Ev
    {
        public double Fiyat { get; set; }

        public SatilikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTur turu,double fiyat)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            this.Fiyat = fiyat;
        }

     

        public override string EvBilgileri()
        {
            return string.Format("{0}, Fiyat: {1}", base.EvBilgileri(), Fiyat);
        }
    }
}
