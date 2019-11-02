using Microsoft.Reporting.WinForms;
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
    public partial class frmCetak : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        private string notrxText;
        public frmCetak( String notrx)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            notrxText = notrx;
            cetak();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
           
        }

        public cetak getData()
        {
            cn.Open();
            cm = new SqlCommand("select * from vw_cetak where notrx='" + notrxText + "' ", cn);
            da = new SqlDataAdapter(cm);
            cetak ds = new cetak();
            da.Fill(ds, "vw_cetak");
            return ds;
        }
        public void cetak()
        {
            cetak ds = getData();
            ReportDataSource dataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.dgvCetak.LocalReport.DataSources.Clear();
            this.dgvCetak.LocalReport.DataSources.Add(dataSource);
            this.dgvCetak.RefreshReport();
        }
        private void FrmCetak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cetak1.vw_cetak' table. You can move, or remove it, as needed.
            this.vw_cetakTableAdapter.Fill(this.cetak1.vw_cetak);
            // TODO: This line of code loads data into the 'cetak.vw_cetak' table. You can move, or remove it, as needed.

        }

        private void DgvCetak_Load(object sender, EventArgs e)
        {

        }
    }
}
