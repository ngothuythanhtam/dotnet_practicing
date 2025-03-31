namespace Lab3
{
    partial class frmBookSale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookInformation = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtExPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblExPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNetDue = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNetDue = new System.Windows.Forms.TextBox();
            this.cbNormalDiscount = new System.Windows.Forms.CheckBox();
            this.cbDistinctStudent = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.grpBookInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // grpBookInformation
            // 
            this.grpBookInformation.Controls.Add(this.cbDistinctStudent);
            this.grpBookInformation.Controls.Add(this.cbNormalDiscount);
            this.grpBookInformation.Controls.Add(this.txtNetDue);
            this.grpBookInformation.Controls.Add(this.txtDiscount);
            this.grpBookInformation.Controls.Add(this.lblNetDue);
            this.grpBookInformation.Controls.Add(this.lblDiscount);
            this.grpBookInformation.Controls.Add(this.btnSum);
            this.grpBookInformation.Controls.Add(this.btnExit);
            this.grpBookInformation.Controls.Add(this.btnCalculate);
            this.grpBookInformation.Controls.Add(this.btnNew);
            this.grpBookInformation.Controls.Add(this.txtExPrice);
            this.grpBookInformation.Controls.Add(this.txtPrice);
            this.grpBookInformation.Controls.Add(this.txtQuantity);
            this.grpBookInformation.Controls.Add(this.txtTitle);
            this.grpBookInformation.Controls.Add(this.lblExPrice);
            this.grpBookInformation.Controls.Add(this.lblPrice);
            this.grpBookInformation.Controls.Add(this.lblQuantity);
            this.grpBookInformation.Controls.Add(this.lblTitle);
            this.grpBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInformation.Location = new System.Drawing.Point(35, 59);
            this.grpBookInformation.Name = "grpBookInformation";
            this.grpBookInformation.Size = new System.Drawing.Size(976, 670);
            this.grpBookInformation.TabIndex = 1;
            this.grpBookInformation.TabStop = false;
            this.grpBookInformation.Text = "Book Information";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 551);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 69);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(63, 551);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(176, 69);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtExPrice
            // 
            this.txtExPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtExPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExPrice.Location = new System.Drawing.Point(339, 291);
            this.txtExPrice.Name = "txtExPrice";
            this.txtExPrice.Size = new System.Drawing.Size(239, 34);
            this.txtExPrice.TabIndex = 7;
            this.txtExPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(339, 223);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(239, 34);
            this.txtPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(339, 155);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(239, 34);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(339, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(239, 34);
            this.txtTitle.TabIndex = 4;
            // 
            // lblExPrice
            // 
            this.lblExPrice.AutoSize = true;
            this.lblExPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExPrice.Location = new System.Drawing.Point(58, 291);
            this.lblExPrice.Name = "lblExPrice";
            this.lblExPrice.Size = new System.Drawing.Size(177, 29);
            this.lblExPrice.TabIndex = 3;
            this.lblExPrice.Text = "Extended Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(58, 223);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(58, 165);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 29);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(58, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(750, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 69);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(524, 551);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(176, 69);
            this.btnSum.TabIndex = 11;
            this.btnSum.Text = "Summary";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(58, 367);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(106, 29);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "Discount";
            // 
            // lblNetDue
            // 
            this.lblNetDue.AutoSize = true;
            this.lblNetDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetDue.Location = new System.Drawing.Point(58, 459);
            this.lblNetDue.Name = "lblNetDue";
            this.lblNetDue.Size = new System.Drawing.Size(101, 29);
            this.lblNetDue.TabIndex = 13;
            this.lblNetDue.Text = "Net Due";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(339, 362);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(239, 34);
            this.txtDiscount.TabIndex = 14;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetDue
            // 
            this.txtNetDue.BackColor = System.Drawing.SystemColors.Control;
            this.txtNetDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetDue.Location = new System.Drawing.Point(339, 454);
            this.txtNetDue.Name = "txtNetDue";
            this.txtNetDue.Size = new System.Drawing.Size(239, 34);
            this.txtNetDue.TabIndex = 15;
            this.txtNetDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbNormalDiscount
            // 
            this.cbNormalDiscount.AutoSize = true;
            this.cbNormalDiscount.Location = new System.Drawing.Point(676, 329);
            this.cbNormalDiscount.Name = "cbNormalDiscount";
            this.cbNormalDiscount.Size = new System.Drawing.Size(213, 33);
            this.cbNormalDiscount.TabIndex = 16;
            this.cbNormalDiscount.Text = "Normal Discount";
            this.cbNormalDiscount.UseVisualStyleBackColor = true;
            // 
            // cbDistinctStudent
            // 
            this.cbDistinctStudent.AutoSize = true;
            this.cbDistinctStudent.Location = new System.Drawing.Point(676, 404);
            this.cbDistinctStudent.Name = "cbDistinctStudent";
            this.cbDistinctStudent.Size = new System.Drawing.Size(201, 33);
            this.cbDistinctStudent.TabIndex = 17;
            this.cbDistinctStudent.Text = "Distinct Student";
            this.cbDistinctStudent.UseVisualStyleBackColor = true;
            // 
            // frmBookSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 756);
            this.Controls.Add(this.grpBookInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBookSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBookInformation.ResumeLayout(false);
            this.grpBookInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBookInformation;
        private System.Windows.Forms.TextBox txtExPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblExPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtNetDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblNetDue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.CheckBox cbDistinctStudent;
        private System.Windows.Forms.CheckBox cbNormalDiscount;
    }
}

