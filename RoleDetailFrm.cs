using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniManagmentSystem_UMT.Clases;
using UniManagmentSystem_UMT.Helper;

namespace UniManagmentSystem_UMT
{
    public partial class RoleDetailFrm : frmParent
    {
        public RoleDetailFrm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
             string role;
             Role obj = new Role();
            obj.RoleId = UniqeId.UniqeIdInc + 1;
            obj.RoleName = this.textBox1.Text;
            ApplicationEntity.oRole.Add(obj);
            role = this.textBox1.Text;
            SystemUserDetailFrm s1 = new SystemUserDetailFrm();
            MessageBox.Show("Data saved", "Data");
        }

        private void RoleDetailFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            base.SetDataGridViewStyle(dataGridView1);

            fetchAllData();
        }

        private void fetchAllData()

        {
            DataTable dt = new DataTable();
            dt = ConverListToDT.ToDataTable(ApplicationEntity.objModele);
            dataGridView1.DataSource = dt;
        }
    }
}
