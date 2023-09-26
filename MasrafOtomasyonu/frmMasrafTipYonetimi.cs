using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasrafOtomasyonu
{
    public partial class frmMasrafTipYonetimi : Form
    {
        public frmMasrafTipYonetimi()
        {
            InitializeComponent();
        }

        private List<string> _masrafTipleri = new List<string>();   

        private void frmMasrafTipYonetimi_Load(object sender, EventArgs e)
        {
            _masrafTipleri = FileHelper.DosyadanOkuMasrafTipleri();
            YukleListboxMasrafTipleri(); 
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            string tip = txtMasrafTipi.Text?.Trim();

            if (string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen bir masraf tipi değeri giriniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _masrafTipleri.Add(tip);
            FileHelper.DosyayaYazMasrafTipleri(_masrafTipleri);
            YukleListboxMasrafTipleri();
            txtMasrafTipi.Clear();  

        }

        private void YukleListboxMasrafTipleri()
        {
            lstMasrafTipleri.DataSource = null;
            lstMasrafTipleri.DataSource = _masrafTipleri;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstMasrafTipleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncelleme için bir masraf tipi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string tip = txtMasrafTipi.Text?.Trim();

            if (string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen bir masraf tipi değeri giriniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_masrafTipleri.Contains(tip))
            {
                MessageBox.Show($"{tip} isimli masraf tipi zaten mevcut!", "Tekrar Eden Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _masrafTipleri[lstMasrafTipleri.SelectedIndex] = tip;
            FileHelper.DosyayaYazMasrafTipleri(_masrafTipleri);
            YukleListboxMasrafTipleri();
            txtMasrafTipi.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMasrafTipleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için bir masraf tipi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string tip = _masrafTipleri[lstMasrafTipleri.SelectedIndex];

            DialogResult sonuc = MessageBox.Show($"{tip} isimli masraf tipini silmek istediğinize emin misiniz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (sonuc == DialogResult.Yes)
            {
                _masrafTipleri.RemoveAt(lstMasrafTipleri.SelectedIndex);

                FileHelper.DosyayaYazMasrafTipleri(_masrafTipleri);
                YukleListboxMasrafTipleri();
                txtMasrafTipi.Clear();
            }
        }

        private void lstMasrafTipleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMasrafTipleri.SelectedIndex > -1)
            {
                txtMasrafTipi.Text = _masrafTipleri[lstMasrafTipleri.SelectedIndex];
            }
        }
    }
}
