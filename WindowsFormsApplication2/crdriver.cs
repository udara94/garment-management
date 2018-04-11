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
    public partial class crdriver : Form
    {
        public crdriver()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("E:\\D - Drive Things\\SLIIT Resorses\\ITP\\ITP project\\WindowsFormsApplication2Ramee\\WindowsFormsApplication2\\DriverData.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\DriverData.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\Vehicle Data.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\Transpotation.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
