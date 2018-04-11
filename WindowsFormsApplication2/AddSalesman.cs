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
    public partial class AddSalesman : Form
    {
        DBAccess9 dba = new DBAccess9();
        Form9 f9 = new Form9();
        public AddSalesman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Visible = true;
            this.Visible = false;
        }

        private void AddSalesmanBtn_Click(object sender, EventArgs e)
        {
            if (dba.addSalesman(txtEmpID.Text, textShops.Text, Convert.ToString(cmbRegion.SelectedItem)))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            txtEmpID.Clear();
            textShops.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

               if (dba.UpdateSalesman(txtEmpID.Text, textShops.Text, Convert.ToString(cmbRegion.SelectedItem)))
             {
                 MessageBox.Show("Successfully Updated");
                this.Dispose();
                f9.Show();
                f9.FillSalesman();
            }
            else
              {
            MessageBox.Show("Error occured");
             }
             }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Dispose();
            f1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Dispose();
            f9.Visible = true;
        }
    }
    }

