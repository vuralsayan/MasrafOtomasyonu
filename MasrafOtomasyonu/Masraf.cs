using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MasrafOtomasyonu
{
    public class Masraf
    {
        public Guid Id { get; set; }
        public string MasrafTipi { get; set; }
        public string Aciklama { get; set; }

        public Fis FisBilgisi { get; set; }
        public MasrafDurumu Durum { get; set; }

        public Guid KullaniciId { get; set; }
    }

    public enum MasrafDurumu
    {
        OnayBekliyor,
        Onaylandı,
        Reddedildi,
        Ödendi
    }

    public class Fis
    {
        public string No { get; set; }

        public DateTime Tarih { get; set; }

        public decimal Tutar { get; set; }
    }
}
