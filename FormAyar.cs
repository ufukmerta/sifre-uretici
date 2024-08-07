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
        Ayarlar ayarlar = new Ayarlar();

        private void FormAyar_Load(object sender, EventArgs e)
        {
            n_karakterSayisi.Minimum = 8;
            n_karakterSayisi.Maximum = 16;
            n_rakamSayisi.Minimum = 4;
            n_rakamSayisi.Maximum = 8;
            n_maxAyniKarakterSayisi.Minimum = 0;
            n_maxAyniKarakterSayisi.Maximum = 2;
            AyarlardanGetir();
        }

        bool ayarlarGetiriliyor = false;
        void AyarlardanGetir()
        {
            ayarlarGetiriliyor = true;
            n_karakterSayisi.Value = ayarlar.KarakterSayisi;
            n_rakamSayisi.Value = ayarlar.RakamSayisi;
            n_maxAyniKarakterSayisi.Value = ayarlar.MaxAyniKarakterSayisi;
            cb_SayiUretme.Checked = ayarlar.SifreSonuSayiEkleme;
            cb_AgresifMod.Checked = ayarlar.AgresifMod;
            ayarlarGetiriliyor = false;
        }

        void AyarlariDuzenle()
        {
            if (!ayarlarGetiriliyor)
            {
                ayarlar.KarakterSayisi = Convert.ToInt32(n_karakterSayisi.Value);
                ayarlar.RakamSayisi = Convert.ToInt32(n_rakamSayisi.Value);
                ayarlar.MaxAyniKarakterSayisi = Convert.ToInt32(n_maxAyniKarakterSayisi.Value);
                ayarlar.SifreSonuSayiEkleme = cb_SayiUretme.Checked;
                ayarlar.AgresifMod = cb_AgresifMod.Checked;
            }
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
            ayarlar.AyarlariGetir();
            AyarlardanGetir();
        }

        private void btn_VarsayilanAyarlar_Click(object sender, EventArgs e)
        {
            ayarlar.VarsayilanAyarlaraDon();
            AyarlardanGetir();
        }

        private void DegisklikleriUygula(object sender, EventArgs e)
        {
            if (cb_SayiUretme.Checked) n_rakamSayisi.Enabled = false;
            else n_rakamSayisi.Enabled = true;
            AyarlariDuzenle();
        }

        private void FormAyar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ayarlar.Kaydet() == false)
            {
                AyarlardanGetir();
                e.Cancel = true;
            }
        }
    }
}