namespace WindowsForm
{
    partial class EvEkleme
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
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
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
            groupBox2 = new GroupBox();
            txtEmlakNumarasi2 = new TextBox();
            label19 = new Label();
            txtFiyat1 = new TextBox();
            label11 = new Label();
            button1 = new Button();
            label13 = new Label();
            cmTur1 = new ComboBox();
            label14 = new Label();
            dtTarih1 = new DateTimePicker();
            txtAlan1 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            cmSemt1 = new ComboBox();
            txtOdaSayisi1 = new TextBox();
            btnSatılıkEvEkle = new Button();
            txtKatNumarasi1 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(884, 42);
            label4.Name = "label4";
            label4.Size = new Size(123, 48);
            label4.TabIndex = 10;
            label4.Text = "EMLAK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(120, 48);
            label3.TabIndex = 9;
            label3.Text = "YAŞAR";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
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
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 576);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // txtDepozito
            // 
            txtDepozito.BackColor = SystemColors.Control;
            txtDepozito.Location = new Point(124, 307);
            txtDepozito.Name = "txtDepozito";
            txtDepozito.Size = new Size(238, 27);
            txtDepozito.TabIndex = 14;
            // 
            // txtKira
            // 
            txtKira.BackColor = SystemColors.Control;
            txtKira.Location = new Point(125, 351);
            txtKira.Name = "txtKira";
            txtKira.Size = new Size(237, 27);
            txtKira.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 351);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 17;
            label9.Text = "Kira:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(42, 310);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 16;
            label10.Text = "Depozito:";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.SlateGray;
            btnTemizle.Location = new Point(124, 462);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(238, 43);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 266);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 12;
            label8.Text = "Türü:";
            // 
            // cmEvTuru
            // 
            cmEvTuru.FormattingEnabled = true;
            cmEvTuru.Items.AddRange(new object[] { "Daire", "Bahceli", "Dubleks", "Mustakil" });
            cmEvTuru.Location = new Point(124, 263);
            cmEvTuru.Name = "cmEvTuru";
            cmEvTuru.Size = new Size(238, 28);
            cmEvTuru.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 224);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 10;
            label7.Text = "Yapım Tarihi:";
            // 
            // dtpYapimTarihi
            // 
            dtpYapimTarihi.Location = new Point(123, 219);
            dtpYapimTarihi.Name = "dtpYapimTarihi";
            dtpYapimTarihi.Size = new Size(238, 27);
            dtpYapimTarihi.TabIndex = 9;
            // 
            // txtAlani
            // 
            txtAlani.BackColor = SystemColors.Control;
            txtAlani.Location = new Point(124, 174);
            txtAlani.Name = "txtAlani";
            txtAlani.Size = new Size(237, 27);
            txtAlani.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 177);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 8;
            label6.Text = "Alan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 134);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Semt:";
            // 
            // cmbSemt
            // 
            cmbSemt.FormattingEnabled = true;
            cmbSemt.Items.AddRange(new object[] { "Selçuklu", "Karatay", "Meram", "Kulu", "Ilgın", "Silifke", "Ereğli" });
            cmbSemt.Location = new Point(123, 131);
            cmbSemt.Name = "cmbSemt";
            cmbSemt.Size = new Size(238, 28);
            cmbSemt.TabIndex = 5;
            // 
            // txtOdaSayisi
            // 
            txtOdaSayisi.BackColor = SystemColors.Control;
            txtOdaSayisi.Location = new Point(123, 45);
            txtOdaSayisi.Name = "txtOdaSayisi";
            txtOdaSayisi.Size = new Size(238, 27);
            txtOdaSayisi.TabIndex = 0;
            // 
            // btnKiralikEkle
            // 
            btnKiralikEkle.BackColor = Color.SlateGray;
            btnKiralikEkle.Location = new Point(124, 403);
            btnKiralikEkle.Name = "btnKiralikEkle";
            btnKiralikEkle.Size = new Size(238, 43);
            btnKiralikEkle.TabIndex = 4;
            btnKiralikEkle.Text = "Kiralık Kayıt Ekle";
            btnKiralikEkle.UseVisualStyleBackColor = false;
            btnKiralikEkle.Click += btnKiralikEkle_Click;
            // 
            // txtKatNumarasi
            // 
            txtKatNumarasi.BackColor = SystemColors.Control;
            txtKatNumarasi.Location = new Point(124, 89);
            txtKatNumarasi.Name = "txtKatNumarasi";
            txtKatNumarasi.Size = new Size(237, 27);
            txtKatNumarasi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 92);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "KatNumarasi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Oda Sayisi:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateGray;
            groupBox2.Controls.Add(txtEmlakNumarasi2);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtFiyat1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmTur1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dtTarih1);
            groupBox2.Controls.Add(txtAlan1);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cmSemt1);
            groupBox2.Controls.Add(txtOdaSayisi1);
            groupBox2.Controls.Add(btnSatılıkEvEkle);
            groupBox2.Controls.Add(txtKatNumarasi1);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(562, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 576);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // txtEmlakNumarasi2
            // 
            txtEmlakNumarasi2.BackColor = SystemColors.Control;
            txtEmlakNumarasi2.Location = new Point(134, 42);
            txtEmlakNumarasi2.Name = "txtEmlakNumarasi2";
            txtEmlakNumarasi2.Size = new Size(238, 27);
            txtEmlakNumarasi2.TabIndex = 18;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.WhiteSmoke;
            label19.Location = new Point(47, 45);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 19;
            label19.Text = "Oda Sayisi:";
            // 
            // txtFiyat1
            // 
            txtFiyat1.BackColor = SystemColors.Control;
            txtFiyat1.Location = new Point(135, 349);
            txtFiyat1.Name = "txtFiyat1";
            txtFiyat1.Size = new Size(237, 27);
            txtFiyat1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(85, 349);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 17;
            label11.Text = "Fiyat:";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Location = new Point(125, 472);
            button1.Name = "button1";
            button1.Size = new Size(238, 43);
            button1.TabIndex = 13;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(84, 308);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 12;
            label13.Text = "Türü:";
            // 
            // cmTur1
            // 
            cmTur1.FormattingEnabled = true;
            cmTur1.Items.AddRange(new object[] { "Daire", "Bahceli", "Dubleks", "Mustakil" });
            cmTur1.Location = new Point(136, 305);
            cmTur1.Name = "cmTur1";
            cmTur1.Size = new Size(238, 28);
            cmTur1.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 266);
            label14.Name = "label14";
            label14.Size = new Size(92, 20);
            label14.TabIndex = 10;
            label14.Text = "Yapım Tarihi:";
            // 
            // dtTarih1
            // 
            dtTarih1.Location = new Point(135, 261);
            dtTarih1.Name = "dtTarih1";
            dtTarih1.Size = new Size(238, 27);
            dtTarih1.TabIndex = 9;
            // 
            // txtAlan1
            // 
            txtAlan1.BackColor = SystemColors.Control;
            txtAlan1.Location = new Point(136, 216);
            txtAlan1.Name = "txtAlan1";
            txtAlan1.Size = new Size(237, 27);
            txtAlan1.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(87, 219);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 8;
            label15.Text = "Alan:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(83, 176);
            label16.Name = "label16";
            label16.Size = new Size(46, 20);
            label16.TabIndex = 6;
            label16.Text = "Semt:";
            // 
            // cmSemt1
            // 
            cmSemt1.FormattingEnabled = true;
            cmSemt1.Items.AddRange(new object[] { "Selçuklu", "Karatay", "Meram", "Kulu", "Ilgın", "Silifke", "Ereğli" });
            cmSemt1.Location = new Point(135, 173);
            cmSemt1.Name = "cmSemt1";
            cmSemt1.Size = new Size(238, 28);
            cmSemt1.TabIndex = 5;
            // 
            // txtOdaSayisi1
            // 
            txtOdaSayisi1.BackColor = SystemColors.Control;
            txtOdaSayisi1.Location = new Point(135, 87);
            txtOdaSayisi1.Name = "txtOdaSayisi1";
            txtOdaSayisi1.Size = new Size(238, 27);
            txtOdaSayisi1.TabIndex = 0;
            // 
            // btnSatılıkEvEkle
            // 
            btnSatılıkEvEkle.BackColor = Color.SlateGray;
            btnSatılıkEvEkle.Location = new Point(125, 413);
            btnSatılıkEvEkle.Name = "btnSatılıkEvEkle";
            btnSatılıkEvEkle.Size = new Size(238, 43);
            btnSatılıkEvEkle.TabIndex = 4;
            btnSatılıkEvEkle.Text = "Satılık Kayıt Ekle";
            btnSatılıkEvEkle.UseVisualStyleBackColor = false;
            btnSatılıkEvEkle.Click += btnSatılıkEvEkle_Click;
            // 
            // txtKatNumarasi1
            // 
            txtKatNumarasi1.BackColor = SystemColors.Control;
            txtKatNumarasi1.Location = new Point(136, 131);
            txtKatNumarasi1.Name = "txtKatNumarasi1";
            txtKatNumarasi1.Size = new Size(237, 27);
            txtKatNumarasi1.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 134);
            label17.Name = "label17";
            label17.Size = new Size(97, 20);
            label17.TabIndex = 3;
            label17.Text = "KatNumarasi:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(48, 90);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 2;
            label18.Text = "Oda Sayisi:";
            // 
            // EvEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1174, 733);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "EvEkleme";
            Text = "EvEkleme";
            Load += EvEkleme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
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
        private Button btnTemizle;
        private Label label8;
        private ComboBox cmEvTuru;
        private TextBox txtDepozito;
        private TextBox txtKira;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox txtFiyat1;
        private Label label11;
        private Button button1;
        private Label label13;
        private ComboBox cmTur1;
        private Label label14;
        private DateTimePicker dtTarih1;
        private TextBox txtAlan1;
        private Label label15;
        private Label label16;
        private ComboBox cmSemt1;
        private TextBox txtOdaSayisi1;
        private Button btnSatılıkEvEkle;
        private TextBox txtKatNumarasi1;
        private Label label17;
        private Label label18;
        private TextBox txtEmlakNumarasi2;
        private Label label19;
    }
}