using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication2
{
    public partial class btn_demo : Form
    {
        

        public btn_demo()
        {
            InitializeComponent();
        }
        DBAccess7 dba = new DBAccess7();

        private void Machine_Details_Load(object sender, EventArgs e)
        {
            //cmbtype.Items.Add("washine machine");
            // fillMachine();
            // fillcom();
        }
        public void fillMachine()
        {
            DataTable dt1 = dba.getmachine();
            cmbtype.ValueMember = "Type";
            cmbtype.DisplayMember = "Type";
            cmbtype.DataSource = dt1;
         

        }
        public void fillcom()
        {
            DataTable dt1 = dba.getmachine();
            cmbpurcom.ValueMember = "PurchaseCompany";
            cmbpurcom.DisplayMember = "PurchaseCompany";
            cmbpurcom.DataSource = dt1;

        }


        private void txttype_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmachine_no_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmonth_dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtann_dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtser_date_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtpur_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbtype.Text == "" && txtpur_price.Text == "" && cmbpurcom.Text == "" && txt_estlife.Text == "")
            {
                MessageBox.Show("Please fill the details to add the machine details");
              
            }
            else if(cmbtype.Text == "" || txtpur_price.Text == "" || cmbpurcom.Text == "" || txt_estlife.Text == "")
            {
                validate_type();
                validate_purchase_price();
                validate_purchase_company();
                validate_etsim_life();
            }
            else 
            { 
        
                if (dba.addmachine(cmbtype.Text, txtinstall_date.Value.Date.ToString("MM/dd/yyyy"), txtser_date.Value.Date.ToString("MM/dd/yyyy"), txtpur_price.Text, cmbpurcom.Text, txt_estlife.Text))
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                Form7 add = new Form7();
                this.Visible = false;
                add.Visible = true;

                DataTable dt2 = dba.getmachine();
                add.dataGridView1.DataSource = dt2.DefaultView;
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public void validate_type()
        {
            if (cmbtype.Text == "")
            {
                lbl_type.Text = "please select the machine type";
            }
            else
            {
                lbl_type.Text = "";
            }
        }
        //----------------------------------------------------------------------------------------------------------
        public void validate_purchase_price()
        {
            if (txtpur_price.Text == "")
            {
                lbl_pur.Text = "enter the purchase price";
            }
            else
            {
                lbl_pur.Text = "";
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public void validate_purchase_company()
        {
            if (cmbpurcom.Text == "")
            {
               lbl_com.Text = "enter the purchase company";
            }
            else
            {
                lbl_com.Text = "";
            }
        }
        //-------------------------------------------------------------------------------------------------------------------
        public void validate_etsim_life()
        {
            if (txt_estlife.Text == "")
            {
               lbl_est_life.Text = "enter the estimated life";
            }
            else
            {
                lbl_est_life.Text = "";
            }
        }
        //-----------------------------------------------------------------------------------------------------

        private void txtpur_price_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtpur_price.Text,out value))
            {
                lbl_pur.Text = "";
            }
            else
            {
                lbl_pur.Text = "";
            }


        }
        //-----------------------------------------------------------------------------------------------------------

        private void txt_estlife_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txt_estlife.Text, out value))
            {
                lbl_est_life.Text = "Please enter only the numbers";
            }
            else
            {
                lbl_est_life.Text = "";
            }


        }
        //--------------------------------------------------------------------------------------------------------------------
        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_type.Text = "";

        }
        private void cmbpurcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_com.Text = "";

        }

        //----------------------------------------------------------------------------------------------------------------------
        private void btnupdate_Click(object sender, EventArgs e)
        {
            

            Form7 fl = new Form7();
            if (dba.updatemachine(this.lbl_mach_id.Text,this.cmbtype.Text, this.txtinstall_date.Value.Date.ToString("MM/dd/yyyy"), this.txtser_date.Value.Date.ToString("MM/dd/yyyy"), this.txtpur_price.Text, this.cmbpurcom.Text, Convert.ToInt32(this.txt_estlife.Text)))
             {
               


                MessageBox.Show("Successfully Updated");

                this.Visible = false;
                Form7 show = new Form7();

                DataTable dt2 = dba.getmachine();
                show.dataGridView1.DataSource = dt2.DefaultView;

                show.Visible = true;

            }
            else
            {
                MessageBox.Show("Error occured");
            }
           
           
            
            txtinstall_date.Text = null;
            txtser_date.Text = null;
            txtpur_price.Text = null;
            
            




        }

        private void txt_cost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbtype.Text = ("Swing Machine");
            txtinstall_date.Text = ("2008/9/25");
            cmbpurcom.Text = ("Singer");
            txtser_date.Text = ("2009/9/20");
            txtpur_price.Text = ("30000");
            txt_estlife.Text = ("5");


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();
            this.Visible = false;
            back.Visible = true;

        }

        private void txtser_date_ValueChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
