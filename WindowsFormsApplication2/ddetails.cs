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
    public partial class ddetails : Form
    {
        DBconnection dba = new DBconnection();
       

        public ddetails()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ddetails_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.getDriver();
            dataGridView2.DataSource = dt.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cmbdtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dadd_Click(object sender, EventArgs e) //add button event
        {
         
            if (txtnic.Text == "")
            {
                dnic_lable.Visible = true;
            }
            else if (txtdname.Text == "")
            {
                dname_lable.Visible = true;
            }
            else if(txtdaddress.Text == "")
            {
                daddress_lable.Visible = true;
            }
            else if(txtdtelephone.Text == "")
            {
                dtelephone_lable.Visible = true;
            }
            else if(txtdlnu.Text == "")
            {
                dlnu_lable.Visible = true;
            }
            else if(cmbdtype.Text == "")
            {
                dltype_lable.Visible = true;
            }
            else
            {
                if (dba.insertDriver(txtnic.Text, txtdname.Text, txtdaddress.Text, txtdtelephone.Text,
                  dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), /*DateTime.Today.Date.ToString("MM/dd/yyyy"),*/ txtdlnu.Text,
                  dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"),/*DateTime.Today.Date.ToString("MM/dd/yyyy")*/
                  Convert.ToString(cmbdtype.SelectedItem)))
                {
                    MessageBox.Show("Successfully Added");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                DataTable dt = dba.getDriver();
                dataGridView2.DataSource = dt.DefaultView;
            }

        }

        public void Clear()
        {
            txtnic.Clear();
            dnic_lable.Hide();
            txtdname.Clear();
            dname_lable.Hide();         
            txtdaddress.Clear();
            daddress_lable.Hide();
            txtdtelephone.Clear();
            dtelephone_lable.Hide();
            dateTimePicker1.Value = DateTime.Today;
            txtdlnu.Clear();
            dlnu_lable.Hide();
            dateTimePicker2.Value = DateTime.Today;
            cmbdtype.SelectedItem=null;


            dadd.Enabled = true;
          
        }

        private void ds1_Click(object sender, EventArgs e)
        {
     
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtdtelephone_TextChanged(object sender, EventArgs e)
        {
            if(txtdtelephone.Text=="")
            {
                validate4n.Text = "";
            }
            else if(txtdtelephone.Text.Count(char.IsDigit)==10)
            {
                validate4n.Text = "Correct phone number";
            }
            else
            {
                validate4n.Text = "Incorrect phone number";
            }
        }

        private void txtdid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            if(txtnic.Text=="")
            {
                validatenic.Text = "";
            }
            else if((txtnic.Text.Count(char.IsDigit)==9) && (txtnic.Text.EndsWith("X")||(txtnic.Text.EndsWith("V")) && (txtnic.Text[2]!='4' && txtnic.Text[2]!=9)))
            {
                validatenic.Text = "NIC is correct";
            }
            else
            {
                validatenic.Text="NIC is incorrect";
            }
        }

        private void txtdname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdlnu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date)
            {
                labeldate.Visible = true;
                //MessageBox.Show("Please recheck DuDate");
            }
            else
            {
                labeldate.Text = "";
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5  = new Form5();
            f5.ShowDialog();
        }

        private void pichome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void ddatasave_Click(object sender, EventArgs e)
        {

        }

        private void txtds1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtdtelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void demod_Click(object sender, EventArgs e)
        {
            //txtdid.Text = "0001";
            txtnic.Text = "895674561V";
            txtdname.Text = "Sugath Perera";
            txtdaddress.Text = "Koggala";
            txtdtelephone.Text = "0774568912";
            dateTimePicker1.Text=("3/4/2011");
            txtdlnu.Text = "B1234567";
            dateTimePicker2.Text=("8/2/2012");
            cmbdtype.SelectedItem = "Light";


        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getDriver());
            DV.RowFilter = string.Format("DriverID LIKE '%{0}%'", txts.Text);
            dataGridView2.DataSource = DV;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
    }


