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
    public partial class stocks_damageRaw : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_damageRaw()
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

        private void stocks_damageRaw_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;

            //setting visibility
            label10.Visible = false;
            

            //Adding values to comboboxes from database at the form load
            //comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            DataTable dt = dba.Stocks();
            foreach (DataRow item in dt.Rows)
            {
                comboBox1.Items.Add(item[0]);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' )
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double cost;
            label10.Visible = false;
            if (textBox1.Text == "")
            {
                label10.Visible = true;
                cost = 0;
                label6.Text = "";
            }
            else if (textBox1.Text.IndexOf('.') != textBox1.Text.LastIndexOf('.'))
            {
                label10.Visible = true;
            }
            else
            {
                label9.Text = label6.Text;
                label10.Visible = false;
                cost =(dba.getCost(Convert.ToInt32(comboBox1.Text)));
                label6.Text = Convert.ToString(cost*Convert.ToDouble(textBox1.Text));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label11.Text = "";
            }
            else
            {
                int dd = Convert.ToInt32(comboBox1.Text);
                string ms = dba.getMeasure(dd);
                label11.Text = ms;
            }

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double rec;
            if (label6.Text == "")
            {
                label9.Text = "";
            }
            else if(textBox2.Text=="")
            {
                rec = 0;
                label9.Text = label6.Text;

            }
            else
            {
                rec = Convert.ToDouble(textBox2.Text);
                double cos = Convert.ToDouble(label6.Text);
                label9.Text = Convert.ToString(cos - rec);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != 0 && label11.Text != "" && textBox1.Text != "" && label6.Text != "")
            {
                double rec = 0;
                double net = 0;
                String dat = Convert.ToString( dateTimePicker1.Value);
                int id = Convert.ToInt32(comboBox1.Text);
                String added =Convert.ToString(DateTime.Today);
                string mes = label11.Text;
                double quan = Convert.ToDouble(textBox1.Text);
                double cos = Convert.ToDouble(label6.Text);
                net = Convert.ToDouble(label9.Text);
                if (textBox2.Text != "" /* && label9.Text != "" */)
                {
                    rec = Convert.ToDouble(textBox2.Text);
                   
                }
                else
                {
                    rec = 0;
                    //net = 0;
                }

                if (dba.AddDamRaw(dat, id, added, mes, quan, cos, rec, net))
                {
                    MessageBox.Show("All the operations are committed successfully");
                }
                

            }
            else if (comboBox1.SelectedIndex == 0 || label11.Text == "" || textBox1.Text == "" || label6.Text == "" || textBox2.Text == "" || label9.Text == "")
            {
                MessageBox.Show("There are more required fields to fill");
            }
            else
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = 0;
            label11.Text = null;
            textBox1.Text = "";
            label6.Text = "";
            textBox2.Text = "";
            label9.Text = "";

        }
    }
}
