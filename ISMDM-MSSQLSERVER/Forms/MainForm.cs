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

namespace ISMDM_MSSQLSERVER.Forms
{

    public partial class MainForm : Form
    {

        DataSet ds;
        public List<Empl> empList = new List<Empl>();
        public EmplRepo emplRepo;
        
        public List<Client> clientList = new List<Client>();
        public ClientRepo clientRepo;

        public List<Job> jobList = new List<Job>();
        public JobRepo jobRepo;

        public List<Account> accList = new List<Account>();
        public AccountRepo accRepo;

        public int page = 0;

        public MainForm()
        {
            InitializeComponent();
            SetRoundedShape(this,30);
            SetLeftRoundedShape(btn_dogovory1,30);
            SetLeftRoundedShape(btn_klienty1,30);
            SetLeftRoundedShape(btn_otch1,30);
            SetLeftRoundedShape(btn_sotr1,30);


            SetRoundedShape(btn_dogovory2, 30);
            SetRoundedShape(btn_klienty2, 30);
            SetRoundedShape(btn_otch2, 30);
            SetRoundedShape(btn_sotr2, 30);
            SetRoundedShape(btn_leave, 15);
            
            SetRoundedShape(btn_add, 80);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ds = Program.adminForm.gusevaDataSet;
            emplRepo = new EmplRepo();
            clientRepo = new ClientRepo();
            jobRepo = new JobRepo();
            accRepo = new AccountRepo();

            UpdateLists();
        }


        public void UpdateLists()
        {
            empList.Clear();
            empList = emplRepo.GetEmployees(ds);

            clientList.Clear();
            clientList = clientRepo.GetClients(ds);

            jobList.Clear();
            jobList = jobRepo.GetJobs(ds);

            accList.Clear();
            accList = accRepo.GetAccounts(ds);


        }


        public static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        public static void SetLeftRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width , 0);  

            
            
