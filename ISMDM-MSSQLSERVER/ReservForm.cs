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
    public partial class ReservForm : Form
    {
        public ReservForm()
        {
            InitializeComponent();
        }
        ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
        ClientRepo clientRepo = Program.mainMenu.clientRepo;
        EmployeeRepo employeeRepo = Program.mainMenu.employeeRepo;
        SpecializationRepo specializationRepo = Program.mainMenu.specializationRepo;
        ServiceSpecRepo servicesSpecRepo = Program.mainMenu.serviceSpecRepo;
        ServiceRepo serviceRepo = Program.mainMenu.serviceRepo;

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void ReservForm_Load(object sender, EventArgs e)
        {
            this.pnl_resItems.Controls.Clear();
            
            foreach (Reserve reserve in Program.mainMenu.reserveList)
            {
                string clientFIO = clientRepo.GetClientsFIOById(reserve.Код_клиента);
                string employeeFIO = employeeRepo.GetEmployeesFIOById(reserve.Код_сотрудника);
                string serviceName = serviceRepo.GetServiceName(reserve.Код_услуги);
                string time = reserve.Дата_время_записи;

                var currForm = new Form();
                currForm = new ItemReserv(clientFIO, employeeFIO, serviceName, time, reserve.Код_записи) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                currForm.Dock = DockStyle.Top;

                currForm.FormBorderStyle = FormBorderStyle.None;
                this.pnl_resItems.Controls.Add(currForm);
                currForm.Show();

            }


        }
    }
}
