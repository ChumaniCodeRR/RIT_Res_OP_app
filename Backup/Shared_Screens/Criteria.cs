using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Criteria
{
    public partial class Criteria : Form
    {
        public Reports_Disc.Reports mainForm;
        string action;
        string stu;
        string regstat = "";

        public Criteria(Reports_Disc.Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        //Created By: Mbongo Mpongwna
        //Date Created: 2011-Aug-10
        //Reason: Created a new constructor that takes in action and student number - to be called from menu item click
        public Criteria(string action, string stu)
        {
            InitializeComponent();

            this.action = action;
            this.stu = stu;
        }

        private void Criteria_Load(object sender, EventArgs e)
        {
            try
            {
                rb_registered.Checked = true;

                cb_report.Items.Add(new Item("Sanction Report- Summary", "1"));
                cb_report.Items.Add(new Item("Detailed Sanctions by Offence Category", "3"));
                cb_report.Items.Add(new Item("Headcount by Category", "2"));
                cb_report.Items.Add(new Item("Out of Range Penalties", "4"));
                cb_report.SelectedIndex = 0;

                cb_status.Items.Add(new Item("All Sanctions", "A"));
                cb_status.Items.Add(new Item("Completed Sanctions Only", "C"));
                cb_status.Items.Add(new Item("Incomplete Sanctions Only", "I"));
                cb_status.Items.Add(new Item("Outstanding Sanctions - Past Due Date", "O"));
                cb_status.SelectedIndex = 0;

                string tempstr = Proxy.System.Get_Sleeping_Halls();

                string[] temparray = tempstr.Split(new char[] { '|' });
                cb_hall.Enabled = false;

                cb_hall.Items.Add(new Item("Any Hall", "*"));
                for (int intArray = 0; intArray < temparray.Length; intArray++)
                {
                    cb_hall.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                    intArray = intArray + 1;
                }

                cb_hall.SelectedIndex = 0;
                cb_hall.Enabled = true;

                cbres.Items.Add(new Item("Any Residence", "*"));
                cbres.SelectedIndex = 0;

                int x = 0;
                cb_badcode.Items.Add(new Item("All Categories", "*"));
                foreach (DataRow row in Global.Global.ds_rescodes.TT_BADCODES.Rows)
                {
                    cb_badcode.Items.Add(new Item(Global.Global.ds_rescodes.TT_BADCODES[x]["descrip"].ToString(), Global.Global.ds_rescodes.TT_BADCODES[x]["bad_category"].ToString()));
                    x++;
                }
                cb_badcode.SelectedIndex = 0;

                dt_start.Value = new DateTime(DateTime.Today.Year - 1, DateTime.Today.Month, DateTime.Today.Day);



                DataView dv_hearing = new DataView(Global.Global.ds_badcodes.tt_genbad);
                dv_hearing.RowFilter = "type = 'DH'";

                x = 0;
                cb_hearing.Items.Add(new Item("All Hearings", "*"));
                foreach (DataRowView row in dv_hearing)
                {
                    cb_hearing.Items.Add(new Item(dv_hearing[x]["descrip"].ToString(), dv_hearing[x]["code"].ToString()));
                    x++;
                }
                cb_hearing.SelectedIndex = 0;

                DataView dv_authority = new DataView(Global.Global.ds_badcodes.tt_genbad);
                dv_authority.RowFilter = "type = 'DA'";

                x = 0;
                cb_authority.Items.Add(new Item("All Authorities", "*"));
                foreach (DataRowView row in dv_authority)
                {
                    cb_authority.Items.Add(new Item(dv_authority[x]["descrip"].ToString(), dv_authority[x]["code"].ToString()));
                    x++;
                }
                cb_authority.SelectedIndex = 0;

                x = 0;
                DataView dv_disc_from = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dv_disc_from.RowFilter = "type = 'DA_FROM'";
                cb_authorityfrom.Items.Add(new Item("All Locations", "*"));
                foreach (DataRowView row in dv_disc_from)
                {
                    cb_authorityfrom.Items.Add(new Item(dv_disc_from[x]["descrip"].ToString(), dv_disc_from[x]["code"].ToString()));
                    x++;
                }
                cb_authorityfrom.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.SharedReportCriteria, ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm = new Reports_Disc.Reports(action, stu);

                if (rb_registered.Checked == true) regstat = "Registered";
                else regstat = "All";

                NS_Discipline.StrongTypesNS.DS_REPORTDataSet DS_Report;
                DS_Report = Proxy.StudentDiscipline.Report_Criteria( regstat,((Item)cb_report.SelectedItem).Value.ToString(), ((Item)cbres.SelectedItem).Value.ToString(),
                    ((Item)cb_hall.SelectedItem).Value.ToString(), dt_start.Value, dt_end.Value, ((Item)cb_status.SelectedItem).Value.ToString(),
                    ((Item)cb_badcode.SelectedItem).Value.ToString(), txt_keywords.Text, ((Item)cb_hearing.SelectedItem).Value.ToString(),
                    ((Item)cb_authority.SelectedItem).Value.ToString(), txt_sdc.Text, txt_aog.Text, ((Item)cb_authorityfrom.SelectedItem).Value.ToString());

                if (((Item)cb_report.SelectedItem).Value.ToString() == "1")
                {
                    mainForm.rds.Name = "DS_REPORTDataSet_TT_STUBAD_COPY";
                    mainForm.rds.Value = DS_Report.TT_STUBAD_COPY;
                    mainForm.reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Disc_Summary.rdlc";
                }

                if (((Item)cb_report.SelectedItem).Value.ToString() == "2")
                {
                    mainForm.rds.Name = "DS_REPORTDataSet_TT_DEMO";
                    mainForm.rds.Value = DS_Report.TT_DEMO;
                    mainForm.reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Disc_Demographics.rdlc";
                }

                if (((Item)cb_report.SelectedItem).Value.ToString() == "3")
                {
                    mainForm.rds.Name = "DS_REPORTDataSet_TT_STUBAD_COPY";
                    mainForm.rds.Value = DS_Report.TT_STUBAD_COPY;
                    mainForm.reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Disc_Category.rdlc";
                }

                if (((Item)cb_report.SelectedItem).Value.ToString() == "4")
                {
                    mainForm.rds.Name = "DS_REPORTDataSet_TT_FINEFILE";
                    mainForm.rds.Value = DS_Report.TT_FINEFILE;
                    mainForm.reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Disc_Range.rdlc";
                }

                mainForm.p[0] = new Microsoft.Reporting.WinForms.ReportParameter("title", ((Item)cb_report.SelectedItem).Name.ToString());

                string temparea = ((Item)cb_hall.SelectedItem).Name.ToString();
                if (((Item)cbres.SelectedItem).Value.ToString() != "*") temparea = ((Item)cbres.SelectedItem).Name.ToString();
                mainForm.p[1] = new Microsoft.Reporting.WinForms.ReportParameter("area", temparea);
                mainForm.p[2] = new Microsoft.Reporting.WinForms.ReportParameter("daterange", dt_start.Value.ToShortDateString() + " till the " + dt_end.Value.ToShortDateString());
                mainForm.p[3] = new Microsoft.Reporting.WinForms.ReportParameter("status", ((Item)cb_status.SelectedItem).Name);
                mainForm.p[4] = new Microsoft.Reporting.WinForms.ReportParameter("offence_cat", ((Item)cb_badcode.SelectedItem).Name);
                mainForm.p[5] = new Microsoft.Reporting.WinForms.ReportParameter("keywords", txt_keywords.Text);
                mainForm.p[6] = new Microsoft.Reporting.WinForms.ReportParameter("hearing", ((Item)cb_hearing.SelectedItem).Name);
                mainForm.p[7] = new Microsoft.Reporting.WinForms.ReportParameter("authority", ((Item)cb_authority.SelectedItem).Name);
                mainForm.p[8] = new Microsoft.Reporting.WinForms.ReportParameter("sdc", txt_sdc.Text);
                mainForm.p[9] = new Microsoft.Reporting.WinForms.ReportParameter("aog", txt_aog.Text);
                mainForm.p[10] = new Microsoft.Reporting.WinForms.ReportParameter("disc_from", ((Item)cb_authorityfrom.SelectedItem).Name);

                mainForm.Show();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.SharedReportCriteria, ex);
            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_hall.Enabled == true)
                {
                    cbres.Items.Clear();
                    cbres.Enabled = false;
                    cbres.Items.Add(new Item("ANY RESIDENCE", "*"));

                    if (((Item)cb_hall.SelectedItem).Value.ToString() != "*")
                    {
                        string tempstr = Proxy.System.Get_Residences(((Item)cb_hall.SelectedItem).Value.ToString());
                        string[] residence = tempstr.Split(new char[] { '|' });

                        for (int intArray = 0; intArray < residence.Length; intArray++)
                        {
                            cbres.Items.Add(new Item(residence[intArray + 1], residence[intArray]));
                            intArray = intArray + 1;
                        }
                    }
                    cbres.SelectedIndex = 0;
                    if (((Item)cb_hall.SelectedItem).Value.ToString() != "*") cbres.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.SharedReportCriteria, ex);
            }
        }

        private void txt_sdc_MouseClick(object sender, MouseEventArgs e)
        {
            Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp("SDC");
            frmCodes.ShowDialog();
            txt_sdc.Text = frmCodes.Code;            
        }

        private void txt_aog_MouseClick(object sender, MouseEventArgs e)
        {
            string tempstr = "AOG";
            if (Global.Global.type == "LA") tempstr = "LAG";
            Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp(tempstr);
            frmCodes.ShowDialog();
            txt_aog.Text = frmCodes.Code; 
        }

        private void cb_report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
               
        
    }
}
