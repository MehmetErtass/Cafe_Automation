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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisMasalar masalar = new SiparisMasalar();
            masalar.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdemeMasalar odemeMasalar = new OdemeMasalar();
            odemeMasalar.Show();
        }
        private void btnMenuGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris girisedonus = new Giris();
            girisedonus.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Enabled = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
