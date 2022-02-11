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
    public partial class SiparisMasalar : Form
    {
        public SiparisMasalar()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa1 siparisAlMasa1 = new SiparisAlMasa1();
            siparisAlMasa1.Show();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa2 siparisAlMasa2 = new SiparisAlMasa2();
            siparisAlMasa2.Show();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa3 siparisAlMasa3 = new SiparisAlMasa3();
            siparisAlMasa3.Show();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa4 siparisAlMasa4 = new SiparisAlMasa4();
            siparisAlMasa4.Show();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa5 siparisAlMasa5 = new SiparisAlMasa5();
            siparisAlMasa5.Show();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa6 siparisAlMasa6 = new SiparisAlMasa6();
            siparisAlMasa6.Show();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa7 siparisAlMasa7 = new SiparisAlMasa7();
            siparisAlMasa7.Show();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisAlMasa8 siparisAlMasa8 = new SiparisAlMasa8();
            siparisAlMasa8.Show();
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenuGecis = new AnaMenu();
            anamenuGecis.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasalar odemeMasalaraGecis = new OdemeMasalar();
            odemeMasalaraGecis.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MenuyeGecis = new Menu();
            MenuyeGecis.Show();
        }

        private void btnMenuGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris GiriseGecis = new Giris();
            GiriseGecis.Show();
        }
    }
}
