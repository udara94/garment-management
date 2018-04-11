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
    public partial class Form3 : Form
    {
        DBAccess dba = new DBAccess();
        int jaye = 0;

        public Form3()
        {
            InitializeComponent();
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
            //pDetails_tot_button.Visible = false;
           // totValue_label.Visible = false;


          /*  if(jaye == 1)
            {
                FillGrid();
                
            }
            else if ( jaye ==2)
            {
                FillGrid2();
                
            }
            else { }*/
        }
        public void FillGrid()
        {
            DataTable dt = dba.get_process();
            dataGridView1.DataSource = dt.DefaultView;
        }

        public void FillGrid2()
        {
            DataTable dt = dba.getproduct_details();
            dataGridView1.DataSource = dt.DefaultView;
        }

        //order details
        public void FillGrid3()
        {
            DataTable dt = dba.get_orders();
            dataGridView1.DataSource = dt.DefaultView;
        }

        //sales details
        public void FillGrid4()
        {
            DataTable dt = dba.get_sales_details();
            dataGridView1.DataSource = dt.DefaultView;
        }

        //Rejected item details
        public void FillGrid5()
        {
            DataTable dt = dba.getrejected_details();
            dataGridView1.DataSource = dt.DefaultView;
        }

        //Export product details
         public void FillGrid6()
         {
             DataTable dt = dba.get_export_details();
             dataGridView1.DataSource = dt.DefaultView;
         }


        private void button4_Click(object sender, EventArgs e)
        {
            cal_productDetails cal = new cal_productDetails();
            cal.Visible = true;
            this.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillGrid2();
            jaye = 2;

            button7.Visible = true;
            remove_button.Visible =true;

            //pDetails_tot_button.Visible = true;
            //totValue_label.Visible = true;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
        }   

        private void order_details_button_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            remove_button.Visible = false;

            FillGrid3();
            jaye = 3;
        }

        private void view_pprocess_button_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            remove_button.Visible = true;

            FillGrid();
            jaye = 1;

        }

        //button 7 => Add button
        private void button7_Click(object sender, EventArgs e)
        {
            if (jaye == 1)
            {
                p_process pro = new p_process();
                pro.Visible = true;
                this.Visible = false;
            }
            else if (jaye == 2)
            {
                p_details prd = new p_details();
                prd.Visible = true;
                this.Visible = false;
            }
           

            else
            { }
        }

        //Total of rejected items



       //search
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (jaye == 1)
            {
                DataView DV = new DataView(dba.get_process());
                DV.RowFilter = string.Format("Process_ID LIKE '%{0}%'", search_txt.Text);
                dataGridView1.DataSource = DV;
            }
            else if (jaye == 2)
            {
                DataView DV = new DataView(dba.getproduct_details());
                DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", search_txt.Text);
                dataGridView1.DataSource = DV;
            }
            else if (jaye == 3)
            {
                DataView DV = new DataView(dba.get_orders());
                DV.RowFilter = string.Format("order_id LIKE '%{0}%'", search_txt.Text);
                //DV.RowFilter = string.Format("completed_status LIKE 'not completed'", search_txt.Text);
                dataGridView1.DataSource = DV;
            }

            else if (jaye == 5)
            {
                DataView DV = new DataView(dba.getrejected_details());
                DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", search_txt.Text);
                dataGridView1.DataSource = DV;
            }

            else if (jaye == 6)
            {
                DataView DV = new DataView(dba.get_export_details());
                DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", search_txt.Text);
                dataGridView1.DataSource = DV;

            }
            else
            {

            }
                
        }

        

       //update product details

        private void update_button_Click(object sender, EventArgs e)
        {
            if (jaye == 2)
            {
                p_details upt = new p_details();
                upt.Visible = true;
                upt.p_save_button.Visible = false;

                upt.p_pid_txt.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                upt.p_cat_com.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                upt.p_size_com.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                upt.p_colour_txt.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                upt.p_uprice_txt.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                upt.p_quality_rating_com.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                upt.richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                this.Dispose();
                //upt.Show();

            }

            //update product process
            else if (jaye == 1)
            {
                p_process upt = new p_process();
                upt.Visible = true;
                upt.add_button.Visible = false;

                upt.pp_proid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                upt.details_secID_txt.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                upt.pp_in.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                upt.pp_out.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                upt.pp_pendquntity.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                upt.pp_quality_com.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                this.Dispose();
                //upt.Show();


            }

            //update order details
            else if (jaye == 3)
            {
                order_details upt = new order_details();
                upt.Visible = true;

                upt.order_id_label.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                upt.order_size_label.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                upt.order_colour_label.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                upt.order_design_label.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                upt.order_quantity_label.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                upt.oredr_date_label.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                upt.order_duedate_label.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                upt.order_status_com.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //upt.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

                this.Dispose();
            }

            else if (jaye == 5)
            {
                rejected upt = new rejected();
                upt.Visible = true;

                upt.reject_pID_label.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                upt.r_category_label.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                upt.r_alloction_label.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                upt.r_uprice_label.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                upt.r_sales_quality.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                upt.r_listBox.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                upt.r_date_label.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                upt.r_sales_month.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
               
                this.Dispose();

            }

            else { }

            }

        //Remove
        private void remove_button_Click(object sender, EventArgs e)
        {
            if (jaye == 1)
            {
                string pp_proid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (pp_proid != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Do you want to delete this item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.delete_process(pp_proid))
                        {
                            MessageBox.Show("Successfully Deleted!");
                            FillGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting!");
                        }
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Select the row!");
                }
            }
            
            if(jaye==2)
            {
                string p_pid_txt = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (p_pid_txt != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Do you want to delete this item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.delete_pdetails(p_pid_txt))
                        {
                            MessageBox.Show("Successfully Deleted!");
                            FillGrid2();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting!");
                        }
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Select the row!");
                }

            }

            // Remove rejected Items
            if (jaye == 5)
            {
                string rejectedID_txt = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (rejectedID_txt != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Do you want to delete this item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.delete_rejectedItems(rejectedID_txt))
                        {
                            MessageBox.Show("Successfully Deleted!");
                            FillGrid5();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting!");
                        }
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Select the row!");
                }

            }
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f3_sales_button_Click(object sender, EventArgs e)
        {
            FillGrid6();
            jaye = 6;

            button7.Visible = false;
            remove_button.Visible = false;
            update_button.Visible = false;

         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            report_1 repo = new report_1();
            repo.Visible = true;
        }

        private void pDetails_tot_button_Click(object sender, EventArgs e)
        {
            
            /*if (jaye == 2)
            {
                int A = 0, B = 0;
                for (A = 0; A < dataGridView1.Rows.Count; A++)
                {
                    B += Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);
                }
                totValue_label.Text = B.ToString();
            }

            if (jaye == 5 )
               
            {*/
                //string i = Convert.ToString(product_dateTime.Value.Date);
            //string m = product_dateTime.Text.Substring(0, 1);
            
               // if (month_txt.Text == "1")// || textBox1.Text = "01")
                //{

                    /*int A = 0, B = 0;
                    for (A = 0; A < dataGridView1.Rows.Count; A++)
                    {
                        B += Convert.ToInt32(dataGridView1.Rows[A].Cells[3].Value);
                    }
                    totValue_label.Text = B.ToString();*/
                }

        private void button2_Click(object sender, EventArgs e)
        {
            FillGrid5();
            jaye = 5;

            button7.Visible = false;
            remove_button.Visible = false;
        }


        // if(month_txt.Text = "01") || (month_txt.Text == "1"))
        //int i = ;

        /* int A = 0, B = 0;
         for (A = 0; A < dataGridView1.Rows.Count; A++)
         {
             B += Convert.ToInt32(dataGridView1.Rows[A].Cells[3].Value);
         }
         totValue_label.Text = B.ToString();
     }

     */
        // else if ()
        //{ }
    }

        /*private void button2_Click(object sender, EventArgs e)
        {
            FillGrid5();
            jaye = 5;

            
        }*/
    }

