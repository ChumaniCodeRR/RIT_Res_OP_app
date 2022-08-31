using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class DPR : Form
    {
        Reports mainForm;

        public DPR(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void DPR_Load(object sender, EventArgs e)
        {
            cb_exams.Items.Add(new Item("Before Exams", "Before"));
            cb_exams.Items.Add(new Item("After Exams", "After"));
            cb_exams.SelectedIndex = 0;

            cb_period.Items.Add(new Item("June Exams", "J"));
            cb_period.Items.Add(new Item("November Exams", "N"));
            if (DateTime.Today.Month <= 8) cb_period.SelectedIndex = 0;
            else cb_period.SelectedIndex = 1;

            mainForm.proceed = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempstr1 = ((Item)cb_period.SelectedItem).Value.ToString();
            mainForm.tempstr2 = ((Item)cb_exams.SelectedItem).Value.ToString();
            mainForm.proceed = true;
            this.Close();
        }
    }
}
