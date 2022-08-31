using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Constants;
using Utilities;

namespace Student_Medical
{
    public partial class StudentMedicalDetails : Form
    {
        private NS_StuInfo.StrongTypesNS.DS_STUINFODataSet ds_stuinfo = new NS_StuInfo.StrongTypesNS.DS_STUINFODataSet();

        public StudentMedicalDetails()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            try
            {
                ds_stuinfo = Proxy.StudentInfo.Get_Stu_Personal_Details(Global.Global.tempstu);
                bsEmergency.DataSource = ds_stuinfo.tt_emergency;

                if (Global.Global.type.Equals(AccountTypes.Administrator) || Global.Global.type.Equals(AccountTypes.HallAdministrator))
                {
                    foreach (Control control in pnlMedicalDetails.Controls)
                    {
                        if (control.GetType().Equals(typeof(TextBox)))
                        {
                            ((TextBox)control).ReadOnly = false;
                        }
                    }

                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentMedicalDetails, ex);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports_Medical.Reports frmReports = new Reports_Medical.Reports("Med_Aid", Global.Global.tempstu);
            frmReports.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string feedback = Proxy.StudentInfo.Save_Stu_Medical_Details(ds_stuinfo);
            MessageBox.Show(feedback, "Emergency Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
