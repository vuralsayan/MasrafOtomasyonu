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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kAdi))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Şifre boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Kullanici> kullanicilar = FileHelper.DosyadanOkuKullanicilar();

            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == kAdi && kullanici.Sifre ==sifre)
                {
                    Degiskenler.GirisYapanKullanici = kullanici;
                    break;
                }

            }

            if (Degiskenler.GirisYapanKullanici != null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
