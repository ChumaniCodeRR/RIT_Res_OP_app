namespace Res_System
{
    partial class Results_Year
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results_Year));
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_show = new System.Windows.Forms.Label();
            this.cb_students = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_year
            // 
            this.cb_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(111, 37);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(201, 21);
            this.cb_year.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Year:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(12, 9);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(93, 13);
            this.lbl_show.TabIndex = 3;
            this.lbl_show.Text = "Show Results For:";
            // 
            // cb_students
            // 
            this.cb_students.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_students.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_students.FormattingEnabled = true;
            this.cb_students.Location = new System.Drawing.Point(111, 6);
            this.cb_students.Name = "cb_students";
            this.cb_students.Size = new System.Drawing.Size(201, 21);
            this.cb_students.TabIndex = 4;
            // 
            // Results_Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 112);
            this.Controls.Add(this.cb_students);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_year);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results_Year";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Year:";
            this.Load += new System.EventHandler(this.Results_Year_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.ComboBox cb_students;
    }
}