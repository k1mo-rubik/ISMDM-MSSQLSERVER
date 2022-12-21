using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMDM_MSSQLSERVER.Classes
{
    internal class Entity
    {

        
    }

    //class for client
    public class Client
    {
        // make class constructor using all fields
        public Client(int Код_клиента, string Фамилия, string Имя, string Отчество, string Телефон)
        {
            this.Код_клиента = Код_клиента;
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Телефон = Телефон;
        }
        public Client()
        {
        }

        public int Код_клиента { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Телефон { get; set; }
    }

    // make employee class
    public class Empl
    {
        //make constructor
        public Empl(int Код_сотрудника, string Фамилия, string Имя, string Отчество, string Телефон, int Код_должности)
        {
            this.Код_сотрудника = Код_сотрудника;
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Телефон = Телефон;
            this.Код_должности = Код_должности;
        }

        public Empl()
        {
     
        }
        public int Код_сотрудника { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Телефон { get; set; }
        public int Код_должности { get; set; }
    }
    
    public class Account
    {
        public int Код_аккаунта { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public int Код_сотрудника { get; set; }
        public int Код_группы { get; set; }
    }

    public class Job
    {
        public Job(int Код_должности, string Наименование_должности)
        {
            this.Код_должности = Код_должности;
            this.Наименование_должности = Наименование_должности;
        }
        public int Код_должности { get; set; }
        public string Наименование_должности { get; set; }
    }

}
