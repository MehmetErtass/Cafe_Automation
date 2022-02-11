using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;
            timer1.Interval = 4000;
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i == 1)
            {
                timer1.Stop();
                this.Hide();
                Giris girisFormunaGecis = new Giris();
                girisFormunaGecis.Show();
            }

        }
    }
}
