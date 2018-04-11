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
    public partial class AddSales : Form
    {

        DBAccess9 dba = new DBAccess9();
        Form9 f9 = new Form9();
        public AddSales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dba.addSales(lblRetailID.Text,Convert.ToString(comboMonth.SelectedItem), textBoxshop.Text, textBoxItm.Text,textBoxSalesPrice.Text, textBoxQun.Text, textBoxPrice.Text, textBoxAdva.Text, textBoxArrear.Text))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            textBoxshop.Clear();
            textBoxItm.Clear();

            textBoxSalesPrice.Clear();
            textBoxQun.Clear();
            textBoxPrice.Clear();
            textBoxAdva.Clear();
            textBoxArrear.Clear();

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            Form9 fm9 = new Form9();
            fm9.Visible = true;
            this.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)//update button code
        {
            if (dba.UpdateSales(Convert.ToString(comboMonth.SelectedItem), textBoxshop.Text, textBoxItm.Text, textBoxSalesPrice.Text, textBoxQun.Text, textBoxPrice.Text, textBoxAdva.Text, textBoxArrear.Text, lblRetailID.Text))
            {
                MessageBox.Show("Successfully Updated");
                f9.FillSales();
                this.Dispose();
                f9.Show();
              

            }
            else
            {
                MessageBox.Show("Error occured");
            }

        
        }

      private void button4_Click(object sender, EventArgs e)  // claculate total price..
        {
           //(textBoxPrice) =(Convert.ToDouble( textBoxSalesPrice) *Convert.ToDouble( textBoxQun));
           // float total = (float)Convert.ToDouble();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddSales_Load(object sender, EventArgs e)
        {

        }

        private void textBoxQun_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quantity = Convert.ToDouble(textBoxQun.Text);
                float salesPrice = (float)Convert.ToDouble(textBoxSalesPrice.Text);


                bool valid = double.TryParse(textBoxQun.Text.ToString(), out quantity);
                // bool valid = float.TryParse(textBoxSalesPrice.Text.ToString(), out

                double total = (quantity * salesPrice);
                textBoxPrice.Text = total.ToString();
            }
            catch
            {
                
            }
           

        }

        private void textBoxAdva_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                float advance = (float)Convert.ToDouble(textBoxAdva.Text);
                float totalAmount = (float)Convert.ToDouble(textBoxPrice.Text);

                bool valid = float.TryParse(textBoxAdva.Text.ToString(), out advance);

                float arrears = (totalAmount - advance);
                textBoxArrear.Text = arrears.ToString();
            }
            catch
            {

            }
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
            Form9 f9 = new Form9();
            this.Dispose();
            f9.Visible = true;
        }

        /* private void button6_Click(object sender, EventArgs e)
         {
             textBoxID.Text="RI00009";
             textBoxCusID.Text="Clear()";
             textBoxBatchNo.Clear();
             textBoxUnit.Clear();
             textBoxSalesPrice.Clear();
             textBoxQun.Clear();
             textBoxPrice.Clear();
             textBoxAdva.Clear();
             textBoxArrear.Clear();
         }*/
    }
}
