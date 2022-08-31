using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;



namespace Res_System
{
    public partial class Sections : Form
    {
        public Sections(string resname, string rescode)
        {
            InitializeComponent();
            lbl_res.Text = resname;
            lbl_res.Tag = rescode;
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            Get_Sections(); 
        }

        private void Get_Sections()
        {
            try
            {
                NS_ResSystem.StrongTypesNS.DS_RESDataSet ds_res = Proxy.Res_System.Get_Res_Sections(Int32.Parse(lbl_res.Tag.ToString()));

                dg_sections.DataSource = null;
                dg_sections.DataSource = ds_res.TT_SECTIONS;
                dg_sections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dg_sections.Columns[0].Visible = false;
                dg_sections.Columns[1].HeaderText = "Section";
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_sections.RowCount >= 1)
                {
                    if (MessageBox.Show("You sure you want to remove this section - " + dg_sections.SelectedCells[1].Value.ToString() + "?", "Confirm Section Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string feedback = Proxy.Res_System.Remove_Res_Section(Int32.Parse(lbl_res.Tag.ToString()),
                            Int32.Parse(dg_sections.SelectedCells[0].Value.ToString()));
                        if (feedback != "") MessageBox.Show(feedback, "Remove Section Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else Get_Sections();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_section.Text != "")
                {
                    string feedback = Proxy.Res_System.Add_Res_Section(Int32.Parse(lbl_res.Tag.ToString()), txt_section.Text);

                    if (feedback != "") MessageBox.Show(feedback, "Add Section Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else Get_Sections();
                    txt_section.Text = "";
                }
                else MessageBox.Show("Please enter a section name first", "No Section Name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }
    }
}
