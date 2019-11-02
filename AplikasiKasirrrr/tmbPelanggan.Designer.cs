namespace AplikasiKasirrrr
{
    partial class tmbPelanggan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBlengkap = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 40);
            this.panel1.TabIndex = 26;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(233, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(205, 23);
            this.lblJudul.TabIndex = 14;
            this.lblJudul.Text = "Tambah Pelanggan";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(534, 3);
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
            this.lblBlengkap.Location = new System.Drawing.Point(129, 363);
            this.lblBlengkap.Name = "lblBlengkap";
            this.lblBlengkap.Size = new System.Drawing.Size(276, 23);
            this.lblBlengkap.TabIndex = 27;
            this.lblBlengkap.Text = "Input data belum lengkap!";
            this.lblBlengkap.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(422, 352);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(125, 44);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Orange;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Location = new System.Drawing.Point(422, 352);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(125, 44);
            this.btnUbah.TabIndex = 37;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(198, 240);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(349, 89);
            this.txtAlamat.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Alamat";
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(198, 202);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(349, 32);
            this.txtTelp.TabIndex = 32;
            this.txtTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "No Hp";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 23);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(198, 128);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(349, 32);
            this.txtNama.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nama";
            // 
            // txtKode
            // 
            this.txtKode.Enabled = false;
            this.txtKode.Location = new System.Drawing.Point(198, 90);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(349, 32);
            this.txtKode.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kode";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmbGender.Location = new System.Drawing.Point(198, 166);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(349, 31);
            this.cmbGender.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Jenis Kelamin";
            // 
            // tmbPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBlengkap);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "tmbPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tmbPelanggan";
            this.Load += new System.EventHandler(this.TmbPelanggan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblBlengkap;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTelp;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtKode;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.Label label5;
    }
}