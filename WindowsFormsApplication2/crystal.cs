using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication2
{
    public partial class crystal : Form
    {
        public crystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load("D:\\SLIIT\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\machine.rpt");
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();
        }

        private void btn_part_Click(object sender, EventArgs e)
        {

            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load("D:\\SLIIT\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\partall.rpt");
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();

        }
        private void btn_service_Click(object sender, EventArgs e)
        {
            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load("D:\\SLIIT\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\serviceall.rpt");
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();

        }
        private void btn_repaire_Click(object sender, EventArgs e)
        {
            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load("D:\\SLIIT\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\repaireall.rpt");
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("D:\\SLIIT\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\part.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["part"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

     
    }
    
}
