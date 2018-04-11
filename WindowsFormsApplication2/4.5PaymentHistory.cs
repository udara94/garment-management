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
    public partial class payHistory : Form
    {
        DBAccess4 dba = new DBAccess4();
        Form4 f4 = new Form4();

        public payHistory()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = true;
            this.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
         
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
            /*f (ortextBox.Text = string.select_c_oID())
            {

            }*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string cid = dba.selectvalues(ortextBox.Text);
            cidlabel.Text = cid;
            string fpay = dba.selectpay(ortextBox.Text);
            tpaylabel.Text = fpay;
            string adv = dba.selectadvance(ortextBox.Text);
            advalabel.Text = adv;
            string arr = dba.selectarrear(ortextBox.Text);
            labelArear.Text = arr;







        }
        //add button payHistory
        private void button1_Click(object sender, EventArgs e)
        {
            if (ortextBox.Text == "" || cidlabel.Text == "" || tpaylabel.Text == "" || advalabel.Text == "" || dateTimePicker1.Value.Date.ToString("MM/dd/yyyy") == ""  || Convert.ToString(fullpaystatuscomboBox.SelectedItem) == "" )
            {
                MessageBox.Show("please enter the all details ");
            }

            else if (dba.addPayHistory(ortextBox.Text , cidlabel.Text, Convert.ToDouble(tpaylabel.Text) , advalabel.Text , labelArear.Text, dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"),  Convert.ToString(fullpaystatuscomboBox.SelectedItem), paymethodtextBox.Text, Convert.ToString(donecomboBox.SelectedItem), rentallabel.Text))
            {
                MessageBox.Show("Successfully Added");
                Form4 f4 = new Form4();
                f4.Visible = true;
                this.Visible = false;

                f4.FillGridh();
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            this.Dispose();
            f4.FillGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ortextBox.Text = "";
            cidlabel.Text = "";
            tpaylabel.Text = "";
            advalabel.Text = "";
            dateTimePicker1.Text = "";
            
            fullpaystatuscomboBox.Text = "";
            labelArear.Text = "";
            rentallabel.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ortextBox.Text = "O00002";
            cidlabel.Text = "C00004";
            tpaylabel.Text = "100000.00";
            advalabel.Text = "12000.00";
            dateTimePicker1.Text = "8/25/2016";
           
            fullpaystatuscomboBox.Text = "not completed";
        }
        //update button pay history
        private void button3_Click(object sender, EventArgs e)
        {
            if (dba.updatePayHistory(ortextBox.Text, dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), paymethodtextBox.Text,rentallabel.Text,Convert.ToString(donecomboBox.SelectedItem),Convert.ToString(fullpaystatuscomboBox.SelectedItem)))
            {
                MessageBox.Show("Successfully Updated");
                Form4 f4 = new Form4();

                this.Visible = false;
                f4.Visible = true;

                f4.FillGridh();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
           if (tpaylabel.Text == "" || advalabel.Text == "" || paymethodtextBox.Text == "")
            {

                MessageBox.Show("Please enter the Values");
            }
            else
            {

                float fullpay = (float)Convert.ToDouble(tpaylabel.Text);
                float advance = (float)Convert.ToDouble(advalabel.Text);
                float payMethod = (float)Convert.ToDouble(paymethodtextBox.Text);
                float total = fullpay - advance;

                //labelMrental.Text = Convert.ToString(total);
                if (payMethod == 0)
                {
                    rentallabel.Text = "Please enter the Payment method";
                }
                else if (payMethod == 1)
                {

                    rentallabel.Text = Convert.ToString(total);
                }

                else if (payMethod == 2)
                {
                    float R1 = total / 2;
                    float R2 = (R1 * 2) / 100;
                    float Rental = (R1 + R2);
                    rentallabel.Text = Convert.ToString(Rental);
                }
                else if (payMethod == 3)
                {
                    float R1 = total / 3;
                    float R2 = (R1 * 3) / 100;
                    float Rental = (R1 + R2);
                    rentallabel.Text = Convert.ToString(Rental);
                }
                else if (payMethod == 4)
                {
                    float R1 = total / 4;
                    float R2 = (R1 * 4) / 100;
                    float Rental = (R1 + R2);
                    rentallabel.Text = Convert.ToString(Rental);
                }
                else if (payMethod == 5)
                {
                    float R1 = total / 5;
                    float R2 = (R1 * 5) / 100;
                    float Rental = (R1 + R2);
                    rentallabel.Text = Convert.ToString(Rental);
                }
                else if (payMethod == 6)
                {
                    float R1 = total / 6;
                    float R2 = (R1 * 6) / 100;
                    float Rental = (R1 + R2);
                    rentallabel.Text = Convert.ToString(Rental);
                }

                else
                {

                }

            }
        }

        private void paymethodtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            paypic pp = new paypic();
            pp.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Dispose();
            f4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
