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

            YukleKullaniciTipleri();

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

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Id = Guid.NewGuid();
            kullanici.TamAdi = txtAdSoyad.Text.Trim();
            kullanici.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            kullanici.Sifre = txtSifre.Text;
            kullanici.Tipi = (KullaniciTipi)cmbKullaniciTipi.SelectedIndex;
            kullanici.YoneticiId = null;

            _kullanicilar.Add(kullanici);

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = _kullanicilar;

            FileHelper.DosyayaYazKullanicilar(_kullanicilar);
        }
    }

    
}
