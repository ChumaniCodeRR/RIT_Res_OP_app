using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using Utilities;

namespace Res_System.ReportForm
{
    public partial class ContactReport : Form
    {
        public string action;
        public string resname;

        public DataView dv_housecomm;
        public int tempyr;

        public Microsoft.Reporting.WinForms.ReportParameter[] p;
        int parameters;



        public ContactReport(string _action)
        {
            InitializeComponent();
            action = _action;
        }


        public ContactReport(string _action, DataView dv_housecomm, int tempyr)
        {
            InitializeComponent();
            action = _action;
            this.dv_housecomm = dv_housecomm;
            this.tempyr = tempyr;
        }


        private void ContactReport_Load(object sender, EventArgs e)
        {
            try
            {
                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;
                if (rootNamespace == "DMU") rootNamespace = "ITS";

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 0;

                if (action == "HOUSECOMM_LIST") parameters = 2;


                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
                reportViewer1.LocalReport.DataSources.Clear();

                if (action == "WardensDirectory")
                {
                    NS_ResSystem.StrongTypesNS.DS_GENDataSet DS_Directory = Proxy.Res_System.Get_Staff_Contact_Info("*");

                    rds.Name = "DS_Directory";
                    rds.Value = DS_Directory.TT_CONTACT;
                    reportViewer1.LocalReport.ReportEmbeddedResource =  string.Concat(rootNamespace, ".Reports.ContactInfo.Phone_Directory.rdlc");                   
                }



                if (action == "HOUSECOMM_LIST")
                {
                    rds.Name = "DS_REPORTSDataSet_TT_HOUSECOM";
                    rds.Value = this.dv_housecomm;
                    reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Updates.HousecommList.rdlc");
                    p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname);  
                    p[1] = new Microsoft.Reporting.WinForms.ReportParameter("TempYear", this.tempyr.ToString());
                }


                rds1.Name = "DS_PHOTODataSet_TT_PHOTO";
                rds1.Value = Global.Global.ds_logo.TT_PHOTO;


                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.DataSources.Add(rds1);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
    }
}
