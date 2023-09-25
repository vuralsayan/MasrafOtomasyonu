using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafOtomasyonu
{
    public static class EnumHelper
    {
        public static string GetirKullaniciTipiAdi(KullaniciTipi kullaniciTipi)
        {
            string sonuc = string.Empty;

            switch (kullaniciTipi)
            {
                case KullaniciTipi.admin:
                    sonuc = "Sistem Yöneticisi";
                    break;
                case KullaniciTipi.personel:
                    sonuc = "Personel";
                    break;
                case KullaniciTipi.yonetici:
                    sonuc = "Yönetici";
                    break;
                case KullaniciTipi.muhasebeci:
                    sonuc = "Muhasebeci";
                    break;
                default:
                    break;
            }


            return sonuc;

        }

        public static List<KullaniciTipiEnumObjesi> GetirKullaniciTipleriListe()
        {
            List<KullaniciTipiEnumObjesi> liste = new List<KullaniciTipiEnumObjesi>();
            liste.Add(new KullaniciTipiEnumObjesi
            {
                KullaniciTipAdi = GetirKullaniciTipiAdi(KullaniciTipi.admin),
                KullaniciTipiDegeri = (int)KullaniciTipi.admin
            });
            liste.Add(new KullaniciTipiEnumObjesi
            {
                KullaniciTipAdi = GetirKullaniciTipiAdi(KullaniciTipi.yonetici),
                KullaniciTipiDegeri = (int)KullaniciTipi.yonetici
            });
            liste.Add(new KullaniciTipiEnumObjesi
            {
                KullaniciTipAdi = GetirKullaniciTipiAdi(KullaniciTipi.personel),
                KullaniciTipiDegeri = (int)KullaniciTipi.personel
            });
            liste.Add(new KullaniciTipiEnumObjesi
            {
                KullaniciTipAdi = GetirKullaniciTipiAdi(KullaniciTipi.muhasebeci),
                KullaniciTipiDegeri = (int)KullaniciTipi.muhasebeci 
            });

            return liste;
        }


    }

    public class KullaniciTipiEnumObjesi
    {
        public int KullaniciTipiDegeri { get; set; }
        public string KullaniciTipAdi { get; set; }
    }
}
