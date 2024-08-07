using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
            ayarlar = new Ayarlar();
            sifreUretici = new SifreUretici(ayarlar);
        }
        internal bool altForm = false;
        Ayarlar ayarlar;
        SifreUretici sifreUretici;

        private void FormAna_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Concat(this.Text, version.Major, ".", version.Minor, ".", version.Build);
            AyarlardanGetir();
            if (!altForm) SifreUret();
        }
        bool agresifMod = false;
        void AyarlardanGetir()
        {
            agresifMod = ayarlar.AgresifMod;
            if (agresifMod && !cb_OzelKarakterYok.Checked)
            {
                txt_Sifre.BackColor = Color.LightCoral;
                txt_Sifre.ForeColor = Color.White;
            }
            else
            {
                txt_Sifre.BackColor = SystemColors.Window;
                txt_Sifre.ForeColor = SystemColors.WindowText;
            }
        }

        List<string> kacinilacakKarakterListesi = new List<string>();

        public void SifreUret()
        {
            txt_Sifre.Text = sifreUretici.Uret(txt_KacinilacakKarakterler.Text, cb_OzelKarakterYok.Checked);
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
                formTopluAdet.ozelKarakterYok = cb_OzelKarakterYok.Checked;
                formTopluAdet.kacinilacakKarakterler = txt_KacinilacakKarakterler.Text;
                formTopluAdet.ShowDialog();
            }
        }

        private void txt_Sifre_MouseEnter(object sender, EventArgs e)
        {
            if (agresifMod)
            {
                toolTip_txt_Sifre.SetToolTip(txt_Sifre, "Agresif mod aktif. Kapatmak için ayarlar ekranına gidiniz.");
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
            ayarlar.AyarlariGetir();
            AyarlardanGetir();
        }

        private void cb_OzelKarakter_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_OzelKarakterYok.Checked && !altForm)
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
                agresifMod = ayarlar.AgresifMod;
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
