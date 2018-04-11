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
    public partial class order_details : Form
    {
        DBAccess dba = new DBAccess();

        Form3 f3 = new Form3();

        public order_details()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void o_add_button_Click(object sender, EventArgs e)
        {
            if (dba.upd_orders(order_id_label.Text, Convert.ToString(order_status_com.SelectedItem),Convert.ToString(dateTimePicker1.Value.Date)))
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            this.Dispose();

            //f3.Show();
            f3.Show();
            f3.FillGrid3();
        }

        private void o_back_button_Click(object sender, EventArgs e)
        {
           f3.Visible = true;
            f3.FillGrid3();
            this.Dispose();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*if (order_duedate_label.Text < Convert.ToString(dateTimePicker1))
            {

            }*/
        }

        private void order_duedate_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}
