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
    public partial class frmUser : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DBConnection dbcon = new DBConnection();
        public frmUser()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
            load();
        }

        public void load()
        {
            this.usersTableAdapter.Fill(this.usersDataSet.Users);
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Users where nama like '%" + txtCari.Text + "%'", cn);
                da = new SqlDataAdapter(cm);
                ds = new DataSet();
                da.Fill(ds, "Users");
                dgv.DataSource = ds;
                dgv.DataMember = "Users";
                dgv.Refresh();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            tmbUsers frm = new tmbUsers(this);
            frm.btnUbah.Visible = false;
            frm.ShowDialog();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv.Columns[e.ColumnIndex].Name;
            if (colName=="Ubah")
            {
                tmbUsers frm = new tmbUsers(this);
                frm.lblJudul.Text = "Ubah Data User";
                frm.btnSimpan.Visible = false;
                frm.lblId.Text = dgv[0, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgv[1, e.RowIndex].Value.ToString();
                frm.txtUsername.Text = dgv[2, e.RowIndex].Value.ToString();
                frm.txtPassword.Text = dgv[3, e.RowIndex].Value.ToString();
                frm.cmbRole.Text = dgv[4, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName=="Hapus")
            {
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    cn.Open();
                    cm = new SqlCommand("delete from Users where id ='" + dgv[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    load();
                    lblSukses.Visible = false;
                    lblUbah.Visible = false;
                    lblHapus.Visible = true;
                }

            }
        }
    }
}
