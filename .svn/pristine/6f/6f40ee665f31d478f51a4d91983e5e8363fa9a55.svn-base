using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Microsoft.Reporting.WinForms;
using System.IO;


namespace Res_System
{
    public partial class FunctionReports : Form
    {
        DataView dvReport;

        public string action;    
        public Microsoft.Reporting.WinForms.ReportParameter[] p;
        int parameters;
    
        string FunDescrip;
        DateTime FunDate;
        String FunTime;
        DateTime FunReplyBy;
        String FunMeals;
        string DefaultAttending;
        public string tempstu;
        public bool tempbuilding = true;
        public bool proceed = true;

        public FunctionReports(string dowhat, DataView _dv_report)
        {
            InitializeComponent();
            action = dowhat;
            dvReport = _dv_report;
           
        }


        public FunctionReports(string dowhat, string tempstu)
        {
            InitializeComponent();
            action = dowhat;
            this.tempstu = tempstu;
        }

        public FunctionReports(string dowhat, int tempfolio, string FunDescrip, DateTime FunDate, String FunTime, DateTime FunReplyBy, String FunMeals,string DefaultAttending)
        {
            InitializeComponent();
            action = dowhat;
            Global.Global.rescode = tempfolio;
            this.FunDescrip = FunDescrip;
            this.FunDate = FunDate;
            this.FunTime = FunTime;
            this.FunReplyBy = FunReplyBy;
            this.FunMeals = FunMeals;
            this.DefaultAttending = DefaultAttending;
            tempstu = "*";
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {

                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;
                if (rootNamespace == "InterDeptOrder") rootNamespace = "Finance";
                if (rootNamespace == "ResOps") rootNamespace = "IOPS";

                NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet ds_reports = new NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet();
               

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 1;
               
                if (action == "FunctionRegister") parameters = 5;

                 p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
                 if (Global.Global.rescode != 999) p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname + " - " + Global.Global.hallname);
                 else p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);
              
                reportViewer1.LocalReport.DataSources.Clear();

                 if (action == "FunctionRegister")
                 {
                   
                       p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Function_Details", "Function: " + this.FunDescrip + " on the " + this.FunDate.ToLongDateString() + " over " + this.FunTime.ToString() + " Time");
                       p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Function_Instruction", "This list will be removed on the " + this.FunReplyBy.ToLongDateString());
                       p[3] = new Microsoft.Reporting.WinForms.ReportParameter("bookings", this.FunMeals);
                       p[4] = new Microsoft.Reporting.WinForms.ReportParameter("DefaultAttending", this.DefaultAttending);
                       tempbuilding = true;
                       proceed = true;
                   

                }

                if (proceed == true)
                {

                    if ( action == "FunctionRegister")
                    {
                        ds_reports = Proxy.Res_System.Generic_Res_Report(tempstu, Global.Global.rescode, Global.Global.hallcode, tempbuilding, action);
                        rds.Name = "DS_REPORTSDataSet_TT_STU_DIET";
                        rds.Value = ds_reports.TT_STU_DIET;
                       
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.Functions.rdlc");
                    }

                    if (action == "ResVac")
                    {

                        rds.Name = "ds_reports";
                        rds.Value = dvReport;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Updates.ResVac.rdlc");
                        p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname);

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
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
    }
}
