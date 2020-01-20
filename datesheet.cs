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
    public partial class datesheet : Form
    {
        MySqlConnection connnection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        public datesheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MIT();
        }
        public void MIT()
        {
            try
            {
                Form f1 = new Form();
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM date_sheet", connnection);
                DataTable dbtl = new DataTable();
                sqld.Fill(dbtl);

                dgv1.DataSource = dbtl;
                connnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    private void button3_Click(object sender, EventArgs e)
        {
            MCS();
        }
        public void MCS()
        {
            try
            {
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM mcs", connnection);
                DataTable dbtl = new DataTable();
                sqld.Fill(dbtl);

                dgv1.DataSource = dbtl;
                connnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MBF();
        }
        public void MBF()
        {
            try
            {
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM mbf", connnection);
                DataTable dbtl = new DataTable();
                sqld.Fill(dbtl);

                dgv1.DataSource = dbtl;
                connnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
