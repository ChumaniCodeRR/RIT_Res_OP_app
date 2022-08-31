using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class AttendanceRegister : Form
    {

        string _eventDetails;
        DateTime _eventDate;
        string _tempstu = "";

        public AttendanceRegister()
        {
            InitializeComponent();
        }

        public string tempstudents
        {
            get { return _tempstu; }
            set { _tempstu = value; }
        }

        public string EventDetails
        {
            get { return _eventDetails; }
            set { _eventDetails = value; }
        }

        public DateTime EventDate
        {
            get { return _eventDate; }
            set { _eventDate = value; }
        }

        private void AttendanceRegister_Load(object sender, EventArgs e)
        {
            cb_period.Items.Add(new Item("All Students", "A"));
            cb_period.Items.Add(new Item("First Year Students Only", "F"));
            cb_period.Items.Add(new Item("Returning Students Only", "R"));
            cb_period.SelectedIndex = 0;

            dteEvent.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_event.Text == string.Empty) MessageBox.Show("Please enter event details to continue", "Error Details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                _eventDetails = txt_event.Text.ToString();
                _eventDate = dteEvent.Value;
                _tempstu = ((Item)cb_period.SelectedItem).Value.ToString();
                this.Close();
            }
        }
    }
}
