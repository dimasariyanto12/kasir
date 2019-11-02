using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasirrrr
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            sidebar.Height = btnHome.Height;
            sidebar.Top = btnHome.Top;
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi kasir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi kasir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnUsers.Height;
            sidebar.Top = btnUsers.Top;
            frmUser frm = new frmUser();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnPelanggan_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnPelanggan.Height;
            sidebar.Top = btnPelanggan.Top;
            frmPelanggan frm = new frmPelanggan();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnSuplier_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnSuplier.Height;
            sidebar.Top = btnSuplier.Top;
            frmSuplier frm = new frmSuplier();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnBarang_Click(object sender, EventArgs e)
        {

            sidebar.Height = btnBarang.Height;
            sidebar.Top = btnBarang.Top;
            frmBarang frm = new frmBarang();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {

            sidebar.Height = btnLaporan.Height;
            sidebar.Top = btnLaporan.Top;
            frmLaporan frm = new frmLaporan();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnHome.Height;
            sidebar.Top = btnHome.Top;
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            frmTransaksi frm = new frmTransaksi();
            frm.txtIdKasir.Text = idUser.ToString();
            frm.txtKasir.Text = namaUser.ToString();
            frm.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void IdUser_Click(object sender, EventArgs e)
        {

        }

        private void NamaUser_Click(object sender, EventArgs e)
        {

        }
    }
}
