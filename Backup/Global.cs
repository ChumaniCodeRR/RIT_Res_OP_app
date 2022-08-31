using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using AppServer;



namespace Global
{
    public abstract class Global
    {
        
        public static string tempstu;
        public static bool cont = true; //continue with change or not...
        //public static NS_ResSystem.StrongTypesNS.DS_STUINFODataSet ds_stuinfo;
        public static NS_Student_Search.StrongTypesNS.DS_STUINFODataSet ds_stuinfo;
        public static NS_System.StrongTypesNS.ds_stuDataSet ds_Stu;
        public static int position = 0;
        public static int totalrec = 0;
        public static DateTime Lasttime = DateTime.Now;
        public static string resname = "";
        public static string hallname = "";
        public static string hallcode = "";
        public static int rescode = 0;
        public static NS_System.StrongTypesNS.DS_PHOTODataSet ds_logo;
        public static NS_System.StrongTypesNS.DS_RESCODESDataSet ds_rescodes;
        public static NS_Discipline.StrongTypesNS.DS_STUBADDataSet ds_badcodes;
        public static bool custom = false;
        public static string type = "";
        
        public static DataRow CurrentRow(DataGrid aGrid)
        {

            CurrencyManager xCM =
              (CurrencyManager)aGrid.BindingContext[aGrid.DataSource, aGrid.DataMember];
            DataRowView xDRV = (DataRowView)xCM.Current;
            return xDRV.Row;
        }

    }
}
