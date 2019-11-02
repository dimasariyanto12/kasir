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
    public partial class tmbBarang : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        frmBarang form;
        public tmbBarang(frmBarang frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            form = frm;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TmbBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suplierDataSet.Suplier' table. You can move, or remove it, as needed.
            this.suplierTableAdapter.Fill(this.suplierDataSet.Suplier);

        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtKode.Text.Trim() == "" || cmbSuplier.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "" || txtHrgBeli.Text.Trim() == "" || txtHrgJual.Text.Trim() == "" || txtStok.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("update  Barang set nama='" + txtNama.Text + "',deskripsi='" + txtDeskripsi.Text + "',stok='" + txtStok.Text + "',hrg_beli='" + txtHrgBeli.Text + "',hrg_jual='" + txtHrgJual.Text + "',id_suplier='" + cmbSuplier.SelectedValue+ "' where id ='"+lblId.Text+"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    this.Dispose();
                    form.load();
                    form.lblSukses.Visible = true;
                    form.lblUbah.Visible = false;
                    form.lblHapus.Visible = false;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtKode.Text.Trim() == "" || cmbSuplier.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "" || txtHrgBeli.Text.Trim() == "" || txtHrgJual.Text.Trim() == "" || txtStok.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Barang values('" + txtKode.Text + "','" + txtNama.Text + "','" + txtDeskripsi.Text + "','" + txtStok.Text + "','" + txtHrgBeli.Text + "','" + txtHrgJual.Text + "','" + cmbSuplier.SelectedValue + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    this.Dispose();
                    form.load();
                    form.lblSukses.Visible = true;
                    form.lblUbah.Visible = false;
                    form.lblHapus.Visible = false;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
