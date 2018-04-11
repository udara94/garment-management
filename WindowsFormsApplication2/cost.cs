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
    public partial class cost : Form
    {
        public cost()
        {
            InitializeComponent();
        }
        DBAccess7 dba = new DBAccess7();
        private void cost_Load(object sender, EventArgs e)
        {
            //calctotal();
            //dataGridView1.Visible = false;
            DataTable dt2 = dba.getcost();
            dataGridView1.DataSource = dt2.DefaultView;
            string x= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbl_cost.Text = ( "Rs"+" "+x );
        }
      /*  public void calctotal()
        {
            
            string con = "Data Source=UD-PC;Initial Catalog=main;Integrated Security=True";
             string query = "select sum(RepaireCost) from dbo.Repaire";
             SqlConnection condata = new SqlConnection(con);
             SqlCommand cmd = new SqlCommand(query, condata);
             SqlDataReader reader;
             try
             {
                 condata.Open();
                 reader = cmd.ExecuteReader();
                lbl_cost.Text = (reader).ToString();

             }catch(Exception ex)
             {

             }


        }*/

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form7 back = new Form7();   
            this.Visible = false;
            back.Visible = true;
        }



        


        private void cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cmb_month.SelectedItem )== " ")
            {
                MessageBox.Show("Please select month and the year");
            }
            else
            {
                dba.getmothlycost(Convert.ToString(cmb_month.SelectedItem), Convert.ToInt32(cmb_year.SelectedItem));

                label1.Text = "Rs "+" "+(Convert.ToString(dba.getmothlycost(Convert.ToString(cmb_month.SelectedItem), Convert.ToInt32(cmb_year.SelectedItem)))) ;
            }
        }

        private void cmb_annual_SelectedIndexChanged(object sender, EventArgs e)
        {
            dba.getannualcost(Convert.ToInt32(cmb_annual.SelectedItem));

            lbl_ann.Text = "Rs "+" "+( Convert.ToString(dba.getannualcost(Convert.ToInt32(cmb_annual.SelectedItem))));
        }
    }
}
