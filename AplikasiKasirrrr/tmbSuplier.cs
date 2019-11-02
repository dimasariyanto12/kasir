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
    public partial class tmbSuplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        frmSuplier form;
        public tmbSuplier(frmSuplier frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            form = frm;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtTelp.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtWebsite.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("update  Suplier set nama='" + txtNama.Text + "',telp='" + txtTelp.Text + "',email='" + txtEmail.Text + "',website='" + txtWebsite.Text + "',alamat='" + txtAlamat.Text + "' where id='"+lblId.Text+"'", cn);
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

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtTelp.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtWebsite.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Suplier values('" + txtNama.Text + "','" + txtTelp.Text + "','" + txtEmail.Text + "','" + txtWebsite.Text + "','" + txtAlamat.Text + "')", cn);
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
