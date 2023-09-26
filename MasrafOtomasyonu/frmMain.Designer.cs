namespace MasrafOtomasyonu
{
    partial class frmMain
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
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOturumKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKullaniciYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasrafHarcamaTipleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasrafYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasraflar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonelRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasrafHarcamaRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygulamaHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGirisYapan = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuYonetim,
            this.mnuMasrafYonetimi,
            this.mnuRaporlar,
            this.mnuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOturumKapat,
            this.toolStripMenuItem1,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(78, 29);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuOturumKapat
            // 
            this.mnuOturumKapat.Name = "mnuOturumKapat";
            this.mnuOturumKapat.Size = new System.Drawing.Size(270, 34);
            this.mnuOturumKapat.Text = "Oturumu Kapat";
            this.mnuOturumKapat.Click += new System.EventHandler(this.mnuOturumKapat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(270, 34);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuYonetim
            // 
            this.mnuYonetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKullaniciYonetimi,
            this.mnuMasrafHarcamaTipleri});
            this.mnuYonetim.Name = "mnuYonetim";
            this.mnuYonetim.Size = new System.Drawing.Size(92, 29);
            this.mnuYonetim.Text = "Yönetim";
            // 
            // mnuKullaniciYonetimi
            // 
            this.mnuKullaniciYonetimi.Name = "mnuKullaniciYonetimi";
            this.mnuKullaniciYonetimi.Size = new System.Drawing.Size(297, 34);
            this.mnuKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.mnuKullaniciYonetimi.Click += new System.EventHandler(this.mnuKullaniciYonetimi_Click);
            // 
            // mnuMasrafHarcamaTipleri
            // 
            this.mnuMasrafHarcamaTipleri.Name = "mnuMasrafHarcamaTipleri";
            this.mnuMasrafHarcamaTipleri.Size = new System.Drawing.Size(297, 34);
            this.mnuMasrafHarcamaTipleri.Text = "Masraf/Harcama Tipleri";
            // 
            // mnuMasrafYonetimi
            // 
            this.mnuMasrafYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasraflar});
            this.mnuMasrafYonetimi.Name = "mnuMasrafYonetimi";
            this.mnuMasrafYonetimi.Size = new System.Drawing.Size(155, 29);
            this.mnuMasrafYonetimi.Text = "Masraf Yönetimi";
            // 
            // mnuMasraflar
            // 
            this.mnuMasraflar.Name = "mnuMasraflar";
            this.mnuMasraflar.Size = new System.Drawing.Size(187, 34);
            this.mnuMasraflar.Text = "Masraflar";
            // 
            // mnuRaporlar
            // 
            this.mnuRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPersonelRaporu,
            this.mnuMasrafHarcamaRaporu});
            this.mnuRaporlar.Name = "mnuRaporlar";
            this.mnuRaporlar.Size = new System.Drawing.Size(95, 29);
            this.mnuRaporlar.Text = "Raporlar";
            // 
            // mnuPersonelRaporu
            // 
            this.mnuPersonelRaporu.Name = "mnuPersonelRaporu";
            this.mnuPersonelRaporu.Size = new System.Drawing.Size(308, 34);
            this.mnuPersonelRaporu.Text = "Personel Raporu";
            // 
            // mnuMasrafHarcamaRaporu
            // 
            this.mnuMasrafHarcamaRaporu.Name = "mnuMasrafHarcamaRaporu";
            this.mnuMasrafHarcamaRaporu.Size = new System.Drawing.Size(308, 34);
            this.mnuMasrafHarcamaRaporu.Text = "Masraf/Harcama Raporu";
            // 
            // mnuHakkinda
            // 
            this.mnuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygulamaHakkinda});
            this.mnuHakkinda.Name = "mnuHakkinda";
            this.mnuHakkinda.Size = new System.Drawing.Size(102, 29);
            this.mnuHakkinda.Text = "Hakkında";
            // 
            // mnuUygulamaHakkinda
            // 
            this.mnuUygulamaHakkinda.Name = "mnuUygulamaHakkinda";
            this.mnuUygulamaHakkinda.Size = new System.Drawing.Size(273, 34);
            this.mnuUygulamaHakkinda.Text = "Uygulama Hakkında";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGirisYapan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(33, 25);
            this.lblGirisYapan.Text = "---";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuOturumKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuYonetim;
        private System.Windows.Forms.ToolStripMenuItem mnuMasrafYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnuRaporlar;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkinda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuKullaniciYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnuMasrafHarcamaTipleri;
        private System.Windows.Forms.ToolStripMenuItem mnuMasraflar;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonelRaporu;
        private System.Windows.Forms.ToolStripMenuItem mnuMasrafHarcamaRaporu;
        private System.Windows.Forms.ToolStripMenuItem mnuUygulamaHakkinda;
        private System.Windows.Forms.ToolStripStatusLabel lblGirisYapan;
    }
}