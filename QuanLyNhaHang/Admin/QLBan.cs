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
    public partial class QLBan : Form
    {
        public QLBan()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void QLBan_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From dbo.Ban", db.GetConnection);

            // execute the command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //dt.Load(rdr);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
