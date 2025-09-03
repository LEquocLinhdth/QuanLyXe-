
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmNV_LapHoaDon : Form
    {
        DataTable giohang = new DataTable();
        string id, ten, sl, dongia, giam, thanhtien;
        int tongtt = 0;
        frmNV_InPhieu frmInHD;
        Modify modify = new Modify();
        int IndexHD = Program.loadIndex(Program.filePathIndex("MaHD.txt"));
        int IndexKH = Program.loadIndex(Program.filePathIndex("MaKH.txt"));

        public frmNV_LapHoaDon(string manv)
        {
            InitializeComponent();
            txtMaNV.Text = manv;
        }

        private void disableAll()
        {
            txtMaNV.Enabled = false;
            txtTenKH.Enabled = false;
            txtDienThoaiKH.Enabled = false;
            txtDiaChiKH.Enabled = false;
            cboTenhang.Enabled = false;
            btnThemHH.Enabled = false;
            btnLuuHD.Enabled = false;
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

        private void frmNV_LapHoaDon_Load(object sender, EventArgs e)                               ///////////FORM LOAD///////////
        {
            dgvThongTinDonHang.Columns["MaHang"].Width = 90;
            dgvThongTinDonHang.Columns["TenHang"].Width = 302;
            dgvThongTinDonHang.Columns["SLuong"].Width = 98;
            dgvThongTinDonHang.Columns["DGia"].Width = 100;
            dgvThongTinDonHang.Columns["GGia"].Width = 90;
            dgvThongTinDonHang.Columns["TTien"].Width = 113;

            txtMaHD.Text = $"HD{IndexHD:D5}";
            txtMaKH.Text = $"KH{IndexKH:D5}";

            loadHH();
            for (int i = 1; i <= 6; i++)
            {
                giohang.Columns.Add("column" + i.ToString(), typeof(string));
            }

            string query = "Select * from NHANVIEN where MANV = " + "'" + txtMaNV.Text + "'";
            DataTable dt = modify.Table(query);
            txtHotenNV.Text = dt.Rows[0]["TENNV"].ToString();
        }



        private void cboTenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThemHH.Enabled = true;
            numGiamGia.Value = 0;
            numSL.Value = 1;
            // Lấy mục được chọn trong ComboBox

            if (cboTenhang.SelectedIndex != -1)
            {
                string selectedValue = cboTenhang.SelectedItem.ToString();

                // Tách chuỗi để lấy phần ID, parts = các phần sau khi tách.
                string[] parts = selectedValue.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                // parts[0] chứa phần ID, dùng để thực hiện truy vấn
                id = parts[0].Trim();

                if (cboTenhang.Text != "")
                {
                    string query = "Select * from HANGHOA where MAHH = " + "'" + id + "'";
                    DataTable dt = modify.Table(query);
                    txtDonGia.Text = dt.Rows[0]["GIABAN"].ToString();
                    txtThanhTien.Text = (numSL.Value * Convert.ToInt32(txtDonGia.Text)).ToString();
                }
            }
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvThongTinDonHang.Rows)
            {
                if (row.Cells["MaHang"].Value != null && row.Cells["MaHang"].Value.ToString().Equals(id))
                {
                    MessageBox.Show("Sản phẩm này đã được thêm vào hóa đơn, vui lòng xóa nếu muốn thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (cboTenhang.Text != "")
            {
                string query = "Select * from HANGHOA where MAHH = " + "'" + id + "'";
                DataTable dt = modify.Table(query);
                ten = dt.Rows[0]["TENHH"].ToString();
                sl = numSL.Value.ToString();
                int slTon = Convert.ToInt32(dt.Rows[0]["SLTON"].ToString());
                if (slTon < Convert.ToUInt32(sl))
                {
                    MessageBox.Show("Số lượng không đủ, số lượng còn lại của mặt hàng là: " + slTon);
                    return;
                }
                dongia = txtDonGia.Text;
                giam = numGiamGia.Value.ToString();
                thanhtien = txtThanhTien.Text;

                dgvThongTinDonHang.Rows.Add(id, ten, sl, dongia, giam, thanhtien);

                cboTenhang.SelectedIndex = -1;
                btnLuuHD.Enabled = true;
                btnThemHH.Enabled = false;
                tongtt += Convert.ToInt32(thanhtien.ToString());
                lblVND.Text = tongtt + "  VNĐ";

                giohang.Rows.Add(txtMaHD.Text, id, Convert.ToInt32(sl), dongia, Convert.ToInt32(giam), thanhtien);

                txtDonGia.Clear();
                txtThanhTien.Clear();
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (txtHotenNV.Text == "" || txtTenKH.Text == "" || txtDienThoaiKH.Text == "" || txtDiaChiKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin hóa đơn, không thể lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Sau khi lưu sẽ không được phép chỉnh sửa bất kì thông tin nào nữa, hãy cân nhắc trước khi lưu!", "Lưu ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                string queryHD;
                string queryKH;
                try
                {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {

                        conn.Open();
                        //Kiểm tra khách hàng mới hay cũ
                        string queryCheck = "SELECT MAKH FROM KHACHHANG WHERE DIENTHOAI = '"+txtDienThoaiKH.Text+"'";
                        using (SqlCommand command = new SqlCommand(queryCheck, conn))
                        {
                            object check = command.ExecuteScalar();

                            if (check != null)
                            {
                                if (MessageBox.Show("Số điện thoại khách hàng đã tồn tại, bạn có muốn thay thế thông tin cũ của khách hàng không?","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    queryKH = "Update KHACHHANG set TenKH = N'" + txtTenKH.Text + "', DIACHI = N'" + txtDiaChiKH.Text + "', DIENTHOAI = '" + txtDienThoaiKH.Text + "'";
                                    queryKH += " where MAKH = '"+txtMaKH.Text+"'";
                                    modify.Command(queryKH);
                                    queryHD = "Insert into HOADON values ('" + txtMaHD.Text + "','" + dtpNgayLap.Text + "','" + txtMaNV.Text + "','" + check.ToString() + "','" + tongtt.ToString() + "')";
                                    modify.Command(queryHD);
                                }    
                                else
                                {
                                    queryHD = "Insert into HOADON values ('" + txtMaHD.Text + "','" + dtpNgayLap.Text + "','" + txtMaNV.Text + "','" + check.ToString() + "','" + tongtt.ToString() + "')";
                                    modify.Command(queryHD);
                                }    
                            }
                            else
                            {
                                queryKH = "Insert into KHACHHANG values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "','" + txtDienThoaiKH.Text + "')";
                                modify.Command(queryKH);
                                IndexKH = IndexKH + 1;
                                Program.saveIndex(Program.filePathIndex("MaKH.txt"), IndexKH);

                                queryHD = "Insert into HOADON values ('" + txtMaHD.Text + "','" + dtpNgayLap.Text + "','" + txtMaNV.Text + "','" + txtMaKH.Text + "','" + tongtt.ToString() + "')";
                                modify.Command (queryHD);

                            }    
                        }
                        int slBan;
                        string mahh;
                        //Giảm số lượng tồn
                        foreach (DataRow row in giohang.Rows)
                        {
                            slBan = Convert.ToInt32(row["column3"]);
                            mahh = row["column2"].ToString();
                            modify.Command("Update HANGHOA set SLTON = SLTON - '" + slBan + "'  WHERE MAHH = '" + mahh + "'");

                        }
                        Program.transmitDataToTable("CTHD", giohang, conn); //Thêm CTHD
                        conn.Close();
                    }

                    //Lưu lại chỉ số mã

                    IndexHD = IndexHD + 1;
                    Program.saveIndex(Program.filePathIndex("MaHD.txt"), IndexHD);


                    disableAll();
                    btnInHD.Enabled = true;
                    MessageBox.Show("Đã lưu hóa đơn", "Hệ thống");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lõi: ", ex.Message);
                    return;
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmInHD = new frmNV_InPhieu(1, txtMaHD.Text);
            frmInHD.ShowDialog();
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
                txtThanhTien.Text = (numSL.Value * Convert.ToInt32(txtDonGia.Text)).ToString();
        }

        private void numGiamGia_ValueChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
                txtThanhTien.Text = Convert.ToInt32((numSL.Value * Convert.ToInt32(txtDonGia.Text)) * ((100 - numGiamGia.Value) / 100)).ToString();
        }

        private void dgvThongTinDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < giohang.Rows.Count)
            {
                // Lấy index của dòng được chọn
                int rowIndex = e.RowIndex;

                // Xác nhận việc xóa dòng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dòng khỏi DataGridView
                    int ttbora = Convert.ToInt32(dgvThongTinDonHang.Rows[rowIndex].Cells["TTien"].Value.ToString());
                    dgvThongTinDonHang.Rows.RemoveAt(rowIndex);
                    tongtt -= ttbora;
                    lblVND.Text = tongtt.ToString() + " VNĐ";

                    giohang.Rows.RemoveAt(rowIndex);
                    if (dgvThongTinDonHang.Rows.Count == 1)
                        btnLuuHD.Enabled = false;
                }
            }
        }
    }
}
