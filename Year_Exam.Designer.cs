namespace Res_System
{
    partial class Year_Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Year_Exam));
            this.txt_yr = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_period = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_yr
            // 
            this.txt_yr.Location = new System.Drawing.Point(52, 6);
            this.txt_yr.Mask = "0000";
            this.txt_yr.Name = "txt_yr";
            this.txt_yr.Size = new System.Drawing.Size(40, 20);
            this.txt_yr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year:";
            // 
            // cb_period
            // 
            this.cb_period.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_period.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_period.FormattingEnabled = true;
            this.cb_period.Location = new System.Drawing.Point(89, 32);
            this.cb_period.Name = "cb_period";
            this.cb_period.Size = new System.Drawing.Size(190, 21);
            this.cb_period.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Exam Period:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(31, 64);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(228, 13);
            this.lbl_time.TabIndex = 10;
            this.lbl_time.Text = "Please note that this report takes a while to run";
            this.lbl_time.Visible = false;
            // 
            // Year_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 113);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_period);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Year_Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please enter a year and select exam period";
            this.Load += new System.EventHandler(this.Year_Exam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_yr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_period;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_time;
    }
}