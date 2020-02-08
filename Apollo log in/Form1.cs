using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apollo_log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = mysqlcsharp");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from users where username = '" +txtuser.Text + "' and password = '" +txtpass.Text + "'", conn);
               
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(dt.Rows[0]["is_admin"].ToString());
                if(dt.Rows[0]["is_admin"].ToString() == "True")
                {
                    Hide();
                    Admin newform = new Admin(this);
                    newform.Show();
                }
                else
                {
                    User userform = new User(this);
                    Hide();
                    userform.Show();
                }
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
