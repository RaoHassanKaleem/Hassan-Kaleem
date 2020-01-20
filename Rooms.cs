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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Room r1 = new Clases.Room();
            r1.subject = textBox1.Text;
            r1.room = int.Parse(textBox2.Text);
            r1.time = int.Parse(textBox3.Text);
        }
    }
}
