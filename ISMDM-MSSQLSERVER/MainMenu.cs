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
        public List<Service> servList = new List<Service>();
        public List<Reserve> reserveList = new List<Reserve>();
        public List<Specialization> specList = new List<Specialization>();
        public List<Schedule> schedList = new List<Schedule>();
        public List<ServicesSpec> servSpecList = new List<ServicesSpec>();
        public List<Account> accountList = new List<Account>();
        public ScheduleRepo scheduleRepo;
        public SpecializationRepo specializationRepo;
        public ClientRepo clientRepo;
        public EmployeeRepo employeeRepo;
        public ServiceSpecRepo serviceSpecRepo;
        public ServiceRepo serviceRepo;
        public ReserveRepo reserveRepo;
        public AccountRepo accountRepo;

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

            clientRepo = new ClientRepo();
            employeeRepo = new EmployeeRepo();
            specializationRepo = new SpecializationRepo();
            scheduleRepo = new ScheduleRepo();
            serviceRepo = new ServiceRepo();
            serviceSpecRepo = new ServiceSpecRepo();
            reserveRepo = new ReserveRepo();
            accountRepo = new AccountRepo();


            UpdateLists();
        }

        public void UpdateLists()
        {
            clientList.Clear();
            empList.Clear();
            servList.Clear();
            reserveList.Clear();
            specList.Clear();
            schedList.Clear();
            servSpecList.Clear();
            accountList.Clear();



            clientList = clientRepo.GetClients(ds);
            empList = employeeRepo.GetEmployees(ds);
            specList = specializationRepo.GetSpecializations(ds);
            schedList = scheduleRepo.GetSchedules(ds);
            servSpecList = serviceSpecRepo.GetServicesSpec(ds);
            servList = serviceRepo.GetServices(ds);
            reserveList = reserveRepo.GetReserves(ds);
            accountList = accountRepo.GetAccounts(ds);
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

            if (b.Tag == "zap") { currPage = 1; currForm = new ReservForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "cli") { currPage = 2; currForm = new ClientForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "sot") { currPage = 3; currForm = new EmplForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            //else if (b.Tag == "usl") { currPage = 4; currForm = new ClientForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }
            else if (b.Tag == "otc") { currPage = 5; currForm = new RepForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; }

            
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
                        currForm = new CreateReserveForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        break;
                    }
                case 2:
                    {
                        currForm = new ConfigPersonForm(true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        break;
                    }
                case 3:
                    {
                       currForm = new ConfigPersonForm(false) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
        // создать запись
        public void addReserve(Reserve reserve)
        {
            DataRow dr = Program.form1.mdmdbDataSet.Записи.NewRow();
            // последняя строка таблицы записей
            int lastId = Program.form1.mdmdbDataSet.Записи.Rows[Program.form1.mdmdbDataSet.Записи.Rows.Count - 1].Field<int>("Код_записи");

            //dr["Код_записи"] = ;
            //Program.form1.записиTableAdapter.
            //check last id in table Записи and add 1
            //int lastId = 0;
            //foreach (DataRow dr in Program.form1.mdmdbDataSet.Записи.Rows)
            //{
            //    if (Convert.ToInt32(dr["Код_записи"]) > lastId)
            //    {
            //        lastId = Convert.ToInt32(dr["Код_записи"]);
            //    }
            //}

            dr["Код_записи"] = lastId + 1;
            dr["Код_клиента"] = reserve.Код_клиента;
            dr["Код_сотрудника"] = reserve.Код_сотрудника;
            dr["Код_услуги"] = reserve.Код_услуги;
            dr["Дата_время_записи"] = reserve.Дата_время_записи;

            Program.form1.mdmdbDataSet.Записи.Rows.Add(dr);
            //Program.form1.dataGridViewClient.Rows[currRow].Cells[1].Value = reserve.Фамилия;





            Program.form1.записиTableAdapter.Update(Program.form1.mdmdbDataSet.Записи);

            UpdateLists();

            MessageBox.Show("Сохранено");
        }

        internal void createPerson(Client client)
        {

            DataRow dr = Program.form1.mdmdbDataSet.Клиенты.NewRow();

            int lastId = Program.form1.mdmdbDataSet.Клиенты.Rows[Program.form1.mdmdbDataSet.Клиенты.Rows.Count - 1].Field<int>("Код_клиента");


            dr["Код_клиента"] = lastId+1;
            dr["Фамилия"] = client.Фамилия;
            dr["Имя"] = client.Имя;
            dr["Отчество"] = client.Отчество;
            dr["Телефон"] = client.Телефон;
            dr["Эл_почта"] = client.Эл_почта;
            
            Program.form1.mdmdbDataSet.Клиенты.Rows.Add(dr);
            Program.form1.клиентыTableAdapter.Update(Program.form1.mdmdbDataSet.Клиенты);

            UpdateLists();
            MessageBox.Show("Сохранено");


        }
        internal void createPerson(Employee employee)
        {

            DataRow dr = Program.form1.mdmdbDataSet.Сотрудники.NewRow();

            int lastId = Program.form1.mdmdbDataSet.Сотрудники.Rows[Program.form1.mdmdbDataSet.Сотрудники.Rows.Count - 1].Field<int>("Код_сотрудника");


            dr["Код_сотрудника"] = lastId+1;
            dr["Фамилия"] = employee.Фамилия;
            dr["Имя"] = employee.Имя;
            dr["Отчество"] = employee.Отчество;
            dr["Телефон"] = employee.Телефон;
            dr["Код_графика"] = employee.Код_графика;
            dr["Специализация"] = employee.Специализация;

            
            Program.form1.mdmdbDataSet.Сотрудники.Rows.Add(dr);
            Program.form1.сотрудникиTableAdapter.Update(Program.form1.mdmdbDataSet.Сотрудники);

            UpdateLists();
            MessageBox.Show("Сохранено");

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

            UpdateLists();
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

            UpdateLists();
            MessageBox.Show("Обновлено");
        }

        internal void mmConfigureReserv(int reserveId)
        {
            //find reserv by id
            Reserve reserve = reserveRepo.GetReserveById(reserveId);

            
            this.PnlFormLoader.Controls.Clear();

            currPage = 7;
            var currForm = new CreateReserveForm(reserve) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            currForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(currForm);



            currForm.Show();
        }
    }
    //repository Аккаунты class
    public class AccountRepo
    {
        public List<Account> accountList = new List<Account>();

        public AccountRepo()
        {
            //this.account = new Аккаунты();
        }


        public List<Account> GetAccounts(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Account account = new Account();
                account.Код_аккаунта = Convert.ToInt32(dr["Код_аккаунта"]);
                account.Логин = dr["Логин"].ToString();
                account.Пароль = dr["Пароль"].ToString();
                account.Код_сотрудника = Convert.ToInt32(dr["Код_сотрудника"]);
                account.Группа_пользователей = Convert.ToInt32(dr["Группа_пользователей"]);
                accountList.Add(account);
            }
            return accountList;
        }


        public Account LoginAccount(string login, string pass)
        {
            // check if login and pass are correct
            foreach (Account account in accountList)
            {
                if (account.Логин == login && account.Пароль == pass)
                {
                    return account;
                }
               
            }
            return null;
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

        internal Client GetClientById(object clientId)
        {
            foreach (Client client in clientList)
            {
                if (client.Код_клиента == (int)clientId)
                {
                    return client;
                }
            }
            return null;
        }

        internal string[] GetClientsFIO()
        {
            string[] fio = new string[clientList.Count];
            for (int i = 0; i < clientList.Count; i++)
            {
                fio[i] = clientList[i].Фамилия + " " + clientList[i].Имя + " " + clientList[i].Отчество;
            }
            return fio;
        }

        internal string GetClientsFIOById(int код_клиента)
        {
            string fio = "";
            for (int i = 0; i < clientList.Count; i++)
            {
                if (clientList[i].Код_клиента == код_клиента)
                {
                    fio = clientList[i].Фамилия + " " + clientList[i].Имя + " " + clientList[i].Отчество;
                }
            }
            return fio;
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

        internal Employee GetEmployeeById(int код_сотрудника)
        {
            foreach (Employee employee in empList)
            {
                if (employee.Код_сотрудника == код_сотрудника)
                {
                    return employee;
                }
            }
            return null;
        }

        internal string[] GetEmployeesFIO()
        {
            string[] fio = new string[empList.Count];
            for (int i = 0; i < empList.Count; i++)
            {
                fio[i] = empList[i].Фамилия + " " + empList[i].Имя + " " + empList[i].Отчество;
            }
            return fio;
        }

        internal string GetEmployeesFIOById(int код_сотрудника)
        {
            string fio = "";
            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].Код_сотрудника == код_сотрудника)
                {
                    fio = empList[i].Фамилия + " " + empList[i].Имя + " " + empList[i].Отчество;
                }
            }
            return fio;
        }

        internal int GetSpecCode(int empCode)
        {
            int specCode = 0;
            foreach (Employee emp in empList)
            {
                if (emp.Код_сотрудника == empCode)
                {
                    specCode = emp.Специализация;
                }
            }
            return specCode;
        }
    }

    //Repository Записи class
    public class ReserveRepo
    {
        public List<Reserve> reservList = new List<Reserve>();

        public List<Reserve> GetReserves(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Записи"].Rows)
            {
                //fill recordList
                reservList.Add(new Reserve(
                    int.Parse(row["Код_записи"].ToString()),
                    int.Parse(row["Код_сотрудника"].ToString()),
                    row["Дата_время_записи"].ToString(),
                    int.Parse(row["Код_клиента"].ToString()),
                    int.Parse(row["Код_услуги"].ToString())
                    ));



            }
            return reservList;
        }

        internal Reserve GetReserveById(int reserveId)
        {
            Reserve reserve = new Reserve();
            foreach (Reserve r in reservList)
            {
                if (r.Код_записи == reserveId)
                {
                    reserve = r;
                }
            }
            return reserve;
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

        internal void AddReserve(Reserve reserve)
        {
            
        }
    }
    //repository услуги_специализации
    public class ServiceSpecRepo
    {
        public List<ServicesSpec> servSpecList = new List<ServicesSpec>();

        public List<ServicesSpec> GetServicesSpec(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Услуги_специализации"].Rows)
            {
                //fill servSpecList
                servSpecList.Add(new ServicesSpec(
                    int.Parse(row["Код"].ToString()),
                    int.Parse(row["Код_специализации"].ToString()),
                    int.Parse(row["Код_услуги"].ToString())
                    ));

            }
            return servSpecList;
        }
        // get services by spec code
     
        internal List<int> GetServicesBySpec(int specCode)
        {
            List<int> currServList = new List<int>();
            foreach (ServicesSpec serv in servSpecList)
            {
                if (serv.Код_специализации == specCode)
                {
                    currServList.Add(serv.Код_услуги);

                }
            }
            return currServList;
        }
    }


    //class услуги_специализации
    public class ServicesSpec
    {
        public int Код { get; set; }
        public int Код_услуги { get; set; }
        public int Код_специализации { get; set; }

        public ServicesSpec(int код, int код_специализации, int код_услуги)
        {
            Код = код;
            Код_услуги = код_услуги;
            Код_специализации = код_специализации;
        }
    }

    //repository services class
    public class ServiceRepo
    {
        public List<Service> servList = new List<Service>();

        public List<Service> GetServices(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Услуги"].Rows)
            {
                //fill servList
                servList.Add(new Service(
                    int.Parse(row["Код_услуги"].ToString()),
                    row["Наименование_услуги"].ToString(),
                    row["Стоимость_услуги"].ToString())
                    );

            }
            return servList;
        }
        public string GetServiceName(int id)
        {
            foreach (Service serv in servList)
            {
                if (serv.Код_услуги == id)
                {
                    return serv.Наименование_услуги;
                }
            }
            return "";
        }
        public string GetServicePrice(int id)
        {
            foreach (Service serv in servList)
            {
                if (serv.Код_услуги == id)
                {
                    return serv.Стоимость_услуги;
                }
            }
            return null;
        }

        internal Service GetServiceById(int код_услуги)
        {
            foreach (Service serv in servList)
            {
                if (serv.Код_услуги == код_услуги)
                {
                    return serv;
                }
            }
            return null;
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
        public Client()
        {
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

        public Employee()
        {
     
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
    public class Service
    {
       

        public Service(int код_услуги, string наименование_услуги, string стоимость_услуги)
        {
            this.Код_услуги = код_услуги;
            this.Наименование_услуги = наименование_услуги;
            this.Стоимость_услуги = стоимость_услуги;
        }

        public int Код_услуги { get; set; }
        public string Наименование_услуги { get; set; }
        public string Стоимость_услуги { get; set; }
    }
    // make reserve class
    public class Reserve
    {
        public Reserve()
        {
        }

        //constructor
        public Reserve(int Код_записи,  int Код_сотрудника, string Дата_время_записи,int Код_клиента, int Код_услуги )
        {
            this.Код_записи = Код_записи;
            this.Код_клиента = Код_клиента;
            this.Код_сотрудника = Код_сотрудника;
            this.Код_услуги = Код_услуги;
            this.Дата_время_записи = Дата_время_записи;
        }
        public int Код_записи { get; set; }
        public int Код_клиента { get; set; }
        public int Код_сотрудника { get; set; }
        public int Код_услуги { get; set; }
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
        public int Код_сотрудника { get; set; }
        public int Группа_пользователей { get; set; }
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
    
