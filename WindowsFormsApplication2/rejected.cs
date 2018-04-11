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
    public partial class rejected : Form
    { 
       DBAccess dba = new DBAccess();

       Form3 f3 = new Form3();
    
        public rejected()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void o_back_button_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            f3.FillGrid5();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dba.upd_rejected(reject_pID_label.Text, r_listBox.Text))
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            this.Dispose();

            //f3.Show();
            f3.Show();
            f3.FillGrid5();



            /* if (dba.upd_orders(order_id_label.Text, Convert.ToString(order_status_com.SelectedItem),Convert.ToString(dateTimePicker1.Value.Date)))
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            this.Dispose();

            //f3.Show();
            f3.Show();
            f3.FillGrid3();
            */
        }

        private void rejected_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            f3.FillGrid5();
            this.Dispose();
        }
    }
}
