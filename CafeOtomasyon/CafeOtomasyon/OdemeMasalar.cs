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
    public partial class OdemeMasalar : Form
    {
        public OdemeMasalar()
        {
            InitializeComponent();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa2 odemeMasa2 = new OdemeMasa2();
            odemeMasa2.Show();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa1 odemeMasa1 = new OdemeMasa1();
            odemeMasa1.Show();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa3 odemeMasa3 = new OdemeMasa3();
            odemeMasa3.Show();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa4 odemeMasa4 = new OdemeMasa4();
            odemeMasa4.Show();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa5 odemeMasa5 = new OdemeMasa5();
            odemeMasa5.Show();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa6 odemeMasa6 = new OdemeMasa6();
            odemeMasa6.Show();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa7 odemeMasa7 = new OdemeMasa7();
            odemeMasa7.Show();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasa8 odemeMasa8 = new OdemeMasa8();
            odemeMasa8.Show();
        }
        private void btnOdemeMasalar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenuDonus = new AnaMenu();
            anamenuDonus.Show();
        }

        private void btnOdemeMasalar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenuGecis = new AnaMenu();
            anamenuGecis.Show();
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisMasalar siparisMasalaraGecis = new SiparisMasalar();
            siparisMasalaraGecis.Show();
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
