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
    public partial class frmLaporan : Form
    {
        public frmLaporan()
        {
            InitializeComponent();
            this.LaporanBarangTableAdapter.Fill(this.kasirrrDataSet.LaporanBarang);
            this.Vw_penjualanTableAdapter.Fill(this.kasirrrDataSet1.Vw_penjualan);

        }

        private void FrmLaporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kasirrrDataSet1.Vw_penjualan' table. You can move, or remove it, as needed.
            this.Vw_penjualanTableAdapter.Fill(this.kasirrrDataSet1.Vw_penjualan);
            // TODO: Thiss line of code loads data into the 'kasirrrDataSet.LaporanBarang' table. You can move, or remove it, as needed.
            this.LaporanBarangTableAdapter.Fill(this.kasirrrDataSet.LaporanBarang);
            // TODO: This line of code loads data into the 'lprnBarangDataSet.LaporanBarang' table. You can move, or remove it, as needed.

        }
    }
}
