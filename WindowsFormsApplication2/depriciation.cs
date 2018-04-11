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
    public partial class depriciation : Form
    {
        public depriciation()
        {
            InitializeComponent();
        }
        DBAccess7 dba = new DBAccess7();
       
        
        /*private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }*/

        private void depriciation_Load(object sender, EventArgs e)
        {
          
            DataSet ds = dba.getdepreciation();
            dgvdep.DataSource = ds.Tables["Machines"].DefaultView;
        }

        private void dgvdep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_machine_id.Text = this.dgvdep.CurrentRow.Cells[0].Value.ToString();
            txt_type.Text = this.dgvdep.CurrentRow.Cells[1].Value.ToString();
            txt_pur_date.Text = this.dgvdep.CurrentRow.Cells[2].Value.ToString();
            txt_pur_cost.Text = this.dgvdep.CurrentRow.Cells[3].Value.ToString();
            txt_period.Text = this.dgvdep.CurrentRow.Cells[4].Value.ToString();

            calcdep();

            /*  if (lbl_per.Text == "")
              {
                  lbl_per.Text = ("please enter the period");
              }
              else
              {
                  lbl_per.Text = "";
              }   */

        }

        public void calcdep()
        {
            float pur_cost =(float)Convert.ToDouble(txt_pur_cost.Text);
            int perid = Convert.ToInt32(txt_period.Text);

            
            float ann_dep = (pur_cost * 20) / 100;

            float mon_dep = ann_dep / 12;

            float period = perid * 12;

            lbl_anual.Text = "Rs"+" "+(Convert.ToString(ann_dep));

            lbl_month.Text =  "Rs"+" "+(Convert.ToString(mon_dep));

            lbl_period.Text = (Convert.ToString(period)+" "+"Months");


        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            if (txt_pur_cost.Text == "")
            {
                MessageBox.Show("please select a machine to calculate the depriciation");

            }
            else if (txt_period.Text == "")
            {
                MessageBox.Show("please enter a period of depriciation");
            }
            else
            {
                calcdep();
            }
        }

        private void txt_period_TextChanged(object sender, EventArgs e)
        {
          /*  if (txt_period.Text == "")
            {
                lbl_per.Text = "";
            }
            else if (txt_period.Text.Any(char.IsDigit))
            {
                lbl_per.Text = "correct period";
            }
            else
            {
                lbl_per.Text = "incorrect period";
            }*/
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            lbl_period.Text = null;
            lbl_anual.Text = null;
            txt_machine_id.Text = null;
            lbl_month.Text = null;
            txt_period.Text = null;
            txt_pur_cost.Text = null;
            txt_pur_date.Text = null;
            txt_type.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();
            back.Visible = true;
            this.Visible = false;
        }
    }
}
