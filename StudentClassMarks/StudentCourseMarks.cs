using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using NS_Dept.StrongTypesNS;
using NS_ResSystem.StrongTypesNS;
using NS_Student_Search.StrongTypesNS;

namespace Res_System.StudentClassMarks
{
    public partial class StudentCourseMarks : Form
    {
        #region Local Variables

        bool canClose = true, registeredStudents;
        DS_STUDENT_SEARCHDataSet ds_res_stu;
        DS_STUDENT_SEARCHDataSet ds_selected;

        #endregion

        #region Constructor

        public StudentCourseMarks()
        {
            InitializeComponent();

            dgvAvailableStudents.AutoGenerateColumns = false;
            dgvSelectedStudents.AutoGenerateColumns = false;
        }

        public StudentCourseMarks(bool registeredStudents)
            : this()
        {
            this.registeredStudents = registeredStudents;
        }

        #endregion

        #region Form Events

        private void CourseStudentPerformance_Load(object sender, EventArgs e)
        {
            try
            {
                lblHallName.Text = Global.Global.hallname;
                lblResName.Text = Global.Global.resname;

                ds_selected = new DS_STUDENT_SEARCHDataSet();
                ds_res_stu = Proxy.StudentSearch.Get_Students_In_Res(Global.Global.hallcode, Global.Global.rescode.ToString(), "CURR", Global.Global.tempyr);

                RefreshAvailableStudents();

                //Default all students to selected
                Invoke(new EventHandler(btnCheckAllAvail_Click), sender, e);
                Invoke(new EventHandler(btnAdd_Click), sender, e);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentResults, ex);
            }
        }

        #endregion

        #region Local Methods

        void RefreshAvailableStudents()
        {
            string selected = string.Empty;
            string formattedStuno = string.Empty;
            DataView dvAvailableStu = new DataView(ds_res_stu.tt_student_info);

            foreach (DS_STUDENT_SEARCHDataSet.tt_student_infoRow student in ds_selected.tt_student_info)
            {
                formattedStuno = string.Concat("'", student.stuno, "'");
                selected = string.IsNullOrEmpty(selected) ? formattedStuno : string.Concat(selected, ",", formattedStuno);
            }

            string filter = string.Format("surn LIKE '%{0}%'", txtFilterAvail.Text.Trim());
            if (!string.IsNullOrEmpty(selected))
            {
                selected = string.Concat("(", selected, ")");
                selected = string.Format("stuno not in {0}", selected);
                filter = string.Concat(filter, " and ", selected);
            }
            dvAvailableStu.RowFilter = filter;

            DataGridViewColumn sortColumn = dgvAvailableStudents.SortedColumn == null ? dgvAvailableStudents.Columns[cSurnameAvail.Name] : dgvAvailableStudents.SortedColumn;
            ListSortDirection sortDirection = dgvAvailableStudents.SortOrder.Equals(SortOrder.Descending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            dgvAvailableStudents.DataSource = dvAvailableStu;
            dgvAvailableStudents.Sort(sortColumn, sortDirection);
            dgvAvailableStudents.Refresh();
        }

        void RefreshSelectedStudenst()
        {
            DataView dvSelectedStu = new DataView(ds_selected.tt_student_info);
            dvSelectedStu.RowFilter = string.Format("surn LIKE '%{0}%'", txtFilterSelect.Text.Trim());

            DataGridViewColumn sortColumn = dgvSelectedStudents.SortedColumn == null ? dgvSelectedStudents.Columns[cSurnnameSelect.Name] : dgvSelectedStudents.SortedColumn;
            ListSortDirection sortDirection = dgvSelectedStudents.SortOrder.Equals(SortOrder.Descending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            dgvSelectedStudents.DataSource = dvSelectedStu;
            dgvSelectedStudents.Sort(sortColumn, sortDirection);
            dgvSelectedStudents.Refresh();
        }

        #endregion

        #region TextBox Events

        private void txtFilterAvail_TextChanged(object sender, EventArgs e)
        {
            RefreshAvailableStudents();
        }

        private void txtFilterSelect_TextChanged(object sender, EventArgs e)
        {
            RefreshSelectedStudenst();
        }

        #endregion

        #region Button Events

        private void btnCheckAllAvail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow student in dgvAvailableStudents.Rows)
            { student.Cells[ckCheckAvail.Name].Value = true; }
        }

