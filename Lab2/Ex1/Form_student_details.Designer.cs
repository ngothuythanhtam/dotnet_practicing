namespace Lab2
{
    partial class Form_student_details
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblYoB = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstHob = new System.Windows.Forms.CheckedListBox();
            this.cboDiv = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student\'s Class Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(63, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblYoB
            // 
            this.lblYoB.AutoSize = true;
            this.lblYoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYoB.Location = new System.Drawing.Point(63, 222);
            this.lblYoB.Name = "lblYoB";
            this.lblYoB.Size = new System.Drawing.Size(145, 29);
            this.lblYoB.TabIndex = 2;
            this.lblYoB.Text = "Year of Birth";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(63, 289);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(177, 29);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Standard/Class";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(63, 386);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(98, 29);
            this.lblDivision.TabIndex = 4;
            this.lblDivision.Text = "Division";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(63, 450);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(104, 29);
            this.lblHobbies.TabIndex = 5;
            this.lblHobbies.Text = "Hobbies";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(270, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(270, 223);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(217, 30);
            this.txtYear.TabIndex = 7;
            // 
            // lstClass
            // 
            this.lstClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 25;
            this.lstClass.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.lstClass.Location = new System.Drawing.Point(270, 290);
            this.lstClass.Name = "lstClass";
            this.lstClass.ScrollAlwaysVisible = true;
            this.lstClass.Size = new System.Drawing.Size(217, 77);
            this.lstClass.TabIndex = 3;
            // 
            // lstHob
            // 
            this.lstHob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHob.FormattingEnabled = true;
            this.lstHob.Items.AddRange(new object[] {
            "Singing",
            "Dancing",
            "Swimming",
            "Reading",
            "Travelling"});
            this.lstHob.Location = new System.Drawing.Point(270, 451);
            this.lstHob.Name = "lstHob";
            this.lstHob.ScrollAlwaysVisible = true;
            this.lstHob.Size = new System.Drawing.Size(217, 104);
            this.lstHob.TabIndex = 9;
            // 
            // cboDiv
            // 
            this.cboDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiv.FormattingEnabled = true;
            this.cboDiv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDiv.Location = new System.Drawing.Point(270, 387);
            this.cboDiv.Name = "cboDiv";
            this.cboDiv.Size = new System.Drawing.Size(217, 33);
            this.cboDiv.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(68, 643);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(247, 64);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm Student Details";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(429, 643);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 64);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form_student_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(635, 789);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboDiv);
            this.Controls.Add(this.lstHob);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblYoB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form_student_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYoB;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.CheckedListBox lstHob;
        private System.Windows.Forms.ComboBox cboDiv;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
    }
}

