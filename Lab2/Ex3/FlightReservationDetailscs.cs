using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Ex3
{
    public partial class FlightReservationDetailscs: Form
    {
        public FlightReservationDetailscs()
        {
            InitializeComponent();
        }

        private bool ValidInputs()
        {
            bool isValid = true;
            StringBuilder errorMessage = new StringBuilder("Please fix the following issues:");

            // Check text fields
            if (string.IsNullOrWhiteSpace(txtTicketnumber.Text))
            {
                errorMessage.Append("\n- Ticket number");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPName.Text))
            {
                errorMessage.Append("\n- Passenger name");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPassportNumber.Text))
            {
                errorMessage.Append("\n- Passport number");
                isValid = false;
            }

            // Check selections
            if (lstSource.SelectedIndex == -1)
            {
                errorMessage.Append("\n- Source");
                isValid = false;
            }
            if (lstDestination.SelectedIndex == -1)
            {
                errorMessage.Append("\n- Destination");
                isValid = false;
            }
            if (cboClass.SelectedIndex == -1)
            {
                errorMessage.Append("\n- Class");
                isValid = false;
            }
            if (clbService.CheckedItems.Count == 0)
            {
                errorMessage.Append("\n- At least one Service");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (!ValidInputs()) return;

            string source = lstSource.SelectedItem.ToString();
            string destination = lstDestination.SelectedItem.ToString();

            if (source == destination)
            {
                MessageBox.Show("The origin city and destination city cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected services
            var services = new List<string>();
            foreach (var item in clbService.CheckedItems)
            {
                services.Add(item.ToString());
            }

            string message = $"Flight Reservation Details:\n\n" +
                           $"Ticket Number: {txtTicketnumber.Text}\n" +
                           $"Passenger Name: {txtPName.Text}\n" +
                           $"Passport Number: {txtPassportNumber.Text}\n" +
                           $"From {source} to {destination}\n" +
                           $"Flight Date: {dptFDate.Value.ToShortDateString()}\n" +
                           $"Class: {cboClass.SelectedItem}\n" +
                           $"Services: {string.Join(", ", services)}";

            MessageBox.Show(message, "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketnumber.Clear();
            txtPName.Clear();
            txtPassportNumber.Clear();
            lstSource.SelectedIndex = -1;
            lstDestination.SelectedIndex = -1;
            cboClass.SelectedIndex = -1;
            for (int i = 0; i < clbService.Items.Count; i++)
            {
                clbService.SetItemChecked(i, false);
            }
            dptFDate.Value = DateTime.Today;
            txtTicketnumber.Focus();
        }
    }
}
