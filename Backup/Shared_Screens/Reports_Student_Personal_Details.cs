using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Student_Personal_Details
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

                NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet ds_reports = new NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet();

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                int parameters = 1;
                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];

                p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);

                ds_reports = Proxy.StudentInfo.GetReportData(Global.Global.tempstu, Global.Global.rescode, "", true, action);
                rds.Name = "DS_REPORTSDataSet_TT_STU_INFO";
                rds.Value = ds_reports.TT_STU_INFO;
                
                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;
                reportViewer1.LocalReport.ReportEmbeddedResource = string.Format("{0}.Reports.Student_Information.rdlc", rootNamespace);

                rds1.Name = "DS_PHOTODataSet_TT_PHOTO";
                rds1.Value = Global.Global.ds_logo.TT_PHOTO;

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.DataSources.Add(rds1);

                this.reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
    }
}
