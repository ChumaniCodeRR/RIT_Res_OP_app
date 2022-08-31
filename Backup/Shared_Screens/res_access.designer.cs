namespace Res_Access
{
    partial class res_access
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(res_access));
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_delete = new System.Windows.Forms.DateTimePicker();
            this.btn_Save_res_access = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(170, 111);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(138, 20);
            this.dt_start.TabIndex = 2;
            this.dt_start.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(566, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Res Access Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Res Access End Date:";
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(462, 111);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(138, 20);
            this.dt_end.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delete this rule on:";
            // 
            // dt_delete
            // 
            this.dt_delete.Location = new System.Drawing.Point(288, 68);
            this.dt_delete.Name = "dt_delete";
            this.dt_delete.Size = new System.Drawing.Size(138, 20);
            this.dt_delete.TabIndex = 1;
            // 
            // btn_Save_res_access
            // 
            this.btn_Save_res_access.Location = new System.Drawing.Point(204, 178);
            this.btn_Save_res_access.Name = "btn_Save_res_access";
            this.btn_Save_res_access.Size = new System.Drawing.Size(205, 23);
            this.btn_Save_res_access.TabIndex = 4;
            this.btn_Save_res_access.Text = "Save changes and apply new dates";
            this.btn_Save_res_access.UseVisualStyleBackColor = true;
            this.btn_Save_res_access.Click += new System.EventHandler(this.btn_Save_res_access_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reason for date changes:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(169, 141);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(431, 20);
            this.txt_reason.TabIndex = 9;
            this.txt_reason.Visible = false;
            // 
            // res_access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 213);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Save_res_access);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dt_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "res_access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Students Res Access Dates";
            this.Load += new System.EventHandler(this.res_access_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_delete;
        private System.Windows.Forms.Button btn_Save_res_access;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_reason;
    }
}