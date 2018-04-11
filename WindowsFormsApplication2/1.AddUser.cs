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
    public partial class AddUser : Form
    {
        DBAccessSession dba = new DBAccessSession();

        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                if (dba.AdminAddUser(textBox1.Text, textBox2.Text, comboBox1.Text))
                {
                    MessageBox.Show("Successfully Added");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.SelectedIndex=0;

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            fillUser();
            comboBox1.SelectedIndex = 0;

        }


        public void fillUser()
        {
            DataTable dt = dba.AdminLoadUserDetails();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (id != null)
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    // confirm delete
                    if (dba.AdminDeleteUser(id))
                    {
                        MessageBox.Show("Successfully Deleted");
                        fillUser();
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting");
                    }

                }
                else
                {
                    //No delete
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (textBox1.Text == "" || textBox2.Text == ""|| comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please put some values to Update");
            }
            else
            {
                if (dba.AdminupdateUsers(id,textBox1.Text,textBox2.Text, Convert.ToString(comboBox1.SelectedItem)))
                {
                    MessageBox.Show("Successfully Updated");
                    fillUser();
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

       

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Visible = false;
        }
    }
}
