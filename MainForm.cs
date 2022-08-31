using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LoginScreen;
using Utilities;
using Discipline.Reports;

namespace Res_System
{
    public partial class MainForm : Form
    {
        public bool agreed = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        public static Student_Search.Student_Search frmstuQuery = new Student_Search.Student_Search();
        public NS_Stanley.StrongTypesNS.ds_stanleyDataSet ds_exceptions;
        public string allres = "";
        int tempres = 999;
        DataView dv_Residence;

        DataSet ds_res_codes;

        Loading ShowLoading;
        ResList ShowResList;
        Student_Personal_Details.StudentsPersonalDetails StuPersonal;
        Discipline.UpdateScreen.Discipline_List frmDisc;
        Student_Results.StudentResults frmStuResults;
        Student_Medical.StudentMedicalDetails frmMedicalDetails;
        
        public bool PerformAction = false;

        private void Load_Crest()
        {
            try
            {
                string tempres = "";
                if (((Item)cbres.SelectedItem).Value.ToString() != "999") tempres = ((Item)cbres.SelectedItem).Value.ToString();
                else tempres = ((Item)cb_hall.SelectedItem).Value.ToString(); 
                Global.Global.ds_logo = new NS_System.StrongTypesNS.DS_PHOTODataSet();
                pichousecrest.Image = Res_System.Properties.Resources.rhodes_crest;
                Bitmap bmp = new Bitmap(Res_System.Properties.Resources.rhodes_crest);

                DataRow newrow = Global.Global.ds_logo.TT_PHOTO.NewRow();
                newrow["image"] = (byte[])TypeDescriptor.GetConverter(bmp).ConvertTo(bmp, typeof(byte[]));
                Global.Global.ds_logo.TT_PHOTO.Rows.Add(newrow);


                NS_System.StrongTypesNS.DS_PHOTODataSet ds_image = Proxy.System.Get_Photos(@"/db/1/live/programs/reslogos/" + tempres + ".jpg");

                int c = ds_image.TT_PHOTO.Rows.Count;

                if (c >= 1)
                {

                    try
                    {
                        Global.Global.ds_logo = ds_image;
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds_image.TT_PHOTO.Rows[c - 1]["image"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pichousecrest.Image = Image.FromStream(stmBLOBData);
                    }
                    catch
                    {
                        Global.Global.ds_logo.TT_PHOTO.Rows[0][0] = pichousecrest.Image;
                        pichousecrest.Image = Res_System.Properties.Resources.rhodes_crest;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void Load_Student()
        {
            try
            {
                picStudent.Image = null;
                NS_System.StrongTypesNS.DS_PHOTODataSet ds_image = new NS_System.StrongTypesNS.DS_PHOTODataSet();
                NS_StuInfo.StrongTypesNS.DS_STUINFODataSet ds_stuinfo = Proxy.StudentInfo.Get_Students_Name(txtstuno.Text);
                string tempstring = @"/db/1/live/programs/photos/" + txtstuno.Text.ToUpper() + ".jpg";

                if (ds_stuinfo.TT_STUNAME.Rows.Count >= 1)
                {
                    try
                    {
                        Global.Global.tempstu = txtstuno.Text;
                        ds_image = Proxy.System.Get_Photos(tempstring);

                        int c = ds_image.TT_PHOTO.Rows.Count;

                        if (c >= 1)
                        {
                            try
                            {
                                Byte[] byteBLOBData = new Byte[0];
                                byteBLOBData = (Byte[])(ds_image.TT_PHOTO.Rows[c - 1]["image"]);
                                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                                picStudent.Image = Image.FromStream(stmBLOBData);                         
                            }
                            catch
                            { picStudent.Image = null; }
                        }
                        else picStudent.Image = Res_System.Properties.Resources.no_photo;

                        if (ds_stuinfo.TT_STUNAME.Rows[0]["prefer_name"].ToString() != "") txt_prefer_name.Text = "Preferred Name: " + ds_stuinfo.TT_STUNAME.Rows[0]["prefer_name"].ToString();
                        else txt_prefer_name.Text = "";
                        txtname.Text = ds_stuinfo.TT_STUNAME[0]["name"].ToString();
                        txtsurn.Text = ds_stuinfo.TT_STUNAME[0]["surname"].ToString();
                        txtdegr.Text = ds_stuinfo.TT_STUNAME[0]["tempdegree"].ToString();
                        txtstatus.Text = ds_stuinfo.TT_STUNAME[0]["tempstatus"].ToString();

                        lbl_outof.Text = (Global.Global.position + 1).ToString() + " of " + Global.Global.totalrec.ToString();
                        Loadform();
                    }
                    catch (Exception ex)
                    {
                        Utils.HandleException(ExceptionSource.ResSystem, ex);
                    }
                }
                else MessageBox.Show("Student Number Does Not Exist");
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void txtstuno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cb_hall.Visible = false;
                    cbres.Visible = false;
                    lblres.Visible = false;
                    lblhall.Visible = false;
                    lblcustom.Visible = true;
                    txt_yr.Enabled = false;
                    pichousecrest.Image = Res_System.Properties.Resources.rhodes_crest;

                    rb_reslist.Checked = false;
                    rb_custom.Checked = false;

                    Global.Global.ds_stuinfo = Proxy.StudentSearch.Search_Single_Student(txtstuno.Text);
                    Load_Res_List_Form();
                    if (Global.Global.ds_stuinfo.tt_student_info.Rows.Count == 200) MessageBox.Show("A maximum of 200 student records have been returned. Please refine your search criteria to be more specific", "Max Records Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void Loadform()
        {
            if (PerformAction == true)
            {
                if (disciplinaryInformationToolStripMenuItem.Checked == true)
                {
                    StuPersonal.Hide();
                    frmStuResults.Hide();
                    frmMedicalDetails.Hide();

                    frmDisc.Show();
                    frmDisc.Refresh_Data();
                }

                if (personalDetailsToolStripMenuItem.Checked == true)
                {   
                    frmDisc.Hide();
                    frmStuResults.Hide();
                    frmMedicalDetails.Hide();

                    StuPersonal.Show();
                    StuPersonal.Refresh_Data();
                }

                if (resultsToolStripMenuItem.Checked)
                {
                    StuPersonal.Hide();
                    frmDisc.Hide();
                    frmMedicalDetails.Hide();

                    frmStuResults.Show();
                    frmStuResults.RefreshData();
                }

                if (medicalDetailsToolStripMenuItem.Checked)
                {
                    StuPersonal.Hide();
                    frmDisc.Hide();
                    frmStuResults.Hide();

                    frmMedicalDetails.Show();
                    frmMedicalDetails.RefreshData();
                }
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool validlogin = AppServer.AppServer.initial_Login(Proxy.Info.username, false, "resg001", true, "Res_System", false);
                if (validlogin == true)
                {
                    if (Proxy.Info.username.StartsWith("test")) menuStrip1.BackColor = statusStrip1.BackColor = Color.LightGreen;
                    if (Proxy.Info.username.StartsWith("test")) resVacationToolStripMenuItem.Visible = true; // Testing purposes only //
                    txt_yr.Text = DateTime.Today.Year.ToString();

                    toolStripStatusLabel1.Text = "LOGGED IN AS: " + Proxy.Info.username + " - "
                    + Proxy.Info.fullname + " SINCE " + DateTime.Now;

                    Global.Global.tempstu = "";

                    if (Proxy.Info.student == true)
                    {
                        string feedback = "";
                        tempres = 0;
                        string temphall = "";
                        Proxy.StudentInfo.Check_Sub_Warden(Proxy.Info.username, "ResSystem", out feedback, out tempres, out temphall);

                        if (feedback != "")
                        {
                            MessageBox.Show(feedback, "Residence System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Close();
                        }
                        else
                        {
                            Global.Global.rescode = tempres;
                            Global.Global.hallcode = temphall;
                            Global.Global.type = "SW";
                        }
                    }
                    else
                    {

                        tempres = 999;
                        string temphall = "";
                        string temptype = "";

                        string feedback = Proxy.Res_System.Check_Level(Proxy.Info.username, out temptype, out tempres, out temphall, out allres);

                        if (feedback != "")
                        {
                            MessageBox.Show(feedback, "Residence System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Close();
                        }
                        else
                        {
                            Global.Global.rescode = tempres;                            
                            Global.Global.type = temptype;
                            Global.Global.hallcode = temphall;
                        }
                    }

                    //Check if terms and conditions have been agreed to
                    agreed = Proxy.System.TAC_CHECK(Proxy.Info.username, "resg001");
                    if (agreed == false)
                    {
                        tac frmtac = new tac(this, false);
                        frmtac.ShowDialog();
                        if (agreed == true)
                        {
                            //Accept terms and conditions and validate
                            agreed = Proxy.System.TAC_AGREE(Proxy.Info.username, "resg001");
                        }
                    }

                    int sendres = Global.Global.rescode;
                    if (Global.Global.type != "SW" && Global.Global.type != "AW") sendres = 0;
                    Global.Global.ds_Stu = Proxy.Global.Get_Reg_Stu_By_Res(sendres);   

                    if (agreed == false) this.Close();
                    if (agreed == true)
                    {

                        //Show list of students;
                        ShowResList = new Res_System.ResList(this);
                        ShowResList.MdiParent = this;
                        ShowResList.Dock = DockStyle.Fill;
                        
                        //Load the Personal Details Form;
                        StuPersonal = new Student_Personal_Details.StudentsPersonalDetails();
                        StuPersonal.MdiParent = this;
                        StuPersonal.Dock = DockStyle.Fill;

                        //Load the Discipline Form
                        frmDisc = new Discipline.UpdateScreen.Discipline_List();
                        frmDisc.MdiParent = this;
                        frmDisc.Dock = DockStyle.Fill;

                        //Load the Student Results Form
                        frmStuResults = new Student_Results.StudentResults(false);
                        frmStuResults.MdiParent = this;
                        frmStuResults.Dock = DockStyle.Fill;

                        //Load the Medical Details Form
                        frmMedicalDetails = new Student_Medical.StudentMedicalDetails();
                        frmMedicalDetails.MdiParent = this;
                        frmMedicalDetails.Dock = DockStyle.Fill;

                        if (Global.Global.hallcode != "")
                        {
                            if (Global.Global.hallcode.Contains(",")) Res_System.Properties.Settings.Default.Start_Hall = Global.Global.hallcode.Split(',')[0];
                            else  Res_System.Properties.Settings.Default.Start_Hall = Global.Global.hallcode;
                        }
                        if (Global.Global.rescode != 0 & Global.Global.type != "HH")
                        {
                            Res_System.Properties.Settings.Default.Start_Res = Global.Global.rescode.ToString();
                        }
                        Global.Global.ds_rescodes = Proxy.System.Get_Res_Codes();
                        Global.Global.ds_badcodes = Proxy.StudentDiscipline.Get_Discipline_Codes();

                        ds_res_codes = Global.Global.ds_rescodes.Copy();

                        for (int i = 0; i < Global.Global.ds_rescodes.TT_HALL.Rows.Count; i++)
                        {

                            NS_System.StrongTypesNS.DS_RESCODESDataSet.TT_HALLRow HallRow = Global.Global.ds_rescodes.TT_HALL[i];

                            if (Global.Global.type == "HA")
                            {
                                if (Global.Global.hallcode.Contains(HallRow.SHALL)) cb_hall.Items.Add(new Item(HallRow.DETAIL, HallRow.SHALL));
                                cb_hall.Enabled = true;
                            }

                            else
                            {
                                cb_hall.Items.Add(new Item(HallRow.DETAIL, HallRow.SHALL));
                            }
                        }
                       
                        DataRow newrow = ds_res_codes.Tables["TT_RES"].NewRow();
                        newrow["hall"] = "*";
                        newrow["res"] = 999;
                        newrow["resname"] = "All Students in the Hall";
                        ds_res_codes.Tables["TT_RES"].Rows.Add(newrow);  
                        
                        int index = 0;
                        
                        try
                        {
                            index = new BindingSource(ds_res_codes, "TT_HALL").Find("shall", Res_System.Properties.Settings.Default.Start_Hall);
                        }
                        finally
                        {
                            try
                            {
                                cb_hall.SelectedIndex = index;
                            }
                            catch { cb_hall.SelectedIndex = 0; }
                        }
                        Fill_Comboboxes();
                        //populate_residences();
                                                
                        Global.Global.hallname = cb_hall.Text.ToString();
                        //Global.Global.hallcode = cb_hall.SelectedValue.ToString();
                        Global.Global.hallcode = ((Item)cb_hall.SelectedItem).Value.ToString();
                        
                        if (Global.Global.type == "AD") cb_hall.Enabled = true;
                        if (Global.Global.type == "SW" || Global.Global.type == "AW")
                        {
                            rb_custom.Enabled = false;
                            txtstuno.Enabled = false;
                            txt_yr.Enabled = false;
                            if (Global.Global.type == "SW")
                            {
                                updatesToolStripMenuItem.Enabled = false;
                                resultsToolStripMenuItem.Enabled = false;
                            }
                        }
                        if (Global.Global.type != "SW")
                        {
                            disciplineReportsToolStripMenuItem.Enabled = true;
                            academicReportsToolStripMenuItem.Enabled = true;
                        }
                        
                        Load_Crest();

                        ShowLoading = new Loading();
                        ShowLoading.MdiParent = this;
                        ShowLoading.Dock = DockStyle.Fill;
                        ShowLoading.Show();
                        
                        nextYearsHouseCommToolStripMenuItem.Text = (DateTime.Today.Year + 1).ToString() + " " + "Leadership list";
                        thisYearsHouseCommToolStripMenuItem.Text = (DateTime.Today.Year).ToString() + " " + "Leadership list";
                        hallLeadershipByPortfolioToolStripMenuItem.Text = (DateTime.Today.Year).ToString() + " " + "Hall Leadership By Portfolio";
                        NextHallLeadershipByPortfolioToolStripMenuItem.Text = (DateTime.Today.Year + 1).ToString() + " " + "Hall Leadership By Portfolio";
                        hallLeadershipByResToolStripMenuItem.Text = (DateTime.Today.Year).ToString() + " " + "Hall Leadership By Res";
                        NexthallLeadershipByResToolStripMenuItem.Text = (DateTime.Today.Year + 1).ToString() + " " + "Hall Leadership By Res";
                        ShowLoading.Close();
                        ShowResListForm();
                        ShowResList.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void populate_residences()
        {

            int startindex = 0;
            int index = 0;

            dv_Residence = new DataView(ds_res_codes.Tables["TT_RES"]);
            string searchstring = "HALL = '" + ((Item)cb_hall.SelectedItem).Value.ToString() + "'";
            
            dv_Residence.RowFilter = searchstring;

            cbres.Items.Clear();

            if (Global.Global.type != "SW" && Global.Global.type != "AW")
            {
                index = 1;
                cbres.Items.Add(new Item("All Students in the hall", "999"));
            }

            foreach (DataRowView rowView in dv_Residence)
            {
                DataRow row = rowView.Row;
                if ((Global.Global.type == "HH" | Global.Global.type == "HA" | Global.Global.type == "AD")
                    | allres.Contains(row["res"].ToString()) | Global.Global.rescode.ToString() == row["res"].ToString())

                {
                    cbres.Items.Add(new Item(row["resname"].ToString(), row["res"].ToString()));
                    if (row["res"].ToString() == Res_System.Properties.Settings.Default.Start_Res) startindex = index;
                    index++;
                }
            }
            cbres.SelectedIndex = startindex;            
        }

        public void ShowResListForm()
        {
            try
            {
                Global.Global.position = 0;
                string typeres = "CURR";
                Global.Global.ds_stuinfo = Proxy.StudentSearch.Get_Students_In_Res(((Item)cb_hall.SelectedItem).Value.ToString(),
                   ((Item)cbres.SelectedItem).Value.ToString(), typeres, Int32.Parse(txt_yr.Text));
                Load_Res_List_Form();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        public void Load_Res_List_Form()
        {
            ShowResList.Refresh_Data();
            ShowResList.Show();
        }


        public void Update_Stu()
        {
            txtstuno.Text = Global.Global.tempstu;
            Load_Student();
        }

        private void Fill_Comboboxes()
        {
            try
            {

                populate_residences();

                Global.Global.rescode = Int32.Parse(((Item)cbres.SelectedItem).Value.ToString());
                Global.Global.resname = ((Item)cbres.SelectedItem).Name.ToString();
                if (Global.Global.type != "SW" && Global.Global.type != "AW") cbres.Enabled = true;

                if (((Item)cbres.SelectedItem).Value.ToString() == "999")
                {
                    roomManagementToolStripMenuItem.Enabled = false;
                    resreportsToolStripMenuItem.Enabled = false;
                    updatesToolStripMenuItem.Enabled = false;
                    hallReportsToolStripMenuItem.Enabled = true;
                }
                else
                {
                    roomManagementToolStripMenuItem.Enabled = true;
                    resreportsToolStripMenuItem.Enabled = true;
                    if (Global.Global.type != "SW") updatesToolStripMenuItem.Enabled = true;
                    hallReportsToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
        
        private void btnnext_Click(object sender, EventArgs e)
        {            
            ShowResList.next_row();            
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            ShowResList.previous_row();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Proxy.Info.username.Substring(0, 4) != "test") Form1_Load(sender, e);
        }

        private void cbres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbres.Enabled == true && ((Item)cbres.SelectedItem).Value != null)
                {
                    Res_System.Properties.Settings.Default.Start_Res = ((Item)cbres.SelectedItem).Value.ToString();
                    Res_System.Properties.Settings.Default.Save();
                    Global.Global.rescode = Int32.Parse(((Item)cbres.SelectedItem).Value.ToString());
                    Global.Global.resname = ((Item)cbres.SelectedItem).Name.ToString();

                    ShowResListForm();

                    Load_Crest();

                    if (((Item)cbres.SelectedItem).Value.ToString() == "999")
                    {
                        roomManagementToolStripMenuItem.Enabled = false;
                        resreportsToolStripMenuItem.Enabled = false;
                        updatesToolStripMenuItem.Enabled = false;
                        hallReportsToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        roomManagementToolStripMenuItem.Enabled = true;
                        resreportsToolStripMenuItem.Enabled = true;
                        updatesToolStripMenuItem.Enabled = true;
                        hallReportsToolStripMenuItem.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void Close_Forms()
        {
            StuPersonal.Hide();
        }

        private void rb_custom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_custom.Checked == true)
                {
                    Close_Forms();
                    cb_hall.Visible = false;
                    cbres.Visible = false;
                    lblres.Visible = false;
                    lblhall.Visible = false;
                    lblcustom.Visible = true;
                    updatesToolStripMenuItem.Enabled = false;
                    txt_yr.Enabled = false;
                    pichousecrest.Image = Res_System.Properties.Resources.rhodes_crest;
                    Global.Global.ds_stuinfo = new NS_Student_Search.StrongTypesNS.DS_STUDENT_SEARCHDataSet();
                    Global.Global.custom = true;
                    frmstuQuery.ShowDialog();
                    Load_Res_List_Form();
                    rb_custom.Checked = false;
                    if (Global.Global.ds_stuinfo.tt_student_info.Rows.Count == 200) MessageBox.Show("A maximum of 200 student records have been returned. Please refine your search criteria to be more specific", "Max Records Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void rb_reslist_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_reslist.Checked == true)
            {
                ShowResListForm();
                Load_Crest();
                lblcustom.Visible = false;
                cb_hall.Visible = true;
                cbres.Visible = true;
                lblres.Visible = true;
                lblhall.Visible = true;
                if (Global.Global.type != "SW" && Global.Global.type != "AW") txt_yr.Enabled = true;
                Global.Global.custom = false;
                updatesToolStripMenuItem.Enabled = true;

            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_hall.SelectedIndex > -1 && cb_hall.Enabled == true)
            {
                Res_System.Properties.Settings.Default.Start_Hall = ((Item)cb_hall.SelectedItem).Value.ToString();
                Res_System.Properties.Settings.Default.Start_Res = "999";
                Res_System.Properties.Settings.Default.Save();
                Global.Global.hallname = cb_hall.Text.ToString();
                Global.Global.hallcode = ((Item)cb_hall.SelectedItem).Value.ToString();
                
                Fill_Comboboxes();
                ShowResListForm();
                Load_Crest();
            }
        }

        
        private void sectionsAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Res_System.Sections frmsections = new Res_System.Sections(((Item)cbres.SelectedItem).Name.ToString(), ((Item)cbres.SelectedItem).Value.ToString());
            frmsections.ShowDialog();
        
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms frmrooms = new Rooms(((Item)cbres.SelectedItem).Name.ToString(), ((Item)cbres.SelectedItem).Value.ToString());
            frmrooms.ShowDialog();
        }

        private void assignStudentsToRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Rooms frmAssign = new Assign_Rooms(((Item)cbres.SelectedItem).Name.ToString(), ((Item)cbres.SelectedItem).Value.ToString());
            frmAssign.ShowDialog();
        }

        private void txt_yr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformAction = true;
                ShowResListForm();
            }
        }

        private void txt_yr_MouseClick(object sender, MouseEventArgs e)
        {
            txt_yr.SelectAll();
        }

        private void txtstuno_MouseClick(object sender, MouseEventArgs e)
        {
            txtstuno.SelectAll();
        }

        private void txtstuno_Enter(object sender, EventArgs e)
        {
            txtstuno.SelectAll();
        }

        private void txt_yr_Enter(object sender, EventArgs e)
        {
            txt_yr.SelectAll();
        }


        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstyrsonly frmfirst = new firstyrsonly();
            frmfirst.ShowDialog();
            if (frmfirst.tempstudents != "")
            {
                string tempstuno = Proxy.StudentInfo.GET_DETAILS_LIST(Global.Global.rescode, frmfirst.tempstudents);
                if (tempstuno != "")
                {
                    Student_Personal_Details.Reports frmreports = new Student_Personal_Details.Reports(tempstuno,"Detailed");
                    frmreports.Show();
                }
                else MessageBox.Show("There are no students to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        
        private void medicalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports_Medical.Reports frmreports = new Reports_Medical.Reports("Med_Aid", "*");
            frmreports.Show();
        }

        private void currentHouseCommToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("HOUSE_COMM", "*");
            frmreports.Show();
        }

        
        private void examReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Results", "*");
            frmreports.Show();
        }

        private void listOfStudentsExcludedOnAcademicGroundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Excluded", "*",Global.Global.rescode);
            frmreports.Show();
        }

        private void dPRefusedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DPR", "*");
            frmreports.Show();
        }

        private void resExamRankingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Ranking", "*");
            frmreports.Show();
        }

        private void racialDemographicsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Demographics", "*");
            frmreports.Show();
        }

        private void boxRoomSignInSignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Boxroom", "*");
            frmreports.Show();
        }
                
        private void arrivalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Arrivals", "*");
            frmreports.Show();
        }

        private void resResultsGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("ResPass", "*");
            frmreports.Show();
        }

        private void houseCommPhotosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("HOUSE_COMM_PHOTOS", "*");
            frmreports.Show();
        }

        private void studentPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstyrsonly frmfirst = new firstyrsonly();
            frmfirst.ShowDialog();
            if (frmfirst.tempstudents != "")
            {
                Reports frmreports = new Reports("Stu_Photos", frmfirst.tempstudents);
                frmreports.Show();
            }
        }

        private void intercomListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("INTERCOM_LIST", "*");
            frmreports.Show();
        }

        private void admissionsAllocatedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("stulist", "*");
            frmreports.Show();
        }

        private void resAccessInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void resAccessDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stanley.stanleyaccessreport frm_select = new Stanley.stanleyaccessreport();
            frm_select.ShowDialog();
        }

        private void vehicleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Vehicle", "*");
            frmreports.Show();
        }

        private void mailForwardingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("mail_forward", "*");
            frmreports.Show();
        }

