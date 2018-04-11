using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class customer : Form
    {
        DBAccess4 dba =new DBAccess4();
        Form4 f4 = new Form4();

        public customer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nic.Text == "" || name.Text == "" || richAddress.Text == ""|| ContNumber.Text == "" || Email.Text == "")
            {
                MessageBox.Show("please enter the all details ");
            }
 
             else if (dba.addCustomer( Nic.Text, name.Text, richAddress.Text, ContNumber.Text, Email.Text))
             {
                 MessageBox.Show("Successfully Added");
                Form4 f4 = new Form4();
                f4.Visible = true;
                this.Visible = false;

                f4.FillGrid();
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


            if (dba.updateCustomer(cusIDlabel.Text,Nic.Text, name.Text, richAddress.Text, ContNumber.Text, Email.Text))
            {
                MessageBox.Show("Successfully Updated");
                Form4 f4 = new Form4();
                this.Visible = false;
                f4.Visible = true;

                f4.FillGrid(); 

            }
            else
            {
                MessageBox.Show("Error occured");
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            cusIDlabel.Text = "";
            Nic.Text = "";
            name.Text = "";
            richAddress.Text = "";
            ContNumber.Text = "";
            Email.Text = "";

        }
        //Email validation
        public static bool IsValidEmailId(string Email)
        {
             
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }
        private void Email_TextChanged(object sender, EventArgs e)
        {

            String UserEmail = Email.Text;
            if (UserEmail == "")
            {
                label7.Text = " ";
            }
            else if (IsValidEmailId(UserEmail))
            {
                label7.Text = "This email is correct formate";
            }
            else
            {
                label7.Text = "This email is wrong formate";
            }

        }
        //NIIC validation
        private void Nic_TextChanged(object sender, EventArgs e)
        {
            if (Nic.Text == "")
            {
                Niclabel.Text = " ";
            }
           else if ((Nic.Text.Count(char.IsDigit) == 9) && (Nic.Text.EndsWith("X") || Nic.Text.EndsWith("V")) &&
            (Nic.Text[2] != '4' && Nic.Text[2] != '9'))
                {
                Niclabel.Text = "Correct NIC number";
                }
                else
                {
                Niclabel.Text = "Wrong NIC number";
            }
        }

        //phone number validation
        private void ContNumber_TextChanged(object sender, EventArgs e)
        {
            if (ContNumber.Text == "")
            {
                numlabel.Text = " ";
            }
            else if (ContNumber.Text.Count(char.IsDigit) == 10 )
                {
                numlabel.Text = " Phone number is correct ";
            }

            else
            {
                numlabel.Text = " Phone number is incorrect ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Nic.Text = "930730988V";
            name.Text = "Sarana";
            richAddress.Text = "Colombo";
            ContNumber.Text = "0775737275";
            Email.Text = "Km@gmail.com";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Dispose();
            f4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }
    }

    
    }

