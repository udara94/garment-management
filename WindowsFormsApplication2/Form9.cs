using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        DBAccess9 dba = new DBAccess9();
        int loadWin = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (loadWin == 1)
            {
                AddRetailCus add = new AddRetailCus();
                add.Visible = true;
                this.Visible = false;
            }
            else if (loadWin == 2)
            {
                AddSales add = new AddSales();
                add.Visible = true;
                this.Visible = false;
            }
            else if (loadWin == 3)
            {
                AddSalesman add = new AddSalesman();
                add.Visible = true;
                this.Visible = false;
            }
            else if (loadWin == 4)
            {
                AddSalesRate add = new AddSalesRate();
                add.Visible = true;
                this.Visible = false;

            }
            else if (loadWin == 5)
            {
                SalesReturnHis add = new SalesReturnHis();
                add.Visible = true;
                this.Visible = false;
            }


        }
        private void button6_Click(object sender, EventArgs e)

        {
            lablHeadline.Text = "Customer Details";

            FillCustomer();
            loadWin = 1;
        }

        public void FillCustomer()
        {
            DataTable dt = dba.getCustomer();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lablHeadline.Text = "Sales Details";
            FillSales();
            loadWin = 2;
        }
        public void FillSales()
        {
            DataTable dt = dba.getSales();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lablHeadline.Text = "Salesman Details";
            FillSalesman();
            loadWin = 3;
        }
        public void FillSalesman()
        {
            DataTable ds = dba.getSalesman();
            dataGridView1.DataSource = ds.DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lablHeadline.Text = "Sales Rate";
            FillSalesRate();
            loadWin = 4;
        }
        public void FillSalesRate()
        {
            DataTable dt = dba.getSalesRate();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lablHeadline.Text = "Return History";
            FillReturn();
            loadWin = 5;
        }
        public void FillReturn()
        {
            DataTable dt = dba.getReturnHis();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Search button
        {
            if (loadWin == 1)
            {
                DataView DV = new DataView(dba.getCustomer());
                DV.RowFilter = string.Format("CustomerID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (loadWin == 2)
            {
                DataView DV = new DataView(dba.getSales());
                DV.RowFilter = string.Format("RetailID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (loadWin == 3)
            {
                DataView DV = new DataView(dba.getSalesman());
                DV.RowFilter = string.Format("EmpID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (loadWin == 4)
            {

                DataView DV = new DataView(dba.getSalesRate());
                DV.RowFilter = string.Format("Month LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (loadWin == 5)
            {
                DataView DV = new DataView(dba.getReturnHis());
                DV.RowFilter = string.Format("RetailID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            //DV.RowFilter = string.Format("Shop LIKE '%{0}%'", textBox1.Text);

            // dataGridView1.DataSource = DV;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (loadWin == 1)
            {
                AddRetailCus updte = new AddRetailCus();
                updte.Visible = true;
                this.Visible = false;

                //Form9 updte = new Form9();


                updte.CusID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updte.NIC.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updte.Shop.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updte.name.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updte.Address.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updte.contact.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updte.mail.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updte.Show();
            }
            else if (loadWin == 2)   //load sales info to update
            {
                AddSales updte = new AddSales();
                updte.Visible = true;
                this.Visible = false;


                 updte.lblRetailID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updte.comboMonth.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updte.textBoxshop.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updte.textBoxItm.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updte.textBoxSalesPrice.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updte.textBoxQun.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updte.textBoxPrice.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updte.textBoxAdva.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                updte.textBoxArrear.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                updte.Show();

            }
            else if (loadWin == 3)
            {
                AddSalesman updte = new AddSalesman();
                updte.Visible = true;
                this.Visible = false;

                updte.txtEmpID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updte.textShops.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
               // updte.textRegion.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updte.Show();

            }
            else if (loadWin == 4)
            {
                AddSalesRate updte = new AddSalesRate();
                updte.Visible = true;
                this.Visible = false;

                updte.comMonth.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updte.text_Income.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updte.texRate.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updte.Show();

            }

            else if (loadWin == 5)
            {
                SalesReturnHis updte = new SalesReturnHis();
                updte.Visible = true;
                this.Visible = false;

                updte.teRetailID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updte.textDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updte.textReallocate.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updte.textLoss.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updte.Show();
            }







        }

        private void RemoveBtn_click(object sender, EventArgs e)
        {
            if (loadWin == 1)
            {
                string CustomerID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string NIC = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();


                if (CustomerID != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you want to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteCus(CustomerID, NIC))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillCustomer();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }

                }
            }
            else if (loadWin == 2)
            {
                //string Month  = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string RetailID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


                if (RetailID != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you want to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteSales (RetailID))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillSales();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }

                }
            }
            else if (loadWin == 3)
            {

                string EmpID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (EmpID != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you want to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteSalesman(EmpID))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillSalesman();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }

                }
            }
            else if (loadWin == 4)
            {
                string Month = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (Month != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you want to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteSalesRate(Month))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillSalesRate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }
                }
            }
            else if (loadWin == 5)
            {
                string RetailIDD = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (RetailIDD != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you want to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteReturnHis(RetailIDD))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillReturn();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }
                }



            }

            }

                
            
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // string ID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //string ID2 = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportsDisplay RD = new ReportsDisplay();
            RD.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forecasting fc = new Forecasting();
            fc.Show();
           

        }
      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 load = new Form1();
            load.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

         
    









