using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Security;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }
        internal bool altForm = false;

        private void FormAna_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Concat(this.Text, version.Major, ".", version.Minor, ".", version.Build);
            AyarlariGetir();
            if (!altForm) SifreUret();
        }

        int karakterSayisi = 10, rakamSayisi = 4, maxAyniKarakterSayisi = 1;
        bool sifreSonuSayiEkleme = false, agresifMod, agresifModIlkDurum;
        void AyarlariGetir()
        {
            try
            {
                string dosyaKonumu = Path.Combine(Application.StartupPath, "ayar.ini");
                if (File.Exists(dosyaKonumu))
                {
                    using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            karakterSayisi = Convert.ToInt32(sr.ReadLine());
                            rakamSayisi = Convert.ToInt32(sr.ReadLine());
                            maxAyniKarakterSayisi = Convert.ToInt32(sr.ReadLine());
                            string metin = sr.ReadLine();
                            string metin2 = sr.ReadLine();
                            if (metin != null && metin2 != null)
                            {
                                sifreSonuSayiEkleme = Convert.ToBoolean(metin);
                                agresifModIlkDurum = agresifMod = Convert.ToBoolean(metin2);
                                if (agresifMod)
                                {
                                    txt_Sifre.BackColor = Color.LightCoral;
                                    txt_Sifre.ForeColor = Color.White;
                                }
                                else
                                {
                                    txt_Sifre.BackColor = SystemColors.Window;
                                    txt_Sifre.ForeColor = SystemColors.WindowText;
                                }
                                sr.Close();
                            }
                            else
                            {
                                sr.Close();
                                MessageBox.Show("Ayarlar okunurken bir sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır.", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                VarsayılanAyarlaraDon();
                            }
                        }
                        fs.Close();
                        AyarlariDogrula();
                    }
                }
                else VarsayılanAyarlaraDon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ayarlar okunurken bir sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır. Hata detayı: " + e.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VarsayılanAyarlaraDon();
            }
        }

        void VarsayılanAyarlaraDon()
        {
            string dosyaKonumu = Path.Combine(Application.StartupPath, "ayar.ini");
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

        void AyarlariDogrula()
        {
            bool hata = false;
            if (karakterSayisi < 8 || karakterSayisi > 16) hata = true;
            if (rakamSayisi < 4 || rakamSayisi > 8) hata = true;
            if (maxAyniKarakterSayisi < 0 || maxAyniKarakterSayisi > 2) hata = true;
            if (hata) VarsayılanAyarlaraDon();
        }

        List<string> kacinilacakKarakterListesi = new List<string>();
        string sifre;
        public void SifreUret()
        {

            kacinilacakKarakterListesi.Clear();
            char[] charArr = txt_KacinilacakKarakterler.Text.ToCharArray();
            foreach (char ch in charArr) kacinilacakKarakterListesi.Add(ch.ToString());
            txt_Sifre.Text = "";
            if (karakterSayisi < 8 || karakterSayisi > 128) throw new ArgumentOutOfRangeException("length");
            do
            {
                sifre = "";
                sifre += Membership.GeneratePassword(128, 25);
                sifre = IstenmeyenKarakterleriSil(sifre);
            } while (sifre.Length < karakterSayisi);
            sifre = ayniKarakterleriKontrolEt(sifre, karakterSayisi);
            if (sifre.Length < karakterSayisi)
            {
                SifreUret();
                return;
            }
            txt_Sifre.Text = sifre;
            if (!sifreSonuSayiEkleme)
            {
                txt_Sifre.Text += "-";
                SayiUret();
            }
        }

        public string IstenmeyenKarakterleriSil(string sifre)
        {
            bool ozelKarakterIceriyorMu = false;
            string[] ozelKarakterler = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "\\", ":", ";", "<", ">", "/", "?", "." };
            string[] benzerKarakterler = new string[] { "(", ")", "0", "O", "o", "1", "i", "I", "l", "|", "!", ":", ";" };
            foreach (string c in benzerKarakterler)
                sifre = sifre.Replace(c, string.Empty);

            if (cb_OzelKarakter.Checked)
            {
                foreach (string r in ozelKarakterler)
                    sifre = sifre.Replace(r, string.Empty);
            }
            if (!cb_OzelKarakter.Checked)
            {
                if (kacinilacakKarakterListesi.Count > 0)
                {
                    foreach (string r in kacinilacakKarakterListesi)
                    {
                        sifre = sifre.Replace(r.ToLower(), string.Empty);
                        sifre = sifre.Replace(r.ToUpper(), string.Empty);
                    }
                }
                if (agresifMod)
                {
                    foreach (var ch in ozelKarakterler)
                    {
                        if (sifre.Substring(0, karakterSayisi).Contains(ch))
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

        public string ayniKarakterleriKontrolEt(string sifre, int karakterSayisi)
        {
            bool sifreDegistiMi = false;
            string geciciSifre = sifre.Substring(0, karakterSayisi);
            foreach (char c in geciciSifre)
            {
                if (maxAyniKarakterSayisi + 1 < geciciSifre.Split(Convert.ToChar(c)).Length - 1)
                {
                    geciciSifre = geciciSifre.Remove(geciciSifre.LastIndexOf(c), 1);
                    sifreDegistiMi = true;
                }
            }
            if (!sifreDegistiMi)
            { return geciciSifre; }
            int sayi = karakterSayisi;
            geciciSifre += sifre.Substring(++sayi);
            return ayniKarakterleriKontrolEt(geciciSifre, sayi);
        }

        public void SayiUret()
        {
            string sayi = "";
            do
            {
                sayi += Membership.GeneratePassword(128, 25);
                sayi = Regex.Replace(sayi, "[^0-9]", "");
            } while (sayi.Length < rakamSayisi);
            txt_Sifre.Text += sayi.Substring(0, rakamSayisi);
        }

        private void btn_SifreUret_Click(object sender, EventArgs e)
        {
            SifreUret();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            using (FormKaydet formKaydet = new FormKaydet())
            {
                formKaydet.txt_Sifre.Text = txt_Sifre.Text;
                formKaydet.ShowDialog();
            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            using (FormListele formListele = new FormListele())
            {
                formListele.ShowDialog();
            }
        }

        private void btn_TopluUret_Click(object sender, EventArgs e)
        {
            using (FormTopluUretmeAdetGiris formTopluAdet = new FormTopluUretmeAdetGiris())
            {
                formTopluAdet.cb_OzelKarakter = cb_OzelKarakter.Checked;
                formTopluAdet.ExcChars = txt_KacinilacakKarakterler.Text.ToCharArray();
                formTopluAdet.ShowDialog();
            }
        }

        private void txt_Sifre_MouseEnter(object sender, EventArgs e)
        {
            if (agresifMod)
            {
                toolTip_txt_Sifre.SetToolTip(txt_Sifre, "Agresif mod aktif kapatmak için ayarlar ekranına gidiniz.");
            }
            else
            {
                toolTip_txt_Sifre.SetToolTip(txt_Sifre, null);
            }
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            using (FormAyar formAyar = new FormAyar())
            {
                formAyar.ShowDialog();
            }
            AyarlariGetir();
        }

        private void cb_OzelKarakter_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_OzelKarakter.Checked && !altForm)
            {
                if (txt_KacinilacakKarakterler.TextLength > 0 || agresifMod)
                {
                    MessageBox.Show("Bu modda özel karakter olmadan rakamlardan ve harflerden " +
                    "şifre oluşturulmaktadır. Bu nedenle istenmeyen karakterden kaçınma özelliği ve agresif mod burada çalışmamaktadır.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                agresifMod = false;
                txt_Sifre.BackColor = SystemColors.Window;
                txt_Sifre.ForeColor = SystemColors.WindowText;
                txt_KacinilacakKarakterler.Enabled = false;
            }
            else
            {
                agresifMod = agresifModIlkDurum;
                if (agresifMod)
                {
                    txt_Sifre.BackColor = Color.LightCoral;
                    txt_Sifre.ForeColor = Color.White;

                }
                txt_KacinilacakKarakterler.Enabled = true;
            }
        }
    }
}
