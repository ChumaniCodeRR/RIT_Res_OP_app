﻿using System;
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
    public partial class Reports : Form
    {

        public bool showDeparture = false;

        string eventDetails;
        DateTime eventDate;

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
        ReportDataSource rds_comments;

        DataView dv_housecomm;
        DataView dv_report;

      

        NS_Dept.StrongTypesNS.ds_subject_marksDataSet ds_stu_marks;

        public string temphall;
        public int tempres;

        public Reports(string dowhat, string stu)
        {
            InitializeComponent();
            action = dowhat;
            tempstu = stu;
        }

        public Reports(string dowhat, NS_Dept.StrongTypesNS.ds_subject_marksDataSet _ds_report)
        {
            InitializeComponent();
            action = dowhat;
            ds_stu_marks = _ds_report;
        }


        public Reports(string dowhat, string _hall, int _res)
        {
            InitializeComponent();
            action = dowhat;
            temphall = _hall;
            tempres = _res;
        }

        public Reports(string dowhat, DataView dv_housecomm, int _tempyr)
        {
            InitializeComponent();
            action = dowhat;
            this.dv_housecomm = dv_housecomm;
            tempyr = _tempyr; 
        }

        public Reports(string dowhat, DataView _dv_report)
        {
            InitializeComponent();
            action = dowhat;
            dv_report = _dv_report;
        }

        public Reports(string dowhat, DataView _dv_report, string _tempTitle)
        {
            InitializeComponent();
            action = dowhat;
            dv_report = _dv_report;
            tempstr1 = _tempTitle;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {

                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;
                if (rootNamespace == "ResOps") rootNamespace = "IOPS";

                NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet ds_reports = new NS_ResSystem.StrongTypesNS.DS_REPORTSDataSet();
                NS_ResSystem.StrongTypesNS.DS_RESULTSDataSet ds_res_results = new NS_ResSystem.StrongTypesNS.DS_RESULTSDataSet();
                NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet ds_results = new NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet();
                NS_ResSystem.StrongTypesNS.DS_RANKINGDataSet ds_ranking = new NS_ResSystem.StrongTypesNS.DS_RANKINGDataSet();
                NS_ResSystem.StrongTypesNS.DS_PASSRATEDataSet ds_passrate = new NS_ResSystem.StrongTypesNS.DS_PASSRATEDataSet();
                NS_ResSystem.StrongTypesNS.DS_RES_GRAPHDataSet ds_respass = new NS_ResSystem.StrongTypesNS.DS_RES_GRAPHDataSet();
                NS_ResSystem.StrongTypesNS.DS_STUFILEDataSet ds_stufile = new NS_ResSystem.StrongTypesNS.DS_STUFILEDataSet();
                NS_ResSystem.StrongTypesNS.DS_ROOMLISTDataSet ds_roomlist = new NS_ResSystem.StrongTypesNS.DS_ROOMLISTDataSet();
                NS_ResSystem.StrongTypesNS.DS_OPPI_REPORTSDataSet ds_oppaddr = new NS_ResSystem.StrongTypesNS.DS_OPPI_REPORTSDataSet();
                NS_ResSystem.StrongTypesNS.DS_OPPISTUDataSet ds_oppstuno = new NS_ResSystem.StrongTypesNS.DS_OPPISTUDataSet();
                NS_ResSystem.StrongTypesNS.DS_DOUBLE_ROOMSDataSet ds_double_rooms = new NS_ResSystem.StrongTypesNS.DS_DOUBLE_ROOMSDataSet();

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 1;

                if (action == "departures")
                {
                    DialogResult results = MessageBox.Show("Show departure dates?", "Departure Date", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Question);
                    if(results == DialogResult.Yes) showDeparture = true;
                    else if (results == DialogResult.No) showDeparture = false;
                    else proceed = false;
                }
               
                if (action == "Stu_Photos" | action == "HOUSE_COMM_PHOTOS" | action == "HALL_COMM_PHOTOS" | action == "PassRate" |
                    action == "ResPass" | action == "General" | action == "stulist" | action == "leaving_dtes" |
                    action == "RoomList" | action == "OppiAddresses" | action == "OppiStunos" | action == "RESHISTORY" | action == "PREVYRS" | action == "EMERGENCYLIST" |
                    action == "MEDLIST"  | action == "DOUBLER" | action == "DOUBLE_ALLOCATION" | action == "EMAILLIST" | action == "Demographics" | action == "WardensResults" |
                    action == "HOUSECOMM_LIST" | action == "HALLCOMM_LIST" | action == "HALLCOMM_LIST_PORT" | action == "EXTENDED_STUDIES" | action == "MEDAIDDOCTORS" | action == "departures"
                    ) parameters = 2;
                if (action == "Excluded" | action == "DPR" | action == "Alumni" | action == "Vehicle" | action == "JUNE_WARNING" |
                    action == "DEGREE_OBTAINED" | action == "PassedAll" | action == "FailedAll" | action == "Distinction" | action == "DistinctionAll" | action == "ATTENDANCE_REGISTER") parameters = 3;

                 p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];

                 if (action != "StuMarks")
                 {
                     if (Global.Global.rescode != 999) p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.resname + " - " + Global.Global.hallname);
                     else p[0] = new Microsoft.Reporting.WinForms.ReportParameter("resname", Global.Global.hallname);

                     

                 }
                 else p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Department", Global.Global.resname);
              
                reportViewer1.LocalReport.DataSources.Clear();


                if (action == "ATTENDANCE_REGISTER")
                {
                    proceed = false;
                    AttendanceRegister frmAttendance = new AttendanceRegister();
                    frmAttendance.ShowDialog();
                    if (frmAttendance.tempstudents != "")
                    {
                        proceed = true;
                        tempstu = frmAttendance.tempstudents;
                        eventDate = frmAttendance.EventDate;
                        eventDetails = frmAttendance.EventDetails;
                    }
                }

                if (action == "Results" & tempstu == "*")
                {
                    Results_Year frmyr = new Results_Year(this);
                    frmyr.ShowDialog();
                }

                if (action == "Excluded" | action == "DEGREE_OBTAINED")
                {
                    Year frmyr = new Year(this, DateTime.Today.Year.ToString());
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


                if (action == "PassedAll" | action == "FailedAll" | action == "Distinction" | action == "DistinctionAll")
                {
                    Year_Exam frmyr = new Year_Exam(this);
                    frmyr.ShowDialog();
                }

                if (action == "RESHISTORY")
                {
                    proceed = false;
                    Search_Grid_Students.Search_Grid_Students frmSearch = new Search_Grid_Students.Search_Grid_Students(true);
                    frmSearch.ShowDialog();
                    if (frmSearch.Stuno != "")
                    {
                        tempstu = frmSearch.Stuno;
                        proceed = true;
                    }                    
                }

                if (action == "PREVYRS")
                {
                    Year frmyr = new Year(this, (DateTime.Today.Year -1).ToString());
                    frmyr.ShowDialog();
                }

                if (proceed == true)
                {

                    if (action == "PREVYRS") tempstu = tempyr.ToString();

                    if (action == "Birthdays" | action == "Phone_Nos" | action == "Stu_Info" | action == "Stu_Photos"
                        | action == "HOUSE_COMM_PHOTOS" | action == "HOUSE_COMM" | action == "Demographics" | action == "HALL_COMM_PHOTOS" | action == "Boxroom"
                        | action == "INTERCOM_LIST" | action == "DEPARTURE_LIST" | action == "Boxroom" | action == "Vehicle" | action == "mail_forward"
                        | action == "last_exam_dts" | action == "room_list" | action == "Arrivals" | action == "departures" | action == "leaving_dtes"
                        | action == "DOOR_LABELS" | action == "Time_Table" | action == "RESHISTORY" | action == "PREVYRS" | action == "EMERGENCYLIST" | action == "MEDLIST"
                        | action == "DOUBLER" | action == "EMAILLIST" | action == "EXTENDED_STUDIES" | action == "MEDAIDDOCTORS" | action == "ATTENDANCE_REGISTER")
                        ds_reports = Proxy.Res_System.Generic_Res_Report(tempstu, Global.Global.rescode, Global.Global.hallcode, tempbuilding, action);

                    if ((action == "RESHISTORY" | action == "PREVYRS" | action == "EMERGENCYLIST" | action == "MEDLIST" | action == "DOUBLER" | action == "EMAILLIST") & (ds_reports.TT_STU_INFO.Rows.Count == 0 & ds_reports.TT_MED_AID.Rows.Count == 0))
                    {
                        MessageBox.Show("No Information to display", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    
                    if (action == "Results") if (tempstu == "*") ds_results = Proxy.StudentResults.Res_Results(tempstu, Global.Global.rescode, tempyr, showyr);                        
                    
                    if (action == "Excluded") ds_res_results = Proxy.Res_System.Excluded_Students_By_Res(temphall,tempres, tempyr);
                  
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

                    if (action == "DEGREE_OBTAINED") ds_res_results = Proxy.Res_System.Obtained_Degree_By_Res(temphall,tempres, tempyr);

                    if (action == "FailedAll" | action == "Distinction" | action == "DistinctionAll" | action == "PassedAll")
                    {
                        string tempreport = "";
                       
                        if (action == "FailedAll") tempreport = "F";
                        if (action == "Distinction") tempreport = "D";
                        if (action == "DistinctionAll") tempreport = "DA";
                        if (action == "PassedAll") tempreport = "P";
                        ds_res_results = Proxy.Res_System.Acad_Res_Students_Highlight(temphall,tempres, tempyr, tempstr1, tempreport);
                    }

                    if (action == "OppiAddresses")
                    {
                        ds_oppaddr = Proxy.Res_System.oppi_reports("OppiAddresses");

                        rds.Name = "DS_OPPI_REPORTSDataSet_TT_OPPADDR";
                        rds.Value = ds_oppaddr.TT_OPPADDR;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.OppiAddr.rdlc";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Oppidan Address list"); 
                    }

                    if (action == "OppiStunos")
                    {
                        ds_oppstuno = Proxy.Res_System.oppstuno(tempstu);
                        
                        rds.Name = "DS_OPPISTUDataSet_TT_OPPISTU";
                        rds.Value = ds_oppstuno.TT_OPPISTU;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "Res_System.Reports.OppiStunos.rdlc";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students staying in the same area"); 

                    }

                    if (action == "ATTENDANCE_REGISTER")
                    {
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("eventDetails", eventDetails);
                        p[2] = new Microsoft.Reporting.WinForms.ReportParameter("eventDate", eventDate.ToShortDateString());
                        rds.Name = "DS_REPORTSDataSet_TT_ROOMLIST";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.AttendanceRegister.rdlc");
                    }

                

                    if (action == "Birthdays")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_BIRTHDAY";
                        rds.Value = ds_reports.TT_BIRTHDAY;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Birthdays.rdlc");
                    }

                    if (action == "Boxroom")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_GEN";
                        rds.Value = ds_reports.TT_GEN;
                        if (action == "Boxroom") reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.Boxroom.rdlc");

                    }

                    if (action == "DOOR_LABELS")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DOOR_LABELS";
                        rds.Value = ds_reports.TT_DOOR_LABELS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.door_labels.rdlc");

                    }

                    if (action == "last_exam_dts")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_LAST_EXAM_DTS";
                        rds.Value = ds_reports.TT_LAST_EXAM_DTS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Last_Exam_Dte.rdlc");
                    }
                    if (action == "Time_Table")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_LAST_EXAM_DTS";
                        rds.Value = ds_reports.TT_LAST_EXAM_DTS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.TimeTable.rdlc");
                    }


                    if (action == "room_list" | action == "Arrivals" | action == "departures" | action == "leaving_dtes")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_ROOMLIST";
                        rds.Value = ds_reports.TT_ROOMLIST;
                        if (action == "room_list") reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.room_list.rdlc");
                        if (action == "Arrivals") reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.Arrivals.rdlc");
                        if (action == "departures")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("showDeparture", showDeparture.ToString());
                            reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.Departures.rdlc");

                        }
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
                            reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.StudentRegisters.Departures_Exams.rdlc");
                        }
                    }

                    if (action == "Phone_Nos")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_PHONENOS";
                        rds.Value = ds_reports.TT_PHONENOS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Phone_Nos.rdlc");
                    }

                    if (action == "mail_forward")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_MAIL_FORWARD";
                        rds.Value = ds_reports.TT_MAIL_FORWARD;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.mail_forward.rdlc");
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
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Resrooms.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", Global.Global.resname);
                    }

                    if (action == "Stu_Photos" | action == "HOUSE_COMM_PHOTOS" | action == "HALL_COMM_PHOTOS")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_PHOTOS";
                        rds.Value = ds_reports.TT_PHOTOS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Res_Photos.rdlc");
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
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Format("{0}.Reports.Results.Results.rdlc", rootNamespace);
                        if (ds_results.TT_COMMENTS.Rows.Count > 0)
                        {
                            rds_comments = new ReportDataSource("ds_comments", (DataTable)ds_results.TT_COMMENTS);
                            reportViewer1.LocalReport.DataSources.Add(rds_comments);

                            StreamReader subReport = new StreamReader(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(
                            string.Concat(rootNamespace, ".Reports.Results.StuCommSubreport.rdlc")));

                            reportViewer1.LocalReport.LoadSubreportDefinition("StuCommSubreport", subReport);
                        }

                    }

                    if (action == "HOUSE_COMM")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_HOUSECOM";
                        rds.Value = ds_reports.TT_HOUSECOM;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Housecomm.rdlc");
                    }
                   

                    if (action == "HALLCOMM_LIST" | action == "HALLCOMM_LIST_PORT")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_HOUSECOM";
                        rds.Value = this.dv_housecomm;
                        if (action == "HALLCOMM_LIST") reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.HallReports.HallcommList.rdlc");
                        else reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.HallReports.HallcommListPort.rdlc");
                        

                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("TempYear", tempyr.ToString());
                    }

                    if (action == "RESHISTORY")
                    {
                        rds.Name = "DS_STUINFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Student_Information.ResHistory.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Student Accomodation History");

                    }

                    if (action == "PREVYRS")
                    {
                        rds.Name = "DS_STUINFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.GeneralResInfo.PrevYears.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Previous Students In Res For " + tempstu);

                    }



                    if (action == "EMERGENCYLIST")
                    {
                        rds.Name = "DS_STUINFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.EmergencyList.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Emergency List");

                    }

                    if (action == "MEDLIST" | action == "MEDAIDDOCTORS")
                    {
                        rds.Name = "DS_MEDAID";
                        rds.Value = ds_reports.TT_MED_AID;
                        if (action == "MEDLIST")
                        {
                            reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.MedicalList.rdlc");
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students With Allergies /On Medication /Etc");
                        }
                        if (action == "MEDAIDDOCTORS")
                        {
                            reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.MedAidDoctors.rdlc");
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Medical Aid/Doctors Information");
                        }


                    }
                    
                    if (action == "DOUBLER")
                    {
                        rds.Name = "DS_STUINFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.DoubleRooms.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Double Room List");

                    }

                    if (action == "DOUBLE_ALLOCATION")
                    {
                        ds_double_rooms = Proxy.Res_System.DOUBLE_ROOM_LIST(Global.Global.rescode);
                        if (ds_double_rooms.TT_DOUBLE.Rows.Count < 1)
                        {
                            MessageBox.Show("No Information to display", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            return;
                        }

                        else
                        {
                            rds.Name = "ds_stuinfo";
                            rds.Value =  ds_double_rooms.TT_DOUBLE;
                            reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.DoubleAllocations.rdlc");
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Double Room Allocation");

                        }

                    }
                    
                    if (action == "EMAILLIST")
                    {
                        string ttitle = "";
                        if (tempstu == "F") ttitle = "Email List Of First Year Students";
                        if (tempstu == "R") ttitle = "Email List Of Returning Students";
                        if (tempstu == "A") ttitle = "Email List Of All Students";


                        rds.Name = "DS_STUINFO";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.EmailList.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", ttitle);

                    }

                    if (action == "Excluded" | action == "DPR" | action == "Vehicle" | action == "Alumni" | action == "JUNE_WARNING" | action == "DEGREE_OBTAINED" | action == "PassedAll" | action == "FailedAll" | action == "Distinction" | action == "DistinctionAll")
                    {
                        rds.Name = "DS_RESULTSDataSet_TT_GEN";
                        rds.Value = ds_res_results.TT_GEN;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.Gen.rdlc");
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

                        if (action == "DistinctionAll")
                        {
                            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", "Students who have obtained full distinctions");
                            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("descrip", "Subjects");
                        }
                    }


                    if (action == "PassRate" | action == "ResPass")
                    {   
                        if (tempstr2 != string.Empty) MessageBox.Show(tempstr2, "Graph cannot be displayed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        else
                        {
                            if (action == "PassRate")
                            {
                                rds.Name = "DS_PASSRATEDataSet_TT_GRAPH";
                                rds.Value = ds_passrate.TT_GRAPH;
                                reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.HallReports.PassRate.rdlc");
                                if (tempstr1 == "J") tempstr2 = "June Pass Rate for " + tempyr.ToString();
                                if (tempstr1 == "F") tempstr2 = "End of Year Pass Rate for " + tempyr.ToString();
                            }

                            if (action == "ResPass")
                            {
                                rds.Name = "DS_RES_GRAPHDataSet_TT_RES_GRAPH";
                                rds.Value = ds_respass.TT_RES_GRAPH;
                                reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.ResPass.rdlc");
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
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.Exam_Ranking.rdlc");
                    }
                    
                    if (action == "Demographics")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DEMOGRAPHICS";
                        rds.Value = ds_reports.TT_DEMOGRAPHICS;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.GeneralResInfo.Demographics.rdlc");
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("DisabCount", ds_reports.TT_DEMOGRAPHICS.Rows[0]["DISAB_COUNT"].ToString());
                    }

                    if (action == "INTERCOM_LIST")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_INTERCOM";
                        rds.Value = ds_reports.TT_INTERCOM;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Intercom.rdlc");
                    }

                    if (action == "StuMarks")
                    {
                        rds.Name = "ds_report";
                        rds.Value = ds_stu_marks.tt_stuclassmk;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.StuMarksByStuno.rdlc");
                    }


                    if (action == "DEPARTURE_LIST")
                    {
                        rds.Name = "DS_REPORTSDataSet_TT_DEPARTURE";
                        rds.Value = ds_reports.TT_DEPARTURE;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.Departure_List.rdlc");
                    }


                    if (action == "stulist")
                    {
                        rds.Name = "DS_STUFILEDataSet_TT_stufile";
                        rds.Value = ds_stufile.TT_stufile;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.Lists.stulist.rdlc");
                        string title = "";
                        if (tempstr1 == "A") title = "List of Students Allocated to Residence";
                        if (tempstr1 == "P") title = "List of Students Provisionally Allocated to Residence";
                        if (tempstr1 == "C") title = "List of Students Currently in Residence";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", title);
                    }

                    if (action == "General")
                    {
                        rds.Name = "DS_STUINFODataSet_ttresstu";
                        rds.Value = Global.Global.ds_stuinfo.tt_student_info;
                        if(Global.Global.rescode.ToString() != "999") reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.ResSystem.General.rdlc");
                        else reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.ResSystem.GeneralAll.rdlc");
                        string title = "General Student list";
                        if (Global.Global.custom == true) title = "Custom Search List";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", title);
                    }

                    if (action == "EXTENDED_STUDIES")
                    {
                        rds.Name = "ds_extended";
                        rds.Value = ds_reports.TT_STU_INFO;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.ExtendedStudies.rdlc");
                        string title = "Extended Studies Student list";
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("title", title);
                    }

                    if (action == "WardensResults")
                    {
                        rds.Name = "ds_subwardens_results";
                        rds.Value = dv_report;
                        reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.AcademicReports.SubwardensReport.rdlc");
                        p[0] = new Microsoft.Reporting.WinForms.ReportParameter("title", tempstr1);
                        p[1] = new Microsoft.Reporting.WinForms.ReportParameter("HallName", Global.Global.hallname);
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

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            if (e.ReportPath.Equals("StuCommSubreport")) { e.DataSources.Add(rds_comments); }
        }
    }
}
