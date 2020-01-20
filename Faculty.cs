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
    public partial class Faculty : frmParent
    {
        MySqlConnection connnection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        public Faculty()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            fetch();
        }
        public void fetch()
        {
            try
            {
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM rooms", connnection);
                DataTable dbtl = new DataTable();
                sqld.Fill(dbtl);

                dataGridView1.DataSource = dbtl;
                connnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM account where ID =('" + textBox1.Text + "') ", connnection);
                DataTable dbt1 = new DataTable();
                sqld.Fill(dbt1);

                dataGridView1.DataSource = dbt1;
                connnection.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marksentry m1 = new marksentry();
            m1.StartPosition = FormStartPosition.CenterParent;
            m1.ShowDialog();
        }
    }
}
