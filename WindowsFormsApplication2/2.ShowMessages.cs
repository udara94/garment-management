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
    public partial class ShowMessages : Form
    {
        DBAccessSession dba = new DBAccessSession();

        private static string _uname;
        public ShowMessages()
        {
            InitializeComponent();
        }

        private void _2_Load(object sender, EventArgs e)
        {
            FillMsgs();

        }


        public void FillMsgs()
        {
            _uname = Login.logininfo.userID;
            DataTable dt = dba.ReceiveMsg(_uname);
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label5.Text=this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label4.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
