﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class Function : Form
    {
        Reports mainForm;

        public Function(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Function_Load(object sender, EventArgs e)
        {
            dt_function.MinDate = DateTime.Today;
            dt_function.Value = DateTime.Today.AddDays(9);
            dt_complete_by.MinDate = DateTime.Today;
            dt_complete_by.Value = DateTime.Today.AddDays(7);
            cb_function_time.SelectedIndex = 2;
            cb_type.SelectedIndex = 0;
            mainForm.proceed = false;
        }

        private void populate_parameters()
        {
            mainForm.p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Function_Details", "Function: " 
                + txt_description.Text + " on the " + dt_function.Value.ToLongDateString() + " over " + cb_function_time.Text.ToString()
                + " Time");
            mainForm.p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Function_Instruction", 
                "Only indicate on this form if you: (i) are not attending the function mentioned above; (ii) wish to change the number of meals booked; " +
                "(iii) or if you want to change your diet choice. Please sign any changes that you make OR If you are double booking your meal. " +
                "If there are no changes made to this form then you will be booked for the function as per the details below. " +
                "This list will be removed on the " + dt_complete_by.Value.ToLongDateString());
            mainForm.p[3] = new Microsoft.Reporting.WinForms.ReportParameter("bookings", cb_type.Text);
            mainForm.tempbuilding = cb_building.Checked;
            mainForm.proceed = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_description.Text != "")
            {
                populate_parameters();
                this.Close();
            }
            else MessageBox.Show("Please enter a description of the function", "No Description", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
