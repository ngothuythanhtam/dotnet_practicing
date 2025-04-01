namespace lab8
{
    partial class QuanLyGiangDay
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(65, 295);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(0, 25);
            this.lblHeading.TabIndex = 0;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiangVien.Location = new System.Drawing.Point(62, 36);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(116, 25);
            this.lblGiangVien.TabIndex = 1;
            this.lblGiangVien.Text = "Giang vien: ";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(62, 103);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(155, 25);
            this.lblMaMon.TabIndex = 2;
            this.lblMaMon.Text = "Chon Mon Hoc: ";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(65, 186);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(137, 25);
            this.lblMaLop.TabIndex = 3;
            this.lblMaLop.Text = "Chon Ma Lop:";
            // 
            // cboMaMon
            // 
            this.cboMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Location = new System.Drawing.Point(244, 100);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(450, 33);
            this.cboMaMon.TabIndex = 4;
            // 
            // cboMaLop
            // 
            this.cboMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(244, 178);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(450, 33);
            this.cboMaLop.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(284, 704);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(228, 60);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Dang Xuat";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(94, 295);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(200, 43);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Hien Thi";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(94, 364);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(600, 290);
            this.dgvStudents.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(494, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cap Nhat";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 866);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.cboMaMon);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.lblHeading);
            this.Name = "DanhSachMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sach Mon Hoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnUpdate;
    }
}