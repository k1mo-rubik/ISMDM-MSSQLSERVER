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
    
    public partial class Form1 : Form
    {
        //DataBase dbMdm = new DataBase();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.специализациияTableAdapter.Fill(this.mdmdbDataSet.Специализациия);
            this.группа_пользователейTableAdapter.Fill(this.mdmdbDataSet.Группа_пользователей);
            this.сотрудникиTableAdapter.Fill(this.mdmdbDataSet.Сотрудники);
            this.клиентыTableAdapter.Fill(this.mdmdbDataSet.Клиенты);
            this.графикTableAdapter.Fill(this.mdmdbDataSet.График);
            this.услуги_специализацииTableAdapter.Fill(this.mdmdbDataSet.Услуги_специализации);
            this.услугиTableAdapter.Fill(this.mdmdbDataSet.Услуги);
            this.записиTableAdapter.Fill(this.mdmdbDataSet.Записи);  
            this.аккаунтыTableAdapter.Fill(this.mdmdbDataSet.Аккаунты);
            
           

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            
            аккаунтыTableAdapter.Update(mdmdbDataSet.Аккаунты);
            графикTableAdapter.Update(mdmdbDataSet.График);
            клиентыTableAdapter.Update(mdmdbDataSet.Клиенты);
            записиTableAdapter.Update(mdmdbDataSet.Записи);
            сотрудникиTableAdapter.Update(mdmdbDataSet.Сотрудники);
            группа_пользователейTableAdapter.Update(mdmdbDataSet.Группа_пользователей);
            специализациияTableAdapter.Update(mdmdbDataSet.Специализациия);
            услугиTableAdapter.Update(mdmdbDataSet.Услуги);


            MessageBox.Show("Все изменения сохранены");
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //this.Hide();
            Program.mainMenu.Show();
            //Program.mainMenu.Hide();
            //Program.clientForm.Show();
        }
    }
}
