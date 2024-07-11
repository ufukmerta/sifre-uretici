namespace WFASifreUretici
{
    partial class FormTopluUretme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopluUretme));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Sifre = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Yardim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sifre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(482, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Şifreyi kopyalamak için ilgili satıra çift tıklamanız gerekmektedir";
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
            this.Sira,
            this.Sifre,
            this.Not});
            this.dgv_Sifre.Location = new System.Drawing.Point(12, 12);
            this.dgv_Sifre.MultiSelect = false;
            this.dgv_Sifre.Name = "dgv_Sifre";
            this.dgv_Sifre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Sifre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sifre.Size = new System.Drawing.Size(775, 287);
            this.dgv_Sifre.TabIndex = 22;
            this.dgv_Sifre.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_PwList_RowsAdded);
            this.dgv_Sifre.SizeChanged += new System.EventHandler(this.dgv_Sifre_SizeChanged);
            this.dgv_Sifre.DoubleClick += new System.EventHandler(this.dgv_Sifre_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.ReadOnly = true;
            this.Sira.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sira.Width = 60;
            // 
            // Sifre
            // 
            this.Sifre.HeaderText = "Şifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.ReadOnly = true;
            this.Sifre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sifre.Width = 250;
            // 
            // Not
            // 
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            this.Not.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Not.Width = 421;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(406, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(154, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 24;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Image = global::WFASifreUretici.Properties.Resources.sil;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.Location = new System.Drawing.Point(12, 305);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(380, 45);
            this.btn_Sil.TabIndex = 19;
            this.btn_Sil.Text = "Seçileni Tablodan Sil";
            this.btn_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Image = global::WFASifreUretici.Properties.Resources.kaydet;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.Location = new System.Drawing.Point(407, 305);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(380, 45);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Tümünü Kaydet";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Yardim
            // 
            this.btn_Yardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yardim.Location = new System.Drawing.Point(764, 13);
            this.btn_Yardim.Name = "btn_Yardim";
            this.btn_Yardim.Size = new System.Drawing.Size(22, 20);
            this.btn_Yardim.TabIndex = 28;
            this.btn_Yardim.Text = "?";
            this.btn_Yardim.UseVisualStyleBackColor = true;
            this.btn_Yardim.Click += new System.EventHandler(this.btn_Yardim_Click);
            // 
            // FormTopluUretme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 361);
            this.Controls.Add(this.btn_Yardim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 796);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(815, 400);
            this.Name = "FormTopluUretme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toplu Şifre Üretme";
            this.Load += new System.EventHandler(this.FormTopluUretme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sifre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgv_Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Yardim;
    }
}