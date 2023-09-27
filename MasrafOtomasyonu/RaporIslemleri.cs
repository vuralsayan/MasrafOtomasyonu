using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafOtomasyonu
{
    public class RaporIslemleri
    {
        public static List<PersonelToplamHarcama> PersonelToplamHarcamaRaporu()
        {
            List<Masraf> masraflar = FileHelper.DosyadanOkuMasraflar();
            List<Kullanici> kullanicilar = FileHelper.DosyadanOkuKullanicilar();
            List<PersonelToplamHarcama> personelToplamHarcamalari = new List<PersonelToplamHarcama>();

            foreach (Masraf masraf in masraflar)
            {
                bool eklendiMi = false;

                foreach (PersonelToplamHarcama pth in personelToplamHarcamalari)
                {
                    if (pth.PersonelId == masraf.KullaniciId)
                    {
                        pth.ToplamTutar += masraf.FisBilgisi.Tutar;
                        eklendiMi = true;
                        break;
                    }
                }

                if (eklendiMi == false)
                {
                    personelToplamHarcamalari.Add(new PersonelToplamHarcama
                    {
                        PersonelId = masraf.KullaniciId,
                        ToplamTutar = masraf.FisBilgisi.Tutar,
                        Personel = KullaniciIslemleri.GetirKullaniciTamAdi(masraf.KullaniciId)
                    });
                }

            }

            return personelToplamHarcamalari;
        }

        public static List<MasrafTipiToplamHarcama> MasrafTipiToplamHarcamaRaporu()
        {
            List<Masraf> masraflar = FileHelper.DosyadanOkuMasraflar();
            List<MasrafTipiToplamHarcama> data = new List<MasrafTipiToplamHarcama>();

            foreach (Masraf masraf in masraflar)
            {
                bool eklendiMi = false;

                foreach (MasrafTipiToplamHarcama m in data)
                {
                    if (m.MasrafTipi == masraf.MasrafTipi)
                    {
                        m.ToplamTutar += masraf.FisBilgisi.Tutar;
                        eklendiMi = true;
                        break;
                    }
                }

                if (eklendiMi == false)
                {
                    data.Add(new MasrafTipiToplamHarcama
                    {
                        MasrafTipi = masraf.MasrafTipi,
                        ToplamTutar = masraf.FisBilgisi.Tutar
                    });
                }

            }

            return data;
        }

    }

    public class PersonelToplamHarcama
    {
        public Guid PersonelId { get; set; }
        public string Personel { get; set; }
        public decimal ToplamTutar { get; set; }
    }

    public class MasrafTipiToplamHarcama
    {
        public string MasrafTipi { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
