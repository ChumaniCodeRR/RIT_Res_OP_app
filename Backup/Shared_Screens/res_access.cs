using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Res_Access
{
    public partial class res_access : Form
    {
        bool accessupdate = false;
        DateTime Start_dte;
        DateTime End_dte;

        public res_access(bool tempaccess)
        {
            InitializeComponent();
            accessupdate = tempaccess;
           // added to force accessupdate to false for testing
         //  accessupdate = false;
           if (accessupdate == true)
           {
               txt_reason.Visible = true;
               label4.Visible = true;
           }
        }

        public static NS_ResSystem.StrongTypesNS.DS_ACCESSDataSet ds_access = new NS_ResSystem.StrongTypesNS.DS_ACCESSDataSet();

        private void res_access_Load(object sender, EventArgs e)
        {
            try
            {
                ds_access = Proxy.Stanley.Get_Res_Access_Dates(Global.Global.tempstu);

                dt_start.DataBindings.Add(new Binding("Text", ds_access.TT_ACCESS, "start_dte", false, DataSourceUpdateMode.OnPropertyChanged));
                dt_end.DataBindings.Add(new Binding("Text", ds_access.TT_ACCESS, "end_dte", false, DataSourceUpdateMode.OnPropertyChanged));
                dt_delete.DataBindings.Add(new Binding("Text", ds_access.TT_ACCESS, "expiry_dte", false, DataSourceUpdateMode.OnPropertyChanged));

                Start_dte = dt_start.Value;
                End_dte = dt_end.Value;

                dt_delete.MinDate = DateTime.Today;

                if (accessupdate == true)
                {
                    dt_delete.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
                    dt_start.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
                    dt_start.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
                    dt_end.MinDate = dt_start.Value;
                    dt_end.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
                }

                if (accessupdate == false)
                {
                    dt_delete.MaxDate = dt_delete.Value;
                    dt_start.MinDate = dt_start.Value;
                    dt_start.MaxDate = dt_end.Value;
                    dt_end.MinDate = dt_start.Value;
                    dt_end.MaxDate = dt_end.Value;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResAccess, ex);
            }
                
        }

        private void btn_Save_res_access_Click(object sender, EventArgs e)
        {

            try
            {
                if (dt_end.Value >= dt_start.Value)
                {
                    if ((accessupdate == true) & (txt_reason.Text == "") & ((dt_start.Value < Start_dte) | (dt_end.Value > End_dte)))
                    {
                        MessageBox.Show("You must enter a reason for this date change. ", "Res Access Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string feedback = Proxy.Stanley.Update_Student_Access(Global.Global.tempstu, accessupdate, txt_reason.Text, ds_access);
                        MessageBox.Show(feedback, "Stanley Access Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else MessageBox.Show("Your End Date Cannot Be Before Your Start Date", "Res Access Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResAccess, ex);
            }
        }

        private void dt_start_ValueChanged(object sender, EventArgs e)
        {
            dt_end.MinDate = dt_start.Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }
    }
}
