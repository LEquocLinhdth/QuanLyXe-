namespace DoAnCSharp
{
    partial class frmNV_LapHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grbTTChung = new GroupBox();
            txtMaNV = new TextBox();
            txtMaKH = new TextBox();
            txtDienThoaiKH = new TextBox();
            lblMaKH = new Label();
            lblTenNV = new Label();
            txtDiaChiKH = new TextBox();
            lblSDT = new Label();
            lblMaNV = new Label();
            lblDiaChi = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgayLap = new Label();
            txtTenKH = new TextBox();
            lblTenKH = new Label();
            txtHotenNV = new TextBox();
            lblMaHD = new Label();
            txtMaHD = new TextBox();
            lblTitle = new Label();
            grbCTDonHang = new GroupBox();
            dgvThongTinDonHang = new DataGridView();
            MaHang = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            SLuong = new DataGridViewTextBoxColumn();
            DGia = new DataGridViewTextBoxColumn();
            GGia = new DataGridViewTextBoxColumn();
            TTien = new DataGridViewTextBoxColumn();
            pnlTongCong = new Panel();
            lblVND = new Label();
            label5 = new Label();
            numSL = new NumericUpDown();
            lblXoa = new Label();
            btnInHD = new Button();
            btnLuuHD = new Button();
            btnThemHH = new Button();
            numGiamGia = new NumericUpDown();
            txtDonGia = new TextBox();
            lblThanhTien = new Label();
            label16 = new Label();
            txtThanhTien = new TextBox();
            lblGiamGia = new Label();
            lblSoLuong = new Label();
            lblTenHang = new Label();
            cboTenhang = new ComboBox();
            grbTTChung.SuspendLayout();
            grbCTDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinDonHang).BeginInit();
            pnlTongCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).BeginInit();
            SuspendLayout();
            // 
            // grbTTChung
            // 
            grbTTChung.BackColor = SystemColors.Control;
            grbTTChung.BackgroundImageLayout = ImageLayout.Center;
            grbTTChung.Controls.Add(txtMaNV);
            grbTTChung.Controls.Add(txtMaKH);
            grbTTChung.Controls.Add(txtDienThoaiKH);
            grbTTChung.Controls.Add(lblMaKH);
            grbTTChung.Controls.Add(lblTenNV);
            grbTTChung.Controls.Add(txtDiaChiKH);
            grbTTChung.Controls.Add(lblSDT);
            grbTTChung.Controls.Add(lblMaNV);
            grbTTChung.Controls.Add(lblDiaChi);
            grbTTChung.Controls.Add(dtpNgayLap);
            grbTTChung.Controls.Add(lblNgayLap);
            grbTTChung.Controls.Add(txtTenKH);
            grbTTChung.Controls.Add(lblTenKH);
            grbTTChung.Controls.Add(txtHotenNV);
            grbTTChung.Controls.Add(lblMaHD);
            grbTTChung.Controls.Add(txtMaHD);
            grbTTChung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbTTChung.Location = new Point(4, 44);
            grbTTChung.Name = "grbTTChung";
            grbTTChung.Size = new Size(836, 198);
            grbTTChung.TabIndex = 0;
            grbTTChung.TabStop = false;
            grbTTChung.Text = "THÔNG TIN CHUNG";
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.ControlLightLight;
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Enabled = false;
            txtMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(143, 109);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(229, 27);
            txtMaNV.TabIndex = 0;
            txtMaNV.TabStop = false;
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = SystemColors.ControlLightLight;
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Enabled = false;
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(587, 33);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(229, 27);
            txtMaKH.TabIndex = 0;
            txtMaKH.TabStop = false;
            // 
            // txtDienThoaiKH
            // 
            txtDienThoaiKH.BackColor = SystemColors.ControlLightLight;
            txtDienThoaiKH.BorderStyle = BorderStyle.FixedSingle;
            txtDienThoaiKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDienThoaiKH.Location = new Point(587, 147);
            txtDienThoaiKH.Name = "txtDienThoaiKH";
            txtDienThoaiKH.Size = new Size(229, 27);
            txtDienThoaiKH.TabIndex = 2;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKH.ForeColor = Color.Blue;
            lblMaKH.Location = new Point(456, 36);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(109, 20);
            lblMaKH.TabIndex = 32;
            lblMaKH.Text = "Mã khách hàng";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNV.ForeColor = Color.Blue;
            lblTenNV.Location = new Point(20, 150);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(99, 20);
            lblTenNV.TabIndex = 23;
            lblTenNV.Text = "Tên nhân viên";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.BackColor = SystemColors.ControlLightLight;
            txtDiaChiKH.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChiKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiKH.Location = new Point(587, 109);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(229, 27);
            txtDiaChiKH.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.Blue;
            lblSDT.Location = new Point(456, 150);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 26;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNV.ForeColor = Color.Blue;
            lblMaNV.Location = new Point(20, 112);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(97, 20);
            lblMaNV.TabIndex = 21;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = Color.Blue;
            lblDiaChi.Location = new Point(456, 112);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 29;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(143, 71);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(228, 27);
            dtpNgayLap.TabIndex = 0;
            dtpNgayLap.TabStop = false;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayLap.ForeColor = Color.Blue;
            lblNgayLap.Location = new Point(20, 74);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(69, 20);
            lblNgayLap.TabIndex = 19;
            lblNgayLap.Text = "Ngày lập";
            // 
            // txtTenKH
            // 
            txtTenKH.BackColor = SystemColors.ControlLightLight;
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKH.Location = new Point(587, 71);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(229, 27);
            txtTenKH.TabIndex = 0;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKH.ForeColor = Color.Blue;
            lblTenKH.Location = new Point(456, 74);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(111, 20);
            lblTenKH.TabIndex = 31;
            lblTenKH.Text = "Tên khách hàng";
            // 
            // txtHotenNV
            // 
            txtHotenNV.BackColor = SystemColors.ControlLightLight;
            txtHotenNV.BorderStyle = BorderStyle.FixedSingle;
            txtHotenNV.Enabled = false;
            txtHotenNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHotenNV.Location = new Point(143, 147);
            txtHotenNV.Name = "txtHotenNV";
            txtHotenNV.Size = new Size(229, 27);
            txtHotenNV.TabIndex = 20;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHD.ForeColor = Color.Blue;
            lblMaHD.Location = new Point(20, 36);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(89, 20);
            lblMaHD.TabIndex = 17;
            lblMaHD.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            txtMaHD.BackColor = SystemColors.ControlLightLight;
            txtMaHD.BorderStyle = BorderStyle.FixedSingle;
            txtMaHD.Enabled = false;
            txtMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHD.Location = new Point(143, 33);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(229, 27);
            txtMaHD.TabIndex = 0;
            txtMaHD.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.OrangeRed;
            lblTitle.Location = new Point(327, -3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 33);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "LẬP HÓA ĐƠN";
            // 
            // grbCTDonHang
            // 
            grbCTDonHang.BackColor = SystemColors.Control;
            grbCTDonHang.Controls.Add(dgvThongTinDonHang);
            grbCTDonHang.Controls.Add(pnlTongCong);
            grbCTDonHang.Controls.Add(numSL);
            grbCTDonHang.Controls.Add(lblXoa);
            grbCTDonHang.Controls.Add(btnInHD);
            grbCTDonHang.Controls.Add(btnLuuHD);
            grbCTDonHang.Controls.Add(btnThemHH);
            grbCTDonHang.Controls.Add(numGiamGia);
            grbCTDonHang.Controls.Add(txtDonGia);
            grbCTDonHang.Controls.Add(lblThanhTien);
            grbCTDonHang.Controls.Add(label16);
            grbCTDonHang.Controls.Add(txtThanhTien);
            grbCTDonHang.Controls.Add(lblGiamGia);
            grbCTDonHang.Controls.Add(lblSoLuong);
            grbCTDonHang.Controls.Add(lblTenHang);
            grbCTDonHang.Controls.Add(cboTenhang);
            grbCTDonHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbCTDonHang.Location = new Point(4, 250);
            grbCTDonHang.Name = "grbCTDonHang";
            grbCTDonHang.Size = new Size(836, 391);
            grbCTDonHang.TabIndex = 1;
            grbCTDonHang.TabStop = false;
            grbCTDonHang.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // dgvThongTinDonHang
            // 
            dgvThongTinDonHang.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThongTinDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongTinDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinDonHang.Columns.AddRange(new DataGridViewColumn[] { MaHang, TenHang, SLuong, DGia, GGia, TTien });
            dgvThongTinDonHang.Location = new Point(20, 111);
            dgvThongTinDonHang.Name = "dgvThongTinDonHang";
            dgvThongTinDonHang.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThongTinDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThongTinDonHang.RowHeadersVisible = false;
            dgvThongTinDonHang.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongTinDonHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvThongTinDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongTinDonHang.Size = new Size(796, 202);
            dgvThongTinDonHang.TabIndex = 51;
            dgvThongTinDonHang.CellDoubleClick += dgvThongTinDonHang_CellDoubleClick;
            // 
            // MaHang
            // 
            MaHang.HeaderText = "Mã";
            MaHang.MinimumWidth = 6;
            MaHang.Name = "MaHang";
            MaHang.ReadOnly = true;
            MaHang.Width = 90;
            // 
            // TenHang
            // 
            TenHang.HeaderText = "Tên hàng";
            TenHang.MinimumWidth = 6;
            TenHang.Name = "TenHang";
            TenHang.ReadOnly = true;
            TenHang.Width = 300;
            // 
            // SLuong
            // 
            SLuong.HeaderText = "Số lượng";
            SLuong.MinimumWidth = 6;
            SLuong.Name = "SLuong";
            SLuong.ReadOnly = true;
            SLuong.Width = 125;
            // 
            // DGia
            // 
            DGia.HeaderText = "Đơn giá";
            DGia.MinimumWidth = 6;
            DGia.Name = "DGia";
            DGia.ReadOnly = true;
            DGia.Width = 125;
            // 
            // GGia
            // 
            GGia.HeaderText = "Giảm(%)";
            GGia.MinimumWidth = 6;
            GGia.Name = "GGia";
            GGia.ReadOnly = true;
            GGia.Width = 90;
            // 
            // TTien
            // 
            TTien.HeaderText = "Thành tiền";
            TTien.MinimumWidth = 6;
            TTien.Name = "TTien";
            TTien.ReadOnly = true;
            TTien.Width = 113;
            // 
            // pnlTongCong
            // 
            pnlTongCong.BackColor = SystemColors.Info;
            pnlTongCong.BorderStyle = BorderStyle.FixedSingle;
            pnlTongCong.Controls.Add(lblVND);
            pnlTongCong.Controls.Add(label5);
            pnlTongCong.Location = new Point(479, 320);
            pnlTongCong.Name = "pnlTongCong";
            pnlTongCong.Size = new Size(337, 54);
            pnlTongCong.TabIndex = 50;
            // 
            // lblVND
            // 
            lblVND.AutoSize = true;
            lblVND.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblVND.ForeColor = Color.FromArgb(192, 0, 0);
            lblVND.Location = new Point(156, 14);
            lblVND.Name = "lblVND";
            lblVND.Size = new Size(62, 23);
            lblVND.TabIndex = 46;
            lblVND.Text = "0 VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(38, 16);
            label5.Name = "label5";
            label5.Size = new Size(95, 19);
            label5.TabIndex = 45;
            label5.Text = "Tổng Cộng:";
            // 
            // numSL
            // 
            numSL.BackColor = SystemColors.ControlLightLight;
            numSL.BorderStyle = BorderStyle.FixedSingle;
            numSL.Location = new Point(95, 69);
            numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSL.Name = "numSL";
            numSL.Size = new Size(162, 27);
            numSL.TabIndex = 5;
            numSL.TextAlign = HorizontalAlignment.Center;
            numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSL.ValueChanged += numSL_ValueChanged;
            // 
            // lblXoa
            // 
            lblXoa.AutoSize = true;
            lblXoa.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblXoa.ForeColor = Color.FromArgb(192, 0, 0);
            lblXoa.Location = new Point(17, 360);
            lblXoa.Name = "lblXoa";
            lblXoa.Size = new Size(210, 18);
            lblXoa.TabIndex = 47;
            lblXoa.Text = "Nháy đúp chuột vào dòng để xóa";
            // 
            // btnInHD
            // 
            btnInHD.BackgroundImageLayout = ImageLayout.Zoom;
            btnInHD.Enabled = false;
            btnInHD.FlatStyle = FlatStyle.Flat;
            btnInHD.Image = Properties.Resources.printerbill1;
            btnInHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnInHD.Location = new Point(324, 320);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(134, 33);
            btnInHD.TabIndex = 8;
            btnInHD.Text = "In hóa đơn";
            btnInHD.TextAlign = ContentAlignment.MiddleRight;
            btnInHD.UseVisualStyleBackColor = true;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnLuuHD
            // 
            btnLuuHD.BackgroundImageLayout = ImageLayout.Zoom;
            btnLuuHD.Enabled = false;
            btnLuuHD.FlatStyle = FlatStyle.Flat;
            btnLuuHD.Image = Properties.Resources.savebill;
            btnLuuHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuHD.Location = new Point(163, 320);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(140, 33);
            btnLuuHD.TabIndex = 7;
            btnLuuHD.Text = "Lưu hóa đơn";
            btnLuuHD.TextAlign = ContentAlignment.MiddleRight;
            btnLuuHD.UseVisualStyleBackColor = true;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // btnThemHH
            // 
            btnThemHH.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemHH.Enabled = false;
            btnThemHH.FlatStyle = FlatStyle.Flat;
            btnThemHH.Image = Properties.Resources.addtocart1;
            btnThemHH.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHH.Location = new Point(20, 320);
            btnThemHH.Name = "btnThemHH";
            btnThemHH.Size = new Size(122, 33);
            btnThemHH.TabIndex = 6;
            btnThemHH.Text = "Thêm vào";
            btnThemHH.TextAlign = ContentAlignment.MiddleRight;
            btnThemHH.UseVisualStyleBackColor = true;
            btnThemHH.Click += btnThemHH_Click;
            // 
            // numGiamGia
            // 
            numGiamGia.BackColor = SystemColors.ControlLightLight;
            numGiamGia.BorderStyle = BorderStyle.FixedSingle;
            numGiamGia.Location = new Point(654, 32);
            numGiamGia.Name = "numGiamGia";
            numGiamGia.Size = new Size(162, 27);
            numGiamGia.TabIndex = 4;
            numGiamGia.TextAlign = HorizontalAlignment.Center;
            numGiamGia.ValueChanged += numGiamGia_ValueChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.BackColor = SystemColors.ControlLightLight;
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Enabled = false;
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(371, 70);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(162, 27);
            txtDonGia.TabIndex = 0;
            txtDonGia.TabStop = false;
            txtDonGia.TextAlign = HorizontalAlignment.Center;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.Blue;
            lblThanhTien.Location = new Point(570, 72);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(78, 20);
            lblThanhTien.TabIndex = 35;
            lblThanhTien.Text = "Thành tiền";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(303, 71);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 34;
            label16.Text = "Đơn giá";
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = SystemColors.ControlLightLight;
            txtThanhTien.BorderStyle = BorderStyle.FixedSingle;
            txtThanhTien.Enabled = false;
            txtThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.Location = new Point(654, 69);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(162, 27);
            txtThanhTien.TabIndex = 0;
            txtThanhTien.TabStop = false;
            txtThanhTien.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiamGia.ForeColor = Color.Blue;
            lblGiamGia.Location = new Point(570, 34);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(70, 20);
            lblGiamGia.TabIndex = 31;
            lblGiamGia.Text = "(%) Giảm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.Blue;
            lblSoLuong.Location = new Point(20, 72);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(69, 20);
            lblSoLuong.TabIndex = 27;
            lblSoLuong.Text = "Số lượng";
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenHang.ForeColor = Color.Blue;
            lblTenHang.Location = new Point(20, 34);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(69, 20);
            lblTenHang.TabIndex = 26;
            lblTenHang.Text = "Tên hàng";
            // 
            // cboTenhang
            // 
            cboTenhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenhang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenhang.BackColor = SystemColors.ControlLightLight;
            cboTenhang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTenhang.ForeColor = Color.Black;
            cboTenhang.FormattingEnabled = true;
            cboTenhang.Location = new Point(95, 31);
            cboTenhang.Name = "cboTenhang";
            cboTenhang.Size = new Size(438, 28);
            cboTenhang.TabIndex = 3;
            cboTenhang.SelectedIndexChanged += cboTenhang_SelectedIndexChanged;
            // 
            // frmNV_LapHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(844, 644);
            Controls.Add(grbCTDonHang);
            Controls.Add(lblTitle);
            Controls.Add(grbTTChung);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNV_LapHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmNV_LapHoaDon_Load;
            grbTTChung.ResumeLayout(false);
            grbTTChung.PerformLayout();
            grbCTDonHang.ResumeLayout(false);
            grbCTDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinDonHang).EndInit();
            pnlTongCong.ResumeLayout(false);
            pnlTongCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbTTChung;
        private TextBox txtDienThoaiKH;
        private Label lblMaKH;
        private Label lblTenNV;
        private TextBox txtDiaChiKH;
        private Label lblSDT;
        private Label lblMaNV;
        private Label lblDiaChi;
        private DateTimePicker dtpNgayLap;
        private Label lblNgayLap;
        private TextBox txtTenKH;
        private Label lblTenKH;
        private TextBox txtHotenNV;
        private Label lblMaHD;
        private TextBox txtMaHD;
        private Label lblTitle;
        private TextBox txtMaKH;
        private TextBox txtMaNV;
        private GroupBox grbCTDonHang;
        private DataGridView dgvThongTinDonHang;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SLuong;
        private DataGridViewTextBoxColumn DGia;
        private DataGridViewTextBoxColumn GGia;
        private DataGridViewTextBoxColumn TTien;
        private Panel pnlTongCong;
        private Label lblVND;
        private Label label5;
        private NumericUpDown numSL;
        private Label lblXoa;
        private Button btnInHD;
        private Button btnLuuHD;
        private Button btnThemHH;
        private NumericUpDown numGiamGia;
        private TextBox txtDonGia;
        private Label lblThanhTien;
        private Label label16;
        private TextBox txtThanhTien;
        private Label lblGiamGia;
        private Label lblSoLuong;
        private Label lblTenHang;
        private ComboBox cboTenhang;
    }
}