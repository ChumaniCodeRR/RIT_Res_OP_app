using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class DateRange : Form
    {
        Reports mainForm;

        public DateRange(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void DateRange_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempdte1 = dt_start.Value;
            mainForm.tempdte2 = dt_end.Value;
            mainForm.proceed = true;
            this.Close();
        }
    }
}
