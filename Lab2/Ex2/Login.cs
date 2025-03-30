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
    public partial class Login: Form
    {
        private const string ValidUsername = "Admin";
        private const string ValidUserPassword = "Admin";
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPass = txtPassword.Text;

            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPass))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(userName == ValidUsername && userPass == ValidUserPassword)
            {
                MessageBox.Show("Login Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Employee_details employee_Details_Form = new Employee_details();
                employee_Details_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong name or password!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtUserName.Focus();
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
