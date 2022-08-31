using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Res_System.SearchOptions
{
    public partial class PickSemester : Form
    {

        public string Semester = "";

        public PickSemester()
        {
            InitializeComponent();
        }

        private void PickSemester_Load(object sender, EventArgs e)
        {
            cbSemester.SelectedIndex = 0;
        }
               
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbSemester.Text.Contains("All")) Semester = "*";
            else Semester = cbSemester.Text;
            this.Close();
        }
    }
}
