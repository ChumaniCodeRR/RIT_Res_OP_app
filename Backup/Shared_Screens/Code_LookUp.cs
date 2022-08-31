using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Code_LookUp
{
    public partial class Code_LookUp : Form
    {
        string lookup = "";
        string _Code;
        string _Descrip;
        string _Category;

        public Code_LookUp(string lookup)
        {
            this.lookup = lookup;
            InitializeComponent();
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public string Descrip
        {
            get { return _Descrip; }
            set { _Descrip = value; }
        }

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }


        private void Code_LookUp_Load(object sender, EventArgs e)
        {
            DataView dv_codes = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_codes.RowFilter = "type = '" + lookup + "'";
            tt_genbadBindingSource.DataSource = dv_codes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv_codes = new DataView(Global.Global.ds_badcodes.tt_genbad);
            dv_codes.RowFilter = "type = '" + lookup + "' and descrip like '*" + txtfilter.Text + "*'";
            tt_genbadBindingSource.DataSource = dv_codes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            _Code = dg_codes.SelectedCells[1].Value.ToString();
            _Descrip = dg_codes.SelectedCells[2].Value.ToString();
            _Category = dg_codes.SelectedCells[3].Value.ToString();
            this.Close();
        }
    }
}
