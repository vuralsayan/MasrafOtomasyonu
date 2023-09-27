using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafOtomasyonu
{
    public static class KullaniciIslemleri
    {
        private static List<Kullanici> _kullanicilar = FileHelper.DosyadanOkuKullanicilar();
        public static string GetirKullaniciTamAdi(Guid kullaniciId)
        {
            foreach (Kullanici kullanici in _kullanicilar)
            {
                if (kullanici.Id == kullaniciId)
                {
                    return kullanici.TamAdi;
                }
            }
            return "-----";
        }

        public static string GetirKullaniciTamAdiVeTipi(Guid kullaniciId)
        {
            foreach (Kullanici kullanici in _kullanicilar)
            {
                if (kullanici.Id == kullaniciId)
                {
                    return $"{kullanici.TamAdi} ({EnumHelper.GetirKullaniciTipiAdi(kullanici.Tipi)})";
                }
            }
            return "-----";
        }
    }


}
