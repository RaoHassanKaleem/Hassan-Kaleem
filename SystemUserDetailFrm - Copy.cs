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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Configuration;

namespace UniManagmentSystem_UMT
{
    public partial class SystemUserDetailFrm : frmParent
    {
      
        public SystemUserDetailFrm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemUser obj = new SystemUser();
            obj.SysUserId = UniqeId.UniqeIdInc+1;
            obj.UserName = this.txtUserName.Text;
            obj.Password = this.txtUserName.Text;
            obj.PersonName = this.txtUserName.Text;
            obj.Addres = this.txtUserName.Text;
            ApplicationEntity.objSystemUser.Add(obj);
            MessageBox.Show("Data saved", "Data");
            insert();
        }

        private void SystemUserDetailFrm_Load(object sender, EventArgs e)
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

      
        public void insert()
        {
            Role r = new Role();
            string role;
            RoleDetailFrm r1 = new RoleDetailFrm();
            role = r.RoleName;
            MySqlConnection connection = new MySqlConnection("server = localhost; uid=root; database=umt");
            string insert = "INSERT INTO system_users(Name,Username,Password,Address,Role) VALUES('" + txtName.Text + "','" + txtUserName.Text + "','" + txtPass.Text + "','" + txtAddress.Text + "','" + r.RoleName + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            connection.Close();
        }
    }
}
