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
    public partial class CetakStruk : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        private string notrxText;
        public CetakStruk(String notrx)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            notrxText = notrx;
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
     
        private void CetakStruk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cetak.vw_cetak' table. You can move, or remove it, as needed.
         

        }
    }
}
