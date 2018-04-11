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
    public partial class vdetails : Form

    {
        DBconnection dba = new DBconnection();
        

        public vdetails()
        {
            InitializeComponent();
        }

        private void ds1_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vdetails_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.getVehicle();
            vdataGridView1.DataSource = dt.DefaultView;
        }

        private void vtype_lable_Click(object sender, EventArgs e)
        {

        }

        private void vmw_lable_Click(object sender, EventArgs e)
        {

        }

        private void vnu_lable_Click(object sender, EventArgs e)
        {

        }

        private void vlin_lable_Click(object sender, EventArgs e)
        {

        }

        private void vlied_lable_Click(object sender, EventArgs e)
        {

        }

        private void vadd_Click(object sender, EventArgs e)
        {

            if (txtvnu.Text == "")
            {
                vnu_lable.Visible = true;
            }
            else if (cmbtype.Text == "")
            {
                vtype_lable.Visible = true;
            }
            else if (cmbmW.Text == "")
            {
                vmw_lable.Visible = true;
            }
            else if (txtvlin.Text == "")
            {
                vlin_lable.Visible = true;
            }
        
            else
            {
                if (dba.insertVehicle(txtvnu.Text, Convert.ToString(cmbtype.SelectedItem), cmbmW.Text, txtvlin.Text,vdateTimePicker1.Value.Date.ToString("MM/dd/yyyy")))
                {
                    MessageBox.Show("Successfully Added");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                DataTable dt = dba.getVehicle();
                vdataGridView1.DataSource = dt.DefaultView;

            }

        }

        public void Clear()
        {
            txtvnu.Clear();
            vnu_lable.Hide();
            cmbtype.SelectedItem = null;
            vtype_lable.Hide();
            cmbmW.SelectedItem = null;
            vmw_lable.Hide();
            txtvlin.Clear();
            vlin_lable.Hide();
            vdateTimePicker1.Value = DateTime.Today;
           

            vadd.Enabled = true;

        }

        private void vback_Click(object sender, EventArgs e)
        {

        }

        private void dback1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void demov_Click(object sender, EventArgs e)
        {
            txtvnu.Text = "TY9098";
            cmbtype.SelectedItem = "Lorry";
            cmbtype.SelectedItem = "1000kg";
            txtvlin.Text = "8789";
            vdateTimePicker1.Text = ("3/4/2011");
        }

        private void txtvs1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getVehicle());
            DV.RowFilter = string.Format("vehicleID LIKE '%{0}%' or VehicleNumber LIKE '%{0}%'", txtvs1.Text);
            vdataGridView1.DataSource = DV;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
    }

