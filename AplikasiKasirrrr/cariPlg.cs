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
    public partial class cariPlg : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        private string kodeplg, namaplg = "";
        public cariPlg()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            this.pelangganTableAdapter.Fill(this.pelangganDataSet.Pelanggan);
        }
        public String getKode
        {
            get
            {
                return kodeplg;
            }
        }
        public String getNama
        {
            get
            {
                return namaplg;
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv.Columns[e.ColumnIndex].Name;
            if (colName == "Pilih")
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                kodeplg = row.Cells["kode"].Value.ToString();
                namaplg = row.Cells["nama"].Value.ToString();
                this.Dispose();
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Pelanggan where nama like '%" + txtCari.Text + "%'", cn);
                da = new SqlDataAdapter(cm);
                ds = new DataSet();
                da.Fill(ds, "Pelanggan");
                dgv.DataSource = ds;
                dgv.DataMember = "Pelanggan";
                dgv.Refresh();
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

        private void CariPlg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pelangganDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.pelangganDataSet.Pelanggan);

        }
    }
}
