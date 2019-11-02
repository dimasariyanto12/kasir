using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasirrrr
{
    public partial class frmBarang : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        public frmBarang()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            load();
        }
        public void load()
        {
            this.barangTableAdapter.Fill(this.barangDataSet.Barang);
        }

        private void FrmBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barangDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.barangDataSet.Barang);

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv.Columns[e.ColumnIndex].Name;
            if (colName == "Ubah")
            {
                tmbBarang frm = new tmbBarang(this);
                frm.lblJudul.Text = "Ubah Data Barang";
                frm.btnSimpan.Visible = false;
                frm.lblId.Text = dgv[0, e.RowIndex].Value.ToString();
                frm.txtKode.Text = dgv[1, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgv[2, e.RowIndex].Value.ToString();
                frm.txtDeskripsi.Text = dgv[3, e.RowIndex].Value.ToString();
                frm.txtStok.Text = dgv[4, e.RowIndex].Value.ToString();
                frm.txtHrgBeli.Text = dgv[5, e.RowIndex].Value.ToString();
                frm.txtHrgJual.Text = dgv[6, e.RowIndex].Value.ToString();
                frm.cmbSuplier.SelectedItem = dgv[7, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Hapus")
            {
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    cn.Open();
                    cm = new SqlCommand("delete from Barang where id ='" + dgv[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    load();
                    lblSukses.Visible = false;
                    lblUbah.Visible = false;
                    lblHapus.Visible = true;
                }

            }

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            tmbBarang frm = new tmbBarang(this);
            frm.btnUbah.Visible = false;
            frm.ShowDialog();
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Barang   nama like '%" + txtCari.Text + "%' or  kode_brg like '%" + txtCari.Text + "%'", cn);
                da = new SqlDataAdapter(cm);
                ds = new DataSet();
                da.Fill(ds, "Barang");
                dgv.DataSource = ds;
                dgv.DataMember = "Barang";
                dgv.Refresh();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
