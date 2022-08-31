namespace StringBox
{
    partial class StringBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringBox));
            this.txt_string = new System.Windows.Forms.TextBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_string
            // 
            this.txt_string.BackColor = System.Drawing.SystemColors.Control;
            this.txt_string.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_string.Location = new System.Drawing.Point(12, 24);
            this.txt_string.Multiline = true;
            this.txt_string.Name = "txt_string";
            this.txt_string.ReadOnly = true;
            this.txt_string.Size = new System.Drawing.Size(205, 29);
            this.txt_string.TabIndex = 0;
            this.txt_string.TabStop = false;
            this.txt_string.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(223, 21);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 20);
            this.txt_value.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StringBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 84);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.txt_string);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StringBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String";
            this.Load += new System.EventHandler(this.String_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_string;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Button button1;
    }
}