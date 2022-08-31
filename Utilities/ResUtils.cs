﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Res_System.Utilities
{
    internal class ResUtils
    {

        internal static List<string> GetExcelWorksheetNames(string file)
        {
            Microsoft.Office.Interop.Excel.Application application = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            try
            {
                List<string> worksheets = new List<string>();
                application = new Microsoft.Office.Interop.Excel.Application();
                workbook = application.Workbooks.Open(file);

                foreach (Microsoft.Office.Interop.Excel.Worksheet worksheet in workbook.Worksheets)
                {
                    worksheets.Add(worksheet.Name);
                }
                return worksheets;
            }
            finally
            {
                if (workbook != null) workbook.Close();
            }
        }

        internal static void GenerateAddressLabels(char addressType, string stu_list, string templateFile, string outputFile)
        {
            try
            {
                //if (!Directory.Exists(Properties.Settings.Default.LetterTemplateDirectory))
                //{
                //    string msg = "The templete director specified does not exist. Make sure that the path is correct and try again.";
                //    MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                //}

                /*string templateFile = string.Concat(Properties.Settings.Default.LetterTemplateDirectory, @"\Labels.doc");*/
                templateFile = templateFile + @"\Labels.doc";

                if (!File.Exists(templateFile))
                {
                    string msg = "Templete file 'Labels.doc' does not exist in the specified template directory.";
                    MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                NS_Letters.StrongTypesNS.DS_ADHOCDataSet ds_adhoc = Proxy.Letter_System.Adhoc_Letters(addressType.ToString(), stu_list);

                /*string outputFile = string.Concat(Properties.Settings.Default.LetterOutputDirectory, @"\Labels.doc");*/
                outputFile = outputFile + @"\Labels.doc";
                StreamWriter stream = new StreamWriter(outputFile);
                stream.WriteLine("LINE1|LINE2|LINE3|LINE4|LINE5|LINE6|LINE7");

                string stuname = string.Empty;
                foreach (NS_Letters.StrongTypesNS.DS_ADHOCDataSet.TT_ADHOCRow adhoc in ds_adhoc.TT_ADHOC.Rows)
                {
                    stuname = string.Concat(adhoc.FTITL, " ", adhoc.INITIALS, " ", adhoc.FSURN);
                    stream.WriteLine(string.Concat(adhoc.STUDENT, "|", stuname, "|", adhoc.FADDR1, "|", adhoc.FADDR2, "|", adhoc.FADDR3, "|", adhoc.FADDR4, "|", adhoc.FADDR5));
                }
                stream.Close();

                MailMerge.PerformMailMerge(templateFile, outputFile);
            }
            catch (UnauthorizedAccessException)
            {
                string msg = "You do not have access to either the template or output director";
                MessageBox.Show(msg, "Department System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
