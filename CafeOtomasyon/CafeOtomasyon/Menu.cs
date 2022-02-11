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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        ErtasCafeOtomasyonuEntities1 db = new ErtasCafeOtomasyonuEntities1();

        private void Goster()
        {
            dgvMenu.DataSource = db.tbl_Menu.ToList();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            if (txtYemekAdi.Text == "" || txtFiyat.Text == "" )
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
            else
            {
                try
                {
                    tbl_Menu tbl = new tbl_Menu();
                    tbl.yemekAdi = txtYemekAdi.Text;
                    tbl.fiyat = txtFiyat.Text;
                    db.tbl_Menu.Add(tbl);
                    db.SaveChanges();
                    Goster();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYemekAdi.Text == "" || txtFiyat.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Kayıt Güncelleme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int kod = Convert.ToInt32(txtId.Text);
                        var sonuc = db.tbl_Menu.Where(x => x.id == kod).FirstOrDefault();
                        sonuc.yemekAdi = txtYemekAdi.Text;
                        sonuc.fiyat = txtFiyat.Text;
                        db.SaveChanges();
                        MessageBox.Show("Yemek Kaydı Güncellendi.");
                        Goster();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(txtId.Text);
            var sonuc = db.tbl_Menu.Where(x => x.id == kod).FirstOrDefault();

            if (txtId.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.tbl_Menu.Remove(sonuc);
                        db.SaveChanges();
                        MessageBox.Show("Yemek Kaydı Silindi.");
                        Goster();
                    }
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMenu.CurrentRow.Cells[0].Value.ToString();
            txtYemekAdi.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }
    }
}
