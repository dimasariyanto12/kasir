namespace AplikasiKasirrrr
{
    partial class cariBrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cariBrg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangDataSet = new AplikasiKasirrrr.BarangDataSet();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barangTableAdapter = new AplikasiKasirrrr.BarangDataSetTableAdapters.BarangTableAdapter();
            this.Pilih = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgbeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsuplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 35);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(962, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pilih,
            this.idDataGridViewTextBoxColumn,
            this.kode,
            this.nama,
            this.deskripsiDataGridViewTextBoxColumn,
            this.stok,
            this.hrgbeliDataGridViewTextBoxColumn,
            this.harga,
            this.idsuplierDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.barangBindingSource;
            this.dgv.Location = new System.Drawing.Point(77, 126);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(891, 401);
            this.dgv.TabIndex = 28;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.barangDataSet;
            // 
            // barangDataSet
            // 
            this.barangDataSet.DataSetName = "BarangDataSet";
            this.barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(262, 76);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(573, 32);
            this.txtCari.TabIndex = 27;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cari(kode/Nama)";
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // Pilih
            // 
            this.Pilih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pilih.HeaderText = "";
            this.Pilih.Image = ((System.Drawing.Image)(resources.GetObject("Pilih.Image")));
            this.Pilih.MinimumWidth = 8;
            this.Pilih.Name = "Pilih";
            this.Pilih.ReadOnly = true;
            this.Pilih.Width = 8;
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
            // kode
            // 
            this.kode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode.DataPropertyName = "kode_brg";
            this.kode.HeaderText = "Kode Barang";
            this.kode.MinimumWidth = 8;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
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
            // stok
            // 
            this.stok.DataPropertyName = "stok";
            this.stok.HeaderText = "Stok";
            this.stok.MinimumWidth = 8;
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            this.stok.Width = 150;
            // 
            // hrgbeliDataGridViewTextBoxColumn
            // 
            this.hrgbeliDataGridViewTextBoxColumn.DataPropertyName = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.HeaderText = "HargaBeli";
            this.hrgbeliDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrgbeliDataGridViewTextBoxColumn.Name = "hrgbeliDataGridViewTextBoxColumn";
            this.hrgbeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.hrgbeliDataGridViewTextBoxColumn.Visible = false;
            this.hrgbeliDataGridViewTextBoxColumn.Width = 150;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "hrg_jual";
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Width = 150;
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
            // cariBrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "cariBrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cariBrg";
            this.Load += new System.EventHandler(this.CariBrg_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private BarangDataSet barangDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private BarangDataSetTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn Pilih;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgbeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsuplierDataGridViewTextBoxColumn;
    }
}