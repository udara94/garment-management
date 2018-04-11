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
    public partial class stocks_addSupPay : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_addSupPay()
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

        private void stocks_addSupPay_Load(object sender, EventArgs e)
        {
            //Adding values to combobox from database
            DataTable dt = dba.Suppliers();
            foreach (DataRow item in dt.Rows)
            {
                comboBox1.Items.Add(item[0]);
            }

            //setting selected index for the combo box

            comboBox1.SelectedIndex = 0;
            
            label3.Text = Convert.ToString(DateTime.Now);

            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
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
                label5.Visible = false;
            }
            else
            {
                if (textBox1.Text.IndexOf('.') != textBox1.Text.LastIndexOf('.'))
                {
                    label5.Visible = true;

                }
                else
                {
                    label5.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && textBox1.Text != "")
            {
                int id = Convert.ToInt32(comboBox1.Text);
                string date = Convert.ToString( DateTime.Today);
                double payment = Convert.ToDouble(textBox1.Text);

                if (dba.AddSupPay(id, date, payment))
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("There are more empty fields to fill");
            }
        }
    }
}
