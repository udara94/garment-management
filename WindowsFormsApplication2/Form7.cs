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
    public partial class Form7 : Form
    {
        DBAccess7 dba = new DBAccess7();
        
        
        public Form7()
        {
            InitializeComponent();
            dataGridView1.Refresh();

        }
        DataSet ds=new DataSet();
      
        

        private void button6_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;

            label2.Text = ("Machine Details");

            FillGrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {


            // FillGrid();
           
            

        }
        public void FillGrid()
        {

            

                DataTable dt2 = dba.getmachine();
                dataGridView1.DataSource = dt2.DefaultView;
            
           
        }
        public void fill_machine_servises()
        {
            DataTable dt2 = dba.getservice();
            dataGridView1.DataSource = dt2.DefaultView;

            // DataSet ds = dba.getservice();
            // dataGridView1.DataSource = ds.Tables["MachineServices"].DefaultView;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = false;

            label2.Text = ("Machine Repaire History");


            DataTable dt2 = dba.getrepaire();
            dataGridView1.DataSource = dt2.DefaultView;
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;

            label2.Text = ("Machine Parts Details");
            
            DataTable dt3 = dba.getparts();
            dataGridView1.DataSource = dt3.DefaultView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;

            label2.Text = ("Service Time Details");
         
            fill_machine_servises();
            //DataSet ds = dba.getservice();
            // dataGridView1.DataSource = ds.Tables["MachineServices"].DefaultView;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //search the row by entering words
        {
            if (dataGridView1.Columns[0].HeaderText == "MachineID")
            {
                DataView dv = new DataView(dba.getmachine());
                dv.RowFilter = string.Format("MachineID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;
            }
            else if (dataGridView1.Columns[0].HeaderText == "PartID")
            {
                DataView dv1 = new DataView(dba.getparts());
                dv1.RowFilter = string.Format("PartID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv1;
            }
            else if (dataGridView1.Columns[0].HeaderText == "ServiceNO")
            {
                DataView dv3 = new DataView(dba.getservice());
                dv3.RowFilter = string.Format(" ServiceNO LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv3;
            }
             else if(dataGridView1.Columns[0].HeaderText== "RepaireNO"&& dataGridView1.Columns[1].HeaderText == "MachineID")
            {
                DataView dv3 = new DataView(dba.getrepaire());
                dv3.RowFilter = string.Format(" RepaireNO LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv3;

            }



        }

        private void button9_Click(object sender, EventArgs e) //go to diferent form from the same button considering the heder text 
        {
            btn_demo btn = new btn_demo();

            if (dataGridView1.ColumnCount <= 0)
            {
                MessageBox.Show("please select the table");
            }

           else if (dataGridView1.Columns[0].HeaderText == "MachineID")
            {
                btn_demo add = new btn_demo();
                

                add.Visible = true;
                //this.Visible = false;


                add.btnadd.Visible = true;
                add.btnupdate.Visible = false;
            }
            else if(dataGridView1.Columns[0].HeaderText == "PartID")
            {
                parts add = new parts();
                add.Visible = true;
                this.Visible = false;

                add.btnpart_add.Visible = true;
                add.btnpart_update.Visible = false;
            }
            else if(dataGridView1.Columns[0].HeaderText == "ServiceNO")
            {
                service add = new service();
                add.Visible = true;
                this.Visible = false;

                add.btnADD.Visible = true;
                add.btnupdate.Visible = false;

            }
            else if (dataGridView1.Columns[0].HeaderText == "RepaireNO")
            {
                Repaire add = new Repaire();
                add.Visible = true;
                this.Visible = false;

                
            }


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e) //set datagrid values to a different type of forms
        {
            if (dataGridView1.ColumnCount <= 0)
            {
                MessageBox.Show("please select the table");
            }

           else if (dataGridView1.Columns[0].HeaderText == "MachineID")
            {

             
               
                btn_demo add = new btn_demo();

                add.btnadd.Visible = false;
                add.btnupdate.Visible = true;

                add.lbl_mach_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                add.cmbtype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();       
                add.txtinstall_date.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                add.txtser_date.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                add.txtpur_price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                add.cmbpurcom.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                add.txt_estlife.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();



                add.ShowDialog();

               
            }
            else if(dataGridView1.Columns[0].HeaderText == "PartID")
            {
                parts add = new parts();

                add.btnpart_add.Visible = false;
                add.btnpart_update.Visible = true;

                add.lbl_part_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
                add.cmbtype.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                add.txtpur_price.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                add.txtqty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                add.txtins_date.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                add.cmbpurcom.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                add.ShowDialog();


            }
            else if(dataGridView1.Columns[0].HeaderText == "ServiceNO")
            {
                service up = new service();

                up.btnADD.Visible = false;
                up.btnupdate.Visible = true;

                up.lbl_service_no.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                up.txtmach_no.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                up.txtser_date.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                up.txtser_per.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                up.txtser_cost.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                up.cmbstation.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                up.ShowDialog();

            }
        }

      

        private void button10_Click(object sender, EventArgs e)     //delete record from the datagridview
        {
            if (dataGridView1.ColumnCount <= 0)
            {
                MessageBox.Show("please select the table");
            }

           else if (dataGridView1.Columns[0].HeaderText == "MachineID")
            {
                if (dataGridView1.CurrentCell.RowIndex < 0 || dataGridView1.CurrentCell.ColumnIndex != dataGridView1.Columns[0].Index)
                    return;
                else
                {
                    if (MessageBox.Show("Delete selected Record?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        

                        string mashine = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                       

                        if (dba.deletemachine(mashine))
                        {
                            MessageBox.Show("Successfully Deleted");
                           
                            FillGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }
                }

            }
            else if (dataGridView1.Columns[0].HeaderText == "PartID")
            {

                if (dataGridView1.CurrentCell.RowIndex < 0 || dataGridView1.CurrentCell.ColumnIndex != dataGridView1.Columns[0].Index)
                    return;
                else
                {
                    if (MessageBox.Show("Delete selected Record?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        

                        string part = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        

                        if (dba.deleteparts(part))
                        {
                            MessageBox.Show("Successfully Deleted");

                            DataTable dt2 = dba.getparts();
                            dataGridView1.DataSource = dt2.DefaultView;
                            // DataSet ds = dba.getparts();
                            // dataGridView1.DataSource = ds.Tables["Part"].DefaultView;

                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }
                }

            }
            else if (dataGridView1.Columns[0].HeaderText == "ServiceNO")
            {

                if (dataGridView1.CurrentCell.RowIndex < 0 || dataGridView1.CurrentCell.ColumnIndex != dataGridView1.Columns[0].Index)
                    return;
                else
                {
                    if (MessageBox.Show("Delete selected Record?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {


                        string service = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


                        if (dba.deleteservice(service))
                        {
                            MessageBox.Show("Successfully Deleted");

                            DataTable dt2 = dba.getservice();
                            dataGridView1.DataSource = dt2.DefaultView;
                            // DataSet ds = dba.getservice();
                            // dataGridView1.DataSource = ds.Tables["MachineServices"].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }
                }

            }
            else if (dataGridView1.Columns[0].HeaderText == "RepaireNO")
            {

                if (dataGridView1.CurrentCell.RowIndex < 0 || dataGridView1.CurrentCell.ColumnIndex != dataGridView1.Columns[0].Index)
                    return;
                else
                {
                    if (MessageBox.Show("Delete selected Record?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {


                        string rep = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


                        if (dba.deleterepaire(rep))
                        {
                            MessageBox.Show("Successfully Deleted");

                            DataTable dt2 = dba.getrepaire();
                            dataGridView1.DataSource = dt2.DefaultView;
                            // DataSet ds = dba.getservice();
                            // dataGridView1.DataSource = ds.Tables["MachineServices"].DefaultView;
                        }
                        else
                        {
                            MessageBox.Show("Error occured while deleting");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }
                }

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)// go to the home menu
        {
            Form1 home = new Form1();
            home.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;

            label2.Text = ("Parts Purchase History");

            DataSet ds = dba.getpartshistory();
            dataGridView1.DataSource = ds.Tables["Part"].DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            depriciation dep = new depriciation();
            dep.Visible = true;
            this.Visible = false;

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cost ud = new cost();
            ud.Visible = true;
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            crystal ud = new crystal();
            ud.Visible = true;
        }
    }
}
