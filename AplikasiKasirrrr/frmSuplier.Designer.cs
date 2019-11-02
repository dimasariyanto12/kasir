namespace AplikasiKasirrrr
{
    partial class frmSuplier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblHapus = new System.Windows.Forms.Label();
            this.lblUbah = new System.Windows.Forms.Label();
            this.lblSukses = new System.Windows.Forms.Label();
            this.suplierDataSet = new AplikasiKasirrrr.SuplierDataSet();
            this.suplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplierTableAdapter = new AplikasiKasirrrr.SuplierDataSetTableAdapters.SuplierTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 44);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Suplier";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.Ubah,
            this.Hapus});
            this.dgv.DataSource = this.suplierBindingSource;
            this.dgv.Location = new System.Drawing.Point(43, 146);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(891, 507);
            this.dgv.TabIndex = 21;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(502, 96);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(432, 32);
            this.txtCari.TabIndex = 20;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cari";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Lime;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(43, 84);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(161, 44);
            this.btnTambah.TabIndex = 19;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // lblHapus
            // 
            this.lblHapus.AutoSize = true;
            this.lblHapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHapus.Location = new System.Drawing.Point(507, 61);
            this.lblHapus.Name = "lblHapus";
            this.lblHapus.Size = new System.Drawing.Size(278, 23);
            this.lblHapus.TabIndex = 24;
            this.lblHapus.Text = "Data Users Berhasil DiHapus";
            this.lblHapus.Visible = false;
            // 
            // lblUbah
            // 
            this.lblUbah.AutoSize = true;
            this.lblUbah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUbah.Location = new System.Drawing.Point(507, 61);
            this.lblUbah.Name = "lblUbah";
            this.lblUbah.Size = new System.Drawing.Size(268, 23);
            this.lblUbah.TabIndex = 23;
            this.lblUbah.Text = "Data Users Berhasil Diubah";
            this.lblUbah.Visible = false;
            // 
            // lblSukses
            // 
            this.lblSukses.AutoSize = true;
            this.lblSukses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSukses.Location = new System.Drawing.Point(495, 61);
            this.lblSukses.Name = "lblSukses";
            this.lblSukses.Size = new System.Drawing.Size(295, 23);
            this.lblSukses.TabIndex = 22;
            this.lblSukses.Text = "Data Users Berhasil Tersimpan";
            this.lblSukses.Visible = false;
            // 
            // suplierDataSet
            // 
            this.suplierDataSet.DataSetName = "SuplierDataSet";
            this.suplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suplierBindingSource
            // 
            this.suplierBindingSource.DataMember = "Suplier";
            this.suplierBindingSource.DataSource = this.suplierDataSet;
            // 
            // suplierTableAdapter
            // 
            this.suplierTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpDataGridViewTextBoxColumn
            // 
            this.telpDataGridViewTextBoxColumn.DataPropertyName = "telp";
            this.telpDataGridViewTextBoxColumn.HeaderText = "Telepon/No HP";
            this.telpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
            this.telpDataGridViewTextBoxColumn.ReadOnly = true;
            this.telpDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            this.websiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.websiteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.websiteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.websiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // Ubah
            // 
            this.Ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ubah.HeaderText = "";
            this.Ubah.Image = ((System.Drawing.Image)(resources.GetObject("Ubah.Image")));
            this.Ubah.MinimumWidth = 8;
            this.Ubah.Name = "Ubah";
            this.Ubah.ReadOnly = true;
            this.Ubah.Width = 8;
            // 
            // Hapus
            // 
            this.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hapus.HeaderText = "";
            this.Hapus.Image = ((System.Drawing.Image)(resources.GetObject("Hapus.Image")));
            this.Hapus.MinimumWidth = 8;
            this.Hapus.Name = "Hapus";
            this.Hapus.ReadOnly = true;
            this.Hapus.Width = 8;
            // 
            // frmSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblHapus);
            this.Controls.Add(this.lblUbah);
            this.Controls.Add(this.lblSukses);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSuplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuplier";
            this.Load += new System.EventHandler(this.FrmSuplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Label lblHapus;
        public System.Windows.Forms.Label lblUbah;
        public System.Windows.Forms.Label lblSukses;
        private SuplierDataSet suplierDataSet;
        private System.Windows.Forms.BindingSource suplierBindingSource;
        private SuplierDataSetTableAdapters.SuplierTableAdapter suplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Ubah;
        private System.Windows.Forms.DataGridViewImageColumn Hapus;
    }
}