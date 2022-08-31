namespace Search_Grid_Students
{
    partial class Search_Grid_Students
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
            this.txt_stuno = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prefer_name = new System.Windows.Forms.TextBox();
            this.tT_STUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_stuDataSet = new NS_System.StrongTypesNS.ds_stuDataSet();
            this.dg_codes = new CustomDataGridView();
            this.sTUNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAME1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tT_STUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stuno
            // 
            this.txt_stuno.Location = new System.Drawing.Point(161, 6);
            this.txt_stuno.Name = "txt_stuno";
            this.txt_stuno.Size = new System.Drawing.Size(84, 20);
            this.txt_stuno.TabIndex = 5;
            this.txt_stuno.TextChanged += new System.EventHandler(this.txt_stuno_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(858, 524);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Double click on an item above to select it";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Surname:";
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(309, 6);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(116, 20);
            this.txt_surn.TabIndex = 11;
            this.txt_surn.TextChanged += new System.EventHandler(this.txt_surn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(475, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(116, 20);
            this.txt_name.TabIndex = 13;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preferred Name:";
            // 
            // txt_prefer_name
            // 
            this.txt_prefer_name.Location = new System.Drawing.Point(687, 6);
            this.txt_prefer_name.Name = "txt_prefer_name";
            this.txt_prefer_name.Size = new System.Drawing.Size(116, 20);
            this.txt_prefer_name.TabIndex = 15;
            this.txt_prefer_name.TextChanged += new System.EventHandler(this.txt_prefer_name_TextChanged);
            // 
            // tT_STUBindingSource
            // 
            this.tT_STUBindingSource.DataMember = "TT_STU";
            this.tT_STUBindingSource.DataSource = this.ds_stuDataSet;
            // 
            // ds_stuDataSet
            // 
            this.ds_stuDataSet.DataSetName = "ds_stuDataSet";
            this.ds_stuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg_codes
            // 
            this.dg_codes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_codes.AllowUserToAddRows = false;
            this.dg_codes.AllowUserToDeleteRows = false;
            this.dg_codes.AutoGenerateColumns = false;
            this.dg_codes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_codes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_codes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUNODataGridViewTextBoxColumn,
            this.surnDataGridViewTextBoxColumn,
            this.nAME1DataGridViewTextBoxColumn,
            this.prefernameDataGridViewTextBoxColumn,
            this.resname});
            this.dg_codes.DataSource = this.tT_STUBindingSource;
            this.dg_codes.Location = new System.Drawing.Point(12, 31);
            this.dg_codes.MultiSelect = false;
            this.dg_codes.Name = "dg_codes";
            this.dg_codes.ReadOnly = true;
            this.dg_codes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_codes.Size = new System.Drawing.Size(929, 487);
            this.dg_codes.TabIndex = 6;
            this.dg_codes.DoubleClick += new System.EventHandler(this.dg_codes_DoubleClick);
            // 
            // sTUNODataGridViewTextBoxColumn
            // 
            this.sTUNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sTUNODataGridViewTextBoxColumn.DataPropertyName = "STUNO";
            this.sTUNODataGridViewTextBoxColumn.HeaderText = "Student Number";
            this.sTUNODataGridViewTextBoxColumn.Name = "sTUNODataGridViewTextBoxColumn";
            this.sTUNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnDataGridViewTextBoxColumn
            // 
            this.surnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.surnDataGridViewTextBoxColumn.DataPropertyName = "surn";
            this.surnDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnDataGridViewTextBoxColumn.Name = "surnDataGridViewTextBoxColumn";
            this.surnDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnDataGridViewTextBoxColumn.Width = 74;
            // 
            // nAME1DataGridViewTextBoxColumn
            // 
            this.nAME1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nAME1DataGridViewTextBoxColumn.DataPropertyName = "NAME1";
            this.nAME1DataGridViewTextBoxColumn.HeaderText = "First Name";
            this.nAME1DataGridViewTextBoxColumn.Name = "nAME1DataGridViewTextBoxColumn";
            this.nAME1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nAME1DataGridViewTextBoxColumn.Width = 76;
            // 
            // prefernameDataGridViewTextBoxColumn
            // 
            this.prefernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.prefernameDataGridViewTextBoxColumn.DataPropertyName = "prefer_name";
            this.prefernameDataGridViewTextBoxColumn.HeaderText = "Preferred Name";
            this.prefernameDataGridViewTextBoxColumn.Name = "prefernameDataGridViewTextBoxColumn";
            this.prefernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefernameDataGridViewTextBoxColumn.Width = 97;
            // 
            // resname
            // 
            this.resname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resname.DataPropertyName = "resname";
            this.resname.HeaderText = "Current Residence";
            this.resname.Name = "resname";
            this.resname.ReadOnly = true;
            // 
            // Search_Grid_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_prefer_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_surn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stuno);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_codes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Search_Grid_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Search";
            this.Load += new System.EventHandler(this.Search_Grid_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tT_STUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stuno;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dg_codes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_surn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prefer_name;
        private System.Windows.Forms.BindingSource tT_STUBindingSource;
        private NS_System.StrongTypesNS.ds_stuDataSet ds_stuDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAME1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resname;
    }
}