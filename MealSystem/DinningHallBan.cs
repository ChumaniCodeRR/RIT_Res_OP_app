﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace OppiBusBan
{
    public partial class DinningHallBan : Form
    {

        NS_ResSystem.StrongTypesNS.DS_OPPISTUDataSet ds_dhallban = new NS_ResSystem.StrongTypesNS.DS_OPPISTUDataSet();
        DataView dv_list;
        bool AddEdit;

        DataSet ds_rescodes;

        string ExpirtDateString;

        public DinningHallBan()
        {
            InitializeComponent();
        }

        private void DinningHallBan_Load(object sender, EventArgs e)
        {
            ds_rescodes = Global.Global.ds_rescodes.Copy();
            DataRow newrow = ds_rescodes.Tables["TT_DHALL"].NewRow();
            newrow["dhall"] = "*";
            newrow["detail"] = "All Halls";
            ds_rescodes.Tables["TT_DHALL"].Rows.InsertAt(newrow, 0);
            ds_halls.DataSource = ds_rescodes.Tables["TT_DHALL"];

            refresh_list();
        }

        private void refresh_list()
        {
            try
            {
                ds_dhallban = Proxy.Res_System.get_dhall_ban();
                dv_list = new DataView(ds_dhallban.tt_dhall_ban);
                bs_dhallban.DataSource = dv_list;
                sc_busban.Panel2Collapsed = true;
                sc_busban.Panel1.Enabled = true;
                filter();
              
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEdit = true;
            txt_emp.Text = "";
            txt_name.Text = "";
            dte_expiry.Value = DateTime.Today;
            dte_expiry.Value = null;
            txt_emp.Enabled = true;
            btn_search.Enabled = true;
            cb_hall.SelectedIndex = -1;
            cb_hall.Enabled = true;

            sc_busban.Panel2Collapsed = false;
            sc_busban.Panel1.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_emp.Text == "") MessageBox.Show("Student Number cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cb_hall.SelectedIndex < 0) MessageBox.Show("Please select Dinning hall to proceed", "Error Hall", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (dte_expiry.Value == null) ExpirtDateString = "?";
                    else ExpirtDateString = ((DateTime)dte_expiry.Value).ToString("dd/MM/yyyy");

                    string feedback = Proxy.Res_System.update_dhallban(AddEdit, txt_emp.Text.ToString(),cb_hall.SelectedValue.ToString(), ExpirtDateString);
                    MessageBox.Show(feedback, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!feedback.StartsWith("Error")) refresh_list();
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(false);
                frmStuSearch.ShowDialog();
                txt_emp.Text = frmStuSearch.Stuno;
                txt_name.Text = frmStuSearch.Surname + " " + frmStuSearch.First_Name;
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_list.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + dg_list.SelectedRows[0].Cells[cn_surn.Name].Value.ToString() + " from the " + dg_list.SelectedRows[0].Cells[cn_halldescrip.Name].Value.ToString() + " list.",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string feedback = Proxy.Res_System.delete_dhallban(dg_list.SelectedRows[0].Cells[cn_stuno.Name].Value.ToString(), dg_list.SelectedRows[0].Cells[cn_dhall.Name].Value.ToString());
                        MessageBox.Show(feedback, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_list();
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            sc_busban.Panel2Collapsed = true;
            sc_busban.Panel1.Enabled = true;
        }

        private void txt_emp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {                  

                }
            }
            catch (Exception ex)
            {
                Utilities.Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void dg_list_DoubleClick(object sender, EventArgs e)
        {
            if (dg_list.SelectedRows.Count > 0)
            {
                AddEdit = false;
                txt_emp.Text = dg_list.SelectedRows[0].Cells[cn_stuno.Name].Value.ToString();
                txt_name.Text = dg_list.SelectedRows[0].Cells[cn_surn.Name].Value.ToString();
                ExpirtDateString = dg_list.SelectedRows[0].Cells[cn_enddte.Name].Value.ToString();
                cb_hall.SelectedValue = dg_list.SelectedRows[0].Cells[cn_dhall.Name].Value.ToString();
             

                if (ExpirtDateString == string.Empty) dte_expiry.Value = null;
                else dte_expiry.Value = DateTime.Parse(dg_list.SelectedRows[0].Cells[cn_enddte.Name].Value.ToString());

                txt_emp.Enabled = false;
                btn_search.Enabled = false;
                cb_hall.Enabled = false;
                sc_busban.Panel2Collapsed = false;
                sc_busban.Panel1.Enabled = false;
            }
        }

        private void filter()
        {
            if (dv_list != null)
            {
                dv_list.RowFilter = "stuno like '*" + txt_filter_stuno.Text.ToString() + "*' and SURN like '*" + txt_filter_name.Text.ToString() + "*'";
                bs_dhallban.DataSource = dv_list;
            }
        }

        private void txt_filter_stuno_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_filter_name_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

    }
}
