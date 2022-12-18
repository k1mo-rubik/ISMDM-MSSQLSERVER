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
    public partial class ItemReserv : Form
    {
        Client client;
        int reservId =-1;

        Employee employee;
        public ItemReserv()
        {
            InitializeComponent();
        }

        public ItemReserv(string clientFIO, string employeeFIO, string service, string date, int reservId)
        {
            InitializeComponent();
            this.reservId = reservId;
            l_client.Text = clientFIO;
            l_emp.Text = employeeFIO;
            l_service.Text = service;
            l_date.Text = date;
        }

        private void ItemReserv_Load(object sender, EventArgs e)
        {

        }

        private void ItemReserv_Click(object sender, EventArgs e)
        {
            if (this.reservId != -1)
            {
                Program.mainMenu.mmConfigureReserv(this.reservId);
            }
        }
    }
}
