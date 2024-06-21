namespace WindowsForm
{
    partial class DetayForm
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
            groupBox1 = new GroupBox();
            txtAktiflik = new TextBox();
            txtEmlakNumarasi = new TextBox();
            label3 = new Label();
            label11 = new Label();
            txtFiyat = new TextBox();
            label12 = new Label();
            txtDepozito = new TextBox();
            txtKira = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            cmEvTuru = new ComboBox();
            label7 = new Label();
            dtpYapimTarihi = new DateTimePicker();
            txtAlani = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbSemt = new ComboBox();
            txtOdaSayisi = new TextBox();
            btnGuncelle = new Button();
            txtKatNumarasi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(txtAktiflik);
            groupBox1.Controls.Add(txtEmlakNumarasi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtDepozito);
            groupBox1.Controls.Add(txtKira);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmEvTuru);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpYapimTarihi);
            groupBox1.Controls.Add(txtAlani);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbSemt);
            groupBox1.Controls.Add(txtOdaSayisi);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtKatNumarasi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(242, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 647);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // txtAktiflik
            // 
            txtAktiflik.BackColor = SystemColors.Control;
            txtAktiflik.Location = new Point(134, 500);
            txtAktiflik.Name = "txtAktiflik";
            txtAktiflik.Size = new Size(237, 27);
            txtAktiflik.TabIndex = 31;
            // 
            // txtEmlakNumarasi
            // 
            txtEmlakNumarasi.BackColor = SystemColors.Control;
            txtEmlakNumarasi.Location = new Point(133, 64);
            txtEmlakNumarasi.Name = "txtEmlakNumarasi";
            txtEmlakNumarasi.Size = new Size(238, 27);
            txtEmlakNumarasi.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(8, 67);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 30;
            label3.Text = "Emlak Numarası:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(83, 464);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 17;
            label11.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = SystemColors.Control;
            txtFiyat.Location = new Point(132, 457);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(237, 27);
            txtFiyat.TabIndex = 15;
            // 
            // label12
            // 
            label12.AllowDrop = true;
            label12.AutoSize = true;
            label12.Location = new Point(70, 503);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 21;
            label12.Text = "Aktiflik:";
            // 
            // txtDepozito
            // 
            txtDepozito.BackColor = SystemColors.Control;
            txtDepozito.Location = new Point(132, 370);
            txtDepozito.Name = "txtDepozito";
            txtDepozito.Size = new Size(238, 27);
            txtDepozito.TabIndex = 14;
            // 
            // txtKira
            // 
            txtKira.BackColor = SystemColors.Control;
            txtKira.Location = new Point(133, 414);
            txtKira.Name = "txtKira";
            txtKira.Size = new Size(237, 27);
            txtKira.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(83, 414);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 17;
            label9.Text = "Kira:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(50, 373);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 16;
            label10.Text = "Depozito:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 329);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 12;
            label8.Text = "Türü:";
            // 
            // cmEvTuru
            // 
            cmEvTuru.FormattingEnabled = true;
            cmEvTuru.Items.AddRange(new object[] { "Daire", "Bahceli", "Dubleks", "Mustakil" });
            cmEvTuru.Location = new Point(132, 326);
            cmEvTuru.Name = "cmEvTuru";
            cmEvTuru.Size = new Size(238, 28);
            cmEvTuru.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 287);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 10;
            label7.Text = "Yapım Tarihi:";
            // 
            // dtpYapimTarihi
            // 
            dtpYapimTarihi.Location = new Point(131, 282);
            dtpYapimTarihi.Name = "dtpYapimTarihi";
            dtpYapimTarihi.Size = new Size(238, 27);
            dtpYapimTarihi.TabIndex = 9;
            // 
            // txtAlani
            // 
            txtAlani.BackColor = SystemColors.Control;
            txtAlani.Location = new Point(132, 237);
            txtAlani.Name = "txtAlani";
            txtAlani.Size = new Size(237, 27);
            txtAlani.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 240);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 8;
            label6.Text = "Alan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 197);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Semt:";
            // 
            // cmbSemt
            // 
            cmbSemt.FormattingEnabled = true;
            cmbSemt.Items.AddRange(new object[] { "Selçuklu", "Karatay", "Meram", "Kulu", "Ilgın", "Silifke", "Ereğli" });
            cmbSemt.Location = new Point(131, 194);
            cmbSemt.Name = "cmbSemt";
            cmbSemt.Size = new Size(238, 28);
            cmbSemt.TabIndex = 5;
            // 
            // txtOdaSayisi
            // 
            txtOdaSayisi.BackColor = SystemColors.Control;
            txtOdaSayisi.Location = new Point(131, 108);
            txtOdaSayisi.Name = "txtOdaSayisi";
            txtOdaSayisi.Size = new Size(238, 27);
            txtOdaSayisi.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SlateGray;
            btnGuncelle.Location = new Point(131, 577);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(238, 43);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKatNumarasi
            // 
            txtKatNumarasi.BackColor = SystemColors.Control;
            txtKatNumarasi.Location = new Point(132, 152);
            txtKatNumarasi.Name = "txtKatNumarasi";
            txtKatNumarasi.Size = new Size(237, 27);
            txtKatNumarasi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 155);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "KatNumarasi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Oda Sayisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(618, 37);
            label4.Name = "label4";
            label4.Size = new Size(123, 48);
            label4.TabIndex = 16;
            label4.Text = "EMLAK";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.SlateGray;
            label13.Location = new Point(250, 37);
            label13.Name = "label13";
            label13.Size = new Size(120, 48);
            label13.TabIndex = 15;
            label13.Text = "YAŞAR";
            // 
            // DetayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(969, 764);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Name = "DetayForm";
            Text = "DetayForm";
            Load += DetayForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtFiyat;
        private Label label12;
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
        private Button btnGuncelle;
        private TextBox txtKatNumarasi;
        private Label label2;
        private Label label1;
        private TextBox txtEmlakNumarasi;
        private Label label3;
        private TextBox txtAktiflik;
        private Label label4;
        private Label label13;
    }
}