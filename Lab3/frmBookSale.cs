using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmBookSale: Form
    {
        private clsBookSale mBookSale;
        public frmBookSale()
        {
            InitializeComponent();
            txtExPrice.ReadOnly = true;
            txtDiscount.ReadOnly = true;
            txtNetDue.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //mBookSale = new clsBookSale();
                //mBookSale.Title = txtTitle.Text;
                //mBookSale.Quantity = Convert.ToInt32(txtQuantity.Text);
                //mBookSale.Price = Convert.ToDecimal(txtPrice.Text);
                //mBookSale.Discount = cbNormalDiscount.Checked;

                mBookSale = new clsStudentBookSale(txtTitle.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), cbNormalDiscount.Checked, cbDistinctStudent.Checked);
                txtPrice.Text = mBookSale.Price.ToString("C");
                txtExPrice.Text = mBookSale.ExtendedPrice().ToString("C");
                txtDiscount.Text = mBookSale.DiscountAmount().ToString("C");
                txtNetDue.Text = mBookSale.NetDue().ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price. " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtExPrice.Clear();
            txtTitle.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string message = "Sales Total: " +
                clsBookSale.SalesTotal.ToString("C") +
                "\nSales count: " + clsBookSale.SalesCount.ToString();
            MessageBox.Show(message, "Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
