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
    public partial class updateAvailability : Form
    {
        DBconnection dba = new DBconnection();

        public updateAvailability()
        {
            InitializeComponent();
        }

        private void rdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pichome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void txtrsrch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.availability());
            DV.RowFilter = string.Format("vehicleID LIKE '%{0}%' or DriverID LIKE '%{0}%'", txtrsrch.Text);
            rdataGridView1.DataSource = DV;
        }

        private void rsb1_Click(object sender, EventArgs e)
        {

        }

        private void dback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        public void FillAvailability()
        {
            DataTable dt = dba.availability();
            rdataGridView1.DataSource = dt.DefaultView;
        }
            

        private void aadd_Click(object sender, EventArgs e)
        {
            if (dba.updateAvailability(txtadid_u.Text, txtavid_u.Text, Convert.ToString(comboBox1_u.SelectedItem)))
            {
                MessageBox.Show("Successfully Updated");
                FillAvailability();
               
            }
            else
            {
                MessageBox.Show("Error occured");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateAvailability_Load(object sender, EventArgs e)
        {
            FillAvailability();
        }

        private void rdataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtadid_u.Text = this.rdataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadid_u.Enabled = false;
            txtavid_u.Text = this.rdataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtavid_u.Enabled = false;
            comboBox1_u.SelectedItem = this.rdataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
