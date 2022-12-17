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
    public partial class ClientForm : Form
    {
     
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            this.pn_client.Controls.Clear();


            foreach (Client client in Program.mainMenu.clientList)
            {
               
                var currForm = new Form();
                currForm = new Item(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                currForm.Dock = DockStyle.Top;

                currForm.FormBorderStyle = FormBorderStyle.None;
                this.pn_client.Controls.Add(currForm);
                currForm.Show();



            }
         

        }

     
    }
}
