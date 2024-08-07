
namespace WFASifreUretici
{
    internal interface ISifreUretici
    {
        string Sifre { get; set; }
        Ayarlar Ayarlar { get; set; }
        string Uret(string kacinilacakKarakterler, bool ozelKarakter);
    }
}
