using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {
        String strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        System.Data.SqlClient.SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("Select * From f_CMaxMua()", sqlCon);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            //cmd.Parameters.Add(new SqlParameter("@idUser", "CLi5"));

            // execute the command
            SqlDataReader rdr = cmd.ExecuteReader();

            // iterate through results, printing each to conso
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1.  create a command object identifying
            //     the stored procedure
            //SqlCommand command = new SqlCommand("Select f_CMaxMua()");
            SqlCommand cmd = new SqlCommand("Select * from dbo.f_CMaxMua()", sqlCon);

            // 2. set the command object so it knows
            //    to execute a stored procedure


            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            //cmd.Parameters.Add(new SqlParameter("@idUser", "CLi5"));

            // execute the command
            SqlDataReader rdr = cmd.ExecuteReader();

            // iterate through results, printing each to conso
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("Select dbo.PhanQuyenChinh('" + username + "', '" + password + "')", sqlCon);

            var result = cmd.ExecuteScalar();
            MessageBox.Show(result.ToString());


            // 2. set the command object so it knows
            //    to execute a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            //cmd.Parameters.Add(new SqlParameter("@username", "VanTuan"));

            // execute the command
            //SqlDataReader rdr = cmd.ExecuteReader();

            // iterate through results, printing each to conso
            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //dataGridView1.DataSource = dt;
            if (result.ToString().Trim() == "1")
            {
                Login re = new Login();
                re.Show();
            }
            else
            {
                MessageBox.Show("aaaaa");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
