using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Res_System
{
    public partial class LetterSettings : Form
    {
        bool can_close = true;

        public LetterSettings()
        {
            InitializeComponent();
        }

        private void LetterSettings_Load(object sender, EventArgs e)
        {
            txtTemplateDir.Text = Properties.Settings.Default.LetterTemplateDirectory;
            txtOutputDir.Text = Properties.Settings.Default.LetterOutputDirectory;
        }

        void LetterSettings_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!can_close) e.Cancel = true;
            can_close = true;
        }

        private void btnBrowseTemplateDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LetterTemplateDirectory) && Directory.Exists(Properties.Settings.Default.LetterTemplateDirectory))
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.LetterTemplateDirectory;

            if (folderBrowserDialog.ShowDialog().Equals(DialogResult.OK)) txtTemplateDir.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnBrowseOutputDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LetterOutputDirectory) && Directory.Exists(Properties.Settings.Default.LetterOutputDirectory))
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.LetterTemplateDirectory;

            if (folderBrowserDialog.ShowDialog().Equals(DialogResult.OK)) txtOutputDir.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidFolderPaths())
            {
                Properties.Settings.Default.LetterTemplateDirectory = txtTemplateDir.Text.Trim();
                Properties.Settings.Default.LetterOutputDirectory = txtOutputDir.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else can_close = false;
        }

        private void txtTemplateDir_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTemplateDir, string.Empty);
        }

        private void txtOutputDir_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtOutputDir, string.Empty);
        }

        bool ValidFolderPaths()
        {
            bool valid = true;

            if (!txtTemplateDir.Text.Trim().Equals(string.Empty))
            {
                if (!Directory.Exists(txtTemplateDir.Text.Trim()))
                {
                    valid = false;
                    errorProvider.SetError(txtTemplateDir, "Invalid folder path");
                }
            }

            if (!txtOutputDir.Text.Trim().Equals(string.Empty))
            {
                if (!Directory.Exists(txtOutputDir.Text.Trim()))
                {
                    valid = false;
                    errorProvider.SetError(txtTemplateDir, "Invalid folder path");
                }
            }

            return valid;
        }
    }
}
