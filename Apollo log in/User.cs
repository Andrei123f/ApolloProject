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
    public partial class User : Form
    {
        private Form1 mainform;
        public User(Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = mysqlcsharp");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from pizza", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            label1.Text = "Aveti " + dt.Rows.Count.ToString() + " tipuri de pizza";
        }
    }
}
