using System;
using System.Data;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmDS_NhaCungCap : Form
    {
        public frmDS_NhaCungCap()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        int Index;
        bool them;
        string query;
        public void disableTextBox()
        {
            txtTenNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        public void enableTextBox()
        {
            txtTenNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }
        public void clearTextBox()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        public bool checkTextBox()
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                return false;
            else
                return true;
        }
        private string generateMANCC()
        {
            Index = Program.loadIndex(Program.filePathIndex("MaNCC.txt"));
            string newMANCC = $"NCC{Index:D4}";
            return newMANCC;
        }

        private void frmDS_NhaCungCap_Load(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked == false)
                query = "Select * from NHACUNGCAP";
            else
                query = "Select * from NHACUNGCAP where MANCC like '%" + txtTimKiem.Text + "%' or TENNCC like N'" + txtTimKiem.Text + "%'";

            DataTable tableNCC = modify.Table(query);

            dgvDSNhaCungCap.DataSource = tableNCC;

            dgvDSNhaCungCap.Columns["MANCC"].HeaderText = "Mã số";
            dgvDSNhaCungCap.Columns["MANCC"].Width = 90;
            dgvDSNhaCungCap.Columns["TENNCC"].HeaderText = "  Tên NCC";
            dgvDSNhaCungCap.Columns["TENNCC"].Width = 230;
            dgvDSNhaCungCap.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvDSNhaCungCap.Columns["DIACHI"].Width = 230;
            dgvDSNhaCungCap.Columns["DIENTHOAI"].HeaderText = "  SDT";
            dgvDSNhaCungCap.Columns["DIENTHOAI"].Width = 120;

            clearTextBox();
            disableTextBox();
            dgvDSNhaCungCap.ClearSelection();
            dgvDSNhaCungCap.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDSNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDSNhaCungCap.Rows.Count - 1 || e.RowIndex == -1)
            {
                frmDS_NhaCungCap_Load(sender, e);
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaNCC.Text = dgvDSNhaCungCap.SelectedCells[0].Value.ToString();
                txtTenNCC.Text = dgvDSNhaCungCap.SelectedCells[1].Value.ToString();
                txtDiaChi.Text = dgvDSNhaCungCap.SelectedCells[2].Value.ToString();
                txtSDT.Text = dgvDSNhaCungCap.SelectedCells[3].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            dgvDSNhaCungCap.ClearSelection();
            dgvDSNhaCungCap.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            clearTextBox();
            enableTextBox();
            txtTenNCC.Focus();
            txtMaNCC.Text = generateMANCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvDSNhaCungCap.Enabled = false;
            them = false;
            //logic
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            enableTextBox();
            txtTenNCC.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (them == false && checkTextBox())
            {
                query = "Update NHACUNGCAP Set TENNCC = N'" + txtTenNCC.Text + "', DIACHI = N'" + txtDiaChi.Text + "', DIENTHOAI = '" + txtSDT.Text + "'";
                query += " where MANCC = '" + txtMaNCC.Text + "'";
                try
                {
                    modify.Command(query);
                    frmDS_NhaCungCap_Load(sender, e);
                    MessageBox.Show("Sửa thành công", "Hệ thống");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message, "Hệ thống");
                    return;
                }
            }
            else if (them == true && checkTextBox())
            {
                query = "Insert into NHACUNGCAP values ('" + txtMaNCC.Text + "', '" + txtTenNCC.Text + "', '" + txtDiaChi.Text + "', '" + txtSDT.Text + "')";
                try
                {
                    modify.Command(query);
                    frmDS_NhaCungCap_Load(sender, e);
                    MessageBox.Show("Thêm thành công", "Hệ thống");
                    Index++;
                    Program.saveIndex(Program.filePathIndex("MaNCC.txt"), Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống");
                    return;
                }
            }
            else
                MessageBox.Show("Không thể lưu thay đổi vì thông tin không đầy đủ!", "Hệ thống");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDS_NhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + txtMaNCC.Text + " không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "Delete from NHACUNGCAP where MANCC = " + "'" + txtMaNCC.Text + "'";
                    modify.Command(query);
                    frmDS_NhaCungCap_Load(sender, e);
                    MessageBox.Show("Xóa thành công", "Thông báo!");
                }

            }
            catch
            {
                MessageBox.Show("Thông tin nhà cung cấp còn giá trị, không thể xóa lúc này!", "Hệ thống");
            }
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked)
            {
                txtTimKiem.Enabled = true;
                dgvDSNhaCungCap.DataSource = null;
                dgvDSNhaCungCap.DataSource = null;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Clear();
            }
            else
            {
                frmDS_NhaCungCap_Load(sender, e);
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Enabled = false;
            }
        }

        private void frmDS_NhaCungCap_Activated(object sender, EventArgs e)
        {
            dgvDSNhaCungCap.ClearSelection();
        }
    }
}
