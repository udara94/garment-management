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
    public partial class rejectedSales : Form

    {
        DBAccess dba = new DBAccess();

        public rejectedSales()
        {
            InitializeComponent();
        }

        public void FillGrid8()
        {
            DataTable dt = dba.getproduct_details();
            dataGridViewR.DataSource = dt.DefaultView;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void addRejectSales_button_Click(object sender, EventArgs e)
        {
            if (dba.addSalesR_details(R_sales_id.Text, R_sales_cat.Text,R_sales_allocation.Text, R_sales_unitPrice.Text, R_sales_quality.Text, R_sales_reason.Text, R_sales_date.Text, R_sales_month.Text))

            {
                MessageBox.Show("Successfully added");

            }
            else
            {
                MessageBox.Show("Error!");
            }

            this.Dispose();
            cal_productDetails cp = new cal_productDetails();
            cp.Show();

            cp.FillGrid124();
        }


        //}

    private void R_sales_id_TextChanged(object sender, EventArgs e)
        {
            //string a;
        }

        private void r_sales_bakButton_Click(object sender, EventArgs e)
        {
            cal_productDetails cal1 = new cal_productDetails();
            cal1.Visible = true;
            this.Dispose();
        }

        private void search_sales_reject_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getproduct_details());
            DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", search_sales_reject.Text);
            dataGridViewR.DataSource = DV;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void rejectedSales_Load(object sender, EventArgs e)
        {
            FillGrid8();
            R_sales_cat.Visible = false;
            R_sales_allocation.Visible = false;
            R_sales_unitPrice.Visible = false;
            R_sales_quality.Visible = false;
            R_sales_date.Visible = false;
            R_sales_month.Visible = false;

        }

        private void dataGridViewR_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* R_sales_id.Text = this.dataGridViewR.CurrentRow.Cells[0].Value.ToString();
            R_sales_id.Enabled = false;
            label10.Text = this.dataGridViewR.CurrentRow.Cells[1].Value.ToString();
            R_sales_allocation.Text = this.dataGridViewR.CurrentRow.Cells[8].Value.ToString();
            R_sales_unitPrice.Text = this.dataGridViewR.CurrentRow.Cells[4].Value.ToString();
            R_sales_quality.Text = this.dataGridViewR.CurrentRow.Cells[7].Value.ToString();
            R_sales_reason.Text = this.dataGridViewR.CurrentRow.Cells[5].Value.ToString();
            R_sales_date.Text = this.dataGridViewR.CurrentRow.Cells[10].Value.ToString();
            R_sales_month.Text = this.dataGridViewR.CurrentRow.Cells[11].Value.ToString(); */

        }

        private void dataGridViewR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }

        private void dataGridViewR_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            R_sales_cat.Visible = true;
            R_sales_allocation.Visible = true;
            R_sales_unitPrice.Visible = true;
            R_sales_quality.Visible = true;
            R_sales_date.Visible = true;
            R_sales_month.Visible = true;


            R_sales_id.Text = this.dataGridViewR.CurrentRow.Cells[0].Value.ToString();
            R_sales_id.Enabled = false;
            R_sales_cat.Text = this.dataGridViewR.CurrentRow.Cells[1].Value.ToString();
            R_sales_allocation.Text = this.dataGridViewR.CurrentRow.Cells[8].Value.ToString();
            R_sales_unitPrice.Text = this.dataGridViewR.CurrentRow.Cells[4].Value.ToString();
            R_sales_quality.Text = this.dataGridViewR.CurrentRow.Cells[7].Value.ToString();
            //R_sales_reason.Text = this.dataGridViewR.CurrentRow.Cells[5].Value.ToString();
            R_sales_date.Text = this.dataGridViewR.CurrentRow.Cells[10].Value.ToString();
            R_sales_month.Text = this.dataGridViewR.CurrentRow.Cells[11].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
