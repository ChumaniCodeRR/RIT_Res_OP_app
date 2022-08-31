using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringBox
{
    public partial class StringBox : Form
    {
        Reports_Disc.Reports mainForm;
        public string quest = "";
        public string caption = "";

        public StringBox(Reports_Disc.Reports mainForm, string question, string caption)
        {
            this.mainForm = mainForm;
            this.caption = caption;
            this.quest = question;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_value.Text == "") MessageBox.Show("Please enter a value to search for", "No text entered", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                mainForm.tempstu = txt_value.Text;
                this.Close();
            }

        }

        private void String_Load(object sender, EventArgs e)
        {
            this.Text = caption;
            txt_string.Text = quest;
        }
    }
}
