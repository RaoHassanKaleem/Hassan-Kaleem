﻿using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
        public void login()
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            MySqlConnection connnection = new MySqlConnection("server = localhost; uid=root; database=umt");
            connnection.Open();
            MySqlDataAdapter sqld = new MySqlDataAdapter("select count(*) from system_users where Username ='" + textBox1.Text + "' and password ='" + textBox2.Text + "' ", connnection);
            DataTable dbt1 = new DataTable();
            sqld.Fill(dbt1);
            try
            {
                if (dbt1.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Username and Password Matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Adminastrator a1 = new Adminastrator();
                    a1.StartPosition = FormStartPosition.CenterParent;
                    a1.ShowDialog();
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
