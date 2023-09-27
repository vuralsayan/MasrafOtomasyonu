namespace MasrafOtomasyonu
{
    partial class frmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExcelAktarim = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSatirSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcelAktarim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExcelAktarim
            // 
            this.btnExcelAktarim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcelAktarim.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktarim.Image")));
            this.btnExcelAktarim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcelAktarim.Name = "btnExcelAktarim";
            this.btnExcelAktarim.Size = new System.Drawing.Size(52, 52);
            this.btnExcelAktarim.Text = "Excel Aktarım";
            this.btnExcelAktarim.Click += new System.EventHandler(this.btnExcelAktarim_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSatirSayisi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSatirSayisi
            // 
            this.lblSatirSayisi.Name = "lblSatirSayisi";
            this.lblSatirSayisi.Size = new System.Drawing.Size(69, 25);
            this.lblSatirSayisi.Text = "Adet: 0";
            // 
            // dgvRapor
            // 
            this.dgvRapor.AllowUserToAddRows = false;
            this.dgvRapor.AllowUserToDeleteRows = false;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapor.Location = new System.Drawing.Point(0, 57);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.ReadOnly = true;
            this.dgvRapor.RowHeadersWidth = 62;
            this.dgvRapor.RowTemplate.Height = 28;
            this.dgvRapor.Size = new System.Drawing.Size(800, 361);
            this.dgvRapor.TabIndex = 2;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rapor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExcelAktarim;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblSatirSayisi;
        public System.Windows.Forms.DataGridView dgvRapor;
    }
}