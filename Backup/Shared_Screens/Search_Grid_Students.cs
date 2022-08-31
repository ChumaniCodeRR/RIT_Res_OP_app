using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Search_Grid_Students
{
    public partial class Search_Grid_Students : Form
    {

        string _Stuno = "";
        string _Surn = "";
        string _Name = "";
        
        
        public Search_Grid_Students()
        {
            InitializeComponent();
        }

        public string Stuno
        {
            get { return _Stuno; }
            set { _Stuno = value; }
        }

        public string Surname
        {
            get { return _Surn; }
            set { _Surn = value; }
        }

        public string First_Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        private void Search_Grid_Students_Load(object sender, EventArgs e)
        {

            filter();
        }

        private void txt_stuno_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            DataView dv_stu = new DataView(Global.Global.ds_Stu.TT_STU);
            dv_stu.RowFilter = "stuno like '*" + txt_stuno.Text + "*' and surn like '*" + txt_surn.Text + "*' and name1 like '*" 
                + txt_name.Text + "*' and prefer_name like '*" + txt_prefer_name.Text + "*'";
            tT_STUBindingSource.DataSource = dv_stu;
        }

        private void txt_surn_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_prefer_name_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_codes_DoubleClick(object sender, EventArgs e)
        {
            _Stuno = dg_codes.SelectedCells[0].Value.ToString();
            _Surn = dg_codes.SelectedCells[1].Value.ToString();
            _Name = dg_codes.SelectedCells[2].Value.ToString();
            this.Close();
        }
    }
}
