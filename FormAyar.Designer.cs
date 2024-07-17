
namespace WFASifreUretici
{
	partial class FormAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyar));
            this.lbl_MaxAyniKarakter = new System.Windows.Forms.Label();
            this.n_maxAyniKarakterSayisi = new System.Windows.Forms.NumericUpDown();
            this.n_karakterSayisi = new System.Windows.Forms.NumericUpDown();
            this.lbl_Karakter = new System.Windows.Forms.Label();
            this.btn_OncekiAyarlaraDon = new System.Windows.Forms.Button();
            this.btn_VarsayilanAyarlar = new System.Windows.Forms.Button();
            this.cb_SayiUretme = new System.Windows.Forms.CheckBox();
            this.n_rakamSayisi = new System.Windows.Forms.NumericUpDown();
            this.lbl_SayiAdet = new System.Windows.Forms.Label();
            this.cb_AgresifMod = new System.Windows.Forms.CheckBox();
            this.btn_Yardim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAyniKarakterSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_karakterSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_rakamSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaxAyniKarakter
            // 
            this.lbl_MaxAyniKarakter.AutoSize = true;
            this.lbl_MaxAyniKarakter.Location = new System.Drawing.Point(51, 38);
            this.lbl_MaxAyniKarakter.Name = "lbl_MaxAyniKarakter";
            this.lbl_MaxAyniKarakter.Size = new System.Drawing.Size(126, 13);
            this.lbl_MaxAyniKarakter.TabIndex = 21;
            this.lbl_MaxAyniKarakter.Text = "Max Aynı Karakter Sayısı:";
            // 
            // n_maxAyniKarakterSayisi
            // 
            this.n_maxAyniKarakterSayisi.Location = new System.Drawing.Point(182, 36);
            this.n_maxAyniKarakterSayisi.Name = "n_maxAyniKarakterSayisi";
            this.n_maxAyniKarakterSayisi.Size = new System.Drawing.Size(42, 20);
            this.n_maxAyniKarakterSayisi.TabIndex = 2;
            this.n_maxAyniKarakterSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_maxAyniKarakterSayisi.ValueChanged += new System.EventHandler(this.SaveChanges);
            // 
            // n_karakterSayisi
            // 
            this.n_karakterSayisi.Location = new System.Drawing.Point(182, 10);
            this.n_karakterSayisi.Name = "n_karakterSayisi";
            this.n_karakterSayisi.Size = new System.Drawing.Size(42, 20);
            this.n_karakterSayisi.TabIndex = 1;
            this.n_karakterSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n_karakterSayisi.ValueChanged += new System.EventHandler(this.SaveChanges);
            // 
            // lbl_Karakter
            // 
            this.lbl_Karakter.AutoSize = true;
            this.lbl_Karakter.Location = new System.Drawing.Point(96, 12);
            this.lbl_Karakter.Name = "lbl_Karakter";
            this.lbl_Karakter.Size = new System.Drawing.Size(80, 13);
            this.lbl_Karakter.TabIndex = 20;
            this.lbl_Karakter.Text = "Karakter Adedi:";
            // 
            // btn_OncekiAyarlaraDon
            // 
            this.btn_OncekiAyarlaraDon.Location = new System.Drawing.Point(12, 134);
            this.btn_OncekiAyarlaraDon.Name = "btn_OncekiAyarlaraDon";
            this.btn_OncekiAyarlaraDon.Size = new System.Drawing.Size(125, 30);
            this.btn_OncekiAyarlaraDon.TabIndex = 6;
            this.btn_OncekiAyarlaraDon.Text = "Değişiklikleri Geri Al";
            this.btn_OncekiAyarlaraDon.UseVisualStyleBackColor = true;
            this.btn_OncekiAyarlaraDon.Click += new System.EventHandler(this.btn_OncekiAyarlaraDon_Click);
            // 
            // btn_VarsayilanAyarlar
            // 
            this.btn_VarsayilanAyarlar.Location = new System.Drawing.Point(145, 134);
            this.btn_VarsayilanAyarlar.Name = "btn_VarsayilanAyarlar";
            this.btn_VarsayilanAyarlar.Size = new System.Drawing.Size(142, 30);
            this.btn_VarsayilanAyarlar.TabIndex = 7;
            this.btn_VarsayilanAyarlar.Text = "Varsayılan Ayarları Kullan";
            this.btn_VarsayilanAyarlar.UseVisualStyleBackColor = true;
            this.btn_VarsayilanAyarlar.Click += new System.EventHandler(this.btn_VarsayilanAyarlar_Click);
            // 
            // cb_SayiUretme
            // 
            this.cb_SayiUretme.AutoSize = true;
            this.cb_SayiUretme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_SayiUretme.Location = new System.Drawing.Point(58, 88);
            this.cb_SayiUretme.Name = "cb_SayiUretme";
            this.cb_SayiUretme.Size = new System.Drawing.Size(166, 17);
            this.cb_SayiUretme.TabIndex = 4;
            this.cb_SayiUretme.Text = "Şifre sonunda - ile sayı üretme";
            this.cb_SayiUretme.UseVisualStyleBackColor = true;
            this.cb_SayiUretme.CheckedChanged += new System.EventHandler(this.SaveChanges);
            // 
            // n_rakamSayisi
            // 
            this.n_rakamSayisi.Location = new System.Drawing.Point(182, 62);
            this.n_rakamSayisi.Name = "n_rakamSayisi";
            this.n_rakamSayisi.Size = new System.Drawing.Size(42, 20);
            this.n_rakamSayisi.TabIndex = 3;
            this.n_rakamSayisi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.n_rakamSayisi.ValueChanged += new System.EventHandler(this.SaveChanges);
            // 
            // lbl_SayiAdet
            // 
            this.lbl_SayiAdet.AutoSize = true;
            this.lbl_SayiAdet.Location = new System.Drawing.Point(116, 64);
            this.lbl_SayiAdet.Name = "lbl_SayiAdet";
            this.lbl_SayiAdet.Size = new System.Drawing.Size(60, 13);
            this.lbl_SayiAdet.TabIndex = 22;
            this.lbl_SayiAdet.Text = "Sayı Adedi:";
            // 
            // cb_AgresifMod
            // 
            this.cb_AgresifMod.AutoSize = true;
            this.cb_AgresifMod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_AgresifMod.Location = new System.Drawing.Point(102, 111);
            this.cb_AgresifMod.Name = "cb_AgresifMod";
            this.cb_AgresifMod.Size = new System.Drawing.Size(122, 17);
            this.cb_AgresifMod.TabIndex = 5;
            this.cb_AgresifMod.Text = "Agresif modu aktif et";
            this.cb_AgresifMod.UseVisualStyleBackColor = true;
            this.cb_AgresifMod.CheckedChanged += new System.EventHandler(this.SaveChanges);
            // 
            // btn_Yardim
            // 
            this.btn_Yardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yardim.Location = new System.Drawing.Point(262, 12);
            this.btn_Yardim.Name = "btn_Yardim";
            this.btn_Yardim.Size = new System.Drawing.Size(25, 25);
            this.btn_Yardim.TabIndex = 8;
            this.btn_Yardim.Text = "?";
            this.btn_Yardim.UseVisualStyleBackColor = true;
            this.btn_Yardim.Click += new System.EventHandler(this.btn_Yardim_Click);
            // 
            // FormAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.btn_Yardim);
            this.Controls.Add(this.cb_AgresifMod);
            this.Controls.Add(this.n_rakamSayisi);
            this.Controls.Add(this.lbl_SayiAdet);
            this.Controls.Add(this.cb_SayiUretme);
            this.Controls.Add(this.lbl_MaxAyniKarakter);
            this.Controls.Add(this.n_maxAyniKarakterSayisi);
            this.Controls.Add(this.n_karakterSayisi);
            this.Controls.Add(this.lbl_Karakter);
            this.Controls.Add(this.btn_VarsayilanAyarlar);
            this.Controls.Add(this.btn_OncekiAyarlaraDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 215);
            this.Name = "FormAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar Ekranı";
            this.Load += new System.EventHandler(this.FormAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAyniKarakterSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_karakterSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_rakamSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_MaxAyniKarakter;
		private System.Windows.Forms.NumericUpDown n_maxAyniKarakterSayisi;
		private System.Windows.Forms.NumericUpDown n_karakterSayisi;
		private System.Windows.Forms.Label lbl_Karakter;
		private System.Windows.Forms.Button btn_OncekiAyarlaraDon;
        private System.Windows.Forms.Button btn_VarsayilanAyarlar;
        private System.Windows.Forms.CheckBox cb_SayiUretme;
        private System.Windows.Forms.NumericUpDown n_rakamSayisi;
        private System.Windows.Forms.Label lbl_SayiAdet;
        private System.Windows.Forms.CheckBox cb_AgresifMod;
        private System.Windows.Forms.Button btn_Yardim;
    }
}