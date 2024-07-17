using System;
using System.IO;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormAyar : Form
    {
        public FormAyar()
        {
            InitializeComponent();
        }

        private void FormAyar_Load(object sender, EventArgs e)
        {
            n_karakterSayisi.Minimum = 8;
            n_karakterSayisi.Maximum = 16;
            n_rakamSayisi.Minimum = 4;
            n_rakamSayisi.Maximum = 8;
            n_maxAyniKarakterSayisi.Minimum = 0;
            n_maxAyniKarakterSayisi.Maximum = 2;
            AyarlariGetir();
        }

        int karakterSayisi, rakamSayisi, maxAyniKarakterSayisi;
        bool sifreSonuSayiEkleme, agresifMod;
        bool ayarOkuma = false;
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
                            try
                            {
                                ayarOkuma = true;
                                n_karakterSayisi.Value = karakterSayisi = Convert.ToInt32(sr.ReadLine());
                                n_rakamSayisi.Value = rakamSayisi = Convert.ToInt32(sr.ReadLine());
                                n_maxAyniKarakterSayisi.Value = maxAyniKarakterSayisi = Convert.ToInt32(sr.ReadLine());

                                string metin = sr.ReadLine();
                                string metin2 = sr.ReadLine();
                                if (metin != null && metin2 != null)
                                {
                                    cb_SayiUretme.Checked = sifreSonuSayiEkleme = Convert.ToBoolean(metin);
                                    cb_AgresifMod.Checked = agresifMod = Convert.ToBoolean(metin2);
                                }
                                else
                                {
                                    MessageBox.Show("Ayarlar okunurken bir sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır.", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    VarsayılanAyarlaraDon();
                                }
                                sr.Close();

                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                sr.Close();
                                fs.Close();
                                MessageBox.Show("Ayarlar okunurken sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır. Hata detayı: " + e.Message, "Veri Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                VarsayılanAyarlaraDon();
                            }
                        }
                        ayarOkuma = false;
                        fs.Close();
                        AyarlariDogrula();
                    }
                }
                else
                {
                    VarsayılanAyarlaraDon();
                    AyarlariKaydet();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ayarlar okunurken bir sorun oluştu. Bu nedenle varsayılan ayarlar geçerli olacaktır. Hata detayı: " + e.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VarsayılanAyarlaraDon();
                AyarlariKaydet();
            }
        }

        void AyarlariDogrula()
        {
            bool hata = false;
            if (n_karakterSayisi.Value < 8 || n_karakterSayisi.Value > 16) hata = true;
            if (n_rakamSayisi.Value < 4 || n_rakamSayisi.Value > 8) hata = true;
            if (n_maxAyniKarakterSayisi.Value < 0 || n_maxAyniKarakterSayisi.Value > 2) hata = true;
            if (hata) VarsayılanAyarlaraDon();
        }

        void VarsayılanAyarlaraDon()
        {
            n_karakterSayisi.Value = 10;
            n_rakamSayisi.Value = 4;
            n_maxAyniKarakterSayisi.Value = 1;
            cb_SayiUretme.Checked = false;
            cb_AgresifMod.Checked = false;
        }

        void AyarlariKaydet()
        {
            if (ayarOkuma) return;               
            try
            {
                string dosyaKonumu = Path.Combine(Application.StartupPath, "ayar.ini");
                using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("" + n_karakterSayisi.Value + "\n" + n_rakamSayisi.Value + "\n" + n_maxAyniKarakterSayisi.Value + "\n" + cb_SayiUretme.Checked + "\n" + cb_AgresifMod.Checked);
                        sw.Flush();
                        sw.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                DialogResult dialogResultKaydet = new DialogResult();
                dialogResultKaydet = MessageBox.Show("Ayarlar kaydedilirken bir sorun oluştu. Hata detayı:  " + e.Message + "Varsayılan ayarları kullanmak için Evet'i, " +
                    "değişiklikleri geri almak için Hayır'ı seçiniz.", "Hata Oluştu", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResultKaydet == DialogResult.Yes) VarsayılanAyarlaraDon();
                else OncekiAyarlaraDon();
            }
        }

        private void OncekiAyarlaraDon()
        {
            n_karakterSayisi.Value = karakterSayisi;
            n_rakamSayisi.Value = rakamSayisi;
            n_maxAyniKarakterSayisi.Value = maxAyniKarakterSayisi;
            cb_SayiUretme.Checked = sifreSonuSayiEkleme;
            cb_AgresifMod.Checked = agresifMod;
        }

        private void btn_Yardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Karakter adedi, şifrenin baş kısmında bulunan harflerden, rakamlardan veya özel karakterlerden oluşan kısmın adedini " +
                "ayarlamaktadır.\n" +
                "Max Aynı Karakter Sayısı, şifre içindeki bir karakterden en çok kaç adet olabileceğini ayarlamaktadır.\n" +
                "Sayı adedi, şifrenin ilk kısmından sonra gelen - ile birlikte '-1234' gibi sayı bulunan kısımdır. Bu sayının kaç basamaklı olduğunu " +
                "ayarlamaktadır.\n" +
                "Şifre sonunda - ile sayı üretme, üstte belirtilen olayı devre dışı bırakmaktadır ve şifre sadece ilk kısımdan oluşmaktadır.\n" +
                "Agresif modu aktif et, aktif olduğunda programı özel karakterli şifre üretmeye zorlar.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_OncekiAyarlaraDon_Click(object sender, EventArgs e)
        {
            OncekiAyarlaraDon();
        }

        private void btn_VarsayilanAyarlar_Click(object sender, EventArgs e)
        {
            VarsayılanAyarlaraDon();
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (cb_SayiUretme.Checked) n_rakamSayisi.Enabled = false;
            else n_rakamSayisi.Enabled = true;
            AyarlariKaydet();
        }
    }
}