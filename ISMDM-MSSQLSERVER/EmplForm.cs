using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDM_MSSQLSERVER
{
    public partial class EmplForm : Form
    {
        public EmplForm()
        {
            InitializeComponent();
        }

        private void EmplForm_Load(object sender, EventArgs e)
        {
            this.pn_empl.Controls.Clear();


            foreach (Employee employee in Program.mainMenu.empList)
            {

                var currForm = new Form();
                currForm = new Item(employee) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                currForm.Dock = DockStyle.Top;

                currForm.FormBorderStyle = FormBorderStyle.None;
                this.pn_empl.Controls.Add(currForm);
                currForm.Show();



            }
        }
    }
}
