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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        ErtasCafeOtomasyonuEntities1 db = new ErtasCafeOtomasyonuEntities1();
        int hak = 3;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Sistemdeki girmek için her haneyi doldurunuz lütfen");
            }
            var sonuc = db.tbl_Kullanici.Where(x => x.kullaniciAdi == txtKullaniciAdi.Text &&
            x.sifre == txtSifre.Text).FirstOrDefault();
            if (sonuc != null)
            {
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girişiniz Bilgileriniz doğru değildir . Kalan Hakkınız : " + --hak);
                if (hak == 0)
                {
                    Application.Exit();
                }

            }
            
            }

        private void Giris_Load(object sender, EventArgs e)
        {

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
