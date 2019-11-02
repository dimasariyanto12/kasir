namespace AplikasiKasirrrr
{
    partial class tmbBarang
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
            this.cmbSuplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBlengkap = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.suplierDataSet = new AplikasiKasirrrr.SuplierDataSet();
            this.suplierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplierTableAdapter = new AplikasiKasirrrr.SuplierDataSetTableAdapters.SuplierTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHrgBeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHrgJual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuplier
            // 
            this.cmbSuplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suplierBindingSource, "nama", true));
            this.cmbSuplier.DataSource = this.suplierBindingSource;
            this.cmbSuplier.DisplayMember = "nama";
            this.cmbSuplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuplier.FormattingEnabled = true;
            this.cmbSuplier.Location = new System.Drawing.Point(634, 197);
            this.cmbSuplier.Name = "cmbSuplier";
            this.cmbSuplier.Size = new System.Drawing.Size(283, 31);
            this.cmbSuplier.TabIndex = 57;
            this.cmbSuplier.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Suplier";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(160, 84);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(315, 32);
            this.txtKode.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Kode";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 40);
            this.panel1.TabIndex = 43;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(422, 10);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(167, 23);
            this.lblJudul.TabIndex = 14;
            this.lblJudul.Text = "Tambah Barang";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(928, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblBlengkap
            // 
            this.lblBlengkap.AutoSize = true;
            this.lblBlengkap.ForeColor = System.Drawing.Color.Red;
            this.lblBlengkap.Location = new System.Drawing.Point(499, 260);
            this.lblBlengkap.Name = "lblBlengkap";
            this.lblBlengkap.Size = new System.Drawing.Size(276, 23);
            this.lblBlengkap.TabIndex = 44;
            this.lblBlengkap.Text = "Input data belum lengkap!";
            this.lblBlengkap.Visible = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Orange;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Location = new System.Drawing.Point(792, 249);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(125, 44);
            this.btnUbah.TabIndex = 52;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(160, 160);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(315, 89);
            this.txtDeskripsi.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Deskripsi";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 23);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(160, 122);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(315, 32);
            this.txtNama.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(792, 249);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(125, 44);
            this.btnSimpan.TabIndex = 53;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // suplierDataSet
            // 
            this.suplierDataSet.DataSetName = "SuplierDataSet";
            this.suplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suplierDataSetBindingSource
            // 
            this.suplierDataSetBindingSource.DataSource = this.suplierDataSet;
            this.suplierDataSetBindingSource.Position = 0;
            // 
            // suplierBindingSource
            // 
            this.suplierBindingSource.DataMember = "Suplier";
            this.suplierBindingSource.DataSource = this.suplierDataSetBindingSource;
            // 
            // suplierTableAdapter
            // 
            this.suplierTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Stok";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(634, 83);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(283, 32);
            this.txtStok.TabIndex = 59;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStok_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Harga Beli";
            // 
            // txtHrgBeli
            // 
            this.txtHrgBeli.Location = new System.Drawing.Point(634, 121);
            this.txtHrgBeli.Name = "txtHrgBeli";
            this.txtHrgBeli.Size = new System.Drawing.Size(283, 32);
            this.txtHrgBeli.TabIndex = 61;
            this.txtHrgBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStok_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Harga Jual";
            // 
            // txtHrgJual
            // 
            this.txtHrgJual.Location = new System.Drawing.Point(634, 159);
            this.txtHrgJual.Name = "txtHrgJual";
            this.txtHrgJual.Size = new System.Drawing.Size(283, 32);
            this.txtHrgJual.TabIndex = 63;
            this.txtHrgJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStok_KeyPress);
            // 
            // tmbBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHrgJual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHrgBeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.cmbSuplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBlengkap);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "tmbBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tmbBarang";
            this.Load += new System.EventHandler(this.TmbBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbSuplier;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtKode;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblBlengkap;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.TextBox txtDeskripsi;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.BindingSource suplierDataSetBindingSource;
        private SuplierDataSet suplierDataSet;
        private System.Windows.Forms.BindingSource suplierBindingSource;
        private SuplierDataSetTableAdapters.SuplierTableAdapter suplierTableAdapter;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtStok;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtHrgBeli;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtHrgJual;
    }
}