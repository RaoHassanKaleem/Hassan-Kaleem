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
    public partial class MainFrm : frmParent
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tspInbox_Click(object sender, EventArgs e)
        {
            ModuleFrm sysUser = new ModuleFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }

        private void tspBtnSupervisor_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.StartPosition = FormStartPosition.CenterParent;
            l1.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SystemUserFrm sysUser = new SystemUserFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            RoleFrm sysUser = new RoleFrm();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }

        private void tspBtnDiscrep_Click(object sender, EventArgs e)
        {
            FacultyLogin sysUser = new FacultyLogin();
            sysUser.StartPosition = FormStartPosition.CenterParent;
            sysUser.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentsFrm S1 = new StudentsFrm();
            S1.StartPosition = FormStartPosition.CenterParent;
            S1.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Admin e1 = new Admin();
            e1.StartPosition = FormStartPosition.CenterParent;
            e1.ShowDialog();
        }

      
    }
}
