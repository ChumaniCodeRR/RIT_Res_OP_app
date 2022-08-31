using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class tac : Form
    {
        public bool agreed = false;
        MainForm mainForm;

        public tac(MainForm mainForm, bool alreadyagreed)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            agreed = alreadyagreed;
            
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (cb_agree.Checked == true)
            {
                mainForm.agreed = true;
                this.Close();
            }
            else MessageBox.Show("You may not use this program until you have agreed to the terms and conditions.", "Residence System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void tac_Load(object sender, EventArgs e)
        {
            if (agreed == true) 
            {
                btn_cancel.Visible = false;
                btn_proceed.Visible = false;
                btn_ok.Visible = true;
                cb_agree.Checked = true;
                cb_agree.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
