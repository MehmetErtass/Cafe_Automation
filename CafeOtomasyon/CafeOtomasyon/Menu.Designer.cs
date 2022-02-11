namespace CafeOtomasyon
{
    partial class Menu
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lblYemekAdi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.btnYemekGuncelle = new System.Windows.Forms.Button();
            this.btnYemekSil = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtYemekAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(16, 15);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(483, 342);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // lblYemekAdi
            // 
            this.lblYemekAdi.AutoSize = true;
            this.lblYemekAdi.BackColor = System.Drawing.Color.White;
            this.lblYemekAdi.Location = new System.Drawing.Point(531, 81);
            this.lblYemekAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYemekAdi.Name = "lblYemekAdi";
            this.lblYemekAdi.Size = new System.Drawing.Size(79, 17);
            this.lblYemekAdi.TabIndex = 1;
            this.lblYemekAdi.Text = "Yemek Adı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(531, 118);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(651, 118);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(184, 22);
            this.txtFiyat.TabIndex = 4;
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYemekEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYemekEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYemekEkle.Location = new System.Drawing.Point(535, 162);
            this.btnYemekEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(100, 60);
            this.btnYemekEkle.TabIndex = 5;
            this.btnYemekEkle.Text = "Yemek Ekle";
            this.btnYemekEkle.UseVisualStyleBackColor = false;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // btnYemekGuncelle
            // 
            this.btnYemekGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYemekGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYemekGuncelle.Location = new System.Drawing.Point(535, 230);
            this.btnYemekGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYemekGuncelle.Name = "btnYemekGuncelle";
            this.btnYemekGuncelle.Size = new System.Drawing.Size(100, 60);
            this.btnYemekGuncelle.TabIndex = 6;
            this.btnYemekGuncelle.Text = "Yemek Güncelle";
            this.btnYemekGuncelle.UseVisualStyleBackColor = false;
            this.btnYemekGuncelle.Click += new System.EventHandler(this.btnYemekGuncelle_Click);
            // 
            // btnYemekSil
            // 
            this.btnYemekSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYemekSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYemekSil.Location = new System.Drawing.Point(535, 298);
            this.btnYemekSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnYemekSil.Name = "btnYemekSil";
            this.btnYemekSil.Size = new System.Drawing.Size(100, 60);
            this.btnYemekSil.TabIndex = 7;
            this.btnYemekSil.Text = "Yemek Sil";
            this.btnYemekSil.UseVisualStyleBackColor = false;
            this.btnYemekSil.Click += new System.EventHandler(this.btnYemekSil_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Undo;
            this.btnAnaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaMenu.Location = new System.Drawing.Point(651, 230);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(100, 60);
            this.btnAnaMenu.TabIndex = 8;
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(531, 34);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(651, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(184, 22);
            this.txtId.TabIndex = 10;
            // 
            // txtYemekAdi
            // 
            this.txtYemekAdi.Location = new System.Drawing.Point(651, 73);
            this.txtYemekAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtYemekAdi.Name = "txtYemekAdi";
            this.txtYemekAdi.Size = new System.Drawing.Size(184, 22);
            this.txtYemekAdi.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(852, 372);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnYemekSil);
            this.Controls.Add(this.btnYemekGuncelle);
            this.Controls.Add(this.btnYemekEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYemekAdi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblYemekAdi);
            this.Controls.Add(this.dgvMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lblYemekAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.Button btnYemekGuncelle;
        private System.Windows.Forms.Button btnYemekSil;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtYemekAdi;
    }
}