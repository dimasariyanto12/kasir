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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MYConnection());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
              if (txtPassword.Text.Trim()==""|| txtPassword.Text.Trim() == "")
            {
                lblBlengkap.Visible = true;
                lblGagal.Visible = false;
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("select * from Users where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", cn);
                SqlDataReader reader = null;
               reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nama = reader.GetString(1);
                    string role = reader.GetString(4);
                    if (role=="Admin")
                    {
                        this.Hide();
                        Admin frm = new Admin();
                        frm.idUser.Text = id.ToString();
                        frm.namaUser.Text = nama.ToString();
                        frm.ShowDialog();
                    }
                    else if (role=="Kasir")
                    {
                        Kasir frm = new Kasir();
                        frm.idUser.Text = id.ToString();
                        frm.namaUser.Text = nama.ToString();
                        frm.ShowDialog();
                    }

                }
                else
                {
                    lblBlengkap.Visible = false;
                    lblGagal.Visible = true; 
                    Clear();
                }


                cn.Close();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi kasir?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else{

            }
        }
    }
}
