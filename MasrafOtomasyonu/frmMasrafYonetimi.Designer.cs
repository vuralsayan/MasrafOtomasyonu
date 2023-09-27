namespace MasrafOtomasyonu
{
    partial class frmMasrafYonetimi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFisTutar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMasrafTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMasraflar = new System.Windows.Forms.ListView();
            this.clmSahibi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMasrafTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFisNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOnayBekliyor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuOnaylandi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuReddedildi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuOdendi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFisTutar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 492);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(306, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Ekle / Düzenle / Sil";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtFisNo);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dtpFisTarih);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.nudFisTutar);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbMasrafTipi);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtAciklama);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(290, 389);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiş No";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(3, 23);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(284, 26);
            this.txtFisNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih";
            // 
            // dtpFisTarih
            // 
            this.dtpFisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFisTarih.Location = new System.Drawing.Point(3, 75);
            this.dtpFisTarih.Name = "dtpFisTarih";
            this.dtpFisTarih.Size = new System.Drawing.Size(284, 26);
            this.dtpFisTarih.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutar";
            // 
            // nudFisTutar
            // 
            this.nudFisTutar.DecimalPlaces = 2;
            this.nudFisTutar.Location = new System.Drawing.Point(3, 127);
            this.nudFisTutar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudFisTutar.Name = "nudFisTutar";
            this.nudFisTutar.Size = new System.Drawing.Size(284, 26);
            this.nudFisTutar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Masraf Tipi";
            // 
            // cmbMasrafTipi
            // 
            this.cmbMasrafTipi.FormattingEnabled = true;
            this.cmbMasrafTipi.Location = new System.Drawing.Point(3, 179);
            this.cmbMasrafTipi.Name = "cmbMasrafTipi";
            this.cmbMasrafTipi.Size = new System.Drawing.Size(284, 28);
            this.cmbMasrafTipi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(3, 233);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(284, 100);
            this.txtAciklama.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSil);
            this.flowLayoutPanel1.Controls.Add(this.btnKaydet);
            this.flowLayoutPanel1.Controls.Add(this.btnYeniEkle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 416);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(202, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 38);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(111, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 38);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(20, 3);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(85, 38);
            this.btnYeniEkle.TabIndex = 5;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMasraflar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(691, 492);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masraflar";
            // 
            // lvMasraflar
            // 
            this.lvMasraflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSahibi,
            this.clmMasrafTipi,
            this.clmTarih,
            this.clmFisNo,
            this.clmTutar,
            this.clmDurumu});
            this.lvMasraflar.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMasraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMasraflar.FullRowSelect = true;
            this.lvMasraflar.HideSelection = false;
            this.lvMasraflar.Location = new System.Drawing.Point(8, 27);
            this.lvMasraflar.MultiSelect = false;
            this.lvMasraflar.Name = "lvMasraflar";
            this.lvMasraflar.Size = new System.Drawing.Size(675, 457);
            this.lvMasraflar.TabIndex = 0;
            this.lvMasraflar.UseCompatibleStateImageBehavior = false;
            this.lvMasraflar.View = System.Windows.Forms.View.Details;
            this.lvMasraflar.SelectedIndexChanged += new System.EventHandler(this.lvMasraflar_SelectedIndexChanged);
            // 
            // clmSahibi
            // 
            this.clmSahibi.Text = "Sahibi";
            this.clmSahibi.Width = 200;
            // 
            // clmMasrafTipi
            // 
            this.clmMasrafTipi.Text = "Masraf Tipi";
            this.clmMasrafTipi.Width = 140;
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            this.clmTarih.Width = 80;
            // 
            // clmFisNo
            // 
            this.clmFisNo.Text = "Fiş No";
            this.clmFisNo.Width = 80;
            // 
            // clmTutar
            // 
            this.clmTutar.Text = "Tutar";
            this.clmTutar.Width = 80;
            // 
            // clmDurumu
            // 
            this.clmDurumu.Text = "Durumu";
            this.clmDurumu.Width = 90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOnayBekliyor,
            this.cmnuOnaylandi,
            this.cmnuReddedildi,
            this.toolStripMenuItem1,
            this.cmnuOdendi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 171);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmnuOnayBekliyor
            // 
            this.cmnuOnayBekliyor.Name = "cmnuOnayBekliyor";
            this.cmnuOnayBekliyor.Size = new System.Drawing.Size(240, 32);
            this.cmnuOnayBekliyor.Text = "Onay Bekliyor";
            this.cmnuOnayBekliyor.Click += new System.EventHandler(this.cmnuOnayBekliyor_Click);
            // 
            // cmnuOnaylandi
            // 
            this.cmnuOnaylandi.Name = "cmnuOnaylandi";
            this.cmnuOnaylandi.Size = new System.Drawing.Size(240, 32);
            this.cmnuOnaylandi.Text = "Onaylandı";
            this.cmnuOnaylandi.Click += new System.EventHandler(this.cmnuOnaylandi_Click);
            // 
            // cmnuReddedildi
            // 
            this.cmnuReddedildi.Name = "cmnuReddedildi";
            this.cmnuReddedildi.Size = new System.Drawing.Size(240, 32);
            this.cmnuReddedildi.Text = "Reddedildi";
            this.cmnuReddedildi.Click += new System.EventHandler(this.cmnuReddedildi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // cmnuOdendi
            // 
            this.cmnuOdendi.Name = "cmnuOdendi";
            this.cmnuOdendi.Size = new System.Drawing.Size(240, 32);
            this.cmnuOdendi.Text = "Ödendi";
            this.cmnuOdendi.Click += new System.EventHandler(this.cmnuOdendi_Click);
            // 
            // frmMasrafYonetimi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1021, 512);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasrafYonetimi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Masraf Yönetimi";
            this.Load += new System.EventHandler(this.frmMasrafYonetimi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFisTutar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ListView lvMasraflar;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFisTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFisTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMasrafTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ColumnHeader clmSahibi;
        private System.Windows.Forms.ColumnHeader clmMasrafTipi;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmFisNo;
        private System.Windows.Forms.ColumnHeader clmTutar;
        private System.Windows.Forms.ColumnHeader clmDurumu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnayBekliyor;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnaylandi;
        private System.Windows.Forms.ToolStripMenuItem cmnuReddedildi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuOdendi;
    }
}