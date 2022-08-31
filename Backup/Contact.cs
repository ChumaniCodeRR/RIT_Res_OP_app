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
        public Contact()
        {
            InitializeComponent();
        }

        public static NS_ResSystem.StrongTypesNS.DS_GENDataSet ds_contact = new NS_ResSystem.StrongTypesNS.DS_GENDataSet();

        private void Contact_Load(object sender, EventArgs e)
        {
            try
            {
                int startindex = 0;
                int index = 0;
                string tempstr = "";

                tempstr = Proxy.System.Get_Sleeping_Halls();

                string[] temphall = tempstr.Split(new char[] { '|' });
                cb_hall.Enabled = false;
                for (int intArray = 0; intArray < temphall.Length; intArray++)
                {
                    cb_hall.Items.Add(new Item(temphall[intArray + 1], temphall[intArray]));
                    if (temphall[intArray] == Global.Global.hallcode) startindex = index;
                    index++;
                    intArray = intArray + 1;
                }
                cb_hall.SelectedIndex = startindex;
                cb_hall.Enabled = true;

                DataView dv_role = new DataView(Global.Global.ds_rescodes.TT_GEN);
                dv_role.RowFilter = "TYPE = 'RC'";
                tT_GENBindingSource.DataSource = dv_role;
                load_res();
                load_contacts();

                if (Global.Global.type == "AD" | Global.Global.type == "HA") panel1.Enabled = true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_hall.Enabled == true)
            {
                load_res();
                load_contacts();
                if (Global.Global.type == "HA")
                {
                    if (Global.Global.hallcode == ((Item)cb_hall.SelectedItem).Value.ToString()) panel1.Enabled = true;
                    else panel1.Enabled = false;
                }
            }
        }

        private void load_res()
        {
            
            //cb_res.Items.Clear();

            DataView dv_RES = new DataView(Global.Global.ds_rescodes.TT_RES);
            string tempstr = "HALL = '" + ((Item)cb_hall.SelectedItem).Value.ToString() + "'";
            dv_RES.RowFilter = tempstr;
            DataRow newrow = dv_RES.Table.NewRow();
            newrow["res"] = 0;
            newrow["resname"] = "None";
            newrow["hall"] = ((Item)cb_hall.SelectedItem).Value.ToString();
            dv_RES.Table.Rows.Add(newrow);
            tT_RESBindingSource.DataSource = dv_RES;

        }

        private void load_contacts()
        {
            try
            {
                ds_contact = Proxy.Res_System.Get_Staff_Contact_Info(((Item)cb_hall.SelectedItem).Value.ToString());

                DataView dv_contact = new DataView(ds_contact.TT_CONTACT);
                dv_contact.Sort = "NAME";
                tT_CONTACTBindingSource.DataSource = dv_contact;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.Res_System.Save_Staff_Contact_Info(txt_employee.Text, Int32.Parse(cb_res.SelectedValue.ToString()), ds_contact);

                MessageBox.Show(feedback, "Res System Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (feedback.StartsWith("Contact Details Updated") | feedback.StartsWith("New contact details created")) load_contacts();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow newrow = ds_contact.TT_CONTACT.NewRow();
            newrow["hall"] = ((Item)cb_hall.SelectedItem).Value.ToString();
            newrow["type"] = "HK";
            newrow["res"] = 0;
            ds_contact.TT_CONTACT.Rows.Add(newrow);
                        
            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            dataGridView1.Refresh();

            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            dataGridView1.Rows[0].Selected = true;
            if (panel1.Enabled == true && txt_employee.Text == "") txt_employee.ReadOnly = false;
            else txt_employee.ReadOnly = true;
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (panel1.Enabled == true && txt_employee.Text == "") txt_employee.ReadOnly = false;
            else txt_employee.ReadOnly = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to remove this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string feedback = Proxy.Res_System.Delete_Staff_Contact_Info(txt_employee.Text, Int32.Parse(cb_res.SelectedValue.ToString()));
                    MessageBox.Show(feedback, "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_contacts();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error Deleting this Person - Please contact the Data Management Unit","Remove Contact",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    Utils.HandleException(ExceptionSource.ResSystem, ex);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
