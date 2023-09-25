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
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {
            List<KullaniciTipiEnumObjesi> kullaniciTipiListesi = EnumHelper.GetirKullaniciTipleriListe();

            //cmbKullaniciTipi.DisplayMember = "KullaniciTipAdi";
            //cmbKullaniciTipi.ValueMember = "KullaniciTipiDegeri";
            cmbKullaniciTipi.DataSource = null;
            cmbKullaniciTipi.DataSource = kullaniciTipiListesi;

        }
    }

    
}
