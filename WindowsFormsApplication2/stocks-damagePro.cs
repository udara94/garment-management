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
    public partial class stocks_damagePro : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_damagePro()
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

        private void stocks_damagePro_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;

            comboBox1.SelectedIndex = 0;

            //Intial visibilities of labels
            label13.Visible = false;

            //Add details to comboboxes
            DataTable dt = dba.GetProIdsFrmStk();
            foreach (DataRow item in dt.Rows)
            {
                comboBox1.Items.Add(item[0]);
            }

            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label9.Text = "";
                label10.Text = "";
            }
            else
            {
                string dd = Convert.ToString(comboBox1.Text);
                string ms = dba.getCat(dd);
                string sz = dba.getSize(dd);
                label9.Text = ms;
                label10.Text = sz;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
                label11.Text = "";
            }
            else
            {
                int quan = Convert.ToInt32(textBox1.Text);
                string id = comboBox1.Text;
                double cos = Convert.ToDouble(dba.getProCost(id));
                label11.Text = Convert.ToString(quan * cos);
                label2.Text = label11.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                label13.Visible = true;
            }
            else
            {
                if (textBox2.Text != "")
                {
                    
                    label13.Visible = false;
                    label12.Text = Convert.ToString(Convert.ToDouble(label11.Text) - Convert.ToDouble(textBox2.Text));

                    if (textBox2.Text == "")
                    {
                        label2.Text = label11.Text;
                    }

                }
                else
                {
                    label2.Text = label11.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || label9.Text == "" || label10.Text == "" || textBox1.Text == "" || label11.Text == "" || textBox2.Text == "" || label12.Text == "")
            {
                MessageBox.Show("There are more empty field(s) needed to be filled");
            }
            else 
            {
                String dat =Convert.ToString( dateTimePicker1.Value);
                string added = Convert.ToString( DateTime.Today);
                string pid = comboBox1.Text;
                string cat = label9.Text;
                string size = label10.Text;
                int quan = Convert.ToInt32(textBox1.Text);
                double cos = Convert.ToDouble(label11.Text);
                double rec = Convert.ToDouble(textBox2.Text);
                double net = Convert.ToDouble(label12.Text);

                if (dba.AddDamPro(dat, added, pid, cat, size, quan, cos, rec, net))
                {
                    MessageBox.Show("Opertions were comitted successfully");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Text = "Select One";
            label9.Text = "";
            label10.Text = "";
            textBox1.Text = "";
            label11.Text = "";
            textBox2.Text = "";
            label12.Text = "";
        }
    }
}
