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
    public partial class SalesReturnHis : Form
    {
        DBAccess9 dba = new DBAccess9();
        Form9 f9 = new Form9();

    
        public SalesReturnHis()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dba.addReturnHis(teRetailID.Text, textDes.Text, textReallocate.Text, textLoss.Text))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            teRetailID.Clear();
            textDes.Clear();
            textReallocate.Clear();
            textLoss.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dba.UpdateReturnHis(teRetailID.Text, textDes.Text, textReallocate.Text,textLoss.Text))
            {
                MessageBox.Show("Successfully Updated");
                this.Dispose();
                f9.Show();
                f9.FillReturn();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teRetailID.Clear();
            textDes.Clear();
            textReallocate.Clear();
            textLoss.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 load = new Form1();
            load.Visible = true;
            this.Visible = false;
        }
    }
    }

