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
    public partial class SearchDates : Form
    {
        public bool proceed;
        public DateTime DateFrom;
        public DateTime DateTo;

        public SearchDates()
        {
            InitializeComponent();
        }

        private void SearchDates_Load(object sender, EventArgs e)
        {
            dteFrom.Value = DateTime.Today;
            dteTo.Value = DateTime.Today;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (dteTo.Value < dteFrom.Value) MessageBox.Show("End Date cannot be before Start Date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                proceed = true;
                DateFrom = dteFrom.Value;
                DateTo = dteTo.Value;
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            proceed = false;
            this.Close();
        }
    }
}
