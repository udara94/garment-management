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
using System.Drawing.Imaging;

namespace WindowsFormsApplication2
{
    public partial class view_employee : Form
    {
        //employees f8 = new employees();
        public view_employee()
        {
            InitializeComponent();
        }

        private void view_employee_Load(object sender, EventArgs e)
        {
            string barcord = label11.Text;
            Bitmap bitmap = new Bitmap(barcord.Length * 40, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font fo = new System.Drawing.Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcord + "*", fo, black, point);

            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBox2.Image = bitmap;
                pictureBox2.Height = bitmap.Height;
                pictureBox2.Width = bitmap.Width;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employees f8 = new employees();
            f8.Visible = true;

        }
    }
}
