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
    public partial class tmbPelanggan : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        frmPelanggan form;
        public tmbPelanggan(frmPelanggan frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            form = frm;
            autonumber();
        }

        public void autonumber()
        {
            long hitung;
            string urut;

            cn.Open();
            cm = new SqlCommand("select kode_plg from Pelanggan where kode_plg in(select max(kode_plg) from Pelanggan)order by kode_plg desc ",cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["kode_plg"].ToString().Length-4,4))+1;
                string joinstr = "0000" + hitung;
              urut = "P"+ joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "P0001";
            }
            dr.Close();
            txtKode.Text = urut;

            cn.Close();
        }
        private void TxtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==46)
            {

            }
            else if (e.KeyChar==8)
            {

            }
            else if ((e.KeyChar<48)||(e.KeyChar>57))
            {
                e.Handled = true;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtTelp.Text.Trim() == "" || cmbGender.Text.Trim() == "" || txtAlamat.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Pelanggan values('" + txtKode.Text + "','" + txtNama.Text + "','" + cmbGender.Text + "','" + txtTelp.Text + "','" + txtAlamat.Text + "')", cn);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtTelp.Text.Trim() == "" || cmbGender.Text.Trim() == "" || txtAlamat.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("update  Pelanggan set kode='" + txtKode.Text + "',nama='" + txtNama.Text + "',gender='" + cmbGender.Text + "',telp='" + txtTelp.Text + "',alamat='" + txtAlamat.Text + "' where id ='"+lblId.Text+"' ", cn);
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

        private void TmbPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
