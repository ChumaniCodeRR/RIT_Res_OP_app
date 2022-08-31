﻿namespace Student_Medical
{
    partial class StudentMedicalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMedicalDetails));
            this.label54 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtmedplan = new System.Windows.Forms.TextBox();
            this.bsEmergency = new System.Windows.Forms.BindingSource(this.components);
            this.dsStudentInfo = new NS_ResSystem.StrongTypesNS.DS_STUINFODataSet();
            this.label50 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtmedrel = new System.Windows.Forms.TextBox();
            this.txtmedaid = new System.Windows.Forms.TextBox();
            this.txtmedaidno = new System.Windows.Forms.TextBox();
            this.txtmedempl = new System.Windows.Forms.TextBox();
            this.txtmedid = new System.Windows.Forms.TextBox();
            this.txtmedprinciple = new System.Windows.Forms.TextBox();
            this.txtemerothernotes = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtemermed = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtemerallerg = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtemerdoc = new System.Windows.Forms.TextBox();
            this.txtemermedalert = new System.Windows.Forms.TextBox();
            this.txtemerblood = new System.Windows.Forms.TextBox();
            this.txtemerother = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.pnlMedicalDetails = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentInfo)).BeginInit();
            this.pnlMedicalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(434, 145);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(50, 13);
            this.label54.TabIndex = 166;
            this.label54.Text = "Employer";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(28, 90);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(102, 13);
            this.label52.TabIndex = 165;
            this.label52.Text = "Medical Aid Number";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(456, 90);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(28, 13);
            this.label51.TabIndex = 164;
            this.label51.Text = "Plan";
            // 
            // txtmedplan
            // 
            this.txtmedplan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medical_aid_plan", true));
            this.txtmedplan.Location = new System.Drawing.Point(490, 87);
            this.txtmedplan.Name = "txtmedplan";
            this.txtmedplan.ReadOnly = true;
            this.txtmedplan.Size = new System.Drawing.Size(227, 20);
            this.txtmedplan.TabIndex = 143;
            // 
            // bsEmergency
            // 
            this.bsEmergency.DataMember = "tt_emergency";
            this.bsEmergency.DataSource = this.dsStudentInfo;
            // 
            // dsStudentInfo
            // 
            this.dsStudentInfo.DataSetName = "DS_STUINFODataSet";
            this.dsStudentInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(26, 64);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(104, 13);
            this.label50.TabIndex = 163;
            this.label50.Text = "Medical Aid Scheme";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(419, 119);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(65, 13);
            this.label47.TabIndex = 162;
            this.label47.Text = "Relationship";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(35, 142);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(95, 26);
            this.label46.TabIndex = 161;
            this.label46.Text = "Medical Principles \r\nID Number";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(7, 119);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(123, 13);
            this.label45.TabIndex = 160;
            this.label45.Text = "Medical Principles Name";
            // 
            // txtmedrel
            // 
            this.txtmedrel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "med_aid_relation", true));
            this.txtmedrel.Location = new System.Drawing.Point(490, 116);
            this.txtmedrel.Name = "txtmedrel";
            this.txtmedrel.ReadOnly = true;
            this.txtmedrel.Size = new System.Drawing.Size(227, 20);
            this.txtmedrel.TabIndex = 145;
            // 
            // txtmedaid
            // 
            this.txtmedaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medical_aid", true));
            this.txtmedaid.Location = new System.Drawing.Point(136, 61);
            this.txtmedaid.Name = "txtmedaid";
            this.txtmedaid.ReadOnly = true;
            this.txtmedaid.Size = new System.Drawing.Size(277, 20);
            this.txtmedaid.TabIndex = 141;
            // 
            // txtmedaidno
            // 
            this.txtmedaidno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medical_aid_no", true));
            this.txtmedaidno.Location = new System.Drawing.Point(136, 87);
            this.txtmedaidno.Name = "txtmedaidno";
            this.txtmedaidno.ReadOnly = true;
            this.txtmedaidno.Size = new System.Drawing.Size(277, 20);
            this.txtmedaidno.TabIndex = 142;
            // 
            // txtmedempl
            // 
            this.txtmedempl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medical_aid_employer", true));
            this.txtmedempl.Location = new System.Drawing.Point(490, 142);
            this.txtmedempl.Name = "txtmedempl";
            this.txtmedempl.ReadOnly = true;
            this.txtmedempl.Size = new System.Drawing.Size(227, 20);
            this.txtmedempl.TabIndex = 147;
            // 
            // txtmedid
            // 
            this.txtmedid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "med_aid_id", true));
            this.txtmedid.Location = new System.Drawing.Point(136, 142);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.ReadOnly = true;
            this.txtmedid.Size = new System.Drawing.Size(176, 20);
            this.txtmedid.TabIndex = 146;
            // 
            // txtmedprinciple
            // 
            this.txtmedprinciple.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "med_aid_principle", true));
            this.txtmedprinciple.Location = new System.Drawing.Point(136, 116);
            this.txtmedprinciple.Name = "txtmedprinciple";
            this.txtmedprinciple.ReadOnly = true;
            this.txtmedprinciple.Size = new System.Drawing.Size(277, 20);
            this.txtmedprinciple.TabIndex = 144;
            // 
            // txtemerothernotes
            // 
            this.txtemerothernotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "other_info", true));
            this.txtemerothernotes.Location = new System.Drawing.Point(136, 349);
            this.txtemerothernotes.Multiline = true;
            this.txtemerothernotes.Name = "txtemerothernotes";
            this.txtemerothernotes.ReadOnly = true;
            this.txtemerothernotes.Size = new System.Drawing.Size(581, 45);
            this.txtemerothernotes.TabIndex = 151;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(42, 352);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(88, 13);
            this.label44.TabIndex = 158;
            this.label44.Text = "Other Information";
            // 
            // txtemermed
            // 
            this.txtemermed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medications", true));
            this.txtemermed.Location = new System.Drawing.Point(136, 196);
            this.txtemermed.Multiline = true;
            this.txtemermed.Name = "txtemermed";
            this.txtemermed.ReadOnly = true;
            this.txtemermed.Size = new System.Drawing.Size(581, 45);
            this.txtemermed.TabIndex = 148;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(36, 196);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(94, 13);
            this.label43.TabIndex = 157;
            this.label43.Text = "Medication Details";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(84, 250);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(46, 13);
            this.label42.TabIndex = 156;
            this.label42.Text = "Allergies";
            // 
            // txtemerallerg
            // 
            this.txtemerallerg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "allergies_info", true));
            this.txtemerallerg.Location = new System.Drawing.Point(136, 247);
            this.txtemerallerg.Multiline = true;
            this.txtemerallerg.Name = "txtemerallerg";
            this.txtemerallerg.ReadOnly = true;
            this.txtemerallerg.Size = new System.Drawing.Size(581, 45);
            this.txtemerallerg.TabIndex = 149;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(43, 301);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 26);
            this.label41.TabIndex = 155;
            this.label41.Text = "Illness/\r\nMajor Operations";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(580, 23);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 13);
            this.label40.TabIndex = 154;
            this.label40.Text = "Blood Group:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(368, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 13);
            this.label39.TabIndex = 153;
            this.label39.Text = "Medic Alert Number";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(55, 23);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(75, 13);
            this.label38.TabIndex = 152;
            this.label38.Text = "Doctors Name";
            // 
            // txtemerdoc
            // 
            this.txtemerdoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "doctor", true));
            this.txtemerdoc.Location = new System.Drawing.Point(136, 20);
            this.txtemerdoc.Name = "txtemerdoc";
            this.txtemerdoc.ReadOnly = true;
            this.txtemerdoc.Size = new System.Drawing.Size(226, 20);
            this.txtemerdoc.TabIndex = 138;
            // 
            // txtemermedalert
            // 
            this.txtemermedalert.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "medic_alert", true));
            this.txtemermedalert.Location = new System.Drawing.Point(474, 20);
            this.txtemermedalert.Name = "txtemermedalert";
            this.txtemermedalert.ReadOnly = true;
            this.txtemermedalert.Size = new System.Drawing.Size(100, 20);
            this.txtemermedalert.TabIndex = 139;
            // 
            // txtemerblood
            // 
            this.txtemerblood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "blood_group", true));
            this.txtemerblood.Location = new System.Drawing.Point(655, 20);
            this.txtemerblood.Name = "txtemerblood";
            this.txtemerblood.ReadOnly = true;
            this.txtemerblood.Size = new System.Drawing.Size(62, 20);
            this.txtemerblood.TabIndex = 140;
            // 
            // txtemerother
            // 
            this.txtemerother.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmergency, "other", true));
            this.txtemerother.Location = new System.Drawing.Point(136, 298);
            this.txtemerother.Multiline = true;
            this.txtemerother.Name = "txtemerother";
            this.txtemerother.ReadOnly = true;
            this.txtemerother.Size = new System.Drawing.Size(581, 45);
            this.txtemerother.TabIndex = 150;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(401, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 167;
            this.button3.Text = "  Print Medical Details";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(203, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 23);
            this.btnSave.TabIndex = 159;
            this.btnSave.Text = "Save Changes to Medical Details";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(722, 1);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(22, 23);
            this.Btn_Close.TabIndex = 169;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // textBox22
            // 
            this.textBox22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox22.BackColor = System.Drawing.SystemColors.Window;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.Purple;
            this.textBox22.Location = new System.Drawing.Point(299, 3);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(125, 19);
            this.textBox22.TabIndex = 168;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "Medical Details";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlMedicalDetails
            // 
            this.pnlMedicalDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMedicalDetails.Controls.Add(this.label38);
            this.pnlMedicalDetails.Controls.Add(this.txtemerother);
            this.pnlMedicalDetails.Controls.Add(this.txtemerblood);
            this.pnlMedicalDetails.Controls.Add(this.label54);
            this.pnlMedicalDetails.Controls.Add(this.txtemermedalert);
            this.pnlMedicalDetails.Controls.Add(this.label52);
            this.pnlMedicalDetails.Controls.Add(this.txtemerdoc);
            this.pnlMedicalDetails.Controls.Add(this.label51);
            this.pnlMedicalDetails.Controls.Add(this.label39);
            this.pnlMedicalDetails.Controls.Add(this.txtmedplan);
            this.pnlMedicalDetails.Controls.Add(this.label40);
            this.pnlMedicalDetails.Controls.Add(this.label50);
            this.pnlMedicalDetails.Controls.Add(this.label41);
            this.pnlMedicalDetails.Controls.Add(this.label47);
            this.pnlMedicalDetails.Controls.Add(this.txtemerallerg);
            this.pnlMedicalDetails.Controls.Add(this.label46);
            this.pnlMedicalDetails.Controls.Add(this.label42);
            this.pnlMedicalDetails.Controls.Add(this.label45);
            this.pnlMedicalDetails.Controls.Add(this.label43);
            this.pnlMedicalDetails.Controls.Add(this.txtmedrel);
            this.pnlMedicalDetails.Controls.Add(this.txtemermed);
            this.pnlMedicalDetails.Controls.Add(this.txtmedaid);
            this.pnlMedicalDetails.Controls.Add(this.label44);
            this.pnlMedicalDetails.Controls.Add(this.txtmedaidno);
            this.pnlMedicalDetails.Controls.Add(this.txtemerothernotes);
            this.pnlMedicalDetails.Controls.Add(this.txtmedempl);
            this.pnlMedicalDetails.Controls.Add(this.txtmedprinciple);
            this.pnlMedicalDetails.Controls.Add(this.txtmedid);
            this.pnlMedicalDetails.Location = new System.Drawing.Point(7, 48);
            this.pnlMedicalDetails.Name = "pnlMedicalDetails";
            this.pnlMedicalDetails.Size = new System.Drawing.Size(731, 408);
            this.pnlMedicalDetails.TabIndex = 170;
            // 
            // StudentMedicalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(745, 579);
            this.Controls.Add(this.pnlMedicalDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMedicalDetails";
            this.Text = "StudentMedicalDetails";
            ((System.ComponentModel.ISupportInitialize)(this.bsEmergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentInfo)).EndInit();
            this.pnlMedicalDetails.ResumeLayout(false);
            this.pnlMedicalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtmedplan;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtmedrel;
        private System.Windows.Forms.TextBox txtmedaid;
        private System.Windows.Forms.TextBox txtmedaidno;
        private System.Windows.Forms.TextBox txtmedempl;
        private System.Windows.Forms.TextBox txtmedid;
        private System.Windows.Forms.TextBox txtmedprinciple;
        private System.Windows.Forms.TextBox txtemerothernotes;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtemermed;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtemerallerg;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtemerdoc;
        private System.Windows.Forms.TextBox txtemermedalert;
        private System.Windows.Forms.TextBox txtemerblood;
        private System.Windows.Forms.TextBox txtemerother;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.BindingSource bsEmergency;
        private NS_ResSystem.StrongTypesNS.DS_STUINFODataSet dsStudentInfo;
        private System.Windows.Forms.Panel pnlMedicalDetails;
    }
}