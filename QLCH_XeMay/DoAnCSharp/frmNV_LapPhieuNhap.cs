using System;
using System.Data;
using System.Data.SqlClient;

namespace DoAnCSharp
{
    public partial class frmNV_LapPhieuNhap : Form
    {
        Modify modify = new Modify();
        DataTable ncc = new DataTable();
        DataTable giohang = new DataTable();
        string id, ten, sl, gianhap, thanhtien; //của hàng
        int tongtt = 0;
        string query;

        frmNV_InPhieu frmInHD;

        int IndexPN = Program.loadIndex(Program.filePathIndex("MaPN.txt"));
        int IndexNCC = Program.loadIndex(Program.filePathIndex("MaNCC.txt"));


        public frmNV_LapPhieuNhap(string manv)
        {
            InitializeComponent();
            txtMaNV.Text = manv;
        }
        private void loadHH()
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("SELECT MAHH, TENHH FROM HANGHOA", conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Tạo chuỗi hiển thị từ cột ID và Ten và phân cách bằng " - "
                            string displayValue = $"{row["MAHH"]} - {row["TENHH"]}";
                            cboTenhang.Items.Add(displayValue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void LapPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPN.Text = $"PN{IndexPN:D5}";
            loadHH();
            for (int i = 1; i <= 5; i++)
            {
                giohang.Columns.Add("column" + i.ToString(), typeof(string));
            }

            query = "Select * from NHANVIEN where MANV = " + "'" + txtMaNV.Text + "'";
            DataTable nv = modify.Table(query);
            txtTenNV.Text = nv.Rows[0]["TENNV"].ToString();

            ncc = modify.Table("select * from NHACUNGCAP");
            cboNCC.DataSource = ncc;
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.SelectedIndex = -1;

        }

        private void cboTenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã hàng hóa trong combobox

            if (cboTenhang.SelectedIndex != -1)
            {
                string selectedValue = cboTenhang.SelectedItem.ToString();

                // Tách chuỗi để lấy phần ID, parts = các phần sau khi tách.
                string[] parts = selectedValue.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                // parts[0] chứa phần ID, dùng để thực hiện truy vấn
                id = parts[0].Trim();
            }
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNCC.SelectedIndex != -1)
            {
                string selectedvalue = cboNCC.SelectedItem.ToString();

                txtMaNCC.Text = ncc.Rows[cboNCC.SelectedIndex]["MANCC"].ToString();
                txtDiaChiNCC.Text = ncc.Rows[cboNCC.SelectedIndex]["DIACHI"].ToString();
                txtSdtNCC.Text = ncc.Rows[cboNCC.SelectedIndex]["DIENTHOAI"].ToString();
            }
            else
            {
                txtMaNCC.Text = $"NCC{IndexNCC:D4}";
            }
        }

