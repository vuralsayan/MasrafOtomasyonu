using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MasrafOtomasyonu
{
    public static class FileHelper
    {
        private static string _kullanicilarDosyaYolu = Application.StartupPath + "\\kullanicilar.json";
        private static string _masrafTipleriDosyaYolu = Application.StartupPath + "\\masraf_tipleri.json";
        public static void DosyayaYazKullanicilar(List<Kullanici> kullanicilar)
        {
            string json = JsonSerializer.Serialize<List<Kullanici>>(kullanicilar, GetirJsonDosyaAyarlari());
            File.WriteAllText(_kullanicilarDosyaYolu, json);
        }

        public static List<Kullanici> DosyadanOkuKullanicilar()
        {
            if (File.Exists(_kullanicilarDosyaYolu))
            {
                string json = File.ReadAllText(_kullanicilarDosyaYolu);
                return JsonSerializer.Deserialize<List<Kullanici>>(json, GetirJsonDosyaAyarlari());
            }

            return new List<Kullanici>();
        }

        public static void DosyayaYazMasrafTipleri(List<string> masrafTipleri)
        {
            string json = JsonSerializer.Serialize<List<string>>(masrafTipleri, GetirJsonDosyaAyarlari());
            File.WriteAllText(_masrafTipleriDosyaYolu, json);
        }

        public static List<string> DosyadanOkuMasrafTipleri()
        {
            if (File.Exists(_masrafTipleriDosyaYolu))
            {
                string json = File.ReadAllText(_masrafTipleriDosyaYolu);
                return JsonSerializer.Deserialize<List<string>>(json, GetirJsonDosyaAyarlari());
            }

            return new List<string>();
        }



        private static JsonSerializerOptions GetirJsonDosyaAyarlari()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            return options;
        }
    }
}
