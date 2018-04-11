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
    public partial class Form2_1 : Form
    {
        DBAccess2 dba = new DBAccess2();
        Form2 f2 = new Form2();

        public Form2_1()
        {
            InitializeComponent();
        }

        private void Form_2_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Add();      

        }

        /*Only can press letters*/
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
           
        }

        /*Only can press Digits*/
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }

        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            panel1_1.Visible = false;
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            panel1_3.Visible = false;
        }

        private void cmbType_MouseClick(object sender, MouseEventArgs e)
        {

            panel1_4.Visible = false;
        }

        private void dTP_Date_MouseCaptureChanged(object sender, EventArgs e)
        {
            panel1_2.Visible = false;
            panel1_2_2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmbTran.SelectedItem = "Water";
            cmbType.SelectedItem = "Cost";
            txtAmount.Text = "14000";
            dTP_Date.Value=DateTime.Today.Date.AddDays(3);
        }



        public void Add()
        {
            if (cmbTran.SelectedItem== null || txtAmount.Text == "" || cmbType.SelectedItem == null || dTP_Date.Value.Date == DateTime.Today.Date)
            {
                if (cmbTran.SelectedItem == null)
                {
                    // MessageBox.Show("Please Enter the Name");
                    panel1_1.Visible = true;
                }
                if (cmbType.SelectedItem == null)
                {
                    //MessageBox.Show("Please Select the Type");
                    panel1_4.Visible = true;
                }
                if (txtAmount.Text == "")
                {
                    //MessageBox.Show("Please Enter the Amount");
                    panel1_3.Visible = true;
                }
                if (dTP_Date.Value.Date == DateTime.Today.Date)
                {
                     //MessageBox.Show("Please Select the Date");
                     panel1_2.Visible = true;
                }
                if (dTP_Date.Value.Date.Month < DateTime.Today.Date.Month || dTP_Date.Value.Date.Month > DateTime.Today.Date.Month)
                {
                     //MessageBox.Show("Please Select the Valid Date");
                     panel1_2_2.Visible = true;
                }
            }

            else
            {
                panel1_1.Visible = false;
                panel1_4.Visible = false;
                panel1_3.Visible = false;
                panel1_2.Visible = false;
                panel1_2_2.Visible = false;

                if (dba.addOtherTran(Convert.ToString(cmbTran.SelectedItem), Convert.ToString(cmbType.SelectedItem), Convert.ToDouble(txtAmount.Text), dTP_Date.Value.Date.ToString("MMMM yyyy")))
                {
                    MessageBox.Show("Successfully Added");
                    f2.FillOtherTran();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                
                this.Dispose();
                f2.Show();

            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbTran.SelectedItem != null || txtAmount.Text != "" || cmbType.SelectedItem != null || dTP_Date.Value.Date.Month != DateTime.Today.Date.Month)
            {
                cmbTran.SelectedItem = null;
                dTP_Date.Value = DateTime.Today.Date;
                txtAmount.Text = "";
                cmbType.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Nothing to Clear");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (cmbTran.SelectedItem == null || txtAmount.Text == "" || cmbType.SelectedItem == null || dTP_Date.Value.Date == DateTime.Today.Date)
            {
                MessageBox.Show("Please put some values to Update");
            }
            else
            {
                if (dba.updateOtherTran(Convert.ToString(cmbTran.SelectedItem), Convert.ToString(cmbType.SelectedItem), txtAmount.Text, dTP_Date.Value.Date.ToString("MMMM yyyy"), lbl_Id.Text))
                {
                    MessageBox.Show("Successfully Updated");
                    f2.FillOtherTran();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                this.Dispose();
                f2.Show();

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
