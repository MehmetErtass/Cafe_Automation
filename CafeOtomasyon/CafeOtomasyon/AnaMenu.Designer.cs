namespace CafeOtomasyon
{
    partial class AnaMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnSiparisAl = new System.Windows.Forms.Button();
            this.btnGiriseGecis = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::CafeOtomasyon.Properties.Resources.delete_icon;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(627, -1);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(71, 73);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMenu.BackgroundImage = global::CafeOtomasyon.Properties.Resources.restaurant_menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(434, 93);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(199, 175);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKasa.BackgroundImage = global::CafeOtomasyon.Properties.Resources.register_2_icon;
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasa.Location = new System.Drawing.Point(228, 93);
            this.btnKasa.Margin = new System.Windows.Forms.Padding(4);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(209, 175);
            this.btnKasa.TabIndex = 1;
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiparisAl.BackgroundImage = global::CafeOtomasyon.Properties.Resources.fork_and_knife_with_plate_icon;
            this.btnSiparisAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisAl.Location = new System.Drawing.Point(27, 93);
            this.btnSiparisAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(203, 175);
            this.btnSiparisAl.TabIndex = 0;
            this.btnSiparisAl.UseVisualStyleBackColor = false;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // btnGiriseGecis
            // 
            this.btnGiriseGecis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGiriseGecis.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Lock_icon;
            this.btnGiriseGecis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiriseGecis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiriseGecis.Location = new System.Drawing.Point(228, 265);
            this.btnGiriseGecis.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiriseGecis.Name = "btnGiriseGecis";
            this.btnGiriseGecis.Size = new System.Drawing.Size(209, 175);
            this.btnGiriseGecis.TabIndex = 4;
            this.btnGiriseGecis.UseVisualStyleBackColor = false;
            this.btnGiriseGecis.Click += new System.EventHandler(this.btnMenuGecis_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(502, 440);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 18);
            this.lblTimer.TabIndex = 5;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(697, 467);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGiriseGecis);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnSiparisAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisAl;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGiriseGecis;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
    }
}