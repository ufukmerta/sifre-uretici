
namespace WFASifreUretici
{
    internal interface IAyarlar
    {        
        int KarakterSayisi { get; set; }
        int RakamSayisi { get; set; }
        int MaxAyniKarakterSayisi { get; set; }
        bool SifreSonuSayiEkleme { get; set; }
        bool AgresifMod { get; set; }        
        void AyarlariGetir();
        bool Kaydet();
        void VarsayilanAyarlaraDon();

    }
}
