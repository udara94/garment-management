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
    public partial class Form2_2 : Form
    {

        DBAccess2 dba = new DBAccess2();
        Form2 f2 = new Form2();
        private static string _valueDay;
        private static string _valueTurn;

        public Form2_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label16.Text == "" || textBox3.Text == "" || label17.Text == "" || textBox5.Text == "")
            {
                if (label16.Text == "")
                {
                    panel1.Visible = true;
                }
                if (textBox3.Text == "")
                {
                    panel2.Visible = true;
                }
                if (label17.Text == "")
                {
                    panel3.Visible = true;
                }
                if (textBox5.Text == "")
                {
                    panel4.Visible = true;
                }
            }
            else
            {

                float day = (float)Convert.ToDouble(label16.Text);
                bool valid = float.TryParse(label16.Text.ToString(), out day);

                int atten = Convert.ToInt32(textBox3.Text);

                float dayprice = day * atten;

                float turn = (float)Convert.ToDouble(label17.Text);
                bool valid2 = float.TryParse(label17.Text.ToString(), out turn);

                int Noturn = Convert.ToInt32(textBox5.Text);

                float turnprice = turn * Noturn;

                float netprice = dayprice + turnprice;


                textBox6.Text = netprice.ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem==null || label16.Text == "" || textBox3.Text == "" || label17.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                if (comboBox1.SelectedItem == null)
                {
                    panel1_1.Visible = true;
                }
                if (label16.Text == "")
                {
                    panel1.Visible = true;
                }
                if (textBox3.Text == "")
                {
                    panel2.Visible = true;
                }
                if (label17.Text == "")
                {
                    panel3.Visible = true;
                }
                if (textBox5.Text == "")
                {
                    panel4.Visible = true;
                }
                if (textBox6.Text == "")
                {
                    panel5.Visible = true;
                }
            }
            else
            {
                string date = DateTime.Today.Date.ToString("MM/dd/yyyy");
                if (dba.addDriverSalaryDetails(Convert.ToString(comboBox1.SelectedItem), date , Convert.ToInt32(label16.Text), textBox3.Text, Convert.ToInt32(label17.Text), textBox5.Text, textBox6.Text))
                {
                    MessageBox.Show("Successfully Added");
                    f2.FillDriSal();

                }
                else
                {
                    MessageBox.Show("Error occured");
                }


                this.Dispose();
                f2.Show();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1_1.Visible = false;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.Visible = false;
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Visible = false;
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label16.Text = "1200";
            textBox3.Text = "2";
            label17.Text = "1200";
            textBox5.Text = "2";
        }

        private void Form2_2_Load(object sender, EventArgs e)
        {
            GetDriverID();
            _valueDay = DefaultValue.Value_day;
            label16.Text = _valueDay;
            _valueTurn = DefaultValue.Value_turn;
            label17.Text = _valueTurn;
            textBox6.Enabled = false;

        }

        public void GetDriverID()
        {
            DataTable dt = dba.getDriverID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.Visible = true;
            label16.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("Please Enter Value");
            else
            {
                label16.Text = textBox2.Text;
                label16.Visible = true;
                textBox2.Visible = false;
                DefaultValue.Value_day = label16.Text;
                linkLabel1.Visible = true;
                linkLabel2.Visible = false;

            }

        }
        public class DefaultValue
        {
            public static string Value_day;
            public static string Value_turn;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox4.Visible = true;
            label17.Visible = false;
            linkLabel4.Visible = false;
            linkLabel3.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Please Enter Value");
            else
            {
                label17.Text = textBox4.Text;
                label17.Visible = true;
                textBox4.Visible = false;
                DefaultValue.Value_turn = label17.Text;
                linkLabel4.Visible = true;
                linkLabel3.Visible = false;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Visible = false;
        }
    }
}
