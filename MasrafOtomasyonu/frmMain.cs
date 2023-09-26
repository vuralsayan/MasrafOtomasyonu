using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasrafOtomasyonu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            frmKullaniciYonetimi frm = new frmKullaniciYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AdminKullaniciEkle();

            GosterGirisFormu();
        }

        private void AdminKullaniciEkle()
        {
            string adminKullaniciAdi = ConfigurationManager.AppSettings["AdminKullaniciAdi"];
            string adminSifre = ConfigurationManager.AppSettings["AdminSifre"];
            bool adminVarMi = false;

            List<Kullanici> kullanicilar = FileHelper.DosyadanOkuKullanicilar();
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == adminKullaniciAdi)        // admin varsa çık
                {
                    adminVarMi = true;
                    break;
                }
            }

            if (adminVarMi == false)                // admin yoksa oluştur
            {
                kullanicilar.Add(new Kullanici
                {
                    Id = Guid.NewGuid(),
                    KullaniciAdi = adminKullaniciAdi,
                    Sifre = adminSifre,
                    TamAdi = "Admin",
                    Tipi = KullaniciTipi.admin
                });

                FileHelper.DosyayaYazKullanicilar(kullanicilar);
            }

        }

        private void GosterGirisFormu()
        {
            frmGiris frm = new frmGiris();
            frm.MdiParent = this;
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Degiskenler.GirisYapanKullanici != null)
            {
                menuStrip1.Visible = true;
                lblGirisYapan.Text = $"{Degiskenler.GirisYapanKullanici.TamAdi} ({EnumHelper.GetirKullaniciTipiAdi(Degiskenler.GirisYapanKullanici.Tipi)})";

                mnuYonetim.Visible = false;
                mnuMasrafYonetimi.Visible = false;
                mnuRaporlar.Visible = false;

                switch (Degiskenler.GirisYapanKullanici.Tipi)
                {
                    case KullaniciTipi.admin:
                        mnuYonetim.Visible = true;
                        break;
                    case KullaniciTipi.personel:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    case KullaniciTipi.yonetici:
                        mnuMasrafYonetimi.Visible = true;
                        mnuRaporlar.Visible = true;
                        break;
                    case KullaniciTipi.muhasebeci:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulamadan Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuOturumKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (sonuc == DialogResult.Yes)
            {
                Degiskenler.GirisYapanKullanici = null;
                lblGirisYapan.Text = "---";


                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
                menuStrip1.Visible = false;
                GosterGirisFormu();

            }
        }

        private void mnuUygulamaHakkinda_Click(object sender, EventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMasrafHarcamaTipleri_Click(object sender, EventArgs e)
        {
            frmMasrafTipYonetimi frm = new frmMasrafTipYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
