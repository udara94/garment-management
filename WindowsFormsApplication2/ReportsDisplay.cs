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


namespace WindowsFormsApplication2
{
    public partial class ReportsDisplay : Form
    {
        public ReportsDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\SalesDetails.rpt");

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\viesales.rpt");

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\7\\WindowsFormsApplication2\\WindowsFormsApplication2\\SalesDetails.rpt");

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
