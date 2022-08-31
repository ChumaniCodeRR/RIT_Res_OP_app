using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class Year_Exam : Form
    {
        Reports mainForm;
        public Year_Exam(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempyr = Int32.Parse(txt_yr.Text);
            mainForm.tempstr1 = ((Item)cb_period.SelectedItem).Value.ToString();
            mainForm.proceed = true;
            this.Close();

        }

        private void Year_Exam_Load(object sender, EventArgs e)
        {
            txt_yr.Text = DateTime.Today.Year.ToString();
            if (mainForm.action == "PassRate") lbl_time.Visible = true;
            cb_period.Items.Add(new Item("June Results", "J"));
            cb_period.Items.Add(new Item("Final Results", "F"));
            if (DateTime.Today.Month <= 8) cb_period.SelectedIndex = 0;
            else cb_period.SelectedIndex = 1;
            mainForm.proceed = false;
        }
    }
}
