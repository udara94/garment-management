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

    public partial class AddRetailCus : Form
    {
        DBAccess9 dba = new DBAccess9();
        Form9 f9 = new Form9();
        public AddRetailCus()
        {
            InitializeComponent();
        }

        private void AddRetailCus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dba.addCus(CusID.Text, NIC.Text, Shop.Text, name.Text, Address.Text, contact.Text, mail.Text))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }

          
            NIC.Clear();
            Shop.Clear();
            name.Clear();
            Address.Clear();
            contact.Clear();
            mail.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Visible = true;
            this.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dba.UpdateCus( Shop.Text, name.Text, Address.Text, contact.Text, mail.Text, CusID.Text, NIC.Text))
            {
                MessageBox.Show("Successfully Updated");
                this.Dispose();
                f9.Show();
                f9.FillCustomer();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void CusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIC_TextChanged(object sender, EventArgs e)
        {
            if(NIC.Text == "")
            {
                NICLabel.Text = " ";
            }
            else if ((NIC.Text.Count(char.IsDigit) == 9) && (NIC.Text.EndsWith("X")|| NIC.Text.EndsWith("V")) && (NIC.Text[2]!='4' && NIC.Text[2] !='9'))
            {
                NICLabel.Text = "NIC is valid.";
            }
            else
            {
                NICLabel.Text = "NIC is not valid.";
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            if(contact.Text == "")
            {
                ContactLabel.Text = " ";
            }
            else if(contact.Text.Count(char.IsDigit)== 10)
            {
                ContactLabel.Text = "Phone number is valid.";
            }
            else
            {
                ContactLabel.Text = "Phone numbwer should contain 10 digits!";
            }
        }

        //Email Validation..
        public static bool IsMailValidate(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;

        }
        private void mail_TextChanged(object sender, EventArgs e)
        {
            string UserEmail = mail.Text;
            if (UserEmail == "")
            {
                EmailLabel.Text = " ";
            }
            else if(IsMailValidate(UserEmail))
             {
                EmailLabel.Text = "E mail is valid!";
              }
            else
            {
                EmailLabel.Text = "E mail is not valid!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // CusID.Text="";
            NIC.Text="863489675V";
            Shop.Text="Riyana Fashion House";
            name.Text="Fathima Rizna";
            Address.Text="48/R,Ganemulla";
            contact.Text="0117788334";
            mail.Text="riyana@gmail.com";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Dispose();
            f9.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }
    }

}


