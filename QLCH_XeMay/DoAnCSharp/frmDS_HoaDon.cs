using System;
using System.Data;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmDS_HoaDon : Form
    {
        Modify modify = new Modify();
        frmNV_LapHoaDon frmLHD;
        frmNV_InPhieu frmIHD;
        public string manv_DSHD { get; set; }
        public bool quyen { get; set; }
        string query;
        string today = DateTime.Now.ToString("MM-dd-yyyy");

        public frmDS_HoaDon()
        {
            InitializeComponent();
        }
        public frmDS_HoaDon(string mahd)
        {
            InitializeComponent();
            btnThem.Enabled = false;
            btnInHD.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyHD.Enabled = false;
            chbTimKiem.Checked = true;
            txtTimKiem.Text = mahd;
            dgvDSHoaDon.ClearSelection();
        }
        public void clearTextBox()
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtMaNVLap.Clear();
            txtTongTT.Clear();
            dtpNgayLap.Value = DateTime.Now;
        }

        private void frmDS_HoaDon_Load(object sender, EventArgs e)
        {
            clearTextBox();
            if (quyen == true) //được xem tất cả hóa đơn
            {
                if (chbTimKiem.Checked == false)
                    query = "Select * from HoaDon";
                else
                    query = "select * from HoaDon where MAHD like '%" + txtTimKiem.Text + "%' or MANV like '" + txtTimKiem.Text + "' or MAKH like '%" + txtMaKH + "%'";
            }
            else //Giới hạn xem hóa đơn
            {
                if (chbTimKiem.Checked == false)
                    query = "Select * from HoaDon where MANV = '" + manv_DSHD + "'";
                else
                    query = "select * from HoaDon where MANV = '" + manv_DSHD + "' and MAHD like '%" + txtTimKiem.Text + "%' or MANV like '" + txtTimKiem.Text + "' or MAKH like '%" + txtMaKH + "%'";
            }

            DataTable tableHD = modify.Table(query);

            DataColumn sttColumn = new DataColumn("STT", typeof(int));
            tableHD.Columns.Add(sttColumn);
            tableHD.Columns["STT"].SetOrdinal(0);

            for (int i = 0; i < tableHD.Rows.Count; i++)
            {
                tableHD.Rows[i]["STT"] = i + 1;
            }

            dgvDSHoaDon.DataSource = tableHD;

            dgvDSHoaDon.Columns["STT"].HeaderText = "STT";
            dgvDSHoaDon.Columns["STT"].Width = 70;
            dgvDSHoaDon.Columns["MAHD"].HeaderText = "  Mã HD";
            dgvDSHoaDon.Columns["MAHD"].Width = 100;
            dgvDSHoaDon.Columns["NGAYLAP"].HeaderText = "  Ngày lập";
            dgvDSHoaDon.Columns["NGAYLAP"].Width = 200;
            dgvDSHoaDon.Columns["MANV"].HeaderText = "   Mã NV";
            dgvDSHoaDon.Columns["MANV"].Width = 100;
            dgvDSHoaDon.Columns["MAKH"].HeaderText = "  Mã KH";
            dgvDSHoaDon.Columns["MAKH"].Width = 100;
            dgvDSHoaDon.Columns["TONGTT"].HeaderText = "   Tổng TT";
            dgvDSHoaDon.Columns["TONGTT"].Width = 140;

            btnInHD.Enabled = false;
            btnHuyHD.Enabled = false;
            btnXoa.Enabled = false;

            dgvDSHoaDon.ClearSelection();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmLHD == null || frmLHD.IsDisposed)
            {
                frmLHD = new frmNV_LapHoaDon(manv_DSHD);
                frmLHD.StartPosition = FormStartPosition.CenterScreen;
                frmLHD.MdiParent = frmHeThong.ActiveForm;
                frmLHD.Show();
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa chọn hóa đơn cần in!", "Hệ thống");
                return;
            }
            frmIHD = new frmNV_InPhieu(1, txtMaHD.Text); //mã hóa đơn dùng để tìm chi tiết hóa đơn và tạo phiếu xuất
            frmIHD.ShowDialog();
        }

        private void dgvDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDSHoaDon.Rows.Count - 1 || e.RowIndex == -1)
            {
                frmDS_HoaDon_Load(sender, e);
            }
            else
            {
                btnXoa.Enabled = true;
                btnInHD.Enabled = true;
                btnHuyHD.Enabled = true;
                txtMaHD.Text = dgvDSHoaDon.SelectedCells[1].Value.ToString();
                dtpNgayLap.Text = dgvDSHoaDon.SelectedCells[2].Value.ToString();
                txtMaNVLap.Text = dgvDSHoaDon.SelectedCells[3].Value.ToString();
                txtMaKH.Text = dgvDSHoaDon.SelectedCells[4].Value.ToString();
                txtTongTT.Text = dgvDSHoaDon.SelectedCells[5].Value.ToString();
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from CTHD where MAHD = '" + txtMaHD.Text + "'";
            DataTable tableCTHD = modify.Table(query);

            DataColumn sttColumn = new DataColumn("STT", typeof(int));
            tableCTHD.Columns.Add(sttColumn);
            tableCTHD.Columns["STT"].SetOrdinal(0);

            for (int i = 0; i < tableCTHD.Rows.Count; i++)
            {
                tableCTHD.Rows[i]["STT"] = i + 1;
            }
            dgvChiTietHD.DataSource = tableCTHD;

            dgvChiTietHD.Columns["STT"].HeaderText = "  STT";
            dgvChiTietHD.Columns["STT"].Width = 70;
            dgvChiTietHD.Columns["MAHD"].HeaderText = "  Mã HĐ";
            dgvChiTietHD.Columns["MAHH"].HeaderText = "    Mã hàng";
            dgvChiTietHD.Columns["SLUONG"].HeaderText = "    SL";
            dgvChiTietHD.Columns["SLUONG"].Width = 100;
            dgvChiTietHD.Columns["DONGIA"].HeaderText = " Đơn Giá";
            dgvChiTietHD.Columns["DONGIA"].Width = 157;
            dgvChiTietHD.Columns["GIAMGIA"].HeaderText = "  % Giảm";
            dgvChiTietHD.Columns["GIAMGIA"].Width = 100;
            dgvChiTietHD.Columns["THANHTIEN"].HeaderText = "  Thành tiền";
            dgvChiTietHD.Columns["THANHTIEN"].Width = 157;
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked == false)
            {
                frmDS_HoaDon_Load(sender, e);
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Enabled = false;
            }
            else
            {
                dgvDSHoaDon.DataSource = null;
                dgvChiTietHD.DataSource = null;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Clear();
                txtTimKiem.Enabled = true;

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            frmDS_HoaDon_Load(sender, e);
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn " + txtMaHD.Text + " không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "Select * from CTHD where MAHD = " + "'" + txtMaHD.Text + "'";
                DataTable dt = modify.Table(query);
                string mahh;
                int sl;
                foreach (DataRow row in dt.Rows)
                {
                    mahh = row["MAHH"].ToString();
                    sl = Convert.ToInt32(row["SLUONG"].ToString());
                    query = "Update HANGHOA Set SLTON = SLTON + " + sl + " where MAHH = '" + mahh + "'";
                    modify.Command(query);
                }

                query = "Delete from CTHD where MAHD = '" + txtMaHD.Text + "'";
                modify.Command(query);
                query = "Delete from HOADON where MAHD = '" + txtMaHD.Text + "'";
                modify.Command(query);
                frmDS_HoaDon_Load(sender, e);
                MessageBox.Show("Hủy thành công", "Thông báo!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + txtMaHD.Text + " không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    query = "Delete from CTHD where MAHD = '" + txtMaHD.Text + "'";
                    modify.Command(query);
                    query = "Delete from HOADON where MAHD = '" + txtMaHD.Text + "'";
                    modify.Command(query);
                    frmDS_HoaDon_Load(sender, e);
                    MessageBox.Show("Xóa thành công", "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void frmDS_HoaDon_Activated(object sender, EventArgs e)
        {
            dgvDSHoaDon.ClearSelection();
        }
    }
}
