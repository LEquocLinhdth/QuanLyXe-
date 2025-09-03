
using System.Data;
using System.Data.SqlClient;

namespace DoAnCSharp
{
    public partial class frmHT_XoaTaiKhoan : Form
    {
        public frmHT_XoaTaiKhoan()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();


        private void frmHT_XoaTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    DataTable dataTable = modify.Table("select * from ACCOUNT");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cboChonNV.Items.Add(row["MANV"]);
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show($"Lỗi: " + ex.Message);
            }
            cboChonNV.SelectedIndex = 0;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy xác nhận việc xóa tài khoản của " + cboChonNV.Text, "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();
                        modify.Command("delete ACCOUNT where MANV = '" + cboChonNV.Text + "'");
                        MessageBox.Show("Xóa thành công tài khoản của " + cboChonNV.Text);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    MessageBox.Show($"Lỗi: " + ex.Message);
                }
            }
        }
    }
}
