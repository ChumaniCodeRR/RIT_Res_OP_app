using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Reports_Student_Results
{
    public partial class Reports : Form
    {
        private string tempstu;
        private string action;
        public Microsoft.Reporting.WinForms.ReportParameter[] p;

        public Reports()
        {
            InitializeComponent();
        }

        public Reports(string action, string studentNo)
        {
            InitializeComponent();
            this.action = action;
            this.tempstu = studentNo;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();

                NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet ds_results = new NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet();

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                int parameters = 1;
                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];

                p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);


                ds_results = Proxy.StudentResults.Single_Student(tempstu);
                rds.Name = "DS_RESULTSDataSet_TT_RESULTS";
                rds.Value = ds_results.TT_RESULTS;

                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;
                reportViewer1.LocalReport.ReportEmbeddedResource = string.Format("{0}.Reports.Results.rdlc", rootNamespace);

                rds1.Name = "DS_PHOTODataSet_TT_PHOTO";
                rds1.Value = Global.Global.ds_logo.TT_PHOTO;

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.DataSources.Add(rds1);

                this.reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Utils.HandleException("Student Results Report", ex);
            }
        }
    }
}
