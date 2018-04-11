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
   
    public partial class AddSalesRate : Form
    {
        DBAccess9 dba = new DBAccess9();
        Form9 f9 = new Form9();
        public AddSalesRate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dba.addSaleRate(Convert.ToString(comMonth.SelectedItem), text_Income.Text, texRate.Text))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            comMonth.Text = "";
            text_Income.Clear();
            texRate.Clear();
            LastIncome.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dba.UpdateSalesRate(Convert.ToString(comMonth.SelectedItem),text_Income.Text, texRate.Text) )
            {
                MessageBox.Show("Successfully Updated");
                this.Dispose();
                f9.Show();
                f9.FillSalesRate();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            comMonth.Text = "";
            text_Income.Clear();
            texRate.Clear();


        }

        public void button2_Click(object sender, EventArgs e)
        {

            dba.calculation(Convert.ToString(comMonth.SelectedItem));

            {
                text_Income.Text = Convert.ToString(dba.calculation(Convert.ToString(comMonth.SelectedItem)));
                //  texRate.Text =( Convert.ToString(dba.LastMonthIncome(Convert.ToString(comMonth.SelectedItem)));

            }

            dba.LastMonthIncome(Convert.ToString(comMonth.SelectedItem));
            {
                LastIncome.Text= Convert.ToString(dba.LastMonthIncome(Convert.ToString(comMonth.SelectedItem)));
            }

            double rate = (Convert.ToDouble(LastIncome.Text) - Convert.ToDouble(text_Income.Text)) / Convert.ToDouble(LastIncome.Text) * 100;
            texRate.Text = Convert.ToString(rate);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Dispose();
            f9.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
