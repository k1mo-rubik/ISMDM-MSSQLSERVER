using ISMDM_MSSQLSERVER.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDM_MSSQLSERVER
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        /// 
        public static MainMenu mainMenu;
        public static MainForm mainForm;
        public static AdminForm adminForm;
        //public static ClientForm clientForm;
        public static LoginForm loginForm;

        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainMenu = new MainMenu();
            
            Program.mainForm = new MainForm();
            Program.adminForm = new AdminForm();
            Program.loginForm = new LoginForm();
            
            //Program.clientForm = new ClientForm();
            Application.Run(Program.adminForm);
            //Application.Run(mainMenu);
        }
    }
}


//public static Form2 Form2;
//Program.Form2 = new Form2();
//Program.Form2.Show();