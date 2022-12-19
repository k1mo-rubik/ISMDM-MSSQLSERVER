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
        public static Form1 form1;
        //public static ClientForm clientForm;
        public static LoginForm loginForm;

        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainMenu = new MainMenu();
            Program.form1 = new Form1();
            Program.loginForm = new LoginForm();
            //Program.clientForm = new ClientForm();
            Application.Run(Program.form1);
            //Application.Run(mainMenu);
        }
    }
}


//public static Form2 Form2;
//Program.Form2 = new Form2();
//Program.Form2.Show();