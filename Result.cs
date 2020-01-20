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

namespace UniManagmentSystem_UMT
{
    public partial class Result : Form
    {
        MySqlConnection connnection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        public Result()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            search();
            Clases.Resultt n = new Clases.Resultt();
            n.gradecalculation();
        }
        public void search()
        {
            try
            {
                
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM grade where ID =('" + textBox1.Text + "') ", connnection);
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
    }
}
