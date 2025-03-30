namespace Lab2.Ex2
{
    partial class Employee_details
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEName = new System.Windows.Forms.Label();
            this.lblEAddress = new System.Windows.Forms.Label();
            this.lblDoJ = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.rtxtEAddress = new System.Windows.Forms.RichTextBox();
            this.dtpDoJ = new System.Windows.Forms.DateTimePicker();
            this.lstEducation = new System.Windows.Forms.ListBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(273, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Details";
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEName.Location = new System.Drawing.Point(105, 134);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(193, 29);
            this.lblEName.TabIndex = 1;
            this.lblEName.Text = "Employee Name";
            // 
            // lblEAddress
            // 
            this.lblEAddress.AutoSize = true;
            this.lblEAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEAddress.Location = new System.Drawing.Point(105, 211);
            this.lblEAddress.Name = "lblEAddress";
            this.lblEAddress.Size = new System.Drawing.Size(217, 29);
            this.lblEAddress.TabIndex = 2;
            this.lblEAddress.Text = "Employee Address";
            // 
            // lblDoJ
            // 
            this.lblDoJ.AutoSize = true;
            this.lblDoJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoJ.Location = new System.Drawing.Point(105, 343);
            this.lblDoJ.Name = "lblDoJ";
            this.lblDoJ.Size = new System.Drawing.Size(140, 29);
            this.lblDoJ.TabIndex = 3;
            this.lblDoJ.Text = "Date of Join";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.Location = new System.Drawing.Point(105, 425);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(120, 29);
            this.lblEducation.TabIndex = 4;
            this.lblEducation.Text = "Education";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(105, 496);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(156, 39);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // txtEName
            // 
            this.txtEName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEName.Location = new System.Drawing.Point(342, 134);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(288, 34);
            this.txtEName.TabIndex = 5;
            // 
            // rtxtEAddress
            // 
            this.rtxtEAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtEAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEAddress.Location = new System.Drawing.Point(342, 211);
            this.rtxtEAddress.Name = "rtxtEAddress";
            this.rtxtEAddress.Size = new System.Drawing.Size(288, 96);
            this.rtxtEAddress.TabIndex = 6;
            this.rtxtEAddress.Text = "";
            // 
            // dtpDoJ
            // 
            this.dtpDoJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoJ.Location = new System.Drawing.Point(339, 343);
            this.dtpDoJ.Name = "dtpDoJ";
            this.dtpDoJ.Size = new System.Drawing.Size(211, 34);
            this.dtpDoJ.TabIndex = 7;
            // 
            // lstEducation
            // 
            this.lstEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEducation.FormattingEnabled = true;
            this.lstEducation.ItemHeight = 29;
            this.lstEducation.Items.AddRange(new object[] {
            "UnderGraduate",
            "PostGraduate"});
            this.lstEducation.Location = new System.Drawing.Point(343, 425);
            this.lstEducation.Name = "lstEducation";
            this.lstEducation.Size = new System.Drawing.Size(207, 33);
            this.lstEducation.TabIndex = 8;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Human Resource",
            "Marketing",
            "R&D"});
            this.cboDepartment.Location = new System.Drawing.Point(343, 498);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(207, 37);
            this.cboDepartment.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(110, 618);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 65);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(290, 618);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 65);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(469, 618);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 65);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Employee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 762);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.lstEducation);
            this.Controls.Add(this.dtpDoJ);
            this.Controls.Add(this.rtxtEAddress);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblDoJ);
            this.Controls.Add(this.lblEAddress);
            this.Controls.Add(this.lblEName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Employee_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblEAddress;
        private System.Windows.Forms.Label lblDoJ;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.RichTextBox rtxtEAddress;
        private System.Windows.Forms.DateTimePicker dtpDoJ;
        private System.Windows.Forms.ListBox lstEducation;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}