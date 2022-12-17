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
        ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
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
            
            tb_name.Text = fio;
            tb_spec.Text = client.Телефон;
            tb_spec2.Text = client.Эл_почта;
            
        }

        public Item(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            string fio = employee.Фамилия + " " + employee.Имя + " " + employee.Отчество;

            tb_name.Text = fio;
            tb_spec.Text = employee.Телефон;

            string currSched = scheduleRepo.GetScheduleByCode(employee.Специализация);
            tb_spec2.Text = currSched;
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
