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
    public partial class facultydetails : Form
    {
        public facultydetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }
        public void Add()
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; uid=root; database=umt");
            string insert = "INSERT INTO faculty(Name,Subject,Password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            connection.Close();
        }
    }
}
