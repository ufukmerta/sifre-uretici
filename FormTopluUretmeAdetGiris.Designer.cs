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
            this.label1 = new System.Windows.Forms.Label();
            this.numPassPcs = new System.Windows.Forms.NumericUpDown();
            this.btn_createPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPassPcs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oluşturmak İstediğiniz Şifre Adedini Giriniz:";
            // 
            // numPassPcs
            // 
            this.numPassPcs.Location = new System.Drawing.Point(253, 37);
            this.numPassPcs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPassPcs.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPassPcs.Name = "numPassPcs";
            this.numPassPcs.Size = new System.Drawing.Size(42, 20);
            this.numPassPcs.TabIndex = 16;
            this.numPassPcs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_createPassword
            // 
            this.btn_createPassword.Image = global::WFASifreUretici.Properties.Resources.sifre;
            this.btn_createPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createPassword.Location = new System.Drawing.Point(12, 78);
            this.btn_createPassword.Name = "btn_createPassword";
            this.btn_createPassword.Size = new System.Drawing.Size(320, 41);
            this.btn_createPassword.TabIndex = 9;
            this.btn_createPassword.Text = "Oluştur";
            this.btn_createPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_createPassword.UseVisualStyleBackColor = true;
            this.btn_createPassword.Click += new System.EventHandler(this.btn_createPassword_Click);
            // 
            // FormTopluUretmeAdetGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 131);
            this.Controls.Add(this.numPassPcs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 170);
            this.Name = "FormTopluUretmeAdetGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toplu Üretme Adet Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.numPassPcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPassPcs;
    }
}