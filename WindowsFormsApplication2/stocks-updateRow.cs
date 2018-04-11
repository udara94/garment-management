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
    public partial class stocks_updateRow : Form
    {
        string imgLocation = "";
        DBAccess1 dba = new DBAccess1();
        public stocks_updateRow()
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

        private void stocks_updateRow_Load(object sender, EventArgs e)
        {
            //Steeing some labels and textboxes not visible at the form load
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label9.Visible = false;
            textBox4.Visible = false;

            //Setting up initial value for the textbox at the foarm load 
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
           // comboBox3.SelectedIndex = 0;
            

           /* //Adding values to combobox from database
            DataTable dt = dba.Suppliers();
            foreach (DataRow item in dt.Rows)
            {
                comboBox3.Items.Add(item[0]);
            } */

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string f = textBox2.Text;
            //Making field for allocations visible if the quantity is added
            if (f == "" || textBox2.Text.IndexOf('.') != textBox2.Text.LastIndexOf('.') || f == ".")
            {
                label9.Visible = false;
                textBox4.Visible = false;
                label14.Visible = false;
                label20.Visible = false;
            }
            else
            {
                double a = Convert.ToDouble(textBox2.Text);
                if (a > 0)
                {
                    //label18.Visible = true;
                    label9.Visible = true;
                    textBox4.Visible = true;
                    label14.Text = textBox2.Text;
                }
                else
                {
                    label9.Visible = false;
                    textBox4.Visible = false;
                    label20.Visible = false;
                }
            }
            //Validation for the field

            if (f.IndexOf('.') != f.LastIndexOf('.'))
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            label14.Visible = true;
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox2.Text;
            string f = textBox4.Text;
            if (f.IndexOf('.') != f.LastIndexOf('.') || f == ".")
            {
                label19.Visible = true;
            }
            else
            {
                label19.Visible = false;
            }

            //Checking for enough stock before doing allocations
            double a = 0;
            double b = 0;


            if (textBox4.Text.Equals("") || textBox4.Text.IndexOf('.') != textBox4.Text.LastIndexOf('.') || f == ".")
            {
                // string d=textBox4.Text;
                if (textBox4.Text.Equals(""))
                {
                    //label19.Visible = true;
                }
                else if (textBox4.Text.IndexOf('.') != textBox4.Text.LastIndexOf('.') || f == ".")
                {
                    label19.Visible = true;
                }
                else
                {
                    label19.Visible = false;
                }
            }
            else
            {
                a = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox4.Text);

                if (a < b)
                {
                    label20.Visible = true;
                }
                else
                {
                    label20.Visible = false;

                    label14.Text = Convert.ToString(a - b);

                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string f = textBox4.Text;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }


            //Checking for enough stock before doing allocations
            double a = 0;
            double b = 0;


            if (textBox2.Text.Equals("") || textBox4.Text.Equals("") || textBox4.Text.IndexOf('.') != textBox4.Text.LastIndexOf('.'))
            {
                if (textBox2.Text.Equals("") || textBox4.Text.IndexOf('.') != textBox4.Text.IndexOf('.'))
                {
                    label20.Visible = true;
                    label19.Visible = true;
                }
                else
                {
                    label20.Visible = false;
                    label19.Visible = false;
                }
            }
            else
            {
                a = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox4.Text);

                if (a < b)
                {
                    label20.Visible = true;
                }
                else
                {
                    label19.Visible = false;
                    label20.Visible = false;
                    label14.Visible = true;
                    label14.Text = Convert.ToString(a - b);


                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string f = textBox3.Text;
            if (f.IndexOf('.') != f.LastIndexOf('.'))
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            string f = textBox1.Text;
            if (f.IndexOf('.') != f.LastIndexOf('.'))
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox3.ImageLocation = imgLocation;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] image = null;

            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "")
            {
                if (imgLocation.Equals(""))
                {
                    // imgLocation = pictureBox3.ImageLocation;
                    // image = pictureBox3.Image.c;
                    // ImageConverter converter = new ImageConverter();
                    //image = pictureBox3.Image;
                    //image = ImageConverter(pictureBox3.Image);

                   

                }
                else
                {
                  //  MessageBox.Show(imgLocation);
                    FileStream stream = new FileStream(this.imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                }

                string um = comboBox1.Text;
                string mt = comboBox2.Text;
                
                double qu = Convert.ToDouble(textBox2.Text);

                //Setting value of allocations
                string al;
                if (textBox4.Text != "")
                {
                    al = textBox4.Text;
                }
                else
                {
                    al = "0";
                }

                double up = Convert.ToDouble(textBox3.Text);
                double aq = Convert.ToDouble(label14.Text);
                string remarks;
                if (textBox5.Text == "")
                {
                    remarks = "none";
                }
                else
                {
                    remarks = textBox5.Text;
                }
                double rol = Convert.ToDouble(textBox1.Text);
                double qp = up * qu;
                int rawId = Convert.ToInt32(label8.Text);

                double roq;
                if (textBox6.Text == "")
                {
                    roq = 0;
                }
                else
                {
                    roq = Convert.ToDouble(textBox6.Text);
                }

                if (dba.UpdateRawDetails( rawId,mt, um, qu, up, qp, al, aq, rol, remarks, image,roq))
                {
                    MessageBox.Show("Operations are comitted successfully");
                }
                else
                {
                    MessageBox.Show("Please re-check the values");
                }

            }
            else
            {
                MessageBox.Show("There are more empty fields");
            }
        }
    }
}
