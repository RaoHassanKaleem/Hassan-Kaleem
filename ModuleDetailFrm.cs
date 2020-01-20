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
    public partial class ModuleDetailFrm : frmParent
    {
        public ModuleDetailFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modules obj = new Modules();
            obj.ModuleId = UniqeId.UniqeIdInc + 1;
            obj.ModuleName = this.textBox1.Text;
            ApplicationEntity.objModele.Add(obj);
            MessageBox.Show("Data saved", "Data");
        }
    }
}
