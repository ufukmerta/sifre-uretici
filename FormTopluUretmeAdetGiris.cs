﻿using System;
using System.Windows.Forms;

namespace WFASifreUretici
{
    public partial class FormTopluUretmeAdetGiris : Form
    {
        public FormTopluUretmeAdetGiris()
        {
            InitializeComponent();
        }                
        internal bool ozelKarakterYok = false;
        internal string kacinilacakKarakterler="";
        private void btn_createPassword_Click(object sender, EventArgs e)
        {
            using (FormTopluUretme formToplu = new FormTopluUretme())
            {
                formToplu.adet = Convert.ToInt32(num_SifreAdet.Value);
                formToplu.ozelKarakterYok = ozelKarakterYok;
                formToplu.kacinilacakKarakterler = kacinilacakKarakterler;
                formToplu.ShowDialog();
            }
            Close();
        }
    }
}
