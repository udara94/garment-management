using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class addleave : Form
    {
        DBAccessEmp dba = new DBAccessEmp();
        employees f8 = new employees();

        public addleave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg2 = new OpenFileDialog();
            dlg2.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg2.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg2.FileName.ToString();
                imgpath2.Text = picpath;
                pictureBox1.ImageLocation = picpath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imagebt2 = null;
            FileStream fstream = new FileStream(this.imgpath2.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt2 = br.ReadBytes((int)fstream.Length);

            if (dba.addleave(textBox2.Text, textBox3.Text, dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), imagebt2))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            f8.leaveing();
            this.Dispose();
            f8.Visible = true;

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f8.leaveing();
            this.Dispose();
            f8.Visible = true;

        }

        private void addleave_Load(object sender, EventArgs e)
        {
            DataTable dt = dba.selectidname();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            this.Dispose();
            emp.Visible = true;
        }
    }
}
