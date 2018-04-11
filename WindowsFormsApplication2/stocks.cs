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

namespace WindowsFormsApplication2
{
    public partial class stocks : Form
    {
        DBAccess1 dba = new DBAccess1();
        int lastClicked = 0;
        string selectedrow;
        public stocks()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            Form1 home = new Form1();
            home.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            if (panel7.Visible == true)
                panel7.Visible = false;
            else
                panel7.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            dataGridView1.DataSource = null;

            label2.Text = button3.Text;
            FillStockDetailsGrid();
            panel7.Visible = false;
            panel8.Visible = false;

            lastClicked = 1;
            
            //changing the text of label when diffrrent buttons are clicked
            label4.Text = "You can search by Supplier ID or Material Type.";
           
            //Set visibility of buttons 
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            pictureBox5.Visible = true;

            //set visibility of panels
            panel8.Visible = false;

        }

        public void FillStockDetailsGrid() //To fill the data in the dgv
        {


            DataView DV = new DataView(dba.selectItems());
            DataTable dt = dba.selectItems();
            dataGridView1.DataSource = DV;

        }
        //Search method for the textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel8.Visible = false;
            if (lastClicked == 1)
            {
                DataView DV = new DataView(dba.selectItems());
                DV.RowFilter = String.Format(" MaterialType LIKE '%{0}%' or SupplierId LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 2)
            {
                DataView DV = new DataView(dba.GetProductStocksDetails());
                DV.RowFilter = String.Format(" ProductID LIKE '%{0}%' or Category LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 3)
            {

            }
            else if (lastClicked == 4)
            {

            }
            else if (lastClicked == 5)
            {
                DataView DV = new DataView(dba.rol());
                DV.RowFilter = String.Format(" convert (RawStockId, 'System.String') LIKE '%{0}%' or SupplierId LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 6)
            {
                DataView DV = new DataView(dba.getSuppliers());
                DV.RowFilter = String.Format(" convert (SupplierId, 'System.String') LIKE '%{0}%' or NIC LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 7)
            {
                DataView DV = new DataView(dba.getSupPayment());
                DV.RowFilter = String.Format(" convert (SupplierId, 'System.String') LIKE '%{0}%' ", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 8)
            {
                DataView DV = new DataView(dba.rawDamage());
                DV.RowFilter = String.Format(" convert (RawStockID, 'System.String') LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
            else if (lastClicked == 9)
            {
                DataView DV = new DataView(dba.proDamage());
                DV.RowFilter = String.Format(" ProductID LIKE '%{0}%' or Category LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;

            }
            else
            {
                MessageBox.Show("Please select a button first");
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void stocks_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            //hiding buttons at the form load event
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            pictureBox5.Visible = false;
            label4.Visible = false;
            panel8.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            label2.Text = button4.Text;
            panel7.Visible = false;
            panel8.Visible = false;
            lastClicked = 2;

            //changing the text of label when diffrrent buttons are clicked
            label4.Text = "You can search by product Id and category";

            //Set visibility of buttons 
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            pictureBox5.Visible = true;

            //Clear the cuurent dgv before adding values
            dataGridView1.DataSource = null;
            //Fill the datagridView with product stock details
            FillProductStockGrid();

        }
        private void FillProductStockGrid()
        {
            DataView DV = new DataView(dba.GetProductStocksDetails());
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = DV;
            
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            //label2.Text = button5.Text;
            panel7.Visible = false;
            lastClicked = 3;
            
           // pictureBox5.Visible = true;
            panel8.Visible = false;
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            //label2.Text = button1.Text;
            panel7.Visible = false;
            panel8.Visible = false;
            lastClicked = 4;
            //Set visibility of buttons 
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            pictureBox5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            //visibility of buttons
            button9.Visible = false;
            button10.Text = "Update";
            button10.Visible = true;
            button11.Visible = false;

            label2.Text = button2.Text;
            panel7.Visible = false;
            panel8.Visible = false;
            lastClicked = 5;
         
            pictureBox5.Visible = true;

            label4.Text = "You can search by Raw Stock Id and Supplier Id";

            //Clear the cuurent dgv before adding values
            dataGridView1.DataSource = null;
            //Insert values into dgv
            FillRolGrid();
        }

        private void FillRolGrid()
        {
            DataView DV = new DataView(dba.rol());
            dataGridView1.DataSource = DV;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            label2.Text = button7.Text;
            panel7.Visible = false;
            panel8.Visible = false;
            lastClicked = 6;
            //Set visibility of buttons 
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            pictureBox5.Visible = true;

            label4.Text = "You can search by Supplier Id and NIC";

            //Clear the cuurent dgv before adding values
            dataGridView1.DataSource = null;
            //Insert values into dgv
            FillSupGrid();
        }

        private void FillSupGrid()
        {
            DataView DV = new DataView(dba.getSuppliers());
            dataGridView1.DataSource = DV;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Setting button texts
            button9.Text = "Remove";
            button10.Text = "Add";
            button11.Text = "Update";

            label2.Text = button8.Text;
            panel7.Visible = false;
            panel8.Visible = false;
            lastClicked = 7;
            //Set visibility of buttons 
            button9.Visible = false;
            button10.Visible = true;
            button11.Visible = false;
            pictureBox5.Visible = true;

            label4.Text = "You can search by supplier id";

            //Fill data grid view
            FillSupPay();
        }

        private void FillSupPay()
        {
            DataView DV = new DataView(dba.getSupPayment());
            dataGridView1.DataSource = DV;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stocks_Reports rept = new stocks_Reports();
            this.Dispose();
            rept.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            if (lastClicked == 1)
            {
                this.Dispose();
                stock_addRaw sa = new stock_addRaw();
                sa.Visible = true;

            }
            else if (lastClicked == 2)
            {
                this.Dispose();
                stocks_addProd ap = new stocks_addProd();
                ap.Visible = true;
            }
            else if (lastClicked == 6)
            {
                this.Dispose();
                stocks_addSup asu = new stocks_addSup();
                asu.Visible = true;
            }
            else if (lastClicked == 7)
            {
                
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;

            if (lastClicked == 1)
            {
                int rawId = Convert.ToInt32(selectedrow);
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DialogResult Result = MessageBox.Show("Are you sure that you want to delete this row?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (Result == DialogResult.Yes)
                    {
                        dba.drawfromrow(rawId); //dbaccess method to delete a row from table
                    }
                    else if (Result == DialogResult.No)
                    {

                    }
                    else
                    {

                    }
                    FillStockDetailsGrid();

                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click delete button");
                }
            }

            else if (lastClicked == 2)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string rawId = Convert.ToString(selectedrow);
                    dba.drawfromPro(rawId); //dbaccess method to delete a row from table
                    FillProductStockGrid();

                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click delete button");
                }
            }
            else if (lastClicked == 5)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    stocks_updateRol su = new stocks_updateRol();
                    su.label6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    su.label7.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    su.label8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    su.textBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    su.textBox2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    this.Dispose();
                    su.Visible = true;

                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click update button");
                }
            }
            else if (lastClicked == 6)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int empid = Convert.ToInt32(selectedrow);
                    dba.drawfromsup(empid); //dbaccess method to delete a row from table
                    FillSupGrid();

                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click delete button");
                }
            }
            else if (lastClicked == 8)
            {
                this.Dispose();
                stocks_damageRaw dr = new stocks_damageRaw();
                dr.Visible = true;
            }
            else if (lastClicked == 9)
            {
                this.Dispose();
                stocks_damagePro dp = new stocks_damagePro();
                dp.Visible = true;
            }
            else if (lastClicked == 7)
            {
                this.Dispose();
                stocks_addSupPay asup = new stocks_addSupPay();
                asup.Visible = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedrow=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            //int rawId = Convert.ToInt32(selectedrow);
            if (lastClicked == 1)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    stocks_updateRow sur = new stocks_updateRow();
                    sur.Visible = true;
                    sur.label8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    sur.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    sur.label10.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    sur.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    sur.textBox2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    sur.textBox4.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    sur.textBox3.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    //sur.label14.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    sur.textBox5.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    sur.textBox1.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    // sur.pictureBox3 = (byte[])(this.dataGridView1.CurrentRow.Cells[2].Value);
                    if (this.dataGridView1.CurrentRow.Cells[2].Value == DBNull.Value)
                    {
                        sur.pictureBox3.Image = null;
                    }
                    else
                    {
                        var data = (byte[])(this.dataGridView1.CurrentRow.Cells[2].Value);
                        var stream = new MemoryStream(data);
                        sur.pictureBox3.Image = Image.FromStream(stream);
                    }
                    sur.textBox6.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();


                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click Update button");
                }
            }
             
            else if (lastClicked == 2)
            {
                //rawId = Convert.ToInt32(selectedrow);
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    
                    stocks_updatePro sup = new stocks_updatePro();
                    sup.Visible = true;
                    sup.comboBox2.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    sup.comboBox1.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    sup.comboBox3.SelectedIndex = 0;
                    sup.comboBox4.SelectedIndex = 0;
                    sup.textBox1.Text= this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    sup.comboBox5.Text= this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    sup.textBox2.Text= this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    sup.comboBox6.Text= this.dataGridView1.CurrentRow.Cells[7].Value.ToString();


                 
                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click Update button");
                }
            }

            else if (lastClicked == 6)
            {
                //rawId = Convert.ToInt32(selectedrow);
                if (dataGridView1.SelectedRows.Count == 1)
                {

                    stocks_updateSup usup = new stocks_updateSup();
                    usup.Visible = true;
                    usup.label7.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    usup.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    usup.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    usup.textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    usup.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    usup.textBox5.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();



                }
                else
                {
                    MessageBox.Show("Please Select a Row first and then click Update button");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            panel7.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel8.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel6_DragEnter(object sender, DragEventArgs e)
        {
            panel8.Visible = false;
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lastClicked = 8;

            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            //Set visibility of buttons 
            button10.Text = button9.Text;
            button9.Visible = false;
            button10.Visible = true;
            button11.Visible = false;
            pictureBox5.Visible = true;

            //Setting the function name
            label2.Text = button15.Text;

            //changing the text of label when diffrrent buttons are clicked
            label4.Text = "You can change search by Raw stock Id";

            //Clear the cuurent dgv before adding values
            dataGridView1.DataSource = null;
            //Fill the datagridView with product stock details
            FillDamageRawGrid();
        }

        private void FillDamageRawGrid()
        {
            DataView DV = new DataView(dba.rawDamage());
            dataGridView1.DataSource = DV;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lastClicked = 9;

            button9.Text = "Add";
            button10.Text = "Remove";
            button11.Text = "Update";

            //Set visibility of buttons 
            button10.Text = button9.Text;
            button9.Visible = false;
            button10.Visible = true;
            button11.Visible = false;
            pictureBox5.Visible = true;

            //Setting the function name
            label2.Text = button14.Text;

            //changing the text of label when diffrrent buttons are clicked
            label4.Text = "You can search by Product ID and Category";

            //Clear the cuurent dgv before adding values
            dataGridView1.DataSource = null;
            //Fill the datagridView with product stock details
            FillDamageProGrid();
        }

        private void FillDamageProGrid()
        {
            DataView DV = new DataView(dba.proDamage());
            dataGridView1.DataSource = DV;
        }

    }
}
