using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    class DataBase
    {
        // String strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }

    }
}
