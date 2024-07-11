
namespace WFASifreUretici
{
    partial class FormListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListele));
            this.dgv_Sifre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Yardim = new System.Windows.Forms.Button();
            this.btn_DisariAktar = new System.Windows.Forms.Button();
            this.btn_DegisiklikleriGeriAl = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sifre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Sifre
            // 
            this.dgv_Sifre.AllowUserToAddRows = false;
            this.dgv_Sifre.AllowUserToResizeColumns = false;
            this.dgv_Sifre.AllowUserToResizeRows = false;
            this.dgv_Sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Sifre.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgv_Sifre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sifre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_Sifre.Location = new System.Drawing.Point(10, 12);
            this.dgv_Sifre.Name = "dgv_Sifre";
            this.dgv_Sifre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Sifre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sifre.Size = new System.Drawing.Size(775, 287);
            this.dgv_Sifre.TabIndex = 23;
            this.dgv_Sifre.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sifre_CellValueChanged);
            this.dgv_Sifre.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_Sifre_RowsAdded);
            this.dgv_Sifre.SizeChanged += new System.EventHandler(this.dgv_Sifre_SizeChanged);
            this.dgv_Sifre.DoubleClick += new System.EventHandler(this.dgv_Sifre_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sıra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Şifre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Not";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 421;
            // 
            // btn_Yardim
            // 
            this.btn_Yardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yardim.Location = new System.Drawing.Point(762, 13);
            this.btn_Yardim.Name = "btn_Yardim";
            this.btn_Yardim.Size = new System.Drawing.Size(22, 20);
            this.btn_Yardim.TabIndex = 27;
            this.btn_Yardim.Text = "?";
            this.btn_Yardim.UseVisualStyleBackColor = true;
            this.btn_Yardim.Click += new System.EventHandler(this.btn_Yardim_Click);
            // 
            // btn_DisariAktar
            // 
            this.btn_DisariAktar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisariAktar.Image = global::WFASifreUretici.Properties.Resources.disariaktar;
            this.btn_DisariAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DisariAktar.Location = new System.Drawing.Point(634, 318);
            this.btn_DisariAktar.Name = "btn_DisariAktar";
            this.btn_DisariAktar.Size = new System.Drawing.Size(150, 45);
            this.btn_DisariAktar.TabIndex = 28;
            this.btn_DisariAktar.Text = "Dışarı Aktar";
            this.btn_DisariAktar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DisariAktar.UseVisualStyleBackColor = true;
            this.btn_DisariAktar.Click += new System.EventHandler(this.btn_DisariAktar_Click);
            // 
            // btn_DegisiklikleriGeriAl
            // 
            this.btn_DegisiklikleriGeriAl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DegisiklikleriGeriAl.Image = global::WFASifreUretici.Properties.Resources.geriyukle;
            this.btn_DegisiklikleriGeriAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegisiklikleriGeriAl.Location = new System.Drawing.Point(322, 318);
            this.btn_DegisiklikleriGeriAl.Name = "btn_DegisiklikleriGeriAl";
            this.btn_DegisiklikleriGeriAl.Size = new System.Drawing.Size(150, 45);
            this.btn_DegisiklikleriGeriAl.TabIndex = 5;
            this.btn_DegisiklikleriGeriAl.Text = "Değişiklikleri Geri Al";
            this.btn_DegisiklikleriGeriAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DegisiklikleriGeriAl.UseVisualStyleBackColor = true;
            this.btn_DegisiklikleriGeriAl.Click += new System.EventHandler(this.btn_DegisiklikleriGeriAl_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Image = global::WFASifreUretici.Properties.Resources.sil;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.Location = new System.Drawing.Point(166, 318);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(150, 45);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "Seçileni Sil";
            this.btn_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Listele.Image = global::WFASifreUretici.Properties.Resources.listele;
            this.btn_Listele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Listele.Location = new System.Drawing.Point(10, 318);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(150, 45);
            this.btn_Listele.TabIndex = 2;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kaydet.Image = global::WFASifreUretici.Properties.Resources.kaydet;
            this.btn_Kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kaydet.Location = new System.Drawing.Point(478, 318);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 45);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // FormListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 375);
            this.Controls.Add(this.btn_DisariAktar);
            this.Controls.Add(this.btn_Yardim);
            this.Controls.Add(this.dgv_Sifre);
            this.Controls.Add(this.btn_DegisiklikleriGeriAl);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Kaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 805);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(815, 414);
            this.Name = "FormListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifre Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListele_FormClosing);
            this.Load += new System.EventHandler(this.FormListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sifre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_DegisiklikleriGeriAl;
        private System.Windows.Forms.DataGridView dgv_Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_Yardim;
        private System.Windows.Forms.Button btn_DisariAktar;
    }
}