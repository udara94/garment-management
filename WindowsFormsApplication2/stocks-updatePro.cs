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
    public partial class stocks_updatePro : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_updatePro()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            this.Dispose();
            st.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            //Making field for allocations visible if the quantity is added

            if (textBox1.Text != "")
            {
                label5.Text = textBox1.Text;
                if (Convert.ToInt32(textBox1.Text) > 10)
                {
                    comboBox5.Enabled = true;
                    textBox2.Enabled = true;
                    comboBox6.Enabled = true;
                }
            }
            else
            {
                comboBox5.Enabled = false;
                textBox2.Enabled = false;
                comboBox6.Enabled = false;
                label5.Text = "";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int tb1, tb2, diff;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                tb1 = Convert.ToInt32(textBox1.Text);
                tb2 = Convert.ToInt32(textBox2.Text);
                diff = tb1 - tb2;
                label5.Text = Convert.ToString(diff);

            }
            else if (textBox1.Text != "")
            {
                label5.Text = textBox1.Text;
            }
            else
            {
                label5.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void stocks_updatePro_Load(object sender, EventArgs e)
        {
            //
            //comboBox3.SelectedIndex = 0;
           // comboBox4.SelectedIndex = 0;

            //Adding values to comboboxes from database at the form load
            DataTable dt = dba.GetProIds();
            foreach (DataRow item in dt.Rows)
            {
                comboBox2.Items.Add(item[0]);
            }

            DataTable ds = dba.GetOrdIds();
            foreach (DataRow item in ds.Rows)
            {
                comboBox6.Items.Add(item[0]);
            }

            //Setting visibility of some fields on and off at the foarm load
            label17.Visible = false;

            //
            if (textBox1.Text == "")
            {
                comboBox5.Enabled = false;
                textBox2.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex != 0 && comboBox4.SelectedIndex != 0 && textBox1.Text != "" && comboBox5.SelectedIndex != 0 && textBox2.Text != "" && comboBox6.SelectedIndex != 0 && label5.Text != "Quantity")
            {
                string pid = comboBox2.Text;
                string cat = comboBox1.Text;
                string qua = comboBox3.Text;
                string size = comboBox4.Text;

                string mar = comboBox5.Text;
                int aa = Convert.ToInt32(textBox2.Text);
                int quan = Convert.ToInt32(textBox1.Text);
                int avquan = Convert.ToInt32(label5.Text);
                string ordId = comboBox6.Text;


                if (dba.UpdateProDetail2(pid, cat, qua, size, quan, mar, aa, ordId, avquan))
                {
                    MessageBox.Show("Operations are Committed Successfully");
                }
                else
                {
                    MessageBox.Show("Operations are not committed");
                }


            }
            else if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex != 0 && comboBox4.SelectedIndex != 0 && textBox1.Text != "" /*&& comboBox5.SelectedIndex == 0 && textBox2.Text == "" && comboBox6.SelectedIndex == 0  && label5.Text != "Quantity"*/ )
            {
                string pid = comboBox2.Text;
                string cat = comboBox1.Text;
                string qua = comboBox3.Text;
                string size = comboBox4.Text;
                int quan = Convert.ToInt32(textBox1.Text);

                if (dba.UpdateProDetails1(pid, cat, qua, size, quan))
                {
                    MessageBox.Show("Operations are Committed Successfully");
                }
                else
                {
                    MessageBox.Show("Operations are not committed");
                }
            }
            else
            {
                MessageBox.Show("There are more required empty fields");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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
    }
}
