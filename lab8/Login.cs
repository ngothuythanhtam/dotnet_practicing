using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab8
{
    public partial class Login : Form
    {
        class clsData
        {
            public static SqlConnection con;
            public static bool OpenConnection()
            {
                try
                {
                    con = new SqlConnection("Data Source=DESKTOP-3JFU13I; Initial Catalog=lab8;User ID=mylogin;Password=mylogin");
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

        public Login()
        {
            InitializeComponent();
            if (clsData.OpenConnection())
            {
                MessageBox.Show("Kết nối thành công");
                clsData.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaCB.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mã cán bộ và mật khẩu!");
                    return;
                }

                clsData.OpenConnection();
                string query = "SELECT MACB, TENCANBO FROM CANBO WHERE MACB = @macb AND MATKHAU = @matkhau";
                using (SqlCommand cmd = new SqlCommand(query, clsData.con))
                {
                    cmd.Parameters.AddWithValue("@macb", txtMaCB.Text.Trim());
                    cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string maCB = reader["MACB"].ToString();
                            string tenCanBo = reader["TENCANBO"].ToString();
                            MessageBox.Show($"Đăng nhập thành công! Xin chào {tenCanBo}");

                            // Open personal page form with officer code
                            QuanLyGiangDay danhSachMonHoc = new QuanLyGiangDay(maCB, tenCanBo);
                            danhSachMonHoc.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mã cán bộ hoặc mật khẩu không đúng!");
                        }
                    }
                }
                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsData.CloseConnection();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}