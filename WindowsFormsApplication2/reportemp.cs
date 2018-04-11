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
    public partial class reportemp : Form
    {
        public reportemp()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load("C:\\Users\\Mashitha\\Desktop\\pavan\\12-09-2016 11.41AM\\WindowsFormsApplication2\\WindowsFormsApplication2\\empreport.rpt");
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
