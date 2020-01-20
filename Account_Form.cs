using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniManagmentSystem_UMT
{
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Salary s = new Clases.Salary();
            s.id = int.Parse(textBox1.Text);
            s.name =textBox2.Text;
            s.salary = int.Parse(textBox1.Text);
            s.daywaorked = int.Parse(textBox1.Text);
            s.calculatesalary();
        }
    }
}
