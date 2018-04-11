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
    public partial class updateDriver : Form
    {
        DBconnection dba = new DBconnection();
       
        
        public updateDriver()
        {
            InitializeComponent();
        }

        private void bdupdate_Click(object sender, EventArgs e)
        {

        }

        public void FillDriver()
        {
            DataTable dt = dba.getDriver();
            dataGridView2.DataSource = dt.DefaultView;
        }

        private void dupdate_Click(object sender, EventArgs e)
        {
            //this.Hide();

            if (dba.updateDriver(txtnic_u.Text, txtdname_u.Text, txtdaddress_u.Text, txtdtelephone_u.Text,
                        dateTimePicker1_u.Value.Date.ToString("MM/dd/yyyy"), /*DateTime.Today.Date.ToString("MM/dd/yyyy"),*/ txtdlnu_u.Text,
                        dateTimePicker2_u.Value.Date.ToString("MM/dd/yyyy"),/*DateTime.Today.Date.ToString("MM/dd/yyyy")*/
                        Convert.ToString(cmbdtype_u.SelectedItem)))
            {
                MessageBox.Show("Successfully Updated");
                FillDriver();

            }
            else
            {
                MessageBox.Show("Error occured");
            }


        }

        private void updateDriver_Load(object sender, EventArgs e)
        {
            FillDriver();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtdid_u.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtdid_u. Enabled = false;
            txtnic_u.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtdname_u.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtdaddress_u.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtdtelephone_u.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1_u.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[5].Value);
            txtdlnu_u.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2_u.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[7].Value);
            cmbdtype_u.SelectedItem = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void dback1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void did_u_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtds1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getDriver());
            DV.RowFilter = string.Format("DriverID LIKE '%{0}%'", txtds1.Text);
            dataGridView2.DataSource = DV;
        }

        private void dateTimePicker2_u_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1_u.Value.Date < dateTimePicker2_u.Value.Date)
            {
                labeldate_u.Visible = true;
                //MessageBox.Show("Please recheck DuDate");
            }
            else
            {
                labeldate_u.Text = "";
            }
        }
    }
}