            path.AddLine(control.Width , control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void btn_sotr_Click(object sender, EventArgs e)
        {
            page = 1;
            btn_add.Visible = true;
            this.pnlLoader.Controls.Clear();
            foreach (Empl empl in Program.mainForm.empList)
            {

                var currForm = new Form();
                currForm = new Item(empl) { Dock = DockStyle.Top, TopLevel = false, TopMost = true }; ;
                currForm.Dock = DockStyle.Top;

                currForm.FormBorderStyle = FormBorderStyle.None;
                lb_page.Text = "Сотрудники";
                this.pnlLoader.Controls.Add(currForm);
                currForm.Show();



            }

        }

        private void btn_otch_Click(object sender, EventArgs e)
        {
            page = 2;

        }

        private void btn_klienty_Click(object sender, EventArgs e)
        {
            page = 3;
            btn_add.Visible = true;
            this.pnlLoader.Controls.Clear();
            foreach (Client client in Program.mainForm.clientList)
            {

                var currForm = new Form();
                currForm = new Item(client) { Dock = DockStyle.Top, TopLevel = false, TopMost = true }; ;
                currForm.Dock = DockStyle.Top;

                currForm.FormBorderStyle = FormBorderStyle.None;
                lb_page.Text = "Клиенты";
                this.pnlLoader.Controls.Add(currForm);
                currForm.Show();



            }

        }

        private void btn_dogovory_Click(object sender, EventArgs e)
        {
            page = 4;

        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //var currForm = new Item(client) { Dock = DockStyle.Top, TopLevel = false, TopMost = true }; ;
            this.pnlLoader.Controls.Clear();
            switch (page)
            {
                case 1:
                    confPerson(false);
                    break;
                case 2:
                    break;
                case 3:
                    confPerson(true);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
        internal void confPerson(bool flag)
        {
            this.pnlLoader.Controls.Clear();
            var currForm = new PersonForm(flag) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            currForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(currForm);
            currForm.Show();
        }
        internal void confPerson(Client client)
        {
            this.pnlLoader.Controls.Clear();
            var currForm = new PersonForm(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            currForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(currForm);
            currForm.Show();
        }
        internal void confPerson(Empl empl)
        {
            this.pnlLoader.Controls.Clear();
            var currForm = new PersonForm(empl) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            currForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(currForm);
            currForm.Show();
        }

        internal void updatePerson(Client client)
        {

            DataRow dr = Program.adminForm.gusevaDataSet.Клиенты.Rows.Find(client.Код_клиента);
            int currRow = Program.adminForm.gusevaDataSet.Клиенты.Rows.IndexOf(dr);
            Program.adminForm.dataGridViewClient.Rows[currRow].Cells[1].Value = client.Фамилия;
            Program.adminForm.dataGridViewClient.Rows[currRow].Cells[2].Value = client.Имя;
            Program.adminForm.dataGridViewClient.Rows[currRow].Cells[3].Value = client.Отчество;
            Program.adminForm.dataGridViewClient.Rows[currRow].Cells[4].Value = client.Телефон;

            Program.adminForm.клиентыTableAdapter.Update(Program.adminForm.gusevaDataSet.Клиенты);

            UpdateLists();
            MessageBox.Show("Обновлено");
        }
        internal void updatePerson(Empl empl)
        {
            DataRow dr = Program.adminForm.gusevaDataSet.Сотрудники.Rows.Find(empl.Код_сотрудника);
            int currRow = Program.adminForm.gusevaDataSet.Сотрудники.Rows.IndexOf(dr);
            Program.adminForm.dataGridViewSotr.Rows[currRow].Cells[1].Value = empl.Фамилия;
            Program.adminForm.dataGridViewSotr.Rows[currRow].Cells[2].Value = empl.Имя;
            Program.adminForm.dataGridViewSotr.Rows[currRow].Cells[3].Value = empl.Отчество;
            Program.adminForm.dataGridViewSotr.Rows[currRow].Cells[4].Value = empl.Телефон;
            Program.adminForm.dataGridViewSotr.Rows[currRow].Cells[5].Value = empl.Код_должности;

            

            Program.adminForm.сотрудникиTableAdapter.Update(Program.adminForm.gusevaDataSet.Сотрудники);

            UpdateLists();
            MessageBox.Show("Обновлено");
        }

        internal void createPerson(Client client)
        {
            DataRow dr = Program.adminForm.gusevaDataSet.Клиенты.NewRow();

            int lastId = Program.adminForm.gusevaDataSet.Клиенты.Rows[Program.adminForm.gusevaDataSet.Клиенты.Rows.Count - 1].Field<int>("Код_клиента");


            dr["Код_клиента"] = lastId + 1;
            dr["Фамилия"] = client.Фамилия;
            dr["Имя"] = client.Имя;
            dr["Отчество"] = client.Отчество;
            dr["Телефон"] = client.Телефон;

            Program.adminForm.gusevaDataSet.Клиенты.Rows.Add(dr);
            Program.adminForm.клиентыTableAdapter.Update(Program.adminForm.gusevaDataSet.Клиенты);

            UpdateLists();
            MessageBox.Show("Сохранено");
        }
        internal void createPerson(Empl empl)
        {

            DataRow dr = Program.adminForm.gusevaDataSet.Сотрудники.NewRow();

            int lastId = Program.adminForm.gusevaDataSet.Сотрудники.Rows[Program.adminForm.gusevaDataSet.Сотрудники.Rows.Count - 1].Field<int>("Код_сотрудника");


            dr["Код_сотрудника"] = lastId + 1;
            dr["Фамилия"] = empl.Фамилия;
            dr["Имя"] = empl.Имя;
            dr["Отчество"] = empl.Отчество;
            dr["Телефон"] = empl.Телефон;
            dr["Специализация"] = empl.Код_должности;


            Program.adminForm.gusevaDataSet.Сотрудники.Rows.Add(dr);
            Program.adminForm.сотрудникиTableAdapter.Update(Program.adminForm.gusevaDataSet.Сотрудники);

            UpdateLists();
            MessageBox.Show("Сохранено");

        }
    }
}
