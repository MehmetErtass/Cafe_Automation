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
    public partial class OdemeMasa4 : Form
    {
        List<tbl_Masa4> list;
        int fiyat = 0;
        public OdemeMasa4()
        {
            InitializeComponent();
        }
        ErtasCafeOtomasyonuEntities1 db = new ErtasCafeOtomasyonuEntities1();

        private void Goster()
        {
            list = db.tbl_Masa4.ToList();
            dgvOdemeMasa.DataSource = list;
        }
        private void toplamFiyat()
        {
            if (list.Count > 0)
            {
                var fiyat = db.tbl_Masa4.Sum(x => x.fiyat);
                if (fiyat == 0)
                {
                    lblToplamTutar.Text = "0";
                }
                else
                {
                    lblToplamTutar.Text = fiyat.ToString();
                    this.fiyat = fiyat;
                }
            }
            else
            {
                lblToplamTutar.Text = "0";
            }
        }
        private void sil()
        {
            var all = from c in db.tbl_Masa4 select c;
            db.tbl_Masa4.RemoveRange(all);
            db.SaveChanges();
            Goster();
            toplamFiyat();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            int alinan = Convert.ToInt32(txtAlınanTutar.Text);
            if (alinan == fiyat)
            {
                MessageBox.Show("Ödeme Alındı", "Ödeme Alma", MessageBoxButtons.OK);
                sil();
            }
            else if (alinan > fiyat)
            {
                MessageBox.Show("Ödeme Alındı\nPara üstü: " + (alinan - fiyat), "Ödeme Alma", MessageBoxButtons.OK);
                sil();
            }
            else
            {
                MessageBox.Show("Eksik Para Verildi: " + (fiyat - alinan), "Ödeme Alma", MessageBoxButtons.OK);
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }

        private void OdemeMasa4_Load(object sender, EventArgs e)
        {
            Goster();
            toplamFiyat();
            dgvOdemeMasa.Columns["id"].HeaderText = "Id";
            dgvOdemeMasa.Columns["yemekAdi"].HeaderText = "Yemek Adı";
            dgvOdemeMasa.Columns["adet"].HeaderText = "Adet";
            dgvOdemeMasa.Columns["fiyat"].HeaderText = "Fiyat";
        }
    }
}
