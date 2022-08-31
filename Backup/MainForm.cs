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

namespace Res_System
{
    public partial class MainForm : Form
    {
        public bool agreed = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        public static Student_Search frmstuQuery = new Student_Search();
        public string allres = "";
        

        Loading ShowLoading;
        ResList ShowResList;
        Student_Personal_Details.StudentsPersonalDetails StuPersonal;
        Discipline_Screen.StudentsPersonalDetails frmDisc;
        Student_Results.StudentResults frmStuResults;
        Student_Medical.StudentMedicalDetails frmMedicalDetails;
        
        public bool PerformAction = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Load_Crest()
        {
            try
            {
                string tempres = "";
                if (((Item)cbres.SelectedItem).Value != "999") tempres = ((Item)cbres.SelectedItem).Value.ToString();
                else tempres = (((Item)cb_hall.SelectedItem).Value.ToString()).ToLower();
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
                                /*
                                Bitmap bmp = new Bitmap(stmBLOBData);
                                bmp.Save("C:\\bla.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                 */
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
                    if (Global.Global.ds_stuinfo.tt_stuinfo.Rows.Count == 200) MessageBox.Show("A maximum of 200 student records have been returned. Please refine your search criteria to be more specific", "Max Records Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load_Student();

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
                    //personalDetailsToolStripMenuItem.Checked = resultsToolStripMenuItem.Checked = false;

                    StuPersonal.Hide();
                    frmStuResults.Hide();
                    frmMedicalDetails.Hide();

                    frmDisc.Show();
                    frmDisc.Refresh_Data();
                }

                if (personalDetailsToolStripMenuItem.Checked == true)
                {
                    //disciplinaryInformationToolStripMenuItem.Checked = resultsToolStripMenuItem.Checked = false;
                    
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
                bool validlogin = AppServer.AppServer.initial_Login(Proxy.Info.username, false, "resg001", true, "Res_System");
                if (validlogin == true)
                {
                    txt_yr.Text = DateTime.Today.Year.ToString();

                    toolStripStatusLabel1.Text = "LOGGED IN AS: " + Proxy.Info.username + " - "
                    + Proxy.Info.fullname + " SINCE " + DateTime.Now;

                    Global.Global.tempstu = "";

                    if (Proxy.Info.student == true)
                    {
                        string feedback = "";
                        int tempres = 0;
                        string temphall = "";
                        Proxy.StudentInfo.Check_Sub_Warden(Proxy.Info.username, out feedback, out tempres, out temphall);

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

                        int tempres = 999;
                        string temphall = "";
                        string temptype = "";

                        string feedback = Proxy.Res_System.Check_User_Level(Proxy.Info.username, out temptype, out tempres, out temphall, out allres);

                        if (feedback != "")
                        {
                            MessageBox.Show(feedback, "Residence System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Close();
                        }
                        else
                        {
                            Global.Global.rescode = tempres;
                            Global.Global.hallcode = temphall;
                            Global.Global.type = temptype;

                        }
                    }

                    int sendres = Global.Global.rescode;
                    if (Global.Global.type != "SW") sendres = 0;
                    Global.Global.ds_Stu = Proxy.System.Get_Reg_Stu_By_Res(sendres);

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

                    if (agreed == false) this.Close();
                    if (agreed == true)
                    {
                        if (Global.Global.hallcode != "")
                        {
                            Res_System.Properties.Settings.Default.Start_Hall = Global.Global.hallcode;
                        }
                        if (Global.Global.rescode != 0 & Global.Global.type != "HH")
                        {
                            Res_System.Properties.Settings.Default.Start_Res = Global.Global.rescode.ToString();
                        }

                        int startindex = 0;
                        int index = 0;
                        string tempstr = Proxy.System.Get_Sleeping_Halls();
                        Global.Global.ds_rescodes = Proxy.System.Get_Res_Codes();
                        Global.Global.ds_badcodes = Proxy.StudentDiscipline.Get_Discipline_Codes();

                        string[] temphall = tempstr.Split(new char[] { '|' });
                        cb_hall.Enabled = false;
                        for (int intArray = 0; intArray < temphall.Length; intArray++)
                        {
                            cb_hall.Items.Add(new Item(temphall[intArray + 1], temphall[intArray]));
                            if (temphall[intArray] == Res_System.Properties.Settings.Default.Start_Hall) startindex = index;
                            index++;
                            intArray = intArray + 1;
                        }

                        cb_hall.SelectedIndex = startindex;
                        Global.Global.hallname = ((Item)cb_hall.SelectedItem).Name.ToString();
                        Global.Global.hallcode = ((Item)cb_hall.SelectedItem).Value.ToString();

                        if (Global.Global.type == "AD") cb_hall.Enabled = true;
                        if (Global.Global.type == "SW")
                        {
                            rb_custom.Enabled = false;
                            txtstuno.Enabled = false;
                            txt_yr.Enabled = false;
                            updatesToolStripMenuItem.Enabled = false;
                            resultsToolStripMenuItem.Enabled = false;
                        }
                        if (Global.Global.type != "SW")
                        {
                            disciplineReportsToolStripMenuItem.Enabled = true;
                            academicReportsToolStripMenuItem.Enabled = true;
                        }
                        Fill_Comboboxes();
                        Load_Crest();

                        ShowLoading = new Loading();
                        ShowLoading.MdiParent = this;
                        ShowLoading.Dock = DockStyle.Fill;
                        ShowLoading.Show();
                        timer1.Enabled = true;

                        nextYearsHouseCommToolStripMenuItem.Text = (DateTime.Today.Year + 1).ToString() + " " + "Leadership list";
                        thisYearsHouseCommToolStripMenuItem.Text = (DateTime.Today.Year).ToString() + " " + "Leadership list";
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        public void ShowResListForm()
        {
            try
            {
                Global.Global.position = 0;
                string typeres = "CURR";
                Global.Global.ds_stuinfo = Proxy.StudentSearch.Get_Students_In_Res(((Item)cb_hall.SelectedItem).Value,
                    ((Item)cbres.SelectedItem).Value, typeres, Int32.Parse(txt_yr.Text));
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
                int startindex = 0;
                int index = 1;
                string tempstr = Proxy.System.Get_Residences(((Item)cb_hall.SelectedItem).Value);

                string[] residence = tempstr.Split(new char[] { '|' });
                cbres.Enabled = false;
                cbres.Items.Clear();
                cbres.Items.Add(new Item("All Students in the hall", "999"));
                for (int intArray = 0; intArray < residence.Length; intArray++)
                {
                    if ((Global.Global.type == "HH" | Global.Global.type == "HA" | Global.Global.type == "AD") | Global.Global.rescode.ToString() == residence[intArray] | allres.Contains(residence[intArray]))
                    {
                        cbres.Items.Add(new Item(residence[intArray + 1], residence[intArray]));
                        if (residence[intArray] == Res_System.Properties.Settings.Default.Start_Res) startindex = index;
                        index++;
                    }
                    intArray = intArray + 1;
                }

                cbres.SelectedIndex = startindex;
                Global.Global.rescode = Int32.Parse(((Item)cbres.SelectedItem).Value.ToString());
                Global.Global.resname = ((Item)cbres.SelectedItem).Name.ToString();
                if (Global.Global.type != "SW") cbres.Enabled = true;

                if (((Item)cbres.SelectedItem).Value == "999")
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
                if (cbres.Enabled == true)
                {
                    Res_System.Properties.Settings.Default.Start_Res = ((Item)cbres.SelectedItem).Value;
                    Res_System.Properties.Settings.Default.Save();
                    Global.Global.rescode = Int32.Parse(((Item)cbres.SelectedItem).Value.ToString());
                    Global.Global.resname = ((Item)cbres.SelectedItem).Name.ToString();


                    ShowResListForm();

                    Load_Crest();

                    if (((Item)cbres.SelectedItem).Value == "999")
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
                    Global.Global.ds_stuinfo = new NS_Student_Search.StrongTypesNS.DS_STUINFODataSet();
                    Global.Global.custom = true;
                    frmstuQuery.ShowDialog();
                    Load_Res_List_Form();
                    rb_custom.Checked = false;
                    if (Global.Global.ds_stuinfo.ttresstu.Rows.Count == 200) MessageBox.Show("A maximum of 200 student records have been returned. Please refine your search criteria to be more specific", "Max Records Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (Global.Global.type != "SW") txt_yr.Enabled = true;
                Global.Global.custom = false;
                updatesToolStripMenuItem.Enabled = true;

            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_hall.Enabled == true)
            {
                Res_System.Properties.Settings.Default.Start_Hall = ((Item)cb_hall.SelectedItem).Value;
                Res_System.Properties.Settings.Default.Start_Res = "999";
                Res_System.Properties.Settings.Default.Save();
                Global.Global.hallname = ((Item)cb_hall.SelectedItem).Name.ToString();
                Global.Global.hallcode = ((Item)cb_hall.SelectedItem).Value.ToString();
                Fill_Comboboxes();

                

                ShowResListForm();

                Load_Crest();
               
            }
        }

        
        private void sectionsAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Res_System.Sections frmsections = new Res_System.Sections(((Item)cbres.SelectedItem).Name, ((Item)cbres.SelectedItem).Value);
            frmsections.ShowDialog();
        
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms frmrooms = new Rooms(((Item)cbres.SelectedItem).Name, ((Item)cbres.SelectedItem).Value);
            frmrooms.ShowDialog();
        }

        private void assignStudentsToRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Rooms frmAssign = new Assign_Rooms(((Item)cbres.SelectedItem).Name, ((Item)cbres.SelectedItem).Value);
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


        private void birthdayListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Birthdays","*");
            frmreports.Show();
        }

        private void phoneNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Phone_Nos","*");
            frmreports.Show();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Stu_Info","*");
            frmreports.Show();
        }

        private void resFunctionRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Stu_Diet","*");
            frmreports.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Close the loading form
            timer1.Enabled = false;
            ShowLoading.Close();

            //Show list of students;
            ShowResList = new Res_System.ResList(this);
            ShowResList.MdiParent = this;
            ShowResList.Dock = DockStyle.Fill;
            ShowResListForm();
            ShowResList.Show();

            //Load the Personal Details Form;
            StuPersonal = new Student_Personal_Details.StudentsPersonalDetails();
            StuPersonal.MdiParent = this;
            StuPersonal.Dock = DockStyle.Fill;

            //Load the Discipline Form
            frmDisc = new Discipline_Screen.StudentsPersonalDetails();
            frmDisc.MdiParent = this;
            frmDisc.Dock = DockStyle.Fill;

            //Load the Student Results Form
            frmStuResults = new Student_Results.StudentResults();
            frmStuResults.MdiParent = this;
            frmStuResults.Dock = DockStyle.Fill;

            //Load the Medical Details Form
            frmMedicalDetails = new Student_Medical.StudentMedicalDetails();
            frmMedicalDetails.MdiParent = this;
            frmMedicalDetails.Dock = DockStyle.Fill;
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
            Reports frmreports = new Reports("Excluded", "*");
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

        private void oldResStudentsStillAtRhodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Alumni", "*");
            frmreports.Show(); 
        }

        private void studentExamRankingsByHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Ranking", "hall");
            frmreports.Show();
        }

        private void racialDemographicsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Demographics", "*");
            frmreports.Show();
        }

        private void hallDemographicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Demographics", "*");
            frmreports.Show();
        }

        private void hallCommPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("HALL_COMM_PHOTOS", "*");
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

        private void examPassRateGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("PassRate", "*");
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
            Reports frmreports = new Reports("Stu_Photos", "*");
            frmreports.Show();
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
            Reports frmreports = new Reports("DEPARTURE_LIST", "*");
            frmreports.Show();
        }

        private void resAccessDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Stanley_List", "*");
            frmreports.Show();
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

        private void studentRegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            Contact frmcontact = new Contact();
            frmcontact.ShowDialog();
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
            Reports frmreports = new Reports("DEGREE_OBTAINED", "*");
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

        private void hallAccessExceptionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Reports frmreports = new Reports("AccessException", "H");
            frmreports.Show();
        }

        private void resAccessExceptionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("AccessException", "R");
            frmreports.Show();
        }

        private void passedAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("PassedAll", "R");
            frmreports.Show();
        }

        private void failedAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("FailedAll", "R");
            frmreports.Show();
        }

        private void attainedADistinctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Distinction", "R");
            frmreports.Show();
        }

        private void stanleyExceptionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("StanExceptions", "R");
            frmreports.Show();
        }

        private void vehicleListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports frmreports = new Reports("Vehicle", "*");
            frmreports.Show();
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

        
    }
}