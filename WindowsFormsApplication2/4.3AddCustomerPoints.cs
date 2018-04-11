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
    public partial class AddCusPoint : Form
    {
        DBAccess4 dba = new DBAccess4();
        Form4 f4 = new Form4();

        public AddCusPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.Visible = true;
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddCusPoint_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentpointlabel.Text == "")
                 {
                    currentpointlabel.Text = "0";
                 }
            else {
                double cp = Convert.ToDouble(currentpointlabel.Text);
                double newp = cp + 1;
                string Newp = Convert.ToString(newp);
                newpointlabel.Text = Newp;
                 }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentpointlabel.Text == "")
            {
                currentpointlabel.Text = "0";
            }
            else
            {
                double cp = Convert.ToDouble(currentpointlabel.Text);
                double newp = cp - 1;
                string Newp = Convert.ToString(newp);
                newpointlabel.Text = Newp;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string cid = dba.selectvalues(ortextBox.Text);
            cidlabel.Text = cid;
            string fpay = dba.selectpay(ortextBox.Text);
            tpaylabel.Text = fpay;
            //string adv = dba.selectadvance(ortextBox.Text);
            //advalabel.Text = adv;
            string arr = dba.selectarrear(ortextBox.Text);
            labelArear.Text = arr;
            string rd = dba.selectrental(ortextBox.Text);
            donedatelabel.Text = rd;
            string fd = dba.selectfullPDone(ortextBox.Text);
            paydonelabel.Text = fd;
            string rp = dba.selectrate(ortextBox.Text);
            currentpointlabel.Text = rp;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dba.updatepoint(newpointlabel.Text, ortextBox.Text))
            {
                MessageBox.Show("Successfully Updated ");
                Form4 f4 = new Form4();
                this.Visible = false;
                f4.Visible = true;

                f4.FillGridh();

            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Dispose();
            f4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
