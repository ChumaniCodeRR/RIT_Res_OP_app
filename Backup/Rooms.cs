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
    public partial class Rooms : Form
    {
        public Rooms(string resname, string rescode)
        {
            InitializeComponent();
            lbl_res.Text = resname;
            lbl_res.Tag = rescode;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            try
            {
                NS_System.StrongTypesNS.DS_RESCODESDataSet ds_sections
                    = Proxy.System.Get_Sections_For_Building(Global.Global.rescode);

                string tempstr = Proxy.System.Get_Buildings(Int32.Parse(lbl_res.Tag.ToString()));

                tT_SECTIONSBindingSource.DataSource = ds_sections.TT_SECTIONS;

                string[] templist = tempstr.Split(new char[] { '|' });
                cb_building.Enabled = false;
                if (tempstr != "")
                {
                    for (int intArray = 0; intArray < templist.Length; intArray++)
                    {
                        cb_building.Items.Add(new Item(templist[intArray + 1], templist[intArray]));
                        intArray = intArray + 1;
                    }

                    cb_building.SelectedIndex = 0;
                    cb_building.Enabled = true;

                    Get_Rooms();
                }
                else
                {
                    MessageBox.Show("Estates have not loaded the buildings and rooms for " + DateTime.Today.Year.ToString() + ". Please contact spaceuse@ru.ac.za", "Unable to load information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void Get_Rooms()
        {
            try
            {
                NS_ResSystem.StrongTypesNS.DS_RESDataSet ds_res = Proxy.Res_System.All_Res_Rooms(((Item)cb_building.SelectedItem).Value.ToString());

                DataView DV = new DataView(ds_res.TT_ROOMS);
                DV.Sort = "ROOM_SORT ASC, ROOM_NO ASC";

                tT_ROOMSBindingSource.DataSource = DV;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

                       
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_roomno.Text != "")
                {
                    Proxy.Res_System.Edit_Room_Info(((Item)cb_building.SelectedItem).Value.ToString(), txt_roomno.Text,
                        Int32.Parse(cb_sections.SelectedValue.ToString()), txt_intercom.Text);
                    Get_Rooms();

                }
                else MessageBox.Show("Please select a room first", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_building_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_building.Enabled == true)
            {
                Get_Rooms();                
            }
        }

        private void dg_buildings_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dg_buildings_Click(object sender, EventArgs e)
        {

        }               
    }
}
