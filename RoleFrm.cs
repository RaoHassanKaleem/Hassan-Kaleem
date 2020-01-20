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
    public partial class RoleFrm : frmParent
    {
        public RoleFrm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoleDetailFrm sysUser = new RoleDetailFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }

        private void RoleFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            base.SetDataGridViewStyle(dataGridView1);

            fetchAllData();
        }

        private void fetchAllData()

        {
            DataTable dt = new DataTable();
            dt = ConverListToDT.ToDataTable(ApplicationEntity.oRole);
            dataGridView1.DataSource = dt;
        }
    }
}
