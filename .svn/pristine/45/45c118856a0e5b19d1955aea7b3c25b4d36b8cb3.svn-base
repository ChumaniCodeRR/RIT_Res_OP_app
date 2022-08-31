using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Res_System
{
    public partial class StudentLeadership : Form
    {
        public int tempyr;

        public StudentLeadership(int year)
        {
            InitializeComponent();

            tempyr = year;

            dgvLeadership.AutoGenerateColumns = false;
            dg_codes.AutoGenerateColumns = false;
        }

        private void StudentLeadership_Load(object sender, EventArgs e)
        {
            try
            {
                txt_title.Text = string.Format("Leadership Positions for {0}", tempyr.ToString());

                //Bind student list
                DataView dvStudents = new DataView(Global.Global.ds_stuinfo.tt_student_info);
                dvStudents.Sort = ("surn");
                cb_student.DataSource = dvStudents;
                cb_student.SelectedIndex = -1;

                //Bind position list
                DataView dvPos = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dvPos.RowFilter = "type = 'HT'";
                cb_position.DataSource = dvPos;
                cb_position.SelectedIndex = -1;

                //Bind res code
                DataView dvResCode = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dvResCode.RowFilter = "type = 'HC'";
                dg_codes.DataSource = dvResCode;

                LoadStudentLeadership();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        #region Local Methods

        void LoadStudentLeadership()
        {
            string feedback = "";
            NS_ResSystem.StrongTypesNS.DS_HOUSECOMMDataSet ds_housecomm = Proxy.Res_System.Fetch_House_Comm(Global.Global.rescode, tempyr, out feedback);
            DataView dvStudentLeaders = new DataView(ds_housecomm.tt_house_comm);
            dvStudentLeaders.Sort = ("namestr");
            dgvLeadership.DataSource = dvStudentLeaders;
            if (feedback != "")
            {
                MessageBox.Show(feedback, "House Comm Update", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        bool ValidDataSelection()
        {
            bool valid = true;
            errorProvider.Clear();

            if (cb_student.SelectedIndex.Equals(-1))
            {
                errorProvider.SetError(cb_student, "Please select student from the list");
                valid = false;
            }

            if (cb_position.SelectedIndex.Equals(-1))
            {
                errorProvider.SetError(cb_position, "Please select position from the list");
                valid = false;
            }

            if (pnlFolio.Visible && txt_position.Text.Trim().Length.Equals(0))
            {
                errorProvider.SetError(txt_position, "Please enter folio description.");
                valid = false;
            }

            return valid;
        }

        void ResetDetails()
        {
            errorProvider.Clear();
            cb_student.SelectedIndex = cb_position.SelectedIndex = -1;
            pnlFolio.Visible = false;

            DataGridViewCheckBoxCell checkCell;
            foreach (DataGridViewRow row in dg_codes.Rows)
            {
                checkCell = (DataGridViewCheckBoxCell)row.Cells["YesNo"];
                checkCell.Value = false;
            }
        }

        #endregion

        private void cb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(cb_position, string.Empty);

                if (cb_position.Items.Count > 0 && cb_position.SelectedIndex > -1)
                {
                    if (cb_position.SelectedValue != null && (cb_position.SelectedValue.ToString().Equals("HS") || cb_position.SelectedValue.ToString().Equals("SW")))
                    {
                        pnlFolio.Visible = false;
                        txt_position.Text = cb_position.SelectedValue.ToString().Equals("SW") ? "Sub-Warden" : "Hall Senior Student";
                    }
                    else
                    {
                        pnlFolio.Visible = true;
                        txt_position.Text = string.Empty;
                    }
                }
                else
                {
                    pnlFolio.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDetails();
            dgvLeadership.ClearSelection();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLeadership.Rows.Count > 0)
                {
                    if (dgvLeadership.SelectedRows.Count > 0)
                    {
                        string message = "Are you sure that you want to remove this person?";
                        DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result.Equals(DialogResult.Yes))
                        {
                            string stuno = dgvLeadership.SelectedRows[0].Cells["stuno"].Value.ToString();
                            string pos = dgvLeadership.SelectedRows[0].Cells["type"].Value.ToString();
                            Proxy.Res_System.Remove_House_Comm(stuno, tempyr, pos);

                            LoadStudentLeadership();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select record to remove.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("There are no records to remove.", "Student Leadership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cb_student, string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidDataSelection())
                {
                    string temp_pos = string.Empty;
                    DataGridViewCheckBoxCell checkCell;
                    foreach (DataGridViewRow row in dg_codes.Rows)
                    {
                        checkCell = (DataGridViewCheckBoxCell)row.Cells["YesNo"];
                        if (checkCell.Value != null && (bool)checkCell.Value)
                        {
                            temp_pos = temp_pos.Equals(string.Empty) ? row.Cells["Code"].Value.ToString() :
                                string.Format("{0},{1}", temp_pos, row.Cells["Code"].Value.ToString());
                        }
                    }

                    string feedback = Proxy.Res_System.Add_House_Comm(cb_student.SelectedValue.ToString(), tempyr,
                        cb_position.SelectedValue.ToString(), txt_position.Text, temp_pos);
                    if (feedback == "")
                    {
                        LoadStudentLeadership();
                        ResetDetails();
                    }
                    else MessageBox.Show(feedback, "House Comm Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        void dgvLeadership_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvLeadership.ClearSelection();
            ResetDetails();
        }

        void dgvLeadership_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                ResetDetails();

                if (dgvLeadership.SelectedRows.Count > 0)
                {
                    cb_student.SelectedValue = dgvLeadership.SelectedRows[0].Cells["stuno"].Value;
                    cb_position.SelectedValue = dgvLeadership.SelectedRows[0].Cells["type"].Value;

                    txt_position.Text = dgvLeadership.SelectedRows[0].Cells["Folio"].Value.ToString();

                    string comm_spot = dgvLeadership.SelectedRows[0].Cells["Responsibilities"].Value.ToString();
                    foreach (DataGridViewRow row in dg_codes.Rows)
                    {
                        if (comm_spot.Contains(row.Cells["Responsibility"].Value.ToString()))
                        {
                            row.Cells["YesNo"].Value = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void txt_position_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txt_position, string.Empty);
        }
    }
}
