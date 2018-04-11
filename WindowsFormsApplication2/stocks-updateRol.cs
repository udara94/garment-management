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
    public partial class stocks_updateRol : Form
    {
        DBAccess1 dba = new DBAccess1();
        public stocks_updateRol()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            this.Dispose();
            st.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Dispose();
            home.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rawId = Convert.ToInt32(label6.Text);
            double rol = Convert.ToDouble(textBox1.Text);
            double roq = Convert.ToDouble(textBox2.Text);
            if (dba.UpdateRol(rawId,rol,roq))
            {
                MessageBox.Show("Opwerations are committed successfully");
            }
            else
            {
                MessageBox.Show("Updation Unsuccessfull");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.IndexOf('.') != textBox1.Text.LastIndexOf('.'))
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;

            } 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text.IndexOf('.') != textBox2.Text.LastIndexOf('.'))
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox validation process
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }
    }
}
