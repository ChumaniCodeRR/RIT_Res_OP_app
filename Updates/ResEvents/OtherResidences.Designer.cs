namespace Res_System.Updates.ResEvents
{
    partial class OtherResidences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherResidences));
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.dgResidences = new System.Windows.Forms.DataGridView();
            this.cCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rESNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_res = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResidences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(398, 12);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(84, 23);
            this.btnUncheckAll.TabIndex = 86;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(308, 12);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(84, 23);
            this.btnCheckAll.TabIndex = 85;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // dgResidences
            // 
            this.dgResidences.AllowUserToAddRows = false;
            this.dgResidences.AllowUserToDeleteRows = false;
            this.dgResidences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResidences.AutoGenerateColumns = false;
            this.dgResidences.BackgroundColor = System.Drawing.Color.White;
            this.dgResidences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResidences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCheck,
            this.rESNAMEDataGridViewTextBoxColumn,
            this.cnRes});
            this.dgResidences.DataSource = this.bs_res;
            this.dgResidences.Location = new System.Drawing.Point(3, 41);
            this.dgResidences.MultiSelect = false;
            this.dgResidences.Name = "dgResidences";
            this.dgResidences.RowHeadersVisible = false;
            this.dgResidences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResidences.Size = new System.Drawing.Size(495, 306);
            this.dgResidences.TabIndex = 84;
            // 
            // cCheck
            // 
            this.cCheck.HeaderText = "";
            this.cCheck.Name = "cCheck";
            this.cCheck.Width = 30;
            // 
            // rESNAMEDataGridViewTextBoxColumn
            // 
            this.rESNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rESNAMEDataGridViewTextBoxColumn.DataPropertyName = "RESNAME";
            this.rESNAMEDataGridViewTextBoxColumn.HeaderText = "Residence";
            this.rESNAMEDataGridViewTextBoxColumn.Name = "rESNAMEDataGridViewTextBoxColumn";
            this.rESNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnRes
            // 
            this.cnRes.DataPropertyName = "RES";
            this.cnRes.HeaderText = "RES";
            this.cnRes.Name = "cnRes";
            this.cnRes.Visible = false;
            // 
            // bs_res
            // 
            this.bs_res.DataSource = typeof(NS_Catering.StrongTypesNS.ds_res_functionsDataSet.TT_RES_LISTDataTable);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(250, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerate.Location = new System.Drawing.Point(152, 357);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 23);
            this.btnGenerate.TabIndex = 87;
            this.btnGenerate.Text = "Proceed";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Please select Residence(s) below which you want to include";
            // 
            // OtherResidences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.dgResidences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtherResidences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Hall Residences ";
            this.Load += new System.EventHandler(this.OtherResidences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResidences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.DataGridView dgResidences;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource bs_res;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRes;
        private System.Windows.Forms.Label label1;
    }
}