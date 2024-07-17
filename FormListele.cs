using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormListele : Form
    {
        public FormListele()
        {
            InitializeComponent();
        }
        bool listeDegistiMi = false;
        string dosyaKonumu = Path.Combine(Application.StartupPath, "pass.data");
        private void FormListele_Load(object sender, EventArgs e)
        {
            SifreleriGetir();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            SifreleriGetir();
        }

        void SifreleriGetir()
        {
            listeDegistiMi = false;
            try
            {
                dgv_Sifre.Rows.Clear();                
                if (File.Exists(dosyaKonumu))
                {
                    using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            int sayac = 1;
                            while (!sr.EndOfStream)
                            {
                                string metin = sr.ReadLine();
                                object[] satir = { sayac, metin.Substring(0, metin.IndexOf("\t")), metin.Substring(metin.IndexOf("\t") + 1) };
                                sayac += 1;
                                dgv_Sifre.Rows.Add(satir);
                            }
                            sr.Close();
                            fs.Close();
                        }
                    }
                }
                else MessageBox.Show("Şifrelere ait bir dosya bulunamadı! Şifreleri görmek için ana ekran şifreyi kaydetmeyi unutmayınız.",
                    "Şifre Dosyası Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Şifreler okunurken bir hata oluştu. Hata detayı: " + e.Message, "Hata Oluştu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void Sil()
        {
            try
            {
                if (dgv_Sifre.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv_Sifre.SelectedRows)
                        dgv_Sifre.Rows.RemoveAt(item.Index);
                    MessageBox.Show("Seçilen öge(ler) başarılı şekilde silindi. " +
                        "Yapılan değişikliklerin geçerli olması için kayıt işlemi yapmanız gerekmektedir.", "İşlem Bilgisi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listeDegistiMi = true;
                }
                else MessageBox.Show("Silme işlemi için önce öge seçmeniz gerekmektedir.", "İşlem Bilgisi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata! Silme işlemi başarısız. \n" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool kaydetHata = false;
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            kaydetHata = false;
            Kaydet(false);
            if (!kaydetHata) SifreleriGetir();
        }
        void Kaydet(bool kapatirkenKaydet)
        {
            DialogResult dialogResultKaydet = new DialogResult();
            if (!kapatirkenKaydet)
            {
                dialogResultKaydet = MessageBox.Show("Yapılan değişiklikler kaydedilecek. Kaydetme işleminden sonra işlemler geri alınamaz." +
                    " Kaydetmek için Evet'i, " +
                    "işlemi iptal etmek için Hayır'ı seçiniz.", "Değişiklikleri Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (dialogResultKaydet == DialogResult.Yes || kapatirkenKaydet)
            {
                verileriYaz(dosyaKonumu);
            }
            else
            {
                MessageBox.Show("Kayıt işlemi iptal edildi.", "İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kaydetHata = true;
            }            
        }

        void verileriYaz(string konum, bool export = false)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(konum, FileMode.Create), Encoding.UTF8))
                {
                    for (int i = 0; i <= dgv_Sifre.RowCount - 1; i++)
                    {
                        if (!export) sw.WriteLine(dgv_Sifre.Rows[i].Cells[1].Value.ToString() + "\t" + dgv_Sifre.Rows[i].Cells[2].Value.ToString());
                        else sw.WriteLine((i + 1) + ". Şifre \nNot: " + dgv_Sifre.Rows[i].Cells[2].Value.ToString() + "\nŞifre: " + dgv_Sifre.Rows[i].Cells[1].Value.ToString() + "\n");
                    }
                }
                MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (konum == dosyaKonumu)
                {
                    MessageBox.Show("Kaydetme sırasında hata oluştu. " +
                                        "Veri kaybı yaşamamanız için tablo bilgileri şifre dosyasının son halinden yüklenmedi. Hata detayı: " + ex.Message,
                                        "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kaydetHata = true;
                }
                else
                {
                    MessageBox.Show("Kaydetme sırasında hata oluştu. " +
                                        "Hata detayı: " + ex.Message,
                                        "Kayıt İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_DegisiklikleriGeriAl_Click(object sender, EventArgs e)
        {
            SifreleriGetir();
        }

        private void dgv_Sifre_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Sifre.SelectedRows.Count > 0)
            {
                Clipboard.SetText(dgv_Sifre.SelectedRows[0].Cells[1].Value.ToString());
                MessageBox.Show("Seçilen öge başarılı şekilde panoya kopyalandı.", "İşlem Bilgisi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Kopyalama işlemi için önce öge seçmeniz gerekmektedir.", "İşlem Bilgisi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgv_Sifre_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_YenidenBoyutlandir();
        }

        private void dgv_Sifre_SizeChanged(object sender, EventArgs e)
        {
            dgv_YenidenBoyutlandir();
        }

        void dgv_YenidenBoyutlandir()
        {
            if (dgv_Sifre.RowCount > 12)
            {
                int boyut = Convert.ToInt32(dgv_Sifre.RowCount * 22.07);
                if (dgv_Sifre.Height <= boyut)
                {
                    dgv_Sifre.Columns[2].Width = this.Width - 410;
                }
                else
                {
                    dgv_Sifre.Columns[2].Width = this.Width - 393;
                }
            }
            else
            {
                dgv_Sifre.Columns[2].Width = this.Width - 393;
            }
        }

        private void FormListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listeDegistiMi)
            {
                DialogResult dialogResultKaydet = MessageBox.Show("Form kapatılmadan önce varsa yapılan değişiklikler kaydedilecek. Kaydetme işleminden sonra işlemler geri alınamaz." +
                "\nKaydetmek için Evet'i, " +
                "kayıt işlemini yapmadan ana ekrana dönmek için Hayır'ı, liste ekranına geri dönmek için İptal'i seçiniz.", "Değişiklikleri Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResultKaydet == DialogResult.Yes)
                {
                    Kaydet(true);
                    if (kaydetHata)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else if (dialogResultKaydet == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void dgv_Sifre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            listeDegistiMi = true;
        }

        private void btn_Yardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifreyi kopyalamak için ilgili satıra çift tıklamanız gerekmektedir.\n" +
                "Şifrenin notunu değiştirmek için aralıklı şekilde çift tıklamanız gerekmektedir. Seçili satıra tek tıklama ile yine " +
                "düzenleme moduna geçer.\n" +
                "Şifre silmek için öncelikle ilgili satırı seçiniz. Sonrasında Seçileni Sil butonunu kullanınız.\n" +
                "Veriler değiştirildikten sonra kayıt edilmesi gerekmektedir. Aksi halde yapılan değişiklikler geçerli olmayacaktır. " +
                "Değişiklikleri geri almak (kayıtlı olan son verileri geri getirmek) için Listele veya Değişiklikleri Geri Al butonunu " +
                "kullanabilirsiniz.\n"
                , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void btn_DisariAktar_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Metin dosyaları (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Title = "Kaydedilecek Konumu Seçin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResultSave = MessageBox.Show("Metin formatında kaydetmek için Evet'i " +
                "programa yedek almak için Hayır'ı, işlemi iptal etmek İptal'i seçiniz.", "Kayıt Türünü Seçin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResultSave == DialogResult.Yes)
                {
                    verileriYaz(saveFileDialog.FileName, true);
                }
                else if (dialogResultSave == DialogResult.No)
                {
                    verileriYaz(saveFileDialog.FileName);
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
