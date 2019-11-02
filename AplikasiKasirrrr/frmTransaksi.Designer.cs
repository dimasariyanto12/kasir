namespace AplikasiKasirrrr
{
    partial class frmTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaksi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkodeplg = new System.Windows.Forms.Label();
            this.txtNotrx = new System.Windows.Forms.TextBox();
            this.txtNamaPlg = new System.Windows.Forms.TextBox();
            this.txtTgl = new System.Windows.Forms.DateTimePicker();
            this.btnCariPlg = new System.Windows.Forms.Button();
            this.txtKodeBrg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCariBrg = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdKasir = new System.Windows.Forms.Label();
            this.txtKasir = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTunai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tambah = new System.Windows.Forms.DataGridViewImageColumn();
            this.Kurang = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 39);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1200, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCariPlg);
            this.groupBox1.Controls.Add(this.txtTgl);
            this.groupBox1.Controls.Add(this.txtNamaPlg);
            this.groupBox1.Controls.Add(this.txtNotrx);
            this.groupBox1.Controls.Add(this.txtkodeplg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(13, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 395);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKasir);
            this.groupBox3.Controls.Add(this.txtIdKasir);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(858, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.txtTunai);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtKembali);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(821, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 395);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "::PEMBAYARAN::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "TRANSAKSI | TOKO MAJU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tanggal";
            // 
            // txtkodeplg
            // 
            this.txtkodeplg.AutoSize = true;
            this.txtkodeplg.Location = new System.Drawing.Point(371, 110);
            this.txtkodeplg.Name = "txtkodeplg";
            this.txtkodeplg.Size = new System.Drawing.Size(92, 23);
            this.txtkodeplg.TabIndex = 3;
            this.txtkodeplg.Text = "kodeplg";
            this.txtkodeplg.Visible = false;
            // 
            // txtNotrx
            // 
            this.txtNotrx.Enabled = false;
            this.txtNotrx.Location = new System.Drawing.Point(165, 32);
            this.txtNotrx.Name = "txtNotrx";
            this.txtNotrx.Size = new System.Drawing.Size(420, 32);
            this.txtNotrx.TabIndex = 4;
            // 
            // txtNamaPlg
            // 
            this.txtNamaPlg.Enabled = false;
            this.txtNamaPlg.Location = new System.Drawing.Point(165, 71);
            this.txtNamaPlg.Name = "txtNamaPlg";
            this.txtNamaPlg.Size = new System.Drawing.Size(420, 32);
            this.txtNamaPlg.TabIndex = 5;
            // 
            // txtTgl
            // 
            this.txtTgl.Enabled = false;
            this.txtTgl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTgl.Location = new System.Drawing.Point(165, 110);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.Size = new System.Drawing.Size(200, 32);
            this.txtTgl.TabIndex = 6;
            // 
            // btnCariPlg
            // 
            this.btnCariPlg.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCariPlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPlg.ForeColor = System.Drawing.Color.White;
            this.btnCariPlg.Location = new System.Drawing.Point(592, 70);
            this.btnCariPlg.Name = "btnCariPlg";
            this.btnCariPlg.Size = new System.Drawing.Size(114, 33);
            this.btnCariPlg.TabIndex = 7;
            this.btnCariPlg.Text = "Cari";
            this.btnCariPlg.UseVisualStyleBackColor = false;
            this.btnCariPlg.Click += new System.EventHandler(this.BtnCariPlg_Click);
            // 
            // txtKodeBrg
            // 
            this.txtKodeBrg.Location = new System.Drawing.Point(19, 259);
            this.txtKodeBrg.Name = "txtKodeBrg";
            this.txtKodeBrg.Size = new System.Drawing.Size(286, 32);
            this.txtKodeBrg.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kode Barang";
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.Enabled = false;
            this.txtNamaBrg.Location = new System.Drawing.Point(311, 259);
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(234, 32);
            this.txtNamaBrg.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nama Barang";
            // 
            // btnCariBrg
            // 
            this.btnCariBrg.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCariBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBrg.ForeColor = System.Drawing.Color.White;
            this.btnCariBrg.Location = new System.Drawing.Point(16, 297);
            this.btnCariBrg.Name = "btnCariBrg";
            this.btnCariBrg.Size = new System.Drawing.Size(124, 32);
            this.btnCariBrg.TabIndex = 8;
            this.btnCariBrg.Text = "Cari ";
            this.btnCariBrg.UseVisualStyleBackColor = false;
            this.btnCariBrg.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(551, 258);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(179, 32);
            this.txtHarga.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Harga";
            // 
            // txtStok
            // 
            this.txtStok.Enabled = false;
            this.txtStok.Location = new System.Drawing.Point(736, 257);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(75, 32);
            this.txtStok.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Stok";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(817, 257);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(75, 32);
            this.txtQty.TabIndex = 17;
            this.txtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(813, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Qty";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(898, 255);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(172, 33);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah Item";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 49);
            this.label10.TabIndex = 19;
            this.label10.Text = "TOTAL :";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(156, 53);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(110, 49);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Kasir :";
            // 
            // txtIdKasir
            // 
            this.txtIdKasir.AutoSize = true;
            this.txtIdKasir.Location = new System.Drawing.Point(343, 28);
            this.txtIdKasir.Name = "txtIdKasir";
            this.txtIdKasir.Size = new System.Drawing.Size(29, 23);
            this.txtIdKasir.TabIndex = 8;
            this.txtIdKasir.Text = "Id";
            this.txtIdKasir.Visible = false;
            // 
            // txtKasir
            // 
            this.txtKasir.AutoSize = true;
            this.txtKasir.Location = new System.Drawing.Point(294, 144);
            this.txtKasir.Name = "txtKasir";
            this.txtKasir.Size = new System.Drawing.Size(64, 23);
            this.txtKasir.TabIndex = 21;
            this.txtKasir.Text = "Kasir :";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column8,
            this.Tambah,
            this.Kurang,
            this.Hapus});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 28);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 62;
            this.dgvList.RowTemplate.Height = 28;
            this.dgvList.Size = new System.Drawing.Size(792, 364);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellContentClick);
            // 
            // txtKembali
            // 
            this.txtKembali.Enabled = false;
            this.txtKembali.Location = new System.Drawing.Point(48, 152);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(334, 32);
            this.txtKembali.TabIndex = 20;
            this.txtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Kembali";
            // 
            // txtTunai
            // 
            this.txtTunai.Location = new System.Drawing.Point(48, 82);
            this.txtTunai.Name = "txtTunai";
            this.txtTunai.Size = new System.Drawing.Size(334, 32);
            this.txtTunai.TabIndex = 20;
            this.txtTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTunai.TextChanged += new System.EventHandler(this.TxtTunai_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Tunai";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(48, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bayar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(48, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 52);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Barang";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pelanggan";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Harga";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Qty";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 81;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Stok";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 86;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "kode_barang";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 150;
            // 
            // Tambah
            // 
            this.Tambah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tambah.HeaderText = "";
            this.Tambah.Image = ((System.Drawing.Image)(resources.GetObject("Tambah.Image")));
            this.Tambah.MinimumWidth = 8;
            this.Tambah.Name = "Tambah";
            this.Tambah.ReadOnly = true;
            this.Tambah.Width = 8;
            // 
            // Kurang
            // 
            this.Kurang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurang.HeaderText = "";
            this.Kurang.Image = ((System.Drawing.Image)(resources.GetObject("Kurang.Image")));
            this.Kurang.MinimumWidth = 8;
            this.Kurang.Name = "Kurang";
            this.Kurang.ReadOnly = true;
            this.Kurang.Width = 8;
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
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 724);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCariBrg);
            this.Controls.Add(this.txtNamaBrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKodeBrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransaksi";
            this.Load += new System.EventHandler(this.FrmTransaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCariPlg;
        private System.Windows.Forms.DateTimePicker txtTgl;
        private System.Windows.Forms.TextBox txtNamaPlg;
        private System.Windows.Forms.TextBox txtNotrx;
        private System.Windows.Forms.Label txtkodeplg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtKodeBrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCariBrg;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTunai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label txtKasir;
        public System.Windows.Forms.Label txtIdKasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Tambah;
        private System.Windows.Forms.DataGridViewImageColumn Kurang;
        private System.Windows.Forms.DataGridViewImageColumn Hapus;
    }
}