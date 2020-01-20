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
    public partial class marksentry : Form
    {
        public marksentry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marks();
        }
        public void marks()
        {
           
            
            Clases.Resultt r1 = new Clases.Resultt();
            r1.id = int.Parse(textBox4.Text);
            r1.subject = textBox1.Text;
            r1.testScore = int.Parse(textBox2.Text);

            MySqlConnection connection = new MySqlConnection("server = localhost; uid=root; database=umt");
            string insert = "INSERT INTO marks(ID,Subject_Name,Marks) VALUES('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Saved");
                    r1.gradecalculation();
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

