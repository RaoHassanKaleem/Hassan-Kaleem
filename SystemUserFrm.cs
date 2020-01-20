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
    public partial class SystemUserFrm : frmParent
    {
        public SystemUserFrm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SystemUserFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            base.SetDataGridViewStyle(dataGridView1);

            fetchAllData(); 
        }

        private void fetchAllData()

        {
            

            DataTable dt = new DataTable();
            dt = ConverListToDT.ToDataTable(ApplicationEntity.objSystemUser); 
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchAllData(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemUserDetailFrm sysUser = new SystemUserDetailFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }
    }
}
