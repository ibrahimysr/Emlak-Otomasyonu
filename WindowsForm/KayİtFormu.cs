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
    public partial class KayİtFormu : Form
    {
        public KayİtFormu()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                if (KayitOl(kullaniciAdi, sifre))
                {
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 form1 = new Form1();
                    form1.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KayitOl(string kullaniciAdi, string sifre)
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

                        if (dosyaKullaniciAdi == kullaniciAdi)
                        {
                            return false; 
                        }
                    }
                }
            }

            using (StreamWriter sw = File.AppendText(dosyaAdi))
            {
                sw.WriteLine($"{kullaniciAdi},{sifre}");
            }

            return true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
