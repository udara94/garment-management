using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication2
{
    public partial class InvoiceView : Form
    {
        DBAccess2 dba = new DBAccess2();

        public InvoiceView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (comboBox1.Text != "")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\2.Invoice.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = comboBox1.Text;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["OrderID"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            else
                MessageBox.Show("Please Enter value");

            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }


        public void GetOrderID()
        {
            DataTable dt = dba.getOrderID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        public void GetRetailID()
        {
            DataTable dt = dba.getRetailID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            label1.Visible = true;
            comboBox1.Visible = true;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            label2.Visible = true;
            comboBox2.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //if (comboBox2.Text != "")
            //{
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\2.RetailInvoice.rpt");

                /*ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = comboBox2.Text;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["RetailID"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);*/

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
           // }
          //  else
            //    MessageBox.Show("Please Enter value");



            label2.Visible = false;
            comboBox2.Visible = false;
            button4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            GetOrderID();
            GetRetailID();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            frm2.Visible = true;
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
