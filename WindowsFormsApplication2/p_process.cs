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
    public partial class p_process : Form
    { 
        
        DBAccess dba = new DBAccess();
        Form3 f3 = new Form3();

        public p_process()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void p_process_Load(object sender, EventArgs e)
        {
            ppro_id_label.Visible = false;
            pp_sectionid_label.Visible = false;
            pp_inpro_label.Visible = false;
            pp_outpro_label.Visible = false;
            pp_pendquantity_label.Visible = false;
            pp_quality_label.Visible = false;

            label9.Visible = false;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
                if (pp_proid.Text == "")
                {
                    ppro_id_label.Visible = true;
                    
                }
                else if (details_secID_txt.Text == "")
                {
                    pp_sectionid_label.Visible = true;
                    
                }
                else if (pp_in.Text == "")
                {
                    pp_inpro_label.Visible = true;
                    
                }
                else if (pp_out.Text == "")
                {
                    pp_outpro_label.Visible = true;
                    
                }
                else if (pp_pendquntity.Text == "")
                {
                    pp_pendquantity_label.Visible = true;
                }
                else if (pp_quality_com.Text == "")
                {
                    pp_quality_label.Visible = true;
                
                { }
            }

            else
            {
                
               // if(add.salesdb(pp_quality_com.SelectedItem))
                if (dba.add_process(pp_proid.Text, details_secID_txt.Text, pp_in.Text, pp_out.Text, pp_pendquntity.Text, Convert.ToString(pp_quality_com.SelectedItem)))

                {
                    MessageBox.Show("Successfully added");
                    
                }
                else
                {
                    MessageBox.Show("Error!");
                }

                this.Dispose();
                f3.Show();

                f3.FillGrid();
            }


        }

       


        private void back_Click(object sender, EventArgs e)
        {
            
            f3.Visible=true;
            f3.FillGrid();
            this.Dispose();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pp_proid.Clear();
            details_secID_txt.Text = "";
            pp_in.Clear();
            pp_out.Clear();
            pp_pendquntity.Clear();
            pp_quality_com.Text = "";
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ppro_id_label_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pp_quality_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(pp_quality_com.SelectedItem);

            string id = pp_proid.Text.Substring(0, 1);

            if ((a == "Grade A") || (a == "Grade B") || (a == "Grade C") || (a == "Grade D") && (id == "O"))
            {
                label9.Visible = true;
                label9.Text = "Orders";
            }
            if ((a == "Grade E"))
            {
                label9.Visible = true;
                label9.Text = "Rejected!";
            }
            if (id != "O")
            {
                if (a == "Grade A")
                {
                    label9.Visible = true;
                    label9.Text = "Export";
                }
                if ((a == "Grade C") || (a == "Grade D"))
                {
                    label9.Visible = true;
                    label9.Text = "Sales";
                }
            }

            else { }
        }

        //update process details
        private void pp_update_Click(object sender, EventArgs e)
        {
            
            if (dba.product_process(pp_proid.Text, details_secID_txt.Text, pp_in.Text, pp_out.Text, pp_pendquntity.Text, Convert.ToString(pp_quality_com.SelectedItem)))
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            this.Dispose();

            f3.Show();
            this.Dispose();
            f3.FillGrid();
           

        }

        //text box validation for enter only numbers
        private void pp_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers!");
            }
        }

        private void pp_out_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers!");
            }
        }
/*
        //calculate pending quantity of product_d
        private void pp_calc_button_Click(object sender, EventArgs e)
        {
            float amount = (float)Convert.ToDouble(pp_in.Text);
            bool valid = float.TryParse(pp_in.Text.ToString(), out amount);

            float out_amount = (float)Convert.ToDouble(pp_out.Text);
            bool valid2 = float.TryParse(pp_out.Text.ToString(), out out_amount);

            float quantity = amount - out_amount;

            pp_pendquntity.Text = quantity.ToString(); 
           
        }*/

        private void pp_inpro_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pp_proid.Text = "p001";
            //pp_comsection.SelectedItem = "02";
            pp_in.Text = "500";
            pp_out.Text = "250";
            pp_quality_com.SelectedItem = "Grade A";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // string id = pp_proid.Text.Substring(0, 1);
           // textBox1.Text = id;
        }

        private void pp_proid_TextChanged(object sender, EventArgs e)
        {
            string id = pp_proid.Text.Substring(0,1);
            details_secID_txt.Text = id;
        }

        private void pp_out_TextChanged(object sender, EventArgs e)
        {
            float amount = (float)Convert.ToDouble(pp_in.Text);
            bool valid = float.TryParse(pp_in.Text.ToString(), out amount);

            float out_amount = (float)Convert.ToDouble(pp_out.Text);
            bool valid2 = float.TryParse(pp_out.Text.ToString(), out out_amount);

            float quantity = amount - out_amount;

            pp_pendquntity.Text = quantity.ToString();
        }
    }
}
