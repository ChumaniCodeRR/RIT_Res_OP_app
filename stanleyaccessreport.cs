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
    public partial class stanleyaccessreport : Form
    {
        Reports mainForm;
        public stanleyaccessreport(Reports mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void stanleyaccessreport_Load(object sender, EventArgs e)
        {
            try
            {
                string tempstr = Proxy.Stanley.Get_Stanley_Types();
                string[] temphall = tempstr.Split(new char[] { '|' });
                cb_types.Enabled = false;
                cb_types.Items.Add(new Item("All Categories of People", "*"));
                for (int intArray = 0; intArray < temphall.Length; intArray++)
                {
                    cb_types.Items.Add(new Item(temphall[intArray + 1], temphall[intArray]));
                    intArray = intArray + 1;
                }
                cb_types.SelectedIndex = 0;
                cb_types.Enabled = true;
                cb_class.Items.Add(new Item("All Sub-Categories of People", "*"));
                cb_class.SelectedIndex = 0;

                mainForm.proceed = false;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void cb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_types.Enabled == true)
                {
                    cb_class.Items.Clear();
                    string tempstr = Proxy.Stanley.Get_Stanley_Class(((Item)cb_types.SelectedItem).Value.ToString());

                    string[] temphall = tempstr.Split(new char[] { '|' });
                    cb_class.Items.Add(new Item("All Sub-Categories of People", "*"));
                    if (tempstr != "")
                    {
                        for (int intArray = 0; intArray < temphall.Length; intArray++)
                        {
                            cb_class.Items.Add(new Item(temphall[intArray + 1], temphall[intArray]));
                            intArray = intArray + 1;
                        }
                    }
                    cb_class.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tempdte1 = dt_start.Value;
            mainForm.tempdte2 = dt_end.Value;
            mainForm.tempstr1 = ((Item)cb_types.SelectedItem).Value.ToString();
            mainForm.tempstr2 = ((Item)cb_class.SelectedItem).Value.ToString();
            mainForm.proceed = true;
            this.Close();
        }
    }
}