        private void cboNCC_TextChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = $"NCC{IndexNCC:D4}";
            txtDiaChiNCC.Clear();
            txtSdtNCC.Clear();
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvThongTinDonHang.Rows)
            {
                if (row.Cells["MaHang"].Value != null && row.Cells["MaHang"].Value.ToString().Equals(id))
                {
                    MessageBox.Show("Sản phẩm này đã được thêm vào phiếu nhập, vui lòng xóa nếu muốn thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (cboTenhang.Text != "" && txtThanhTien.Text.Length != 0)
            {
                string query = "Select * from HANGHOA where MAHH = " + "'" + id + "'";
                DataTable dt = modify.Table(query);
                ten = dt.Rows[0]["TENHH"].ToString();
                sl = numSL.Value.ToString();
                gianhap = txtGiaNhap.Text;
                thanhtien = txtThanhTien.Text;

                dgvThongTinDonHang.Rows.Add(id, ten, sl, gianhap, thanhtien);

                cboTenhang.SelectedIndex = -1;
                btnLuuPN.Enabled = true;
                tongtt += Convert.ToInt32(thanhtien.ToString());
                lblVND.Text = tongtt + "  VNĐ";

                giohang.Rows.Add(txtMaPN.Text, id, Convert.ToInt32(sl), gianhap, thanhtien);

                numSL.Value = 1;
                txtGiaNhap.Clear();
                txtThanhTien.Clear();
            }
            else
                return;
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text.Length > 0 && txtGiaNhap.Text[0] == '0')
            {
                txtGiaNhap.Text = txtGiaNhap.Text.Substring(1);
            }
            if (txtGiaNhap.Text != "")
                txtThanhTien.Text = (Convert.ToInt32(txtGiaNhap.Text) * numSL.Value).ToString();
        }
        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtGiaNhap.Text.Length == 1 && txtGiaNhap.Text[0] == '0' && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text != "")
                txtThanhTien.Text = (Convert.ToInt32(txtGiaNhap.Text) * numSL.Value).ToString();
        }

        private void dgvThongTinDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < giohang.Rows.Count)
            {
                // Lấy index của dòng được chọn
                int rowIndex = e.RowIndex;

                // Xác nhận việc xóa dòng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dòng khỏi DataGridView
                    int ttbora = Convert.ToInt32(dgvThongTinDonHang.Rows[rowIndex].Cells["TTien"].Value.ToString());
                    dgvThongTinDonHang.Rows.RemoveAt(rowIndex);
                    tongtt -= ttbora;
                    lblVND.Text = tongtt.ToString() + " VNĐ";

                    giohang.Rows.RemoveAt(rowIndex);

                    if (dgvThongTinDonHang.Rows.Count == 1)
                        btnLuuPN.Enabled = false;
                }
            }
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            if (txtSdtNCC.Text == "" || txtDiaChiNCC.Text == "" || cboNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin hóa đơn, không thể lưu!", "Hệ thống!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Sau khi lưu sẽ không được phép chỉnh sửa bất kì thông tin nào nữa, hãy cân nhắc trước khi lưu!", "Lưu ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                string queryNCC = "Insert into NHACUNGCAP values ('" + txtMaNCC.Text + "',N'" + cboNCC.Text + "',N'" + txtDiaChiNCC.Text + "','" + txtSdtNCC.Text + "')";
                string queryPN = "Insert into PHIEUNHAP values ('" + txtMaPN.Text + "','" + dtpNgayLap.Text + "','" + txtMaNV.Text + "','" + txtMaNCC.Text + "','" + tongtt.ToString() + "')";
                
                try
                {
                    modify.Command(queryPN);

                    //Nếu là nhà cung cấp mới thì thêm vào database và tăng chỉ số
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        string query = $"SELECT 1 FROM NHACUNGCAP WHERE MANCC = '" + txtMaNCC.Text + "'";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows == false)
                                {
                                    modify.Command(queryNCC);
                                    IndexNCC = IndexNCC + 1;
                                    Program.saveIndex(Program.filePathIndex("MaNCC.txt"), IndexNCC);
                                }
                            }
                        }
                    }

                    //Lưu lại chỉ số mã
                    IndexPN = IndexPN + 1;
                    Program.saveIndex(Program.filePathIndex("MaPN.txt"), IndexPN);
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        int slNhap;
                        string mahh;
                        conn.Open();
                        //tăng số lượng tồn
                        foreach (DataRow row in giohang.Rows)
                        {
                            slNhap = Convert.ToInt32(row["column3"]);
                            mahh = row["column2"].ToString();
                            modify.Command("Update HANGHOA set SLTON = SLTON + '" + slNhap + "'  WHERE MAHH = '" + mahh + "'");

                        }
                        Program.transmitDataToTable("CTPN", giohang, conn);
                        conn.Close();
                    }
                    //disableAll();
                    btnLuuPN.Enabled = false;
                    btnInPN.Enabled = true;
                    MessageBox.Show("Đã lưu phiếu nhập hàng", "Hệ thống");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lõi: ", ex.Message);
                    return;
                }
            }
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            frmInHD = new frmNV_InPhieu(2, txtMaPN.Text);
            frmInHD.ShowDialog();
        }
    }
}
