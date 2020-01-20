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
    public partial class StudentDetailFrm : frmParent
    {
        public StudentDetailFrm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clases.Student s = new Clases.Student();
            s.id = int.Parse(textBox6.Text);
            s.contact = int.Parse(textBox3.Text);
            s.cnic = int.Parse(textBox5.Text);
            s.name = textBox1.Text;
            s.program = textBox4.Text;
            s.fname = textBox2.Text;
            Clases.Resultt r1 = new Clases.Resultt();
            s.Add(r1);
           
        }
       
          
        }
    }

