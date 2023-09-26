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
    }
}
