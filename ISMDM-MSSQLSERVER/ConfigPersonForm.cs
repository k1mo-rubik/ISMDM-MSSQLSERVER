using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDM_MSSQLSERVER
{
    public partial class ConfigPersonForm : Form
    {
        bool flag;
        Dictionary<string, bool> btnRule = new Dictionary<string, bool>();
        Client client;
        Employee employee;
        ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
        SpecializationRepo specializationRepo = Program.mainMenu.specializationRepo;
        public ConfigPersonForm()
        {
            InitializeComponent();
        }

        public ConfigPersonForm(bool flag)
        {
            this.flag = flag;
            InitializeComponent();
            if (flag)
            {


      
                comboBox1.Visible = false;
                label6.Visible = false;
                comboBox2.Visible = false;
                label7.Visible = false;
            }
            else
            {
                

     

                comboBox1.Visible = true;


                foreach (var sched in Program.mainMenu.schedList)
                {
                    comboBox1.Items.Add(new ComboBoxItem(sched.График, sched.Код_графика));
                }
               
                foreach (var spec in Program.mainMenu.specList)
                {
                    comboBox2.Items.Add(new ComboBoxItem(spec.Наименование_специализации, spec.Код_специализации));
                }
                
                label6.Visible = true;
                comboBox2.Visible = true;
                label7.Visible = true;
            }
            
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

            label5.Visible = false;
            tb_email.Visible = false;
            comboBox1.Visible = true;
            string currSpec = specializationRepo.GetSpecName(employee.Специализация);
            string currSched = scheduleRepo.GetScheduleByCode(employee.Код_графика);

            
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

            btnRule.Clear();
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
            else if (this.flag)
            {
                Client client = new Client();
                client.Фамилия = tb_surname.Text;
                client.Имя = tb_name.Text;
                client.Отчество = tb_patr.Text;
                client.Телефон = tb_phone.Text;
                client.Эл_почта = tb_email.Text;
                Program.mainMenu.createPerson(client);
            }
            else if (!this.flag)
            {
                Employee employee= new Employee();
                
                employee.Фамилия = tb_surname.Text;
                employee.Имя = tb_name.Text;
                employee.Отчество = tb_patr.Text;
                employee.Телефон = tb_phone.Text;
                employee.Специализация = ((ComboBoxItem)comboBox2.SelectedItem).Value;
                employee.Код_графика = ((ComboBoxItem)comboBox1.SelectedItem).Value;


                Program.mainMenu.createPerson(employee);
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

        private void fio_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // if regex for surname is not matched, then show error
            if (!Regex.IsMatch(textBox.Text, @"^[А-Я][а-я]+$"))
            {
                //label8.Text = "Фамилия должна начинаться с заглавной буквы и состоять только из букв русского алфавита";
                btnRule[textBox.Name] = false;
                textBox.BackColor = Color.Red;
            }
            else
            {
                //label8.Text = "";
                btnRule[textBox.Name] = true;
                textBox.BackColor = Color.White;
            }

            foreach (var rule in btnRule)
            {
                if (!rule.Value)
                {
                    button1.Enabled = false;
                    return;
                }
                button1.Enabled = true;
            }

        }
        
        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Regex.IsMatch(tb_phone.Text, @"^\+7\d{10}$") && !Regex.IsMatch(tb_phone.Text, @"^8\d{10}$"))
            {
                //label8.Text = "Номер телефона должен начинаться с +7 и состоять из 11 цифр";

                btnRule[textBox.Name] = false;
                textBox.BackColor = Color.Red;
            }
            else
            {
                //label8.Text = "";
                btnRule[textBox.Name] = true;
                textBox.BackColor = Color.White;

            }
            foreach (var rule in btnRule)
            {
                if (!rule.Value)
                {
                    button1.Enabled = false;
                    return;
                }
                button1.Enabled = true;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
           
            
            //regex for email
            TextBox textBox = (TextBox)sender;
            
            if (textBox.Visible)
            {
             
                if (!Regex.IsMatch(tb_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                 {
                //label8.Text = "Некорректный email";
                btnRule[textBox.Name] = false;
                textBox.BackColor = Color.Red;
                 }
                    else
                 {
                //label8.Text = "";
                btnRule[textBox.Name] = true;
                textBox.BackColor = Color.White;
                  }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
