using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMDM_MSSQLSERVER.Classes
{
    internal class Repository
    {
    }



    // Repository Client Class
    public class ClientRepo
    {
        public List<Client> clientList = new List<Client>();

        public ClientRepo()
        {
        }

        public List<Client> GetClients(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Клиенты"].Rows)
            {
                clientList.Add(new Client(
                    int.Parse(row["Код_клиента"].ToString()),
                    row["Фамилия"].ToString(),
                    row["Имя"].ToString(),
                    row["Отчество"].ToString(),
                    row["Телефон"].ToString()));
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
    
    public class EmplRepo
    {
        public List<Empl> empList = new List<Empl>();


        public List<Empl> GetEmployees(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Сотрудники"].Rows)
            {
                //fill empList
                empList.Add(new Empl(
                    int.Parse(row["Код_сотрудника"].ToString()),
                    row["Фамилия"].ToString(),
                    row["Имя"].ToString(),
                    row["Отчество"].ToString(),
                    row["Телефон"].ToString(),
                    int.Parse(row["Код_должности"].ToString())
                    ));



            }
            return empList;
        }

        internal Empl GetEmployeeById(int код_сотрудника)
        {
            foreach (Empl employee in empList)
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
            int jobCode = 0;
            foreach (Empl emp in empList)
            {
                if (emp.Код_сотрудника == empCode)
                {
                    jobCode = emp.Код_должности;
                }
            }
            return jobCode;
        }
    }
    public class JobRepo
    {
        public List<Job> jobList = new List<Job>();

        internal Job GetByCode(int код_должности)
        {
            foreach (Job job in jobList)
            {
                if (job.Код_должности == код_должности)
                {
                    return job;
                }
            }
            return null;
        }

        internal List<Job> GetJobs(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["Должности"].Rows)
            {
                jobList.Add(new Job(
                    int.Parse(row["Код_должности"].ToString()),
                    row["Наименование_должности"].ToString()
                    ));

            }
            return jobList;
        }
    }


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
                account.Код_группы = Convert.ToInt32(dr["Код_группы"]);
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
}
