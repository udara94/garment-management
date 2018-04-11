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
    public partial class runningChart : Form
    {
        DBconnection dba = new DBconnection();

        public runningChart()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void txtrotime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtritime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtrvid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrdid_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfrom_Click(object sender, EventArgs e)
        {

        }

        private void rkm_Click(object sender, EventArgs e)
        {

        }

        private void rdate_Click(object sender, EventArgs e)
        {

        }

        private void ritime_Click(object sender, EventArgs e)
        {

        }

        private void rotime_Click(object sender, EventArgs e)
        {

        }

        private void rvid_Click(object sender, EventArgs e)
        {

        }

        private void rdid_Click(object sender, EventArgs e)
        {

        }

        private void radd_Click(object sender, EventArgs e)
        {
            if (txtrdid.Text == "")
            {
                lblrdid.Visible = true;
            }
            else if (txtrvid.Text == "")
            {
                lblrvid.Visible = true;
            }
            else if (txtrkm.Text == "")
            {
                lblkm.Visible = true;
            }
            else if (txtrfrom.Text == "")
            {
                lblfrom.Visible = true;
            }
            else if (txtrto.Text == "")
            {
                lblto.Visible = true;
            }

            else
            {
                if (dba.insertrunningdata(txtrdid.Text, txtrvid.Text, rdateTimePicker1.Value.ToString("HH:mm"), /*DateTime.Today.Date.ToString("MM/dd/yyyy"),*/
              rdateTimePicker2.Value.ToString("HH:mm"),/*DateTime.Today.Date.ToString("MM/dd/yyyy")*/
              rdateTimePicker3.Value.Date.ToString("MM/dd/yyyy"), /*DateTime.Today.Date.ToString("MM/dd/yyyy"),*/
              txtrkm.Text, txtrfrom.Text, txtrto.Text))
                {
                    MessageBox.Show("Successfully Added");
                    FillRunningChart();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
          
        }
        public void Clear()
        {
            txtrdid.Clear();
            lblrdid.Hide();
            txtrvid.Clear();
            lblrvid.Hide();
            rdateTimePicker1.Value = DateTime.Now;
            rdateTimePicker2.Value = DateTime.Now;
            rdateTimePicker3.Value = DateTime.Today;
            txtrkm.Clear();
            lblkm.Hide();
            txtrfrom.Clear();
            lblfrom.Hide();
            txtrto.Clear();
            lblto.Hide();

            radd.Enabled = true;

        }

        //---------Fill runnig chart ----
        public void FillRunningChart()
        {
            DataTable dt = dba.getrunningChart();
            rdataGridView1.DataSource = dt.DefaultView;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblrdid_Click(object sender, EventArgs e)
        {

        }

        private void runningChart_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.getrunningChart();
            rdataGridView1.DataSource = dt.DefaultView;
        }

        private void txtrsrch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getrunningChart());
            DV.RowFilter = string.Format("RunnigChartNumber LIKE '%{0}%'", txtrsrch.Text);
            rdataGridView1.DataSource = DV;
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
