namespace Lab2.Ex3
{
    partial class FlightReservationDetailscs
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
            this.lblTicketNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtTicketnumber = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.clbService = new System.Windows.Forms.CheckedListBox();
            this.dptFDate = new System.Windows.Forms.DateTimePicker();
            this.lstDestination = new System.Windows.Forms.ListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(188, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flight Reservation Details";
            // 
            // lblTicketNumber
            // 
            this.lblTicketNumber.AutoSize = true;
            this.lblTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumber.Location = new System.Drawing.Point(129, 122);
            this.lblTicketNumber.Name = "lblTicketNumber";
            this.lblTicketNumber.Size = new System.Drawing.Size(172, 29);
            this.lblTicketNumber.TabIndex = 1;
            this.lblTicketNumber.Text = "Ticket Number";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 197);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 29);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Passenger Name";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportNumber.Location = new System.Drawing.Point(129, 260);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(201, 29);
            this.lblPassportNumber.TabIndex = 3;
            this.lblPassportNumber.Text = "Passport Number";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(129, 323);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(90, 29);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(129, 436);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(133, 29);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Destination";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(128, 544);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 29);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Flight Date";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(128, 600);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(73, 29);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(128, 665);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(94, 29);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "Service";
            // 
            // txtTicketnumber
            // 
            this.txtTicketnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketnumber.Location = new System.Drawing.Point(360, 122);
            this.txtTicketnumber.Name = "txtTicketnumber";
            this.txtTicketnumber.Size = new System.Drawing.Size(260, 30);
            this.txtTicketnumber.TabIndex = 9;
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(360, 197);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(373, 30);
            this.txtPName.TabIndex = 10;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportNumber.Location = new System.Drawing.Point(360, 260);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(260, 30);
            this.txtPassportNumber.TabIndex = 11;
            // 
            // lstSource
            // 
            this.lstSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 25;
            this.lstSource.Items.AddRange(new object[] {
            "Ha Noi",
            "Can Tho",
            "Da Nang",
            "Soc Trang",
            "Nha Trang",
            "Da Lat",
            "Vung Tau",
            "Vinh Hy",
            "Dong Nai"});
            this.lstSource.Location = new System.Drawing.Point(360, 323);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(260, 77);
            this.lstSource.TabIndex = 12;
            // 
            // cboClass
            // 
            this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "economy",
            "first class",
            "business"});
            this.cboClass.Location = new System.Drawing.Point(359, 600);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(261, 33);
            this.cboClass.TabIndex = 14;
            // 
            // clbService
            // 
            this.clbService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbService.FormattingEnabled = true;
            this.clbService.Items.AddRange(new object[] {
            "Child Care",
            "Nurse",
            "Wi-Fi",
            "Catering "});
            this.clbService.Location = new System.Drawing.Point(359, 665);
            this.clbService.Name = "clbService";
            this.clbService.ScrollAlwaysVisible = true;
            this.clbService.Size = new System.Drawing.Size(261, 77);
            this.clbService.TabIndex = 16;
            // 
            // dptFDate
            // 
            this.dptFDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptFDate.Location = new System.Drawing.Point(359, 544);
            this.dptFDate.Name = "dptFDate";
            this.dptFDate.Size = new System.Drawing.Size(261, 30);
            this.dptFDate.TabIndex = 17;
            // 
            // lstDestination
            // 
            this.lstDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDestination.FormattingEnabled = true;
            this.lstDestination.ItemHeight = 25;
            this.lstDestination.Items.AddRange(new object[] {
            "Ha Noi",
            "Can Tho",
            "Da Nang",
            "Soc Trang",
            "Nha Trang",
            "Da Lat",
            "Vung Tau",
            "Vinh Hy",
            "Dong Nai"});
            this.lstDestination.Location = new System.Drawing.Point(360, 436);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.Size = new System.Drawing.Size(260, 77);
            this.lstDestination.TabIndex = 18;
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(133, 762);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(211, 56);
            this.btnVerify.TabIndex = 19;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(429, 762);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 56);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FlightReservationDetailscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 864);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lstDestination);
            this.Controls.Add(this.dptFDate);
            this.Controls.Add(this.clbService);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtTicketnumber);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTicketNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "FlightReservationDetailscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservation Detailscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTicketNumber;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtTicketnumber;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.CheckedListBox clbService;
        private System.Windows.Forms.DateTimePicker dptFDate;
        private System.Windows.Forms.ListBox lstDestination;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnClear;
    }
}