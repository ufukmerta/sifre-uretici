using System;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormTopluUretme : Form
    {
        public FormTopluUretme()
        {
            InitializeComponent();
        }
        internal bool cb_OzelKarakter = false;
        internal char[] kacinilacakKarakterler = new char[15];
        internal int adet = 0;
        private void FormTopluUretme_Load(object sender, EventArgs e)
        {
            using (FormAna formAna = new FormAna())
            {
                formAna.Show();
                formAna.Hide();
                formAna.altForm = true;
                formAna.cb_OzelKarakter.Checked = cb_OzelKarakter;
                formAna.txt_KacinilacakKarakterler.Text = new string(kacinilacakKarakterler);
                formAna.SifreUret();
                for (int i = 1; i <= adet; i++)
                {
                    formAna.SifreUret();
                    object[] satir = { i, formAna.txt_Sifre.Text, "" };
                    dgv_Sifre.Rows.Add(satir);
                }
                formAna.Close();
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            using (FormKaydet formKaydet = new FormKaydet())
            {
                formKaydet.Show();
                formKaydet.Hide();
                int sayac = 0;
                for (int i = 0; i <= dgv_Sifre.RowCount - 1; i++)
                {
                    formKaydet.txt_Sifre.Text = dgv_Sifre.Rows[i].Cells[1].Value.ToString();
                    formKaydet.txt_SifreNotu.Text = dgv_Sifre.Rows[i].Cells[2].Value.ToString();
                    sayac += formKaydet.Kaydet(true);
                }
                formKaydet.Close();
                MessageBox.Show("Üretilen Şifre adedi: " + dgv_Sifre.RowCount + ". Kaydedilen şifre adedi: " + sayac);
            }
        }

        private void dgv_Sifre_SizeChanged(object sender, EventArgs e)
        {
            dgv_YenidenBoyutlandir();
        }

        private void dgv_PwList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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

        bool uyariVer = true;
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Sil();
            dgv_YenidenBoyutlandir();
        }

        void Sil()
        {
            if (uyariVer)
            {
                MessageBox.Show("Silme işlemi geri alınamaz ve bu uyarı bir defa verildikten sonra tekrar gösterilmeyecek. " +
                    "Bu nedenle silme işleminde dikkatli olunuz. Tabloda işlemlerinizi tamamladığınızda 'Tümünü Kaydet' " +
                    "ile kayıtlı şifrelere ekleyebilirsiniz. Aksi halde kaydedilmeyecektir.",
                    "İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uyariVer = false;
            }
            else
            {
                try
                {
                    if (dgv_Sifre.SelectedRows.Count > 0)
                    {
                        dgv_Sifre.Rows.RemoveAt(dgv_Sifre.SelectedRows[0].Index);
                    }
                    else MessageBox.Show("Silme işlemi için önce öge seçmeniz gerekmektedir.", "İşlem Bilgisi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata! Silme işlemi başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btn_Yardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifreyi kopyalamak için ilgili satıra çift tıklamanız gerekmektedir.\n" +
                "Şifreye not eklemek için aralıklı şekilde çift tıklamanız gerekmektedir. Seçili satıra tek tıklama ile yine " +
                "düzenleme moduna geçer.\n" +
                "Şifre silmek için öncelikle ilgili satırı seçiniz. Sonrasında Seçileni Tablodan Sil butonunu kullanınız.\n" +
                "Oluşturulan şifreleri kaydetmek için Kaydet butonuna tıklamanız gerekmektedir. " +
                "Aksi halde şifreler kaydedilmeyecektir. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}