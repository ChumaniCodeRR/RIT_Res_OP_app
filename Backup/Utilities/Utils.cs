using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;

namespace Utilities
{
    internal static class Utils
    {
        /// <summary>
        /// Handles runtime application exceptions
        /// </summary>
        /// <param name="source">Source of the exception</param>
        /// <param name="ex">Exception to handle</param>
        internal static void HandleException(string source, Exception ex)
        {
            EventLog.WriteEntry(source, ex.ToString(), EventLogEntryType.Error);
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.GetType().Equals(typeof(Proxy.SessionExpiredException)))
            {
                try
                {
                    Application.Restart();
                }
                catch
                {
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Converts the first character of each word in the space delimited 'source' string to uppercase, and the rest to lowercases
        /// </summary>
        /// <param name="source">Space delimited source string to format</param>
        /// <returns>A formatted string with the first letter of each word as uppercase and the rest as lowercases</returns>
        internal static string ToUpperFirstLetter(string source)
        {
            if (source == null || source.Trim().Equals(string.Empty))
                return string.Empty;

            string upper = string.Empty;
            List<string> names = new List<string>(source.Trim().ToLower().Split(' '));

            names.ForEach(delegate(string s)
            {
                char[] letters = s.ToCharArray();
                letters[0] = Char.ToUpper(letters[0]);
                upper = string.IsNullOrEmpty(upper) ? new string(letters) :
                    string.Format("{0} {1}", upper, new string(letters));
            });

            return upper;
        }
    }

    internal static class UpdateAction
    {
        internal static string Save = "Save";
        internal static string Cancel = "Cancel";
    }

    internal static class MessageBoxCaption
    {
        internal const string Information = "Information";
        internal const string Error = "Error";
        internal const string Warning = "Warning";
        internal const string Question = "Question";
        internal const string Retry = "Retry";
    }

    /// <summary>
    /// Sources where runtime applications are thrown
    /// </summary>
    internal static class ExceptionSource
    {
        internal const string StudentPersonalDetails = "Student Personal Details";
        internal const string ResAccess = "Res Access";
        internal const string DisciplineSystem = "Discipline System";
        internal const string SharedReportCriteria = "Shared Report Criteria";
        internal const string SharedCapturedBy = "Shared Captured By";
        internal const string DisciplineScreen = "Discipline Screen";
        internal const string DisciplineReports = "Discipline Reports";
        internal const string HealthCareSystem = "Health Care System";
        internal const string LetterProgram = "Letter Program";
        internal const string VenueSystem = "Venue System";
        internal const string RUTalk = "RU Talk";
        internal const string ResSystem = "Res System";
        internal const string StudentResults = "Student Results";
        internal const string StudentMedicalDetails = "Student Medical Details";
        internal const string MedicalReport = "Medical Report";
        internal const string InterDeptOrder = "Inter Deartmental Order";
        internal const string RegSystem = "Registration System";
        internal const string Wizard = "Wizard";
        internal const string ResPlanning = "ResPlanning";
    }
}
