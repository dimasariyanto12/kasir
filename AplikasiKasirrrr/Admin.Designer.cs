namespace AplikasiKasirrrr
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnSuplier = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.idUser = new System.Windows.Forms.ToolStripLabel();
            this.namaUser = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLaporan);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnPelanggan);
            this.panel1.Controls.Add(this.btnSuplier);
            this.panel1.Controls.Add(this.btnBarang);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 722);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Orange;
            this.sidebar.Location = new System.Drawing.Point(3, 236);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(17, 46);
            this.sidebar.TabIndex = 12;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 594);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(274, 52);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(0, 542);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(274, 52);
            this.btnLaporan.TabIndex = 10;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.BtnLaporan_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 490);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(274, 52);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.Button7_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPelanggan.FlatAppearance.BorderSize = 0;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnPelanggan.Location = new System.Drawing.Point(0, 438);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(274, 52);
            this.btnPelanggan.TabIndex = 8;
            this.btnPelanggan.Text = "Pelanggan";
            this.btnPelanggan.UseVisualStyleBackColor = true;
            this.btnPelanggan.Click += new System.EventHandler(this.BtnPelanggan_Click);
            // 
            // btnSuplier
            // 
            this.btnSuplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuplier.FlatAppearance.BorderSize = 0;
            this.btnSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplier.ForeColor = System.Drawing.Color.White;
            this.btnSuplier.Location = new System.Drawing.Point(0, 386);
            this.btnSuplier.Name = "btnSuplier";
            this.btnSuplier.Size = new System.Drawing.Size(274, 52);
            this.btnSuplier.TabIndex = 7;
            this.btnSuplier.Text = "Suplier";
            this.btnSuplier.UseVisualStyleBackColor = true;
            this.btnSuplier.Click += new System.EventHandler(this.BtnSuplier_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarang.FlatAppearance.BorderSize = 0;
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarang.ForeColor = System.Drawing.Color.White;
            this.btnBarang.Location = new System.Drawing.Point(0, 334);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(274, 52);
            this.btnBarang.TabIndex = 6;
            this.btnBarang.Text = "Barang";
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.BtnBarang_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 282);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(274, 52);
            this.btnTransaksi.TabIndex = 5;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.BtnTransaksi_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 230);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(274, 52);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 230);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOKO MAJU";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 38);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(919, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.toolStrip1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(274, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(966, 684);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMain_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idUser,
            this.namaUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 654);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // idUser
            // 
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(27, 25);
            this.idUser.Text = "id";
            this.idUser.Click += new System.EventHandler(this.IdUser_Click);
            // 
            // namaUser
            // 
            this.namaUser.Name = "namaUser";
            this.namaUser.Size = new System.Drawing.Size(56, 25);
            this.namaUser.Text = "nama";
            this.namaUser.Click += new System.EventHandler(this.NamaUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 722);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnSuplier;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel idUser;
        public System.Windows.Forms.ToolStripLabel namaUser;
    }
}