using ISMDM_MSSQLSERVER.Classes;
using ISMDM_MSSQLSERVER.Forms;
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
    public partial class Item : Form
    {
        Client client;

        //ScheduleRepo scheduleRepo = Program.mainMenu.scheduleRepo;
        JobRepo jobRepo = Program.mainForm.jobRepo;
        ClientRepo clientRepo = Program.mainForm.clientRepo;
        EmplRepo emplRepo = Program.mainForm.emplRepo;

        Empl empl;
        public Item()
        {
            InitializeComponent();
        }
    

        public Item(Empl empl)
        {
            InitializeComponent();
            
            this.empl = empl;


            string fio = emplRepo.GetEmployeesFIOById(empl.Код_сотрудника);

            l_name.Text = fio;
            l_spec.Text = empl.Телефон;
            lb_job.Text = Program.mainForm.jobRepo.GetByCode(empl.Код_должности).Наименование_должности;

            SetRoundedShape(panel1, 10);

        }

        public Item(Client client)
        {
            InitializeComponent();

            this.client = client;


            string fio = clientRepo.GetClientsFIOById(client.Код_клиента);

            l_name.Text = fio;
            l_spec.Text = client.Телефон;
            panel1.Visible = false;

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
        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void Item_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void Item_Click(object sender, EventArgs e)
        {
            //if (client != null)
            //{
            //    Program.mainMenu.mmConfigurePerson(this.client);
            //}
            //else if (empl != null)
            //{
            //    Program.mainMenu.mmConfigurePerson(this.empl);

            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                Program.mainForm.confPerson(this.client);
            }
            else if (empl != null)
            {
                Program.mainForm.confPerson(this.empl);

            }
        }
    }
}
