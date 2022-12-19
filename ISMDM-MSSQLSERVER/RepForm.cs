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
    public partial class RepForm : Form
    {
        public RepForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
         
            //export to pdf
            //https://www.c-sharpcorner.com/article/export-datagridview-data-to-pdf-in-windows-forms-using-itextsharp/
            
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  


            //worksheet = workbook.Sheets["Лист1"];
            var sheet1 = workbook.Sheets.Add();
            worksheet = sheet1;
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < Program.form1.dataGridViewClient.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Program.form1.dataGridViewClient.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < Program.form1.dataGridViewClient.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Program.form1.dataGridViewClient.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Program.form1.dataGridViewClient.Rows[i].Cells[j].Value.ToString();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            Microsoft.Office.Interop.Excel._Worksheet worksheet1 = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  

            sheet1 = workbook.Sheets.Add();
            worksheet = sheet1;
            //worksheet = workbook.Sheets["Лист2"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview1";
            // storing header part in Excel  
            for (int i = 1; i < Program.form1.dataGridView3.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Program.form1.dataGridView3.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < Program.form1.dataGridView3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Program.form1.dataGridView3.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Program.form1.dataGridView3.Rows[i].Cells[j].Value.ToString();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////
            Microsoft.Office.Interop.Excel._Worksheet worksheet2 = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  



            sheet1 = workbook.Sheets.Add();
            worksheet = sheet1;
            //worksheet = workbook.Sheets["Sheet3"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview2";
            // storing header part in Excel  
            for (int i = 1; i < Program.form1.dataGridViewEmpl.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Program.form1.dataGridViewEmpl.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < Program.form1.dataGridViewEmpl.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Program.form1.dataGridViewEmpl.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Program.form1.dataGridViewEmpl.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            }
            catch
            {

            }
        }
    }
}
