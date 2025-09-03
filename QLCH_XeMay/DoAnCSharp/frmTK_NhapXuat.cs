using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;



namespace DoAnCSharp
{
    public partial class frmTK_NhapXuat : Form
    {
        public frmTK_NhapXuat()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        DataTable dataTable;

        string mahh;
        int month, year;
        int doanhthu = 0;
        string product, productbytype, query;

        public void clearTextBox()
        {
            txtMaHH.Clear();
            txtTenHH.Clear();
            txtLoaiHH.Clear();
            txtHangSX.Clear();
            txtGiaBan.Clear();
            txtSLTON.Clear();
        }

        private void frmTK_NhapXuat_Load(object sender, EventArgs e)
        {
            cboLoai.SelectedIndex = 0;
            numThang.Value = DateTime.Now.Month;
            numNam.Value = DateTime.Now.Year;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            month = ((int)numThang.Value);
            year = ((int)numNam.Value);
            if (tabThongKe.SelectedIndex == 0)
            {
                rdoNhap.Enabled = false;
                rdoXuat.Enabled = false;
                numNam.Enabled = false;
                numThang.Enabled = false;
                cboLoai.Enabled = false;
                //tab 1
                string type;
                dataTable = new DataTable();

                DataColumn sttColumn = new DataColumn("STT", typeof(int));
                dataTable.Columns.Add(sttColumn);
                dataTable.Columns["STT"].SetOrdinal(0);

                if (rdoXuat.Checked)
                {
                    product = "GetSellingProducts";
                    productbytype = "GetSellingProductsByType";
                    if (cboLoai.SelectedIndex == 1)
                    {
                        type = "XE";
                        gbHangHoaBanRa.Text = "Xe máy bán ra trong " + month + "/" + year;
                    }
                    else
                    {
                        type = "PT";
                        gbHangHoaBanRa.Text = "Phụ tùng bán ra trong " + month + "/" + year;
                    }
                }
                else
                {
                    product = "GetImportedProducts";
                    productbytype = "GetImportedProductsByType";
                    if (cboLoai.SelectedIndex == 1)
                    {
                        type = "XE";
                        gbHangHoaBanRa.Text = "Xe máy nhập hàng trong " + month + "/" + year;
                    }
                    else
                    {
                        type = "PT";
                        gbHangHoaBanRa.Text = "Phụ tùng nhập hàng trong " + month + "/" + year;
                    }
                }
                if (cboLoai.SelectedIndex == 0)
                {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        using (SqlCommand command = new SqlCommand(product, conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            // Thêm tham số vào stored procedure
                            command.Parameters.AddWithValue("@Month", month);
                            command.Parameters.AddWithValue("@Year", year);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);

                                // Hiển thị dữ liệu trên DataGridView
                                dgvNhapXuat.DataSource = dataTable;
                            }
                        }
                    }
                    if (rdoXuat.Checked)
                        gbHangHoaBanRa.Text = "Hàng hóa bán ra trong " + month + "/" + year;
                    else
                        gbHangHoaBanRa.Text = "Hàng hóa nhập vào trong " + month + "/" + year;

                }
                else
                {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        using (SqlCommand command = new SqlCommand(productbytype, conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            // Thêm tham số vào stored procedure
                            command.Parameters.AddWithValue("@Month", month);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@ProductType", type);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);

                                // Hiển thị dữ liệu trên DataGridView
                                dgvNhapXuat.DataSource = dataTable;
                            }
                        }
                    }
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["STT"] = i + 1;
                }

                dgvNhapXuat.Columns["STT"].HeaderText = "STT";
                dgvNhapXuat.Columns["STT"].Width = 50;
                dgvNhapXuat.Columns[1].HeaderText = "Mã hàng";
                dgvNhapXuat.Columns[1].Width = 100;
                dgvNhapXuat.Columns[2].HeaderText = "   Tên hàng";
                dgvNhapXuat.Columns[2].Width = 360;
                if (rdoNhap.Checked)
                {
                    dgvNhapXuat.Columns["SOLUONGNHAP"].HeaderText = "SL nhập vào";
                    dgvNhapXuat.Columns["SOLUONGNHAP"].Width = 110;
                }
                else
                {
                    dgvNhapXuat.Columns["SOLUONGBAN"].HeaderText = "SL bán ra";
                    dgvNhapXuat.Columns["SOLUONGBAN"].Width = 110;
                }

