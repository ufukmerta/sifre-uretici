using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace WFASifreUretici
{
    internal class Ayarlar : IAyarlar
    {
        private int karakterSayisi;
        public int KarakterSayisi
        {
            get
            {
                return karakterSayisi;
            }
            set
            {
                if (value < 8 || value > 16) hataliAyar = true;
                else karakterSayisi = value;
            }
        }
        private int rakamSayisi;
        public int RakamSayisi
        {
            get
            {
                return rakamSayisi;
            }
            set
            {
                if (value < 4 || value > 8) hataliAyar = true;
                else rakamSayisi = value;
            }
        }
        private int maxAyniKarakterSayisi;
        public int MaxAyniKarakterSayisi
        {
            get
            {
                return maxAyniKarakterSayisi;
            }
            set
            {
                if (value < 0 || value > 2) hataliAyar = true;
                else maxAyniKarakterSayisi = value;
            }
        }
        private bool sifreSonuSayiEkleme;
        public bool SifreSonuSayiEkleme
        {
            get
            {
                return sifreSonuSayiEkleme;
            }
            set
            {
                sifreSonuSayiEkleme = value;
            }
        }
        private bool agresifMod;
        public bool AgresifMod
        {
            get
            {
                return agresifMod;
            }
            set
            {
                agresifMod = value;
            }
        }
        private bool hataliAyar = false;
        private string dosyaKonumu = ConfigurationManager.AppSettings["ayarlarKonum"];

        internal Ayarlar()
        {
            AyarlariGetir();
        }
        public void AyarlariGetir()
        {
            try
            {
                if (File.Exists(dosyaKonumu))
                {
                    using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            try
                            {
                                karakterSayisi = Convert.ToInt32(sr.ReadLine());
                                rakamSayisi = Convert.ToInt32(sr.ReadLine());
                                maxAyniKarakterSayisi = Convert.ToInt32(sr.ReadLine());
                                string metin = sr.ReadLine();
                                SifreSonuSayiEkleme = (metin != null) ? Convert.ToBoolean(metin) : hataliAyar = true;
                                metin = sr.ReadLine();
                                AgresifMod = (metin != null) ? Convert.ToBoolean(metin) : hataliAyar = true;
                                sr.Close();

                            }
                            catch (Exception ex)
                            {
                                sr.Close();
                                fs.Close();
                                MessageBox.Show("Ayarlar okunurken sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır. Hata detayı: " + ex.Message, "Veri Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                VarsayilanAyarlaraDon();
                            }
                        }
                        fs.Close();
                        if (hataliAyar) VarsayilanAyarlaraDon();
                    }
                }
                else
                {
                    VarsayilanAyarlaraDon();
                    Kaydet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar okunurken bir sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır. Hata detayı: " + ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VarsayilanAyarlaraDon();
                Kaydet();
            }
        }

        public bool Kaydet()
        {
            try
            {
                using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(karakterSayisi + "\n" + rakamSayisi + "\n" + maxAyniKarakterSayisi + "\n" + sifreSonuSayiEkleme + "\n" + agresifMod);
                        sw.Flush();
                        sw.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResultKaydet = new DialogResult();
                dialogResultKaydet = MessageBox.Show("Ayarlar kaydedilirken bir sorun oluştu. Hata detayı:  " + ex.Message + "Varsayılan ayarları kullanmak için Evet'i, " +
                    "değişiklikleri geri almak için Hayır'ı seçiniz.", "Hata Oluştu", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResultKaydet == DialogResult.Yes) VarsayilanAyarlaraDon();
                else
                {
                    AyarlariGetir();
                    return false;
                }
            }
            return true;
        }

        public void VarsayilanAyarlaraDon()
        {
            using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("10\n4\n1\nfalse\nfalse");
                    sw.Flush();
                    sw.Close();
                }
                fs.Close();
            }
            AyarlariGetir();
        }
    }
}
