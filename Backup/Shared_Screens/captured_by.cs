using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Captured_By
{
    public partial class captured_by : Form
    {
        Reports_Disc.Reports mainForm;

        public captured_by(Reports_Disc.Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }


        private void captured_by_Load(object sender, EventArgs e)
        {
            try
            {
                NS_System.StrongTypesNS.DS_ISD_DATADataSet ds_users = Proxy.System.Get_Protea_Users();

                cb_users.Items.Add(new Item("Any User", "*"));
                DataView dview = new DataView();
                dview.Table = ds_users.TT_USERS;
                dview.Sort = "name";


                int x = 0;
                foreach (DataRow row in dview.Table.Rows)
                {
                    cb_users.Items.Add(new Item(dview[x]["name"].ToString(), dview[x]["username"].ToString()));
                    x++;
                }
                cb_users.SelectedIndex = 0;

                dt_start.Value = DateTime.Today.AddMonths(-6);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.SharedCapturedBy, ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NS_Discipline.StrongTypesNS.DS_CREATED_BYDataSet ds_disc = new NS_Discipline.StrongTypesNS.DS_CREATED_BYDataSet();
                Proxy.StudentDiscipline.Captured_By(((Item)cb_users.SelectedItem).Value.ToString(), dt_start.Value, dt_end.Value);

                mainForm.rds.Name = "DS_CREATED_BYDataSet_TT_CREATED_BY";
                mainForm.rds.Value = ds_disc.TT_CREATED_BY;
                mainForm.reportViewer1.LocalReport.ReportEmbeddedResource = Proxy.Info.whereami + ".Reports.Disc_Captured_By.rdlc";
                string header = "Between the dates of the " + dt_start.Value.ToShortDateString() + " till the " + dt_end.Value.ToShortDateString();
                mainForm.p[0] = new Microsoft.Reporting.WinForms.ReportParameter("title", header);
                mainForm.proceed = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.SharedCapturedBy, ex);
            }
        }
    }
}
