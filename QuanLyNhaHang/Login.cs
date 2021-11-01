using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Login : Form
    {
        String strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        System.Data.SqlClient.SqlConnection sqlCon = null;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            SqlCommand cmd = new SqlCommand("Select dbo.PhanQuyenChinh('" + username + "', '" + password + "')", sqlCon);

            var result = cmd.ExecuteScalar();

            if (result.ToString().Trim() == "1")
            {
                MessageBox.Show("Admin");
                QuanLyForm re = new QuanLyForm();
                re.Show();
            }
            else
            {
                MessageBox.Show("Nhan Vien");
            }
        }

    }
}
