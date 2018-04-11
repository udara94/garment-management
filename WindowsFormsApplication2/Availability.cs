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
    public partial class Availability : Form
    {
        DBconnection dba = new DBconnection();

        public Availability()
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

        private void radd_Click(object sender, EventArgs e)
        {
            if (txtadid.Text == "")
            {
                lblAdid.Visible = true;
            }
            else if (txtavid.Text == "")
            {
                lblavid.Visible = true;
            }
            else if (comboBox1.Text == "")
            {
                lblca.Visible = true;
            }
            else
            {
                if (dba.insertAvailability(txtadid.Text, txtavid.Text, Convert.ToString(comboBox1.SelectedItem)))
                {
                    MessageBox.Show("Successfully Added");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
            
            DataTable dt = dba.availability();
            rdataGridView1.DataSource = dt.DefaultView;

        }
        public void Clear()
        {
            txtadid.Clear();
            lblAdid.Hide();
            txtavid.Clear();
            lblavid.Hide();
            comboBox1.SelectedItem = null;

            aadd.Enabled = true;

        }

        private void Availability_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.availability();
            rdataGridView1.DataSource = dt.DefaultView;
        }

        private void txtrsrch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.availability());
            DV.RowFilter = string.Format("DriverID LIKE '%{0}%' or vehicleID LIKE '%{0}%'", txtrsrch.Text);
            rdataGridView1.DataSource = DV;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Form5 f5 = new Form5();
            this.Dispose();
            f5.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            this.Dispose();
            f1.ShowDialog();
        }
    }
}
