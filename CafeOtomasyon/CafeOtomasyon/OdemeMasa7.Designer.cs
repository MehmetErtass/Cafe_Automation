namespace CafeOtomasyon
{
    partial class OdemeMasa7
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtAlınanTutar = new System.Windows.Forms.TextBox();
            this.lblMusteridenAlinanTutar = new System.Windows.Forms.Label();
            this.lblTl = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.lblFis = new System.Windows.Forms.Label();
            this.dgvOdemeMasa = new System.Windows.Forms.DataGridView();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.lblMasa7 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtAlınanTutar);
            this.groupBox.Controls.Add(this.lblMusteridenAlinanTutar);
            this.groupBox.Location = new System.Drawing.Point(659, 219);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(441, 123);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            // 
            // txtAlınanTutar
            // 
            this.txtAlınanTutar.Location = new System.Drawing.Point(289, 57);
            this.txtAlınanTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlınanTutar.Name = "txtAlınanTutar";
            this.txtAlınanTutar.Size = new System.Drawing.Size(132, 22);
            this.txtAlınanTutar.TabIndex = 1;
            // 
            // lblMusteridenAlinanTutar
            // 
            this.lblMusteridenAlinanTutar.AutoSize = true;
            this.lblMusteridenAlinanTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteridenAlinanTutar.Location = new System.Drawing.Point(8, 54);
            this.lblMusteridenAlinanTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteridenAlinanTutar.Name = "lblMusteridenAlinanTutar";
            this.lblMusteridenAlinanTutar.Size = new System.Drawing.Size(250, 25);
            this.lblMusteridenAlinanTutar.TabIndex = 0;
            this.lblMusteridenAlinanTutar.Text = "Müşteriden Alınan Tutar:";
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTl.Location = new System.Drawing.Point(871, 153);
            this.lblTl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(57, 38);
            this.lblTl.TabIndex = 12;
            this.lblTl.Text = "TL";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(794, 153);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(40, 38);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "X";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(680, 70);
            this.lblOdenecekTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(377, 42);
            this.lblOdenecekTutar.TabIndex = 10;
            this.lblOdenecekTutar.Text = "ÖDENECEK TUTAR";
            // 
            // lblFis
            // 
            this.lblFis.AutoSize = true;
            this.lblFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFis.Location = new System.Drawing.Point(247, 21);
            this.lblFis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFis.Name = "lblFis";
            this.lblFis.Size = new System.Drawing.Size(76, 46);
            this.lblFis.TabIndex = 9;
            this.lblFis.Text = "Fiş";
            // 
            // dgvOdemeMasa
            // 
            this.dgvOdemeMasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeMasa.Location = new System.Drawing.Point(13, 71);
            this.dgvOdemeMasa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOdemeMasa.Name = "dgvOdemeMasa";
            this.dgvOdemeMasa.Size = new System.Drawing.Size(592, 353);
            this.dgvOdemeMasa.TabIndex = 8;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Undo;
            this.btnAnaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaMenu.Location = new System.Drawing.Point(876, 350);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(124, 74);
            this.btnAnaMenu.TabIndex = 15;
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOdemeAl.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Dollar_icon6;
            this.btnOdemeAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdemeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeAl.ForeColor = System.Drawing.Color.Black;
            this.btnOdemeAl.Location = new System.Drawing.Point(724, 350);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(124, 74);
            this.btnOdemeAl.TabIndex = 14;
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // lblMasa7
            // 
            this.lblMasa7.AutoSize = true;
            this.lblMasa7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa7.Location = new System.Drawing.Point(794, 9);
            this.lblMasa7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasa7.Name = "lblMasa7";
            this.lblMasa7.Size = new System.Drawing.Size(147, 42);
            this.lblMasa7.TabIndex = 17;
            this.lblMasa7.Text = "Masa 7";
            // 
            // OdemeMasa7
            // 
            this.AcceptButton = this.btnOdemeAl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1124, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lblMasa7);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblTl);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.lblFis);
            this.Controls.Add(this.dgvOdemeMasa);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnOdemeAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdemeMasa7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdemeMasa7";
            this.Load += new System.EventHandler(this.OdemeMasa7_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeMasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtAlınanTutar;
        private System.Windows.Forms.Label lblMusteridenAlinanTutar;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label lblFis;
        private System.Windows.Forms.DataGridView dgvOdemeMasa;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Label lblMasa7;
    }
}