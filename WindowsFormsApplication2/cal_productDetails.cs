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
    public partial class cal_productDetails : Form
    {
        DBAccess dba = new DBAccess();
        Form3 f3 = new Form3();

        int x = 0;

        public cal_productDetails()
        {
            InitializeComponent();
        }

        private void cal_month_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string a = Convert.ToString(name_com.SelectedItem);
            if (a == "Product Details")
            {
                FillGrid123();
                x = 1;
                string month_b = Convert.ToString(cal_month_com.SelectedItem);
                unitPrice_label.Text = dba.product_price(month_b);

            }

            else if (a == "Rejected Items")
            {
                FillGrid124();
                x = 2;
            }
            else { }
            */

        }

        private void cal_add_button_Click(object sender, EventArgs e)
        {
            if (dba.add_cal(Convert.ToString(name_com.SelectedItem), Convert.ToString(cal_month_com.SelectedItem), unitPrice_label.Text, rejected_sum_label.Text, product_profit.Text))
            {

                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            //f3.Show();
            //this.Dispose();
            FillGrid7();

        }

        public void FillGrid123()
        {
            string m = Convert.ToString(cal_month_com.SelectedItem);


            DataTable dt = dba.getproduct_details();
            dataGridcal.DataSource = dt.DefaultView;

           
        }


        public void FillGrid7()
        {
            DataTable dt = dba.get_calculation_details();
            dataGridcal.DataSource = dt.DefaultView;

        }

       

        public void FillGrid124()
        {
            DataTable dt = dba.getrejected_details();
            dataGridcal.DataSource = dt.DefaultView;

            /* int A = 0, B = 0;
             for (A = 0; A < dataGridcal.Rows.Count; A++)
             {
                 B += Convert.ToInt32(dataGridcal.Rows[A].Cells[3].Value);
             }
             total_label.Text = B.ToString();*/
        }

        private void name_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(name_com.SelectedItem);
            if (a == "Product Details")
            {
                FillGrid123();
                x = 1;
                string month_b = Convert.ToString(cal_month_com.SelectedItem);
                unitPrice_label.Text = dba.product_unit(month_b);

                //product_profit.Text = dba.product_profit(month_b);
                float jayani = dba.product_profit(month_b);
                string s = jayani.ToString();
                product_profit.Text = s;


            }

            else if (a == "Rejected Items")
            {

                FillGrid124();
                x = 2;

                string month_b = Convert.ToString(cal_month_com.SelectedItem);
                rejected_sum_label.Text = dba.rejected_unit(month_b);

            }
            else { }


        }

        private void back_cal_button_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            //f3.FillGrid3();
            this.Dispose();
        }

        private void unitPrice_label_Click(object sender, EventArgs e)
        {

        }

       

        private void rejected_sum_label_Click(object sender, EventArgs e)
        {

        }

        private void cal_productDetails_Load(object sender, EventArgs e)
        {

        }

        private void product_profit_Click(object sender, EventArgs e)
        {

        }

        private void add_sales_button_Click(object sender, EventArgs e)
        {
          

            rejectedSales reject = new rejectedSales();
            reject.Visible = true;
            this.Visible = false;
        }

        private void search_sales_reject_TextChanged(object sender, EventArgs e)
        {
           /* DataView DV = new DataView(dba.getproduct_details());
            DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", search_txt.Text);
            dataGridView1.DataSource = DV;*/
        }
    }
}
