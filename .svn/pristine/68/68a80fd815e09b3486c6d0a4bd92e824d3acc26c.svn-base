using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class OppiSearch : Form
    {
        public OppiSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_searchstr.Text == "")
            {
                MessageBox.Show("Street address/name cannot be blank", "Address query", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                Reports frmreports = new Reports("OppiStunos", txt_searchstr.Text);
                frmreports.Show();
             }
        }
    }
}
