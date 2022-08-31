using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;


namespace Reports_Medical
{
    public partial class Reports : Form
    {
        public string action;
        public DateTime tempdte1;
        public DateTime tempdte2;
        public bool proceed = true;
        public string tempstu;
        public string tempstr1;
        public string tempstr2;
        public bool tempbool;
        public int tempyr;
        public int showyr;
        public Microsoft.Reporting.WinForms.ReportParameter[] p;
        int parameters;
        public bool tempbuilding = true;
        
        public Reports(string dowhat, string stu)
        {
            InitializeComponent();
            action = dowhat;
            tempstu = stu;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet ds_reports = new NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet();

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 1;
                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
                if (Global.Global.rescode != 999) p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname + " - " + Global.Global.hallname);
                else p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);
                reportViewer1.LocalReport.DataSources.Clear();

                if (action == "Med_Aid" & tempstu == "*")
                {
                    proceed = false;
                    Medical_Request_First_Years_Only.firstyrsonly fnform = new Medical_Request_First_Years_Only.firstyrsonly(this);
                    fnform.ShowDialog();
                }

                if (proceed == true)
                {

                    ds_reports = Proxy.Res_System.Generic_Res_Report(tempstu, Global.Global.rescode, "*", tempbuilding, action);

                    if (action == "Med_Aid")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_MED_AID";
                        rds.Value = ds_reports.TT_MED_AID;
                        reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Med_Aid_Info.rdlc";
                    }

                    rds1.Name = "DS_PHOTODataSet_TT_PHOTO";
                    rds1.Value = Global.Global.ds_logo.TT_PHOTO;

                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.DataSources.Add(rds1);
                    reportViewer1.LocalReport.EnableExternalImages = true;
                    this.reportViewer1.LocalReport.SetParameters(p);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.MedicalReport, ex);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
