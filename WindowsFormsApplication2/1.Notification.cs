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
    public partial class Notification : Form
    {
        DBAccessSession dba = new DBAccessSession();

        private static string _uname;
        private static string _pwd;

        public Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _uname = Login.logininfo.userID;
            DateTime date =  dateTimePicker1.Value;
            
            if (comboBox1.Text != "" && richTextBox1.Text != "")
            {
                if (dba.SendMsg(date, comboBox1.Text, _uname, richTextBox1.Text))
                {
                    MessageBox.Show("Successfully Send");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All");
            }
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            FillUsersname();
            try
            {
                FillMsg();
            }
            catch
            { }
        }

        public void FillMsg()
        {
            _uname = Login.logininfo.userID;
            _pwd = Login.logininfo.Pwd;
            DataTable dt = dba.getUserDetails(_uname, _pwd);
            string test = (string)(dt.Rows[0][2]);

            DataTable dt2 = dba.ReceiveMsg(test);
            label4.Text = dt2.Rows[0][0].ToString();
            richTextBox1.Text = dt2.Rows[0][1].ToString();
        }

        public void FillUsersname()
        {
            DataTable dt = dba.getUsersname();
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }

        }

    private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Visible = false;
        }
    }
}
