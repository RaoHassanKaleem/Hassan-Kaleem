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
    public partial class ModuleFrm : frmParent
    {
        public ModuleFrm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void ModuleFrm_Load(object sender, EventArgs e)
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

        private void btnFetech_Click(object sender, EventArgs e)
        {
            fetchAllData(); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModuleDetailFrm sysUser = new ModuleDetailFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }
    }
}
