using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ISMDM_MSSQLSERVER.Classes;

namespace ISMDM_MSSQLSERVER
{
    public partial class LoginForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //    );


        string login;
        string password;
        
        public LoginForm()
        {
            
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetRoundedShape(pn_login, 25);
            SetRoundedShape(this, 25);
            SetRoundedShape(button1, 25);
        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account acc = Program.mainForm.accRepo.LoginAccount(login, password);
            if (acc != null)
            {
                if (acc.Код_группы == 1)
                {
                    this.Hide();
                    Program.mainForm.Show();
                }
                else if (acc.Код_группы == 0)
                {
                    this.Hide();
                    Program.mainForm.Show();
                    Program.adminForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            login = tb_login.Text;
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            password = tb_pass.Text;
        }
    }
}
