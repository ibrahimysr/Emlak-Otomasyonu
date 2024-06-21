using EmlakOtomasyonu;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (KullaniciDogrula(kullaniciAdi, sifre))
            {
                AnaForm mainForm = new AnaForm();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanýcý adý veya þifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            string dosyaAdi = "C:\\Users\\ibrah\\Desktop\\C#proje\\user.txt";
            if (File.Exists(dosyaAdi))
            {
                string[] satirlar = File.ReadAllLines(dosyaAdi);

                foreach (string satir in satirlar)
                {
                    string[] kullaniciBilgileri = satir.Split(',');

                    if (kullaniciBilgileri.Length == 2)
                    {
                        string dosyaKullaniciAdi = kullaniciBilgileri[0].Trim();
                        string dosyaSifre = kullaniciBilgileri[1].Trim();

                        if (dosyaKullaniciAdi == kullaniciAdi && dosyaSifre == sifre)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayÝtFormu kayit = new KayÝtFormu();
            kayit.Show();
            this.Hide();
        }
    }
}