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
    
    public partial class AdminForm : Form
    {
        //DataBase dbMdm = new DataBase();
        
        public AdminForm()
        {
            InitializeComponent();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.страховые_рискиTableAdapter.Fill(this.gusevaDataSet.Страховые_риски);
            this.должностиTableAdapter.Fill(this.gusevaDataSet.Должности);
            this.договоры_и_рискиTableAdapter.Fill(this.gusevaDataSet.Договоры_и_риски);
            this.группы_пользователейTableAdapter.Fill(this.gusevaDataSet.Группы_пользователей);
            this.аккаунтыTableAdapter.Fill(this.gusevaDataSet.Аккаунты);
            this.клиентыTableAdapter.Fill(this.gusevaDataSet.Клиенты);
            this.сотрудникиTableAdapter.Fill(this.gusevaDataSet.Сотрудники);
            this.договорыTableAdapter.Fill(this.gusevaDataSet.Договоры);





        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //сохранить все изменения
            
            this.Validate();
            //this.tableAdapterManager1.UpdateAll(this.gusevaDataSet);
            MessageBox.Show("Изменения сохранены");


        }

        private void dataGridViewDogovor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
            
            Program.mainForm.Show();
            Program.mainForm.Hide();
            
            Program.loginForm.Show();
            
        }
    }
}
