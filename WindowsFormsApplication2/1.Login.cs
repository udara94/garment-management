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
using System.Configuration;


namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        DBAccessSession dbas = new DBAccessSession();
        Security sec = new Security();
        
        public Login()
        {
            InitializeComponent();
        }
  

        private void Form10_Load(object sender, EventArgs e)
        {
         
               
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 test = new Form1();
            logininfo.userID=txtUsername.Text;
            logininfo.Pwd = sec.Encrypt(txtPwd.Text);
            if (login(txtUsername.Text.Trim(),sec.Encrypt(txtPwd.Text)))
            {
                Form1 f1 = new Form1();

                this.Visible = false;

                f1.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username & Password");
                txtUsername.Text = "";
                txtPwd.Text = "";
            }
        }

        private bool login(string user, string pwd)
        {

            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection NewCon = new SqlConnection(ConStr);
            NewCon.Open();

            SqlCommand newCmd = NewCon.CreateCommand();
            newCmd.Connection = NewCon;
            newCmd.CommandType = CommandType.Text; //sec.Encrypt(pwd)
            newCmd.CommandText = "select UserPassword from Users where UserName='" + user + "' and UserPassword = '" + pwd + "'";

          
            SqlDataReader dr = newCmd.ExecuteReader();
            if (dr.HasRows)
            {
                newCmd.Dispose();
                NewCon.Close();
                return true;
            }

            newCmd.Dispose();
            NewCon.Close();
            return false;

        }

        //Passing the Username and Password 
        public class logininfo
        {
            public static string userID;
            public static string Pwd;
        }

        private void demo_login_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Oshan";
            txtPwd.Text = "test";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           attendence at = new attendence();
           at.Show();
            
        }
    }
   
}


