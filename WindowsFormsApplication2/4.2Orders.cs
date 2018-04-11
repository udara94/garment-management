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
    public partial class Orders : Form
    {
        DBAccess4 dba = new DBAccess4();
        Form4 f4 = new Form4();

        public Orders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        //Add orders
        private void button2_Click(object sender, EventArgs e)
        {
            if (cusIDtextBox.Text == "" || Convert.ToString(ortypecomboBox.SelectedItem) == "" || QuantytextBox.Text == "" || ordateTimePicker.Value.Date.ToString("MM/dd/yyyy") == "" || duedateTimePicker.Value.Date.ToString("MM/dd/yyyy") == "" || Convert.ToString(comstatecomboBox.SelectedItem) == "" || fullpaytextBox.Text == "" || advancetextBox.Text == "" || labelarrear.Text == "" || Convert.ToString(substatuscomboBox.SelectedItem) == "")
            {
                MessageBox.Show("please enter the all details ");
            }
            else if (dba.addOrders(cusIDtextBox.Text, Convert.ToString(typecomboBox.SelectedItem), Convert.ToString(sizecomboBox.SelectedItem), ColortextBox.Text, DesigntextBox.Text, (float)Convert.ToDouble(QuantytextBox.Text), Convert.ToString(ortypecomboBox.SelectedItem), ordateTimePicker.Value.Date.ToString("MM/dd/yyyy"), duedateTimePicker.Value.Date.ToString("MM/dd/yyyy"), Convert.ToString(comstatecomboBox.SelectedItem), fullpaytextBox.Text, advancetextBox.Text, labelarrear.Text, Convert.ToString(substatuscomboBox.SelectedItem), subdatetextBox.Text))
                {
                    MessageBox.Show("Successfully Added");
                    Form4 f4 = new Form4();
                    f4.Visible = true;
                    this.Visible = false;

                f4.FillGridO();
            }
                else
                {
                    MessageBox.Show("Error occured");

                }

                this.Dispose();
                f4.FillGrid();
            }
        


        private void ColortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
        }

        private void substatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Designlabel_Click(object sender, EventArgs e)
        {

        }

        private void DesigntextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //order update
        private void button3_Click(object sender, EventArgs e)
        {
            if (dba.updateOrders(orderIDlabel.Text,cusIDtextBox.Text, Convert.ToString(typecomboBox.SelectedItem), Convert.ToString(sizecomboBox.SelectedItem), ColortextBox.Text, DesigntextBox.Text, QuantytextBox.Text, Convert.ToString(ortypecomboBox.SelectedItem), ordateTimePicker.Value.Date.ToString("MM/dd/yyyy"), duedateTimePicker.Value.Date.ToString("MM/dd/yyyy"), Convert.ToString(comstatecomboBox.SelectedItem), fullpaytextBox.Text, advancetextBox.Text, labelarrear.Text, Convert.ToString(substatuscomboBox.SelectedItem), subdatetextBox.Text))
            {
                MessageBox.Show("Successfully Updated");
                Form4 f4 = new Form4();
                
                this.Visible = false;
                f4.Visible = true;

                f4.FillGridO();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }
        // order clear button
        private void button4_Click(object sender, EventArgs e)
        {
            orderIDlabel.Text = "";
            cusIDtextBox.Text = "";
            typecomboBox.Text = "";
            sizecomboBox.Text = "";
            ColortextBox.Text = "";
            DesigntextBox.Text = "";
            QuantytextBox.Text = "";
            ortypecomboBox.Text = "";
            ordateTimePicker.Text = "";
            duedateTimePicker.Text = "";
            comstatecomboBox.Text = "";
            fullpaytextBox.Text = "";
            advancetextBox.Text = "";
            substatuscomboBox.Text = "";
            subdatetextBox.Text = "";
            labelarrear.Text = "";
            unip.Text = "";
        }

        private void dudlabel_Click(object sender, EventArgs e)
        {
            /*if (ordateTimePicker.Value.Date < duedateTimePicker.Value.Date)
            {
                dudlabel.Text = "Please recheck DuDate";
            }
            else
            {
                dudlabel.Text = "";
            } */
        }

        private void advancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullpaytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullpaytextBox.Text == "" || advancetextBox.Text == "")
            {
                // labelarrear.Text = "";
                MessageBox.Show("Please enter the Values");
            }
            else
            {

                float fullpay = (float)Convert.ToDouble(fullpaytextBox.Text);
                float advance = (float)Convert.ToDouble(advancetextBox.Text);
                float total = fullpay - advance;

                labelarrear.Text = Convert.ToString(total);
            }
        }

        private void duedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ordateTimePicker.Value.Date > duedateTimePicker.Value.Date)
            {
                dudlabel.Text = "Please recheck DuDate";
                //MessageBox.Show("Please recheck DuDate");
            }
            else
            {
                dudlabel.Text = "";
            }
        }

        private void cusIDtextBox_TextChanged(object sender, EventArgs e)
        {

           /* int Text = Select CustomerID from customer;
            if (cusIDtextBox.Text =="")
            {
                label16.Text = " ";
            }
            else if(cusIDtextBox.Text == )
            {

            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            cusIDtextBox.Text = "C00002";
            //typecomboBox.Text = "T-shirt";
            //sizecomboBox.Text = "XXXL";
            ColortextBox.Text = "Sky_Blue";
            DesigntextBox.Text = "SLIIT";
            //QuantytextBox.Text = "300";
            //ortypecomboBox.Text = "Local";
            ordateTimePicker.Text = "2016/8/1";
            duedateTimePicker.Text = "2016/8/28";
            comstatecomboBox.Text = "Completed";
            //fullpaytextBox.Text = "200000.00";
            //advancetextBox.Text = "45000.00";
            substatuscomboBox.Text = "Submited";
            subdatetextBox.Text = "8/30/2016";
            //labelarrear.Text = "";
        }

        private void clothsTypetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //VPayPlane vpp = new VPayPlane();
            //vpp.Visible = true;
            //this.Visible = false;
        }

        private void typecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typecomboBox.Text == "Baby Grow")
            {
                unip.Text = "450";
            }
            else if (typecomboBox.Text == "Blouse ")
            {
                unip.Text = "250";
            }
            else if (typecomboBox.Text == "Jumper ")
            {
                unip.Text = "300";
            }
            else if (typecomboBox.Text == "Shirt (long sleeve)")
            {
                unip.Text = "1050";
            }
            else if (typecomboBox.Text == "Shirt (short sleeve)")
            {
                unip.Text = "1000";
            }
            else if (typecomboBox.Text == "Shorts")
            {
                unip.Text = "500";
            }
            else if (typecomboBox.Text == "Skirt ")
            {
                unip.Text = "650";
            }
            else if (typecomboBox.Text == "Sarong ")
            {
                unip.Text = "650";
            }
            else if (typecomboBox.Text == "Socks ")
            {
                unip.Text = "150";
            }
            else if (typecomboBox.Text == "Sweatshirt ")
            {
                unip.Text = "750";
            }
            else if (typecomboBox.Text == "T-Shirt (long sleeve)")
            {
                unip.Text = "700";
            }
            else if (typecomboBox.Text == "T-Shirt (short sleeve)")
            {
                unip.Text = "650";
            }
            else if (typecomboBox.Text == "Top ")
            {
                unip.Text = "660";
            }
            else if (typecomboBox.Text == "Trousers ")
            {
                unip.Text = "1500";
            }
            else if (typecomboBox.Text == "Vest ")
            {
                unip.Text = "150";
            }
            else if (typecomboBox.Text == "")
            {
                unip.Text = "";
            }
            else { }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ortypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ortypecomboBox.Text == "Export")
            {
                double up = Convert.ToDouble(unip.Text);
                double qunt = Convert.ToDouble(QuantytextBox.Text);
                double Total = (up + 1000)* qunt;
                string tot = Convert.ToString(Total);

                fullpaytextBox.Text = tot;
            }
            else if (ortypecomboBox.Text == "Local")
            {
                double up = Convert.ToDouble(unip.Text);
                double qunt = Convert.ToDouble(QuantytextBox.Text);
                double Total = (up + 500) * qunt;
                string tot = Convert.ToString(Total);

                fullpaytextBox.Text = tot;
            }
            else
            {
                fullpaytextBox.Text = "";
            }
        }

        private void unip_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Dispose();
            f4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }
    }
}
