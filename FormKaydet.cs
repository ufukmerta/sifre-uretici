using System;
using System.IO;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormKaydet : Form
    {
        public FormKaydet()
        {
            InitializeComponent();
        }
        private void btn_SifreyiKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        public void Kaydet(bool altForm = false)
        {
            try
            {
                string dosyaKonumu = Path.Combine(Application.StartupPath, "pass.data");
                using (FileStream fs = new FileStream(dosyaKonumu, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(txt_Sifre.Text + "\t" + txt_SifreNotu.Text);
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        if (altForm)
                        {
                            MessageBox.Show("Şifre ve not bilgisi başarılı bir şekilde kaydedildi.", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şifre ve not bilgisi kaydedilirken bir hata oluştu. Hata bilgisi: " + ex.Message, "Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
