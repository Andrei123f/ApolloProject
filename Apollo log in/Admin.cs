using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apollo_log_in
{
    public partial class Admin : Form
    {
        private Form1 mainform;
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder bd;
        private DataTable tbl;
        public Admin(Form1 form)
        {
            InitializeComponent();
            mainform = form;
            getGrid();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }

        private void getGrid()
        {
            conn = new MySqlConnection(Properties.Settings.Default.mysqlcsharpConnectionString);
            adapter = new MySqlDataAdapter("SELECT * FROM users", conn);
            bd = new MySqlCommandBuilder(adapter);
            tbl = new DataTable();
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adapter.Update(tbl);
        }
    }
}
