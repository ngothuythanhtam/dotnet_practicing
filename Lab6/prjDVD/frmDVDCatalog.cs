using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6.prjDVD
{
    public partial class frmDVDCatalog: Form
    {
        int CodeNo;
        decimal price;
        string language;
        int subTitle;

        public frmDVDCatalog()
        {
            InitializeComponent();
            if (Database.OpenConnection())
            {
                MessageBox.Show("kết nối thành công");
                Database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối");
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void updPrice_ValueChanged(object sender, EventArgs e)
        {
            price = updPrice.Value;
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang.SelectedIndex == -1) return;
            language = cboLang.Text;
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 1;
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 0;
        }

        void ResetFields(bool status)
        {
            txtNo.Clear();
            txtTitle.Clear();
            cboLang.SelectedIndex = -1;
            updPrice.Value = updPrice.Minimum;
            radYes.Checked = true;
            radNo.Checked = false;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            txtTitle.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MAX(DVDCodeNo) FROM DVDLibrary", Database.con);
                object result = com.ExecuteScalar();
                CodeNo = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                CodeNo++;
                Database.CloseConnection();

                ResetFields(true);
                txtNo.Text = CodeNo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next DVD Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodeNo = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into DVDLibrary Values (@DVDNo, @DVDTitle, @DVDLang, @SubTitle, @price)";
                Database.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, Database.con);

                SqlParameter p1 = new SqlParameter("@DVDNo", SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar);
                p2.Value = txtTitle.Text;
                SqlParameter p3 = new SqlParameter("@DVDLang", SqlDbType.NVarChar);
                p3.Value = language;
                SqlParameter p4 = new SqlParameter("@SubTitle", SqlDbType.Bit);
                p4.Value = subTitle;
                SqlParameter p5 = new SqlParameter("@price", SqlDbType.Money);
                p5.Value = updPrice.Value;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!");
                Database.CloseConnection();
                ResetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
        }
    }
}
