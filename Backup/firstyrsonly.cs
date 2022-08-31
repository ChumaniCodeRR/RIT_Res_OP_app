using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class firstyrsonly : Form
    {
        Reports mainForm;
        public firstyrsonly(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void firstyrsonly_Load(object sender, EventArgs e)
        {
            cb_period.Items.Add(new Item("All Students", "A"));
            cb_period.Items.Add(new Item("First Year Students Only", "F"));
            cb_period.Items.Add(new Item("Returning Students Only", "R"));
            cb_period.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempstu = ((Item)cb_period.SelectedItem).Value.ToString();
            mainForm.proceed = true;
            this.Close();
        }
    }
}
