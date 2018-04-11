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
    public partial class p_details : Form
    {
        DBAccess dba = new DBAccess();
        Form3 f3 = new Form3();

        public p_details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void p_profit_TextChanged(object sender, EventArgs e)
        {

        }

        //add product details
        private void p_save_button_Click(object sender, EventArgs e)
        {
            if (p_pid_txt.Text == "")
            {
                pid_label.Visible = true;
            }
            else if (p_cat_com.Text == "")
            {
                p_category_label.Visible = true;
            }
            else if (p_size_com.Text == "")
            {
                p_size_label.Visible = true;
            }
            else if (p_colour_txt.Text == "")
            {
                p_colour_label.Visible = true;
            }
            else if (p_uprice_txt.Text == "")
            {
                p_uprice_label.Visible = true;
            }
            else if (p_sprice_txt.Text == "")
            {
                p_uprice_label.Visible = true;
            }
            else if (p_profit_txt.Text == "")
            {
                p_uprice_label.Visible = true;
            }
            else if (p_quality_rating_com.Text == "")
            {
                p_quality_label.Visible = true;
            }
            else if (richTextBox1 == null)
            {
                p_details_label.Visible = true;
            }
            else
            {
                string a = Convert.ToString(p_quality_rating_com.SelectedItem);
                string id = p_pid_txt.Text.Substring(0, 1);
                if (((id == "O") && a == "Grade A") || a == "Grade B" || a == "Grade C" || a == "Grade D")
                {
                    string month = Convert.ToString(product_dateTime.Value.Date);
                    DateTime m = Convert.ToDateTime(month);
                    string month1 = m.ToString("MM");
                    if (dba.add_details(p_pid_txt.Text, Convert.ToString(p_cat_com.SelectedItem), Convert.ToString(p_size_com.SelectedItem), p_colour_txt.Text, p_uprice_txt.Text, p_sprice_txt.Text, p_profit_txt.Text, Convert.ToString(p_quality_rating_com.SelectedItem), richTextBox1.Text, p_allocation_label2.Text, Convert.ToString(product_dateTime.Value.Date),month1))

                    {
                        MessageBox.Show("Successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                    f3.Show();
                    this.Dispose();
                    f3.FillGrid2();
                }

                else if (a == "Grade E")
                {
                    string month = Convert.ToString(product_dateTime.Value.Date);
                    DateTime m = Convert.ToDateTime(month);
                    string month1 = m.ToString("MM");

                    if (dba.rejected_details(p_pid_txt.Text, Convert.ToString(p_cat_com.SelectedItem), p_allocation_label2.Text, p_uprice_txt.Text, Convert.ToString(p_quality_rating_com.SelectedItem), Convert.ToString(product_dateTime.Value.Date),month1))

                    {
                        MessageBox.Show("Successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                    f3.Show();
                    this.Dispose();
                    f3.FillGrid5();

                }

                else if (id != "O" && a == "Grade A")
                {
                    if(dba.export_details(p_pid_txt.Text, Convert.ToString(p_cat_com.SelectedItem), p_allocation_label2.Text, p_uprice_txt.Text, p_sprice_txt.Text, p_profit_txt.Text, Convert.ToString(p_quality_rating_com.SelectedItem), richTextBox1.Text, Convert.ToString(product_dateTime.Value.Date)))
                    {
                        MessageBox.Show("Successfully updated!");
                    }

                    else
                    {
                        MessageBox.Show("Error!");
                    }

                    f3.Show();
                    this.Dispose();
                    f3.FillGrid6();

                    //button7.Visible = false;
                    //remove_button.Visible = false;
                    //update_button.Visible = false;



                }

            }

            p_pid_txt.Clear();
            p_cat_com.Text = "";
            p_size_com.Text = "";
            p_colour_txt.Clear();
            p_uprice_txt.Clear();
            p_sprice_txt.Clear();
            p_profit_txt.Clear();
            p_quality_rating_com.Text = "";
            richTextBox1.Text = "";

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void p_sprice_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            p_pid_txt.Clear();
            p_cat_com.Text = "";
            p_size_com.Text = "";
            p_colour_txt.Clear();
            p_uprice_txt.Clear();
            p_sprice_txt.Clear();
            p_profit_txt.Clear();
            p_quality_rating_com.Text = "";
            richTextBox1.Text = "";

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            f3.FillGrid2();
            this.Dispose();

        }

        //calculate the selling price and the profit
        private void calc_button_Click(object sender, EventArgs e)
        {

            float price = (float)Convert.ToDouble(p_uprice_txt.Text);
            
            bool valid = float.TryParse(p_uprice_txt.Text.ToString(), out price);

            float sprice = (price * 35 / 100) + price;
            float profit = sprice - price;


            p_sprice_txt.Text = sprice.ToString();
            p_profit_txt.Text = profit.ToString();
     
        }

        private void p_details_Load(object sender, EventArgs e)
        {
            pid_label.Visible = false;
            p_category_label.Visible = false;
            p_size_label.Visible = false;
            p_colour_label.Visible = false;
            p_uprice_label.Visible = false;
            p_quality_label.Visible = false;
            p_details_label.Visible = false;

            //p_allocation_label1.Visible = false;
           // p_allocation_label2.Visible = false;
           // p_allocation_label3.Visible = false;
            //p_reject_label.Visible = false;
        }

        //update product details
        private void p_update_button_Click(object sender, EventArgs e)
        {
          
            if (dba.p_details(p_pid_txt.Text, Convert.ToString(p_cat_com.SelectedItem), Convert.ToString(p_size_com.SelectedItem), p_colour_txt.Text, p_uprice_txt.Text, p_sprice_txt.Text, p_profit_txt.Text, Convert.ToString(p_quality_rating_com.SelectedItem),p_allocation_label2.Text, richTextBox1.Text))

            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
           
            f3.Show();
            this.Dispose();
            f3.FillGrid2();
           
        }

        //Get allocation values
        private void p_quality_rating_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(p_quality_rating_com.SelectedItem);
           
            string id = p_pid_txt.Text.Substring(0, 1);

            if ((a=="Grade A")||(a=="Grade B")||(a=="Grade C") ||(a=="Grade D")&& (id=="O"))
            {
                p_allocation_label2.Visible = true;
                p_allocation_label2.Text = "Orders";
            }
            if((a=="Grade E"))
            {
                p_allocation_label2.Visible = true;
                p_allocation_label2.Text = "Rejected!";
            }
            if(id!="O")
            {
                if (a == "Grade A")
                {
                    p_allocation_label2.Visible = true;
                    p_allocation_label2.Text = "Export";



                    /*float price = (float)Convert.ToDouble(p_uprice_txt.Text);

            bool valid = float.TryParse(p_uprice_txt.Text.ToString(), out price);

            float sprice = (price * 35 / 100) + price;
            float profit = sprice - price;


            p_sprice_txt.Text = sprice.ToString();
            p_profit_txt.Text = profit.ToString();
                    */

                }
                if ((a == "Grade C") || (a == "Grade D"))
                {
                    p_allocation_label2.Visible = true;
                    p_allocation_label2.Text = "Sales";
                }
            }
            
            else { }
        }

        private void p_uprice_txt_TextChanged(object sender, EventArgs e)
        {
            int price = (Int32)Convert.ToDouble(p_uprice_txt.Text);

            bool valid = int.TryParse(p_uprice_txt.Text.ToString(), out price);

            int sprice = (price * 35 / 100) + price;
            int profit = sprice - price;

            /*float price = (float)Convert.ToDouble(p_uprice_txt.Text);

            bool valid = float.TryParse(p_uprice_txt.Text.ToString(), out price);

            float sprice = (price * 35 / 100) + price;
            float profit = sprice - price;
            */

            p_sprice_txt.Text = sprice.ToString();
            p_profit_txt.Text = profit.ToString();
        }

        //validation only for numbers
        private void p_uprice_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void p_demo_button_Click(object sender, EventArgs e)
        {
            p_pid_txt.Text = "O0012";
            p_cat_com.SelectedItem = "Gents Item";
            p_size_com.SelectedItem = "M";
            p_colour_txt.Text = "Blue";
            p_uprice_txt.Text = "650";
            p_quality_rating_com.SelectedItem = "Grade A";
            richTextBox1.Text = "gents trouser M size";

        }

        private void pDetails_tot_button_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_sprice_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void product_dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p_allocation_label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

    

      
    
    

    