                btnThongKe.Enabled = false;
                btnChonLai.Enabled = true;
                btnXuatExcel.Enabled = true;
            }
            //tab 2
            else
            {
                lblThangNam.Text = month + "/" + year;
                rdoNhap.Enabled = false;
                rdoXuat.Enabled = false;
                numNam.Enabled = false;
                numThang.Enabled = false;

                query = "select * from HOADON where MONTH(NGAYLAP) = " + month + " AND YEAR(NGAYLAP) = '" + year + "'";

                DataTable tableHD = modify.Table(query);

                DataColumn sttColumn = new DataColumn("STT", typeof(int));
                tableHD.Columns.Add(sttColumn);
                tableHD.Columns["STT"].SetOrdinal(0);

                for (int i = 0; i < tableHD.Rows.Count; i++)
                {
                    tableHD.Rows[i]["STT"] = i + 1;
                }

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
                dgvHoaDon.ClearSelection();

                foreach (DataRow row in tableHD.Rows)
                {
                    doanhthu += Convert.ToInt32(row[5].ToString());
                }
                lblDoanhThu.Text = doanhthu.ToString() + " VNĐ";

                query = $"SELECT SUM(TONGTT) FROM PHIEUNHAP WHERE MONTH(NgayLap) = {month} AND YEAR(NgayLap) = {year}";
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Thực thi câu lệnh SQL và nhận kết quả
                        object result = command.ExecuteScalar();

                        if (result.ToString() != "")
                            lblTienNhap.Text = result.ToString() + " vnđ";
                        else
                            lblTienNhap.Text = "Không nhập hàng!";
                    }
                }
                btnThongKe.Enabled = false;
                btnChonLai.Enabled = true;
                btnXuatExcel.Enabled = true;

            }
        }

        private void btnChonLai_Click(object sender, EventArgs e)
        {
            doanhthu = 0;
            btnChonLai.Enabled = false;
            btnThongKe.Enabled = true;
            btnXuatExcel.Enabled = false;
            dgvNhapXuat.DataSource = null;
            gbHangHoaBanRa.Text = "Hàng hóa bán ra";
            rdoNhap.Enabled = true;
            rdoXuat.Enabled = true;
            numNam.Enabled = true;
            numThang.Enabled = true;
            if (tabThongKe.SelectedIndex == 0)
                cboLoai.Enabled = true;
            else
                cboLoai.Enabled = false;
        }

        private void dgvNhapXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex == dgvNhapXuat.Rows.Count - 1 && e.RowIndex != -1) || e.RowIndex == -1)
            {
                clearTextBox();
                dgvNhapXuat.ClearSelection();
                return;
            }
            mahh = dgvNhapXuat.SelectedCells[1].Value.ToString();
            string query = "Select * from HANGHOA where MAHH = " + "'" + mahh + "'";
            DataTable dt = modify.Table(query);
            txtMaHH.Text = dt.Rows[0]["MAHH"].ToString();
            txtTenHH.Text = dt.Rows[0]["TENHH"].ToString();
            txtLoaiHH.Text = dt.Rows[0]["LOAIHH"].ToString();
            txtHangSX.Text = dt.Rows[0]["HANGSX"].ToString();
            txtGiaBan.Text = dt.Rows[0]["GIABAN"].ToString();
            txtSLTON.Text = dt.Rows[0]["SLTON"].ToString();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    worksheet.Cells["A1"].Value = gbHangHoaBanRa.Text;

                    // Xuất cột tiêu đề
                    for (int i = 1; i <= dgvNhapXuat.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i].Value = dgvNhapXuat.Columns[i - 1].HeaderText;
                    }

                    // Xuất dữ liệu từ DataGridView
                    for (int row = 0; row < dgvNhapXuat.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvNhapXuat.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 3, col + 1].Value = dgvNhapXuat.Rows[row].Cells[col].Value;
                            worksheet.Cells[row + 2, col + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Căn giữa dữ liệu
                        }
                    }
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Chọn nơi lưu tệp Excel";
                        saveFileDialog.FileName = "YourExcelFile.xlsx"; // Tên mặc định

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Lưu file Excel theo đường dẫn đã chọn
                            FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(excelFile);
                            MessageBox.Show("Xuất Excel thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}");
            }
        }

        private void tabThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabThongKe.SelectedIndex == 1)
            {
                rdoNhap.Visible = false;
                rdoXuat.Visible = false;
                cboLoai.SelectedIndex = 0;
                cboLoai.Enabled = false;
            }
            else
            {
                cboLoai.Enabled = true;
                rdoNhap.Visible = true;
                rdoXuat.Visible = true;

            }
        }
    }
}
