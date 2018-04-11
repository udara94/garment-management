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
    public partial class Repaire : Form
    {
        public Repaire()
        {
            InitializeComponent();
        }

        DBAccess7 dba = new DBAccess7();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_machid.Text == "" && cmbreptype.Text == "" && txtrepcost.Text == "" && cmb_date.Text == "" && cmb_month.Text == "" && cmb_year.Text == "")
            {
                MessageBox.Show("please fill the values to add");
            }
            else if (txt_machid.Text == "" || cmbreptype.Text == "" || txtrepcost.Text == "" || cmb_date.Text == "" || cmb_month.Text == "" || cmb_year.Text == "")
            {
                validate_machineID();
                validate_RepType();
                validate_Repcost();
                validate_date();


            }
            else
            {
                if (dba.addrepaire(txt_machid.Text, cmbreptype.Text, txtrepcost.Text, cmb_date.Text, cmb_month.Text, cmb_year.Text))
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

                DataTable dt2 = dba.getrepaire();
                add.dataGridView1.DataSource = dt2.DefaultView;


            }


        }
        public void validate_machineID()
        {
            if (txt_machid.Text == "")
            {
                lbl_mach_ID.Text = " enter the Mahine ID";
            }
            else
            {
                lbl_mach_ID.Text = "";
            }
        }
        public void validate_RepType()
        {
            if (cmbreptype.Text == "")
            {
                lbl_repaire.Text = "enter the repaire type";
            }
            else
            {
                lbl_repaire.Text = "";
            }
        }
        public void validate_Repcost()
        {
            if (txtrepcost.Text == "")
            {
                lbl_rep_cost.Text = "enter the repaire cost";
            }
            else
            {
                lbl_rep_cost.Text = "";
            }
        }
        public void validate_date()
        {
            if (cmb_date.Text == "" || cmb_month.Text=="" ||cmb_year.Text=="" )
            {
                lbl_date.Text = "enter the repaire date";
            }
            else
            {
                lbl_date.Text = "";
            }
        }
        private void txtrepcost_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtrepcost.Text, out value))
            {
                lbl_rep_cost.Text = "Please enter only the numbers";
            }
            else
            {
                lbl_rep_cost.Text = "";
            }
        }
        private void txt_machid_TextChanged(object sender, EventArgs e)
        {
            if(txt_machid != null)
            {
                lbl_mach_ID.Text = "";
            }
      
        }
        private void cmbreptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_repaire.Text = "";
        }

        private void Repaire_Load(object sender, EventArgs e)
        {
            
        }

        public void fillMachine()
        {
            DataTable dt1 = dba.getrepaire();
            cmbreptype.ValueMember = "RepaireType";
            cmbreptype.DisplayMember = "RepaireType";
            cmbreptype.DataSource = dt1;


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();
            this.Visible = false;
            back.Visible = true;
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            txt_machid.Text = "MC00001";
            cmbreptype.Text = "motor change";
            txtrepcost.Text = "3000";
            cmb_year.Text = "2007";
            cmb_month.Text = "March";
            cmb_date.Text = "14";
        }

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
