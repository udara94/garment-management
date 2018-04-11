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
    public partial class Form1 : Form
    {

        DBAccessSession dba = new DBAccessSession();
        //byte[] image = null;
        private static string _uname;
        private static string _pwd;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillUser();


        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.UseVisualStyleBackColor = false;
            button5.BackColor = Color.DodgerBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stocks frm6 = new stocks();
            frm6.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees frm8 = new employees();
            frm8.Show();
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Dispose();
        }

        public void FillUser()
        {
            _uname = Login.logininfo.userID;
            _pwd = Login.logininfo.Pwd;
            DataTable dt = dba.getUserDetails(_uname, _pwd);
            try
            {
                label1.Text = (string)(dt.Rows[0][0]);
                string test = (string)(dt.Rows[0][2]);
            

            if (test == "Admin")
            {
                button12.Visible = true;
            }
            if (test == "Accountant")
            {
                button5.Visible = false;
            }
            }
            catch
            {

            }

            try
            {
                var data = (byte[])(dt.Rows[0][3]);
                var stream = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(stream);
            }
            catch
            {

            }


        }

        public void FillGrid1()
        {
            DataTable dt2 = dba.getPic();
            var data = (byte[])(dt2.Rows[3][0]);
            var stream = new MemoryStream(data);
            pictureBox2.Image = Image.FromStream(stream);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Dispose();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Dispose();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.DodgerBlue;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.DodgerBlue;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.UseVisualStyleBackColor = false;
            button3.BackColor = Color.DodgerBlue;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.UseVisualStyleBackColor = false;
            button4.BackColor = Color.DodgerBlue;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.UseVisualStyleBackColor = false;
            button6.BackColor = Color.DodgerBlue;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.UseVisualStyleBackColor = false;
            button7.BackColor = Color.DodgerBlue;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.UseVisualStyleBackColor = false;
            button8.BackColor = Color.DodgerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(1, 179, 227);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login frm10 = new Login();
            frm10.Visible = true;
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoginDetails frm10_1 = new LoginDetails();
            frm10_1.Visible = true;
            this.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //attendence at = new attendence();
            //at.Show();
            //this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MsgPanl.Visible == true)
                MsgPanl.Visible = false;
            else
                MsgPanl.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            AddUser ad = new AddUser();
            ad.Visible = true;
            this.Visible = false;

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ShowMessages msgs = new ShowMessages();
            msgs.Visible = true;
            this.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Notification msg = new Notification();
            msg.Visible = true;
            this.Visible = false;

        }
    }
}
