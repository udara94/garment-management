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
    public partial class stocks_updateSup : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_updateSup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            this.Dispose();
            st.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 'v' || e.KeyChar == 'V')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                if (ValidateNIC(textBox1.Text) == true)
                {
                    label8.Visible = false;
                }
                else
                {
                    label8.Visible = true;
                }
            }
        }

        private bool ValidateNIC(string p)
        {
            bool isMatchCase = Regex.IsMatch(p, @"^\d{9}(V|v)$");
            return isMatchCase;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                if (textBox4.Text.Length == 10 || textBox4.Text.Length == 9)
                {
                    label9.Visible = false;
                }
                else
                {
                    label9.Visible = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                label10.Visible = false;
            }
            else
            {
                bool isEmail = Regex.IsMatch(textBox5.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail == true)
                {
                    label10.Visible = false;
                }
                else
                {
                    label10.Visible = true;
                }

            }
        }

        private void stocks_updateSup_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                int id = Convert.ToInt32(label7.Text);
                string nic = textBox1.Text;
                string name = textBox2.Text;
                string address = textBox3.Text;
                int phone = Convert.ToInt32(textBox4.Text);
                string email = textBox5.Text;

                if (dba.UpdateSupDetails1(id,nic, name, address, phone, email))
                {
                    MessageBox.Show("Values are updated successfully");
                }
                else
                {
                }
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
            {
                int id = Convert.ToInt32(label7.Text);
                string nic = textBox1.Text;
                string name = textBox2.Text;
                string address = textBox3.Text;
                int phone = Convert.ToInt32(textBox4.Text);
                // string email = textBox5.Text;

                if (dba.UpdateSupDetails2(id,nic, name, address, phone))
                {
                    MessageBox.Show("Values are updated successfully");
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("There are more fields that need to be filled");
            }
        }
    }
}
