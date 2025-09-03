
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmDS_NhanVien : Form
    {
        int Index;
        Modify modify = new Modify();
        bool them;

        private List<DataTable> backupList = new List<DataTable>(); //Danh sách để sao lưu

        public void clearTable(string tableName, SqlConnection connection) //Xóa dữ liệu bảng
        {
            using (SqlCommand command = new SqlCommand($"DELETE FROM {tableName}", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void transmitDataToTable(string tableName, DataTable dtable, SqlConnection conn) // Truyền dữ liệu vào bảng
        {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
            {
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.WriteToServer(dtable);
            }
        }
        private string formatDate(DateTimePicker dtp) //Bị lỗi định dạng khi truyền date vào database ko biết sửa sao nên định dạng thủ công
        {
            return dtpNgaysinh.Value.Year.ToString() + "/" + dtpNgaysinh.Value.Month.ToString() + "/" + dtpNgaysinh.Value.Day.ToString();
        }
        private string generateMANV() //Hàm tạo mã nhân viên tự động với chỉ số được lưu trong file txt
        {
            Index = Program.loadIndex(Program.filePathIndex("MaNV.txt"));
            string newMANV = $"NV{Index:D3}";
            return newMANV;
        }
        public void enableTextBox()
        {
            txtHoten.Enabled = true;
            dtpNgaysinh.Enabled = true;
            cboPhai.Enabled = true;
            txtCCCD.Enabled = true;
            txtSDT.Enabled = true;
            txtChucvu.Enabled = true;
        }
        public void clear_disableTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtHoten.Text = string.Empty;
            dtpNgaysinh.Text = string.Empty;
            cboPhai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtChucvu.Text = string.Empty;

            txtHoten.Enabled = false;
            dtpNgaysinh.Enabled = false;
            cboPhai.Enabled = false;
            txtCCCD.Enabled = false;
            txtSDT.Enabled = false;
            txtChucvu.Enabled = false;
        }
        public bool checkTextBox()
        {
            if (txtMaNV.Text == "" || cboPhai.Text == "" || txtCCCD.Text == "" || txtSDT.Text == "" || txtChucvu.Text == "")
                return false;
            else
                return true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnUndo.Enabled = false;
            if (backupList.Count > 0)
                btnUndo.Enabled = true;

            //logic
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            clear_disableTextBox();
            try
            {
                dgvDSNhanVien.DataSource = modify.Table("Select * from NHANVIEN");

                dgvDSNhanVien.Columns["manv"].HeaderText = "Mã số";
                dgvDSNhanVien.Columns["manv"].Width = 80;
                dgvDSNhanVien.Columns["tennv"].HeaderText = "Họ tên";
                dgvDSNhanVien.Columns["tennv"].Width = 190;
                dgvDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgvDSNhanVien.Columns["ngaysinh"].Width = 140;
                dgvDSNhanVien.Columns["gioitinh"].HeaderText = "Phái";
                dgvDSNhanVien.Columns["gioitinh"].Width = 65;
                dgvDSNhanVien.Columns["cccd"].HeaderText = "Số CCCD";
                dgvDSNhanVien.Columns["cccd"].Width = 140;
                dgvDSNhanVien.Columns["sdt"].HeaderText = "SĐT";
                dgvDSNhanVien.Columns["chucvu"].HeaderText = "Vị trí";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgvDSNhanVien.ClearSelection();
            dgvDSNhanVien.Enabled = true;
        }

        public frmDS_NhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            //logic
            clear_disableTextBox();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            enableTextBox();
            dgvDSNhanVien.Enabled = false;
            txtHoten.Focus();
            txtMaNV.Text = generateMANV();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvDSNhanVien.Enabled = false;
            them = false;
            //logic
            btnSua.Enabled = true;
            enableTextBox();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtHoten.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e) //Xóa dòng
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + txtMaNV.Text + " không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = @"Delete from NHANVIEN where MANV = " + "'" + txtMaNV.Text + "'";
                    backupList.Add(modify.Table("Select * from NHANVIEN"));
                    modify.Command(query);
                    frmNhanVien_Load(sender, e);
                    MessageBox.Show("Xóa thành công", "Thông báo!");

                }
            }
            catch
            {
                MessageBox.Show("Thông tin nhân viên còn giá trị, không thể xóa lúc này!", "Hệ thống");
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)  //Khôi phục bảng sau thao tác Sửa và Xóa.
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn hoàn tác lại thay đổi trước đó không", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        DataTable latestDataTable = backupList[backupList.Count - 1];
                        backupList.RemoveAt(backupList.Count - 1);

                        string dropForeignKey = "ALTER TABLE PHIEUNHAP DROP CONSTRAINT FK_PHIEUNHAP_NHANVIEN;\n";
                        dropForeignKey += "ALTER TABLE HOADON DROP CONSTRAINT FK_HOADON_NHANVIEN;";

                        modify.Command(dropForeignKey);
                        clearTable("NHANVIEN", conn);
                        transmitDataToTable("NHANVIEN", latestDataTable, conn);

                        string addForeignKey = "ALTER TABLE PHIEUNHAP ADD CONSTRAINT FK_PHIEUNHAP_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);\n";
                        addForeignKey += "ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);";

                        modify.Command(addForeignKey);



                        conn.Close();
                    }
                }

                frmNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (backupList.Count < 1)
            {
                btnUndo.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)   //Thực hiện thao tác Thêm hoặc Sửa
        {
            //Thực hiện chức năng và lưu vào csdl
            if (them == true && checkTextBox())
            {
                string query = "Insert into NHANVIEN values ('" + txtMaNV.Text + "', N'" + txtHoten.Text + "', '" + formatDate(dtpNgaysinh) + "', N'" + cboPhai.Text + "', '" + txtCCCD.Text + "', '" + txtSDT.Text + "', N'" + txtChucvu.Text + "')";
                try
                {
                    backupList.Add(modify.Table("Select * from NHANVIEN"));
                    modify.Command(query);
                    frmNhanVien_Load(sender, e);
                    MessageBox.Show("Thêm thành công", "Thông báo!");
                    Index++;
                    Program.saveIndex(Program.filePathIndex("MaNV.txt"), Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                    return;
                }
            }
            else if (them == false && checkTextBox())
            {
                string query = "Update NHANVIEN Set MANV = '" + txtMaNV.Text + "', TENNV = N'" + txtHoten.Text + "', NGAYSINH = '" + formatDate(dtpNgaysinh) + "', GIOITINH = N'" + cboPhai.Text + "', CCCD = '" + txtCCCD.Text + "', SDT = '" + txtSDT.Text + "', CHUCVU = N'" + txtChucvu.Text + "'";
                query += " where MANV = '" + txtMaNV.Text + "'";
                try
                {
                    backupList.Add(modify.Table("Select * from NHANVIEN"));
                    modify.Command(query);
                    frmNhanVien_Load(sender, e);
                    MessageBox.Show("Sửa thành công", "Thông báo!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Hệ thống");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)  //Thoát khỏi thao tác thêm hoặc Sửa
        {
            frmNhanVien_Load(sender, e);
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)   //Lấy hoặc hiển thị thông tin 1 dòng datagridview
        {
            if (e.RowIndex == dgvDSNhanVien.Rows.Count - 1 || e.RowIndex == -1) //Trừ dòng tên cột và dòng trống cuối bảng
            {
                frmNhanVien_Load(sender, e);
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                txtMaNV.Text = dgvDSNhanVien.SelectedCells[0].Value.ToString();
                txtHoten.Text = dgvDSNhanVien.SelectedCells[1].Value.ToString();
                dtpNgaysinh.Text = dgvDSNhanVien.SelectedCells[2].Value.ToString();
                cboPhai.Text = dgvDSNhanVien.SelectedCells[3].Value.ToString();
                txtCCCD.Text = dgvDSNhanVien.SelectedCells[4].Value.ToString();
                txtSDT.Text = dgvDSNhanVien.SelectedCells[5].Value.ToString();
                txtChucvu.Text = dgvDSNhanVien.SelectedCells[6].Value.ToString();
            }
        }

        private void frmDS_NhanVien_Activated(object sender, EventArgs e)
        {
            dgvDSNhanVien.ClearSelection();
        }
    }
}
