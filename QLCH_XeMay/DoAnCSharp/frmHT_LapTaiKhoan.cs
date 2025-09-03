
using System.Data;
using System.Data.SqlClient;

namespace DoAnCSharp
{
    public partial class frmHT_LapTaiKhoan : Form
    {
        Modify modify = new Modify();
        string id, tk, mk;
        int quyen;
        public frmHT_LapTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmHT_LapTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("SELECT MANV, TENNV FROM NHANVIEN", conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Tạo chuỗi hiển thị từ cột ID và Ten và phân cách bằng " - "
                            string displayValue = $"{row["MANV"]} - {row["TENNV"]}";
                            cboChonNV.Items.Add(displayValue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show($"Lỗi: " + ex.Message);
            }
        }


        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (cboChonNV.Text == "" || txtMatKhau.Text == "" || txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin để tiến hành lập tài khoản mới!", "Hệ thống");
                return;
            }
            string selectedValue = cboChonNV.SelectedItem.ToString();

            // Tách chuỗi để lấy phần ID, parts = các phần sau khi tách.
            string[] parts = selectedValue.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            // parts[0] chứa phần ID, dùng để thực hiện truy vấn
            id = parts[0].Trim();

            tk = txtTaiKhoan.Text;
            mk = txtMatKhau.Text;
            quyen = chbQuyenQT.Checked ? 1 : 0;
            SqlConnection conn = Connection.GetSqlConnection();
            string query = "Insert into ACCOUNT values ('" + tk + "','" + mk + "','" + id + "','" + quyen + "')";
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT 1 FROM ACCOUNT WHERE TAIKHOAN = '" + tk + "' OR MANV = '" + id + "'", conn))
                {
                    conn.Open();

                    // Sử dụng ExecuteScalar để kiểm tra sự tồn tại
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại hoặc nhân viên này đã được tạo tài khoản rồi!", "Hệ thống");
                    }
                    else
                    {
                        modify.Command(query);
                        MessageBox.Show("Tạo tài khoản mới thành công", "Hệ thống");
                        this.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
