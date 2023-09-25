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
    public partial class frmKullaniciYonetimi : Form
    {
        List<Kullanici> _kullanicilar = new List<Kullanici>();
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {
            YukleKullanicilari();
            YukleYoneticileri();
            YukleKullaniciTipleri();

        }

        private void YukleYoneticileri()
        {
            cmbYonetici.DisplayMember = "TamAdi";
            cmbYonetici.ValueMember = "Id";
            cmbYonetici.DataSource = null;
            cmbYonetici.DataSource = GetirYoneticiler();
        }

        private void YukleKullaniciTipleri()
        {
            List<KullaniciTipiEnumObjesi> kullaniciTipiListesi = EnumHelper.GetirKullaniciTipleriListe();

            //cmbKullaniciTipi.DisplayMember = "KullaniciTipAdi";
            //cmbKullaniciTipi.ValueMember = "KullaniciTipiDegeri";
            cmbKullaniciTipi.DataSource = null;
            cmbKullaniciTipi.DataSource = kullaniciTipiListesi;
        }

        private void YukleKullanicilari()
        {
            _kullanicilar = FileHelper.DosyadanOkuKullanicilar();
            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = _kullanicilar;
        }

        private List<Kullanici> GetirYoneticiler()
        {
            List<Kullanici> liste = new List<Kullanici>();

            foreach (Kullanici kullanici in _kullanicilar)
            {
                if (kullanici.Tipi == KullaniciTipi.yonetici)
                {
                    liste.Add(kullanici);
                }
            }


            return liste;
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Id = Guid.NewGuid();
            kullanici.TamAdi = txtAdSoyad.Text.Trim();
            kullanici.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            kullanici.Sifre = txtSifre.Text;
            kullanici.Tipi = (KullaniciTipi)cmbKullaniciTipi.SelectedValue;
            kullanici.YoneticiId = (Guid)cmbYonetici.SelectedValue;

            _kullanicilar.Add(kullanici);

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = _kullanicilar;

            FileHelper.DosyayaYazKullanicilar(_kullanicilar);
            Temizle();
        }

        private void Temizle()
        {
            txtAdSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            cmbKullaniciTipi.SelectedIndex = -1;
            cmbYonetici.SelectedIndex = -1;

            lblTamAd.Text = "Ad Soyad: ---";
            lblKullaniciAdi.Text = "Kullanıcı Adı: ---";
            lblSifre.Text = "Şifre: ---";
            lblKullaniciTipi.Text = "Tipi: ---";
            lblYoneticiAdi.Text = "Yönetici: ---";
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1)
            {
                Temizle();
                return;
            }

            Kullanici seciliKullanici = lstKullanicilar.SelectedItem as Kullanici;
            YukleKullaniciVerisi(seciliKullanici);

        }

        private void YukleKullaniciVerisi(Kullanici seciliKullanici)
        {
            Temizle();
            lblTamAd.Text = "Ad Soyad: " + seciliKullanici.TamAdi;
            lblKullaniciAdi.Text = "Kullanıcı Adı: " + seciliKullanici.KullaniciAdi;
            lblSifre.Text = "Şifre: " + seciliKullanici.Sifre;
            lblKullaniciTipi.Text = "Tipi: " + EnumHelper.GetirKullaniciTipiAdi(seciliKullanici.Tipi);
            lblYoneticiAdi.Text = "Yönetici: " + GetirKullaniciAdi(seciliKullanici.YoneticiId);

            txtAdSoyad.Text = seciliKullanici.TamAdi;
            txtKullaniciAdi.Text = seciliKullanici.KullaniciAdi;
            txtSifre.Text = seciliKullanici.Sifre;
            cmbKullaniciTipi.SelectedValue = (int)seciliKullanici.Tipi;

            if (seciliKullanici.YoneticiId != null)
            {
                cmbYonetici.SelectedValue = seciliKullanici.YoneticiId;
            }
        }

        private string GetirKullaniciAdi(Guid? kullaniciId)
        {
            string adi = "";

            if (kullaniciId != null)
            {
                foreach (Kullanici kullanici in _kullanicilar)
                {
                    if (kullanici.Id == kullaniciId)
                    {
                        adi = kullanici.TamAdi;
                        break;
                    }
                }
            }

            return adi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1)
            {
                Temizle();
                return;
            }

            Kullanici seciliKullanici = lstKullanicilar.SelectedItem as Kullanici;
            seciliKullanici.TamAdi = txtAdSoyad.Text.Trim();
            seciliKullanici.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            seciliKullanici.Sifre = txtSifre.Text;
            seciliKullanici.Tipi = (KullaniciTipi)cmbKullaniciTipi.SelectedValue;
            seciliKullanici.YoneticiId = (Guid)cmbYonetici.SelectedValue;

            lstKullanicilar.DataSource = null;  
            lstKullanicilar.DataSource = _kullanicilar;

            FileHelper.DosyayaYazKullanicilar(_kullanicilar);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1)
            {
                Temizle();
                return;
            }


            Kullanici seciliKullanici = lstKullanicilar.SelectedItem as Kullanici;
            DialogResult result = MessageBox.Show($"{seciliKullanici.TamAdi} adlı kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                if (seciliKullanici.Tipi == KullaniciTipi.yonetici)
                {
                    foreach (Kullanici kullanici in _kullanicilar)
                    {
                        if (kullanici.YoneticiId == seciliKullanici.Id)
                        {
                            kullanici.YoneticiId = null;
                        }
                    }
                }



                _kullanicilar.Remove(seciliKullanici);

                lstKullanicilar.DataSource = null;
                lstKullanicilar.DataSource = _kullanicilar;

                FileHelper.DosyayaYazKullanicilar(_kullanicilar);
            }
        }
    }


}
