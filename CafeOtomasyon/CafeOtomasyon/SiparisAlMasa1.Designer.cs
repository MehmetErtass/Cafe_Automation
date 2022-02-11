namespace CafeOtomasyon
{
    partial class SiparisAlMasa1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.cboxYemekAdi = new System.Windows.Forms.ComboBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblYemekAdi = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvMasa = new System.Windows.Forms.DataGridView();
            this.lblMasa1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(685, 202);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(165, 22);
            this.txtFiyat.TabIndex = 30;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(579, 210);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 29;
            this.lblFiyat.Text = "Fiyat";
            // 
            // cboxYemekAdi
            // 
            this.cboxYemekAdi.FormattingEnabled = true;
            this.cboxYemekAdi.Location = new System.Drawing.Point(685, 92);
            this.cboxYemekAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cboxYemekAdi.Name = "cboxYemekAdi";
            this.cboxYemekAdi.Size = new System.Drawing.Size(165, 24);
            this.cboxYemekAdi.TabIndex = 28;
            this.cboxYemekAdi.SelectionChangeCommitted += new System.EventHandler(this.cboxYemekAdi_SelectionChangeCommitted);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Undo;
            this.btnAnaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaMenu.Location = new System.Drawing.Point(741, 346);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(111, 68);
            this.btnAnaMenu.TabIndex = 27;
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click_1);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSiparisSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisSil.Location = new System.Drawing.Point(583, 346);
            this.btnSiparisSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(111, 68);
            this.btnSiparisSil.TabIndex = 26;
            this.btnSiparisSil.Text = "Sipariş Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = false;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiparisGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(741, 249);
            this.btnSiparisGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(111, 68);
            this.btnSiparisGuncelle.TabIndex = 25;
            this.btnSiparisGuncelle.Text = "Sipariş Güncelle";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSiparisVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisVer.Location = new System.Drawing.Point(583, 249);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(111, 68);
            this.btnSiparisVer.TabIndex = 24;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(291, 352);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(39, 38);
            this.lblToplamTutar.TabIndex = 23;
            this.lblToplamTutar.Text = "X";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTT.Location = new System.Drawing.Point(28, 352);
            this.lblTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(219, 38);
            this.lblTT.TabIndex = 22;
            this.lblTT.Text = "Toplam Tutar:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(685, 153);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(165, 22);
            this.txtAdet.TabIndex = 21;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(685, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 22);
            this.txtId.TabIndex = 20;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(579, 161);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(37, 17);
            this.lblAdet.TabIndex = 19;
            this.lblAdet.Text = "Adet";
            // 
            // lblYemekAdi
            // 
            this.lblYemekAdi.AutoSize = true;
            this.lblYemekAdi.Location = new System.Drawing.Point(579, 102);
            this.lblYemekAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYemekAdi.Name = "lblYemekAdi";
            this.lblYemekAdi.Size = new System.Drawing.Size(75, 17);
            this.lblYemekAdi.TabIndex = 18;
            this.lblYemekAdi.Text = "Yemek Adı";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(579, 43);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // dgvMasa
            // 
            this.dgvMasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasa.Location = new System.Drawing.Point(28, 26);
            this.dgvMasa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMasa.Name = "dgvMasa";
            this.dgvMasa.Size = new System.Drawing.Size(527, 303);
            this.dgvMasa.TabIndex = 16;
            this.dgvMasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasa_CellContentClick);
            // 
            // lblMasa1
            // 
            this.lblMasa1.AutoSize = true;
            this.lblMasa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa1.Location = new System.Drawing.Point(428, 352);
            this.lblMasa1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasa1.Name = "lblMasa1";
            this.lblMasa1.Size = new System.Drawing.Size(118, 36);
            this.lblMasa1.TabIndex = 31;
            this.lblMasa1.Text = "Masa 1";
            // 
            // SiparisAlMasa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(881, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lblMasa1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.cboxYemekAdi);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnSiparisGuncelle);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblYemekAdi);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvMasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisAlMasa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Al Masa1";
            this.Load += new System.EventHandler(this.SiparisAlMasa1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.ComboBox cboxYemekAdi;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblYemekAdi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvMasa;
        private System.Windows.Forms.Label lblMasa1;
    }
}