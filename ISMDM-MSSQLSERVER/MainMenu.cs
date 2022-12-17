using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using ISMDM_MSSQLSERVER.mdmdbDataSetTableAdapters;

namespace ISMDM_MSSQLSERVER
{
    public partial class MainMenu : Form
    {
        int currPage = 0;
        DataSet ds;
        public List<Client> clientList = new List<Client>();
        public List<Employee> empList = new List<Employee>();
        public List<Services> servList = new List<Services>();
        public List<Reserve> reserveList = new List<Reserve>();
        public List<Specialization> specList = new List<Specialization>();
        public List<Schedule> schedList = new List<Schedule>();
        public ScheduleRepo scheduleRepo;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public MainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelWorker.Text = btnMain.Text;
            //pnlNav.Height = btnMain.Height;
            //pnlNav.Top = btnMain.Top;
            //pnlNav.Left = btnMain.Left;
            pnlNav.BackColor = Color.FromArgb(255, 255, 255);
            

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //labelWorker.Text = authForm.worker;

            ds = Program.form1.mdmdbDataSet;

            ClientRepo clientRepo = new ClientRepo();
            EmployeeRepo employeeRepo = new EmployeeRepo();
            SpecializationRepo specializationRepo = new SpecializationRepo();
            scheduleRepo = new ScheduleRepo();


            clientList = clientRepo.GetClients(ds);
            empList = employeeRepo.GetEmployees(ds);
            specList = specializationRepo.GetSpecializations(ds);
            schedList = scheduleRepo.GetSchedules(ds);
        }


        private void btnNav_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            pnlNav.Height = b.Height;
            pnlNav.Top = b.Top;
            pnlNav.Left = b.Left;
            pnlNav.BackColor = Color.FromArgb(255, 255, 255);
            pnlNav.Visible = true;
            lblTitle.Text = b.Text;


            this.PnlFormLoader.Controls.Clear();
            var currForm = new Form();

