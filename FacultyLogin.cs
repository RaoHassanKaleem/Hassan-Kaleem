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
using System.Data.SqlClient;
using System.Configuration;

namespace UniManagmentSystem_UMT
{
    public partial class FacultyLogin : Form
    {
        public FacultyLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        public void Login()
        {
            
            MySqlConnection connnection = new MySqlConnection("server = localhost; uid=root; database=umt");
            connnection.Open();
            MySqlDataAdapter sqld = new MySqlDataAdapter("select count(*) FROM faculty where Name ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "' ", connnection);
            DataTable dbt1 = new DataTable();
            sqld.Fill(dbt1);
            try
            {
                if (dbt1.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Username and Password Matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Faculty sysUser = new Faculty();
                    sysUser.StartPosition = FormStartPosition.CenterParent;
                    sysUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username and Password Not Matched", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            connnection.Close();
        }
    }
}
