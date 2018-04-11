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
    public partial class caclulate_salary : Form
    {
        DBAccessEmp dba = new DBAccessEmp();
        employees f8 = new employees();
        
        public caclulate_salary()
        {
            InitializeComponent();
        }

        private void caclulate_salary_Load(object sender, EventArgs e)
        {
            getid_name();
        }

        public void getid_name()
        {
            DataTable dt = dba.getid_name();
            dataGridView1.DataSource = dt.DefaultView;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            /* dba.select_hour(textBox1.Text);
             ()*/
            float basic = (float)Convert.ToDouble(textBox2.Text);
             bool valid = float.TryParse(textBox2.Text.ToString(), out basic);

             float hour = (float)Convert.ToDouble(textBox3.Text);
             bool valid2 = float.TryParse(textBox3.Text.ToString(), out hour);

             float allow = (float)Convert.ToDouble(textBox4.Text);
             bool valid3 = float.TryParse(textBox4.Text.ToString(), out allow);

             float rate = (float)Convert.ToDouble(textBox6.Text);
             bool valid4 = float.TryParse(textBox6.Text.ToString(), out rate);

             float net_sal = (hour * rate) + basic + allow;
             textBox5.Text = net_sal.ToString();
            //textBox3.Text = dba.work_days(textBox1.Text, Convert.ToString(comboBox1.SelectedItem));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
           if (dba.addsalary(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox4.Text, textBox5.Text,date))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            //f8.leaveing();
            this.Dispose();
            f8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            textBox3.Text = "100";
            textBox4.Text = "2000";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            emp.Visible = true;
            this.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = dba.calwork_houres(textBox1.Text, Convert.ToString(comboBox1.SelectedItem));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox3.Text);
            if (x>=180)
            {
                textBox4.Text = "2000";
            }
            else if(x >= 170)
            {
                textBox4.Text = "1000";
            }
            else
            {
                textBox4.Text = "0";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            this.Dispose();
            emp.Visible = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }
    }
}
