using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class QuanLyForm : Form
    {
        public QuanLyForm()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void buttonQLBan_Click(object sender, EventArgs e)
        {
            QLBan re = new QLBan();
            re.Show();
        }
    }
}
