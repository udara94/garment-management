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
    public partial class empadd : Form
    {
        DBAccessEmp dba = new DBAccessEmp();
        employees f8 = new employees();
        validation vaild = new validation();
        
        public empadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            //label20.Visible = false;
            label21.Visible = false;
            
            label23.Visible = false;
            label24.Visible = false;
            if (textBoxname.Text == "" || textBoxage.Text == "" || textBoxconno.Text == "" || textBoxnic.Text == "" ||  richTextadd.Text == "" ||  richTextBoxexp.Text == "" || img_path.Text == "" || textBox1.Text == "")
            {
                
                if (textBoxname.Text == "")
                {
                    
                    label12.Visible = true;
                }
                if (textBoxage.Text == "")
                { 
                    label13.Visible = true;
                }
                if (textBoxconno.Text == "")
                {
                    label25.Visible = false;
                    label14.Visible = true;
                }
                if (textBoxnic.Text == "")
                {
                    label24.Visible = false;
                    label15.Visible = true;
                }
              /*  if (textBoxbirthday.Text == "")
                {

                    label16.Visible = true;
                }*/


                if (richTextadd.Text == "")
                     
                {
                    
                    label17.Visible = true;
                }
                
                if (img_path.Text == "")
                {
                    label21.Visible = true;
                }

                
                if (textBox1.Text == "")
                {
                    label23.Visible = true;
                }
                
            }

            else
            {
                
                    byte[] imagebt = null;
                    FileStream fstream = new FileStream(this.img_path.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imagebt = br.ReadBytes((int)fstream.Length);
                
                

                if (dba.addemp(textBoxname.Text, textBoxage.Text, textBoxconno.Text, textBoxnic.Text, birthday.Value.Date.ToString("MM/dd/yyyy"), richTextadd.Text, Convert.ToString(comboBox1.SelectedItem), richTextBoxexp.Text, joindate.Value.Date.ToString("MM/dd/yyyy"), textBox1.Text, imagebt))
                {                    
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                f8.FillGrid();
                this.Dispose();
                f8.Visible = true;
                
            } 



            /* if (textBoxname.Text == null)
            {
                MessageBox.Show("Please Enter the Name");
            }
            else if (textBoxage.Text == null)
            {
                MessageBox.Show("Please Select the age");
            }
            else
            {
                if (dba.addemp(textBoxname.Text))
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                this.Dispose();
                f8.Show();

                f8.FillGrid();
            }

           string txtid = textBox_empid.Text;
            MessageBox.Show(txtid);*/

        }

        private void empadd_Load(object sender, EventArgs e)
        {

            /*button1.Visible = false;
            button2.Visible = false;
            if (f8.var2 == 1)
            {
                this.button2.Visible = true;
            }
            else if(f8.var2 == 2)
            {
                this.button1.Visible = true;
            }
            else { }*/

            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            
            label17.Visible = false;
            label18.Visible = false;

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            employees emp = new employees();

            byte[] imagebt = null;
            FileStream fstream = new FileStream(this.img_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);

            if (dba.updateemployee(textBox_empid.Text,textBoxname.Text, textBoxage.Text, textBoxconno.Text, textBoxnic.Text, birthday.Value.Date.ToString("MM/dd/yyyy"), richTextadd.Text, Convert.ToString(comboBox1.SelectedItem), richTextBoxexp.Text, joindate.Value.Date.ToString("MM/dd/yyyy"), textBox1.Text, imagebt))
 
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            

            //emp.FillGrid();

            f8.FillGrid();
            this.Dispose();
            f8.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg Files(*.jpg)|*.jpg|png Files(*.png)|*.png|All Files(*.*)|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                img_path.Text = picLoc;
                pictureBox1.ImageLocation = picLoc;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxage_KeyPress(object sender, KeyPressEventArgs e)
        {
            vaild.valid_numbers(e);
        }

        private void textBoxage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxconno_TextChanged(object sender, EventArgs e)
        {
           if(textBoxconno.Text == "")
            {
                label25.Text = " ";
            }
            else if (textBoxconno.Text.Count(char.IsDigit)==10)
            {
                label25.Text = "Number is Correct";
                label25.Visible = true;
                label14.Visible = false;
            }
            else
            {
                label25.Text = "Number is incorrect";
                label25.Visible = true;
                label14.Visible = false;
            }
        }

        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            vaild.valid_letters(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBoxname.Text = "saman perera";
            textBoxage.Text = "22";
            textBoxconno.Text = "0777123456";
            textBoxnic.Text = "951860600V";
            
            
            richTextadd.Text = "Colombo";
           
            richTextBoxexp.Text = "work mas pvt ltd";
            
            textBox1.Text = "15000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            f8.Show();
        }

        private void textBoxnic_TextChanged(object sender, EventArgs e)
        {
            if (textBoxnic.Text == "")
            {
                label24.Text = " ";
            }
            else if ((textBoxnic.Text.Count(char.IsDigit) == 9) && (textBoxnic.Text.EndsWith("X") || textBoxnic.Text.EndsWith("x") || textBoxnic.Text.EndsWith("V") || textBoxnic.Text.EndsWith("v")) && (textBoxnic.Text[2] != '4' && textBoxnic.Text[2] != '9'))
            {

                label24.Text = "Correct ";
                label24.Visible = true;
                label15.Visible = false;
            }
            else
            {
                label24.Text = "incorrect ";
                label24.Visible = true;
                label15.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vaild.valid_numbers(e);
        }

        private void textBoxconno_KeyPress(object sender, KeyPressEventArgs e)
        {
            vaild.valid_numbers(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = Convert.ToString(comboBox1.SelectedItem);
            if(select == "Manager")
            {
                textBox1.Text = "50000";
            }
            else if(select == "HR Manager")
            {
                textBox1.Text = "50000";
            }
            else if(select == "Supervisor")
            {
                textBox1.Text = "30000";
            }
            else if(select == "Juki machine operator")
            {
                textBox1.Text = "20000";
            }

        }
    }
    }

