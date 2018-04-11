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
    public partial class transportc : Form
    {
        DBconnection dba = new DBconnection();
       

        public transportc()
        {
            InitializeComponent();
        }

        private void pichome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void dback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void dadd_Click(object sender, EventArgs e)
        {
            if (txttcvid.Text == "")
            {
                lbltcvid.Visible = true;
            }
            else if (txttckm.Text == "")
            {
                lbltckm.Visible = true;
            }
            else if (cmbtctype.Text == "")
            {
                lbltcftype.Visible = true;
            }

            else
            {
                if (dba.inserttransportc(txttcvid.Text, txttckm.Text, Convert.ToString(cmbtctype.SelectedItem), labelDC.Text, labelOC.Text, label1.Text))
                {
                    MessageBox.Show("Successfully Added");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

                DataTable dt = dba.gettranspocost();
                dataGridView2.DataSource = dt.DefaultView;
            }

        }

        public void Clear()
        {
            txttcvid.Clear();
            lbltcvid.Hide();
            txttckm.Clear();
            lbltckm.Hide();
            cmbtctype.SelectedItem = null;
            lbltcftype.Hide();
            labelDC.Text = "0";
            labelOC.Text = "0";
            label1.Text = "0";
            tcadd.Enabled = true;

            tcadd.Enabled = true;

        }

        //--------------calculate transport cost-------------

        private void calc_Click(object sender, EventArgs e)
        {
            
      
        }

        private void cmbtctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //--------------petrol------------------------------
            if (cmbtctype.SelectedIndex == 0)
            {

                float distance = (float)Convert.ToDouble(txttckm.Text);

                float driverCost = (float)Convert.ToDouble(labelDC.Text);


                float otherCost = (float)Convert.ToDouble(labelOC.Text);


                double cost = (distance * 45);
                double cost1 = driverCost + otherCost;
                double fcost = cost + cost1;
                label1.Text = fcost.ToString();
            }

            //---------------------- diesel----------------------
            else if (cmbtctype.SelectedIndex == 1)
            {

                float distance = (float)Convert.ToDouble(txttckm.Text);

                float driverCost = (float)Convert.ToDouble(labelDC.Text);

                float otherCost = (float)Convert.ToDouble(labelOC.Text);

                double cost = (distance * 50);
                double cost1 = driverCost + otherCost;
                double fcost = cost + cost1;
                label1.Text = fcost.ToString();
            }
        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.gettranspocost());
            DV.RowFilter = string.Format("TranspotationID LIKE '%{0}%'", txts.Text);
            dataGridView2.DataSource = DV;
        }

        private void transportc_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.gettranspocost();
            dataGridView2.DataSource = dt.DefaultView;
        }

        private void txttckm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float a = (float)Convert.ToDouble(txttckm.Text);
                // bool valid = float.TryParse(txttckm.Text.ToString(), out a);


                if (a <= 20)
                {
                    labelDC.Text = "700";
                    labelOC.Text = "500";
                }

                else if (a > 20 && a <= 40)
                {
                    labelDC.Text = "1000";
                    labelOC.Text = "800";
                }

                else if (a > 40 && a <= 60)
                {
                    labelDC.Text = "1200";
                    labelOC.Text = "1000";
                }

                else if (a > 60 && a <= 80)
                {
                    labelDC.Text = "1500";
                    labelOC.Text = "1200";
                }

                else if (a > 80 && a <= 100)
                {
                    labelDC.Text = "2000";
                    labelOC.Text = "1500";
                }

                else if (a > 100 && a <= 120)
                {
                    labelDC.Text = "2200";
                    labelOC.Text = "1700";
                }


                else if (a > 120 && a <= 140)
                {
                    labelDC.Text = "2400";
                    labelOC.Text = "2000";
                }


                else if (a > 140 && a <= 160)
                {
                    labelDC.Text = "2500";
                    labelOC.Text = "2200";
                }


                else if (a > 160 && a <= 200)
                {
                    labelDC.Text = "2800";
                    labelOC.Text = "2400";
                }

                else if (a > 200 && a <= 300)
                {
                    labelDC.Text = "3000";
                    labelOC.Text = "2800";
                }

                else if (a > 300)
                {
                    labelDC.Text = "4000";
                    labelOC.Text = "3000";
                }

                else
                {

                }

            }
            catch
            {
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}