namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            btnKayitOl = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.Control;
            txtKullaniciAdi.Location = new Point(137, 55);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(150, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Control;
            txtSifre.Location = new Point(137, 108);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 27);
            txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 115);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(btnKayitOl);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(179, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 281);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Location = new Point(89, 157);
            button1.Name = "button1";
            button1.Size = new Size(198, 43);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(177, 53);
            label3.Name = "label3";
            label3.Size = new Size(120, 48);
            label3.TabIndex = 6;
            label3.Text = "YAŞAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(430, 53);
            label4.Name = "label4";
            label4.Size = new Size(123, 48);
            label4.TabIndex = 7;
            label4.Text = "EMLAK";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.SlateGray;
            btnKayitOl.Location = new Point(89, 216);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(198, 43);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(736, 420);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.MenuText;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button btnKayitOl;
    }
}