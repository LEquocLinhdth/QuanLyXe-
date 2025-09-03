using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmHT_DoiMatKhau : Form
    {
        string query;
        Modify modify = new Modify();
        string mk;
        public string tk { get; set; }
        public frmHT_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmHT_DoiMatKhau_Load(object sender, EventArgs e)
        {
            frmHeThong frmHT = new frmHeThong();
            txtTaiKhoan.Text = tk;
            query = "select MATKHAU from ACCOUNT where TAIKHOAN = '" + tk + "'";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mk = reader.GetString(0);
                        }
                    }
                }
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ!", "Hệ thống");
                return;
            }
            else if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!", "Hệ thống");
                return;
            }
            else if (txtXacNhan.Text == "")
            {
                MessageBox.Show("Chưa xác nhận mật khẩu!", "Hệ thống");
                return;
            }


            if (mk != txtMatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Hệ thống");
                return;
            }
            else if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Hệ thống");
                return;
            }
            string query = "Update ACCOUNT set MATKHAU = '" + txtMatKhauMoi.Text + "' where TAIKHOAN = '" + tk + "'";
            try
            {
                modify.Command(query);
                MessageBox.Show("Đổi mật khẩu thành công!", "Hệ thống");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
        }
    }
}
