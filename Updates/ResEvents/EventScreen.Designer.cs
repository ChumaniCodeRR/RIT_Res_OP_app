﻿namespace Res_System.Updates.ResEvents
{
    partial class EventScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventScreen));
            this.pnl_event = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_update_details = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bs_function = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbRes = new System.Windows.Forms.ComboBox();
            this.bs_res = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESCODESDataSet = new NS_System.StrongTypesNS.DS_RESCODESDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.grp_initial = new System.Windows.Forms.GroupBox();
            this.chk_returners = new System.Windows.Forms.CheckBox();
            this.chk_first = new System.Windows.Forms.CheckBox();
            this.chk_house = new System.Windows.Forms.CheckBox();
            this.chk_hall = new System.Windows.Forms.CheckBox();
            this.chk_other_res = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_meal_cnt = new System.Windows.Forms.ComboBox();
            this.chk_everyone = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chk_mcnt_change = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_compulsory = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dte_reply_dte = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_ward_attend = new System.Windows.Forms.CheckBox();
            this.chk_dependant_attend = new System.Windows.Forms.CheckBox();
            this.dte_fn_dte = new System.Windows.Forms.DateTimePicker();
            this.cb_fn_time = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_refno = new System.Windows.Forms.TextBox();
            this.dg_students = new CustomDataGridView();
            this.cn_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mealcnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_diet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs_diets = new System.Windows.Forms.BindingSource(this.components);
            this.cn_attending = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_trs_ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_trs_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_trs_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_students = new System.Windows.Forms.BindingSource(this.components);
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_decision = new System.Windows.Forms.ComboBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.grp_status = new System.Windows.Forms.GroupBox();
            this.lbl_other_events = new System.Windows.Forms.Label();
            this.txt_otherevents = new System.Windows.Forms.TextBox();
            this.pnl_event.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_function)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESCODESDataSet)).BeginInit();
            this.grp_initial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_students)).BeginInit();
            this.grp_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_event
            // 
            this.pnl_event.Controls.Add(this.pnl_buttons);
            this.pnl_event.Controls.Add(this.pnl_details);
            this.pnl_event.Controls.Add(this.dg_students);
            this.pnl_event.Location = new System.Drawing.Point(1, 2);
            this.pnl_event.Name = "pnl_event";
            this.pnl_event.Size = new System.Drawing.Size(703, 486);
            this.pnl_event.TabIndex = 0;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_update_details);
            this.pnl_buttons.Controls.Add(this.btn_cancel);
            this.pnl_buttons.Controls.Add(this.btn_save);
            this.pnl_buttons.Location = new System.Drawing.Point(3, 283);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(694, 23);
            this.pnl_buttons.TabIndex = 112;
            // 
            // btn_update_details
            // 
            this.btn_update_details.Location = new System.Drawing.Point(251, 0);
            this.btn_update_details.Name = "btn_update_details";
            this.btn_update_details.Size = new System.Drawing.Size(186, 23);
            this.btn_update_details.TabIndex = 0;
            this.btn_update_details.Text = "Update Function Details";
            this.btn_update_details.UseVisualStyleBackColor = true;
            this.btn_update_details.Click += new System.EventHandler(this.btn_update_details_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(350, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 23);
            this.btn_cancel.TabIndex = 85;
            this.btn_cancel.Text = "Cancel Changes";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(218, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 23);
            this.btn_save.TabIndex = 80;
            this.btn_save.Text = "Save Function Details";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_details
            // 
            this.pnl_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_details.Controls.Add(this.textBox4);
            this.pnl_details.Controls.Add(this.label16);
            this.pnl_details.Controls.Add(this.textBox3);
            this.pnl_details.Controls.Add(this.label15);
            this.pnl_details.Controls.Add(this.textBox2);
            this.pnl_details.Controls.Add(this.label13);
            this.pnl_details.Controls.Add(this.textBox1);
            this.pnl_details.Controls.Add(this.label12);
            this.pnl_details.Controls.Add(this.cbRes);
            this.pnl_details.Controls.Add(this.label11);
            this.pnl_details.Controls.Add(this.grp_initial);
            this.pnl_details.Controls.Add(this.dte_reply_dte);
            this.pnl_details.Controls.Add(this.label10);
            this.pnl_details.Controls.Add(this.label7);
            this.pnl_details.Controls.Add(this.label6);
            this.pnl_details.Controls.Add(this.chk_ward_attend);
            this.pnl_details.Controls.Add(this.chk_dependant_attend);
            this.pnl_details.Controls.Add(this.dte_fn_dte);
            this.pnl_details.Controls.Add(this.cb_fn_time);
            this.pnl_details.Controls.Add(this.label9);
            this.pnl_details.Controls.Add(this.label2);
            this.pnl_details.Controls.Add(this.txt_description);
            this.pnl_details.Controls.Add(this.label1);
            this.pnl_details.Controls.Add(this.txt_refno);
            this.pnl_details.Location = new System.Drawing.Point(3, 3);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(700, 274);
            this.pnl_details.TabIndex = 111;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "additional", true));
            this.textBox4.Location = new System.Drawing.Point(354, 121);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 44);
            this.textBox4.TabIndex = 50;
            // 
            // bs_function
            // 
            this.bs_function.DataSource = typeof(NS_Catering.StrongTypesNS.ds_res_functionsDataSet.tt_res_eventsDataTable);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(353, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 13);
            this.label16.TabIndex = 244;
            this.label16.Text = "Special Requests / Additonal Information";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "menu", true));
            this.textBox3.Location = new System.Drawing.Point(5, 121);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 44);
            this.textBox3.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 242;
            this.label15.Text = "Food Requested (Menu)";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "start_time", true));
            this.textBox2.Location = new System.Drawing.Point(545, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 239;
            this.label13.Text = "Start Time:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "venue", true));
            this.textBox1.Location = new System.Drawing.Point(110, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 237;
            this.label12.Text = "Function Venue:";
            // 
            // cbRes
            // 
            this.cbRes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_function, "res", true));
            this.cbRes.DataSource = this.bs_res;
            this.cbRes.DisplayMember = "RESNAME";
            this.cbRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRes.FormattingEnabled = true;
            this.cbRes.Location = new System.Drawing.Point(110, 5);
            this.cbRes.Name = "cbRes";
            this.cbRes.Size = new System.Drawing.Size(331, 21);
            this.cbRes.TabIndex = 236;
            this.cbRes.TabStop = false;
            this.cbRes.ValueMember = "RES";
            // 
            // bs_res
            // 
            this.bs_res.DataMember = "TT_RES";
            this.bs_res.DataSource = this.dS_RESCODESDataSet;
            // 
            // dS_RESCODESDataSet
            // 
            this.dS_RESCODESDataSet.DataSetName = "DS_RESCODESDataSet";
            this.dS_RESCODESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 235;
            this.label11.Text = "Residence:";
            // 
            // grp_initial
            // 
            this.grp_initial.Controls.Add(this.chk_returners);
            this.grp_initial.Controls.Add(this.chk_first);
            this.grp_initial.Controls.Add(this.chk_house);
            this.grp_initial.Controls.Add(this.chk_hall);
            this.grp_initial.Controls.Add(this.chk_other_res);
            this.grp_initial.Controls.Add(this.label14);
            this.grp_initial.Controls.Add(this.cb_meal_cnt);
            this.grp_initial.Controls.Add(this.chk_everyone);
            this.grp_initial.Controls.Add(this.label8);
            this.grp_initial.Controls.Add(this.chk_mcnt_change);
            this.grp_initial.Controls.Add(this.label5);
            this.grp_initial.Controls.Add(this.label4);
            this.grp_initial.Controls.Add(this.chk_compulsory);
            this.grp_initial.Controls.Add(this.label3);
            this.grp_initial.Location = new System.Drawing.Point(5, 171);
            this.grp_initial.Name = "grp_initial";
            this.grp_initial.Size = new System.Drawing.Size(687, 96);
            this.grp_initial.TabIndex = 234;
            this.grp_initial.TabStop = false;
            this.grp_initial.Text = "Initial Setup, these cannot be changed later";
            // 
            // chk_returners
            // 
            this.chk_returners.AutoSize = true;
            this.chk_returners.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "returners", true));
            this.chk_returners.Location = new System.Drawing.Point(435, 70);
            this.chk_returners.Name = "chk_returners";
            this.chk_returners.Size = new System.Drawing.Size(72, 17);
            this.chk_returners.TabIndex = 228;
            this.chk_returners.Text = "Returners";
            this.chk_returners.UseVisualStyleBackColor = true;
            // 
            // chk_first
            // 
            this.chk_first.AutoSize = true;
            this.chk_first.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "firstyr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_first.Location = new System.Drawing.Point(357, 70);
            this.chk_first.Name = "chk_first";
            this.chk_first.Size = new System.Drawing.Size(75, 17);
            this.chk_first.TabIndex = 227;
            this.chk_first.Text = "First Years";
            this.chk_first.UseVisualStyleBackColor = true;
            // 
            // chk_house
            // 
            this.chk_house.AutoSize = true;
            this.chk_house.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "housecomm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_house.Location = new System.Drawing.Point(269, 70);
            this.chk_house.Name = "chk_house";
            this.chk_house.Size = new System.Drawing.Size(89, 17);
            this.chk_house.TabIndex = 226;
            this.chk_house.Text = "House Comm";
            this.chk_house.UseVisualStyleBackColor = true;
            // 
            // chk_hall
            // 
            this.chk_hall.AutoSize = true;
            this.chk_hall.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "hallcomm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_hall.Location = new System.Drawing.Point(187, 70);
            this.chk_hall.Name = "chk_hall";
            this.chk_hall.Size = new System.Drawing.Size(76, 17);
            this.chk_hall.TabIndex = 225;
            this.chk_hall.Text = "Hall Comm";
            this.chk_hall.UseVisualStyleBackColor = true;
            // 
            // chk_other_res
            // 
            this.chk_other_res.AutoSize = true;
            this.chk_other_res.Location = new System.Drawing.Point(269, 48);
            this.chk_other_res.Name = "chk_other_res";
            this.chk_other_res.Size = new System.Drawing.Size(15, 14);
            this.chk_other_res.TabIndex = 224;
            this.chk_other_res.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 13);
            this.label14.TabIndex = 223;
            this.label14.Text = "Book Same Event For Other Residences In The Hall:";
            // 
            // cb_meal_cnt
            // 
            this.cb_meal_cnt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "meal_cnt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_meal_cnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_meal_cnt.FormattingEnabled = true;
            this.cb_meal_cnt.Location = new System.Drawing.Point(137, 18);
            this.cb_meal_cnt.Name = "cb_meal_cnt";
            this.cb_meal_cnt.Size = new System.Drawing.Size(59, 21);
            this.cb_meal_cnt.TabIndex = 55;
            // 
            // chk_everyone
            // 
            this.chk_everyone.AutoSize = true;
            this.chk_everyone.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "default_attend", true));
            this.chk_everyone.Location = new System.Drawing.Point(110, 71);
            this.chk_everyone.Name = "chk_everyone";
            this.chk_everyone.Size = new System.Drawing.Size(71, 17);
            this.chk_everyone.TabIndex = 70;
            this.chk_everyone.Text = "Everyone";
            this.chk_everyone.UseVisualStyleBackColor = true;
            this.chk_everyone.CheckedChanged += new System.EventHandler(this.chk_everyone_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 222;
            this.label8.Text = "Default Attendance :";
            // 
            // chk_mcnt_change
            // 
            this.chk_mcnt_change.AutoSize = true;
            this.chk_mcnt_change.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "meal_change", true));
            this.chk_mcnt_change.Location = new System.Drawing.Point(357, 21);
            this.chk_mcnt_change.Name = "chk_mcnt_change";
            this.chk_mcnt_change.Size = new System.Drawing.Size(15, 14);
            this.chk_mcnt_change.TabIndex = 60;
            this.chk_mcnt_change.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 221;
            this.label5.Text = "Allow Change Meal Numbers:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 220;
            this.label4.Text = "No Of Meals Per Student:";
            // 
            // chk_compulsory
            // 
            this.chk_compulsory.AutoSize = true;
            this.chk_compulsory.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "comp", true));
            this.chk_compulsory.Location = new System.Drawing.Point(492, 21);
            this.chk_compulsory.Name = "chk_compulsory";
            this.chk_compulsory.Size = new System.Drawing.Size(15, 14);
            this.chk_compulsory.TabIndex = 65;
            this.chk_compulsory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 219;
            this.label3.Text = "Function Compulsory:";
            // 
            // dte_reply_dte
            // 
            this.dte_reply_dte.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_function, "reply_by", true));
            this.dte_reply_dte.Location = new System.Drawing.Point(545, 54);
            this.dte_reply_dte.Name = "dte_reply_dte";
            this.dte_reply_dte.Size = new System.Drawing.Size(147, 20);
            this.dte_reply_dte.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 233;
            this.label10.Text = "Reply By:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 232;
            this.label7.Text = "Warden Attending:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 231;
            this.label6.Text = "Warden\'s Dependants Attending:";
            // 
            // chk_ward_attend
            // 
            this.chk_ward_attend.AutoSize = true;
            this.chk_ward_attend.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "warden", true));
            this.chk_ward_attend.Location = new System.Drawing.Point(110, 81);
            this.chk_ward_attend.Name = "chk_ward_attend";
            this.chk_ward_attend.Size = new System.Drawing.Size(15, 14);
            this.chk_ward_attend.TabIndex = 30;
            this.chk_ward_attend.UseVisualStyleBackColor = true;
            // 
            // chk_dependant_attend
            // 
            this.chk_dependant_attend.AutoSize = true;
            this.chk_dependant_attend.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_function, "dependants", true));
            this.chk_dependant_attend.Location = new System.Drawing.Point(301, 82);
            this.chk_dependant_attend.Name = "chk_dependant_attend";
            this.chk_dependant_attend.Size = new System.Drawing.Size(15, 14);
            this.chk_dependant_attend.TabIndex = 35;
            this.chk_dependant_attend.UseVisualStyleBackColor = true;
            // 
            // dte_fn_dte
            // 
            this.dte_fn_dte.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_function, "fn_dte", true));
            this.dte_fn_dte.Location = new System.Drawing.Point(545, 5);
            this.dte_fn_dte.Name = "dte_fn_dte";
            this.dte_fn_dte.Size = new System.Drawing.Size(147, 20);
            this.dte_fn_dte.TabIndex = 5;
            // 
            // cb_fn_time
            // 
            this.cb_fn_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_fn_time.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_function, "fn_time", true));
            this.cb_fn_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fn_time.FormattingEnabled = true;
            this.cb_fn_time.Location = new System.Drawing.Point(545, 80);
            this.cb_fn_time.Name = "cb_fn_time";
            this.cb_fn_time.Size = new System.Drawing.Size(147, 21);
            this.cb_fn_time.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 230;
            this.label9.Text = "Meal in Lieu of:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 229;
            this.label2.Text = "Function Date:";
            // 
            // txt_description
            // 
            this.txt_description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "descrip", true));
            this.txt_description.Location = new System.Drawing.Point(110, 29);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(331, 20);
            this.txt_description.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 228;
            this.label1.Text = "Description:";
            // 
            // txt_refno
            // 
            this.txt_refno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_refno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "folio", true));
            this.txt_refno.Location = new System.Drawing.Point(3, 1);
            this.txt_refno.Name = "txt_refno";
            this.txt_refno.ReadOnly = true;
            this.txt_refno.Size = new System.Drawing.Size(20, 20);
            this.txt_refno.TabIndex = 227;
            this.txt_refno.Visible = false;
            // 
            // dg_students
            // 
            this.dg_students.AllowUserToAddRows = false;
            this.dg_students.AllowUserToDeleteRows = false;
            this.dg_students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_students.AutoGenerateColumns = false;
            this.dg_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_stuno,
            this.namestringDataGridViewTextBoxColumn,
            this.cn_mealcnt,
            this.cn_diet,
            this.cn_attending,
            this.cn_trs_ref,
            this.cn_trs_link,
            this.cn_trs_no,
            this.folioDataGridViewTextBoxColumn});
            this.dg_students.DataSource = this.bs_students;
            this.dg_students.Location = new System.Drawing.Point(3, 312);
            this.dg_students.MultiSelect = false;
            this.dg_students.Name = "dg_students";
            this.dg_students.Size = new System.Drawing.Size(694, 171);
            this.dg_students.TabIndex = 110;
            this.dg_students.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_students_CellValueChanged);
            this.dg_students.CurrentCellDirtyStateChanged += new System.EventHandler(this.dg_students_CurrentCellDirtyStateChanged);
            // 
            // cn_stuno
            // 
            this.cn_stuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_stuno.DataPropertyName = "stuno";
            this.cn_stuno.HeaderText = "Stuno";
            this.cn_stuno.Name = "cn_stuno";
            this.cn_stuno.ReadOnly = true;
            this.cn_stuno.Width = 60;
            // 
            // namestringDataGridViewTextBoxColumn
            // 
            this.namestringDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namestringDataGridViewTextBoxColumn.DataPropertyName = "namestring";
            this.namestringDataGridViewTextBoxColumn.HeaderText = "Name";
            this.namestringDataGridViewTextBoxColumn.Name = "namestringDataGridViewTextBoxColumn";
            this.namestringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cn_mealcnt
            // 
            this.cn_mealcnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_mealcnt.DataPropertyName = "meal_cnt";
            this.cn_mealcnt.HeaderText = "Meal Count";
            this.cn_mealcnt.Name = "cn_mealcnt";
            this.cn_mealcnt.Width = 86;
            // 
            // cn_diet
            // 
            this.cn_diet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_diet.DataPropertyName = "diet";
            this.cn_diet.DataSource = this.bs_diets;
            this.cn_diet.DisplayMember = "diet_detail";
            this.cn_diet.HeaderText = "Diet";
            this.cn_diet.Name = "cn_diet";
            this.cn_diet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_diet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cn_diet.ValueMember = "diet";
            this.cn_diet.Width = 51;
            // 
            // bs_diets
            // 
            this.bs_diets.DataSource = typeof(NS_Conference.StrongTypesNS.ds_conference_lookupDataSet.tt_dietsDataTable);
            // 
            // cn_attending
            // 
            this.cn_attending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_attending.DataPropertyName = "attending";
            this.cn_attending.HeaderText = "Attending";
            this.cn_attending.Name = "cn_attending";
            this.cn_attending.Width = 58;
            // 
            // cn_trs_ref
            // 
            this.cn_trs_ref.DataPropertyName = "TRS_REF";
            this.cn_trs_ref.HeaderText = "TRS_REF";
            this.cn_trs_ref.Name = "cn_trs_ref";
            this.cn_trs_ref.Visible = false;
            // 
            // cn_trs_link
            // 
            this.cn_trs_link.DataPropertyName = "trs_link";
            this.cn_trs_link.HeaderText = "trs_link";
            this.cn_trs_link.Name = "cn_trs_link";
            this.cn_trs_link.Visible = false;
            // 
            // cn_trs_no
            // 
            this.cn_trs_no.DataPropertyName = "trs_no";
            this.cn_trs_no.HeaderText = "trs_no";
            this.cn_trs_no.Name = "cn_trs_no";
            this.cn_trs_no.Visible = false;
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.Visible = false;
            // 
            // bs_students
            // 
            this.bs_students.DataSource = typeof(NS_Catering.StrongTypesNS.ds_res_functionsDataSet.tt_event_stuDataTable);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(267, 631);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(173, 23);
            this.btn_submit.TabIndex = 95;
            this.btn_submit.Text = "Submit Function";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(88, 631);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(173, 23);
            this.btn_register.TabIndex = 90;
            this.btn_register.Text = "Print Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(446, 631);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(173, 23);
            this.btn_exit.TabIndex = 100;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_decision
            // 
            this.cb_decision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_function, "caterers_decision", true));
            this.cb_decision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_decision.FormattingEnabled = true;
            this.cb_decision.Location = new System.Drawing.Point(6, 20);
            this.cb_decision.Name = "cb_decision";
            this.cb_decision.Size = new System.Drawing.Size(126, 21);
            this.cb_decision.TabIndex = 105;
            this.cb_decision.SelectedIndexChanged += new System.EventHandler(this.cb_decision_SelectedIndexChanged);
            // 
            // txt_reason
            // 
            this.txt_reason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "reason", true));
            this.txt_reason.Location = new System.Drawing.Point(8, 47);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(266, 78);
            this.txt_reason.TabIndex = 110;
            // 
            // lbl_reason
            // 
            this.lbl_reason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.Location = new System.Drawing.Point(138, 23);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(47, 13);
            this.lbl_reason.TabIndex = 239;
            this.lbl_reason.Text = "Reason:";
            // 
            // grp_status
            // 
            this.grp_status.Controls.Add(this.lbl_other_events);
            this.grp_status.Controls.Add(this.txt_otherevents);
            this.grp_status.Controls.Add(this.txt_reason);
            this.grp_status.Controls.Add(this.cb_decision);
            this.grp_status.Controls.Add(this.lbl_reason);
            this.grp_status.Location = new System.Drawing.Point(1, 494);
            this.grp_status.Name = "grp_status";
            this.grp_status.Size = new System.Drawing.Size(700, 131);
            this.grp_status.TabIndex = 241;
            this.grp_status.TabStop = false;
            this.grp_status.Text = "Function Status";
            // 
            // lbl_other_events
            // 
            this.lbl_other_events.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_other_events.AutoSize = true;
            this.lbl_other_events.Location = new System.Drawing.Point(277, 16);
            this.lbl_other_events.Name = "lbl_other_events";
            this.lbl_other_events.Size = new System.Drawing.Size(412, 13);
            this.lbl_other_events.TabIndex = 242;
            this.lbl_other_events.Text = "Other approved functions already happening on the same day for the same dining ha" +
    "ll:";
            // 
            // txt_otherevents
            // 
            this.txt_otherevents.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_function, "otherevents", true));
            this.txt_otherevents.Location = new System.Drawing.Point(280, 32);
            this.txt_otherevents.Multiline = true;
            this.txt_otherevents.Name = "txt_otherevents";
            this.txt_otherevents.Size = new System.Drawing.Size(414, 93);
            this.txt_otherevents.TabIndex = 115;
            // 
            // EventScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(706, 666);
            this.Controls.Add(this.grp_status);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pnl_event);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Details";
            this.Load += new System.EventHandler(this.EventScreen_Load);
            this.pnl_event.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_function)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESCODESDataSet)).EndInit();
            this.grp_initial.ResumeLayout(false);
            this.grp_initial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_students)).EndInit();
            this.grp_status.ResumeLayout(false);
            this.grp_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_event;
        private CustomDataGridView dg_students;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.BindingSource bs_function;
        private System.Windows.Forms.BindingSource bs_students;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mealcnt;
        private System.Windows.Forms.DataGridViewComboBoxColumn cn_diet;
        private System.Windows.Forms.BindingSource bs_diets;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_attending;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_trs_ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_trs_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_trs_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grp_initial;
        private System.Windows.Forms.ComboBox cb_meal_cnt;
        private System.Windows.Forms.CheckBox chk_everyone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk_mcnt_change;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_compulsory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dte_reply_dte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_ward_attend;
        private System.Windows.Forms.CheckBox chk_dependant_attend;
        private System.Windows.Forms.DateTimePicker dte_fn_dte;
        private System.Windows.Forms.ComboBox cb_fn_time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_refno;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_update_details;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbRes;
        private System.Windows.Forms.BindingSource bs_res;
        private NS_System.StrongTypesNS.DS_RESCODESDataSet dS_RESCODESDataSet;
        private System.Windows.Forms.ComboBox cb_decision;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.GroupBox grp_status;
        private System.Windows.Forms.Label lbl_other_events;
        private System.Windows.Forms.TextBox txt_otherevents;
        private System.Windows.Forms.CheckBox chk_other_res;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_returners;
        private System.Windows.Forms.CheckBox chk_first;
        private System.Windows.Forms.CheckBox chk_house;
        private System.Windows.Forms.CheckBox chk_hall;

    }
}