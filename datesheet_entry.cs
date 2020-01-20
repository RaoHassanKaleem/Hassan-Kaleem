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
    public partial class datesheet_entry : Form
    {
        public datesheet_entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Date_sheet d1 = new Clases.Date_sheet();
            d1.course = textBox1.Text;
            d1.date = int.Parse(textBox2.Text);
            d1.time = int.Parse(textBox2.Text);
            d1.clas = int.Parse(textBox2.Text);
            d1.sec = textBox2.Text;
            d1.MBF();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Date_sheet d1 = new Clases.Date_sheet();
            d1.course = textBox1.Text;
            d1.date = int.Parse(textBox2.Text);
            d1.time = int.Parse(textBox2.Text);
            d1.clas = int.Parse(textBox2.Text);
            d1.sec = textBox2.Text;
            d1.MIT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.Date_sheet d1 = new Clases.Date_sheet();
            d1.course = textBox1.Text;
            d1.date = int.Parse(textBox2.Text);
            d1.time = int.Parse(textBox2.Text);
            d1.clas = int.Parse(textBox2.Text);
            d1.sec = textBox2.Text;
            d1.MCS();
        }
    }
}
