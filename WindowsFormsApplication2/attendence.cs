using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class attendence : Form
    {
        public int max { get; set; }

        DBAccessEmp dba = new DBAccessEmp();
        public attendence()
        {
            InitializeComponent();

        }

        /*private void button1_Click(object sender, EventArgs e)
        {

            //type 1-use for in 0-use for out

            string type = "0";
            string day = DateTime.Now.ToString("dd/MM/yyyy");
            string month = DateTime.Today.Date.Month.ToString();
            string year = DateTime.Today.Date.Year.ToString();
            string time = DateTime.Now.ToString("HH:mm");

           /* string max = dba.selectmaxrow(textBox1.Text);
            string val = dba.typedefine(max);*/

           /* if (dba.selectemp(textBox1.Text) == "null")
            {
                type = "1";
                if (dba.addattendence(textBox1.Text, day, month, year, type, time))
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
            else
            {
                string max = dba.selectmaxrow(textBox1.Text);
                string val = dba.typedefine(max);
                if (val == "0")
                {
                    
                    type = "1";
                    if (dba.addattendence(textBox1.Text, day, month, year, type, time))
                    {
                        MessageBox.Show("Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("Error occured");
                    }

                }
                else if (val == "1")
                {
                    
                    type = "0";
                    if (dba.addattendence(textBox1.Text, day, month, year, type, time))
                    {
                        MessageBox.Show("Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("Error occured");
                    }
                }
                else
                {

                }



            }



            
        }*/

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Dispose();
        }

        /*private void button2_Click_1(object sender, EventArgs e)
        {
            string max = dba.selectemp(textBox1.Text);
           // string val = dba.typedefine(max);
            MessageBox.Show(max);
        }*/

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //type 1-use for in 0-use for out

                string type = "0";
                string day = DateTime.Now.ToString("dd/MM/yyyy");
                string month = DateTime.Today.Date.Month.ToString();
                string year = DateTime.Today.Date.Year.ToString();
                string time = DateTime.Now.ToString("HH:mm");
                string duration = "0";

                /* string max = dba.selectmaxrow(textBox1.Text);
                 string val = dba.typedefine(max);*/

                if (dba.selectemp(textBox1.Text) == "null")
                {
                    type = "1";
                    if (dba.addattendence(textBox1.Text, day, month, year, type, time, duration))
                    {
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error occured");
                    }
                }
                else
                {
                    string max = dba.selectmaxrow(textBox1.Text);
                    string val = dba.typedefine(max);
                    if (val == "0")
                    {

                        type = "1";
                        if (dba.addattendence(textBox1.Text, day, month, year, type, time, duration))
                        {
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                        }

                    }
                    else if (val == "1")
                    {
                        string max_value = dba.get_last_atten(textBox1.Text);
                        //MessageBox.Show(max_value);
                        string time2 = dba.get_last_time(max_value);
                        DateTime t1 = Convert.ToDateTime(time2);
                        DateTime t2 = Convert.ToDateTime(time);
                        TimeSpan ts = t2.Subtract(t1);
                        DateTime t3 = Convert.ToDateTime(ts.ToString());
                        //string t = DateTime.Convert.ToString("HH:mm");
                        string houre = t3.ToString("HH");
                        string min = t3.ToString("mm");
                        int minint = Int32.Parse(min);
                        if (minint >=30)
                        {
                            int houreint = Int32.Parse(houre);
                            houreint = houreint + 1;
                            duration = Convert.ToString(houreint);
                        }
                        else
                        {
                            duration = houre;
                        }
                        type = "0";
                        if (dba.addattendence(textBox1.Text, day, month, year, type, time,duration))
                        {
                            duration = "0";
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                        }
                    }
                    else
                    {

                    }



                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void attendence_Load(object sender, EventArgs e)
        {

        }
    }
}
