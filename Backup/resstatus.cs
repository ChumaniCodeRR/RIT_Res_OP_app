using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class resstatus : Form
    {
        Reports mainForm;
        public resstatus(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void resstatus_Load(object sender, EventArgs e)
        {
            mainForm.proceed = false;
            cb_status.Items.Add(new Item("Allocated Students", "A"));
            cb_status.Items.Add(new Item("Current Students", "C"));
            cb_status.Items.Add(new Item("Provisional Students", "P"));
            cb_status.SelectedIndex = 0;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempstr1 = ((Item)cb_status.SelectedItem).Value.ToString();
            mainForm.tempbool = cb_mip.Checked;
            mainForm.proceed = true;
            this.Close();
        }

    }
}
