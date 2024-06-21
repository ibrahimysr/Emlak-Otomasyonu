using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvEkleme evekle = new EvEkleme();
            evekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SorgulamaFormu sorguformu = new SorgulamaFormu();
            sorguformu.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();

            this.Hide();
        }
    }
}
