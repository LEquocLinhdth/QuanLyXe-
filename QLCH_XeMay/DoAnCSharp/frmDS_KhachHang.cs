using System;
using System.Data;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmDS_KhachHang : Form
    {
        public frmDS_KhachHang(string manv, bool quyen)
        {
            InitializeComponent();
            this.manv = manv;
            this.quyen = quyen;
        }
        Modify modify = new Modify();
        string query;
        string manv;
        bool quyen;
        string mahd;


        public void disableTextBox()
        {
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        public void enableTextBox()
        {
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }
        public void clearTextBox()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        public bool checkTextBox()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                return false;
            else
                return true;
        }
        private void frmDS_KhachHang_Load(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked == false)
                query = "Select * from KhachHang";
            else
                query = "select * from KhachHang where DIENTHOAI like  '%" + txtTimKiem.Text + "%' or MAKH like '%" + txtTimKiem.Text + "%' or TENKH like '%" + txtTimKiem.Text + "%'";

            DataTable tableKH = modify.Table(query);

            dgvDSKhachHang.DataSource = tableKH;

            dgvDSKhachHang.Columns["MAKH"].HeaderText = "Mã KH";
            dgvDSKhachHang.Columns["MAKH"].Width = 90;
            dgvDSKhachHang.Columns["TENKH"].HeaderText = "  Họ tên";
            dgvDSKhachHang.Columns["TENKH"].Width = 190;
            dgvDSKhachHang.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvDSKhachHang.Columns["DIACHI"].Width = 220;
            dgvDSKhachHang.Columns["DIENTHOAI"].HeaderText = "  SDT";
            dgvDSKhachHang.Columns["DIENTHOAI"].Width = 115;

            clearTextBox();
            disableTextBox();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnXemCTHD.Enabled = false;
            dgvDSKhachHang.ClearSelection();
        }

        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDSKhachHang.Rows.Count - 1 || e.RowIndex == -1)
            {
                frmDS_KhachHang_Load(sender, e);
            }
            else
            {
                btnXemCTHD.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaKH.Text = dgvDSKhachHang.SelectedCells[0].Value.ToString();
                txtTenKH.Text = dgvDSKhachHang.SelectedCells[1].Value.ToString();
                txtDiaChi.Text = dgvDSKhachHang.SelectedCells[2].Value.ToString();
                txtSDT.Text = dgvDSKhachHang.SelectedCells[3].Value.ToString();
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from HOADON where MAKH = '" + txtMaKH.Text + "'";
            DataTable tableHD = modify.Table(query);

            DataColumn sttColumn = new DataColumn("STT", typeof(int));
            tableHD.Columns.Add(sttColumn);
            tableHD.Columns["STT"].SetOrdinal(0);

            dgvHoaDon.DataSource = tableHD;

            dgvHoaDon.Columns["STT"].HeaderText = "STT";
            dgvHoaDon.Columns["STT"].Width = 70;
            dgvHoaDon.Columns["MAHD"].HeaderText = "  Mã HD";
            dgvHoaDon.Columns["MAHD"].Width = 100;
            dgvHoaDon.Columns["NGAYLAP"].HeaderText = "  Ngày lập";
            dgvHoaDon.Columns["NGAYLAP"].Width = 200;
            dgvHoaDon.Columns["MANV"].HeaderText = "   Mã NV";
            dgvHoaDon.Columns["MANV"].Width = 100;
            dgvHoaDon.Columns["MAKH"].HeaderText = "  Mã KH";
            dgvHoaDon.Columns["MAKH"].Width = 100;
            dgvHoaDon.Columns["TONGTT"].HeaderText = "   Tổng TT";
            dgvHoaDon.Columns["TONGTT"].Width = 140;

            for (int i = 0; i < tableHD.Rows.Count; i++)
            {
                tableHD.Rows[i]["STT"] = i + 1;
            }

            dgvHoaDon.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            enableTextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                if (MessageBox.Show("Hãy xác nhận việc sửa thông tin " + txtMaKH, "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "Update KHACHHANG Set TENKH = N'" + txtTenKH.Text + "', DIACHI = N'" + txtDiaChi.Text + "', DIENTHOAI = '" + txtSDT.Text + "'";
                    query += " where MAKH = '" + txtMaKH.Text + "'";
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thành công", "Hệ thống");
                        frmDS_KhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống");
                        return;
                    }
                }
            }
            else
                MessageBox.Show("Không thể lưu thay đổi vì thông tin không đầy đủ!", "Hệ thống");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDS_KhachHang_Load(sender, e);
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked)
            {
                txtTimKiem.Enabled = true;
                dgvDSKhachHang.DataSource = null;
                dgvHoaDon.DataSource = null;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Clear();
            }
            else
            {
                frmDS_KhachHang_Load(sender, e);
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Hãy xác nhận việc xóa thông tin " + txtMaKH, "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "Delete KHACHHANG where MAKH = '" + txtMaKH.Text + "'";
                    try
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công", "Hệ thống");
                        frmDS_KhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thông tin khách hàng còn giá trị, không thể xóa lúc này!", "Hệ thống");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            frmDS_KhachHang_Load(sender, e);
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            frmDS_HoaDon frmDSHD = new frmDS_HoaDon(mahd);
            frmDSHD.manv_DSHD = manv;
            frmDSHD.quyen = quyen;
            frmDSHD.StartPosition = FormStartPosition.CenterScreen;
            frmDSHD.MdiParent = frmHeThong.ActiveForm;
            frmDSHD.Show();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXemCTHD.Enabled = true;
            mahd = dgvHoaDon.SelectedCells[1].Value.ToString();
        }

        private void frmDS_KhachHang_Activated(object sender, EventArgs e)
        {
            dgvDSKhachHang.ClearSelection();
        }
    }
}
