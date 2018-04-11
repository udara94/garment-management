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
    public partial class stocks_Reports : Form
    {
        public stocks_Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\stocks-RawDamage.rpt");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\stocks-ProductDamage.rpt");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Udara Indrajith\\Documents\\2nd year\\2nd semester\\ITP\\Project\\backup\\6\\WindowsFormsApplication2\\WindowsFormsApplication2\\stocks-SupplierPayment.rpt");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
