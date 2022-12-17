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
    public partial class ConfigPersonForm : Form
    {
        Client client;
        Employee employee;
        SpecializationRepo specializationRepo = new SpecializationRepo();
        ScheduleRepo scheduleRepo = new ScheduleRepo();
        public ConfigPersonForm()
        {
            InitializeComponent();
        }
        public ConfigPersonForm(Client client)
        {
            this.client = client;
            InitializeComponent();
           


           tb_surname.Text = client.Фамилия;
           tb_name.Text = client.Имя;
           tb_patr.Text = client.Отчество;
           tb_phone.Text = client.Телефон;
           tb_email.Text = client.Эл_почта;

           comboBox1.Visible = false;
           label6.Visible = false;
           comboBox2.Visible = false;
           label7.Visible = false;
        }
        public ConfigPersonForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();



            tb_surname.Text = employee.Фамилия;
            tb_name.Text = employee.Имя;
            tb_patr.Text = employee.Отчество;
            tb_phone.Text = employee.Телефон;
            
            comboBox1.Visible = true;
            string currSpec = specializationRepo.GetSpecName(employee.Специализация);
            string currSched = scheduleRepo.GetScheduleByCode(employee.Специализация);

            
            foreach (var sched in Program.mainMenu.schedList)
            {
                comboBox1.Items.Add(new ComboBoxItem(sched.График, sched.Код_графика));
            }
            comboBox1.SelectedIndex = comboBox1.FindString(currSched);

            foreach (var spec in Program.mainMenu.specList)
            {
                comboBox2.Items.Add(new ComboBoxItem(spec.Наименование_специализации, spec.Код_специализации));
            }
            comboBox2.SelectedIndex = comboBox2.FindString(currSpec);

            label6.Visible = true;
            comboBox2.Visible = true;
            label7.Visible = true;
        }
        public class ComboBoxItem
        {
            //constructor
            public ComboBoxItem(string text, int  value)
            {
                Text = text;
                Value = value;
            }
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btn_saveData(object sender, EventArgs e)
        {
            if (this.client != null)
            {
                client.Фамилия = tb_surname.Text;
                client.Имя = tb_name.Text;
                client.Отчество = tb_patr.Text;
                client.Телефон = tb_phone.Text;
                client.Эл_почта = tb_email.Text;
                Program.mainMenu.updatePerson(client);
            }
            else if (this.employee != null)
            {

                employee.Фамилия = tb_surname.Text;
                employee.Имя = tb_name.Text;
                employee.Отчество = tb_patr.Text;
                employee.Телефон = tb_phone.Text;
                employee.Специализация = ((ComboBoxItem)comboBox2.SelectedItem).Value;
                employee.Код_графика = ((ComboBoxItem)comboBox1.SelectedItem).Value;
                Program.mainMenu.updatePerson(employee);

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ConfigPersonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
