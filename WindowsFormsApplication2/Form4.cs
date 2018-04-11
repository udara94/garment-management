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
    
    public partial class Form4 : Form
    {
        int selectname=0;
        DBAccess4 dba = new DBAccess4();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           // FillGrid();
        }

        public void FillGrid()
        {
            DataTable dt = dba.getCustomer();
            dataGridView1.DataSource = dt.DefaultView;
        }
        public void FillGridO()
        {
            DataTable dt = dba.getOrders();
            dataGridView1.DataSource = dt.DefaultView;
        }
        //
        public void FillGridh()
        {
            DataTable dt = dba.getpayHistory();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {




            //Add button 
            if (selectname == 1)
            {
                customer c1 = new customer();
                this.Dispose();
                c1.Visible = true;
                c1.button1.Visible = true;
                c1.button2.Visible = false;

            }
            else if (selectname == 2)
            {
                Orders o1 = new Orders();
                o1.Visible = true;
                o1.button2.Visible = true;
                o1.button3.Visible = false;
            }
            else if (selectname == 4)
            {
                payHistory ph = new payHistory();
                ph.Visible = true;
                ph.button1.Visible = true;
                ph.button3.Visible = false;
                //this.Visible = false;
            }
            /*else if (selectname == 3)
            {

                payHistory ph = new payHistory();
                ph.Visible = true;
            }*/

            else
            {

                MessageBox.Show(
                "Please select right button",
                "Error window",
                MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "View Customer Details";

            DataTable ds1 = dba.getCustomer();
            selectname = 1;
            dataGridView1.DataSource = ds1.DefaultView;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label2.Text = "View Order Details";

            DataTable ds = dba.getOrders();
            selectname = 2;
            dataGridView1.DataSource = ds.DefaultView;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Add Customer Points";

            AddCusPoint acp = new AddCusPoint();
            acp.Visible = true;
            //this.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "View Best Details";


            DataTable ds = dba.getbest();
           // selectname = 4;
            dataGridView1.DataSource = ds.DefaultView;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label2.Text = "View Payment Plan";

            //VPayPlane vpp = new VPayPlane();
           // vpp.Visible = true;
            //this.Visible = false;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "View Invoices";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Print Invoices";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (selectname == 1)
            {
                customer cu = new customer();
                cu.cusIDlabel.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cu.Nic.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cu.name.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cu.richAddress.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cu.ContNumber.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cu.Email.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cu.Show();

                cu.button2.Visible = true;
                cu.button1.Visible = false;
            }
            else if (selectname == 2)
            {
                Orders or = new Orders();
                or.orderIDlabel.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                or.cusIDtextBox.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                or.typecomboBox.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                or.sizecomboBox.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                or.ColortextBox.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                or.DesigntextBox.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                or.QuantytextBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                or.ortypecomboBox.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                or.ordateTimePicker.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                or.duedateTimePicker.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                or.comstatecomboBox.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                or.fullpaytextBox.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                or.advancetextBox.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                or.labelarrear.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                or.substatuscomboBox.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
                or.subdatetextBox.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
                or.Show();

                or.button3.Visible = true;
                or.button2.Visible = false;
            }
            else if (selectname == 4)
            {
                payHistory ph = new payHistory();
                ph.ortextBox.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ph.cidlabel.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ph.tpaylabel.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ph.advalabel.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ph.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ph.labelArear.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                ph.paymethodtextBox.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                ph.rentallabel.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                ph.donecomboBox.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                ph.fullpaystatuscomboBox.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                ph.Show();

                ph.button3.Visible = true;
                ph.button1.Visible = false;

            }
            else
            {
                MessageBox.Show("Please select right button", "Error window", MessageBoxButtons.OK);
            }
        }
        //Remove customer
        private void button10_Click(object sender, EventArgs e)
        {
            if (selectname == 1)
            {
                string cusIDtextBox = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (cusIDtextBox != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deleteCustomer(cusIDtextBox))
                        {
                            MessageBox.Show("Successfully Deleted");
                            FillGrid();
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
            else if (selectname == 2) 
                    { 
                //remove order

                string Oid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (Oid != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deleteOrder(Oid))
                        {
                            MessageBox.Show("Successfully Deleted");
                            FillGridO();
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
            else if (selectname == 4)
            {
                //remove payhistory

                string Orid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (Orid != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deletphistory(Orid))
                        {
                            MessageBox.Show("Successfully Deleted");
                            FillGridh();
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


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (selectname == 1)
            {
                DataView DV = new DataView(dba.getCustomer());
                DV.RowFilter = string.Format("CustomerId LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;

            }
            else if (selectname == 2)
            {
                DataView DV = new DataView(dba.getOrders());
                DV.RowFilter = string.Format("OrderId LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;

            }
            else if (selectname == 4)
            {
                DataView DV = new DataView(dba.getpayHistory());
               DV.RowFilter = string.Format("OrdID LIKE '%{0}%'", textBox1.Text);
               dataGridView1.DataSource = DV;
            }
            else { }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label2.Text = "View Payment History";

            DataTable ds1 = dba.getpayHistory();
            selectname = 4;
            dataGridView1.DataSource = ds1.DefaultView;

            //payHistory ph = new payHistory();
            //ph.Visible = true;
            //this.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            creportView cv = new  creportView();
            cv.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }
    }
}
