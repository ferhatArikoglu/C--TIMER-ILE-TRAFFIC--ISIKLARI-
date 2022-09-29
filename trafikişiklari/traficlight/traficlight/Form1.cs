using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traficlight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac==50)
            {
                this.BackColor=Color.Red;
            }
            if (sayac == 70)
            {
                this.BackColor = Color.Gold;
            }
            if (sayac == 140)
            {
                sayac = 0;
                this.BackColor = Color.Green;
            }
        }
    }
}
