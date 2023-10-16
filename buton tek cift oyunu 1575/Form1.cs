using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_tek_cift_oyunu_1575
{
    public partial class Form1 : Form
    {
        int sayi = 0, puan = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);
            lblSayi.Text = sayi.ToString();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            if (sayi % 2 != 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text= puan.ToString();
        }  
    }
}
