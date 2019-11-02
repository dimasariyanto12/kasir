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
    public partial class frmTransaksi : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr ;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        public frmTransaksi()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            autonumber();
            txtQty.Text = "1";
        }

        public void autonumber()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string notrx;
            int count;

            try
            {
                cn.Open();
                cm = new SqlCommand("select top 1 notrx From Penjualan where notrx like '" + sdate + "%' order by notrx desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    notrx = dr[0].ToString();
                    count = int.Parse(notrx.Substring(8, 4));
                    txtNotrx.Text = sdate + (count + 1);
                }
                else
                {
                    notrx = sdate + "1001";
                    txtNotrx.Text = notrx;
                    dr.Close();
                }
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            cariBrg frm = new cariBrg();

            frm.ShowDialog();
            txtKodeBrg.Text = frm.getKode;
            txtNamaBrg.Text = frm.getNama;
            txtStok.Text = frm.getStok;
            txtHarga.Text = frm.getHarga;
        }

        private void BtnCariPlg_Click(object sender, EventArgs e)
        {
            cariPlg frm = new cariPlg();

            frm.ShowDialog();
            txtkodeplg.Text = frm.getKode;
            txtNamaPlg.Text = frm.getNama;
        }
        public void  simpanPenjualan()
        {
            float harga = float.Parse(txtHarga.Text);
            int qty = int.Parse(txtQty.Text);
            float total = harga * qty;
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO Penjualan (notrx, tgl, kode_plg, kode_brg, harga, qty, total, id_user)VALUES('"+txtNotrx.Text+ "','" + txtTgl.Text + "','" + txtkodeplg.Text + "','" + txtKodeBrg.Text + "','" + txtHarga.Text + "','" + txtQty.Text + "','" +total + "','" + txtIdKasir.Text + "')",cn);
                cm.ExecuteNonQuery();
                cn.Close();
                loadBarang();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void SUbTotal()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select sum (harga*qty) from Penjualan where notrx='" + txtNotrx.Text + "'",cn);
                int result = (int)(decimal)cm.ExecuteScalar();
                txtTotal.Text = result.ToString();
                cn.Close();
             
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Data Barang Kosong");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void loadBarang()
        {

            try
            {
                dgvList.Rows.Clear();
                cn.Open();
                int i = 0;

                cm = new SqlCommand("select * from loadBarang where notrx like '" + txtNotrx.Text + "' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvList.Rows.Add(i, dr["id"].ToString(), dr["Barang"].ToString(), dr["Pelanggan"].ToString(), dr["harga"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["stok"].ToString(), dr["kode_brg"].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text=="")
            {
                txtQty.Text = "1";
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (txtNamaBrg.Text.Trim()=="" || txtKodeBrg.Text.Trim() == "" || txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Input data belum lengkap");
            }
            else
            {
                simpanPenjualan();
                SUbTotal();
            }
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvList.Columns[e.ColumnIndex].Name;
            if (colname == "Tambah")
            {
                cn.Open();
                cm = new SqlCommand("update Penjualan set qty=(qty+1) where id='" + dgvList[1, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();


                cm = new SqlCommand("update Barang set stok=(stok-1) where kode_brg='" + dgvList[8, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();



                cn.Close();
                loadBarang();
                SUbTotal();
            }
            else if (colname == "Kurang")
            {
                cn.Open();
                cm = new SqlCommand("update Penjualan set qty=(qty-1) where id='" + dgvList[1, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();


                cm = new SqlCommand("update Barang set stok=(stok+1) where kode_brg='" + dgvList[8, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();



                cn.Close();
                loadBarang();
                SUbTotal();
            }
            else if (colname == "Hapus")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("delete from  Penjualan  where id='" + dgvList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    loadBarang();
                    SUbTotal();
                    cn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtTunai_TextChanged(object sender, EventArgs e)
        {
            if (txtTunai.Text=="")
            {
                txtTunai.Text = "0";
            }
            int total = int.Parse(txtTotal.Text);
            int tunai = int.Parse(txtTunai.Text);
            int kembali = tunai - total;
            txtKembali.Text = kembali.ToString();
        }

        public void simpanDetail()
        {

            try
            {
                cn.Open();
                cm = new SqlCommand("insert into DetailPenjualan values('" + txtNotrx.Text + "', '" + txtTotal.Text + "','" + txtTunai.Text + "','" + txtKembali.Text + "') ", cn);
                cm.ExecuteNonQuery();

                cn.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                
            int total = int.Parse(txtTotal.Text);
            int tunai = int.Parse(txtTunai.Text);
            int kembali = tunai - total;
            if (tunai<total)
            {
                MessageBox.Show("Pembayaran tidak mecukupi");
            }
            else
            {
                simpanDetail();
                frmCetak frm = new frmCetak(txtNotrx.Text);
                frm.ShowDialog();
            }
        }
    }
}
