namespace AssetManagement.UI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaFiyatBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listelemeToolStripMenuItem,
            this.yeniKayıtToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            this.listelemeToolStripMenuItem.Click += new System.EventHandler(this.listelemeToolStripMenuItem_Click);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıRaporuToolStripMenuItem,
            this.markaFiyatBilgisiToolStripMenuItem,
            this.müşteriBilgisiToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // kullanıcıRaporuToolStripMenuItem
            // 
            this.kullanıcıRaporuToolStripMenuItem.Name = "kullanıcıRaporuToolStripMenuItem";
            this.kullanıcıRaporuToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kullanıcıRaporuToolStripMenuItem.Text = "Kullanıcı Raporu";
            this.kullanıcıRaporuToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıRaporuToolStripMenuItem_Click);
            // 
            // markaFiyatBilgisiToolStripMenuItem
            // 
            this.markaFiyatBilgisiToolStripMenuItem.Name = "markaFiyatBilgisiToolStripMenuItem";
            this.markaFiyatBilgisiToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.markaFiyatBilgisiToolStripMenuItem.Text = "Marka - Fiyat Bilgisi";
            this.markaFiyatBilgisiToolStripMenuItem.Click += new System.EventHandler(this.markaFiyatBilgisiToolStripMenuItem_Click);
            // 
            // müşteriBilgisiToolStripMenuItem
            // 
            this.müşteriBilgisiToolStripMenuItem.Name = "müşteriBilgisiToolStripMenuItem";
            this.müşteriBilgisiToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.müşteriBilgisiToolStripMenuItem.Text = "Müşteri Bilgisi";
            this.müşteriBilgisiToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgisiToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Ana Menü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaFiyatBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgisiToolStripMenuItem;
    }
}