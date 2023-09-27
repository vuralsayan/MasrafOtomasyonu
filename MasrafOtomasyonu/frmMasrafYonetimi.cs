using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MasrafOtomasyonu
{
    public partial class frmMasrafYonetimi : Form
    {
        public frmMasrafYonetimi()
        {
            InitializeComponent();
        }

        List<Masraf> _masraflar = new List<Masraf>();
        List<Kullanici> _kullanicilar = new List<Kullanici>();
        List<string> _masrafTipleri = new List<string>();

        private void frmMasrafYonetimi_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde masrafları JSON dosyasından çekip listele
            YukleKullanicilar();
            YukleMasraflar();
            YukleMasrafTipleri();
        }

        private void YukleKullanicilar()
        {
            _kullanicilar = FileHelper.DosyadanOkuKullanicilar();
        }

        //private void YukleMasraflarListesi(List<Masraf> masraflar)
        //{
        //    // Listview'i temizle
        //    lvMasraflar.Items.Clear();

        //    // Masrafları listview'e ekle
        //    foreach (Masraf masraf in masraflar)
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Text = KullaniciIslemleri.GetirKullaniciTamAdiVeTipi(masraf.KullaniciId);
        //        item.SubItems.Add(masraf.MasrafTipi);
        //        item.SubItems.Add(masraf.FisBilgisi.Tarih.ToShortDateString());
        //        item.SubItems.Add(masraf.FisBilgisi.No);
        //        item.SubItems.Add(masraf.FisBilgisi.Tutar.ToString());
        //        item.SubItems.Add(masraf.Durum.ToString());
        //        item.Tag = masraf;
        //        lvMasraflar.Items.Add(item);
        //    }
        //}

        private void YukleMasraflar()
        {
            _masraflar = FileHelper.DosyadanOkuMasraflar();

            lvMasraflar.Items.Clear();

            switch (Degiskenler.GirisYapanKullanici.Tipi)
            {
                case KullaniciTipi.personel:
                    foreach (Masraf masraf in _masraflar)
                    {
                        if (masraf.KullaniciId == Degiskenler.GirisYapanKullanici.Id)
                        {
                            EkleMasrafListView(masraf);
                        }
                    }

                    break;
                case KullaniciTipi.yonetici:
                    List<Guid> masrafSahipleriIdleri = new List<Guid>();
                    masrafSahipleriIdleri.Add(Degiskenler.GirisYapanKullanici.Id);

                    foreach (Kullanici kullanici in _kullanicilar)
                    {
                        if (kullanici.YoneticiId == Degiskenler.GirisYapanKullanici.Id)
                        {
                            masrafSahipleriIdleri.Add(kullanici.Id);
                        }
                    }

                    foreach (Masraf masraf in _masraflar)
                    {
                        if (masrafSahipleriIdleri.Contains(masraf.KullaniciId))
                        {
                            EkleMasrafListView(masraf);
                        }
                    }


                    break;
                case KullaniciTipi.muhasebeci:
                    foreach (Masraf masraf in _masraflar)
                    {
                        if (masraf.Durum == MasrafDurumu.Onaylandı)
                        {
                            EkleMasrafListView(masraf);
                        }
                    }
                    break;
                case KullaniciTipi.admin:
                default:
                    break;
            }
        }

        private void EkleMasrafListView(Masraf masraf)
        {
            ListViewItem item = new ListViewItem();
            item.Text = KullaniciIslemleri.GetirKullaniciTamAdiVeTipi(masraf.KullaniciId);
            item.SubItems.Add(masraf.MasrafTipi);
            item.SubItems.Add(masraf.FisBilgisi.Tarih.ToShortDateString());
            item.SubItems.Add(masraf.FisBilgisi.No);
            item.SubItems.Add(masraf.FisBilgisi.Tutar.ToString());
            item.SubItems.Add(EnumHelper.GetirMasrafDurumAdi(masraf.Durum));
            item.Tag = masraf;

            lvMasraflar.Items.Add(item);
        }

        private void YukleMasrafTipleri()
        {
            // Masraf tiplerini yükle
            _masrafTipleri = FileHelper.DosyadanOkuMasrafTipleri();

            cmbMasrafTipi.DataSource = null;
            cmbMasrafTipi.DataSource = _masrafTipleri;
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            // Yeni masraf ekleme işlemi
            string fisNo = txtFisNo.Text;
            string aciklama = txtAciklama.Text;
            DateTime tarih = dtpFisTarih.Value.Date;
            decimal tutar = nudFisTutar.Value;
            string masrafTipi = cmbMasrafTipi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fisNo) || string.IsNullOrEmpty(masrafTipi))
            {
                MessageBox.Show("Fis No ve Masraf Tipi boş bırakılamaz.");
                return;
            }

            Fis fis = new Fis
            {
                No = fisNo,
                Tarih = tarih,
                Tutar = tutar
            };

            MasrafDurumu durum = (Degiskenler.GirisYapanKullanici.YoneticiId == null) ? MasrafDurumu.Onaylandı : MasrafDurumu.OnayBekliyor;

            Masraf masraf = new Masraf
            {
                Id = Guid.NewGuid(),
                FisBilgisi = fis,
                Aciklama = aciklama,
                MasrafTipi = masrafTipi,
                Durum = durum,
                KullaniciId = Degiskenler.GirisYapanKullanici.Id
            };

            _masraflar.Add(masraf);
            FileHelper.DosyayaYazMasraflar(_masraflar);

            // Yeni masrafı listeye ekleyin
            ListViewItem item = new ListViewItem();
            item.Text = KullaniciIslemleri.GetirKullaniciTamAdiVeTipi(masraf.KullaniciId);
            item.SubItems.Add(masraf.MasrafTipi);
            item.SubItems.Add(masraf.FisBilgisi.Tarih.ToShortDateString());
            item.SubItems.Add(masraf.FisBilgisi.No);
            item.SubItems.Add(masraf.FisBilgisi.Tutar.ToString());
            item.SubItems.Add(masraf.Durum.ToString());
            item.Tag = masraf;
            lvMasraflar.Items.Add(item);

            // Alanları temizle
            txtFisNo.Clear();
            txtAciklama.Clear();
            cmbMasrafTipi.SelectedIndex = -1;
            nudFisTutar.Value = 0;
        }

        private void lvMasraflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKaydet.Visible = true;
            btnSil.Visible = true;

            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                int index = lvMasraflar.SelectedIndices[0];
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];
                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    txtFisNo.Text = masraf.FisBilgisi.No;
                    txtAciklama.Text = masraf.Aciklama;
                    dtpFisTarih.Value = masraf.FisBilgisi.Tarih;
                    nudFisTutar.Value = masraf.FisBilgisi.Tutar;
                    cmbMasrafTipi.SelectedItem = masraf.MasrafTipi;

                    if (masraf.KullaniciId != Degiskenler.GirisYapanKullanici.Id)
                    {
                        btnKaydet.Visible = false;
                        btnSil.Visible = false;
                    }
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                int index = lvMasraflar.SelectedIndices[0];
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];
                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    //if (masraf.KullaniciId != Degiskenler.GirisYapanKullanici.Id)
                    //{
                    //    MessageBox.Show("Sadece kendinize ait masrafları düzenleyebilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    return;
                    //}

                    if (masraf.Durum == MasrafDurumu.OnayBekliyor || (Degiskenler.GirisYapanKullanici.YoneticiId == null && masraf.Durum == MasrafDurumu.Onaylandı))
                    {

                        string fisNo = txtFisNo.Text;
                        string aciklama = txtAciklama.Text;
                        DateTime tarih = dtpFisTarih.Value.Date;
                        decimal tutar = nudFisTutar.Value;
                        string masrafTipi = cmbMasrafTipi.SelectedItem?.ToString();

                        masraf.FisBilgisi.No = fisNo;
                        masraf.FisBilgisi.Tarih = tarih;
                        masraf.FisBilgisi.Tutar = tutar;
                        masraf.Aciklama = aciklama;
                        masraf.MasrafTipi = masrafTipi;

                        FileHelper.DosyayaYazMasraflar(_masraflar);
                        YukleMasraflar();
                    }
                    else
                    {
                        MessageBox.Show("Masraf durumu güncellemeye uygun değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }


                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                int index = lvMasraflar.SelectedIndices[0];
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];
                Masraf masraf = listViewItem.Tag as Masraf;

                if (masraf != null)
                {
                    DialogResult sonuc = MessageBox.Show($"{masraf.FisBilgisi.No} fiş numaralı masrafı silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                    if (sonuc == DialogResult.Yes)
                    {
                        _masraflar.Remove(masraf);
                        FileHelper.DosyayaYazMasraflar(_masraflar);
                        YukleMasraflar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir masraf seçiniz", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            cmnuOnayBekliyor.Enabled = false;
            cmnuOnaylandi.Enabled = false;
            cmnuReddedildi.Enabled = false;
            cmnuOdendi.Enabled = false;

            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                switch (Degiskenler.GirisYapanKullanici.Tipi)
                {
                    case KullaniciTipi.yonetici:
                        cmnuOnayBekliyor.Enabled = true;
                        cmnuOnaylandi.Enabled = true;
                        cmnuReddedildi.Enabled = true;
                        break;
                    case KullaniciTipi.muhasebeci:
                        cmnuOdendi.Enabled = true;
                        break;
                    case KullaniciTipi.personel:
                    case KullaniciTipi.admin:
                    default:
                        break;
                }

                int index = lvMasraflar.SelectedIndices[0];
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];
                Masraf masraf = listViewItem.Tag as Masraf;

                switch (masraf.Durum)
                {
                    case MasrafDurumu.OnayBekliyor:
                        cmnuOnayBekliyor.Enabled = false;
                        break;
                    case MasrafDurumu.Onaylandı:
                        cmnuOnaylandi.Enabled = false;
                        break;
                    case MasrafDurumu.Reddedildi:
                        cmnuReddedildi.Enabled = false;
                        break;
                    case MasrafDurumu.Ödendi:
                        cmnuOdendi.Enabled = false;
                        cmnuOnayBekliyor.Enabled = false;
                        cmnuOnaylandi.Enabled = false;
                        cmnuReddedildi.Enabled = false;
                        break;
                    default:
                        break;
                }

            }




        }

        private void cmnuOnayBekliyor_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Masraf masraf = lvMasraflar.SelectedItems[0].Tag as Masraf;
                masraf.Durum = MasrafDurumu.OnayBekliyor;
                FileHelper.DosyayaYazMasraflar(_masraflar);
                YukleMasraflar();
            }
        }

        private void cmnuOnaylandi_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Masraf masraf = lvMasraflar.SelectedItems[0].Tag as Masraf;
                masraf.Durum = MasrafDurumu.Onaylandı;
                FileHelper.DosyayaYazMasraflar(_masraflar);
                YukleMasraflar();
            }
        }

        private void cmnuReddedildi_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Masraf masraf = lvMasraflar.SelectedItems[0].Tag as Masraf;
                masraf.Durum = MasrafDurumu.Reddedildi;
                FileHelper.DosyayaYazMasraflar(_masraflar);
                YukleMasraflar();
            }
        }

        private void cmnuOdendi_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Masraf masraf = lvMasraflar.SelectedItems[0].Tag as Masraf;

                DialogResult sonuc = MessageBox.Show($"{masraf.FisBilgisi.No} fiş numaralı masrafı ödendi yapmak üzeresiniz, onaylıyor musunuz?", "Ödeme Onay İşlemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (sonuc == DialogResult.Yes)
                {
                    masraf.Durum = MasrafDurumu.Ödendi;

                    FileHelper.DosyayaYazMasraflar(_masraflar);
                    YukleMasraflar();
                }
            }
        }
    }
}
