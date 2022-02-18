using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            double toplam = 0;
            double ortalama;
            while (sayac < Convert.ToInt32(listBox1.Items.Count))
            {
                toplam = toplam + Convert.ToInt32(listBox1.Items[sayac]);
                sayac++;
            }
            ortalama = toplam / sayac;
            label1.Text = "ortalama =" + ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
