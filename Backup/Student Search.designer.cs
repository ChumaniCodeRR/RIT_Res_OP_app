namespace Res_System
{
    partial class Student_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Search));
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtstuno = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtsurn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_faculty = new System.Windows.Forms.ComboBox();
            this.cb_subj = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_hall = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_degree = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_acad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_race = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_veh_reg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stuno";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(266, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "STUDENT SEARCH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 49);
            this.panel1.TabIndex = 26;
            // 
            // txtstuno
            // 
            this.txtstuno.Location = new System.Drawing.Point(50, 85);
            this.txtstuno.Name = "txtstuno";
            this.txtstuno.Size = new System.Drawing.Size(72, 20);
            this.txtstuno.TabIndex = 27;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(302, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(229, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Currently Registered Students && Admissions";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtsurn
            // 
            this.txtsurn.Location = new System.Drawing.Point(183, 85);
            this.txtsurn.Name = "txtsurn";
            this.txtsurn.Size = new System.Drawing.Size(100, 20);
            this.txtsurn.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Surname";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(330, 85);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name";
            // 
            // cbres
            // 
            this.cbres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbres.Enabled = false;
            this.cbres.FormattingEnabled = true;
            this.cbres.Location = new System.Drawing.Point(417, 3);
            this.cbres.Name = "cbres";
            this.cbres.Size = new System.Drawing.Size(243, 21);
            this.cbres.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Current Residence";
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(215, 53);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(81, 17);
            this.rb_all.TabIndex = 36;
            this.rb_all.Text = "All Students";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Current Faculty";
            // 
            // cb_faculty
            // 
            this.cb_faculty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_faculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_faculty.FormattingEnabled = true;
            this.cb_faculty.Location = new System.Drawing.Point(89, 37);
            this.cb_faculty.Name = "cb_faculty";
            this.cb_faculty.Size = new System.Drawing.Size(220, 21);
            this.cb_faculty.TabIndex = 37;
            this.cb_faculty.SelectedIndexChanged += new System.EventHandler(this.cb_faculty_SelectedIndexChanged);
            // 
            // cb_subj
            // 
            this.cb_subj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_subj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_subj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subj.Enabled = false;
            this.cb_subj.FormattingEnabled = true;
            this.cb_subj.Location = new System.Drawing.Point(89, 118);
            this.cb_subj.Name = "cb_subj";
            this.cb_subj.Size = new System.Drawing.Size(570, 21);
            this.cb_subj.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(460, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sleeping Hall";
            // 
            // cb_hall
            // 
            this.cb_hall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_hall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hall.FormattingEnabled = true;
            this.cb_hall.Location = new System.Drawing.Point(90, 3);
            this.cb_hall.Name = "cb_hall";
            this.cb_hall.Size = new System.Drawing.Size(220, 21);
            this.cb_hall.TabIndex = 48;
            this.cb_hall.SelectedIndexChanged += new System.EventHandler(this.cb_hall_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Degree";
            // 
            // cb_degree
            // 
            this.cb_degree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_degree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_degree.Enabled = false;
            this.cb_degree.FormattingEnabled = true;
            this.cb_degree.Location = new System.Drawing.Point(89, 64);
            this.cb_degree.Name = "cb_degree";
            this.cb_degree.Size = new System.Drawing.Size(570, 21);
            this.cb_degree.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Department";
            // 
            // cb_dept
            // 
            this.cb_dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(89, 91);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(570, 21);
            this.cb_dept.TabIndex = 39;
            this.cb_dept.SelectedIndexChanged += new System.EventHandler(this.cb_dept_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Academic Level";
            // 
            // cb_acad
            // 
            this.cb_acad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_acad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_acad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acad.FormattingEnabled = true;
            this.cb_acad.Location = new System.Drawing.Point(416, 37);
            this.cb_acad.Name = "cb_acad";
            this.cb_acad.Size = new System.Drawing.Size(243, 21);
            this.cb_acad.TabIndex = 53;
            this.cb_acad.SelectedIndexChanged += new System.EventHandler(this.cb_acad_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Gender";
            // 
            // cb_gender
            // 
            this.cb_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(130, 119);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(220, 21);
            this.cb_gender.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Race";
            // 
            // cb_race
            // 
            this.cb_race.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_race.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_race.FormattingEnabled = true;
            this.cb_race.Location = new System.Drawing.Point(457, 119);
            this.cb_race.Name = "cb_race";
            this.cb_race.Size = new System.Drawing.Size(243, 21);
            this.cb_race.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Clear Search Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_veh_reg
            // 
            this.txt_veh_reg.Location = new System.Drawing.Point(637, 85);
            this.txt_veh_reg.Name = "txt_veh_reg";
            this.txt_veh_reg.Size = new System.Drawing.Size(100, 20);
            this.txt_veh_reg.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(566, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Vehicle Reg";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_faculty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_dept);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cb_subj);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cb_degree);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cb_acad);
            this.panel2.Controls.Add(this.cb_hall);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbres);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(41, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 141);
            this.panel2.TabIndex = 61;
            // 
            // Student_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_veh_reg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_race);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_all);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtstuno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rhodes University Student Search";
            this.Load += new System.EventHandler(this.Student_Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtstuno;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtsurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_faculty;
        private System.Windows.Forms.ComboBox cb_subj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_hall;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_degree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_acad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_race;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_veh_reg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
    }
}