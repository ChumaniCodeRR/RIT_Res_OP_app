namespace Res_System
{
    partial class Assign_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Rooms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_building = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.lbl_stu_to_be_assigned = new System.Windows.Forms.Label();
            this.lbl_students_assigned = new System.Windows.Forms.Label();
            this.tT_TAKENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESDataSet = new NS_ResSystem.StrongTypesNS.DS_RESDataSet();
            this.tT_STUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tT_ROOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_assigned_students = new CustomDataGridView();
            this.dg_avail_students = new CustomDataGridView();
            this.STUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMESTRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YRS_IN_RES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_rooms = new CustomDataGridView();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMESTRDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM_SORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tT_TAKENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_STUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_ROOMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_assigned_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avail_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_res);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_building);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 72);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(376, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(546, 53);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Building:";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(80, 13);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(89, 13);
            this.lbl_res.TabIndex = 7;
            this.lbl_res.Text = "Residence Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Residence:";
            // 
            // cb_building
            // 
            this.cb_building.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_building.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_building.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_building.FormattingEnabled = true;
            this.cb_building.Location = new System.Drawing.Point(83, 32);
            this.cb_building.Name = "cb_building";
            this.cb_building.Size = new System.Drawing.Size(262, 21);
            this.cb_building.TabIndex = 5;
            this.cb_building.SelectedIndexChanged += new System.EventHandler(this.cb_building_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Available rooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Students to be assigned to a room";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(655, 168);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(61, 119);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Allocate a student to an available room";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(655, 309);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(61, 119);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "Remove a student from a room";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Students assigned to a room";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(115, 87);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(15, 13);
            this.lbl_room_no.TabIndex = 14;
            this.lbl_room_no.Text = "#";
            // 
            // lbl_stu_to_be_assigned
            // 
            this.lbl_stu_to_be_assigned.AutoSize = true;
            this.lbl_stu_to_be_assigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stu_to_be_assigned.Location = new System.Drawing.Point(520, 87);
            this.lbl_stu_to_be_assigned.Name = "lbl_stu_to_be_assigned";
            this.lbl_stu_to_be_assigned.Size = new System.Drawing.Size(15, 13);
            this.lbl_stu_to_be_assigned.TabIndex = 15;
            this.lbl_stu_to_be_assigned.Text = "#";
            // 
            // lbl_students_assigned
            // 
            this.lbl_students_assigned.AutoSize = true;
            this.lbl_students_assigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_students_assigned.Location = new System.Drawing.Point(893, 87);
            this.lbl_students_assigned.Name = "lbl_students_assigned";
            this.lbl_students_assigned.Size = new System.Drawing.Size(15, 13);
            this.lbl_students_assigned.TabIndex = 16;
            this.lbl_students_assigned.Text = "#";
            // 
            // tT_TAKENBindingSource
            // 
            this.tT_TAKENBindingSource.DataMember = "TT_TAKEN";
            this.tT_TAKENBindingSource.DataSource = this.dS_RESDataSet;
            // 
            // dS_RESDataSet
            // 
            this.dS_RESDataSet.DataSetName = "DS_RESDataSet";
            this.dS_RESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tT_STUBindingSource
            // 
            this.tT_STUBindingSource.DataMember = "TT_STU";
            this.tT_STUBindingSource.DataSource = this.dS_RESDataSet;
            // 
            // tT_ROOMSBindingSource
            // 
            this.tT_ROOMSBindingSource.DataMember = "TT_ROOMS";
            this.tT_ROOMSBindingSource.DataSource = this.dS_RESDataSet;
            // 
            // dg_assigned_students
            // 
            this.dg_assigned_students.AllowUserToAddRows = false;
            this.dg_assigned_students.AllowUserToDeleteRows = false;
            this.dg_assigned_students.AutoGenerateColumns = false;
            this.dg_assigned_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_assigned_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nAMESTRDataGridViewTextBoxColumn1,
            this.rOOMNODataGridViewTextBoxColumn1,
            this.ROOM_SORT});
            this.dg_assigned_students.DataSource = this.tT_TAKENBindingSource;
            this.dg_assigned_students.Location = new System.Drawing.Point(722, 103);
            this.dg_assigned_students.Name = "dg_assigned_students";
            this.dg_assigned_students.ReadOnly = true;
            this.dg_assigned_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_assigned_students.Size = new System.Drawing.Size(228, 409);
            this.dg_assigned_students.TabIndex = 8;
            // 
            // dg_avail_students
            // 
            this.dg_avail_students.AllowUserToAddRows = false;
            this.dg_avail_students.AllowUserToDeleteRows = false;
            this.dg_avail_students.AutoGenerateColumns = false;
            this.dg_avail_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_avail_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STUNO,
            this.nAMESTRDataGridViewTextBoxColumn,
            this.dBLDataGridViewTextBoxColumn,
            this.YRS_IN_RES,
            this.ACYR});
            this.dg_avail_students.DataSource = this.tT_STUBindingSource;
            this.dg_avail_students.Location = new System.Drawing.Point(316, 103);
            this.dg_avail_students.Name = "dg_avail_students";
            this.dg_avail_students.ReadOnly = true;
            this.dg_avail_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_avail_students.Size = new System.Drawing.Size(333, 409);
            this.dg_avail_students.TabIndex = 7;
            // 
            // STUNO
            // 
            this.STUNO.DataPropertyName = "STUNO";
            this.STUNO.HeaderText = "STUNO";
            this.STUNO.Name = "STUNO";
            this.STUNO.ReadOnly = true;
            this.STUNO.Visible = false;
            // 
            // nAMESTRDataGridViewTextBoxColumn
            // 
            this.nAMESTRDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMESTRDataGridViewTextBoxColumn.DataPropertyName = "NAMESTR";
            this.nAMESTRDataGridViewTextBoxColumn.FillWeight = 43.47826F;
            this.nAMESTRDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMESTRDataGridViewTextBoxColumn.Name = "nAMESTRDataGridViewTextBoxColumn";
            this.nAMESTRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dBLDataGridViewTextBoxColumn
            // 
            this.dBLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dBLDataGridViewTextBoxColumn.DataPropertyName = "DBL";
            this.dBLDataGridViewTextBoxColumn.FillWeight = 40F;
            this.dBLDataGridViewTextBoxColumn.HeaderText = "Dbl Room";
            this.dBLDataGridViewTextBoxColumn.Name = "dBLDataGridViewTextBoxColumn";
            this.dBLDataGridViewTextBoxColumn.ReadOnly = true;
            this.dBLDataGridViewTextBoxColumn.Width = 40;
            // 
            // YRS_IN_RES
            // 
            this.YRS_IN_RES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.YRS_IN_RES.DataPropertyName = "YRS_IN_RES";
            this.YRS_IN_RES.FillWeight = 50F;
            this.YRS_IN_RES.HeaderText = "Years in Res";
            this.YRS_IN_RES.Name = "YRS_IN_RES";
            this.YRS_IN_RES.ReadOnly = true;
            this.YRS_IN_RES.Width = 50;
            // 
            // ACYR
            // 
            this.ACYR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ACYR.DataPropertyName = "ACYR";
            this.ACYR.FillWeight = 50F;
            this.ACYR.HeaderText = "Acad Year";
            this.ACYR.Name = "ACYR";
            this.ACYR.ReadOnly = true;
            this.ACYR.Width = 50;
            // 
            // dg_rooms
            // 
            this.dg_rooms.AllowUserToAddRows = false;
            this.dg_rooms.AllowUserToDeleteRows = false;
            this.dg_rooms.AutoGenerateColumns = false;
            this.dg_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOOMNODataGridViewTextBoxColumn,
            this.sECTIONNAMEDataGridViewTextBoxColumn,
            this.bEDSDataGridViewTextBoxColumn,
            this.DBL});
            this.dg_rooms.DataSource = this.tT_ROOMSBindingSource;
            this.dg_rooms.Location = new System.Drawing.Point(12, 103);
            this.dg_rooms.Name = "dg_rooms";
            this.dg_rooms.ReadOnly = true;
            this.dg_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rooms.Size = new System.Drawing.Size(288, 409);
            this.dg_rooms.TabIndex = 6;
            // 
            // rOOMNODataGridViewTextBoxColumn
            // 
            this.rOOMNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rOOMNODataGridViewTextBoxColumn.DataPropertyName = "ROOM_NO";
            this.rOOMNODataGridViewTextBoxColumn.FillWeight = 50F;
            this.rOOMNODataGridViewTextBoxColumn.HeaderText = "Room";
            this.rOOMNODataGridViewTextBoxColumn.Name = "rOOMNODataGridViewTextBoxColumn";
            this.rOOMNODataGridViewTextBoxColumn.ReadOnly = true;
            this.rOOMNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rOOMNODataGridViewTextBoxColumn.Width = 50;
            // 
            // sECTIONNAMEDataGridViewTextBoxColumn
            // 
            this.sECTIONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sECTIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "SECTION_NAME";
            this.sECTIONNAMEDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sECTIONNAMEDataGridViewTextBoxColumn.Name = "sECTIONNAMEDataGridViewTextBoxColumn";
            this.sECTIONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTIONNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bEDSDataGridViewTextBoxColumn
            // 
            this.bEDSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bEDSDataGridViewTextBoxColumn.DataPropertyName = "BEDS";
            this.bEDSDataGridViewTextBoxColumn.FillWeight = 40F;
            this.bEDSDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bEDSDataGridViewTextBoxColumn.Name = "bEDSDataGridViewTextBoxColumn";
            this.bEDSDataGridViewTextBoxColumn.ReadOnly = true;
            this.bEDSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bEDSDataGridViewTextBoxColumn.Width = 40;
            // 
            // DBL
            // 
            this.DBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DBL.DataPropertyName = "DBL";
            this.DBL.FillWeight = 40F;
            this.DBL.HeaderText = "Dbl Room";
            this.DBL.Name = "DBL";
            this.DBL.ReadOnly = true;
            this.DBL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DBL.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STUNO";
            this.dataGridViewTextBoxColumn1.HeaderText = "STUNO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // nAMESTRDataGridViewTextBoxColumn1
            // 
            this.nAMESTRDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMESTRDataGridViewTextBoxColumn1.DataPropertyName = "NAMESTR";
            this.nAMESTRDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nAMESTRDataGridViewTextBoxColumn1.Name = "nAMESTRDataGridViewTextBoxColumn1";
            this.nAMESTRDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nAMESTRDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rOOMNODataGridViewTextBoxColumn1
            // 
            this.rOOMNODataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rOOMNODataGridViewTextBoxColumn1.DataPropertyName = "ROOM_NO";
            this.rOOMNODataGridViewTextBoxColumn1.FillWeight = 50F;
            this.rOOMNODataGridViewTextBoxColumn1.HeaderText = "Room";
            this.rOOMNODataGridViewTextBoxColumn1.Name = "rOOMNODataGridViewTextBoxColumn1";
            this.rOOMNODataGridViewTextBoxColumn1.ReadOnly = true;
            this.rOOMNODataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rOOMNODataGridViewTextBoxColumn1.Width = 50;
            // 
            // ROOM_SORT
            // 
            this.ROOM_SORT.DataPropertyName = "ROOM_SORT";
            this.ROOM_SORT.HeaderText = "ROOM_SORT";
            this.ROOM_SORT.Name = "ROOM_SORT";
            this.ROOM_SORT.ReadOnly = true;
            this.ROOM_SORT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ROOM_SORT.Visible = false;
            // 
            // Assign_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 524);
            this.Controls.Add(this.lbl_students_assigned);
            this.Controls.Add(this.lbl_stu_to_be_assigned);
            this.Controls.Add(this.lbl_room_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_assigned_students);
            this.Controls.Add(this.dg_avail_students);
            this.Controls.Add(this.dg_rooms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Assign_Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Students To Rooms";
            this.Load += new System.EventHandler(this.Assign_Rooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tT_TAKENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_STUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_ROOMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_assigned_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avail_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_building;
        private CustomDataGridView dg_rooms;
        private CustomDataGridView dg_avail_students;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Label lbl_stu_to_be_assigned;
        private System.Windows.Forms.Label lbl_students_assigned;
        private System.Windows.Forms.BindingSource tT_ROOMSBindingSource;
        private NS_ResSystem.StrongTypesNS.DS_RESDataSet dS_RESDataSet;
        private CustomDataGridView dg_assigned_students;
        private System.Windows.Forms.BindingSource tT_TAKENBindingSource;
        private System.Windows.Forms.BindingSource tT_STUBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMESTRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YRS_IN_RES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMESTRDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOM_SORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBL;

    }
}