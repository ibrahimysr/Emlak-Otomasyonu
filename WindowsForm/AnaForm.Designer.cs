namespace WindowsForm
{
    partial class AnaForm
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
            btnCikisYap = new Button();
            button4 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(439, 56);
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
            label3.Location = new Point(186, 56);
            label3.Name = "label3";
            label3.Size = new Size(120, 48);
            label3.TabIndex = 9;
            label3.Text = "YAŞAR";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateGray;
            groupBox1.Controls.Add(btnCikisYap);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(188, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 331);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.SlateGray;
            btnCikisYap.Location = new Point(78, 230);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(198, 72);
            btnCikisYap.TabIndex = 8;
            btnCikisYap.Text = "Çıkış Yap:";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Location = new Point(78, 141);
            button4.Name = "button4";
            button4.Size = new Size(198, 72);
            button4.TabIndex = 7;
            button4.Text = "Sorgulama-listeleme";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Location = new Point(78, 48);
            button1.Name = "button1";
            button1.Size = new Size(198, 69);
            button1.TabIndex = 4;
            button1.Text = "Yeni ev ekleme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(763, 476);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "AnaForm";
            Text = "AnaForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Button button4;
        private Button button1;
        private Button btnCikisYap;
    }
}