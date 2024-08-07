using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Security;

namespace WFASifreUretici
{
    internal class SifreUretici : ISifreUretici
    {
        public string Sifre { get; set; }
        public Ayarlar Ayarlar { get; set; }

        internal SifreUretici(Ayarlar ayarlar)
        {
            this.Ayarlar = ayarlar;
        }
        List<string> kacinilacakKarakterListesi = new List<string>();

        public string Uret(string kacinilacakKarakterler, bool ozelKarakter)
        {
            kacinilacakKarakterListesi.Clear();
            char[] charArr = kacinilacakKarakterler.ToCharArray();            
            foreach (char ch in charArr) kacinilacakKarakterListesi.Add(ch.ToString());
            do
            {
                Sifre = "";
                Sifre += Membership.GeneratePassword(128, 25);
                Sifre = IstenmeyenKarakterleriSil(Sifre, ozelKarakter);
            } while (Sifre.Length < Ayarlar.KarakterSayisi);
            Sifre = AyniKarakterleriKontrolEt(Sifre);
            if (Sifre.Length < Ayarlar.KarakterSayisi)
            {
                return Uret(kacinilacakKarakterler, ozelKarakter);
            }

            if (!Ayarlar.SifreSonuSayiEkleme)
            {
                Sifre += "-";
                string sayi = "";
                do
                {
                    sayi += Membership.GeneratePassword(128, 25);
                    sayi = Regex.Replace(sayi, "[^0-9]", "");
                } while (sayi.Length < Ayarlar.RakamSayisi);
                Sifre += sayi.Substring(0, Ayarlar.RakamSayisi);
            }
            return Sifre;
        }
        private string IstenmeyenKarakterleriSil(string sifre, bool ozelKarakterYok)
        {
            bool ozelKarakterIceriyorMu = false;
            string[] ozelKarakterler = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "\\", ":", ";", "<", ">", "/", "?", "." };
            string[] benzerKarakterler = new string[] { "(", ")", "0", "O", "o", "1", "i", "I", "l", "|", "!", ":", ";" };
            foreach (string c in benzerKarakterler)
                sifre = sifre.Replace(c, string.Empty);

            if (ozelKarakterYok)
            {
                foreach (string r in ozelKarakterler)
                    sifre = sifre.Replace(r, string.Empty);
            }
            if (!ozelKarakterYok)
            {
                if (kacinilacakKarakterListesi.Count > 0)
                {
                    kacinilacakKarakterListesi.ForEach(c =>
                    {
                        sifre = sifre.Replace(c.ToLower(), string.Empty);
                        sifre = sifre.Replace(c.ToUpper(), string.Empty);
                    });                    
                }
                if (Ayarlar.AgresifMod)
                {
                    foreach (var ch in ozelKarakterler)
                    {
                        if (sifre.Substring(0, Ayarlar.KarakterSayisi).Contains(ch))
                        {
                            ozelKarakterIceriyorMu = true;
                            break;
                        }
                    }
                    if (!ozelKarakterIceriyorMu)
                    {
                        sifre = "";
                    }
                }
            }
            return sifre;
        }
        private string AyniKarakterleriKontrolEt(string sifre)
        {
            bool sifreDegistiMi = false;
            string geciciSifre = sifre.Substring(0, Ayarlar.KarakterSayisi);
            foreach (char c in geciciSifre)
            {
                if (Ayarlar.MaxAyniKarakterSayisi + 1 < geciciSifre.Split(c).Length - 1)
                {
                    geciciSifre = geciciSifre.Remove(geciciSifre.LastIndexOf(c), 1);
                    sifreDegistiMi = true;
                }
            }
            if (!sifreDegistiMi)
            { return geciciSifre; }
            geciciSifre += sifre.Substring(Ayarlar.KarakterSayisi);
            return AyniKarakterleriKontrolEt(geciciSifre);
        }
    }
}