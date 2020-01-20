using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniManagmentSystem_UMT.Clases;

namespace UniManagmentSystem_UMT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Resultt r1 = new Resultt();
            Student s1 = new Student();
            s1.Add(r1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<SystemUser> objSystemUser = new List<SystemUser>();
            List<Modules> objModele = new List<Modules>();

            List<Role> oRole = new List<Role>();
            List<RoleModule> oRoleModule = new List<RoleModule>();



            ApplicationEntity.objSystemUser = objSystemUser;
            ApplicationEntity.objModele = objModele;

            ApplicationEntity.oRole = oRole;
            ApplicationEntity.oRoleModule = oRoleModule;
            
           Application.Run(new MainFrm());
            //Application.Run(new Adminastrator());

        }
    }
}
