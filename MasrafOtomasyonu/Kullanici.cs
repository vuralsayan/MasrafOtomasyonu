using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafOtomasyonu
{
    public class Kullanici
    {
        // 72C06D63-D244-4CBC-A2CA-6E53CACD5F5B  -- GUID

        public Guid Id { get; set; }
        public string TamAdi { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public KullaniciTipi Tipi { get; set; } 

        public Guid? YoneticiId { get; set; }
    }

    public enum KullaniciTipi
    {
        admin,
        personel,
        yonetici,
        muhasebeci
    }
}
