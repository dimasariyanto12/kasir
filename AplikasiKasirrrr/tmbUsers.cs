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
    public partial class tmbUsers : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        frmUser form;
        public tmbUsers(frmUser frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            form = frm;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim()=="" || txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cmbRole.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Users values('" + txtNama.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbRole.Text + "')", cn);
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

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cmbRole.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {

                try
                {
                    cn.Open();
                    cm = new SqlCommand("update  Users set nama='" + txtNama.Text + "',username='" + txtUsername.Text + "',password='" + txtPassword.Text + "',role='" + cmbRole.Text + "' where id='"+lblId.Text+"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    this.Dispose();
                    form.load();
                    form.lblSukses.Visible = false;
                    form.lblUbah.Visible = true;
                    form.lblHapus.Visible = false;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TmbUsers_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
