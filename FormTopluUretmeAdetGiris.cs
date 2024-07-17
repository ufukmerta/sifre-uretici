using System;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormTopluUretmeAdetGiris : Form
    {
        public FormTopluUretmeAdetGiris()
        {
            InitializeComponent();
        }

        internal bool cb_OzelKarakter = false;
        internal char[] ExcChars = new char[15];
        private void btn_createPassword_Click(object sender, EventArgs e)
        {
            using (FormTopluUretme formToplu = new FormTopluUretme())
            {
                formToplu.adet = Convert.ToInt32(num_SifreAdet.Value);
                formToplu.cb_OzelKarakter = cb_OzelKarakter;
                formToplu.kacinilacakKarakterler = ExcChars;
                formToplu.ShowDialog();
            }
            Close();
        }
    }
}
