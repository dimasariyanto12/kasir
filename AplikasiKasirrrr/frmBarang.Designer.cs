namespace AplikasiKasirrrr
{
    partial class frmBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblHapus = new System.Windows.Forms.Label();
            this.lblUbah = new System.Windows.Forms.Label();
            this.lblSukses = new System.Windows.Forms.Label();
            this.barangDataSet = new AplikasiKasirrrr.BarangDataSet();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new AplikasiKasirrrr.BarangDataSetTableAdapters.BarangTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgbeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsuplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Barang";
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
            this.kodebrgDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.hrgbeliDataGridViewTextBoxColumn,
            this.hrgjualDataGridViewTextBoxColumn,
            this.idsuplierDataGridViewTextBoxColumn,
            this.Ubah,
            this.Hapus});
            this.dgv.DataSource = this.barangBindingSource;
            this.dgv.Location = new System.Drawing.Point(41, 137);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(891, 507);
            this.dgv.TabIndex = 29;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(500, 87);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(432, 32);
            this.txtCari.TabIndex = 28;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cari";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Lime;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(41, 75);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(161, 44);
            this.btnTambah.TabIndex = 27;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // lblHapus
            // 
            this.lblHapus.AutoSize = true;
            this.lblHapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHapus.Location = new System.Drawing.Point(496, 52);
            this.lblHapus.Name = "lblHapus";
            this.lblHapus.Size = new System.Drawing.Size(300, 23);
            this.lblHapus.TabIndex = 32;
            this.lblHapus.Text = "Data Barang Berhasil DiHapus";
            this.lblHapus.Visible = false;
            // 
            // lblUbah
            // 
            this.lblUbah.AutoSize = true;
            this.lblUbah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUbah.Location = new System.Drawing.Point(496, 52);
            this.lblUbah.Name = "lblUbah";
            this.lblUbah.Size = new System.Drawing.Size(290, 23);
            this.lblUbah.TabIndex = 31;
            this.lblUbah.Text = "Data Barang Berhasil Diubah";
            this.lblUbah.Visible = false;
            // 
            // lblSukses
            // 
            this.lblSukses.AutoSize = true;
            this.lblSukses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSukses.Location = new System.Drawing.Point(493, 52);
            this.lblSukses.Name = "lblSukses";
            this.lblSukses.Size = new System.Drawing.Size(317, 23);
            this.lblSukses.TabIndex = 30;
            this.lblSukses.Text = "Data Barang Berhasil Tersimpan";
            this.lblSukses.Visible = false;
            // 
            // barangDataSet
            // 
            this.barangDataSet.DataSetName = "BarangDataSet";
            this.barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.barangDataSet;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
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
            // kodebrgDataGridViewTextBoxColumn
            // 
            this.kodebrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodebrgDataGridViewTextBoxColumn.DataPropertyName = "kode_brg";
            this.kodebrgDataGridViewTextBoxColumn.HeaderText = "Kode Barang";
            this.kodebrgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodebrgDataGridViewTextBoxColumn.Name = "kodebrgDataGridViewTextBoxColumn";
            this.kodebrgDataGridViewTextBoxColumn.ReadOnly = true;
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
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.ReadOnly = true;
            this.deskripsiDataGridViewTextBoxColumn.Visible = false;
            this.deskripsiDataGridViewTextBoxColumn.Width = 150;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokDataGridViewTextBoxColumn.Width = 150;
            // 
            // hrgbeliDataGridViewTextBoxColumn
            // 
            this.hrgbeliDataGridViewTextBoxColumn.DataPropertyName = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.HeaderText = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrgbeliDataGridViewTextBoxColumn.Name = "hrgbeliDataGridViewTextBoxColumn";
            this.hrgbeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.hrgbeliDataGridViewTextBoxColumn.Visible = false;
            this.hrgbeliDataGridViewTextBoxColumn.Width = 150;
            // 
            // hrgjualDataGridViewTextBoxColumn
            // 
            this.hrgjualDataGridViewTextBoxColumn.DataPropertyName = "hrg_jual";
            this.hrgjualDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hrgjualDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrgjualDataGridViewTextBoxColumn.Name = "hrgjualDataGridViewTextBoxColumn";
            this.hrgjualDataGridViewTextBoxColumn.ReadOnly = true;
            this.hrgjualDataGridViewTextBoxColumn.Width = 150;
            // 
            // idsuplierDataGridViewTextBoxColumn
            // 
            this.idsuplierDataGridViewTextBoxColumn.DataPropertyName = "id_suplier";
            this.idsuplierDataGridViewTextBoxColumn.HeaderText = "id_suplier";
            this.idsuplierDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idsuplierDataGridViewTextBoxColumn.Name = "idsuplierDataGridViewTextBoxColumn";
            this.idsuplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsuplierDataGridViewTextBoxColumn.Visible = false;
            this.idsuplierDataGridViewTextBoxColumn.Width = 150;
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
            // frmBarang
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
            this.Name = "frmBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBarang";
            this.Load += new System.EventHandler(this.FrmBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
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
        private BarangDataSet barangDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private BarangDataSetTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgbeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsuplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Ubah;
        private System.Windows.Forms.DataGridViewImageColumn Hapus;
    }
}