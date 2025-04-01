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
using Lab6.prjDVD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab6.prjCanBo
{
    public partial class frmThongTinCanBo: Form
    {
        int MaCb;

        public frmThongTinCanBo()
        {
            
            InitializeComponent();
            if (clsDatabase.OpenConnection())
            {
                MessageBox.Show("kết nối thành công");
                clsDatabase.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối");
            }
            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * From ChucVu", clsDatabase.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCV.DataSource = dt;
            cboCV.DisplayMember = "TenCV";
            cboCV.ValueMember = "MaCV";
            clsDatabase.CloseConnection();
            btnSave.Enabled = false;
        }

        void ResetFields(bool status)
        {
            txtMSCB.Clear();
            txtHoTen.Clear();
            cboCV.SelectedIndex = -1;
            txtDonGia.Clear();
            txtSoGioGiang.Clear();
            btnSave.Enabled = status;
            btnClose.Enabled = status;
            btnAdd.Enabled = !status;
            txtMSCB.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MAX(MaCB) FROM CanBo", clsDatabase.con);
                object result = com.ExecuteScalar();
                MaCb = (result == DBNull.Value) ? 1 : Convert.ToInt32(result);
                MaCb++;
                clsDatabase.CloseConnection();

                ResetFields(true);
                txtMSCB.Text = MaCb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next Ma Can Bo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaCb = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into CanBo Values (@MaCB, @TenCB, @MaCV, @SoGioGiang, @DonGia)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@MaCB", SqlDbType.Int);
                p1.Value = MaCb;
                SqlParameter p2 = new SqlParameter("@TenCB", SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text;
                SqlParameter p3 = new SqlParameter("@MaCV", SqlDbType.Int);
                p3.Value = cboCV.SelectedValue;
                SqlParameter p4 = new SqlParameter("@SoGioGiang", SqlDbType.Int);
                p4.Value = txtSoGioGiang.Text;
                SqlParameter p5 = new SqlParameter("@DonGia", SqlDbType.Money);
                p5.Value = txtDonGia.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!");
                clsDatabase.CloseConnection();
                ResetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
