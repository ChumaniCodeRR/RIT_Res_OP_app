using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class SelectYear : Form
    {
        public bool proceed; 
       public int _tempyr;

       public SelectYear()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tempyr = Int32.Parse(txt_yr.Text);
            proceed = true;
            this.Close();
        }

        private void txt_yr_Click(object sender, EventArgs e)
        {
            this.txt_yr.SelectAll();
        }

        private void SelectYear_Load(object sender, EventArgs e)
        {
            txt_yr.Text = DateTime.Today.Year.ToString();
            proceed = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            proceed = false;
            this.Close();
        }
    }
}
