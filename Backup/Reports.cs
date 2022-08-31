﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;


namespace Res_System
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
                NS_ResSystem.StrongTypesNS.DS_RESULTSDataSet ds_res_results = new NS_ResSystem.StrongTypesNS.DS_RESULTSDataSet();
                NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet ds_results = new NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet();
                NS_ResSystem.StrongTypesNS.DS_RANKINGDataSet ds_ranking = new NS_ResSystem.StrongTypesNS.DS_RANKINGDataSet();
                NS_ResSystem.StrongTypesNS.DS_PASSRATEDataSet ds_passrate = new NS_ResSystem.StrongTypesNS.DS_PASSRATEDataSet();
                NS_ResSystem.StrongTypesNS.DS_RES_GRAPHDataSet ds_respass = new NS_ResSystem.StrongTypesNS.DS_RES_GRAPHDataSet();
                NS_ResSystem.StrongTypesNS.DS_STUFILEDataSet ds_stufile = new NS_ResSystem.StrongTypesNS.DS_STUFILEDataSet();
                NS_ResSystem.StrongTypesNS.ds_stanleyaccessDataSet ds_stanley = new NS_ResSystem.StrongTypesNS.ds_stanleyaccessDataSet();
                NS_ResSystem.StrongTypesNS.ds_resfileDataSet ds_exceptions = new NS_ResSystem.StrongTypesNS.ds_resfileDataSet();
                NS_ResSystem.StrongTypesNS.DS_EXCEPTIONSDataSet ds_stanleyexceptions = new NS_ResSystem.StrongTypesNS.DS_EXCEPTIONSDataSet();
                NS_ResSystem.StrongTypesNS.DS_ROOMLISTDataSet ds_roomlist = new NS_ResSystem.StrongTypesNS.DS_ROOMLISTDataSet();

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 1;
                if (action == "Stu_Diet") parameters = 4;
                if (action == "Stu_Photos" | action == "HOUSE_COMM_PHOTOS" | action == "HALL_COMM_PHOTOS" | action == "PassRate" |
                    action == "ResPass" | action == "General" | action == "stulist" | action == "Stanley_List" | action == "StanExceptions" | action == "leaving_dtes" |
                    action == "RoomList"
                    ) parameters = 2;
                if (action == "Excluded" | action == "DPR" | action == "Alumni" | action == "Vehicle" | action == "JUNE_WARNING" |
                    action == "DEGREE_OBTAINED" | action == "PassedAll" | action == "FailedAll" | action == "Distinction") parameters = 3;


                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
                if (Global.Global.rescode != 999) p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname + " - " + Global.Global.hallname);
                else p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);

                reportViewer1.LocalReport.DataSources.Clear();

                if ((action == "Stu_Info" | action == "Stu_Photos") & tempstu == "*")
                {
                    proceed = false;
                    firstyrsonly fnform = new firstyrsonly(this);
                    fnform.ShowDialog();
                }

                if (action == "Stu_Diet")
                {
                    Function frmfns = new Function(this);
                    frmfns.ShowDialog();
                }

                if (action == "Results" & tempstu == "*")
                {
                    Results_Year frmyr = new Results_Year(this);
                    frmyr.ShowDialog();
                }

                if (action == "Excluded" | action == "DEGREE_OBTAINED")
                {
                    Year frmyr = new Year(this);
                    frmyr.ShowDialog();
                }

                if (action == "DPR")
                {
                    DPR frmdpr = new DPR(this);
                    frmdpr.ShowDialog();
                }

                if (action == "Ranking" | action == "ResPass" | action == "PassRate")
                {
                    Year_Exam frmyr = new Year_Exam(this);
                    frmyr.ShowDialog();
                }

                if (action == "stulist")
                {
                    resstatus frmstatus = new resstatus(this);
                    frmstatus.ShowDialog();
                }

                if (action == "Stanley_List")
                {
                    stanleyaccessreport frmstanley = new stanleyaccessreport(this);
                    frmstanley.ShowDialog();
                }

                if (action == "StanExceptions")
                {
                    DateRange frmrange = new DateRange(this);
                    frmrange.ShowDialog();
                }

                if (action == "PassedAll" | action == "FailedAll" | action == "Distinction")
                {
                    Year_Exam frmyr = new Year_Exam(this);
                    frmyr.ShowDialog();
                }



                if (proceed == true)
                {
                    if (action == "Birthdays" | action == "Phone_Nos" | action == "Stu_Info" | action == "Stu_Diet" | action == "Stu_Photos"
                        | action == "HOUSE_COMM_PHOTOS" | action == "HOUSE_COMM" | action == "Demographics" | action == "HALL_COMM_PHOTOS" | action == "Boxroom"
                        | action == "INTERCOM_LIST" | action == "DEPARTURE_LIST" | action == "Boxroom" | action == "Vehicle" | action == "mail_forward"
                        | action == "last_exam_dts" | action == "room_list" | action == "Arrivals" | action == "departures" | action == "leaving_dtes"
                        | action == "DOOR_LABELS" | action == "Time_Table")
                        ds_reports = Proxy.Res_System.Generic_Res_Report(tempstu, Global.Global.rescode, Global.Global.hallcode, tempbuilding, action);
                    
                    if (action == "Results") if (tempstu == "*") ds_results = Proxy.StudentResults.Res_Results(tempstu, Global.Global.rescode, tempyr, showyr);                        
                    
                    if (action == "Excluded") ds_res_results = Proxy.Res_System.Excluded_Students_By_Res(Global.Global.rescode, tempyr);
                    if (action == "DEGREE_OBTAINED") ds_res_results = Proxy.Res_System.Obtained_Degree_By_Res(Global.Global.rescode, tempyr);
                    if (action == "DPR") ds_res_results = Proxy.Res_System.DPR_By_Res(Global.Global.rescode, tempstr2, tempstr1);
                    if (action == "JUNE_WARNING") ds_res_results = Proxy.Res_System.June_Warning_By_Res(Global.Global.rescode);
                    if (action == "RoomList") ds_roomlist = Proxy.Res_System.roomlist(Global.Global.rescode);
                    if (action == "Ranking")
                    {
                        if (tempstu == "hall") ds_ranking = Proxy.Res_System.Acad_Ranking_Report(Global.Global.hallcode, 999, tempyr, tempstr1);
                        else ds_ranking = Proxy.Res_System.Acad_Ranking_Report(Global.Global.hallcode, Global.Global.rescode, tempyr, tempstr1);
                    }
                    if (action == "PassRate") ds_passrate = Proxy.Res_System.Acad_Res_Comparasion(tempyr, tempstr1, out tempstr2);
                    if (action == "ResPass") ds_respass = Proxy.Res_System.Acad_Graph_Res(tempyr, tempstr1, Global.Global.rescode, out tempstr2);
                    if (action == "stulist") ds_stufile = Proxy.Res_System.Official_Student_List(Global.Global.rescode, tempbool, tempstr1);
                    if (action == "Alumni") ds_res_results = Proxy.Res_System.Res_Alumni(Global.Global.rescode);
                    if (action == "Stanley_List") ds_stanley = Proxy.Stanley.Res_Stanley_Access_Report(tempstr1, tempstr2, Global.Global.rescode, tempdte1, tempdte2, out tempstr1);
                    if (action == "StanExceptions") ds_stanleyexceptions = Proxy.Stanley.Res_Stanley_Exception(Global.Global.rescode, tempdte1, tempdte2);

                    if (action == "AccessException")
                    {
                        if (tempstu == "H") ds_exceptions = Proxy.Stanley.Res_Stanley_Update_List("H", Global.Global.hallcode);
                        if (tempstu == "R") ds_exceptions = Proxy.Stanley.Res_Stanley_Update_List("R", Global.Global.rescode.ToString());
                    }


                    if (action == "PassedAll" | action == "FailedAll" | action == "Distinction")
                    {
                        string tempreport = "";
                        if (action == "PassedAll") tempreport = "P";
                        if (action == "FailedAll") tempreport = "F";
                        if (action == "Distinction") tempreport = "D";
                        ds_res_results = Proxy.Res_System.Acad_Res_Students_Highlight(Global.Global.rescode, tempyr, tempstr1, tempreport);
                    }
                    if (action == "Birthdays")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_BIRTHDAY";
                        rds.Value = ds_reports.TT_BIRTHDAY;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Birthdays.rdlc";
                    }

                    if (action == "Boxroom")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_GEN";
                        rds.Value = ds_reports.TT_GEN;
                        if (action == "Boxroom") reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Boxroom.rdlc";

                    }

                    if (action == "DOOR_LABELS")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DOOR_LABELS";
                        rds.Value = ds_reports.TT_DOOR_LABELS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.door_labels.rdlc";

                    }

                    if (action == "last_exam_dts")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_LAST_EXAM_DTS";
                        rds.Value = ds_reports.TT_LAST_EXAM_DTS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Last_Exam_Dte.rdlc";
                    }
                    if (action == "Time_Table")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_LAST_EXAM_DTS";
                        rds.Value = ds_reports.TT_LAST_EXAM_DTS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.TimeTable.rdlc";
                    }


                    if (action == "room_list" | action == "Arrivals" | action == "departures" | action == "leaving_dtes")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_ROOMLIST";
                        rds.Value = ds_reports.TT_ROOMLIST;
                        if (action == "room_list") reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.room_list.rdlc";
                        if (action == "Arrivals") reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Arrivals.rdlc";
                        if (action == "departures") reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Departures.rdlc";
                        if (action == "leaving_dtes")
                        {
                            if (MessageBox.Show
                                (
                                "Do you want to print the 'possible last exam dates' on this list?"
                                + Environment.NewLine + Environment.NewLine +
                                "Bear in mind that if this date is wrong - which it may well be for some students (see the FAQ, under Help for an explanation) - students may not correct the date. As a result, they may end up staying around residence well after their last exam, and possibly cause a disturbance."
                                + Environment.NewLine + Environment.NewLine +
                                "It is recommended that you leave select 'No' below and compare the students date they enter for their last exam to the 'Possible Last Exam Date Report', available under Reports -> Lists"
                                , "Possible Last Exam Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                p[1] = new Microsoft.Reporting.WinForms.ReportParameter("choice", "yes");
                            else { p[1] = new Microsoft.Reporting.WinForms.ReportParameter("choice", "no"); }
                            reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Departures_Exams.rdlc";
                        }
                    }

                    if (action == "Phone_Nos")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_PHONENOS";
                        rds.Value = ds_reports.TT_PHONENOS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Phone_Nos.rdlc";
                    }

                    if (action == "mail_forward")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_MAIL_FORWARD";
                        rds.Value = ds_reports.TT_MAIL_FORWARD;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.mail_forward.rdlc";
                    }

                    if (action == "Stu_Info")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_STU_INFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Student_Information.rdlc";
                    }

                    if (action == "RoomList")
                    {
                        rds.Name = "DS_ROOMLISTDataSet_TT_ROOMLIST";
                        rds.Value = ds_roomlist.TT_ROOMLIST;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Resrooms.rdlc";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", Global.Global.resname);
                    }



                    if (action == "Stu_Diet")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_STU_DIET";
                        rds.Value = ds_reports.TT_STU_DIET;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Functions.rdlc";
                    }

                    if (action == "Stu_Photos" | action == "HOUSE_COMM_PHOTOS" | action == "HALL_COMM_PHOTOS")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_PHOTOS";
                        rds.Value = ds_reports.TT_PHOTOS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Res_Photos.rdlc";
                        if (action == "Stu_Photos")
                        {
                            if (tempstu == "A") p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Student Photos - " + DateTime.Today.Year.ToString());
                            if (tempstu == "R") p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Returning Students Photos - " + DateTime.Today.Year.ToString());
                            if (tempstu == "F") p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "First Year Students Photos - " + DateTime.Today.Year.ToString());
                        }
                        if (action == "HOUSE_COMM_PHOTOS") p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "House Committee - " + DateTime.Today.Year.ToString());
                        if (action == "HALL_COMM_PHOTOS") p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students on Hall Committee - " + DateTime.Today.Year.ToString());
                    }

                    if (action == "Results")
                    {
                        rds.Name = "DS_RESULTSDataSet_TT_RESULTS";
                        rds.Value = ds_results.TT_RESULTS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Results.rdlc";
                    }

                    if (action == "HOUSE_COMM")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_HOUSECOM";
                        rds.Value = ds_reports.TT_HOUSECOM;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Housecomm.rdlc";
                    }

                    if (action == "Excluded" | action == "DPR" | action == "Vehicle" | action == "Alumni" | action == "JUNE_WARNING" | action == "DEGREE_OBTAINED" | action == "PassedAll" | action == "FailedAll" | action == "Distinction")
                    {
                        rds.Name = "DS_RESULTSDataSet_TT_GEN";
                        rds.Value = ds_res_results.TT_GEN;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Gen.rdlc";
                        if (action == "Excluded")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "List of Students Excluded in " + tempyr.ToString());
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Excluded in");
                        }
                        if (action == "DEGREE_OBTAINED")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "List of students who obtained their degree in " + tempyr.ToString());
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Degree");
                        }
                        if (action == "DPR")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "List of Students who Lost their DP");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Subject");
                        }

                        if (action == "JUNE_WARNING")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "List of Students who received a June Warning");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Description");
                        }

                        if (action == "Vehicle")
                        {
                            rds.Value = ds_reports.TT_GEN;
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "List of Students who have Registered a Vehicle");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Registration/Description");
                        }

                        if (action == "Alumni")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Old Res Students Still At Rhodes");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Year(s) they were in Res");
                        }

                        if (action == "PassedAll")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students who have passed all their subjects");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Subjects Passed");
                        }
                        if (action == "FailedAll")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students who have failed all subjects");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Subjects Failed");
                        }
                        if (action == "Distinction")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students who have obtained a distinction");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Subjects passed with Distinction");
                        }
                    }


                    if (action == "PassRate" | action == "ResPass")
                    {
                        


                        if (tempstr2 != "")
                        {
                            MessageBox.Show(tempstr2, "Graph cannot be displayed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                        else
                        {
                            if (action == "PassRate")
                            {
                                rds.Name = "DS_PASSRATEDataSet_TT_GRAPH";
                                rds.Value = ds_passrate.TT_GRAPH;
                                reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.PassRate.rdlc";
                                if (tempstr1 == "J") tempstr2 = "June Pass Rate for " + tempyr.ToString();
                                if (tempstr1 == "F") tempstr2 = "End of Year Pass Rate for " + tempyr.ToString();
                            }

                            if (action == "ResPass")
                            {
                                rds.Name = "DS_RES_GRAPHDataSet_TT_RES_GRAPH";
                                rds.Value = ds_respass.TT_RES_GRAPH;
                                reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.ResPass.rdlc";
                                if (tempstr1 == "J") tempstr2 = "June Res Results for " + tempyr.ToString();
                                if (tempstr1 == "F") tempstr2 = "End of Year Res Results for " + tempyr.ToString();
                            }


                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", tempstr2);
                        }
                    }


                    if (action == "Ranking")
                    {
                        rds.Name = "DS_RANKINGDataSet_TT_RANKING";
                        rds.Value = ds_ranking.TT_RANKING;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Exam_Ranking.rdlc";
                    }

                    if (action == "AccessException")
                    {
                        rds.Name = "ds_resfileDataSet_ttresfile";
                        rds.Value = ds_exceptions.ttresfile;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.AccessException.rdlc";
                        string tempstring = Global.Global.hallname;
                        if (tempstu == "R") tempstring = Global.Global.resname;
                        p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", tempstring);
                    }



                    if (action == "Demographics")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DEMOGRAPHICS";
                        rds.Value = ds_reports.TT_DEMOGRAPHICS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Demographics.rdlc";
                    }

                    if (action == "INTERCOM_LIST")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_INTERCOM";
                        rds.Value = ds_reports.TT_INTERCOM;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Intercom.rdlc";
                    }

                    if (action == "DEPARTURE_LIST")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DEPARTURE";
                        rds.Value = ds_reports.TT_DEPARTURE;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Departure_List.rdlc";
                    }


                    if (action == "stulist")
                    {
                        rds.Name = "DS_STUFILEDataSet_TT_stufile";
                        rds.Value = ds_stufile.TT_stufile;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.stulist.rdlc";
                        string title = "";
                        if (tempstr1 == "A") title = "List of Students Allocated to Residence";
                        if (tempstr1 == "P") title = "List of Students Provisionally Allocated to Residence";
                        if (tempstr1 == "C") title = "List of Students Currently in Residence";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", title);
                    }

                    if (action == "General")
                    {


                        rds.Name = "DS_STUINFODataSet_ttresstu";
                        rds.Value = Global.Global.ds_stuinfo.ttresstu;
                        if(Global.Global.rescode.ToString() != "999") reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.General.rdlc";
                        else reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.GeneralAll.rdlc";
                        string title = "General Student list";
                        if (Global.Global.custom == true) title = "Custom Search List";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", title);
                    }


                    if (action == "Stanley_List")
                    {
                        rds.Name = "ds_stanleyaccessDataSet_tt_stanleyaccess";
                        rds.Value = ds_stanley.tt_stanleyaccess;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Stanley_Access.rdlc";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", tempstr1);

                    }

                    if (action == "StanExceptions")
                    {
                        rds.Name = "DS_EXCEPTIONSDataSet_TT_EXCEPTIONS";
                        rds.Value = ds_stanleyexceptions.TT_EXCEPTIONS;

                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.Stanley_exceptions.rdlc";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Stanley Exceptions between " + tempdte1.ToShortDateString() + " and " + tempdte2.ToShortDateString() + ".");

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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