        private void btnUncheckAllAvail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow student in dgvAvailableStudents.Rows)
            { student.Cells[ckCheckAvail.Name].Value = false; }
        }

        private void btnCheckAllSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow student in dgvSelectedStudents.Rows)
            { student.Cells[ckCheckSelected.Name].Value = true; }
        }

        private void btnUncheckAllSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow student in dgvSelectedStudents.Rows)
            { student.Cells[ckCheckSelected.Name].Value = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validSelection = false;
            string stuno = string.Empty;

            foreach (DataGridViewRow item in dgvAvailableStudents.Rows)
            {
                if (item.Cells[ckCheckAvail.Name].Value != null && (bool)item.Cells[ckCheckAvail.Name].Value)
                {
                    validSelection = true;
                    stuno = item.Cells[cStunoAvail.Name].Value.ToString();

                    foreach (DS_STUDENT_SEARCHDataSet.tt_student_infoRow student in ds_res_stu.tt_student_info)
                    {
                        if (student.stuno.Equals(stuno, StringComparison.InvariantCultureIgnoreCase))
                        { ds_selected.tt_student_info.LoadDataRow(student.ItemArray, true); break; }
                    }
                }
            }

            if (!validSelection)
            {
                string msg = "You have to select at leat one student from the list of available students.";
                MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RefreshSelectedStudenst();
                RefreshAvailableStudents();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool validSelection = false;
            string stuno = string.Empty;
            List<string> selected = new List<string>();

            foreach (DataGridViewRow item in dgvSelectedStudents.Rows)
            {
                if (item.Cells[ckCheckSelected.Name].Value != null && (bool)item.Cells[ckCheckSelected.Name].Value)
                {
                    validSelection = true;
                    stuno = item.Cells[cStunoSelect.Name].Value.ToString();
                    selected.Add(stuno);
                }
            }

            if (!validSelection)
            {
                string msg = "You have to select at leat one student from the list of selected students.";
                MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                selected.ForEach(delegate(string s)
                {
                    int index = new BindingSource(ds_selected, "tt_student_info").Find("stuno", s);
                    if (index >= 0) { ds_selected.tt_student_info.Rows.Remove(ds_selected.tt_student_info[index]); }
                });

                RefreshSelectedStudenst();
                RefreshAvailableStudents();
            }
        }
 
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                bool validSelection = false;
                string students = string.Empty;

                foreach (DataGridViewRow item in dgvSelectedStudents.Rows)
                {
                    validSelection = true;
                    string stuno = item.Cells[cStunoSelect.Name].Value.ToString();
                    students = string.IsNullOrEmpty(students) ? stuno : string.Concat(students, ",", stuno);
                }

                if (!validSelection)
                {
                    string msg = "You have to add at least one student to the list of students to be included in the report.";
                    MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool showpublish = true;
                    StudentDetails.StudentResults.CourseResultsFilters filters = new StudentDetails.StudentResults.CourseResultsFilters(true);
                    if (filters.ShowDialog().Equals(DialogResult.OK))
                    {
                        //Added these two last parameters to compile 13/07/2016 Mbu
                        Student_Results.Report_Student_Marks report = new Student_Results.Report_Student_Marks(students, filters.ExclUnpubComp, filters.Semester,false,true);
                        report.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.StudentResults, ex);
            }
        }

       #endregion

        #region DataGridView Events

        void dgvSelectedStudents_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dgvSelectedStudents.IsCurrentCellDirty && dgvSelectedStudents.CurrentCell.GetType().Equals(typeof(DataGridViewCheckBoxCell)))
            {
                dgvSelectedStudents.EndEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        void dgvAvailableStudents_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dgvAvailableStudents.IsCurrentCellDirty && dgvAvailableStudents.CurrentCell.GetType().Equals(typeof(DataGridViewCheckBoxCell)))
            {
                dgvAvailableStudents.EndEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        #endregion
    }
}