        private void possibleLastExamDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("last_exam_dts", "*");
            frmreports.Show();
        }

        private void roomListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("room_list", "*");
            frmreports.Show();
        }

        private void departureToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Reports frmreports = new Reports("departures", "*");
            frmreports.Show();
        }

        private void leavingDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("leaving_dtes", "*");
            frmreports.Show();
        }

        private void nextYearsHouseCommToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            StudentLeadership frmLead = new StudentLeadership(DateTime.Today.Year + 1);
            frmLead.ShowDialog();                                   
        }

        private void aboutResSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about frmAbout = new about();
            frmAbout.ShowDialog();

        }

        private void viewTermsAndConditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tac frmtac = new tac(this, true);
            frmtac.ShowDialog();
        }

        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact frmContact = new Contact(Global.Global.hallcode, Global.Global.type);
            frmContact.ShowDialog();
        }

        private void thisYearsHouseCommToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentLeadership frmLead = new StudentLeadership(DateTime.Today.Year);
            frmLead.ShowDialog();          
        }

        private void doorLabelExtractforMailMergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DOOR_LABELS", "*");
            frmreports.Show();
        }

        private void juneWarningsForTheYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("JUNE_WARNING", "*");
            frmreports.Show();
        }

        private void studentsWhoHaveObtainedTheirDegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DEGREE_OBTAINED","*",Global.Global.rescode);
            frmreports.Show();
        }
                
        private void viewAFineUsingARefNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports_Disc.Reports frmreports = new Reports_Disc.Reports("VIEW_FINE_REF", "*");
            frmreports.Show();
        }

        private void studentsWhoHaveNotCompletedTheirFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close_Forms();
                Global.Global.ds_stuinfo = Proxy.StudentSearch.Res_Outstanding_Fines(Global.Global.rescode, Global.Global.hallcode, "All");
                rb_custom.Checked = false;
                rb_reslist.Checked = false;
                Load_Res_List_Form();
                disciplinaryInformationToolStripMenuItem.Checked = true;
                personalDetailsToolStripMenuItem.Checked = false;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void studentsWhoWereGivenAFineThisYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close_Forms();
                Global.Global.ds_stuinfo = Proxy.StudentSearch.Res_Fines_This_Year(Global.Global.rescode, Global.Global.hallcode);
                rb_custom.Checked = false;
                rb_reslist.Checked = false;
                Load_Res_List_Form();
                disciplinaryInformationToolStripMenuItem.Checked = true;
                personalDetailsToolStripMenuItem.Checked = false;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void wardensDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual frmManual = new Manual("1");
            frmManual.Show();
        }

        private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual frmManual = new Manual("2");
            frmManual.Show();
        }

        private void disciplinaryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalDetailsToolStripMenuItem.Checked =
                resultsToolStripMenuItem.Checked =
                medicalDetailsToolStripMenuItem.Checked = false;
            
            disciplinaryInformationToolStripMenuItem.Checked = true;
            PerformAction = true;
            Loadform();
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disciplinaryInformationToolStripMenuItem.Checked =
                resultsToolStripMenuItem.Checked =
                medicalDetailsToolStripMenuItem.Checked = false;
            
            personalDetailsToolStripMenuItem.Checked = true;
            PerformAction = true;
            Loadform();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalDetailsToolStripMenuItem.Checked = disciplinaryInformationToolStripMenuItem.Checked =
                medicalDetailsToolStripMenuItem.Checked = false;

            LoadNewStudentInfoForm(resultsToolStripMenuItem);
        }

        private void medicalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Medical Details! What medical details?", "Medical Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            personalDetailsToolStripMenuItem.Checked =
                disciplinaryInformationToolStripMenuItem.Checked =
                resultsToolStripMenuItem.Checked = false;

            LoadNewStudentInfoForm(medicalDetailsToolStripMenuItem);
        }

        private void LoadNewStudentInfoForm(ToolStripMenuItem menuItem)
        {
            menuItem.Checked = true;
            PerformAction = true;
            Loadform();
        }

        private void customReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criteria.Criteria frmCriteria = new Criteria.Criteria("Custom", string.Empty);
            frmCriteria.Show();
        }

        private void resAccessExceptionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempvalue = Global.Global.rescode.ToString();
            if (tempvalue == "999") tempvalue = "*";
            ds_exceptions = Proxy.Stanley.Res_Stanley_Update_List("R", tempvalue);
            if (ds_exceptions.ttresfile.Rows.Count < 1)
            {
                MessageBox.Show("Your query returned no results", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Stanley.ReportForm.StanReportForm stan_reports = new Stanley.ReportForm.StanReportForm("AccessException", Global.Global.resname, "",ds_exceptions);
                stan_reports.Show();
            }
        }

        private void passedAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("PassedAll", "*",Global.Global.rescode);
            frmreports.Show();
        }

        private void failedAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("FailedAll", "*",Global.Global.rescode);
            frmreports.Show();
        }

        private void attainedADistinctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Distinction","*" ,Global.Global.rescode);
            frmreports.Show();
        }

        private void stanleyExceptionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stanley.StanleyAccessControl.HallResSelect frm_select = new Stanley.StanleyAccessControl.HallResSelect(true);
            frm_select.ShowDialog();
        }

        private void roomlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("RoomList", "R");
            frmreports.Show();
        }

        private void studentsWhoHaveNotCompletedTheirFinesNowOverdueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close_Forms();
                Global.Global.ds_stuinfo = Proxy.StudentSearch.Res_Outstanding_Fines(Global.Global.rescode, Global.Global.hallcode, "Overdue");
                rb_custom.Checked = false;
                rb_reslist.Checked = false;
                Load_Res_List_Form();
                disciplinaryInformationToolStripMenuItem.Checked = true;
                personalDetailsToolStripMenuItem.Checked = false;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Time_Table", "*");
            frmreports.Show();
        }

        private void addressListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("OppiAddresses", "*");
            frmreports.Show();
        }

        private void addressEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OppiSearch frm_search_oppi = new OppiSearch();
            frm_search_oppi.ShowDialog();
                              
        }

        private void residenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("RESHISTORY", "*");
            frmreports.Show();
           
        }



        private void previousYearsListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Reports frmreports = new Reports("PREVYRS", "*");
            frmreports.Show();
        }
        private void emergencyListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("EMERGENCYLIST", "*");
            frmreports.Show();
        }
       
        private void doubleRoomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DOUBLER", "*");
            frmreports.Show();

        }
        private void emailListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            firstyrsonly frmfirst = new firstyrsonly();
            frmfirst.ShowDialog();
            if (frmfirst.tempstudents != "")
            {
                Reports frmreports = new Reports("EMAILLIST", frmfirst.tempstudents);
                frmreports.Show();
            }
        }

        private void oldResStudentsStillAtRhodesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Alumni", "*");
            frmreports.Show(); 
        }

        void txt_yr_TextChanged(object sender, System.EventArgs e)
        {
            if (txt_yr.MaskCompleted && txt_yr.Text.Length.Equals(4))
                Global.Global.tempyr = int.Parse(txt_yr.Text.Trim());
        }

        #region Labels

        private void customLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string templateFile = string.Concat(Properties.Settings.Default.LetterTemplateDirectory, @"\Labels.doc");
            //string outputFile = string.Concat(Properties.Settings.Default.LetterOutputDirectory, @"\Labels.doc");
            //Labels.AdhocLabels labels = new Labels.AdhocLabels(new DataView(Global.Global.ds_stuinfo.tt_student_info), templateFile, outputFile);
            //labels.ShowDialog();

            Labels.AdhocLabels labels = new Labels.AdhocLabels(new DataView(Global.Global.ds_stuinfo.tt_student_info), Properties.Settings.Default.LetterTemplateDirectory, Properties.Settings.Default.LetterOutputDirectory);
            labels.ShowDialog();
        }

        private void resLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string templateFile = string.Concat(Properties.Settings.Default.LetterTemplateDirectory, @"\Labels.doc");
            string outputFile = string.Concat(Properties.Settings.Default.LetterOutputDirectory, @"\Labels.doc");
            LabelAddress labelAddress = new LabelAddress(templateFile, outputFile);
            labelAddress.ShowDialog();
        }

        private void letterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Honours.LetterSettings settings = new Honours.LetterSettings(Properties.Settings.Default.LetterTemplateDirectory, Properties.Settings.Default.LetterOutputDirectory);
            if (settings.ShowDialog().Equals(DialogResult.OK))
            {
                Properties.Settings.Default.LetterTemplateDirectory = settings.TempDir;
                Properties.Settings.Default.LetterOutputDirectory = settings.OutputDir;
            }
        }

        private void hallLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string templateFile = string.Concat(Properties.Settings.Default.LetterTemplateDirectory, @"\Labels.doc");
            string outputFile = string.Concat(Properties.Settings.Default.LetterOutputDirectory, @"\Labels.doc");
            LabelAddress labelAddress = new LabelAddress(templateFile, outputFile);
            labelAddress.ShowDialog();
        }

        private void adhocLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // string templateFile = string.Concat(Properties.Settings.Default.LetterTemplateDirectory, @"\Labels.doc");
          //  string outputFile = string.Concat(Properties.Settings.Default.LetterOutputDirectory, @"\Labels.doc");
            //Labels.AdhocLabels labels = new Labels.AdhocLabels(new DataView(Global.Global.ds_stuinfo.tt_student_info), Global.Global.templatefile, Global.Global.ouputfile);
            //labels.ShowDialog();
        }

        #endregion

        private void summaryReportByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryReport frm_summary = new SummaryReport();
            frm_summary.ShowDialog();
        }

        private void doubleRoomsAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DOUBLE_ALLOCATION", "*");
            frmreports.Show();
        }

      
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("PassedAll", Global.Global.hallcode,999);
            frmreports.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DEGREE_OBTAINED",Global.Global.hallcode,999);
            frmreports.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("FailedAll", Global.Global.hallcode,999);
            frmreports.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Excluded", Global.Global.hallcode,999);
            frmreports.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Distinction",Global.Global.hallcode,999);
            frmreports.Show();
        }

        private void studentsWhoHaveAttainedFullDistinctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DistinctionAll", "*", Global.Global.rescode);
            frmreports.Show();
        }

      
        private void studentsWhoHaveAttainedFullDistinctionsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DistinctionAll", Global.Global.hallcode, 999);
            frmreports.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("PassRate", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Stanley.StanleyAccessControl.HallResSelect frm_select = new Stanley.StanleyAccessControl.HallResSelect(true);
            frm_select.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ds_exceptions = Proxy.Stanley.Res_Stanley_Update_List("H", Global.Global.hallcode.ToString());
            if (ds_exceptions.ttresfile.Rows.Count < 1)
            {
                MessageBox.Show("Your query returned no results", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Stanley.ReportForm.StanReportForm stan_reports = new Stanley.ReportForm.StanReportForm("AccessException", Global.Global.hallname, "", ds_exceptions);
                stan_reports.Show();
            }
        }

        private void examRankingsForStudentsByHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Ranking", "hall");
            frmreports.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("HALL_COMM_PHOTOS", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Demographics", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Vehicle", "*");
            frmreports.Show();
        }


        private void extendedStudiesStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("EXTENDED_STUDIES", "*");
            frmreports.Show();
        }

        private void extendedStudiesStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("EXTENDED_STUDIES", "*");
            frmreports.Show();
        }

        private void medicalAidDoctorsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void studentMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tempyr = DateTime.Today.Year;
            string subj = "*";
            int tempres = Global.Global.rescode;


            Res_System.SearchOptions.PickSemester frmSemester = new Res_System.SearchOptions.PickSemester();
            
            if (frmSemester.ShowDialog().Equals(DialogResult.OK))
            {
                string tempsemester =  frmSemester.Semester;
                bool temppublished = true;

                NS_Dept.StrongTypesNS.ds_subject_marksDataSet ds_report = Proxy.StudentDepartment.subject_marks(tempyr, tempsemester, subj, tempres, temppublished,"*","*",0);
                if (ds_report.tt_stuclassmk.Rows.Count > 0)
                {
                    Reports rpt = new Reports("StuMarks", ds_report);
                    rpt.Show();
                }
                else MessageBox.Show("Error No Data To Display", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res_System.Updates.ResEvents.ResFunctions frmFunctions = new Res_System.Updates.ResEvents.ResFunctions(Global.Global.rescode);
            frmFunctions.ShowDialog();
        }

        private void blockedRoomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NS_Conference.StrongTypesNS.ds_rooms_reportDataSet ds_report = Proxy.ConferenceSystem.conference_blocked_rooms_report(Global.Global.hallcode,999);
            if (ds_report.TT_ROOMS.Count > 0)
            {
                DataView dvData = new DataView(ds_report.TT_ROOMS);

                ConferenceSys.Reports frmReports = new ConferenceSys.Reports(false,"BlockedReport", dvData, "Blocked Room Report");
                frmReports.Show();
            }
            else MessageBox.Show("Error - There is no data to display", "Error No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Birthdays", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("EMERGENCYLIST", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("MEDAIDDOCTORS", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("MEDLIST", "*");
            frmreports.Show();

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            NS_Conference.StrongTypesNS.ds_rooms_reportDataSet ds_report = Proxy.ConferenceSystem.conference_blocked_rooms_report(Global.Global.hallcode, Global.Global.rescode);
            if (ds_report.TT_ROOMS.Count > 0)
            {
                DataView dvData = new DataView(ds_report.TT_ROOMS);

                ConferenceSys.Reports frmReports = new ConferenceSys.Reports(false,"BlockedReport", dvData, "Blocked Room Report");
                frmReports.Show();
            }
            else MessageBox.Show("Error - There is no data to display", "Error No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("DEPARTURE_LIST", "*");
            frmreports.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Phone_Nos", "*");
            frmreports.Show();
        }

        private void resVacationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResSystem.Updates.res_vac frmVac = new ResSystem.Updates.res_vac();
            frmVac.ShowDialog();

        }

        private void hallVacationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Res_System.SearchOptions.SearchDates frmDates = new Res_System.SearchOptions.SearchDates();
            frmDates.ShowDialog();
            if (frmDates.proceed)
            {
                NS_ResSystem.StrongTypesNS.ds_res_vacDataSet rd_vac_report = Proxy.Res_System.get_resvac_report(Global.Global.hallcode,999, frmDates.DateFrom, frmDates.DateTo);
                if (rd_vac_report.tt_res_vac.Count > 0)
                {
                    DataView dvReport = new DataView(rd_vac_report.tt_res_vac);
                    Res_System.FunctionReports frmReport = new Res_System.FunctionReports("ResVac", dvReport);
                    frmReport.Show();
                }
                else MessageBox.Show("There are no Residence Vacation records to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("ATTENDANCE_REGISTER", "*");
            frmreports.Show();
        }

        private void subwardensResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectYear frmYear = new SelectYear();
            frmYear.ShowDialog();

            if (frmYear.proceed)
            {

                NS_ResSystem.StrongTypesNS.ds_warden_resultsDataSet ds_results = Proxy.Res_System.subwardens_results(Global.Global.hallcode, frmYear._tempyr);

                if (ds_results.tt_warden_results.Count > 0)
                {
                    string tempTitle = string.Empty;
                    
                    DataView dvFebSupp = new DataView(ds_results.tt_warden_results);
                    dvFebSupp.RowFilter = "FEB_SUPP = 'Y'";                    
                    if (dvFebSupp.Count > 0)
                    {
                        tempTitle = "Subwardens in " + (frmYear._tempyr).ToString() + " who have more than 1 February supp";
                        Reports frmreports = new Reports("WardensResults", dvFebSupp,tempTitle);
                        frmreports.Show();
                    }

                    DataView dvCredFail = new DataView(ds_results.tt_warden_results);
                    dvCredFail.RowFilter = "CRED_FAIL = 'Y'";
                    if (dvFebSupp.Count > 0)
                    {
                        tempTitle = "Subwardens in " + (frmYear._tempyr).ToString() + " who have failed more than one credit";
                        Reports frmreports = new Reports("WardensResults", dvCredFail, tempTitle);
                        frmreports.Show();
                    }

                    DataView dvNone = new DataView(ds_results.tt_warden_results);
                    dvNone.RowFilter = "NONE_1 = 'Y'";
                    if (dvFebSupp.Count > 0)
                    {
                        tempTitle = "Subwardens in " + (frmYear._tempyr).ToString() + " who have failed less than 2 credits and have less than 2 Feb supps";
                        Reports frmreports = new Reports("WardensResults", dvNone, tempTitle);
                        frmreports.Show();
                    }


                }
                else MessageBox.Show("Your query returned no data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void opToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOPS.ResidentialOperations.OppidanDiningHalls frmOppidan = new IOPS.ResidentialOperations.OppidanDiningHalls();
            frmOppidan.ShowDialog();
        }

        private void hallLeadershipPortfolioListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string feedback = string.Empty;

            NS_ResSystem.StrongTypesNS.DS_HOUSECOMMDataSet ds_housecomm = Proxy.Res_System.Fetch_House_Comm(Global.Global.hallcode, Global.Global.rescode, DateTime.Today.Year + 1, out feedback);
            DataView dvStudentLeaders = new DataView(ds_housecomm.tt_house_comm);

            if (ds_housecomm.tt_house_comm.Rows.Count > 0)
            {
                DataView dv_housecomm = new DataView(ds_housecomm.tt_house_comm);
                Reports frmreports = new Reports("HALLCOMM_LIST", dv_housecomm, DateTime.Today.Year + 1);
                frmreports.Show();

            }

        }

        private void hallLeadershipByPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedback = string.Empty;

            NS_ResSystem.StrongTypesNS.DS_HOUSECOMMDataSet ds_housecomm = Proxy.Res_System.Fetch_House_Comm_Port(Global.Global.hallcode, Global.Global.rescode, DateTime.Today.Year, out feedback);
            DataView dvStudentLeaders = new DataView(ds_housecomm.tt_house_comm);

            if (ds_housecomm.tt_house_comm.Rows.Count > 0)
            {
                DataView dv_housecomm = new DataView(ds_housecomm.tt_house_comm);
                Reports frmreports = new Reports("HALLCOMM_LIST_PORT", dv_housecomm, DateTime.Today.Year);
                frmreports.Show();

            }

        }

        private void NextHallLeadershipByPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedback = string.Empty;

            NS_ResSystem.StrongTypesNS.DS_HOUSECOMMDataSet ds_housecomm = Proxy.Res_System.Fetch_House_Comm_Port(Global.Global.hallcode, Global.Global.rescode, DateTime.Today.Year + 1, out feedback);
            DataView dvStudentLeaders = new DataView(ds_housecomm.tt_house_comm);

            if (ds_housecomm.tt_house_comm.Rows.Count > 0)
            {
                DataView dv_housecomm = new DataView(ds_housecomm.tt_house_comm);
                Reports frmreports = new Reports("HALLCOMM_LIST_PORT", dv_housecomm, DateTime.Today.Year + 1);
                frmreports.Show();

            }
        }

        private void hallLeadershipByResToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedback = string.Empty;

            NS_ResSystem.StrongTypesNS.DS_HOUSECOMMDataSet ds_housecomm = Proxy.Res_System.Fetch_House_Comm(Global.Global.hallcode, Global.Global.rescode, DateTime.Today.Year, out feedback);
            DataView dvStudentLeaders = new DataView(ds_housecomm.tt_house_comm);

            if (ds_housecomm.tt_house_comm.Rows.Count > 0)
            {
                DataView dv_housecomm = new DataView(ds_housecomm.tt_house_comm);
                Reports frmreports = new Reports("HALLCOMM_LIST", dv_housecomm, DateTime.Today.Year);
                frmreports.Show();

            }
        }

        private void bannedOppidansToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hallBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void academicReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bannedOppidansToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }   
     

        }
    }
