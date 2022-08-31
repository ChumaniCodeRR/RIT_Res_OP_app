namespace Code_LookUp
{
    partial class Code_LookUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code_LookUp));
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_codes = new CustomDataGridView();
            this.tt_genbadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_STUBADDataSet = new NS_Discipline.StrongTypesNS.DS_STUBADDataSet();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt_genbadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_STUBADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(108, 7);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(121, 20);
            this.txtfilter.TabIndex = 0;
            this.txtfilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by Keyword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Double click on an item above to select it";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.typeDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descripDataGridViewTextBoxColumn,
            this.other});
            this.dg_codes.DataSource = this.tt_genbadBindingSource;
            this.dg_codes.Location = new System.Drawing.Point(12, 33);
            this.dg_codes.MultiSelect = false;
            this.dg_codes.Name = "dg_codes";
            this.dg_codes.ReadOnly = true;
            this.dg_codes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_codes.Size = new System.Drawing.Size(929, 487);
            this.dg_codes.TabIndex = 1;
            this.dg_codes.DoubleClick += new System.EventHandler(this.customDataGridView1_DoubleClick);
            // 
            // tt_genbadBindingSource
            // 
            this.tt_genbadBindingSource.DataMember = "tt_genbad";
            this.tt_genbadBindingSource.DataSource = this.dS_STUBADDataSet;
            // 
            // dS_STUBADDataSet
            // 
            this.dS_STUBADDataSet.DataSetName = "DS_STUBADDataSet";
            this.dS_STUBADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripDataGridViewTextBoxColumn
            // 
            this.descripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripDataGridViewTextBoxColumn.DataPropertyName = "descrip";
            this.descripDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descripDataGridViewTextBoxColumn.Name = "descripDataGridViewTextBoxColumn";
            this.descripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // other
            // 
            this.other.DataPropertyName = "other";
            this.other.HeaderText = "other";
            this.other.Name = "other";
            this.other.ReadOnly = true;
            this.other.Visible = false;
            // 
            // Code_LookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.dg_codes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Code_LookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code LookUp";
            this.Load += new System.EventHandler(this.Code_LookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_codes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt_genbadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_STUBADDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dg_codes;
        private System.Windows.Forms.BindingSource tt_genbadBindingSource;
        private NS_Discipline.StrongTypesNS.DS_STUBADDataSet dS_STUBADDataSet;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other;
    }
}