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
    public partial class Item : Form
    {
        Client client;

        //ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
        SpecializationRepo specializationRepo = Program.mainMenu.specializationRepo;

        Employee employee;
        public Item()
        {
            InitializeComponent();
        }
        public Item(Client client)
        {
            this.client = client;
            InitializeComponent();
            string fio = client.Фамилия + " " + client.Имя + " " + client.Отчество;
            
            l_name.Text = fio;
            l_spec.Text = client.Телефон;
            l_spec2.Text = client.Эл_почта;
            
        }

        public Item(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            string fio = employee.Фамилия + " " + employee.Имя + " " + employee.Отчество;

            l_name.Text = fio;
            l_spec.Text = employee.Телефон;

            //string currSched = scheduleRepo.GetScheduleByCode(employee.Специализация);
            //l_spec2.Text = currSched;

            string currSpec = specializationRepo.GetSpecName(employee.Специализация);
            l_spec2.Text = currSpec;
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void Item_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                Program.mainMenu.mmConfigurePerson(this.client);
            }
            else if (employee != null)
            {
                Program.mainMenu.mmConfigurePerson(this.employee);

            }
        }
    }
}
