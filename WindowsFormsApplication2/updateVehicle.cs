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
    public partial class updateVehicle : Form
    {
        DBconnection dba = new DBconnection();
        

        public updateVehicle()
        {
            InitializeComponent();
        }

        private void bvupdateView_Click(object sender, EventArgs e)
        {
          
        
            
        }
        public void FillVehicle()
        {
            DataTable dt = dba.getVehicle();
            vdataGridView1.DataSource = dt.DefaultView;
        }

        private void vupdate_Click(object sender, EventArgs e)
        {
            if (dba.updateVehicle(txtvnu_uv.Text,Convert.ToString(cmbtype_uv.SelectedItem), txtvmaxw_uv.Text, txtvlin_uv.Text, vdateTimePicker1_u.Value.Date.ToString("MM/dd/yyyy") /*DateTime.Today.Date.ToString("MM/dd/yyyy"),*/))
            {
                MessageBox.Show("Successfully Updated");
                FillVehicle();
                

            }
            else
            {
                MessageBox.Show("Error occured");
            }

        }

        private void vdataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtvid_uv.Text = this.vdataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtvid_uv.Enabled = false;
            txtvnu_uv.Text = this.vdataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbtype_uv.SelectedItem = this.vdataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtvmaxw_uv.Text = this.vdataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtvlin_uv.Text = this.vdataGridView1.CurrentRow.Cells[4].Value.ToString();
            //vdateTimePicker1_u.Value = Convert.ToDateTime(vdataGridView1.CurrentRow.Cells[5].Value);
            vdataGridView1.Text = this.vdataGridView1.CurrentRow.Cells[5].Value.ToString();
        }





        private void updateVehicle_Load(object sender, EventArgs e)
        {
            FillVehicle();
        }

        private void dback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void pichome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void txtvs1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dba.getVehicle());
            DV.RowFilter = string.Format("vehicleID LIKE '%{0}%' or VehicleNumber LIKE '%{0}%'", txtvs1.Text);
            vdataGridView1.DataSource = DV;
        }

        private void dback1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
