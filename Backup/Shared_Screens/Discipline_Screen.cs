using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;


namespace Discipline_Screen
{
    public partial class StudentsPersonalDetails : Form
    {
        
        public StudentsPersonalDetails()
        {
            InitializeComponent();
        }
                
        
        public string PerformAction;
        public int totalfines;
        public int finenumber;
        public int position;
        public string codechosen = "";
        public string descripchosen = "";
        public string badcat = "";
        public string test;
        
        public static NS_Discipline.StrongTypesNS.DS_STUBADDataSet ds_stubad = new NS_Discipline.StrongTypesNS.DS_STUBADDataSet();

        public void Refresh_Data()
        {

            tabControl2.SelectedIndex = 0;

            try
            {
                ds_stubad = Proxy.StudentDiscipline.Get_Discipline(Global.Global.tempstu, "", out finenumber, out totalfines);


                if (ds_stubad.tt_stubad.Rows.Count == 0) panel5.Visible = false;
                else panel5.Visible = true;

                tt_stubadBindingSource.DataSource = ds_stubad.tt_stubad;

                panel2.Visible = true;


                if (ds_stubad.tt_stubad.Rows.Count == 0)
                {
                    txt_fines.Text = "Student Has No Hearings";
                    position = 0;
                    btn_prev.Enabled = false;
                    btn_next.Enabled = false;
                }


                else
                {
                    txt_fines.Text = "Hearing 1 of " + ds_stubad.tt_stubad.Rows.Count.ToString();
                    position = 1;
                    btn_prev.Enabled = true;
                    btn_next.Enabled = true;
                }

                if (Global.Global.type == "RO") btn_add.Enabled = false;
                else btn_add.Enabled = true;
                
                disc_readonly();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void StudentsPersonalDetails_Load(object sender, EventArgs e)
        {

            tt_badcodes.DataSource = Global.Global.ds_rescodes;
            tt_badcodes2.DataSource = Global.Global.ds_rescodes;
            
            DataView dv_authority = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_authority.RowFilter = "type = 'DA'";
            tt_position.DataSource = dv_authority;

            DataView dv_hearing = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_hearing.RowFilter = "type = 'DH'";
            tt_hearing.DataSource = dv_hearing;

            DataView dv_other = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_other.RowFilter = "type = 'DS'";
            tt_secon_source.DataSource = dv_other;
            tt_second_source2.DataSource = dv_other;

            DataView dv_verdict = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_verdict.RowFilter = "type = 'DV'";
            tt_verdict.DataSource = dv_verdict;
            tt_verdict2.DataSource = dv_verdict;


            DataView dv_excl = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_excl.RowFilter = "type = 'D1'";
            tt_exclusion.DataSource = dv_excl;

            DataView dv_period = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_period.RowFilter = "type = 'D2'";
            tt_period.DataSource = dv_period;
            tt_period2.DataSource = dv_period;
            tt_period3.DataSource = dv_period;

            DataView dv_disc_from = new DataView(Global.Global.ds_rescodes.TT_GEN);
            dv_disc_from.RowFilter = "type = 'DA_FROM'";
            tt_disc_from.DataSource = dv_disc_from;
                        
            cb_verdict.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "verdict1" , false, DataSourceUpdateMode.OnPropertyChanged));
            cb_verdict2.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "verdict2", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_trial_type.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "trial_type" , false, DataSourceUpdateMode.OnPropertyChanged));
            cb_offence.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "offence_cat1", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_offence2.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "offence_cat2", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_other1.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "other_source_type1", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_other2.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "other_source_type2", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_exclusion.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "exclusion" , false, DataSourceUpdateMode.OnPropertyChanged));
            cb_excl_suspended.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "excl_period" , false, DataSourceUpdateMode.OnPropertyChanged));
            cb_comp_suspended.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "serv_suspension_period", false, DataSourceUpdateMode.OnPropertyChanged));
            cb_fine_suspended.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "fine_suspension_period" , false, DataSourceUpdateMode.OnPropertyChanged));
            cb_auth_res.DataBindings.Add(new Binding("SelectedValue", tt_stubadBindingSource, "guilty_by_from", false, DataSourceUpdateMode.OnPropertyChanged));
            
            Refresh_Data();
            
        }

        private void FineButtons()
        {
            panel2.Visible = true;           
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void bt_next_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds_stubad = Proxy.StudentDiscipline.Get_Discipline(Global.Global.tempstu, txtdiscref.Text, out finenumber, out totalfines);
                FineButtons();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void btn_prev_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds_stubad = Proxy.StudentDiscipline.Get_Discipline(Global.Global.tempstu, "", out finenumber, out totalfines);
                FineButtons();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        
        private void btn_disc_save_Click(object sender, EventArgs e)
        {
            try
            {
                string feedback = "";
                string reference = @txtdiscref.Text;
                bool alldone = false;

                Proxy.StudentDiscipline.Save_Discipline(ds_stubad, Global.Global.type, Global.Global.tempstu, ref reference, Proxy.Info.username, out feedback, out alldone);

                if (feedback.StartsWith("Saved") | feedback.StartsWith("Discipline details for"))
                {
                    btn_prev.Enabled = true;
                    btn_next.Enabled = true;
                    disc_readonly();
                    btn_add.Enabled = true;
                    txtdiscref.Text = reference;
                    cbdiscpenaltycomplete.Checked = alldone;
                    MessageBox.Show(feedback, "Student Discipline Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(feedback, "Student Discipline Record", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                string feedback = "";

                ds_stubad = Proxy.StudentDiscipline.New_Hearing(Global.Global.tempstu, Global.Global.type, out feedback);

                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Create new record", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    panel5.Visible = true;
                    disc_readonly();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            disc_readonly();
        }

        private void disc_readonly()
        {
            if (Global.Global.type != "RO")
            {
                if ((Global.Global.type == "AD") | (Proxy.Info.username.ToLower() == txt_Createdby.Text.ToLower()) | (txtdiscref.Text == ""))
                {
                    for (int intIndex = 0; intIndex < tb_offence.Controls.Count; intIndex++)
                    {
                        if (tb_offence.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_offence.Controls[intIndex].Enabled = true; }
                    }

                    for (int intIndex = 0; intIndex < tb_penalty.Controls.Count; intIndex++)
                    {
                        if (tb_penalty.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_penalty.Controls[intIndex].Enabled = true; }
                    }

                    for (int intIndex = 0; intIndex < tb_charge1.Controls.Count; intIndex++)
                    {
                        if (tb_charge1.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_charge1.Controls[intIndex].Enabled = true; }
                    }

                    for (int intIndex = 0; intIndex < tb_charge2.Controls.Count; intIndex++)
                    {
                        if (tb_charge2.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_charge2.Controls[intIndex].Enabled = true; }
                    }
                    btn_disc_save.Enabled = true;
                    btn_duplicate.Enabled = true;
                    btn_print_summons.Enabled = true;
                    btn_print_fine.Enabled = true;
                    tabControl3.Enabled = true;

                    if (ds_stubad.tt_stubad.Rows.Count > 0)
                    {
                        int temposition = position - 1;
                        if (temposition <= 0) temposition = 0;
                        if (ds_stubad.tt_stubad[temposition]["complete_dte1"].ToString() != "") cb_hours1.Enabled = true;
                        else cb_hours1.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["complete_dte2"].ToString() != "") cb_hours2.Enabled = true;
                        else cb_hours2.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["pay_by"].ToString() != "") cb_fine_compl.Enabled = true;
                        else cb_fine_compl.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["add_fine_by"].ToString() != "") cb_add_compl.Enabled = true;
                        else cb_add_compl.Enabled = false;
                    }

                    cbdiscpenaltycomplete.Enabled = false;
                    txt_completedhrs.Enabled = true;
                    dte_completeddte.Enabled = true;
                    txtdiscpen.Enabled = false;
                    txtdiscref.Enabled = false;
                    hallTextBox.Enabled = false;
                    txt_capture_by.Enabled = false;
                    pnl_sanction.Enabled = false;

                    //Only hall wardens, hall admins, and admins, and registrars can exclude 
                    if (!(Global.Global.type == "HA" | Global.Global.type == "AD" | Global.Global.type == "HH" | Global.Global.type == "PR"))
                    {
                        cb_exclusion.Enabled = false;
                        cb_excl_suspended.Enabled = false;
                    }

                    //Only certain people are allowed to update the complete indicators
                    bool update_sanction = Proxy.StudentDiscipline.Can_Complete_Indicator(txtdiscref.Text, Global.Global.type);
                    if (update_sanction == true) pnl_sanction.Enabled = true;

                    if (Global.Global.type == "SW" | Global.Global.type == "LA" | Global.Global.type == "PR")
                    {
                        cb_position.Enabled = false;
                        cb_auth_res.Enabled = false;
                    }
                    if (Global.Global.type == "SW") txtdiscguiltyby.Enabled = false;
                }

                else
                {
                    for (int intIndex = 0; intIndex < tb_offence.Controls.Count; intIndex++)
                    {
                        if (tb_offence.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_offence.Controls[intIndex].Enabled = false; }
                    }

                    for (int intIndex = 0; intIndex < tb_penalty.Controls.Count; intIndex++)
                    {
                        if (tb_penalty.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_penalty.Controls[intIndex].Enabled = false; }
                    }

                    for (int intIndex = 0; intIndex < tb_charge1.Controls.Count; intIndex++)
                    {
                        if (tb_charge1.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_charge1.Controls[intIndex].Enabled = false; }
                    }

                    for (int intIndex = 0; intIndex < tb_charge2.Controls.Count; intIndex++)
                    {
                        if (tb_charge2.Controls[intIndex].Name.StartsWith("label")) { }
                        else { tb_charge2.Controls[intIndex].Enabled = false; }
                    }

                    btn_disc_save.Enabled = false;
                    btn_duplicate.Enabled = false;
                    btn_print_summons.Enabled = true;
                    btn_print_fine.Enabled = true;
                    btn_print_service.Enabled = true;
                    tabControl3.Enabled = true;
                    cb_hours1.Enabled = false;
                    pnl_sanction.Enabled = false;
                    cb_hours2.Enabled = false;
                    cb_fine_compl.Enabled = false;
                    cb_add_compl.Enabled = false;
                    cbdiscpenaltycomplete.Enabled = false;
                    txt_completedhrs.Enabled = false;
                    dte_completeddte.Enabled = false;
                    txtdiscpen.Enabled = false;
                    txt_capture_by.Enabled = false;

                    if (Global.Global.type == "HA" | Global.Global.type == "HH")
                    {
                        btn_disc_save2.Enabled = true;
                        btn_disc_save.Enabled = true;
                        int temposition = position - 1;
                        if (temposition <= 0) temposition = 0;
                        /* Hall Admins allowed to update discipline complete indicator only */
                        if (ds_stubad.tt_stubad[temposition]["complete_dte1"].ToString() != "") cb_hours1.Enabled = true;
                        else cb_hours1.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["complete_dte2"].ToString() != "") cb_hours2.Enabled = true;
                        else cb_hours2.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["pay_by"].ToString() != "") cb_fine_compl.Enabled = true;
                        else cb_fine_compl.Enabled = false;
                        if (ds_stubad.tt_stubad[temposition]["add_fine_by"].ToString() != "") cb_add_compl.Enabled = true;
                        else cb_add_compl.Enabled = false;
                        txt_completedhrs.Enabled = true;
                        dte_completeddte.Enabled = true;
                    }

                    //Only certain people are allowed to update the complete indicators
                    bool update_sanction = Proxy.StudentDiscipline.Can_Complete_Indicator(txtdiscref.Text, Global.Global.type);
                    if (update_sanction == true) pnl_sanction.Enabled = true;
                }
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            disc_readonly();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            disc_readonly();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            disc_readonly();
        }

        private void bindingNavigatorPositionItem_Enter(object sender, EventArgs e)
        {
            disc_readonly();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (ds_stubad.tt_stubad.Count >= position + 1)
            {
                position = position + 1;
                dg_fines.FirstDisplayedScrollingRowIndex = position - 1;
                dg_fines.Refresh();

                dg_fines.CurrentCell = dg_fines.Rows[position - 1].Cells[0];
                dg_fines.Rows[position - 1].Selected = true;

                txt_fines.Text = "Hearing " + position.ToString() + " of " + ds_stubad.tt_stubad.Rows.Count.ToString();
                disc_readonly();
            }            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (position > 1)
            {
                position = position - 1;
                dg_fines.FirstDisplayedScrollingRowIndex = position - 1;
                dg_fines.Refresh();

                dg_fines.CurrentCell = dg_fines.Rows[position - 1].Cells[0];
                dg_fines.Rows[position - 1].Selected = true;
                //cb_auth_res.DataBindings.Add(new Binding("Text", tt_stubadBindingSource, "guilty_by_from", false, DataSourceUpdateMode.OnPropertyChanged));
                
                txt_fines.Text = "Hearing " + position.ToString() + " of " + ds_stubad.tt_stubad.Rows.Count.ToString();
                //cb_auth_res.Text = ds_stubad.tt_stubad[position - 1]["guilty_by_from"].ToString();
                disc_readonly();
            }          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string feedback = "";
                NS_Discipline.StrongTypesNS.DS_STUBADDataSet dsres = new NS_Discipline.StrongTypesNS.DS_STUBADDataSet();
                dsres = Proxy.StudentDiscipline.New_Hearing(Global.Global.tempstu, Global.Global.type, out feedback);

                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Create new record", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    DataRow newrow = dsres.tt_stubad[0];

                    ds_stubad.tt_stubad.ImportRow(newrow);
                    position = ds_stubad.tt_stubad.Rows.Count;
                    dg_fines.FirstDisplayedScrollingRowIndex = position - 1;
                    dg_fines.Refresh();

                    dg_fines.CurrentCell = dg_fines.Rows[position - 1].Cells[0];
                    dg_fines.Rows[position - 1].Selected = true;

                    txt_fines.Text = "Hearing " + position.ToString() + " of " + ds_stubad.tt_stubad.Rows.Count.ToString();
                    panel5.Visible = true;

                    disc_readonly();

                    btn_print_summons.Enabled = false;
                    btn_duplicate.Enabled = false;

                    dt_hearing_dte.Value = DateTime.Today;
                    dt_hearing_dte.Value = null;

                    dt_summons_dte.Value = DateTime.Today;
                    dt_summons_dte.Value = null;

                    dt_bad_dte1.Value = DateTime.Today;
                    dt_bad_dte1.Value = null;

                    dt_bad_dte2.Value = DateTime.Today;
                    dt_bad_dte2.Value = null;

                    dt_report_dte2.Value = DateTime.Today;
                    dt_report_dte2.Value = null;

                    dt_fine_notification.Value = DateTime.Today;
                    dt_fine_notification.Value = null;

                    dt_report_dte1.Value = DateTime.Today;
                    dt_report_dte1.Value = null;

                    dt_complete1.Value = DateTime.Today;
                    dt_complete1.Value = null;

                    dt_complete2.Value = DateTime.Today;
                    dt_complete2.Value = null;

                    dt_fine_pay.Value = DateTime.Today;
                    dt_fine_pay.Value = null;

                    dt_add_fine.Value = DateTime.Today;
                    dt_add_fine.Value = null;

                    btn_add.Enabled = false;
                    btn_prev.Enabled = false;
                    btn_next.Enabled = false;

                    cb_auth_res.SelectedIndex = 0;
                    tabControl3.SelectedIndex = 0;
                    tabControl2.SelectedIndex = 0;

                    txt_Createdby.Text = Proxy.Info.username;
                    txtdiscguiltyby.Text = Proxy.Info.fullname;
                    if (!(Global.Global.type == "LA" | Global.Global.type == "PR")) cb_auth_res.SelectedIndex = cb_auth_res.FindString(Global.Global.resname);
                    if (Global.Global.type == "LA") cb_auth_res.SelectedIndex = cb_auth_res.FindString("Library");
                    if (Global.Global.type == "PR") cb_auth_res.SelectedIndex = cb_auth_res.FindString("Proctors Hearing");

                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void btn_printfine_Click(object sender, EventArgs e)
        {

            Reports_Disc.Reports frmreports = new Reports_Disc.Reports("Summons", txtdiscref.Text);
            frmreports.Show();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string feedback = "";
                string reference = txtdiscref.Text;
                bool alldone = false;
                Proxy.StudentDiscipline.Save_Discipline(ds_stubad, Global.Global.type, Global.Global.tempstu, ref reference, Proxy.Info.username, out feedback, out alldone);

                if (feedback.StartsWith("Saved") | feedback.StartsWith("Discipline details for"))
                {
                    btn_prev.Enabled = true;
                    btn_next.Enabled = true;
                    btn_add.Enabled = true;
                    disc_readonly();
                    txtdiscref.Text = reference;
                    cbdiscpenaltycomplete.Checked = alldone;

                    MessageBox.Show(feedback, "Student Discipline Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(feedback, "Student Discipline Record", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }
        
        private void dt_summon_time_ValueChanged(object sender, EventArgs e)
        {
            txt_summons_time.Text = dt_summon_time.Value.TimeOfDay.TotalSeconds.ToString();            
        }

        private void dt_offence_time1_ValueChanged(object sender, EventArgs e)
        {
            txt_offence_time1.Text = dt_offence_time1.Value.TimeOfDay.TotalSeconds.ToString();
            
        }

        private void dt_offence_time2_ValueChanged(object sender, EventArgs e)
        {
            txt_offence_time2.Text = dt_offence_time2.Value.TimeOfDay.TotalSeconds.ToString();
            
        }

        private void txtdiscservicehours_Leave(object sender, EventArgs e)
        {
            try 
            {
                addhours();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtdiscservicehours.Focus();
            }
        }

        private void addhours()
        {
            txt_comp_hrs.Text = (Int32.Parse(txtdiscservicehours.Text) + Int32.Parse(txtdiscservicehours2.Text) + Int32.Parse(txt_suspended.Text)).ToString();
        }

        private void txtdiscservicehours2_Leave(object sender, EventArgs e)
        {
            try
            {
                addhours();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtdiscservicehours2.Focus();
            }


        }

        private void txt_suspended_Leave(object sender, EventArgs e)
        {
            try
            {
                addhours();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_suspended.Focus();
            }
        }

        private void fine_amtTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                addfine();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                fine_amtTextBox.Focus();
            }
        }

        private void txt_fine_amt_suspended_Leave(object sender, EventArgs e)
        {
            try
            {
                addfine();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_fine_amt_suspended.Focus();
            }
        }

        private void txt_fine_additional_Leave(object sender, EventArgs e)
        {
            try
            {
                addfine();
            }
            catch
            {
                MessageBox.Show("Only enter numbers into this field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_fine_additional.Focus();
            }
        }

        private void addfine()
        {
            txt_fine_total.Text = (Int32.Parse(fine_amtTextBox.Text) - Int32.Parse(txt_fine_amt_suspended.Text) + Int32.Parse(txt_fine_additional.Text)).ToString();            
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl2.SelectedIndex == 1)
                {
                    bool checkguilt = false;
                    checkguilt = Proxy.StudentDiscipline.Check_Guilt_By_Ref(Global.Global.tempstu, txtdiscref.Text);

                    if (checkguilt == false)
                    {
                        tabControl2.SelectedIndex = 0;
                        MessageBox.Show("The student was not found guilty, therefore no sanction", "Sanction Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void txt_sdc2_MouseClick(object sender, MouseEventArgs e)
        {
                        
            Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp("SDC");
            frmCodes.ShowDialog();
            try
            {
                if (frmCodes.Code != null) {
                    txt_sdc2.Text = frmCodes.Code;
                    if (txt_AOG2.Text == "")
                    {
                        txt_descrip2.Text = frmCodes.Descrip;
                        try
                        {
                            cb_offence2.SelectedValue = frmCodes.Category;
                        }
                        catch { }
                    }
                }
            }
            catch
            {
            }            
        }

        private void txt_sdc1_MouseClick(object sender, MouseEventArgs e)
        {

            Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp("SDC");
            frmCodes.ShowDialog();
            try
            {
                if (frmCodes.Code != null)
                {
                    txt_sdc1.Text = frmCodes.Code;
                    if (txt_AOG1.Text == "")
                    {
                        txt_descrip.Text = frmCodes.Descrip;
                        try
                        {
                            cb_offence.SelectedValue = frmCodes.Category;
                        }
                        catch { }
                    }
                }
            }
            catch
            {
            }            
        }

        private void txt_AOG1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (cb_trial_type.SelectedValue.ToString() == "AG" | cb_trial_type.SelectedValue.ToString() == "LA")
                {
                    string tempstr = "AOG";
                    if (cb_trial_type.SelectedValue.ToString() == "LA") tempstr = "LAG";
                    Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp(tempstr);
                    frmCodes.ShowDialog();
                    try
                    {
                        if (frmCodes.Code != null)
                        {
                            txt_AOG1.Text = frmCodes.Code;
                            txt_descrip.Text = frmCodes.Descrip;
                            try
                            {
                                cb_offence.SelectedValue = frmCodes.Category;
                            }
                            catch { }
                        }
                        
                    }
                    catch{}            
                }
                else MessageBox.Show("You can only select an Admission of Guilt schedule if the hearing type is an Admission of Guilt", "Incorrect Hearing Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Please select a hearing type first", "No Hearing Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_AOG2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cb_trial_type.SelectedValue.ToString() == "AG" | cb_trial_type.SelectedValue.ToString() == "LA")
                {
                    string tempstr = "AOG";
                    if (cb_trial_type.SelectedValue.ToString() == "LA") tempstr = "LAG";
                    Code_LookUp.Code_LookUp frmCodes = new Code_LookUp.Code_LookUp(tempstr);
                    frmCodes.ShowDialog();
                    try
                    {
                        if (frmCodes.Code != null)
                        {
                            txt_AOG2.Text = frmCodes.Code;
                            txt_descrip2.Text = frmCodes.Descrip;
                            try
                            {
                                cb_offence2.SelectedValue = frmCodes.Category;
                            }
                            catch { }
                        }

                    }
                    catch{ }                                
                }
                else MessageBox.Show("You can only select an Admission of Guilt schedule if the hearing type is an Admission of Guilt", "Incorrect Hearing Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Please select a hearing type first", "No Hearing Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reports_Disc.Reports frmreports = new Reports_Disc.Reports("Record", txtdiscref.Text);
            frmreports.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports_Disc.Reports frmreports = new Reports_Disc.Reports("Fine", txtdiscref.Text);
            frmreports.Show();
        }

        private void txt_summons_time_TextChanged(object sender, EventArgs e)
        {
            dt_summon_time.Value = DateTime.Today.AddSeconds(Int32.Parse(txt_summons_time.Text));            
        }

        private void txt_offence_time1_TextChanged(object sender, EventArgs e)
        {
            dt_offence_time1.Value = DateTime.Today.AddSeconds(Int32.Parse(txt_offence_time1.Text));
        }

        private void txt_offence_time2_TextChanged(object sender, EventArgs e)
        {
            dt_offence_time2.Value = DateTime.Today.AddSeconds(Int32.Parse(txt_offence_time2.Text));
        }

        private void cb_trial_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_trial_type.SelectedValue.ToString() != "AG")
                {
                    if (txt_AOG1.Text != "")
                    {
                        txt_AOG1.Text = "";
                        txt_descrip.Text = "";
                    }
                    if (txt_AOG2.Text != "")
                    {
                        txt_AOG2.Text = "";
                        txt_descrip2.Text = "";
                    }
                }
            }
            catch
            {
            }
        }

       

        private void dt_report_dte1_Enter(object sender, EventArgs e)
        {
            if (dt_report_dte1.Value == null)
            {
                dt_report_dte1.Value = DateTime.Today;
                dt_report_dte1.Value = null;
            }
        }
               

        private void dt_fine_notification_Enter(object sender, EventArgs e)
        {
            if (dt_fine_notification.Value == null)
            {
                dt_fine_notification.Value = DateTime.Today;
                dt_fine_notification.Value = null;
            }
        }

        private void dt_complete1_Enter(object sender, EventArgs e)
        {
            if (dt_complete1.Value == null)
            {
                dt_complete1.Value = DateTime.Today;
                dt_complete1.Value = null;
            }
        }

        private void dt_report_dte2_Enter(object sender, EventArgs e)
        {
            if (dt_report_dte2.Value == null)
            {
                dt_report_dte2.Value = DateTime.Today;
                dt_report_dte2.Value = null;
            }
        }

        private void dt_complete2_Enter(object sender, EventArgs e)
        {
            if (dt_complete2.Value == null)
            {
                dt_complete2.Value = DateTime.Today;
                dt_complete2.Value = null;
            }
        }

        private void dt_fine_pay_Enter(object sender, EventArgs e)
        {
            if (dt_fine_pay.Value == null)
            {
                dt_fine_pay.Value = DateTime.Today;
                dt_fine_pay.Value = null;
            }
        }

        private void dt_add_fine_Enter(object sender, EventArgs e)
        {
            if (dt_add_fine.Value == null)
            {
                dt_add_fine.Value = DateTime.Today;
                dt_add_fine.Value = null;
            }
        }

        private void dt_summons_dte_Enter(object sender, EventArgs e)
        {
            if (dt_summons_dte.Value == null)
            {
                dt_summons_dte.Value = DateTime.Today;
                dt_summons_dte.Value = null;
            }
        }

        private void dt_hearing_dte_Enter(object sender, EventArgs e)
        {
            if (dt_hearing_dte.Value == null)
            {
                dt_hearing_dte.Value = DateTime.Today;
                dt_hearing_dte.Value = null;
            }
        }

        private void dt_bad_dte1_Enter(object sender, EventArgs e)
        {
            if (dt_bad_dte1.Value == null)
            {
                dt_bad_dte1.Value = DateTime.Today;
                dt_bad_dte1.Value = null;
            }
        }

        private void dt_bad_dte2_Enter(object sender, EventArgs e)
        {
            if (dt_bad_dte2.Value == null)
            {
                dt_bad_dte2.Value = DateTime.Today;
                dt_bad_dte2.Value = null;
            }
        }

        private void btn_duplicate_Click(object sender, EventArgs e)
        {
            try
            {
                Search_Grid_Students.Search_Grid_Students frmSearch = new Search_Grid_Students.Search_Grid_Students();
                frmSearch.ShowDialog();
                if (frmSearch.Stuno != "")
                {
                    if (MessageBox.Show("Are you sure you wish to create a duplicate disciplinary record for " + frmSearch.First_Name + " " + frmSearch.Surname + " (" + frmSearch.Stuno + ")?", "Duplicate Sanction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string feedback = Proxy.StudentDiscipline.Duplicate_Fine(txtdiscref.Text, frmSearch.Stuno, Proxy.Info.username);
                        MessageBox.Show(feedback, "Duplicate Fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DisciplineScreen, ex);
            }
        }

        private void Btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cb_auth_res_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_offence_Click(object sender, EventArgs e)
        {

        }

        private void tb_penalty_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_excl_suspended_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
    }
}