namespace Res_System
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.cb_building = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_roomno = new System.Windows.Forms.TextBox();
            this.tT_ROOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESDataSet = new NS_ResSystem.StrongTypesNS.DS_RESDataSet();
            this.cb_sections = new System.Windows.Forms.ComboBox();
            this.tT_SECTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESCODESDataSet = new NS_System.StrongTypesNS.DS_RESCODESDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bed_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_intercom = new System.Windows.Forms.TextBox();
            this.txt_room_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_buildings = new CustomDataGridView();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERCOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMSORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tT_ROOMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_SECTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESCODESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buildings)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_building
            // 
            this.cb_building.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_building.FormattingEnabled = true;
            this.cb_building.Location = new System.Drawing.Point(65, 32);
            this.cb_building.Name = "cb_building";
            this.cb_building.Size = new System.Drawing.Size(450, 21);
            this.cb_building.TabIndex = 5;
            this.cb_building.SelectedIndexChanged += new System.EventHandler(this.cb_building_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Building:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Existing Rooms:";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(110, 9);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(89, 13);
            this.lbl_res.TabIndex = 30;
            this.lbl_res.Text = "Residence Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Residence Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(367, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 153);
            this.textBox1.TabIndex = 35;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Room No:";
            // 
            // txt_roomno
            // 
            this.txt_roomno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tT_ROOMSBindingSource, "ROOM_NO", true));
            this.txt_roomno.Location = new System.Drawing.Point(77, 241);
            this.txt_roomno.Name = "txt_roomno";
            this.txt_roomno.ReadOnly = true;
            this.txt_roomno.Size = new System.Drawing.Size(40, 20);
            this.txt_roomno.TabIndex = 39;
            // 
            // tT_ROOMSBindingSource
            // 
            this.tT_ROOMSBindingSource.DataMember = "TT_ROOMS";
            this.tT_ROOMSBindingSource.DataSource = this.dS_RESDataSet;
            // 
            // dS_RESDataSet
            // 
            this.dS_RESDataSet.DataSetName = "DS_RESDataSet";
            this.dS_RESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_sections
            // 
            this.cb_sections.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tT_ROOMSBindingSource, "SECTION_CODE", true));
            this.cb_sections.DataSource = this.tT_SECTIONSBindingSource;
            this.cb_sections.DisplayMember = "DESCRIP";
            this.cb_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sections.FormattingEnabled = true;
            this.cb_sections.Location = new System.Drawing.Point(77, 268);
            this.cb_sections.Name = "cb_sections";
            this.cb_sections.Size = new System.Drawing.Size(297, 21);
            this.cb_sections.TabIndex = 2;
            this.cb_sections.ValueMember = "SECTION_CODE";
            // 
            // tT_SECTIONSBindingSource
            // 
            this.tT_SECTIONSBindingSource.DataMember = "TT_SECTIONS";
            this.tT_SECTIONSBindingSource.DataSource = this.dS_RESCODESDataSet;
            // 
            // dS_RESCODESDataSet
            // 
            this.dS_RESCODESDataSet.DataSetName = "DS_RESCODESDataSet";
            this.dS_RESCODESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Section:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Intercom No:";
            // 
            // txt_bed_no
            // 
            this.txt_bed_no.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tT_ROOMSBindingSource, "BEDS", true));
            this.txt_bed_no.Location = new System.Drawing.Point(476, 241);
            this.txt_bed_no.Name = "txt_bed_no";
            this.txt_bed_no.ReadOnly = true;
            this.txt_bed_no.Size = new System.Drawing.Size(43, 20);
            this.txt_bed_no.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "No of Beds:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(188, 295);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(159, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save Updated Room Details";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_intercom
            // 
            this.txt_intercom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tT_ROOMSBindingSource, "INTERCOM_NO", true));
            this.txt_intercom.Location = new System.Drawing.Point(476, 268);
            this.txt_intercom.Name = "txt_intercom";
            this.txt_intercom.Size = new System.Drawing.Size(43, 20);
            this.txt_intercom.TabIndex = 3;
            // 
            // txt_room_descrip
            // 
            this.txt_room_descrip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tT_ROOMSBindingSource, "DESCRIP", true));
            this.txt_room_descrip.Location = new System.Drawing.Point(223, 241);
            this.txt_room_descrip.Name = "txt_room_descrip";
            this.txt_room_descrip.ReadOnly = true;
            this.txt_room_descrip.Size = new System.Drawing.Size(178, 20);
            this.txt_room_descrip.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Room Description:";
            // 
            // dg_buildings
            // 
            this.dg_buildings.AllowUserToAddRows = false;
            this.dg_buildings.AllowUserToDeleteRows = false;
            this.dg_buildings.AutoGenerateColumns = false;
            this.dg_buildings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_buildings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_buildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_buildings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOOMNODataGridViewTextBoxColumn,
            this.sECTIONNAMEDataGridViewTextBoxColumn,
            this.sECTIONCODEDataGridViewTextBoxColumn,
            this.bEDSDataGridViewTextBoxColumn,
            this.iNTERCOMNODataGridViewTextBoxColumn,
            this.rOOMSORTDataGridViewTextBoxColumn,
            this.dBLDataGridViewTextBoxColumn});
            this.dg_buildings.DataSource = this.tT_ROOMSBindingSource;
            this.dg_buildings.Location = new System.Drawing.Point(15, 82);
            this.dg_buildings.MultiSelect = false;
            this.dg_buildings.Name = "dg_buildings";
            this.dg_buildings.ReadOnly = true;
            this.dg_buildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_buildings.Size = new System.Drawing.Size(343, 153);
            this.dg_buildings.TabIndex = 1;
            // 
            // rOOMNODataGridViewTextBoxColumn
            // 
            this.rOOMNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rOOMNODataGridViewTextBoxColumn.DataPropertyName = "ROOM_NO";
            this.rOOMNODataGridViewTextBoxColumn.HeaderText = "Room";
            this.rOOMNODataGridViewTextBoxColumn.Name = "rOOMNODataGridViewTextBoxColumn";
            this.rOOMNODataGridViewTextBoxColumn.ReadOnly = true;
            this.rOOMNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rOOMNODataGridViewTextBoxColumn.Width = 41;
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
            // sECTIONCODEDataGridViewTextBoxColumn
            // 
            this.sECTIONCODEDataGridViewTextBoxColumn.DataPropertyName = "SECTION_CODE";
            this.sECTIONCODEDataGridViewTextBoxColumn.HeaderText = "SECTION_CODE";
            this.sECTIONCODEDataGridViewTextBoxColumn.Name = "sECTIONCODEDataGridViewTextBoxColumn";
            this.sECTIONCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTIONCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bEDSDataGridViewTextBoxColumn
            // 
            this.bEDSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bEDSDataGridViewTextBoxColumn.DataPropertyName = "BEDS";
            this.bEDSDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bEDSDataGridViewTextBoxColumn.Name = "bEDSDataGridViewTextBoxColumn";
            this.bEDSDataGridViewTextBoxColumn.ReadOnly = true;
            this.bEDSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bEDSDataGridViewTextBoxColumn.Width = 37;
            // 
            // iNTERCOMNODataGridViewTextBoxColumn
            // 
            this.iNTERCOMNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iNTERCOMNODataGridViewTextBoxColumn.DataPropertyName = "INTERCOM_NO";
            this.iNTERCOMNODataGridViewTextBoxColumn.HeaderText = "Intercom";
            this.iNTERCOMNODataGridViewTextBoxColumn.Name = "iNTERCOMNODataGridViewTextBoxColumn";
            this.iNTERCOMNODataGridViewTextBoxColumn.ReadOnly = true;
            this.iNTERCOMNODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iNTERCOMNODataGridViewTextBoxColumn.Width = 54;
            // 
            // rOOMSORTDataGridViewTextBoxColumn
            // 
            this.rOOMSORTDataGridViewTextBoxColumn.DataPropertyName = "ROOM_SORT";
            this.rOOMSORTDataGridViewTextBoxColumn.HeaderText = "ROOM_SORT";
            this.rOOMSORTDataGridViewTextBoxColumn.Name = "rOOMSORTDataGridViewTextBoxColumn";
            this.rOOMSORTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOOMSORTDataGridViewTextBoxColumn.Visible = false;
            // 
            // dBLDataGridViewTextBoxColumn
            // 
            this.dBLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dBLDataGridViewTextBoxColumn.DataPropertyName = "DBL";
            this.dBLDataGridViewTextBoxColumn.HeaderText = "Double";
            this.dBLDataGridViewTextBoxColumn.Name = "dBLDataGridViewTextBoxColumn";
            this.dBLDataGridViewTextBoxColumn.ReadOnly = true;
            this.dBLDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dBLDataGridViewTextBoxColumn.Width = 47;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.txt_room_descrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_intercom);
            this.Controls.Add(this.dg_buildings);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txt_bed_no);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sections);
            this.Controls.Add(this.txt_roomno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_building);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Room Information";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tT_ROOMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tT_SECTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESCODESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buildings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_building;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_roomno;
        private System.Windows.Forms.ComboBox cb_sections;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bed_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private CustomDataGridView dg_buildings;
        private System.Windows.Forms.TextBox txt_intercom;
        private System.Windows.Forms.TextBox txt_room_descrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tT_ROOMSBindingSource;
        private NS_ResSystem.StrongTypesNS.DS_RESDataSet dS_RESDataSet;
        private System.Windows.Forms.BindingSource tT_SECTIONSBindingSource;
        private NS_System.StrongTypesNS.DS_RESCODESDataSet dS_RESCODESDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERCOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMSORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBLDataGridViewTextBoxColumn;
    }
}