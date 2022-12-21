using ISMDM_MSSQLSERVER.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISMDM_MSSQLSERVER.Forms
{
    public partial class PersonForm : Form
    {
        Client client;
        Empl empl;
        bool flag;
        JobRepo jobRepo = Program.mainForm.jobRepo;
        public PersonForm()
        {
            InitializeComponent();
        }
        public PersonForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            textBox1.Text = client.Фамилия.ToString();
            textBox2.Text = client.Имя.ToString();
            textBox3.Text = client.Отчество.ToString();
            textBox4.Text = client.Телефон.ToString();
            label5.Visible = false;
            comboBox1.Visible = false;
            

        }
        public PersonForm(Empl empl)
        {
            this.empl = empl; 
            InitializeComponent();
            textBox1.Text = empl.Фамилия.ToString();
            textBox2.Text = empl.Имя.ToString();
            textBox3.Text = empl.Отчество.ToString();
            textBox4.Text = empl.Телефон.ToString();
            label5.Visible = true;
            comboBox1.Visible = true;


            string currJob = jobRepo.GetByCode(empl.Код_должности).Наименование_должности;

            foreach (var job in Program.mainForm.jobList)
            {
                comboBox1.Items.Add(new ComboBoxItem(job.Наименование_должности, job.Код_должности));
            }
            comboBox1.SelectedIndex = comboBox1.FindString(currJob);
        }

        public PersonForm(bool flag)
        {
            this.flag = flag;
            InitializeComponent();
            if (!flag)
            {
                label5.Visible = true;
                comboBox1.Visible = true;
                foreach (var job in Program.mainForm.jobList)
                {
                    comboBox1.Items.Add(new ComboBoxItem(job.Наименование_должности, job.Код_должности));
                }
            }
            else
            {
                label5.Visible = false;
                comboBox1.Visible = false;
            }

        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        public class ComboBoxItem
        {
            //constructor
            public ComboBoxItem(string text, int value)
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.client != null)
            {
                client.Фамилия = textBox1.Text;
                client.Имя = textBox2.Text;
                client.Отчество = textBox3.Text;
                client.Телефон = textBox4.Text;
                
                Program.mainForm.updatePerson(client);
            }
            else if (this.empl != null)
            {

                empl.Фамилия = textBox1.Text;
                empl.Имя = textBox2.Text;
                empl.Отчество = textBox3.Text;
                empl.Телефон = textBox4.Text;

                empl.Код_должности = ((ComboBoxItem)comboBox1.SelectedItem).Value;

                Program.mainForm.updatePerson(empl);
            }
            else if ( this.flag)
            {
                Client client = new Client();
                client.Фамилия = textBox1.Text;
                client.Имя = textBox2.Text;
                client.Отчество = textBox3.Text;
                client.Телефон = textBox4.Text;

                Program.mainForm.createPerson(client);
            }
            else if ( !this.flag)
            {
                Empl empl = new Empl();

                empl.Фамилия = textBox1.Text;
                empl.Имя = textBox2.Text;
                empl.Отчество = textBox3.Text;
                empl.Телефон = textBox4.Text;

                empl.Код_должности = ((ComboBoxItem)comboBox1.SelectedItem).Value;


                //Program.mainForm.createPerson(employee);
            }
        }
    }
}
