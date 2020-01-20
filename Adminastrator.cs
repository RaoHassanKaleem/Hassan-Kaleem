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
    public partial class Adminastrator : Form
    {
        public Adminastrator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rooms r1 = new Rooms();
            r1.StartPosition = FormStartPosition.CenterParent;
            r1.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datesheet_entry d1 = new datesheet_entry();
            d1.StartPosition= FormStartPosition.CenterParent;
            d1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facultydetails f1 = new facultydetails();
            f1.StartPosition= FormStartPosition.CenterParent;
            f1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Account_Form a1 = new Account_Form();

            a1.StartPosition = FormStartPosition.CenterParent;
            a1.ShowDialog();
        }
    }
}
