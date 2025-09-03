
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmHeThong : Form
    {

        public bool isLogin = false;
        string taikhoan, matkhau;
        public bool quyen { get; set; }

        frmHT_DangNhap frmDN;
        frmHT_LapTaiKhoan frmLTK;
        frmHT_XoaTaiKhoan frmXTK;
        frmHT_DoiMatKhau frmDMK;
        frmDS_KhachHang frmDSKH;
        frmDS_NhanVien frmDSNV;
        frmDS_HoaDon frmDSHD;
        frmDS_HangHoa frmDSHH;
        frmDS_NhaCungCap frmDSNCC;
        frmNV_LapHoaDon frmLHD;
        frmNV_LapPhieuNhap frmLPN;
        frmTK_NhapXuat frmNX;


        public string manv_login { get; set; }

        Modify modify = new Modify();

        public frmHeThong()
        {
            InitializeComponent();
        }
        private void HienThiMenu()
        {
            htDangNhap.Enabled = !isLogin;
            htDangXuat.Enabled = isLogin;

            if (isLogin == true)
            {
                // Hiển thị trạng thái đăng nhập
                sttUser.Text = "Hi!, " + taikhoan;
                sttLoggedTime.Text = "Logged time: " + DateTime.Now;
                //logic
                htDoiMK.Enabled = isLogin;
                menuDanhSach.Enabled = isLogin;
                menuNghiepVu.Enabled = isLogin;

                // Hiển thị menu theo quyền
                switch (quyen)
                {
                    case true:
                        htThem.Enabled = true;
                        htXoa.Enabled = true;
                        dsNhanVien.Enabled = true;
                        menuThongKe.Enabled = true;
                        break;
                    case false:
                        htThem.Enabled = false;
                        htXoa.Enabled = false;
                        dsNhanVien.Enabled = false;
                        menuThongKe.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                sttUser.Text = "Status: chưa đăng nhập";
                sttLoggedTime.Text = "Logged time: ";
                //Logic
                htThem.Enabled = isLogin;
                htXoa.Enabled = isLogin;
                htDoiMK.Enabled = isLogin;
                menuDanhSach.Enabled = isLogin;
                menuNghiepVu.Enabled = isLogin;
                menuThongKe.Enabled = isLogin;
            }

        }


        private void htDangNhap_Click(object sender, EventArgs e)
        {
            frmDN = new frmHT_DangNhap();
            if (frmDN.ShowDialog() == DialogResult.OK)
            {
                while (true)
                {
                    if (frmDN.DialogResult != DialogResult.OK)
                    { break; }
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();
                        taikhoan = frmDN.txtTaiKhoan.Text;
                        matkhau = frmDN.txtMatKhau.Text;

                        if (taikhoan != "" && matkhau != "")
                        {

                            string query = "select * from ACCOUNT where TAIKHOAN = '" + taikhoan + "' and MATKHAU = '" + matkhau + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataReader rdr = cmd.ExecuteReader();
                            if (rdr.Read() == true)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Hệ thống");
                                manv_login = rdr.GetValue(2).ToString();
                                quyen = rdr.GetBoolean(3);
                                isLogin = true;
                                HienThiMenu();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Tên đang nhập hoặc mật khẩu không đúng", "Hệ thống");
                                frmDN.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Phải nhập đầy đủ thông tin đăng nhập", "Hệ thống");
                            frmDN.ShowDialog();
                        }

                        conn.Close();
                    }
                }
            }
            else
            {
                isLogin = false;
            }
        }
        private void htThem_Click(object sender, EventArgs e)
        {
            if (frmLTK == null || frmLTK.IsDisposed)
            {
                frmLTK = new frmHT_LapTaiKhoan();
                if (frmLTK.ShowDialog() == DialogResult.Cancel)
                {
                    frmLTK.Dispose();
                }
            }
        }

        private void htXoa_Click(object sender, EventArgs e)
        {
            if (frmXTK == null || frmXTK.IsDisposed)
            {
                frmXTK = new frmHT_XoaTaiKhoan();
                if (frmXTK.ShowDialog() == DialogResult.Cancel)
                {
                    frmXTK.Dispose();
                }
            }
        }

        private void htDoiMK_Click(object sender, EventArgs e)
        {
            if (frmDMK == null || frmDMK.IsDisposed)
            {
                frmDMK = new frmHT_DoiMatKhau();
                frmDMK.tk = taikhoan;
                if (frmDMK.ShowDialog() == DialogResult.Cancel)
                {
                    frmDMK.Dispose();
                }
            }
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {

        }
        private void htDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (!f.IsDisposed)
                        f.Close();
                }
                MessageBox.Show("Đăng xuất thành công!", "Hệ thống");
                isLogin = false;
                HienThiMenu();
            }
        }


        private void nvLapHoaDon_Click_1(object sender, EventArgs e)
        {
            if (frmLHD == null || frmLHD.IsDisposed)
            {
                frmLHD = new frmNV_LapHoaDon(manv_login);
                frmLHD.StartPosition = FormStartPosition.CenterScreen;
                frmLHD.MdiParent = this;
                frmLHD.Show();
            }
        }
        private void nvLapPhieuNhap_Click(object sender, EventArgs e)
        {
            if (frmLPN == null || frmLPN.IsDisposed)
            {
                frmLPN = new frmNV_LapPhieuNhap(manv_login);
                frmLPN.StartPosition = FormStartPosition.CenterScreen;
                frmLPN.MdiParent = this;
                frmLPN.Show();
            }
        }

        private void dsKhachHang_Click(object sender, EventArgs e)
        {
            if (frmDSKH == null || frmDSKH.IsDisposed)
            {
                frmDSKH = new frmDS_KhachHang(manv_login, quyen);
                frmDSKH.StartPosition = FormStartPosition.CenterScreen;
                frmDSKH.MdiParent = this;
                frmDSKH.Show();
            }
        }

        private void dsNhanVien_Click(object sender, EventArgs e)
        {
            if (frmDSNV == null || frmDSNV.IsDisposed)
            {
                frmDSNV = new frmDS_NhanVien();
                frmDSNV.StartPosition = FormStartPosition.CenterScreen;
                frmDSNV.MdiParent = this;
                frmDSNV.Show();
            }
        }
        private void dsHoaDon_Click(object sender, EventArgs e)
        {
            if (frmDSHD == null || frmDSHD.IsDisposed)
            {
                frmDSHD = new frmDS_HoaDon();
                frmDSHD.StartPosition = FormStartPosition.CenterScreen;
                frmDSHD.manv_DSHD = manv_login;
                frmDSHD.quyen = quyen;
                frmDSHD.MdiParent = this;
                frmDSHD.Show();
            }
        }

        private void dsXeMay_Click(object sender, EventArgs e)
        {
            if (frmDSHH == null || frmDSHH.IsDisposed)
            {
                frmDSHH = new frmDS_HangHoa();
                frmDSHH.StartPosition = FormStartPosition.CenterScreen;
                frmDSHH.MdiParent = this;
                frmDSHH.Show();
            }
        }

        private void dsNhaCungCap_Click(object sender, EventArgs e)
        {
            if (frmDSNCC == null || frmDSNCC.IsDisposed)
            {
                frmDSNCC = new frmDS_NhaCungCap();
                frmDSNCC.StartPosition = FormStartPosition.CenterScreen;
                frmDSNCC.MdiParent = this;
                frmDSNCC.Show();
            }
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            if (frmNX == null || frmNX.IsDisposed)
            {
                frmNX = new frmTK_NhapXuat();
                frmNX.StartPosition = FormStartPosition.CenterScreen;
                frmNX.MdiParent = this;
                frmNX.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                string link = "https://fit.agu.edu.vn/";

                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở trang web: {ex.Message}", "Lỗi");
                }
            }
        }
    }
}
