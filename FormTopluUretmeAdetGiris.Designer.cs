namespace WFASifreUretici
{
    partial class FormTopluUretmeAdetGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopluUretmeAdetGiris));
            this.lbl_Adet = new System.Windows.Forms.Label();
            this.num_SifreAdet = new System.Windows.Forms.NumericUpDown();
            this.btn_SifreUret = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_SifreAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Adet
            // 
            this.lbl_Adet.AutoSize = true;
            this.lbl_Adet.Location = new System.Drawing.Point(42, 39);
            this.lbl_Adet.Name = "lbl_Adet";
            this.lbl_Adet.Size = new System.Drawing.Size(205, 13);
            this.lbl_Adet.TabIndex = 12;
            this.lbl_Adet.Text = "Oluşturmak İstediğiniz Şifre Adedini Giriniz:";
            // 
            // num_SifreAdet
            // 
            this.num_SifreAdet.Location = new System.Drawing.Point(253, 37);
            this.num_SifreAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_SifreAdet.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_SifreAdet.Name = "num_SifreAdet";
            this.num_SifreAdet.Size = new System.Drawing.Size(52, 20);
            this.num_SifreAdet.TabIndex = 16;
            this.num_SifreAdet.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_SifreUret
            // 
            this.btn_SifreUret.Image = global::WFASifreUretici.Properties.Resources.sifre;
            this.btn_SifreUret.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SifreUret.Location = new System.Drawing.Point(12, 78);
            this.btn_SifreUret.Name = "btn_SifreUret";
            this.btn_SifreUret.Size = new System.Drawing.Size(320, 41);
            this.btn_SifreUret.TabIndex = 9;
            this.btn_SifreUret.Text = "Oluştur";
            this.btn_SifreUret.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SifreUret.UseVisualStyleBackColor = true;
            this.btn_SifreUret.Click += new System.EventHandler(this.btn_createPassword_Click);
            // 
            // FormTopluUretmeAdetGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 131);
            this.Controls.Add(this.num_SifreAdet);
            this.Controls.Add(this.lbl_Adet);
            this.Controls.Add(this.btn_SifreUret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 170);
            this.Name = "FormTopluUretmeAdetGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toplu Üretme Adet Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.num_SifreAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SifreUret;
        private System.Windows.Forms.Label lbl_Adet;
        private System.Windows.Forms.NumericUpDown num_SifreAdet;
    }
}