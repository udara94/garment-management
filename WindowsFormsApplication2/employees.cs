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
    public partial class employees : Form
    {
        DBAccessEmp dba = new DBAccessEmp();
        view_employee v_emp = new view_employee();
        Form1 f1 = new Form1();

        public int variable = 0;
        public int var2 = 0;

        public employees()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button6.Visible = false;
            if ( variable == 1)
            {
                FillGrid();
            }
            else if(variable == 2)
            {
                getallattendence();
            }
            else if (variable == 3)
            {
                leaveing();
            }
            else { }
        }

        public void FillGrid()
        {
            DataTable dt = dba.getAllJobs();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void Fillsalary()
        {
            DataTable dt = dba.getAllsalary();
            dataGridView1.DataSource = dt.DefaultView;
        }
        

        public void getallattendence()
        {
            DataTable dt = dba.getallattendence();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void leaveing()
        {
            DataTable dt = dba.leave();
            dataGridView1.DataSource = dt.DefaultView;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (variable == 1)
            {

                var2 = 1;
                variable = 1;
                empadd ad = new empadd();
                ad.textBox1.Enabled = false;
                ad.Visible = true;
                ad.button1.Visible = true;
                this.Visible = false;
            }
            else if (variable == 3)
            {
                //variable2 = 1;
                //variable = 1;
                addleave addle = new addleave();
                addle.Visible = true;
                this.Visible = false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (variable == 1)
            {
                DataView DV = new DataView(dba.getAllJobs());
                DV.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
                label4.Text = "(Name)";
            }
            else if (variable == 2)
            {
                DataView DV = new DataView(dba.getallattendence());
                DV.RowFilter = string.Format("empid LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
                label4.Text = "(EmpID)";
            }
            else if (variable == 3)
            {
                DataView DV = new DataView(dba.leave());
                DV.RowFilter = string.Format("empid LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
                label4.Text = "(EmpID)";
            }
            else if (variable == 4)
            {
                DataView DV = new DataView(dba.getAllsalary());
                DV.RowFilter = string.Format("empid LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
                label4.Text = "(EmpID)";
            }
            else
            { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            variable = 1;
            label2.Text = "Employee Details";
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button6.Visible = false;
            FillGrid();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (variable == 1)
            {
                string empid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (empid != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deleteemp(empid))
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
            else if(variable == 3)
            {
                string no = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (no != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // confirm delete
                        if (dba.deleteemp(no))
                        {
                            MessageBox.Show("Successfully Deleted");
                            leaveing();
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
            else { }
                
                    
       }

        private void button10_Click(object sender, EventArgs e)
        {
            if (variable == 1)
            {
                var2 = 2;
                variable = 2;
                empadd emp_add = new empadd();
                emp_add.button2.Visible = true;
                emp_add.textBox_empid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                emp_add.textBoxname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                emp_add.textBoxage.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                emp_add.textBoxconno.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                emp_add.textBoxnic.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                //emp_add.birthday.Value.Date.ToString("MM/dd/yyyy") = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //emp_add.birthday.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                emp_add.richTextadd.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                emp_add.comboBox1.SelectedItem = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                emp_add.richTextBoxexp.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();

              //  emp_add.joindate.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[10].Value);
                emp_add.textBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                

                var data = (byte[])(this.dataGridView1.CurrentRow.Cells[11].Value);
                var stream = new MemoryStream(data);
                emp_add.pictureBox1.Image = Image.FromStream(stream);

                emp_add.textBox1.Enabled = true;


                emp_add.Show();
                this.Dispose();

                
            }
            else if(variable == 3)
            {
                addleave add_leave = new addleave();
                add_leave.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                add_leave.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                add_leave.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                add_leave.Show();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            variable = 2;
            label2.Text = "Employee Attendence";
            getallattendence();
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            variable = 3;
            label2.Text = "Leaving Letter";
            leaveing();
            button9.Visible = true;
            button10.Visible = false;
            button11.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable = 1;
            label2.Text = "Employee Details";
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button6.Visible = true;
            FillGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            variable = 4;
            label2.Text = "Salary Details";
            button6.Visible = false;
            Fillsalary();
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            caclulate_salary sal = new caclulate_salary();
            this.Dispose();
            sal.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            v_emp.label11.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            v_emp.label12.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            v_emp.label13.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            v_emp.label14.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            v_emp.label15.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            v_emp.label16.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //.dateTimebirthday.Value = (DateTime)this.dataGridView1.CurrentRow.Cells[5].Value;
            v_emp.label17.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            v_emp.label18.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            v_emp.label19.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            v_emp.label20.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            var data =(byte [])(this.dataGridView1.CurrentRow.Cells[11].Value);
            var stream = new MemoryStream(data);
            v_emp.pictureBox1.Image = Image.FromStream(stream);

            //emp_add.richTextBoxexp.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //  emp_add.dateTimejoindate.Value = (DateTime)this.dataGridView1.CurrentRow.Cells[9].Value;
            this.Dispose();
            v_emp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            reportemp reemp = new reportemp();
            reemp.Visible = true;
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            EmpCris ec = new EmpCris();
            ec.Visible = true;
          
        }
    }
}

