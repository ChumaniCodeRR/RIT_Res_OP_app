using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NS_Dept.StrongTypesNS;
using System.IO;
using Utilities;
using Res_System.Utilities;

namespace Res_System
{
    public partial class LabelAddress : Form
    {
        bool can_close = true;
        string templateFile, outputFile;

        public LabelAddress()
        {
            InitializeComponent();
        }

        public LabelAddress(string templateFile, string outputFile)
            : this()
        {
            this.templateFile = templateFile;
            this.outputFile = outputFile;
        }

        private void ClassLabelAddress_Load(object sender, EventArgs e)
        {
            Utils.LoadComboBoxFromEnumeration(cbLetterAddress, typeof(Enumerations.ClassLabelAddressType), false, string.Empty);
        }

        void ClassLabelAddress_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!can_close) e.Cancel = true;
            can_close = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_list = string.Empty;
                //ds_subject_studentDataSet ds_subj_stu = Proxy.StudentDepartment.Get_Subject_Students(Global.Global.tempsubj, Global.Global.tempyr);
                if (Global.Global.ds_stuinfo.tt_student_info.Rows.Count.Equals(0))
                {
                    string msg = "There are not students for the selected subject.";
                    MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }

                foreach (NS_Student_Search.StrongTypesNS.DS_STUDENT_SEARCHDataSet.tt_student_infoRow student in Global.Global.ds_stuinfo.tt_student_info)
                {
                    stu_list = stu_list.Equals(string.Empty) ? student.stuno : string.Concat(stu_list, ",", student.stuno);
                }

                ResUtils.GenerateAddressLabels(cbLetterAddress.Text[0], stu_list, templateFile, outputFile);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
            }
        }

        //string GetSelectedSubjectName()
        //{
        //    string subjname = string.Empty;

        //    if (!string.IsNullOrEmpty(Global.Global.tempsubj))
        //    {
        //        int index = new BindingSource(Global.Global.ds_subjects, "tt_subject").Find("subj", Global.Global.tempsubj);
        //        if (index > 0) subjname = Global.Global.ds_subjects.tt_subject[index].subjname;
        //    }
        //    return subjname;
        //}
    }
}
