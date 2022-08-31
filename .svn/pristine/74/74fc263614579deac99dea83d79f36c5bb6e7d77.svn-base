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
    public partial class Contact : Form
    {
        string hall_code;
        string type;
        int oldres;
        bool AddEdit;

        public static NS_ResSystem.StrongTypesNS.DS_GENDataSet ds_contact = new NS_ResSystem.StrongTypesNS.DS_GENDataSet();
        NS_ResSystem.StrongTypesNS.DS_GENDataSet ds_update;

        public Contact(string hall_code, string type)
        {
            InitializeComponent();
            this.hall_code = hall_code;
            this.type = type;
        }

        private void load_form()
        {
            try
            {
                bs_hall.DataSource = Global.Global.ds_rescodes.TT_HALL;

                DataView dv_role = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dv_role.RowFilter = "TYPE = 'RC'";
                tT_GENBindingSource.DataSource = dv_role;

                load_res();
                load_contacts();
                if (type == "AD" | type == "HA") panel1.Enabled = true;

                sc_contacts.Panel2Collapsed = true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void load_res()
        {
            DataView dv_RES = new DataView(Global.Global.ds_rescodes.TT_RES);
            string tempstr = "HALL = '" + cb_hall.SelectedValue.ToString() + "'";
            dv_RES.RowFilter = tempstr;
            DataRow newrow = dv_RES.Table.NewRow();
            newrow["res"] = 0;
            newrow["resname"] = "None";
            newrow["hall"] = cb_hall.SelectedValue.ToString();
            dv_RES.Table.Rows.Add(newrow);
            tT_RESBindingSource.DataSource = dv_RES;
        }

        private void load_contacts()
        {
            try
            {
                ds_contact = Proxy.Res_System.Get_Staff_Contact_Info(cb_hall.SelectedValue.ToString());
                DataView dv_contact = new DataView(ds_contact.TT_CONTACT);
                dv_contact.Sort = "NAME";
                tT_CONTACTBindingSource.DataSource = dv_contact;
                sc_contacts.Panel1.Enabled = true;
                sc_contacts.Panel2Collapsed = true;
                pnl_select.Enabled = true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (panel1.Enabled == true && txt_employee.Text == "") txt_employee.ReadOnly = false;
            else txt_employee.ReadOnly = true;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            sc_contacts.Panel1.Enabled = false;
            sc_contacts.Panel2Collapsed = false;
            pnl_select.Enabled = false;

            oldres = 0;
            AddEdit = true;

            ds_update = new NS_ResSystem.StrongTypesNS.DS_GENDataSet();
            DataRow newrow = ds_update.TT_CONTACT.NewRow();
            newrow["hall"] = cb_hall.SelectedValue.ToString();
            newrow["type"] = "";
            newrow["res"] = 0;
            ds_update.TT_CONTACT.Rows.Add(newrow);

            bs_contact_update.DataSource = ds_update.TT_CONTACT;

            if (panel1.Enabled == true && txt_employee.Text == "") txt_employee.ReadOnly = false;
            else txt_employee.ReadOnly = true;
        }

        private void cb_hall_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_hall.Enabled == true)
            {
                load_res();
                load_contacts();
                if (type == "HA")
                {
                    if (hall_code == cb_hall.SelectedValue.ToString()) panel1.Enabled = true;
                    else panel1.Enabled = false;
                }
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_employee.Text == "") MessageBox.Show("Please enter employee number to continue", "Employee Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cb_role.SelectedIndex == -1) MessageBox.Show("Please select a role to continue", "Select Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string feedback = Proxy.Res_System.Save_Staff_Contact_Info(AddEdit, txt_employee.Text, oldres, ds_update);

                    MessageBox.Show(feedback, "Res System Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (feedback.StartsWith("Contact Details Updated") | feedback.StartsWith("New contact details created")) load_contacts();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure that you want to remove " + dataGridView1.SelectedRows[0].Cells[cn_nAME.Name].Value.ToString() + " from the list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string feedback = Proxy.Res_System.Delete_Staff_Contact_Info(dataGridView1.SelectedRows[0].Cells[cnEMPLOYEE.Name].Value.ToString(), Int32.Parse(dataGridView1.SelectedRows[0].Cells[cnRES.Name].Value.ToString()), cb_hall.SelectedValue.ToString());
                        MessageBox.Show(feedback, "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_contacts();
                    }
                    catch (Exception ex)
                    {
                        Utils.HandleException(ExceptionSource.ResSystem, ex);
                    }
                }
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sc_contacts.Panel1.Enabled = false;
                sc_contacts.Panel2Collapsed = false;
                pnl_select.Enabled = false;

                oldres = int.Parse(dataGridView1.SelectedRows[0].Cells[cnRES.Name].Value.ToString());
                AddEdit = false;

                ds_update = new NS_ResSystem.StrongTypesNS.DS_GENDataSet();
                DataRow newrow = ds_update.TT_CONTACT.NewRow();
                newrow["employee_no"] = dataGridView1.SelectedRows[0].Cells[cnEMPLOYEE.Name].Value.ToString();
                newrow["hall"] = cb_hall.SelectedValue.ToString();
                newrow["type"] = dataGridView1.SelectedRows[0].Cells[cnTYPE.Name].Value.ToString();
                newrow["res"] = int.Parse(dataGridView1.SelectedRows[0].Cells[cnRES.Name].Value.ToString());
                newrow["cell_phone"] = dataGridView1.SelectedRows[0].Cells[cnCELLPHONE.Name].Value.ToString();
                newrow["office_no"] = dataGridView1.SelectedRows[0].Cells[cnOFFICENO.Name].Value.ToString();
                newrow["home_no"] = dataGridView1.SelectedRows[0].Cells[cnHOMENO.Name].Value.ToString();
                ds_update.TT_CONTACT.Rows.Add(newrow);

                bs_contact_update.DataSource = ds_update.TT_CONTACT;

                if (panel1.Enabled == true && txt_employee.Text == "") txt_employee.ReadOnly = false;
                else txt_employee.ReadOnly = true;
            }
        }

        private void btn_print_dir_Click_1(object sender, EventArgs e)
        {
            ReportForm.ContactReport frm_reports = new ReportForm.ContactReport("WardensDirectory");
            frm_reports.Show();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            load_form();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            load_form();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            sc_contacts.Panel1.Enabled = true;
            sc_contacts.Panel2Collapsed = true;
            pnl_select.Enabled = true;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.DS_ISD_DATADataSet ds_empnos = new NS_System.StrongTypesNS.DS_ISD_DATADataSet();

            SearchEmployee.Search_Protea_Users frm_search_users = new SearchEmployee.Search_Protea_Users(true, ds_empnos);
            frm_search_users.ShowDialog();
            if (frm_search_users.UserId != "")
            {
                txt_employee.Text = frm_search_users.UserId;

            }

        }
    }
            
}
