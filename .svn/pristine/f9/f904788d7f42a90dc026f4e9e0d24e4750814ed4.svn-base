using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace ResSystem.Updates
{
    public partial class res_vac : Form
    {
        NS_ResSystem.StrongTypesNS.ds_res_vacDataSet ds_vacs = new NS_ResSystem.StrongTypesNS.ds_res_vacDataSet();
       
        DataView dvUsers;
        bool AddNew;
        public string temptype;
        public DateTime OriginalDate;
        public DateTime NewDate;

        public res_vac()
        {
            InitializeComponent();
        }

        private void res_vac_Load(object sender, EventArgs e)
        {
            refresh_list();
        }

        private void refresh_list()
        {
            try
            {
                ds_vacs = Proxy.Res_System.get_res_vac(Global.Global.rescode);
                dvUsers = new DataView(ds_vacs.tt_res_vac);
                dvUsers.Sort = "namestr";
                bs_vacs.DataSource = dvUsers;

                if (dvUsers.Count < 1) btn_print.Enabled = false;
                else btn_print.Enabled = true;

                sc_users.Panel2Collapsed = true;
                sc_users.Panel1.Enabled = true;

            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Search_Grid_Students.Search_Grid_Students frmSelect = new Search_Grid_Students.Search_Grid_Students(true);
                frmSelect.ShowDialog();
                if (frmSelect.Stuno != "")
                {
                     temptype = "";
                    string feedback = Proxy.Res_System.get_vac_student(Global.Global.rescode, frmSelect.Stuno, out OriginalDate, out temptype);
                    if (feedback != string.Empty) MessageBox.Show(feedback, "Error Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        AddNew = true;
                        txt_stuno.Text = frmSelect.Stuno;
                        txt_name.Text = frmSelect.Surname + ", " + frmSelect.First_Name;
                        dte_original.Value = OriginalDate;
                        if (temptype == "L") dte_new.Value = OriginalDate.AddDays(1);
                        if (temptype == "E") dte_new.Value = OriginalDate.AddDays(-1);
                        chk_charge.Checked = true;
                        txt_reason.Text = string.Empty;

                        dte_original.Enabled = false;

                        sc_users.Panel2Collapsed = false;
                        sc_users.Panel1.Enabled = false;
                    }                
                }     
             }
             catch (Exception ex)
             {
                 Utilities.Utils.HandleException(ExceptionSource.ResSystem, ex);
             }
        }

        private void dg_vac_DoubleClick(object sender, EventArgs e)
        {
           
            if (dg_vac.SelectedRows.Count > 0)
            {

                AddNew = false;
                

                txt_stuno.Text = dg_vac.SelectedRows[0].Cells[cnStuno.Name].Value.ToString();
                txt_name.Text = dg_vac.SelectedRows[0].Cells[cnNamestr.Name].Value.ToString();
                dte_original.Value = DateTime.Parse(dg_vac.SelectedRows[0].Cells[cnOriginaldte.Name].Value.ToString());
                dte_new.Value = DateTime.Parse(dg_vac.SelectedRows[0].Cells[cnNewdte.Name].Value.ToString());                
                chk_charge.Checked = bool.Parse(dg_vac.SelectedRows[0].Cells[cnCharge.Name].Value.ToString());
                temptype = dg_vac.SelectedRows[0].Cells[cnType.Name].Value.ToString();

                txt_reason.Text = dg_vac.SelectedRows[0].Cells[cnReason.Name].Value.ToString();
                dte_original.Enabled = false;
                sc_users.Panel2Collapsed = false;
                sc_users.Panel1.Enabled = false; 
            } 

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
             {
                 if (temptype == "E"  & dte_new.Value >= dte_original.Value) MessageBox.Show("New date must be earlier than the Original Date", "Error Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 else if (temptype == "L" & dte_new.Value <= dte_original.Value) MessageBox.Show("New date must be after the Original Date ", "Error Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 else if (txt_reason.Text.Trim() == string.Empty) MessageBox.Show("Please enter reason for date change", "Error Reason", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                 else
                 {
                     string feedback = Proxy.Res_System.update_res_vac(AddNew, Global.Global.rescode, chk_charge.Checked, dte_new.Value, dte_original.Value, txt_reason.Text, txt_stuno.Text, temptype);
                     MessageBox.Show(feedback, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     if (!feedback.Contains("Error")) refresh_list();
                 }
             }
             catch (Exception ex)
             {
                 Utilities.Utils.HandleException(ExceptionSource.ResSystem, ex);
             }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_vac.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?","Delete ResVac", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string feedback = Proxy.Res_System.delete_res_vac(Global.Global.rescode, dg_vac.SelectedRows[0].Cells[cnStuno.Name].Value.ToString(), dg_vac.SelectedRows[0].Cells[cnType.Name].Value.ToString());
                        MessageBox.Show(feedback, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_list();
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.ResSystem, ex);
            }        
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            sc_users.Panel2Collapsed = true;
            sc_users.Panel1.Enabled = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Res_System.SearchOptions.SearchDates frmDates = new Res_System.SearchOptions.SearchDates();
            frmDates.ShowDialog();
            if (frmDates.proceed)
            {
                NS_ResSystem.StrongTypesNS.ds_res_vacDataSet rd_vac_report = Proxy.Res_System.get_resvac_report("*",Global.Global.rescode, frmDates.DateFrom, frmDates.DateTo);
                if (rd_vac_report.tt_res_vac.Count > 0)
                {
                    DataView dvReport = new DataView(rd_vac_report.tt_res_vac);
                    Res_System.FunctionReports frmReport = new Res_System.FunctionReports("ResVac", dvReport);
                    frmReport.Show();
                }
                else MessageBox.Show("There are no Residence Vacation records to display", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
