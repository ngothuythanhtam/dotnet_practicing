using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Ex2
{
    public partial class Employee_details: Form
    {
        public Employee_details()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtEName.Text))
            {
                MessageBox.Show("Please enter full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtxtEAddress.Text))
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtEAddress.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string message =
                    $"Employee Details:\n\n" +
                    $"Full name: {txtEName.Text}\n" +
                    $"Address: {rtxtEAddress.Text}\n" +
                    $"Join Date: {dtpDoJ.Value.ToShortDateString()}\n" +
                    $"Education: {lstEducation.SelectedItem}\n" +
                    $"Department: {cboDepartment.SelectedItem} \n";
                MessageBox.Show(message,"Employee Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEName.Clear();
            rtxtEAddress.Clear();
            dtpDoJ.Value = DateTime.Today;
            lstEducation.SelectedIndex = 0;
            cboDepartment.SelectedIndex = 0;
            txtEName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
