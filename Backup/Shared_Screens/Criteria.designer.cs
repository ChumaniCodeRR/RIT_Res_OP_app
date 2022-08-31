namespace Criteria
{
    partial class Criteria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criteria));
            this.label9 = new System.Windows.Forms.Label();
            this.cb_hall = new System.Windows.Forms.ComboBox();
            this.cbres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_keywords = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_badcode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_report = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdc = new System.Windows.Forms.TextBox();
            this.txt_aog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_hearing = new System.Windows.Forms.ComboBox();
            this.cb_authority = new System.Windows.Forms.ComboBox();
            this.cb_authorityfrom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_registered = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Sleeping Hall:";
            // 
            // cb_hall
            // 
            this.cb_hall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_hall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hall.FormattingEnabled = true;
            this.cb_hall.Location = new System.Drawing.Point(113, 66);
            this.cb_hall.Name = "cb_hall";
            this.cb_hall.Size = new System.Drawing.Size(243, 21);
            this.cb_hall.TabIndex = 52;
            this.cb_hall.SelectedIndexChanged += new System.EventHandler(this.cb_hall_SelectedIndexChanged);
            // 
            // cbres
            // 
            this.cbres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbres.Enabled = false;
            this.cbres.FormattingEnabled = true;
            this.cbres.Location = new System.Drawing.Point(489, 66);
            this.cbres.Name = "cbres";
            this.cbres.Size = new System.Drawing.Size(243, 21);
            this.cbres.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Residence:";
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(421, 237);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(154, 20);
            this.dt_end.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "till the";
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(221, 237);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(154, 20);
            this.dt_start.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Disciplinary offence committed between:";
            // 
            // txt_keywords
            // 
            this.txt_keywords.Location = new System.Drawing.Point(21, 286);
            this.txt_keywords.Name = "txt_keywords";
            this.txt_keywords.Size = new System.Drawing.Size(711, 20);
            this.txt_keywords.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(501, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Fines with the following keyword(s) in the description of the offence - use a com" +
                "ma to seperate keywords:";
            // 
            // cb_badcode
            // 
            this.cb_badcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_badcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_badcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_badcode.FormattingEnabled = true;
            this.cb_badcode.Location = new System.Drawing.Point(113, 147);
            this.cb_badcode.Name = "cb_badcode";
            this.cb_badcode.Size = new System.Drawing.Size(243, 21);
            this.cb_badcode.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Offence Category:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 84;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Report On:";
            // 
            // cb_report
            // 
            this.cb_report.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_report.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_report.FormattingEnabled = true;
            this.cb_report.Location = new System.Drawing.Point(113, 39);
            this.cb_report.Name = "cb_report";
            this.cb_report.Size = new System.Drawing.Size(619, 21);
            this.cb_report.TabIndex = 86;
            this.cb_report.SelectedIndexChanged += new System.EventHandler(this.cb_report_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(113, 120);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(243, 21);
            this.cb_status.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Sanction Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "SDC Number:";
            // 
            // txt_sdc
            // 
            this.txt_sdc.Location = new System.Drawing.Point(197, 188);
            this.txt_sdc.Name = "txt_sdc";
            this.txt_sdc.ReadOnly = true;
            this.txt_sdc.Size = new System.Drawing.Size(100, 20);
            this.txt_sdc.TabIndex = 90;
            this.txt_sdc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_sdc_MouseClick);
            // 
            // txt_aog
            // 
            this.txt_aog.Location = new System.Drawing.Point(525, 188);
            this.txt_aog.Name = "txt_aog";
            this.txt_aog.ReadOnly = true;
            this.txt_aog.Size = new System.Drawing.Size(100, 20);
            this.txt_aog.TabIndex = 92;
            this.txt_aog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_aog_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "AOG Reference:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Type of Hearing:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Discipline Authority:";
            // 
            // cb_hearing
            // 
            this.cb_hearing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_hearing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_hearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hearing.FormattingEnabled = true;
            this.cb_hearing.Location = new System.Drawing.Point(113, 93);
            this.cb_hearing.Name = "cb_hearing";
            this.cb_hearing.Size = new System.Drawing.Size(243, 21);
            this.cb_hearing.TabIndex = 95;
            // 
            // cb_authority
            // 
            this.cb_authority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_authority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_authority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_authority.FormattingEnabled = true;
            this.cb_authority.Location = new System.Drawing.Point(489, 93);
            this.cb_authority.Name = "cb_authority";
            this.cb_authority.Size = new System.Drawing.Size(243, 21);
            this.cb_authority.TabIndex = 96;
            // 
            // cb_authorityfrom
            // 
            this.cb_authorityfrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_authorityfrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_authorityfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_authorityfrom.FormattingEnabled = true;
            this.cb_authorityfrom.Location = new System.Drawing.Point(489, 123);
            this.cb_authorityfrom.Name = "cb_authorityfrom";
            this.cb_authorityfrom.Size = new System.Drawing.Size(243, 21);
            this.cb_authorityfrom.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = " Authority Location:";
            // 
            // rb_registered
            // 
            this.rb_registered.AutoSize = true;
            this.rb_registered.Location = new System.Drawing.Point(223, 12);
            this.rb_registered.Name = "rb_registered";
            this.rb_registered.Size = new System.Drawing.Size(145, 17);
            this.rb_registered.TabIndex = 99;
            this.rb_registered.TabStop = true;
            this.rb_registered.Text = "Registered Students Only";
            this.rb_registered.UseVisualStyleBackColor = true;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(374, 12);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(81, 17);
            this.rb_all.TabIndex = 100;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All Students";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // Criteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 353);
            this.Controls.Add(this.rb_all);
            this.Controls.Add(this.rb_registered);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_authorityfrom);
            this.Controls.Add(this.cb_authority);
            this.Controls.Add(this.cb_hearing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_aog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sdc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_keywords);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_badcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_hall);
            this.Controls.Add(this.cbres);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Criteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Criteria";
            this.Load += new System.EventHandler(this.Criteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_hall;
        private System.Windows.Forms.ComboBox cbres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_keywords;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_badcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_report;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_aog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sdc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_authority;
        private System.Windows.Forms.ComboBox cb_hearing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_authorityfrom;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_registered;
    }
}