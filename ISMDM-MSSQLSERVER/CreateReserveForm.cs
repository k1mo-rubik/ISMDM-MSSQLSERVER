using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISMDM_MSSQLSERVER.ConfigPersonForm;

namespace ISMDM_MSSQLSERVER
{
    public partial class CreateReserveForm : Form
    {
        Reserve reserve;
 
        ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
        ClientRepo clientRepo = Program.mainMenu.clientRepo;
        EmployeeRepo employeeRepo = Program.mainMenu.employeeRepo;
        SpecializationRepo specializationRepo = Program.mainMenu.specializationRepo;
        ServiceSpecRepo servicesSpecRepo = Program.mainMenu.serviceSpecRepo;
        ServiceRepo serviceRepo = Program.mainMenu.serviceRepo;
        public CreateReserveForm()
        {
            InitializeComponent();
            btn_del.Visible = false;
        }
        
        public CreateReserveForm(Reserve reserve)
        {
            this.reserve = reserve;

            InitializeComponent();
            btn_del.Visible = true;
            LoadData();
            var employee = employeeRepo.GetEmployeeById(reserve.Код_сотрудника);
            //choose client in combobox by Код_клиента
            cb_client.SelectedIndex = cb_client.FindStringExact(clientRepo.GetClientsFIOById(reserve.Код_клиента));
            cb_emp.SelectedIndex = cb_emp.FindStringExact(specializationRepo.GetSpecName(employee.Специализация) + " | " + employeeRepo.GetEmployeesFIOById(reserve.Код_сотрудника));
            cb_serv.SelectedIndex = cb_serv.FindStringExact(serviceRepo.GetServiceById(reserve.Код_услуги).Наименование_услуги);





            // split Дата_и_время into date and time

            string[] currDate = reserve.Дата_время_записи.Split('|');
            currDate[1] = currDate[1].Trim();
            dtp_date.Value = DateTime.Parse(currDate[0]);
            cb_time.SelectedIndex = cb_time.FindStringExact(currDate[1]);



            //// get client by id
            //Client client = clientRepo.GetClientById(reserve.Код_клиента);
            //// get employee by id
            //Employee employee = employeeRepo.GetEmployeeById(reserve.Код_сотрудника);
            //// get service by id
            //Service service = serviceRepo.GetServiceById(reserve.Код_услуги);

            //


        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string[] clientsFIO = clientRepo.GetClientsFIO();
            string[] employeesFIO = employeeRepo.GetEmployeesFIO();



            foreach (var client in clientRepo.clientList)
            {
                cb_client.Items.Add(new ComboBoxItem(client.Фамилия + " " + client.Имя + " " + client.Отчество, client.Код_клиента));
            }
            foreach (var employee in employeeRepo.empList)
            {
                cb_emp.Items.Add(new ComboBoxItem(specializationRepo.GetSpecName(employee.Специализация) + " | " + employee.Фамилия + " " + employee.Имя + " " + employee.Отчество, employee.Код_сотрудника));
            }


            var item = DateTime.Today.AddHours(9); // 14:00:00
            while (item <= DateTime.Today.AddHours(20)) // 16:00:00
            {
                cb_time.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                item = item.AddMinutes(20);
            }
        }

        private void cb_serv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            //получить Код сотрудника из комбобокса
            int empCode = ((ComboBoxItem)cb.SelectedItem).Value;
            //получить специализацию сотрудника
            int specCode = employeeRepo.GetSpecCode(empCode);
            //получить список услуг по специализации
            List<int> servCodes = servicesSpecRepo.GetServicesBySpec(specCode);
            //очистить комбобокс услуг
            cb_serv.Items.Clear();
            //добавить услуги в комбобокс
            foreach (var servCode in servCodes)
            {
                cb_serv.Items.Add(new ComboBoxItem(serviceRepo.GetServiceName(servCode), servCode));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Код_клиента = ((ComboBoxItem)cb_client.SelectedItem).Value;
            reserve.Код_сотрудника = ((ComboBoxItem)cb_emp.SelectedItem).Value;
            reserve.Код_услуги = ((ComboBoxItem)cb_serv.SelectedItem).Value;
            reserve.Дата_время_записи = dtp_date.Value.ToString() + " | " + cb_time.Text.ToString();
            
            Program.mainMenu.addReserve(reserve);

        }

        private void btn_del_click(object sender, EventArgs e)
        {
            Program.form1.mdmdbDataSet.Записи.Rows.Find(reserve.Код_записи).Delete();
            Program.form1.записиTableAdapter.Update(Program.form1.mdmdbDataSet.Записи);
            Program.mainMenu.UpdateLists();
            MessageBox.Show("deleted");
        }
    }
    
}
