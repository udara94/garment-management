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
using System.Web.SessionState;

namespace WindowsFormsApplication2
{
    public partial class LoginDetails : Form
    {
        DBAccessSession dba = new DBAccessSession();
        Security sec = new Security();
        string imgLocation = "";
        byte[] image = null;


        private static string _uname;
        private static string _pwd;

        public LoginDetails()
        {
            InitializeComponent();
        }

        private void Form10_1_Load(object sender, EventArgs e)
        {
            FillUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation;
            }
        }
        public void FillUser()
        {
            _uname = Login.logininfo.userID;
            _pwd = Login.logininfo.Pwd;
            DataTable dt = dba.getUserDetails(_uname, _pwd);
            label2.Text =(string)(dt.Rows[0][0]);
            label4.Text = (string)(dt.Rows[0][1]);
            label6.Text = (string)(dt.Rows[0][2]);
            textBox2.Text = (string)(dt.Rows[0][4]);
            try
            {
                image = (byte[])(dt.Rows[0][3]);
                var data = (byte[])(dt.Rows[0][3]);
                var stream = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(stream);
            }
            catch
            {

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
       
                if (dba.addPic(image))
                    MessageBox.Show("Saved");
                else
                    MessageBox.Show("Error");
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Dispose();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            if (imgLocation.Equals(""))
            {
                imgLocation = pictureBox2.ImageLocation;
            }
            else
            {

                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
            }
                _uname = Login.logininfo.userID;
                if (textBox3.Visible == true)
                {
                    textBox3.Text = sec.Encrypt(textBox3.Text);
                    if (dba.updateUser(textBox3.Text, _uname, image))
                        MessageBox.Show("Successfull");
                    else
                        MessageBox.Show("Error");
                }
                if (textBox3.Visible == false)
                {
                    if (dba.updateUser(textBox2.Text, _uname, image))
                        MessageBox.Show("Successfull");
                    else
                        MessageBox.Show("Error");
                }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
            //MessageBox.Show(textBox2.Text);
            if (!string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                if (textBox1.Text != textBox2.Text)
                {
                    label9.Text = "Not Matching";
                    //MessageBox.Show("Not Matching");
                }
                else
                {
                    label9.Text = "Confirmed";
                    //MessageBox.Show("Confirmed");
                }
            }

               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sec.Encrypt(textBox1.Text) == textBox2.Text)
            {
                textBox3.Visible = true;
                label8.Visible = true;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
