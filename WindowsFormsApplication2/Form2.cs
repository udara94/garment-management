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
using CrystalDecisions.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        DBAccess2 dba = new DBAccess2();
        DBAccessSession dba2 = new DBAccessSession();

        public int count { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void FillOtherTran()
        {
            label2.Text = ("Other Transactions");
            DataTable dt = dba.getOtherTran();
            BindingSource bs = new BindingSource();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void FillDriSal()
        {
            label2.Text = ("Drivers Salary Details");
            DataTable dt = dba.getDriverSalaryDetails();
            dataGridView1.DataSource = dt.DefaultView;
        }
        public void FillEmpSal()
        {
            label2.Text = ("Employee Salary Details");
            DataTable dt = dba.getEmployeeSalaryDetails();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void FillSales()
        {
            label2.Text = ("Sales Details");
            DataTable dt = dba.getSalesProfit();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void FillOrders()
        {
            label2.Text = ("Order Details");
            DataTable dt = dba.getOrderProft();
            dataGridView1.DataSource = dt.DefaultView;
        }


        public void FillIncome()
        {
            label2.Text = ("Company Income");
            DataTable dt = dba.getIncome();
            dataGridView1.DataSource = dt.DefaultView;
        }
        public void FillCost()
        {
            label2.Text = ("Company Cost");
            DataTable dt = dba.getCost();
            dataGridView1.DataSource = dt.DefaultView;
        }


        /*public void FillGrid5()
        {
            Login frm10 = new Login();
            DataTable dt = dba2.getPic();
            var data = (byte[])(dt.Rows[2][0]);
            var stream =new  MemoryStream(data);
            pictureBox2.Image = Image.FromStream(stream);

        }*/

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (count == 1)
            {
               

                if (comboBox1.SelectedIndex == 0)
                {
                    DataView DV = new DataView(dba.getOtherTran());
                    DV.RowFilter = string.Format(" ID LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = DV;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    DataView DV = new DataView(dba.getOtherTran());
                    DV.RowFilter = string.Format(" Description LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = DV;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    DataView DV = new DataView(dba.getOtherTran());
                    DV.RowFilter = string.Format(" Type LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = DV;
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    DataView DV = new DataView(dba.getOtherTran());
                    DV.RowFilter = string.Format("convert(Amount, 'System.String') LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = DV;
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    DataView DV = new DataView(dba.getOtherTran());
                    DV.RowFilter = string.Format("convert(Date, 'System.String') LIKE '%{0}%'",textBox1.Text);
                    dataGridView1.DataSource = DV;
                }
            }


            if (count == 3)
            {
                DataView DV = new DataView(dba.getDriverSalaryDetails());
                DV.RowFilter = string.Format(" DriverID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form2_1 f2_1 = new Form2_1();
            Form2_2 f2_4 = new Form2_2();
            if (count == 1)
            {
                f2_1.Show();
            }
            else if (count == 3)
            {
                f2_4.Show();
            }
            else
            {
                MessageBox.Show("Please select the Details");
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Form2_1 f2_1 = new Form2_1();
                f2_1.lbl_Id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f2_1.cmbTran.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f2_1.cmbType.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f2_1.txtAmount.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f2_1.dTP_Date.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f2_1.Show();

                f2_1.button4.Visible = true;
                f2_1.label10.Visible = true;
                f2_1.lbl_Id.Visible = true;
                f2_1.button3.Visible = false;
                f2_1.button1.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select the Details");
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            string cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (id != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deleteOtherTran(id))
                        {
                            MessageBox.Show("Successfully Deleted");
                            FillOtherTran();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting");
                        }

                    }
                    else
                    {
                        //No delete
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the row");
                }
            }
            else
            {

                MessageBox.Show("Please select the Details");

            }

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            //FillGrid3();
            FillOrders();
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;

            label4.Visible = false;
            comboBox1.Visible = false;
            //groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillSales();
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;

            label4.Visible = false;
            comboBox1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //FillGrid2_1();
            FillEmpSal();

            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;

            groupBox1.Visible = false;

            label4.Visible = false;
            comboBox1.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (groupBox1.Visible == true)
                groupBox1.Visible = false;
            else
                groupBox1.Visible = true;
        }

        private void Driver_Salary_Click(object sender, EventArgs e)
        {
            count = 3;
            FillDriSal();
            groupBox1.Visible = false;

            btn_Add.Visible = true;
        }

        private void Other_Tran_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            comboBox1.Visible = true;
            
            btn_Add.Visible = true;
            btn_Remove.Visible = true;
            btn_Update.Visible = true;
       
            count = 1;
            FillOtherTran();
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            InvoiceView inView = new InvoiceView();
            inView.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;

            label4.Visible = false;
            comboBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == true)
                panel7.Visible = false;
            else
                panel7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frm10 = new Login();
            frm10.Visible = true;
            this.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            LoginDetails frm10_1 = new LoginDetails();
            frm10_1.Visible = true;
            this.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FillCost();
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;
            groupBox2.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FillIncome();
            btn_Add.Visible = false;
            btn_Remove.Visible = false;
            btn_Update.Visible = false;
            groupBox2.Visible = false;
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FillSales();
            btn_Add.Visible = true;
            btn_Remove.Visible = true;
            btn_Update.Visible = true;
            count = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btn_Add.Visible = true;
            btn_Remove.Visible = true;
            btn_Update.Visible = true;
            count = 4;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            if (groupBox1.Visible == true)
                groupBox1.Visible = false;
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
            else
                groupBox2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _2_Sheetcs test = new _2_Sheetcs();
            test.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BalanceView bv = new BalanceView();
            bv.Visible = true;
        }
    }
}
