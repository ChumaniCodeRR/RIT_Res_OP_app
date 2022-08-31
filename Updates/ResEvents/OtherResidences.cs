using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;


namespace Res_System.Updates.ResEvents
{
    public partial class OtherResidences : Form
    {
        public bool Continue = false;
        public NS_Catering.StrongTypesNS.ds_res_functionsDataSet ds_res_list;

        public OtherResidences()
        {
            InitializeComponent();
        }

        private void OtherResidences_Load(object sender, EventArgs e)
        {
            try
            {
                NS_Catering.StrongTypesNS.ds_res_functionsDataSet ds_display_list = Proxy.CateringSystem.get_hall_list(Global.Global.hallcode, Global.Global.rescode);
                bs_res.DataSource = ds_display_list.TT_RES_LIST;
             }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Catering, ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Continue = false;
            this.Close();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgResidences.Rows)
            {
                row.Cells[cCheck.Name].Value = true;
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgResidences.Rows)
            {
                row.Cells[cCheck.Name].Value = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgResidences.Rows.Count > 0)
                {
                    bool selected = false;
                    foreach (DataGridViewRow row in dgResidences.Rows)
                    {
                        if (row.Cells[cCheck.Name].Value != null && (bool)row.Cells[cCheck.Name].Value)
                        {
                            selected = true; break;
                        }
                    }
                    if (!selected) MessageBox.Show("There are no residences selected", "Res Functions", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
                    else
                    {
                        ds_res_list = new NS_Catering.StrongTypesNS.ds_res_functionsDataSet();
                        foreach (DataGridViewRow row in dgResidences.Rows)
                        {
                            if (row.Cells[cCheck.Name].Value != null && (bool)row.Cells[cCheck.Name].Value)
                            {
                                DataRow newrow = ds_res_list.TT_RES_LIST.NewRow();
                                newrow["res"] = row.Cells[cnRes.Name].Value;
                                ds_res_list.TT_RES_LIST.Rows.Add(newrow);

                            }
                        }
                        Continue = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Catering, ex);
            }
        }
    }
}
