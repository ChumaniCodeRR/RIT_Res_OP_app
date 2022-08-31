namespace Captured_By
{
    partial class captured_by
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captured_by));
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(328, 41);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(154, 20);
            this.dt_end.TabIndex = 83;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(288, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 82;
            this.label18.Text = "till the";
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(128, 41);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(154, 20);
            this.dt_start.TabIndex = 81;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Captured Between the";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Captured By:";
            // 
            // cb_users
            // 
            this.cb_users.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_users.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(83, 6);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(399, 21);
            this.cb_users.TabIndex = 87;
            // 
            // captured_by
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 106);
            this.Controls.Add(this.cb_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "captured_by";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "captured_by";
            this.Load += new System.EventHandler(this.captured_by_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_users;
    }
}