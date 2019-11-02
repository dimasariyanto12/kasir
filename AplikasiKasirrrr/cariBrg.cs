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
    public partial class cariBrg : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        private string kodebrg, namabrg, stokbrg , hargabrg = "";
        public cariBrg()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
        }

        private void CariBrg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barangDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.barangDataSet.Barang);

        }
        public String getKode
        {
            get
            {
                return kodebrg;
            }
        }
        public String getNama
        {
            get
            {
                return namabrg;
            }
        }
        public String getStok
        {
            get
            {
                return stokbrg;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public String getHarga
        {
            get
            {
                return hargabrg;
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv.Columns[e.ColumnIndex].Name;
            if (colName == "Pilih")
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                kodebrg = row.Cells["kode"].Value.ToString();
                namabrg = row.Cells["nama"].Value.ToString();
                stokbrg = row.Cells["stok"].Value.ToString();
                hargabrg = row.Cells["harga"].Value.ToString();
                this.Dispose();
            }
        }

       

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Barang where nama like '%" + txtCari.Text + "%' or  kode_brg like '%" + txtCari.Text + "%'", cn);
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
