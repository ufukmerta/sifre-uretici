
namespace WFASifreUretici
{
	partial class FormAna
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KacinilacakKarakterler = new System.Windows.Forms.TextBox();
            this.lbl_Sİfre = new System.Windows.Forms.Label();
            this.lbl_KacinilacakKarakter = new System.Windows.Forms.Label();
            this.cb_OzelKarakterYok = new System.Windows.Forms.CheckBox();
            this.btn_TopluUret = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_SifreUret = new System.Windows.Forms.Button();
            this.toolTip_txt_Sifre = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(123, 12);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(149, 21);
            this.txt_Sifre.TabIndex = 1;
            this.txt_Sifre.MouseEnter += new System.EventHandler(this.txt_Sifre_MouseEnter);
            // 
            // txt_KacinilacakKarakterler
            // 
            this.txt_KacinilacakKarakterler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KacinilacakKarakterler.Location = new System.Drawing.Point(167, 38);
            this.txt_KacinilacakKarakterler.MaxLength = 15;
            this.txt_KacinilacakKarakterler.Name = "txt_KacinilacakKarakterler";
            this.txt_KacinilacakKarakterler.Size = new System.Drawing.Size(105, 21);
            this.txt_KacinilacakKarakterler.TabIndex = 2;
            // 
            // lbl_Sİfre
            // 
            this.lbl_Sİfre.AutoSize = true;
            this.lbl_Sİfre.Location = new System.Drawing.Point(12, 15);
            this.lbl_Sİfre.Name = "lbl_Sİfre";
            this.lbl_Sİfre.Size = new System.Drawing.Size(87, 13);
            this.lbl_Sİfre.TabIndex = 20;
            this.lbl_Sİfre.Text = "Oluşturulan Şifre:";
            // 
            // lbl_KacinilacakKarakter
            // 
            this.lbl_KacinilacakKarakter.AutoSize = true;
            this.lbl_KacinilacakKarakter.Location = new System.Drawing.Point(12, 41);
            this.lbl_KacinilacakKarakter.Name = "lbl_KacinilacakKarakter";
            this.lbl_KacinilacakKarakter.Size = new System.Drawing.Size(149, 13);
            this.lbl_KacinilacakKarakter.TabIndex = 21;
            this.lbl_KacinilacakKarakter.Text = "Kaçınılacak karakterleri giriniz:";
            // 
            // cb_OzelKarakterYok
            // 
            this.cb_OzelKarakterYok.AutoSize = true;
            this.cb_OzelKarakterYok.Location = new System.Drawing.Point(15, 68);
            this.cb_OzelKarakterYok.Name = "cb_OzelKarakterYok";
            this.cb_OzelKarakterYok.Size = new System.Drawing.Size(138, 17);
            this.cb_OzelKarakterYok.TabIndex = 3;
            this.cb_OzelKarakterYok.Text = "Özel Karakter İçermesin";
            this.cb_OzelKarakterYok.UseVisualStyleBackColor = true;
            this.cb_OzelKarakterYok.CheckedChanged += new System.EventHandler(this.cb_OzelKarakter_CheckedChanged);
            // 
            // btn_TopluUret
            // 
            this.btn_TopluUret.Location = new System.Drawing.Point(167, 64);
            this.btn_TopluUret.Name = "btn_TopluUret";
            this.btn_TopluUret.Size = new System.Drawing.Size(105, 23);
            this.btn_TopluUret.TabIndex = 9;
            this.btn_TopluUret.Text = "Toplu Şifre Üret";
            this.btn_TopluUret.UseVisualStyleBackColor = true;
            this.btn_TopluUret.Click += new System.EventHandler(this.btn_TopluUret_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Image = global::WFASifreUretici.Properties.Resources.listele;
            this.btn_Listele.Location = new System.Drawing.Point(184, 95);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(41, 41);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Image = global::WFASifreUretici.Properties.Resources.kaydet;
            this.btn_Kaydet.Location = new System.Drawing.Point(137, 95);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(41, 41);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.Image = global::WFASifreUretici.Properties.Resources.ayarlar;
            this.btn_Ayarlar.Location = new System.Drawing.Point(231, 95);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(41, 41);
            this.btn_Ayarlar.TabIndex = 7;
            this.btn_Ayarlar.UseVisualStyleBackColor = true;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_SifreUret
            // 
            this.btn_SifreUret.Image = global::WFASifreUretici.Properties.Resources.sifre;
            this.btn_SifreUret.Location = new System.Drawing.Point(12, 95);
            this.btn_SifreUret.Name = "btn_SifreUret";
            this.btn_SifreUret.Size = new System.Drawing.Size(119, 41);
            this.btn_SifreUret.TabIndex = 4;
            this.btn_SifreUret.Text = "Şifre Oluştur";
            this.btn_SifreUret.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SifreUret.UseVisualStyleBackColor = true;
            this.btn_SifreUret.Click += new System.EventHandler(this.btn_SifreUret_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btn_TopluUret);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cb_OzelKarakterYok);
            this.Controls.Add(this.btn_Ayarlar);
            this.Controls.Add(this.lbl_KacinilacakKarakter);
            this.Controls.Add(this.lbl_Sİfre);
            this.Controls.Add(this.txt_KacinilacakKarakterler);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.btn_SifreUret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 190);
            this.MinimumSize = new System.Drawing.Size(300, 190);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Üretici V";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_SifreUret;
        private System.Windows.Forms.Label lbl_Sİfre;
        private System.Windows.Forms.Label lbl_KacinilacakKarakter;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_TopluUret;
        internal System.Windows.Forms.TextBox txt_Sifre;
        internal System.Windows.Forms.CheckBox cb_OzelKarakterYok;
        private System.Windows.Forms.ToolTip toolTip_txt_Sifre;
        internal System.Windows.Forms.TextBox txt_KacinilacakKarakterler;
    }
}

