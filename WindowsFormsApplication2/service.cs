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
    public partial class service : Form
    {
        public service()
        {
            InitializeComponent();
        }
        DBAccess7 dba = new DBAccess7();

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtmach_no.Text == "" && txtser_per.Text == "" && txtser_cost.Text == "" && cmbstation.Text == "")
            {
                MessageBox.Show("please insert details to add");
            }
            else if (txtmach_no.Text == "" || txtser_per.Text == "" || txtser_cost.Text == "" || cmbstation.Text == "")
            {
                validate_machineNO();
                validate_service_per();
                validate_service_cost();
                validate_service_company();
            }
            else
            {
                if (dba.addservice(txtmach_no.Text, txtser_date.Value.Date.ToString("MM/dd/yyyy"), txtser_per.Text, txtser_cost.Text, cmbstation.Text))
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

                DataTable dt2 = dba.getservice();
                add.dataGridView1.DataSource = dt2.DefaultView;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void validate_machineNO()
        {
            if (txtmach_no.Text == "")
            {
                lbl_mach_no.Text = "enter the machine number";
            }
            else
            {
                lbl_mach_no.Text = "";
            }
        }
        public void validate_service_per()
        {
            if (txtser_per.Text == "")
            {
                lbl_ser_per.Text = "enter the sevice period";
            }
            else
            {
                lbl_ser_per.Text = "";
            }
        }
        public void validate_service_cost()
        {
            if (txtser_cost.Text == "")
            {
                lbl_ser_cost.Text = "enter the service cost";
            }
            else
            {
                lbl_ser_cost.Text = "";
            }
        }
        public void validate_service_company()
        {
            if (cmbstation.Text == "")
            {
                lbl_ser_stat.Text = "enter the service station";
            }
            else
            {
                lbl_ser_stat.Text = "";
            }
        }
       private void txtser_cost_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(txtser_cost.Text, out value))
            {
                lbl_ser_cost.Text = "";
            }
            else
            {
                lbl_ser_cost.Text = "";
            }

        }
        private void txtmach_no_TextChanged(object sender, EventArgs e)
        {
            if(txtmach_no.Text != null)
            {
                lbl_mach_no.Text = "";
            }
            else
            {
                lbl_mach_no.Text = "enter the machine number";
            }
        }
        private void txtser_per_TextChanged(object sender, EventArgs e)
        {
            if (txtser_per.Text != null)
            {
                lbl_ser_per.Text = "";
            }
            else
            {
                lbl_ser_per.Text = "enter the service period";
            }
        }

        private void cmbstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ser_stat.Text = "";
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            Form7 fl = new Form7();
            if (dba.updateservice(this.lbl_service_no.Text, this.txtser_date.Value.Date.ToString("MM/dd/yyyy"), this.txtmach_no.Text, this.txtser_per.Text, this.txtser_cost.Text, this.cmbstation.Text))
            {

                MessageBox.Show("Successfully Updated");

                //DataSet ds = dba.getservice();
                // fl.dataGridView1.DataSource = ds.Tables["MachineServices"].DefaultView;

                DataTable dt2 = dba.getservice();
                fl.dataGridView1.DataSource = dt2.DefaultView;
                this.Dispose();
                fl.Show();
                

            }
            else
            {
                MessageBox.Show("Error occured");
            }

        }

        private void txtser_stat_TextChanged(object sender, EventArgs e)
        {

        }

      
       

     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            txtser_date.Text = ("2009/9/25");
            txtmach_no.Text = ("120");
            txtser_per.Text = ("6 month");
            txtser_cost.Text = ("1000");
            cmbstation.Text = ("Singer");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();
            this.Visible = false;
            back.Visible = true;
        }

        private void service_Load(object sender, EventArgs e)
        {
            //fillcom();
        }
        public void fillcom()
        {
            DataTable dt1 = dba.getservice();
            cmbstation.ValueMember = "ServiceStation";
            cmbstation.DisplayMember = "ServiceStation";
            cmbstation.DataSource = dt1;

        }

        private void txtser_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
