using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;


namespace Reports_Disc
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
        public Microsoft.Reporting.WinForms.ReportDataSource rds;
        int parameters;
        public bool tempbuilding = true;
                
        public Reports(string dowhat, string stu)
        {
            InitializeComponent();

            action = dowhat;
            tempstu = stu;

            InitializeVariables();
        }

        private void InitializeVariables()
        {
            rds = new Microsoft.Reporting.WinForms.ReportDataSource();

            parameters = 1;
            if (action == "Custom") parameters = 11;
            p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
            reportViewer1.LocalReport.DataSources.Clear();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                NS_Discipline.StrongTypesNS.DS_STUBADDataSet ds_bad = new NS_Discipline.StrongTypesNS.DS_STUBADDataSet();

                if (action == "VIEW_FINE_REF")
                {
                    StringBox.StringBox frmstring = new StringBox.StringBox(this, "Please enter a reference number:", "View Student Offence");
                    frmstring.ShowDialog();
                }
                if (action == "Summons" | action == "Fine" | action == "Record" | action == "VIEW_FINE_REF")
                    ds_bad = Proxy.StudentDiscipline.Get_Discipline("", tempstu, out tempyr, out showyr);

                if (action == "VIEW_FINE_REF" | action == "VIEW_FINE_STU" | action == "Summons" | action == "Fine" | action == "Record")
                {
                    if (ds_bad.tt_stubad.Rows.Count > 0)
                    {
                        proceed = true;
                        p[0] = new Microsoft.Reporting.WinForms.ReportParameter("title", "");

                        rds.Name = "DS_STUBADDataSet_tt_stubad";
                        rds.Value = ds_bad.tt_stubad;
                        if (action == "Summons") reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Summons.rdlc";
                        if (action == "Fine" | action == "VIEW_FINE_REF") reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.NOP.rdlc";
                        if (action == "Record") reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.CompServiceRecord.rdlc";
                    }
                    else
                    {
                        proceed = false;
                        MessageBox.Show("No fine was found that matches your search criteria", "Student Discipline", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (proceed == true)
                {
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.EnableExternalImages = true;
                    this.reportViewer1.LocalReport.SetParameters(p);
                    reportViewer1.RefreshReport();

                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineReports, ex);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
