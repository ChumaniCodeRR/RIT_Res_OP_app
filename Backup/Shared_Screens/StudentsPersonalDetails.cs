using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Constants;
using Utilities;


namespace Student_Personal_Details
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
        public static NS_StuInfo.StrongTypesNS.DS_STUINFODataSet ds_stuinfo = new NS_StuInfo.StrongTypesNS.DS_STUINFODataSet();
       
        private void StudentsPersonalDetails_Load(object sender, EventArgs e)
        {
            //Restrict access to only the below account types for res access dates
            if (Global.Global.type != AccountTypes.Administrator && Global.Global.type != AccountTypes.HallAdministrator &&
                Global.Global.type != AccountTypes.HallWarden && Global.Global.type != AccountTypes.HouseWarden &&
                Global.Global.type != AccountTypes.SubWarden)
            {
                btn_res_access.Enabled = false;
            }

            cb_kin.DataBindings.Add(new Binding("SelectedValue", ds_stuinfo.tt_stuinfo, "kin"));
            cb_prefer_diet.DataBindings.Add(new Binding("SelectedValue", ds_stuinfo.tt_stuinfo, "pref_diet"));
            Refresh_Data();
        }

        public void Refresh_Data()
        {
            try
            {
                ds_stuinfo = Proxy.StudentInfo.Get_Stu_Personal_Details(Global.Global.tempstu);
                tt_stuinfoBindingSource.DataSource = ds_stuinfo.tt_stuinfo;
                tT_DIETBindingSource.DataSource = Global.Global.ds_rescodes.TT_DIET;
                
                DataView dv_rel = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dv_rel.RowFilter = "type = 'KI'";
                tT_GENBindingSource.DataSource = dv_rel;

                if (Global.Global.type == "AD" | Global.Global.type == "HA")
                {
                    foreach (Control ctrl in tab_contact.Controls)
                    {
                        if (ctrl.GetType() == typeof(TextBox)) ((TextBox)ctrl).ReadOnly = false;
                    }

                    txtemail.ReadOnly = true;
                    txtterm.ReadOnly = true;
                    btn_save_contact_info.Visible = true;
                    cb_kin.Enabled = true;
                    cb_prefer_diet.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentPersonalDetails, ex);
            }
        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
               
        private void btn_res_access_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcurr.Text == "") MessageBox.Show("This student is not in res - you may not update their access details until they have registered and are placed in res", "Res Access Dates",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    bool tempaccess = Proxy.Stanley.Permission_Update_Res_Access(Global.Global.tempstu);
                    Res_Access.res_access frmresaccess = new Res_Access.res_access(tempaccess);
                    frmresaccess.ShowDialog();

                    NS_ResSystem.StrongTypesNS.DS_ACCESSDataSet ds_access = Proxy.Stanley.Get_Res_Access_Dates(Global.Global.tempstu);
                    res_startTextBox.Text = (ds_access.TT_ACCESS[0]["start_dte"].ToString()).Substring(0, 10);
                    res_expiryTextBox.Text = (ds_access.TT_ACCESS[0]["end_dte"].ToString()).Substring(0, 10);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentPersonalDetails, ex);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Student_Personal_Details.Reports frmreports = new Student_Personal_Details.Reports("Stu_Info", Global.Global.tempstu);
            frmreports.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Personal_Details.Reports frmreports = new Student_Personal_Details.Reports("Stu_Info", Global.Global.tempstu);
            frmreports.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Personal_Details.Reports frmreports = new Student_Personal_Details.Reports("Med_Aid", Global.Global.tempstu);
            frmreports.Show();
        }

        private void btn_save_alt_info_Click(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.StudentInfo.Save_Stu_Contact_Details(ds_stuinfo);
                MessageBox.Show(feedback, "Alternate Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentPersonalDetails, ex);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Student_Personal_Details.Reports frmreports = new Student_Personal_Details.Reports("Results", Global.Global.tempstu);
            frmreports.Show();
        }
        
        private void txtcellno_Leave(object sender, EventArgs e)
        {
            if (txtcellno.ReadOnly == false)
            {
                string cellno = "";
                string errormsg = "";
                checkcell(txtcellno.Text, out cellno, out errormsg);
                txtcellno.Text = cellno;
                if (errormsg != "")
                {
                    MessageBox.Show(errormsg, "Cell Phone Incorrectly Captured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcellno.Focus();
                }
            }

        }

        private void checkcell(string cellno, out string newcell, out string errormsg)
        {
            errormsg = "";
            try
            {
                Proxy.System.Check_Cell_No(ref cellno);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentPersonalDetails, ex);
            }
            newcell = cellno;
        }

        private void textBox22_Leave(object sender, EventArgs e)
        {
            string cellno = "";
            string errormsg = "";
            checkcell(txt_kin_cell.Text, out cellno, out errormsg);
            txt_kin_cell.Text = cellno;
            if (errormsg != "")
            {
                MessageBox.Show(errormsg, "Cell Phone Incorrectly Captured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_kin_cell.Focus();
            }
        }

        private void txt_alt_cell_Leave(object sender, EventArgs e)
        {
            string cellno = "";
            string errormsg = "";
            checkcell(txt_alt_cell.Text, out cellno, out errormsg);

            txt_alt_cell.Text = cellno;
            if (errormsg != "")
            {
                MessageBox.Show(errormsg, "Cell Phone Incorrectly Captured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_alt_cell.Focus();
            }
        }

        private void txtemail_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + txtemail.Text);
        }

        private void Btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }       
    }
}