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
    public partial class SiparisAlMasa3 : Form
    {
        List<tbl_Masa3> list;
        public SiparisAlMasa3()
        {
            InitializeComponent();
        }
        ErtasCafeOtomasyonuEntities1 db = new ErtasCafeOtomasyonuEntities1();

        private void YemekAdiGoster()
        {
            cboxYemekAdi.DataSource = db.tbl_Menu.ToList();
            cboxYemekAdi.ValueMember = "yemekAdi";
        }

        private void Goster()
        {
            list = db.tbl_Masa3.ToList();
            dgvMasa.DataSource = list;
        }

        int yemekFiyat = 0;
        private void FiyatBilgisi()
        {
            string yemekAdi = cboxYemekAdi.SelectedValue.ToString();
            var nesne = db.tbl_Menu.Where(x => x.yemekAdi == yemekAdi).ToList().First();
            yemekFiyat = Convert.ToInt32(nesne.fiyat);
            txtFiyat.Text = yemekFiyat.ToString();
        }

        int id;

        private void fiyatBelirle()
        {
            int adet = 0;
            if (txtAdet.Text != "")
            {
                adet = Convert.ToInt32(txtAdet.Text);
            }
            int fiyat = yemekFiyat * adet;
            txtFiyat.Text = fiyat.ToString();
        }

        private void toplamFiyat()
        {
            if (list.Count > 0)
            {
                var fiyat = db.tbl_Masa3.Sum(x => x.fiyat);
                if (fiyat == 0)
                {
                    lblToplamTutar.Text = "0";
                }
                else
                {
                    lblToplamTutar.Text = fiyat.ToString();
                }
            }
            else
            {
                lblToplamTutar.Text = "0";
            }
        }

        private void btnSiparisVer_Click_1(object sender, EventArgs e)
        {
            if (cboxYemekAdi.Text == "" || txtAdet.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Sipariş başlatmak istediğinize emin misiniz?", "Kayıt Ekleme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tbl_Masa3 tbl = new tbl_Masa3();
                        tbl.yemekAdi = cboxYemekAdi.SelectedValue.ToString();
                        tbl.adet = txtAdet.Text;
                        tbl.fiyat = Convert.ToInt32(txtFiyat.Text);
                        db.tbl_Masa3.Add(tbl);
                        db.SaveChanges();
                        Goster();
                        YemekAdiGoster();
                        toplamFiyat();
                    }
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void SiparisAlMasa3_Load(object sender, EventArgs e)
        {
            YemekAdiGoster();
            Goster();
            toplamFiyat();

            dgvMasa.Columns[0].Width = 50;
            dgvMasa.Columns[1].Width = 140;
            dgvMasa.Columns[2].Width = 80;
            dgvMasa.Columns[3].Width = 80;

            dgvMasa.Columns["id"].HeaderText = "Id";
            dgvMasa.Columns["yemekAdi"].HeaderText = "Yemek Adı";
            dgvMasa.Columns["adet"].HeaderText = "Adet";
            dgvMasa.Columns["fiyat"].HeaderText = "Fiyat";
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }

        private void cboxYemekAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FiyatBilgisi();
            fiyatBelirle();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            fiyatBelirle();
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(txtId.Text);
            var sonuc = db.tbl_Masa3.Where(x => x.id == kod).FirstOrDefault();
            id = sonuc.id;
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
                        db.tbl_Masa3.Remove(sonuc);
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Silindi.");
                        Goster();
                        toplamFiyat();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || cboxYemekAdi.Text == "" || txtAdet.Text == "" ||
               txtFiyat.Text == "")
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
                        var sonuc = db.tbl_Masa3.Where(x => x.id == kod).FirstOrDefault();
                        sonuc.adet = txtAdet.Text;
                        sonuc.fiyat = Convert.ToInt32(txtFiyat.Text);
                        sonuc.yemekAdi = cboxYemekAdi.SelectedValue.ToString();
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Güncellendi.");
                        Goster();
                        toplamFiyat();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvMasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMasa.CurrentRow.Cells[0].Value.ToString();
            cboxYemekAdi.SelectedValue = dgvMasa.CurrentRow.Cells[1].Value.ToString();
            txtAdet.Text = dgvMasa.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dgvMasa.CurrentRow.Cells[3].Value.ToString();
        }
    }
}