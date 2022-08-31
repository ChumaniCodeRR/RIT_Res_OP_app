using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class Results_Year : Form
    {
        Reports mainForm;
        
        public Results_Year(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Results_Year_Load(object sender, EventArgs e)
        {
            cb_year.Items.Add(new Item("All Years", "0"));
            cb_year.Items.Add(new Item(DateTime.Today.Year.ToString() + " Results", DateTime.Today.Year.ToString()));
            cb_year.Items.Add(new Item((DateTime.Today.Year - 1).ToString() + " Results", (DateTime.Today.Year - 1).ToString()));

            cb_students.Items.Add(new Item((DateTime.Today.Year) + " Students", DateTime.Today.Year.ToString()));
            cb_students.Items.Add(new Item((DateTime.Today.Year - 1) + " Students", (DateTime.Today.Year - 1).ToString()));

            cb_year.SelectedIndex = 0;
            cb_students.SelectedIndex = 0;

            if (mainForm.tempstu != "*")
            {
                cb_students.Visible = false;
                lbl_show.Visible = false;
            }
            mainForm.proceed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.showyr = Int32.Parse(((Item)cb_year.SelectedItem).Value.ToString());
            mainForm.tempyr = Int32.Parse(((Item)cb_students.SelectedItem).Value.ToString());
            mainForm.proceed = true;
            this.Close();
        }
    }
}
