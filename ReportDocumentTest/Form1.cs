using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace ReportDocumentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            crystalReportViewer1.ReportSource = covidReport1;

        }
    }
}
