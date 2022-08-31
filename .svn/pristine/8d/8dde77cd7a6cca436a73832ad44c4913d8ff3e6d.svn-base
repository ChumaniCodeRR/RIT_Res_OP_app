using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
//using Student_System;

namespace Res_System
{
    public partial class ResList : Form
    {
        public string TempRes;
        public string TempHall;
        public int index = 0;


        private MainForm m_parent;

        public ResList(MainForm frm1)
        {
            InitializeComponent();
            m_parent = frm1;
            
        }

        private void ResList_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
            //this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;            
        }

        public void Refresh_Data()
        {
            Global.Global.totalrec = dg_resstu.Rows.Count;
            dg_resstu.DataSource = null;
            dg_resstu.DataSource = Global.Global.ds_stuinfo.tt_student_info;
            dg_resstu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_resstu.Sort(dg_resstu.Columns[1], ListSortDirection.Ascending);
        }
        
        private void dg_resstu_DoubleClick(object sender, EventArgs e)
        {
            if (dg_resstu.RowCount >= 1)
            {
                Global.Global.tempstu = dg_resstu.SelectedCells[0].Value.ToString();
                Global.Global.position = dg_resstu.CurrentRow.Index;
                Global.Global.totalrec = dg_resstu.Rows.Count;
                Global.Global.cont = true;
                m_parent.PerformAction = true;
                m_parent.Update_Stu();                
            }
            
        }

        public void next_row()
        {
            try
            {
                if (Global.Global.ds_stuinfo.tt_student_info.Count >= Global.Global.position + 2)
                {
                    Global.Global.position = Global.Global.position + 1;
                    dg_resstu.FirstDisplayedScrollingRowIndex = Global.Global.position;
                    dg_resstu.Refresh();

                    dg_resstu.CurrentCell = dg_resstu.Rows[Global.Global.position].Cells[0];
                    dg_resstu.Rows[Global.Global.position].Selected = true;
                    Global.Global.tempstu = dg_resstu.SelectedCells[0].Value.ToString();
                    Global.Global.cont = true;
                    m_parent.PerformAction = true;
                    m_parent.Update_Stu();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        public void previous_row()
        {
            try
            {
                if (Global.Global.position - 1 >= 0) Global.Global.position = Global.Global.position - 1;
                dg_resstu.FirstDisplayedScrollingRowIndex = Global.Global.position;
                dg_resstu.Refresh();

                dg_resstu.CurrentCell = dg_resstu.Rows[Global.Global.position].Cells[0];
                dg_resstu.Rows[Global.Global.position].Selected = true;

                Global.Global.tempstu = dg_resstu.SelectedCells[0].Value.ToString();
                Global.Global.cont = true;
                m_parent.PerformAction = true;
                m_parent.Update_Stu();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            next_row();
        }

        
        private void dg_resstu_Sorted(object sender, EventArgs e)
        {

            if (dg_resstu.Rows.Count >= 1)
            {
                Global.Global.position = 0;
                dg_resstu.Rows[Global.Global.position].Selected = true;
                dg_resstu.CurrentCell = dg_resstu[0, 0];
                Global.Global.tempstu = dg_resstu.SelectedCells[0].Value.ToString();
                Global.Global.cont = true;
                Global.Global.totalrec = dg_resstu.Rows.Count;
                //m_parent.PerformAction = false;
                m_parent.Update_Stu();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            Reports frmreports = new Reports("General", "*");
            frmreports.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_resstu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            m_parent.PerformAction = false;
        }

        private void dg_resstu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
