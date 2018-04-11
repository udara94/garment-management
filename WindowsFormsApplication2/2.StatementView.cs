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
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class _2_Sheetcs : Form
    { 
        SqlConnection conn;
        public _2_Sheetcs()
        {
            conn = ConnectionManager.GetConnection();
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text != "" || comboBox1.Text != "")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\2.IncomeStatement.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();


                if (comboBox2.Text != "")
                {
                    crParameterDiscreteValue.Value = Convert.ToInt32(comboBox2.Text);
                    crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["Year"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    if (comboBox1.Text != "")
                    {
                        crParameterDiscreteValue.Value = Convert.ToInt32(comboBox1.Text);
                        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                        crParameterFieldDefinition = crParameterFieldDefinitions["Month"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;


                        crParameterValues.Clear();
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Please Select the month");
                    }

                }
                else
                {
                    MessageBox.Show("Please Select the Year");
                }
            }
            else
            {
                MessageBox.Show("Please Select the Year and Month");
                comboBox2.Text = "";
                comboBox1.Text = "";
            }





        }

        private void _2_Sheetcs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
    }
}
