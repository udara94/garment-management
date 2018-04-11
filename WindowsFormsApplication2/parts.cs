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

namespace WindowsFormsApplication2
{
    public partial class parts : Form
    {
        public parts()
        {
            InitializeComponent();
        }
        DBAccess7 dba = new DBAccess7();
        private void btnpart_add_Click(object sender, EventArgs e)
        {
            if (cmbpurcom.Text == "" && cmbtype.Text == "" && txtpur_price.Text == "" && txtqty.Text == "")
            {
                MessageBox.Show("please fill the details to enter");
            }
            else if(cmbpurcom.Text == "" || cmbtype.Text == "" || txtpur_price.Text == "" || txtqty.Text == "")
            {
                validate_type();
                validate_pur_price();
                validate_quantity();
                validate_pur_com();



            }
            else
            {
                if (dba.addparts(cmbtype.Text, txtqty.Text, txtpur_price.Text, txtins_date.Value.Date.ToString("MM/dd/yyyy"), cmbpurcom.Text, txt_pur_date.Value.Date.ToString("MM/dd/yyyy")))
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

                DataTable dt2 = dba.getparts();
                add.dataGridView1.DataSource = dt2.DefaultView;

            }
        }

        //---------------------------------------------------------------------------------------------------------------------
        public void validate_type()
        {
            if (cmbtype.Text == "")
            {
                lbl_type.Text = "enter the type";
            }
            else
            {
                lbl_type.Text = "";
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void validate_pur_price()
        {

            if (txtpur_price.Text == "")
            {
                lbl_pur_pri.Text = "enter the price";
            }
            else
            {
                lbl_pur_pri.Text = "";
            }

        }
        //------------------------------------------------------------------------------------------------------------------------
        public void validate_quantity()
        {

            if (txtqty.Text == "")
            {
                lbl_qty.Text = "enter the quantity";
            }
            else
            {
                lbl_qty.Text = "";
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void validate_pur_com()
        {
            
            if (cmbpurcom.Text == "")
            {
                lbl_pur_com.Text = "enter the company";
            }
            else
            {
                lbl_pur_com.Text = "";
            }
        }
        //----------------------------------------------------------------------------------------------------------------------

       private void txtpur_price_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtpur_price.Text, out value))
            {
                lbl_pur_pri.Text = "";
            }
            else
            {
                lbl_pur_pri.Text = "";
            }
        }
        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtqty.Text, out value))
            {
                lbl_qty.Text = "";
            }
            else
            {
                lbl_qty.Text = "";
            }
        }
        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_type.Text = "";

        }
        private void cmbpurcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_pur_com.Text = "";
        }

        private void btnpart_update_Click(object sender, EventArgs e)
        {
            Form7 fl = new Form7();
            if (dba.updateparts(this.lbl_part_id.Text, this.cmbtype.Text, this.txtpur_price.Text, Convert.ToInt32(this.txtqty.Text), this.txtins_date.Value.Date.ToString("MM/dd/yyyy"),this.cmbpurcom.Text, this.txt_pur_date.Value.Date.ToString("MM/dd/yyyy")))
            {
               

                MessageBox.Show("Successfully Updated");

                clean();
                Form7 show = new Form7();

                DataTable dt2 = dba.getparts();
                show.dataGridView1.DataSource = dt2.DefaultView;

                


            }
            else
            {
                MessageBox.Show("Error occured");
            }
            
           


            this.Visible = false;
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
          
        }
        public void clean()
        {
          
            
            txtpur_price.Text = null;
            txtqty.Text = null;
            txtins_date.Text = null;
            
            txt_pur_date.Text = null;
        }

       

       

        private void btn_demo_Click(object sender, EventArgs e)
        {
            
            cmbtype.Text = ("Motor");
            txtpur_price.Text = ("1500");
            txtqty.Text = ("2");
            txtins_date.Text = ("2007/03/21");
            cmbpurcom.Text = ("Singer");
            txt_pur_date.Text = ("2007/01/25");
        }

        private void parts_Load(object sender, EventArgs e)
        {
            //fillMachine();
            //cmbpurcom.Items.Add()
        }
        public void fillMachine()
        {
            DataTable dt1 = dba.getparts();
            cmbpurcom.ValueMember = "PurchaseCompany";
            cmbpurcom.DisplayMember = "PurchaseCompany";
            cmbtype.DisplayMember = "Type";
            cmbpurcom.DataSource = dt1;


        }


        private void btnback_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();
            this.Visible = false;
            back.Visible = true;
        }

        private void txt_pur_date_ValueChanged(object sender, EventArgs e)
        {
            if( txt_pur_date.Value.Date>txtins_date.Value.Date)
            {
                lbl_validate.Text = "Please enter a correct date";
            }
            else
            {
                lbl_validate.Text = " ";
            }
        }

        private void txtpur_price_TextChanged_1(object sender, EventArgs e)
        {

            int value;
            if (!int.TryParse(txtpur_price.Text, out value))
            {
                lbl_pur_pri.Text = "";
            }
            else
            {
                lbl_pur_pri.Text = "";
            }
        }
    }
}
