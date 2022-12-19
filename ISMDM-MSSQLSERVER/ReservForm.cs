using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISMDM_MSSQLSERVER.ConfigPersonForm;

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

            foreach (var employee in employeeRepo.empList)
            {
                comboBox1.Items.Add(new ComboBoxItem(employee.Фамилия + " " + employee.Имя + " " + employee.Отчество, employee.Код_сотрудника));
            }
            foreach (var client in clientRepo.clientList)
            {
                comboBox2.Items.Add(new ComboBoxItem(client.Фамилия + " " + client.Имя + " " + client.Отчество, client.Код_клиента));
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // фильтрация ItemReserv по выбранному сотруднику
            this.pnl_resItems.Controls.Clear();
            foreach (Reserve reserve in Program.mainMenu.reserveList)
            {
                string clientFIO = clientRepo.GetClientsFIOById(reserve.Код_клиента);
                string employeeFIO = employeeRepo.GetEmployeesFIOById(reserve.Код_сотрудника);
                string serviceName = serviceRepo.GetServiceName(reserve.Код_услуги);
                string time = reserve.Дата_время_записи;

                if (employeeFIO == comboBox1.SelectedItem.ToString())
                {
                    var currForm = new Form();
                    currForm = new ItemReserv(clientFIO, employeeFIO, serviceName, time, reserve.Код_записи) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                    currForm.Dock = DockStyle.Top;

                    currForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnl_resItems.Controls.Add(currForm);
                    currForm.Show();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnl_resItems.Controls.Clear();
            foreach (Reserve reserve in Program.mainMenu.reserveList)
            {
                string clientFIO = clientRepo.GetClientsFIOById(reserve.Код_клиента);
                string employeeFIO = employeeRepo.GetEmployeesFIOById(reserve.Код_сотрудника);
                string serviceName = serviceRepo.GetServiceName(reserve.Код_услуги);
                string time = reserve.Дата_время_записи;

                if (clientFIO == comboBox2.SelectedItem.ToString())
                {
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
}