            if (b.Tag == "zap") { currPage = 1; currForm = new ReserveForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "cli") { currPage = 2; currForm = new ClientForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "sot") { currPage = 3; currForm = new EmplForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "usl") { currPage = 4; currForm = new ClientForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "otc") { currPage = 5; currForm = new ClientForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }

            
            currForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(currForm);
            currForm.Show();


        }

        public void mmConfigurePerson(Client client)
        {

            this.PnlFormLoader.Controls.Clear();
           
            currPage = 6;
            var currForm = new ConfigPersonForm(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
     
            currForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(currForm);

           

            currForm.Show();

        }
        public void mmConfigurePerson(Employee employee)
        {
            this.PnlFormLoader.Controls.Clear();

            currPage = 6;
            var currForm = new ConfigPersonForm(employee) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            currForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(currForm);



            currForm.Show();

        }
        static void SetRoundedShape(Control control, int radius)
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

    
        private void btn_add(object sender, EventArgs e)
        {

            this.PnlFormLoader.Controls.Clear();
            var currForm = new Form();
            switch (currPage)
            {
                case 1:
                    {
                       
                        break;
                    }
                case 2:
                    {
                        currForm = new ConfigPersonForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        break;
                    }
                case 3:
                    {
                       currForm = new ConfigPersonForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        break;
                    }
                case 4:
                    {
                      
                        break;
                    }
                case 5:
                    {
                       
                        break;
                    }
            }

            currForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(currForm);
            currForm.Show();
        }

        internal void updatePerson(Client client)
        {
            
            DataRow dr = Program.form1.mdmdbDataSet.Клиенты.Rows.Find(client.Код_клиента);
            int currRow = Program.form1.mdmdbDataSet.Клиенты.Rows.IndexOf(dr);
            Program.form1.dataGridViewClient.Rows[currRow].Cells[1].Value = client.Фамилия;
            Program.form1.dataGridViewClient.Rows[currRow].Cells[2].Value = client.Имя;
            Program.form1.dataGridViewClient.Rows[currRow].Cells[3].Value = client.Отчество;
            Program.form1.dataGridViewClient.Rows[currRow].Cells[4].Value = client.Телефон;
            Program.form1.dataGridViewClient.Rows[currRow].Cells[5].Value = client.Эл_почта;

            Program.form1.клиентыTableAdapter.Update(Program.form1.mdmdbDataSet.Клиенты);


            MessageBox.Show("Обновлено");

        }
        internal void updatePerson(Employee employee)
        {
            DataRow dr = Program.form1.mdmdbDataSet.Сотрудники.Rows.Find(employee.Код_сотрудника);
            int currRow = Program.form1.mdmdbDataSet.Сотрудники.Rows.IndexOf(dr);
            
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[1].Value = employee.Фамилия;
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[2].Value = employee.Имя;
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[3].Value = employee.Отчество;
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[4].Value = employee.Телефон;
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[5].Value = employee.Код_графика;
            Program.form1.dataGridViewEmpl.Rows[currRow].Cells[6].Value = employee.Специализация;
            

            Program.form1.сотрудникиTableAdapter.Update(Program.form1.mdmdbDataSet.Сотрудники);


            MessageBox.Show("Обновлено");
        }
    }

    // Repository Client Class
    public class ClientRepo
    {
        public List<Client> clientList = new List<Client>();
        
        public ClientRepo()
        {
            //clientList.Add(new Client(1, "Иванов", "Иван", "Иванович", "8-800-555-35-35", "
        }

        public List<Client> GetClients(DataSet ds)
        {

          

            foreach (DataRow row in ds.Tables["Клиенты"].Rows)
            {
                //fill clientList
                clientList.Add(new Client(
                    int.Parse(row["Код_клиента"].ToString()),
                    row["Фамилия"].ToString(),
                    row["Имя"].ToString(),
                    row["Отчество"].ToString(),
                    row["Телефон"].ToString(),
                    row["Эл_почта"].ToString()));

            }
            return clientList;
        }

        }
    // Repository Employee Class
    public class EmployeeRepo
    {
        public List<Employee> empList = new List<Employee>();


        public List<Employee> GetEmployees(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Сотрудники"].Rows)
            {
                //fill empList
                empList.Add(new Employee(
                    int.Parse(row["Код_сотрудника"].ToString()),
                    row["Фамилия"].ToString(),
                    row["Имя"].ToString(),
                    row["Отчество"].ToString(),
                    row["Телефон"].ToString(),
                    int.Parse(row["Код_графика"].ToString()),
                    int.Parse(row["Специализация"].ToString())
                    ));



            }
            return empList;
        }
    }

    //Repository specialization class
    public class SpecializationRepo
    {
        public List<Specialization> specList = new List<Specialization>();

        public List<Specialization> GetSpecializations(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Специализациия"].Rows)
            {
                //fill specList
                specList.Add(new Specialization(
                    int.Parse(row["Код_специализации"].ToString()),
                    row["Наименование_специализации"].ToString()
                    ));

            }
            return specList;
        }

        public string GetSpecName(int id)
        {
            foreach (Specialization spec in specList)
            {
                if (spec.Код_специализации == id)
                {
                    return spec.Наименование_специализации;
                }
            }
            return "";
        }
    }


    // repository Schedule class
    public class ScheduleRepo
    {
        public List<Schedule> schedList = new List<Schedule>();

        public List<Schedule> GetSchedules(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["График"].Rows)
            {
                //fill schedList
                schedList.Add(new Schedule(
                    int.Parse(row["Код_графика"].ToString()),
                    row["График"].ToString()
                    ));

            }
            return schedList;
        }
        public string GetScheduleByCode(int id)
        {
            foreach (Schedule sched in this.schedList)
            {
                if (sched.Код_графика == id)
                {
                    return sched.График;
                }
            }
            return "";
        }

    }





    // make client class
    public class Client
    {
        // make class constructor using all fields
        public Client(int Код_клиента, string Фамилия, string Имя, string Отчество, string Телефон, string Эл_почта)
        {
            this.Код_клиента = Код_клиента;
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Телефон = Телефон;
            this.Эл_почта = Эл_почта;
        }

        public int Код_клиента { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Телефон { get; set; }
        public string Эл_почта { get; set; }
    }

    // make employee class
    public class Employee
    {
        //make constructor
        public Employee(int Код_сотрудника, string Фамилия, string Имя, string Отчество, string Телефон, int Код_графика, int? Специализация)
        {
            this.Код_сотрудника = Код_сотрудника;
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Телефон = Телефон;

            this.Код_графика = (int)(Код_графика == null? 0 : Код_графика);
            this.Специализация = (int)(Специализация == null ? 0 : Специализация);
        }
        public int Код_сотрудника { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Телефон { get; set; }
        public int Код_графика { get; set; }
        public int Специализация { get; set; }
    }
    // make services class
    public class Services
    {
        public int Код_услуги { get; set; }
        public string Наименование_услуги { get; set; }
        public string Стоимость_услуги { get; set; }
    }
    // make reserve class
    public class Reserve
    {
        public int Код_записи { get; set; }
        public string Код_клиента { get; set; }
        public string Код_сотрудника { get; set; }
        public string Код_услуги { get; set; }
        public string Дата_время_записи { get; set; }
    }
    // класс группа пользователей
    public class UserGroup
    {
        public int Код_группы { get; set; }
        public string Наименование_группы { get; set; }
        public string Уровень_доступа { get; set; }
    }
    // класс аккаунты
    public class Account
    {
        public int Код_аккаунта { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string Код_сотрудника { get; set; }
        public string Группа_пользователей { get; set; }
    }

    //класс график работы
    public class Schedule
    {

        public Schedule(int Код_графика, string График)
        {
            this.Код_графика = Код_графика;
            this.График = График;
        }

        public int Код_графика { get; set; }
        public string График { get; set; }
        //public string День_недели { get; set; }
        //public string Время_начала { get; set; }
        //public string Время_окончания { get; set; }
    }
    // класс специализация
    public class Specialization
    {
        //constructor 
        public Specialization(int Код_специализации, string Наименование_специализации)
        {
            this.Код_специализации = Код_специализации;
            this.Наименование_специализации = Наименование_специализации;
        }
        public int Код_специализации { get; set; }
        public string Наименование_специализации { get; set; }
    }
}
    // класс для работы с БД
    
