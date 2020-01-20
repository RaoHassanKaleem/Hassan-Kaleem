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
    public partial class StudentsFrm : frmParent
    {
        MySqlConnection connnection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        public StudentsFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentDetailFrm s1 = new StudentDetailFrm();
            s1.StartPosition = FormStartPosition.CenterParent;
            s1.ShowDialog();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Fetch();
        }
        public void Fetch()
        {
            try
            {
                
                connnection.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM student_data where ID=('"+textBox1.Text+"')", connnection);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
