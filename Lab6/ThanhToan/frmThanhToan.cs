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
using System.Xml.Linq;
using Lab6.prjDVD;

namespace Lab6.ThanhToan
{
    public partial class frmThanhToan: Form
    {
        int soHD;
        class clsData
        {
            public static SqlConnection con;
            public static bool OpenConnection()
            {
                try
                {
                    con = new SqlConnection("Data Source=DESKTOP-3JFU13I; Initial Catalog=ThanhToan;User ID=mylogin;Password=mylogin");
                    con.Open();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            public static bool CloseConnection()
            {
                try
                {
                    con.Close();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public frmThanhToan()
        {
            InitializeComponent();
            if (clsData.OpenConnection())
            {
                MessageBox.Show("kết nối thành công");
                clsData.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối");
            }
            clsData.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Phong", clsData.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboSoPhong.DataSource = dt;
            cboSoPhong.DisplayMember = "TenPhong";
            cboSoPhong.ValueMember = "MaPhong";
            clsData.CloseConnection();
            btnLuu.Enabled = false;
        }

        void ResetFields(bool status)
        {
            txtSoHD.Clear();
            txtHoTen.Clear();
            cboSoPhong.SelectedIndex = -1;
            txtSoCMND.Clear();
            txtSoTienTT.Clear();
            btnLuu.Enabled = status;
            btnThoat.Enabled = status;
            btnThem.Enabled = !status;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsData.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MAX(SoHD) FROM KhachHang", clsData.con);
                object result = com.ExecuteScalar();
                soHD = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                clsData.CloseConnection();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next SoHD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                soHD = 0;
            }
            soHD++;
            ResetFields(true);
            txtSoHD.Text = soHD.ToString();
            dtpNgayTT.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dtpNgayTT.Value = DateTime.Now;

                string strInsert = "Insert Into KHachHang Values(@SoHD, @TenKH, @SoCMND, @SoTien, @NgayTT, @SoPhong)";
                clsData.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsData.con);

                SqlParameter p1 = new SqlParameter("@SoHD", SqlDbType.Int);
                p1.Value = soHD;
                SqlParameter p2 = new SqlParameter("@TenKH", SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text;
                SqlParameter p3 = new SqlParameter("@SoCMND", SqlDbType.Int);
                p3.Value = txtSoCMND.Text;
                SqlParameter p4 = new SqlParameter("@SoTien", SqlDbType.Money);
                p4.Value = txtSoTienTT.Text;
                SqlParameter p5 = new SqlParameter("@NgayTT", SqlDbType.DateTime);
                p5.Value = dtpNgayTT.Value;
                SqlParameter p6 = new SqlParameter("@SoPhong", SqlDbType.Int);
                p6.Value = cboSoPhong.SelectedValue;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!!");
                clsData.CloseConnection();
                ResetFields(false);
                btnThoat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
