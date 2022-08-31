using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Proxy;
using Utilities;

namespace Student_Results
{
    public partial class StudentResults : Form
    {
        private NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet ds_results = new NS_Student_Results.StrongTypesNS.DS_RESULTSDataSet();

        public StudentResults()
        {
            InitializeComponent();

            this.dg_results.AutoGenerateColumns =
                this.dg_comments.AutoGenerateColumns =
                this.dg_matr_results.AutoGenerateColumns = false;

            this.tcStudentResults.Focus();
        }

        /// <summary>
        /// Gets student results for the currently selected student
        /// </summary>
        public void RefreshData()
        {
            try
            {
                ds_results = Proxy.StudentResults.Single_Student(Global.Global.tempstu);
                UploadResults();
            }
            catch (Exception ex)
            {
                Utils.HandleException("Student Results", ex);
            }
        }

        private void ClearDataSources()
        {
            dg_results.DataSource = null;
            dg_comments.DataSource = null;
            dg_matr_results.DataSource = null;
        }
        /// <summary>
        /// Show results for currently selected student and filter settings
        /// </summary>
        public void UploadResults()
        {
            try
            {
                ClearDataSources();

                DataView dv = new DataView((DataTable)ds_results.TT_RESULTS);
                if (rbthisyr.Checked) dv.RowFilter = string.Format("yr = {0}", DateTime.Today.Year);
                if (rblastyr.Checked) dv.RowFilter = string.Format("yr = {0}", DateTime.Today.Year - 1);

                dg_results.DataSource = dv;
                dg_comments.DataSource = ds_results.TT_COMMENTS;
                dg_matr_results.DataSource = ds_results.TT_MATR;
                bsMatricDetails.DataSource = ds_results.TT_MATR_DETAILS;
                tT_CREDITSBindingSource.DataSource = ds_results.TT_CREDITS;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentResults, ex);
            }
        }

        private void btn_print_results_Click(object sender, EventArgs e)
        {
           Reports_Student_Results.Reports frmReports = new Reports_Student_Results.Reports("Results", Global.Global.tempstu);
           frmReports.Show();
        }

        private void rbthisyr_CheckedChanged(object sender, EventArgs e)
        {
            UploadResults();
        }

        private void rblastyr_CheckedChanged(object sender, EventArgs e)
        {
            UploadResults();
        }

        private void rballyrs_CheckedChanged(object sender, EventArgs e)
        {
            UploadResults();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Handles exceptions that occure during runtime
        /// </summary>
        /// <param name="ex"></param>
        private void HandleException(string source, Exception ex)
        {
            EventLog.WriteEntry(source, ex.ToString(), EventLogEntryType.Error);
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bsMatricDetails1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void StudentResults_Load(object sender, EventArgs e)
        {

        }
    }
}
