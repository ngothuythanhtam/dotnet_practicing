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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab8
{
    public partial class QuanLyGiangDay : Form
    {
        private string maCB;
        private string tenCanBo;
        private string currentMaMon; // To store the current MAMON for updates
        private List<StudentGradeChange> gradeChanges; // To track changes

        // Class to track grade changes
        private class StudentGradeChange
        {
            public string MSSV { get; set; }
            public decimal DiemSo { get; set; }
            public string DiemChu { get; set; }
        }

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

        public QuanLyGiangDay(string maCB, string tenCanBo)
        {
            InitializeComponent();
            this.maCB = maCB;
            this.tenCanBo = tenCanBo;
            lblGiangVien.Text = $"Xin chào: {tenCanBo}";
            LoadClasses();
            LoadSubjects();
            dgvStudents.ReadOnly = false; // Allow editing
            dgvStudents.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.CellEndEdit += new DataGridViewCellEventHandler(dgvStudents_CellEndEdit);
            this.Controls.Add(dgvStudents);
            gradeChanges = new List<StudentGradeChange>();
        }

        private void LoadClasses()
        {
            try
            {
                clsData.OpenConnection();
                string query = @"SELECT DISTINCT GD.MALOP, LH.TENLOP 
                               FROM GIANGDAY GD 
                               JOIN LOPHOC LH ON GD.MALOP = LH.MALOP 
                               WHERE GD.MACB = @MaCB";

                using (SqlCommand cmd = new SqlCommand(query, clsData.con))
                {
                    cmd.Parameters.AddWithValue("@MaCB", maCB);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboMaLop.DataSource = dt;
                        cboMaLop.DisplayMember = "TENLOP";
                        cboMaLop.ValueMember = "MALOP";
                    }
                }
                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
                clsData.CloseConnection();
            }
        }

        private void LoadSubjects()
        {
            try
            {
                clsData.OpenConnection();
                string query = @"SELECT DISTINCT MH.MAMON, MH.TENMON 
                               FROM MONHOC MH 
                               JOIN GIANGDAY GD ON MH.MAMON = GD.MAMON 
                               WHERE GD.MACB = @MaCB";

                using (SqlCommand cmd = new SqlCommand(query, clsData.con))
                {
                    cmd.Parameters.AddWithValue("@MaCB", maCB);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboMaMon.DataSource = dt;
                        cboMaMon.DisplayMember = "TENMON";
                        cboMaMon.ValueMember = "MAMON";
                    }
                }
                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
                clsData.CloseConnection();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedItem == null || cboMaMon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã lớp và mã môn!");
                return;
            }

            string selectedMaLop = cboMaLop.SelectedValue.ToString();
            string selectedMaMon = cboMaMon.SelectedValue.ToString();
            currentMaMon = selectedMaMon; // Store the current MAMON for updates
            gradeChanges.Clear(); // Clear previous changes

            try
            {
                LoadStudents(selectedMaMon, selectedMaLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách sinh viên: " + ex.Message);
            }
        }

        private void LoadStudents(string maMon, string maLop)
        {
            try
            {
                clsData.OpenConnection();
                string query = @"SELECT SV.MSSV, SV.HOVATEN, HM.DIEMSO, HM.DIEMCHU
                               FROM SINHVIEN SV 
                               JOIN HOCMON HM ON SV.MSSV = HM.MSSV
                               JOIN GIANGDAY GD ON SV.MALOP = GD.MALOP AND HM.MAMON = GD.MAMON
                               WHERE HM.MAMON = @MaMon AND SV.MALOP = @MaLop AND GD.MACB = @MaCB";

                using (SqlCommand cmd = new SqlCommand(query, clsData.con))
                {
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@MaCB", maCB);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvStudents.DataSource = dt;
                        dgvStudents.Columns["MSSV"].HeaderText = "MSSV";
                        dgvStudents.Columns["HOVATEN"].HeaderText = "Họ và Tên";
                        dgvStudents.Columns["DIEMSO"].HeaderText = "Điểm Số";
                        dgvStudents.Columns["DIEMCHU"].HeaderText = "Điểm Chữ";
                        dgvStudents.Columns["MSSV"].ReadOnly = true;
                        dgvStudents.Columns["HOVATEN"].ReadOnly = true;
                        dgvStudents.Columns["DIEMSO"].ReadOnly = false; // Allow editing
                        dgvStudents.Columns["DIEMCHU"].ReadOnly = true; // Auto-calculated
                    }
                }
                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
                clsData.CloseConnection();
            }
        }

        private string ConvertDiemSoToDiemChu(decimal diemSo)
        {
            if (diemSo >= 9.0m) return "A";
            if (diemSo >= 8.0m) return "B+";
            if (diemSo >= 7.0m) return "B";
            if (diemSo >= 6.0m) return "C+";
            if (diemSo >= 5.0m) return "C";
            if (diemSo >= 4.5m) return "D+";
            if (diemSo >= 4.0m) return "D";
            return "F";
        }

        private void dgvStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStudents.Columns["DIEMSO"].Index)
            {
                try
                {
                    decimal diemSo;
                    if (!decimal.TryParse(dgvStudents.Rows[e.RowIndex].Cells["DIEMSO"].Value?.ToString(), out diemSo))
                    {
                        MessageBox.Show("Vui lòng nhập số hợp lệ!");
                        dgvStudents.Rows[e.RowIndex].Cells["DIEMSO"].Value = 0;
                        return;
                    }

                    if (diemSo < 0 || diemSo > 10)
                    {
                        MessageBox.Show("Điểm phải từ 0 đến 10!");
                        dgvStudents.Rows[e.RowIndex].Cells["DIEMSO"].Value = 0;
                        return;
                    }

                    string diemChu = ConvertDiemSoToDiemChu(diemSo);
                    dgvStudents.Rows[e.RowIndex].Cells["DIEMCHU"].Value = diemChu;

                    // Add or update the change in the list
                    string mssv = dgvStudents.Rows[e.RowIndex].Cells["MSSV"].Value.ToString();
                    var existingChange = gradeChanges.Find(c => c.MSSV == mssv);
                    if (existingChange != null)
                    {
                        existingChange.DiemSo = diemSo;
                        existingChange.DiemChu = diemChu;
                    }
                    else
                    {
                        gradeChanges.Add(new StudentGradeChange
                        {
                            MSSV = mssv,
                            DiemSo = diemSo,
                            DiemChu = diemChu
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật điểm: " + ex.Message);
                    dgvStudents.Rows[e.RowIndex].Cells["DIEMSO"].Value = 0;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gradeChanges.Count == 0)
            {
                MessageBox.Show("Không có thay đổi để cập nhật!");
                return;
            }

            try
            {
                clsData.OpenConnection();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = clsData.con;
                    cmd.CommandText = @"UPDATE HOCMON 
                                       SET DIEMSO = @DiemSo, DIEMCHU = @DiemChu 
                                       WHERE MSSV = @MSSV AND MAMON = @MaMon";

                    foreach (var change in gradeChanges)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@DiemSo", change.DiemSo);
                        cmd.Parameters.AddWithValue("@DiemChu", change.DiemChu);
                        cmd.Parameters.AddWithValue("@MSSV", change.MSSV);
                        cmd.Parameters.AddWithValue("@MaMon", currentMaMon);
                        cmd.ExecuteNonQuery();
                    }
                }
                clsData.CloseConnection();

                MessageBox.Show("Cập nhật điểm thành công!");
                gradeChanges.Clear(); // Clear the changes after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật điểm: " + ex.Message);
                clsData.CloseConnection();
            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
