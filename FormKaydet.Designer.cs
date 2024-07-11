
namespace WFASifreUretici
{
    partial class FormKaydet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKaydet));
            this.lbl_Sıfre = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SifreNotu = new System.Windows.Forms.TextBox();
            this.btn_SifreyiKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Sıfre
            // 
            this.lbl_Sıfre.AutoSize = true;
            this.lbl_Sıfre.Location = new System.Drawing.Point(12, 36);
            this.lbl_Sıfre.Name = "lbl_Sıfre";
            this.lbl_Sıfre.Size = new System.Drawing.Size(87, 13);
            this.lbl_Sıfre.TabIndex = 5;
            this.lbl_Sıfre.Text = "Oluşturulan Şifre:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(105, 33);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.ReadOnly = true;
            this.txt_Sifre.Size = new System.Drawing.Size(226, 20);
            this.txt_Sifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notunuzu Giriniz:";
            // 
            // txt_SifreNotu
            // 
            this.txt_SifreNotu.Location = new System.Drawing.Point(105, 59);
            this.txt_SifreNotu.MaxLength = 32;
            this.txt_SifreNotu.Name = "txt_SifreNotu";
            this.txt_SifreNotu.Size = new System.Drawing.Size(226, 20);
            this.txt_SifreNotu.TabIndex = 0;
            // 
            // btn_SifreyiKaydet
            // 
            this.btn_SifreyiKaydet.Image = global::WFASifreUretici.Properties.Resources.kaydet;
            this.btn_SifreyiKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SifreyiKaydet.Location = new System.Drawing.Point(12, 100);
            this.btn_SifreyiKaydet.Name = "btn_SifreyiKaydet";
            this.btn_SifreyiKaydet.Size = new System.Drawing.Size(319, 41);
            this.btn_SifreyiKaydet.TabIndex = 1;
            this.btn_SifreyiKaydet.Text = "Şifre ve Notu Kaydet";
            this.btn_SifreyiKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SifreyiKaydet.UseVisualStyleBackColor = true;
            this.btn_SifreyiKaydet.Click += new System.EventHandler(this.btn_SifreyiKaydet_Click);
            // 
            // FormKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.Controls.Add(this.btn_SifreyiKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SifreNotu);
            this.Controls.Add(this.lbl_Sıfre);
            this.Controls.Add(this.txt_Sifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 190);
            this.Name = "FormKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifre Kaydetme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sıfre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SifreyiKaydet;
        internal System.Windows.Forms.TextBox txt_Sifre;
        internal System.Windows.Forms.TextBox txt_SifreNotu;
    }
}