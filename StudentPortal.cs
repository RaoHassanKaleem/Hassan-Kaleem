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
    public partial class StudentPortal : Form
    {

        public StudentPortal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datesheet d1 = new datesheet();
            d1.StartPosition = FormStartPosition.CenterParent;
            d1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.StartPosition = new FormStartPosition();
            r.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection connnection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
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
    }
}
