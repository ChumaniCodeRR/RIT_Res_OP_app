﻿namespace Res_System
{
    partial class StudentLeadership
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
            this.txt_title = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvLeadership = new System.Windows.Forms.DataGridView();
            this.stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cell_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsibilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response_str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_rep = new System.Windows.Forms.DataGridView();
            this.code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portfolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YesNo2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_codes = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YesNo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_other = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFolio = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeadership)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlFolio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.SystemColors.Control;
            this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_title.Location = new System.Drawing.Point(12, 12);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(686, 13);
            this.txt_title.TabIndex = 1;
            this.txt_title.TabStop = false;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_title.TextChanged += new System.EventHandler(this.txt_title_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_print);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.dgvLeadership);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 202);
            this.panel3.TabIndex = 14;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(600, 173);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 20;
            this.btn_print.Text = "Print List";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(519, 173);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvLeadership
            // 
            this.dgvLeadership.AllowUserToAddRows = false;
            this.dgvLeadership.AllowUserToDeleteRows = false;
            this.dgvLeadership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeadership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuno,
            this.StuName,
            this.cn_email,
            this.cn_cell_phone,
            this.Type,
            this.Role,
            this.yr,
            this.Folio,
            this.Responsibilities,
            this.response_str});
            this.dgvLeadership.Location = new System.Drawing.Point(10, 25);
            this.dgvLeadership.MultiSelect = false;
            this.dgvLeadership.Name = "dgvLeadership";
            this.dgvLeadership.ReadOnly = true;
            this.dgvLeadership.RowHeadersVisible = false;
            this.dgvLeadership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeadership.Size = new System.Drawing.Size(665, 142);
            this.dgvLeadership.TabIndex = 18;
            this.dgvLeadership.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLeadership_DataBindingComplete);
            this.dgvLeadership.SelectionChanged += new System.EventHandler(this.dgvLeadership_SelectionChanged);
            // 
            // stuno
            // 
            this.stuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stuno.DataPropertyName = "stuno";
            this.stuno.HeaderText = "Stuno";
            this.stuno.Name = "stuno";
            this.stuno.ReadOnly = true;
            this.stuno.Width = 60;
            // 
            // StuName
            // 
            this.StuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StuName.DataPropertyName = "namestr";
            this.StuName.HeaderText = "Name";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            this.StuName.Width = 60;
            // 
            // cn_email
            // 
            this.cn_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_email.DataPropertyName = "email";
            this.cn_email.HeaderText = "Email";
            this.cn_email.Name = "cn_email";
            this.cn_email.ReadOnly = true;
            this.cn_email.Visible = false;
            // 
            // cn_cell_phone
            // 
            this.cn_cell_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_cell_phone.DataPropertyName = "cell_phone";
            this.cn_cell_phone.HeaderText = "Cell Number";
            this.cn_cell_phone.Name = "cn_cell_phone";
            this.cn_cell_phone.ReadOnly = true;
            this.cn_cell_phone.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Role.DataPropertyName = "type_descrip";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 54;
            // 
            // yr
            // 
            this.yr.DataPropertyName = "yr";
            this.yr.HeaderText = "yr";
            this.yr.Name = "yr";
            this.yr.ReadOnly = true;
            this.yr.Visible = false;
            // 
            // Folio
            // 
            this.Folio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Folio.DataPropertyName = "descrip";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 54;
            // 
            // Responsibilities
            // 
            this.Responsibilities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsibilities.DataPropertyName = "position";
            this.Responsibilities.HeaderText = "Responsibilities";
            this.Responsibilities.Name = "Responsibilities";
            this.Responsibilities.ReadOnly = true;
            // 
            // response_str
            // 
            this.response_str.DataPropertyName = "response_str";
            this.response_str.HeaderText = "response_str";
            this.response_str.Name = "response_str";
            this.response_str.ReadOnly = true;
            this.response_str.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select a name above to edit their details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Student Leadership List:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dg_rep);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dg_codes);
            this.panel1.Controls.Add(this.pnlFolio);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cb_position);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_student);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 352);
            this.panel1.TabIndex = 15;
            // 
            // dg_rep
            // 
            this.dg_rep.AllowUserToAddRows = false;
            this.dg_rep.AllowUserToDeleteRows = false;
            this.dg_rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code2,
            this.Portfolio,
            this.YesNo2});
            this.dg_rep.Location = new System.Drawing.Point(357, 81);
            this.dg_rep.MultiSelect = false;
            this.dg_rep.Name = "dg_rep";
            this.dg_rep.RowHeadersVisible = false;
            this.dg_rep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rep.Size = new System.Drawing.Size(318, 189);
            this.dg_rep.TabIndex = 22;
            // 
            // code2
            // 
            this.code2.DataPropertyName = "CODE";
            this.code2.HeaderText = "Code";
            this.code2.Name = "code2";
            this.code2.Visible = false;
            // 
            // Portfolio
            // 
            this.Portfolio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Portfolio.DataPropertyName = "DESCRIP";
            this.Portfolio.HeaderText = "Portfolio";
            this.Portfolio.Name = "Portfolio";
            // 
            // YesNo2
            // 
            this.YesNo2.DataPropertyName = "CHECKED";
            this.YesNo2.FillWeight = 50F;
            this.YesNo2.HeaderText = "Yes/No";
            this.YesNo2.Name = "YesNo2";
            this.YesNo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YesNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YesNo2.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(357, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 47);
            this.textBox1.TabIndex = 21;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Please tick below if this person is a res rep for any of the House-comm portfolio" +
    "s below ( Required for mailing lists, res access, etc ):";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(422, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add / Edit Students Details";
            // 
            // dg_codes
            // 
            this.dg_codes.AllowUserToAddRows = false;
            this.dg_codes.AllowUserToDeleteRows = false;
            this.dg_codes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_codes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Responsibility,
            this.YesNo});
            this.dg_codes.Location = new System.Drawing.Point(6, 81);
            this.dg_codes.MultiSelect = false;
            this.dg_codes.Name = "dg_codes";
            this.dg_codes.RowHeadersVisible = false;
            this.dg_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_codes.Size = new System.Drawing.Size(318, 189);
            this.dg_codes.TabIndex = 14;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "CODE";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = false;
            // 
            // Responsibility
            // 
            this.Responsibility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsibility.DataPropertyName = "DESCRIP";
            this.Responsibility.HeaderText = "Responsibility";
            this.Responsibility.Name = "Responsibility";
            // 
            // YesNo
            // 
            this.YesNo.DataPropertyName = "CHECKED";
            this.YesNo.FillWeight = 50F;
            this.YesNo.HeaderText = "Yes/No";
            this.YesNo.Name = "YesNo";
            this.YesNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YesNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YesNo.Width = 50;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(318, 47);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Please tick below if this person is responsible for one of the groups below ( Req" +
    "uired for mailing lists, res access, etc ):";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_position
            // 
            this.cb_position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_position.DisplayMember = "descrip";
            this.cb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Location = new System.Drawing.Point(436, 16);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(229, 21);
            this.cb_position.TabIndex = 4;
            this.cb_position.ValueMember = "code";
            this.cb_position.SelectedIndexChanged += new System.EventHandler(this.cb_position_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position:";
            // 
            // cb_student
            // 
            this.cb_student.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_student.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_student.DisplayMember = "namestr";
            this.cb_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(91, 16);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(229, 21);
            this.cb_student.TabIndex = 2;
            this.cb_student.ValueMember = "stuno";
            this.cb_student.SelectedIndexChanged += new System.EventHandler(this.cb_student_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Add/Save Person to Student Leadership List";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stuno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stuno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "namestr";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "type_descrip";
            this.dataGridViewTextBoxColumn4.HeaderText = "Role";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "yr";
            this.dataGridViewTextBoxColumn5.HeaderText = "yr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descrip";
            this.dataGridViewTextBoxColumn6.HeaderText = "Folio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Responsibilities";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "response_str";
            this.dataGridViewTextBoxColumn8.HeaderText = "response_str";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CODE";
            this.dataGridViewTextBoxColumn9.HeaderText = "Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DESCRIP";
            this.dataGridViewTextBoxColumn10.HeaderText = "Responsibility";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CODE";
            this.dataGridViewTextBoxColumn11.HeaderText = "Code";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DESCRIP";
            this.dataGridViewTextBoxColumn12.HeaderText = "Responsibility";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(41, 11);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(229, 20);
            this.txt_position.TabIndex = 12;
            /*this.txt_position.TextChanged += new System.EventHandler(this.txt_position_TextChanged);*/
            // 
            // txt_other
            // 
            this.txt_other.AutoSize = true;
            this.txt_other.Location = new System.Drawing.Point(3, 11);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(32, 13);
            this.txt_other.TabIndex = 5;
            this.txt_other.Text = "Folio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "A Maximum of 7 House Comm Members Allowed";
            // 
            // pnlFolio
            // 
            this.pnlFolio.Controls.Add(this.label3);
            this.pnlFolio.Controls.Add(this.txt_other);
            this.pnlFolio.Controls.Add(this.txt_position);
            this.pnlFolio.Location = new System.Drawing.Point(25, 305);
            this.pnlFolio.Name = "pnlFolio";
            this.pnlFolio.Size = new System.Drawing.Size(299, 45);
            this.pnlFolio.TabIndex = 13;
            this.pnlFolio.Visible = false;
            // 
            // StudentLeadership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentLeadership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Leadership";
            this.Load += new System.EventHandler(this.StudentLeadership_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeadership)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlFolio.ResumeLayout(false);
            this.pnlFolio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLeadership;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_codes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsibility;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YesNo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dg_rep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cell_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn yr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsibilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn response_str;
        private System.Windows.Forms.DataGridViewTextBoxColumn code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portfolio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YesNo2;
        private System.Windows.Forms.Panel pnlFolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_other;
        private System.Windows.Forms.TextBox txt_position;
    }
}