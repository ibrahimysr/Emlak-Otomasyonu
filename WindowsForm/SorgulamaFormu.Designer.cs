namespace WindowsForm
{
    partial class SorgulamaFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnGoruntule = new Button();
            btnArşiv = new Button();
            btnSil = new Button();
            btnDetayGoster = new Button();
            listBox1 = new ListBox();
            txtFiyat = new TextBox();
            label11 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            chkFiyat = new CheckBox();
            chkKira = new CheckBox();
            chkDepozito = new CheckBox();
            chkTur = new CheckBox();
            chkYapimTarihi = new CheckBox();
            chkSemt = new CheckBox();
            chkKatNumarasi = new CheckBox();
            label12 = new Label();
            cmbBelgeSecimi = new ComboBox();
            chkAlan = new CheckBox();
            chkOdaSayisi = new CheckBox();
            txtDepozito = new TextBox();
            txtKira = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnTemizle = new Button();
            label8 = new Label();
            cmEvTuru = new ComboBox();
            label7 = new Label();
            dtpYapimTarihi = new DateTimePicker();
            txtAlani = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbSemt = new ComboBox();
            txtOdaSayisi = new TextBox();
            btnKiralikEkle = new Button();
            txtKatNumarasi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(btnGoruntule);
            groupBox2.Controls.Add(btnArşiv);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnDetayGoster);
            groupBox2.Controls.Add(listBox1);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(557, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(830, 647);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = Color.SlateGray;
            btnGoruntule.Location = new Point(471, 582);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(309, 43);
            btnGoruntule.TabIndex = 20;
            btnGoruntule.Text = "Resimleri Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // btnArşiv
            // 
            btnArşiv.BackColor = Color.SlateGray;
            btnArşiv.Location = new Point(471, 533);
            btnArşiv.Name = "btnArşiv";
            btnArşiv.Size = new Size(309, 43);
            btnArşiv.TabIndex = 19;
            btnArşiv.Text = "Arşivle";
            btnArşiv.UseVisualStyleBackColor = false;
            btnArşiv.Click += btnArşiv_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.SlateGray;
            btnSil.Location = new Point(76, 582);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(343, 43);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDetayGoster
            // 
            btnDetayGoster.BackColor = Color.SlateGray;
            btnDetayGoster.Location = new Point(76, 533);
            btnDetayGoster.Name = "btnDetayGoster";
            btnDetayGoster.Size = new Size(343, 43);
            btnDetayGoster.TabIndex = 17;
            btnDetayGoster.Text = "Detayı Göster";
            btnDetayGoster.UseVisualStyleBackColor = false;
            btnDetayGoster.Click += btnDetayGoster_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(6, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(818, 480);
            listBox1.TabIndex = 16;
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = SystemColors.Control;
            txtFiyat.Location = new Point(137, 413);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(237, 27);
            txtFiyat.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(88, 420);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 17;
            label11.Text = "Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(1011, 33);
            label4.Name = "label4";
            label4.Size = new Size(123, 48);
            label4.TabIndex = 14;
            label4.Text = "EMLAK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(39, 33);
            label3.Name = "label3";
            label3.Size = new Size(120, 48);
            label3.TabIndex = 13;
            label3.Text = "YAŞAR";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(chkFiyat);
            groupBox1.Controls.Add(chkKira);
            groupBox1.Controls.Add(chkDepozito);
            groupBox1.Controls.Add(chkTur);
            groupBox1.Controls.Add(chkYapimTarihi);
            groupBox1.Controls.Add(chkSemt);
            groupBox1.Controls.Add(chkKatNumarasi);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cmbBelgeSecimi);
            groupBox1.Controls.Add(chkAlan);
            groupBox1.Controls.Add(chkOdaSayisi);
            groupBox1.Controls.Add(txtDepozito);
            groupBox1.Controls.Add(txtKira);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmEvTuru);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpYapimTarihi);
            groupBox1.Controls.Add(txtAlani);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbSemt);
            groupBox1.Controls.Add(txtOdaSayisi);
            groupBox1.Controls.Add(btnKiralikEkle);
            groupBox1.Controls.Add(txtKatNumarasi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(39, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 647);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // chkFiyat
            // 
            chkFiyat.AutoSize = true;
            chkFiyat.Location = new Point(381, 419);
            chkFiyat.Name = "chkFiyat";
            chkFiyat.Size = new Size(18, 17);
            chkFiyat.TabIndex = 28;
            chkFiyat.UseVisualStyleBackColor = true;
            // 
            // chkKira
            // 
            chkKira.AutoSize = true;
            chkKira.Location = new Point(381, 376);
            chkKira.Name = "chkKira";
            chkKira.Size = new Size(18, 17);
            chkKira.TabIndex = 27;
            chkKira.UseVisualStyleBackColor = true;
            // 
            // chkDepozito
            // 
            chkDepozito.AutoSize = true;
            chkDepozito.Location = new Point(380, 332);
            chkDepozito.Name = "chkDepozito";
            chkDepozito.Size = new Size(18, 17);
            chkDepozito.TabIndex = 26;
            chkDepozito.UseVisualStyleBackColor = true;
            // 
            // chkTur
            // 
            chkTur.AutoSize = true;
            chkTur.Location = new Point(380, 288);
            chkTur.Name = "chkTur";
            chkTur.Size = new Size(18, 17);
            chkTur.TabIndex = 25;
            chkTur.UseVisualStyleBackColor = true;
            // 
            // chkYapimTarihi
            // 
            chkYapimTarihi.AutoSize = true;
            chkYapimTarihi.Location = new Point(380, 246);
            chkYapimTarihi.Name = "chkYapimTarihi";
            chkYapimTarihi.Size = new Size(18, 17);
            chkYapimTarihi.TabIndex = 24;
            chkYapimTarihi.UseVisualStyleBackColor = true;
            // 
            // chkSemt
            // 
            chkSemt.AutoSize = true;
            chkSemt.Location = new Point(380, 156);
            chkSemt.Name = "chkSemt";
            chkSemt.Size = new Size(18, 17);
            chkSemt.TabIndex = 23;
            chkSemt.UseVisualStyleBackColor = true;
            // 
            // chkKatNumarasi
            // 
            chkKatNumarasi.AutoSize = true;
            chkKatNumarasi.Location = new Point(380, 114);
            chkKatNumarasi.Name = "chkKatNumarasi";
            chkKatNumarasi.Size = new Size(18, 17);
            chkKatNumarasi.TabIndex = 22;
            chkKatNumarasi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AllowDrop = true;
            label12.AutoSize = true;
            label12.Location = new Point(90, 459);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 21;
            label12.Text = "Türü:";
            // 
            // cmbBelgeSecimi
            // 
            cmbBelgeSecimi.AllowDrop = true;
            cmbBelgeSecimi.FormattingEnabled = true;
            cmbBelgeSecimi.Items.AddRange(new object[] { "kiralik", "satilik" });
            cmbBelgeSecimi.Location = new Point(135, 456);
            cmbBelgeSecimi.Name = "cmbBelgeSecimi";
            cmbBelgeSecimi.Size = new Size(238, 28);
            cmbBelgeSecimi.TabIndex = 20;
            // 
            // chkAlan
            // 
            chkAlan.AutoSize = true;
            chkAlan.Location = new Point(380, 203);
            chkAlan.Name = "chkAlan";
            chkAlan.Size = new Size(18, 17);
            chkAlan.TabIndex = 19;
            chkAlan.UseVisualStyleBackColor = true;
            // 
            // chkOdaSayisi
            // 
            chkOdaSayisi.AutoSize = true;
            chkOdaSayisi.Location = new Point(380, 67);
            chkOdaSayisi.Name = "chkOdaSayisi";
            chkOdaSayisi.Size = new Size(18, 17);
            chkOdaSayisi.TabIndex = 18;
            chkOdaSayisi.UseVisualStyleBackColor = true;
            // 
            // txtDepozito
            // 
            txtDepozito.BackColor = SystemColors.Control;
            txtDepozito.Location = new Point(137, 326);
            txtDepozito.Name = "txtDepozito";
            txtDepozito.Size = new Size(238, 27);
            txtDepozito.TabIndex = 14;
            // 
            // txtKira
            // 
            txtKira.BackColor = SystemColors.Control;
            txtKira.Location = new Point(138, 370);
            txtKira.Name = "txtKira";
            txtKira.Size = new Size(237, 27);
            txtKira.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(88, 370);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 17;
            label9.Text = "Kira:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(55, 329);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 16;
            label10.Text = "Depozito:";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.SlateGray;
            btnTemizle.Location = new Point(138, 585);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(238, 43);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 285);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 12;
            label8.Text = "Türü:";
            // 
            // cmEvTuru
            // 
            cmEvTuru.FormattingEnabled = true;
            cmEvTuru.Items.AddRange(new object[] { "Daire", "Bahceli", "Dubleks", "Mustakil" });
            cmEvTuru.Location = new Point(137, 282);
            cmEvTuru.Name = "cmEvTuru";
            cmEvTuru.Size = new Size(238, 28);
            cmEvTuru.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 243);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 10;
            label7.Text = "Yapım Tarihi:";
            // 
            // dtpYapimTarihi
            // 
            dtpYapimTarihi.Location = new Point(136, 238);
            dtpYapimTarihi.Name = "dtpYapimTarihi";
            dtpYapimTarihi.Size = new Size(238, 27);
            dtpYapimTarihi.TabIndex = 9;
            // 
            // txtAlani
            // 
            txtAlani.BackColor = SystemColors.Control;
            txtAlani.Location = new Point(137, 193);
            txtAlani.Name = "txtAlani";
            txtAlani.Size = new Size(237, 27);
            txtAlani.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 196);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 8;
            label6.Text = "Alan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 153);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Semt:";
            // 
            // cmbSemt
            // 
            cmbSemt.FormattingEnabled = true;
            cmbSemt.Items.AddRange(new object[] { "Selçuklu", "Karatay", "Meram", "Kulu", "Ilgın", "Silifke", "Ereğli" });
            cmbSemt.Location = new Point(136, 150);
            cmbSemt.Name = "cmbSemt";
            cmbSemt.Size = new Size(238, 28);
            cmbSemt.TabIndex = 5;
            // 
            // txtOdaSayisi
            // 
            txtOdaSayisi.BackColor = SystemColors.Control;
            txtOdaSayisi.Location = new Point(136, 64);
            txtOdaSayisi.Name = "txtOdaSayisi";
            txtOdaSayisi.Size = new Size(238, 27);
            txtOdaSayisi.TabIndex = 0;
            // 
            // btnKiralikEkle
            // 
            btnKiralikEkle.BackColor = Color.SlateGray;
            btnKiralikEkle.Location = new Point(136, 533);
            btnKiralikEkle.Name = "btnKiralikEkle";
            btnKiralikEkle.Size = new Size(238, 43);
            btnKiralikEkle.TabIndex = 4;
            btnKiralikEkle.Text = "Arama Yap";
            btnKiralikEkle.UseVisualStyleBackColor = false;
            btnKiralikEkle.Click += btnKiralikEkle_Click;
            // 
            // txtKatNumarasi
            // 
            txtKatNumarasi.BackColor = SystemColors.Control;
            txtKatNumarasi.Location = new Point(137, 108);
            txtKatNumarasi.Name = "txtKatNumarasi";
            txtKatNumarasi.Size = new Size(237, 27);
            txtKatNumarasi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 111);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "KatNumarasi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(49, 67);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Oda Sayisi:";
            // 
            // SorgulamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1403, 793);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "SorgulamaFormu";
            Text = "SorgulamaFormu";
            Load += SorgulamaFormu_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtFiyat;
        private Label label11;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox chkAlan;
        private CheckBox chkOdaSayisi;
        private TextBox txtDepozito;
        private TextBox txtKira;
        private Label label9;
        private Label label10;
        private Button btnTemizle;
        private Label label8;
        private ComboBox cmEvTuru;
        private Label label7;
        private DateTimePicker dtpYapimTarihi;
        private TextBox txtAlani;
        private Label label6;
        private Label label5;
        private ComboBox cmbSemt;
        private TextBox txtOdaSayisi;
        private Button btnKiralikEkle;
        private TextBox txtKatNumarasi;
        private Label label2;
        private Label label1;
        private Label label12;
        private ComboBox cmbBelgeSecimi;
        private ListBox listBox1;
        private CheckBox chkFiyat;
        private CheckBox chkKira;
        private CheckBox chkDepozito;
        private CheckBox chkTur;
        private CheckBox chkYapimTarihi;
        private CheckBox chkSemt;
        private CheckBox checkBox1;
        private CheckBox chkKatNumarasi;
        private Button btnDetayGoster;
        private Button btnSil;
        private Button btnArşiv;
        private Button btnGoruntule;
    }
}