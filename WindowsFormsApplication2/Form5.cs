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
    public partial class Form5 : Form
    {
        DBconnection dba = new DBconnection();
        int mwindow = 0;
        int umwindow = 0;    

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillDriver();
            mwindow = 1;
            umwindow = 1;
            label2.Text = bviewDriverData.Text;
            mbtn_Add.Visible = true;
            mbtn_Update.Visible = true;
            mbtn_Remove.Visible = true;
        }
        public void FillDriver()
        {
            DataTable dt = dba.getDriver();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            /*this.Hide();
            ddetails ddata = new ddetails();
            ddata.ShowDialog();*/
        }


        private void button11_Click(object sender, EventArgs e)
        {
    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //------------transpotationCost-----------------------------------

        private void button7_Click(object sender, EventArgs e)
        {
            FillTCost();
            mwindow = 4;
            label2.Text = button7.Text;
            mbtn_Add.Visible = true;
            mbtn_Update.Visible = false;
            mbtn_Remove.Visible = true;
        }
        public void FillTCost()
        {
            DataTable dt = dba.gettranspocost();
            dataGridView1.DataSource = dt.DefaultView;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            FillVehicle();
            mwindow = 2;
            umwindow = 2;
            label2.Text = bviewvdata.Text;
            mbtn_Add.Visible = true;
            mbtn_Update.Visible = true;
            mbtn_Remove.Visible = true;

        }
        public void FillVehicle()
        {
            DataTable dt = dba.getVehicle();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void beditdriverdata_Click(object sender, EventArgs e)
        {
           
        }

        private void beditvdata_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (mwindow == 1)
            {
                DataView DV = new DataView(dba.getDriver());
                DV.RowFilter = string.Format("DriverID LIKE '%{0}%'", maintxtds.Text);
                dataGridView1.DataSource = DV;
            }

            else if (mwindow == 2)
            {
                DataView DV = new DataView(dba.getVehicle());
                DV.RowFilter = string.Format("vehicleID LIKE '%{0}%'", maintxtds.Text);
                dataGridView1.DataSource = DV;
            }

            else if (mwindow == 3)
            {
                DataView DV = new DataView(dba.getrunningChart());
                DV.RowFilter = string.Format("RunnigChartNumber LIKE '%{0}%'", maintxtds.Text);
                dataGridView1.DataSource = DV;
            }

            else if (mwindow == 4)
            {
                DataView DV = new DataView(dba.gettranspocost());
                DV.RowFilter = string.Format("TranspotationID LIKE '%{0}%'", maintxtds.Text);
                dataGridView1.DataSource = DV;
            }

            else if (mwindow == 5)
            {
                DataView DV = new DataView(dba.availability());
                DV.RowFilter = string.Format("vehicleID LIKE '%{0}%' or DriverID LIKE '%{0}%'", maintxtds.Text);
                dataGridView1.DataSource = DV;
            }

        }


    private void mbtn_Add_Click(object sender, EventArgs e)
        {
            //add button
            //------------driver details------------
            if (mwindow == 1)
            {
                this.Hide();
                ddetails vdata = new ddetails();
                vdata.ShowDialog();
            }
            //---------vehicle details--------------

            else if (mwindow == 2)
            {
                this.Hide();
                vdetails vdata = new vdetails();
                vdata.ShowDialog();
            }

            //------runnig chart details---------
            else if (mwindow == 3)
            {
                this.Hide();
                runningChart rdata = new runningChart();
                rdata.ShowDialog();
            }

            //---------transport Cost--------

           else if(mwindow==4)
            {
                this.Hide();
                transportc tc = new transportc();
                tc.ShowDialog();
            }

            //--------------availability-------------

            else if(mwindow==5)
            {
                this.Hide();
                Availability tc = new Availability();
                tc.ShowDialog();
            }

        }

        private void mbtn_Update_Click(object sender, EventArgs e)
        {
            //update button
            //--------update driver---------
            if (umwindow == 1)
            {
                updateDriver updd = new updateDriver();
                updd.Visible = true;
                this.Visible = false;
            }

            //--------update vehicle---------
            else if (umwindow==2)
            {
                updateVehicle updv = new updateVehicle();
                updv.Visible = true;
                this.Visible = false;
            }

            //----------update Availability----------
            else if (umwindow == 3)
            {
                updateAvailability upda = new updateAvailability();
                upda.Visible = true;
                this.Visible = false;
            }


        }

        private void mbtn_Remove_Click(object sender, EventArgs e)
        {
            //--------------------remove driver-------------------------
            if(mwindow==1)
            {
                string DriverID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string NIC = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();


                if (DriverID != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you sure to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteDriver(DriverID, NIC))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillDriver();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }
                }
            
            }

            //---------------remove vehicle-----------------

            else if(mwindow==2)
            {
                string VehicleNumber = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                if (VehicleNumber != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you sure to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteVehicle(VehicleNumber))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillVehicle();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }
                }

            }

            //-------------remove Transpotation cost--------------------------------------------------
            else if (mwindow == 4)
            {
                string TranspotationID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (TranspotationID != null)
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you sure to delete this? ", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        if (dba.deleteVehicle(TranspotationID))
                        {
                            MessageBox.Show("Successfully deleted");
                            FillVehicle();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");

                    }
                }

            }
        }

        private void maincmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //--------------Availability--------------
        private void button1_Click(object sender, EventArgs e)
        {
            FillAvailability();
            mwindow = 5;
            umwindow = 3;
            label2.Text = button1.Text;
            mbtn_Add.Visible = true;
            mbtn_Update.Visible = true;
            mbtn_Remove.Visible = false;


        }
        public void FillAvailability()
        {
            DataTable dt = dba.availability();
            dataGridView1.DataSource = dt.DefaultView;
        }


        //-------------------Running Chart------------------
        private void button2_Click(object sender, EventArgs e)
        {
            FillRunningChart();
            mwindow = 3;
            label2.Text = button2.Text;
            mbtn_Add.Visible = true;
            mbtn_Update.Visible = false;
            mbtn_Remove.Visible = false;

        }
        public void FillRunningChart()
        {
            DataTable dt = dba.getrunningChart();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = button3.Text;

            crdriver cd = new crdriver();
            cd.Visible = true;
            this.Visible = false;
        }
    }

}

