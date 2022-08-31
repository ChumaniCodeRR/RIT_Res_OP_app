using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class Year : Form
    {
        Reports mainForm;

        public Year(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempyr = Int32.Parse(txt_yr.Text);
            mainForm.proceed = true;
            this.Close();
        }

        private void txt_yr_Click(object sender, EventArgs e)
        {
            this.txt_yr.SelectAll();
        }

        private void Year_Load(object sender, EventArgs e)
        {
            txt_yr.Text = DateTime.Today.Year.ToString();
            mainForm.proceed = false;
        }
    }
}
