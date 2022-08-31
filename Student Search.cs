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
    public partial class Student_Search : Form
    {
        public Student_Search()
        {
            InitializeComponent();
        }
                
        private string tempstr = "";
        public static string PerformAction;

        private void Student_Search_Load(object sender, EventArgs e)
        {
            try
            {
                if (cb_hall.Items.Count == 0)
                {

                    tempstr = Proxy.System.Get_Sleeping_Halls();

                    string[] temparray = tempstr.Split(new char[] { '|' });
                    cb_hall.Enabled = false;

                    cb_hall.Items.Add(new Item("ANY HALL", "*"));
                    for (int intArray = 0; intArray < temparray.Length; intArray++)
                    {
                        cb_hall.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                        intArray = intArray + 1;
                    }

                    cb_hall.SelectedIndex = 0;
                    cb_hall.Enabled = true;

                    cbres.Items.Add(new Item("ANY RESIDENCE", "*"));
                    cbres.SelectedIndex = 0;

                    tempstr = Proxy.System.Get_Gen("FA");
                    temparray = tempstr.Split(new char[] { '|' });

                    cb_faculty.Enabled = false;
                    cb_acad.Items.Add(new Item("UG & PG STUDENTS", "*"));
                    cb_acad.Items.Add(new Item("UG STUDENTS", "UG"));
                    cb_acad.Items.Add(new Item("PG STUDENTS", "PG"));
                    cb_acad.SelectedIndex = 0;

                    cb_faculty.Items.Add(new Item("ALL FACULTIES", "*"));
                    for (int intArray = 0; intArray < temparray.Length; intArray++)
                    {
                        cb_faculty.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                        intArray = intArray + 1;
                    }

                    cb_faculty.SelectedIndex = 0;
                    cb_faculty.Enabled = true;


                    cb_degree.Items.Add(new Item("ANY DEGREE", "*"));
                    cb_degree.SelectedIndex = 0;
                    tempstr = Proxy.System.Get_Dept();

                    temparray = tempstr.Split(new char[] { '|' });

                    cb_dept.Enabled = false;
                    cb_dept.Items.Add(new Item("ALL DEPARTMENTS", "*"));
                    for (int intArray = 0; intArray < temparray.Length; intArray++)
                    {
                        cb_dept.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                        intArray = intArray + 1;
                    }

                    cb_dept.SelectedIndex = 0;
                    cb_dept.Enabled = true;

                    cb_subj.Items.Add(new Item("ANY SUBJECT", "*"));
                    cb_subj.SelectedIndex = 0;

                    cb_race.Items.Add(new Item("ALL RACES", "*"));
                    cb_race.Items.Add(new Item("AFRICAN", "B"));
                    cb_race.Items.Add(new Item("COLOURED", "C"));
                    cb_race.Items.Add(new Item("INDIAN", "A"));
                    cb_race.Items.Add(new Item("WHITE", "D"));
                    cb_race.SelectedIndex = 0;

                    cb_gender.Items.Add(new Item("BOTH GENDERS", "*"));
                    cb_gender.Items.Add(new Item("MALE STUDENTS", "MALE"));
                    cb_gender.Items.Add(new Item("FEMALE STUDENTS", "FEMALE"));
                    cb_gender.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
                
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NS_Student_Search.StrongTypesNS.DS_STUSEARCHDataSet ds_stusearch = new NS_Student_Search.StrongTypesNS.DS_STUSEARCHDataSet();
                DataRow newrow = ds_stusearch.TT_STUSEARCH.NewRow();

                newrow["stuno"] = txtstuno.Text;
                newrow["surn"] = txtsurn.Text;
                newrow["name1"] = txtname.Text;
                newrow["id"] = txtid.Text;
                newrow["sex"] = ((Item)cb_gender.SelectedItem).Value.ToString();
                newrow["race"] = ((Item)cb_race.SelectedItem).Value.ToString();
                newrow["hall"] = ((Item)cb_hall.SelectedItem).Value.ToString();
                newrow["res"] = ((Item)cbres.SelectedItem).Value.ToString();

                if (((Item)cb_faculty.SelectedItem).Value.ToString() == "*") newrow["faculty"] = "*";
                else newrow["faculty"] = ((Item)cb_faculty.SelectedItem).Name.ToString();

                newrow["acad"] = ((Item)cb_acad.SelectedItem).Value.ToString();
                newrow["degr"] = ((Item)cb_degree.SelectedItem).Value.ToString();
                newrow["dept"] = ((Item)cb_dept.SelectedItem).Value.ToString();
                newrow["subj"] = ((Item)cb_subj.SelectedItem).Value.ToString();
                newrow["vehreg"] = txt_veh_reg.Text;
                ds_stusearch.TT_STUSEARCH.Rows.Add(newrow);

                if (radioButton1.Checked == true) Global.Global.ds_stuinfo = Proxy.StudentSearch.Search_Reg_Student_Criteria(ds_stusearch);
                else Global.Global.ds_stuinfo = Proxy.StudentSearch.Search_All_Student_Criteria(ds_stusearch);
                if (Global.Global.ds_stuinfo.tt_student_info.Rows.Count >= 1) this.Close();
                else MessageBox.Show("Your Query Generated No Results", "Custom Query", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_hall.Enabled == true)
                {
                    cbres.Items.Clear();
                    cbres.Enabled = false;
                    cbres.Items.Add(new Item("ANY RESIDENCE", "*"));

                    if (((Item)cb_hall.SelectedItem).Value.ToString() != "*")
                    {
                        tempstr = Proxy.System.Get_Residences(((Item)cb_hall.SelectedItem).Value.ToString());

                        string[] residence = tempstr.Split(new char[] { '|' });


                        for (int intArray = 0; intArray < residence.Length; intArray++)
                        {
                            cbres.Items.Add(new Item(residence[intArray + 1], residence[intArray]));
                            intArray = intArray + 1;
                        }
                    }
                    cbres.SelectedIndex = 0;
                    if (((Item)cb_hall.SelectedItem).Value.ToString() != "*") cbres.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_faculty.Enabled == true) Get_Degree();
        }

        private void Get_Degree()
        {
            try
            {
                cb_degree.Enabled = false;
                cb_degree.Items.Clear();
                cb_degree.Items.Add(new Item("ANY DEGREE", "*"));

                if (((Item)cb_faculty.SelectedItem).Value.ToString() != "*")
                {
                    tempstr = Proxy.System.Get_Degrees_By_Faculty(((Item)cb_faculty.SelectedItem).Name.ToString(), ((Item)cb_acad.SelectedItem).Value.ToString());
                    if (tempstr != "")
                    {
                        string[] temparray = tempstr.Split(new char[] { '|' });



                        for (int intArray = 0; intArray < temparray.Length; intArray++)
                        {
                            cb_degree.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                            intArray = intArray + 1;
                        }


                    }
                }
                cb_degree.SelectedIndex = 0;
                if (((Item)cb_faculty.SelectedItem).Value.ToString() != "*") cb_degree.Enabled = true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_acad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_faculty.Enabled == true) Get_Degree();
            Get_Subj();
        }

        private void cb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_dept.Enabled == true)
            {
                cb_subj.Enabled = true;
                Get_Subj();
            }
        }

        private void Get_Subj()
        {
            try
            {
                if (cb_subj.Enabled == true)
                {
                    cb_subj.Enabled = false;
                    cb_subj.Items.Clear();
                    if (((Item)cb_dept.SelectedItem).Value.ToString() == "*")
                    {
                        cb_subj.Items.Add(new Item("ANY SUBJECT", "*"));
                    }
                    else
                    {
                        tempstr = Proxy.System.Get_Subjects_By_Dept(DateTime.Today.Year,
                            ((Item)cb_acad.SelectedItem).Value.ToString(),
                            ((Item)cb_dept.SelectedItem).Value.ToString());

                        string[] temparray = tempstr.Split(new char[] { '|' });

                        cb_subj.Items.Add(new Item("ANY SUBJECT IN " + ((Item)cb_dept.SelectedItem).Name.ToString(), "*"));
                        for (int intArray = 0; intArray < temparray.Length; intArray++)
                        {
                            cb_subj.Items.Add(new Item(temparray[intArray + 1], temparray[intArray]));
                            intArray = intArray + 1;
                        }
                    }
                    cb_subj.SelectedIndex = 0;
                    cb_subj.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_veh_reg.Text = "";
            txtstuno.Text = "";
            txtsurn.Text = "";
            txtname.Text = "";
            txtid.Text = "";
            cb_gender.SelectedIndex = 0;
            cb_race.SelectedIndex = 0;
            cb_hall.SelectedIndex = 0;
            cb_faculty.SelectedIndex = 0;
            cb_dept.SelectedIndex = 0;
            cb_acad.SelectedIndex = 0;
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_all.Checked == true)

            { panel2.Visible = false; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) panel2.Visible = true;
        }
        

    }
}