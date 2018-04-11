using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    public partial class Forecasting : Form
    {
        DBAccess9 dba = new DBAccess9();
        public Forecasting()
        {
            InitializeComponent();
        }

        private void Forecasting_Load(object sender, EventArgs e)
        {
            FillSalesRate();

        }
        public void FillSalesRate()
        {
            DataTable dt = dba.getSalesRateOnly();
            dataGridView2.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileTest = "D:\\Temp\\tests.xlsx";
            if (File.Exists(fileTest))
            {
                File.Delete(fileTest);
            }
            Excel.Application oApp;
            Excel.Worksheet osheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            osheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            osheet.Cells[1, 1] = "Values";

            oBook.SaveAs(fileTest);
            oBook.Close();
            oApp.Quit();



         
        }
        private void copyAlltoClipboard()
        {
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);



          //  Excel.Range chartRange;

           
         
        }

        private void ChartLoad_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Udara Indrajith\Desktop\NewChartpass.png");

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Visible = true;
            this.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            this.Dispose();
            frm9.Visible = true;
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }
    }
}
