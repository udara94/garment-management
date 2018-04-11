using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    class validation
    {
        public void valid_numbers(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter only Numbers");
            }
        }

        public void valid_letters(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar ==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Enter only letters");
            }
        }



    }
}
