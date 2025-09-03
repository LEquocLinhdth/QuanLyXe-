namespace DoAnCSharp
{
    partial class frmNV_LapPhieuNhap
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
            btnInPN = new Button();
            btnLuuPN = new Button();
            btnThemHH = new Button();
            lblSoLuong = new Label();
            lblXoa = new Label();
            panel1 = new Panel();
            lblVND = new Label();
            label5 = new Label();
            cboTenhang = new ComboBox();
            grbTTChung = new GroupBox();
            txtMaNV = new TextBox();
            cboNCC = new ComboBox();
            txtMaNCC = new TextBox();
            lblTenNCC = new Label();
            txtSdtNCC = new TextBox();
            lblMaNCC = new Label();
            lblTenNV = new Label();
            txtDiaChiNCC = new TextBox();
            lblSDT = new Label();
            lblMaNV = new Label();
            lblDiaChi = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgayLap = new Label();
            txtTenNV = new TextBox();
            lblMaPN = new Label();
            txtMaPN = new TextBox();
            grbCTDonHang = new GroupBox();
            lblLuuY = new Label();
            numSL = new NumericUpDown();
            txtGiaNhap = new TextBox();
            lblThanhTien = new Label();
            lblDonGia = new Label();
            txtThanhTien = new TextBox();
            lblTenHang = new Label();
            dgvThongTinDonHang = new DataGridView();
            MaHang = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            SLuong = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            TTien = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            panel1.SuspendLayout();
            grbTTChung.SuspendLayout();
            grbCTDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinDonHang).BeginInit();
            SuspendLayout();
            // 
            // btnInPN
            // 
            btnInPN.BackgroundImageLayout = ImageLayout.Zoom;
            btnInPN.Enabled = false;
            btnInPN.FlatStyle = FlatStyle.Flat;
            btnInPN.Image = Properties.Resources.printerbill1;
            btnInPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnInPN.Location = new Point(311, 348);
            btnInPN.Name = "btnInPN";
            btnInPN.Size = new Size(147, 33);
            btnInPN.TabIndex = 8;
            btnInPN.Text = "In phiếu nhập";
            btnInPN.TextAlign = ContentAlignment.MiddleRight;
            btnInPN.UseVisualStyleBackColor = true;
            btnInPN.Click += btnInPN_Click;
            // 
            // btnLuuPN
            // 
            btnLuuPN.BackgroundImageLayout = ImageLayout.Zoom;
            btnLuuPN.Enabled = false;
            btnLuuPN.FlatStyle = FlatStyle.Flat;
            btnLuuPN.Image = Properties.Resources.savebill;
            btnLuuPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuPN.Location = new Point(163, 348);
            btnLuuPN.Name = "btnLuuPN";
            btnLuuPN.Size = new Size(127, 33);
            btnLuuPN.TabIndex = 7;
            btnLuuPN.Text = "Lưu phiếu";
            btnLuuPN.TextAlign = ContentAlignment.MiddleRight;
            btnLuuPN.UseVisualStyleBackColor = true;
            btnLuuPN.Click += btnLuuPN_Click;
            // 
            // btnThemHH
            // 
            btnThemHH.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemHH.FlatStyle = FlatStyle.Flat;
            btnThemHH.Image = Properties.Resources.addtocart1;
            btnThemHH.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHH.Location = new Point(20, 348);
            btnThemHH.Name = "btnThemHH";
            btnThemHH.Size = new Size(122, 33);
            btnThemHH.TabIndex = 6;
            btnThemHH.Text = "Thêm vào";
            btnThemHH.TextAlign = ContentAlignment.MiddleRight;
            btnThemHH.UseVisualStyleBackColor = true;
            btnThemHH.Click += btnThemHH_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.Blue;
            lblSoLuong.Location = new Point(20, 68);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(61, 20);
            lblSoLuong.TabIndex = 27;
            lblSoLuong.Text = "SL nhập";
            // 
            // lblXoa
            // 
            lblXoa.AutoSize = true;
            lblXoa.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblXoa.ForeColor = Color.FromArgb(192, 0, 0);
            lblXoa.Location = new Point(17, 388);
            lblXoa.Name = "lblXoa";
            lblXoa.Size = new Size(210, 18);
            lblXoa.TabIndex = 47;
            lblXoa.Text = "Nháy đúp chuột vào dòng để xóa";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblVND);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(479, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 54);
            panel1.TabIndex = 50;
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
            // cboTenhang
            // 
            cboTenhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenhang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenhang.BackColor = SystemColors.ControlLightLight;
            cboTenhang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTenhang.ForeColor = Color.Black;
            cboTenhang.FormattingEnabled = true;
            cboTenhang.Location = new Point(95, 29);
            cboTenhang.Name = "cboTenhang";
            cboTenhang.Size = new Size(438, 28);
            cboTenhang.TabIndex = 3;
            cboTenhang.SelectedIndexChanged += cboTenhang_SelectedIndexChanged;
            // 
            // grbTTChung
            // 
            grbTTChung.BackColor = SystemColors.Control;
            grbTTChung.BackgroundImageLayout = ImageLayout.Center;
            grbTTChung.Controls.Add(txtMaNV);
            grbTTChung.Controls.Add(cboNCC);
            grbTTChung.Controls.Add(txtMaNCC);
            grbTTChung.Controls.Add(lblTenNCC);
            grbTTChung.Controls.Add(txtSdtNCC);
            grbTTChung.Controls.Add(lblMaNCC);
            grbTTChung.Controls.Add(lblTenNV);
            grbTTChung.Controls.Add(txtDiaChiNCC);
            grbTTChung.Controls.Add(lblSDT);
            grbTTChung.Controls.Add(lblMaNV);
            grbTTChung.Controls.Add(lblDiaChi);
            grbTTChung.Controls.Add(dtpNgayLap);
            grbTTChung.Controls.Add(lblNgayLap);
            grbTTChung.Controls.Add(txtTenNV);
            grbTTChung.Controls.Add(lblMaPN);
            grbTTChung.Controls.Add(txtMaPN);
            grbTTChung.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbTTChung.Location = new Point(4, 44);
            grbTTChung.Name = "grbTTChung";
            grbTTChung.Size = new Size(836, 198);
            grbTTChung.TabIndex = 3;
            grbTTChung.TabStop = false;
            grbTTChung.Text = "THÔNG TIN CHUNG";
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.ControlLightLight;
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Enabled = false;
            txtMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(148, 109);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(229, 27);
            txtMaNV.TabIndex = 0;
            txtMaNV.TabStop = false;
            // 
            // cboNCC
            // 
            cboNCC.FormattingEnabled = true;
            cboNCC.Items.AddRange(new object[] { "Xe máy", "Phụ tùng" });
            cboNCC.Location = new Point(587, 71);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(229, 28);
            cboNCC.TabIndex = 0;
            cboNCC.SelectedIndexChanged += cboNCC_SelectedIndexChanged;
            cboNCC.TextChanged += cboNCC_TextChanged;
            // 
            // txtMaNCC
            // 
            txtMaNCC.BackColor = SystemColors.ControlLightLight;
            txtMaNCC.BorderStyle = BorderStyle.FixedSingle;
            txtMaNCC.Enabled = false;
            txtMaNCC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNCC.Location = new Point(587, 33);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(229, 27);
            txtMaNCC.TabIndex = 0;
            txtMaNCC.TabStop = false;
            // 
            // lblTenNCC
            // 
            lblTenNCC.AutoSize = true;
            lblTenNCC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNCC.ForeColor = Color.Blue;
            lblTenNCC.Location = new Point(466, 76);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(100, 20);
            lblTenNCC.TabIndex = 64;
            lblTenNCC.Text = "Nhà cung cấp";
            // 
            // txtSdtNCC
            // 
            txtSdtNCC.BackColor = SystemColors.ControlLightLight;
            txtSdtNCC.BorderStyle = BorderStyle.FixedSingle;
            txtSdtNCC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdtNCC.Location = new Point(587, 147);
            txtSdtNCC.Name = "txtSdtNCC";
            txtSdtNCC.Size = new Size(229, 27);
            txtSdtNCC.TabIndex = 2;
            // 
            // lblMaNCC
            // 
            lblMaNCC.AutoSize = true;
            lblMaNCC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNCC.ForeColor = Color.Blue;
            lblMaNCC.Location = new Point(466, 36);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(63, 20);
            lblMaNCC.TabIndex = 32;
            lblMaNCC.Text = "Mã NCC";
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
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.BackColor = SystemColors.ControlLightLight;
            txtDiaChiNCC.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChiNCC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiNCC.Location = new Point(587, 109);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(229, 27);
            txtDiaChiNCC.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.Blue;
            lblSDT.Location = new Point(466, 150);
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
            lblDiaChi.Location = new Point(466, 112);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 29;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpNgayLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.ImeMode = ImeMode.NoControl;
            dtpNgayLap.Location = new Point(148, 71);
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
            // txtTenNV
            // 
            txtTenNV.BackColor = SystemColors.ControlLightLight;
            txtTenNV.BorderStyle = BorderStyle.FixedSingle;
            txtTenNV.Enabled = false;
            txtTenNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNV.Location = new Point(148, 147);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(229, 27);
            txtTenNV.TabIndex = 20;
            // 
            // lblMaPN
            // 
            lblMaPN.AutoSize = true;
            lblMaPN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPN.ForeColor = Color.Blue;
            lblMaPN.Location = new Point(20, 36);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(108, 20);
            lblMaPN.TabIndex = 17;
            lblMaPN.Text = "Mã phiếu nhập";
            // 
            // txtMaPN
            // 
            txtMaPN.BackColor = SystemColors.ControlLightLight;
            txtMaPN.BorderStyle = BorderStyle.FixedSingle;
            txtMaPN.Enabled = false;
            txtMaPN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPN.Location = new Point(148, 33);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(229, 27);
            txtMaPN.TabIndex = 0;
            txtMaPN.TabStop = false;
            // 
            // grbCTDonHang
            // 
            grbCTDonHang.BackColor = SystemColors.Control;
            grbCTDonHang.Controls.Add(lblLuuY);
            grbCTDonHang.Controls.Add(numSL);
            grbCTDonHang.Controls.Add(txtGiaNhap);
            grbCTDonHang.Controls.Add(lblThanhTien);
            grbCTDonHang.Controls.Add(lblDonGia);
            grbCTDonHang.Controls.Add(txtThanhTien);
            grbCTDonHang.Controls.Add(lblTenHang);
            grbCTDonHang.Controls.Add(dgvThongTinDonHang);
            grbCTDonHang.Controls.Add(panel1);
            grbCTDonHang.Controls.Add(lblXoa);
            grbCTDonHang.Controls.Add(btnInPN);
            grbCTDonHang.Controls.Add(btnLuuPN);
            grbCTDonHang.Controls.Add(btnThemHH);
            grbCTDonHang.Controls.Add(lblSoLuong);
            grbCTDonHang.Controls.Add(cboTenhang);
            grbCTDonHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbCTDonHang.Location = new Point(4, 250);
            grbCTDonHang.Name = "grbCTDonHang";
            grbCTDonHang.Size = new Size(836, 420);
            grbCTDonHang.TabIndex = 4;
            grbCTDonHang.TabStop = false;
            grbCTDonHang.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // lblLuuY
            // 
            lblLuuY.AutoSize = true;
            lblLuuY.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLuuY.ForeColor = Color.FromArgb(192, 0, 0);
            lblLuuY.Location = new Point(20, 95);
            lblLuuY.Name = "lblLuuY";
            lblLuuY.Size = new Size(355, 18);
            lblLuuY.TabIndex = 72;
            lblLuuY.Text = "Lưu ý: Nhập SL phải ấn Enter để hiển thị đúng thành tiền";
            // 
            // numSL
            // 
            numSL.BackColor = SystemColors.ControlLightLight;
            numSL.BorderStyle = BorderStyle.FixedSingle;
            numSL.Location = new Point(95, 66);
            numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSL.Name = "numSL";
            numSL.Size = new Size(162, 27);
            numSL.TabIndex = 4;
            numSL.TextAlign = HorizontalAlignment.Center;
            numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSL.ValueChanged += numSL_ValueChanged;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.BackColor = SystemColors.ControlLightLight;
            txtGiaNhap.BorderStyle = BorderStyle.FixedSingle;
            txtGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaNhap.Location = new Point(371, 66);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(162, 27);
            txtGiaNhap.TabIndex = 5;
            txtGiaNhap.TabStop = false;
            txtGiaNhap.TextAlign = HorizontalAlignment.Center;
            txtGiaNhap.TextChanged += txtGiaNhap_TextChanged;
            txtGiaNhap.KeyPress += txtGiaNhap_KeyPress;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.Blue;
            lblThanhTien.Location = new Point(570, 69);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(78, 20);
            lblThanhTien.TabIndex = 70;
            lblThanhTien.Text = "Thành tiền";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.Blue;
            lblDonGia.Location = new Point(297, 68);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(68, 20);
            lblDonGia.TabIndex = 69;
            lblDonGia.Text = "Giá nhập";
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = SystemColors.ControlLightLight;
            txtThanhTien.BorderStyle = BorderStyle.FixedSingle;
            txtThanhTien.Enabled = false;
            txtThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.Location = new Point(654, 66);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(162, 27);
            txtThanhTien.TabIndex = 68;
            txtThanhTien.TabStop = false;
            txtThanhTien.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenHang.ForeColor = Color.Blue;
            lblTenHang.Location = new Point(20, 32);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(69, 20);
            lblTenHang.TabIndex = 66;
            lblTenHang.Text = "Tên hàng";
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
            dgvThongTinDonHang.Columns.AddRange(new DataGridViewColumn[] { MaHang, TenHang, SLuong, GiaNhap, TTien });
            dgvThongTinDonHang.Location = new Point(20, 124);
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
            dgvThongTinDonHang.Size = new Size(796, 216);
            dgvThongTinDonHang.TabIndex = 51;
            dgvThongTinDonHang.CellDoubleClick += dgvThongTinDonHang_CellDoubleClick;
            // 
            // MaHang
            // 
            MaHang.HeaderText = "Mã";
            MaHang.MinimumWidth = 6;
            MaHang.Name = "MaHang";
            MaHang.ReadOnly = true;
            MaHang.Width = 93;
            // 
            // TenHang
            // 
            TenHang.HeaderText = "Tên hàng";
            TenHang.MinimumWidth = 6;
            TenHang.Name = "TenHang";
            TenHang.ReadOnly = true;
            TenHang.Width = 320;
            // 
            // SLuong
            // 
            SLuong.HeaderText = "Số lượng";
            SLuong.MinimumWidth = 6;
            SLuong.Name = "SLuong";
            SLuong.ReadOnly = true;
            SLuong.Width = 120;
            // 
            // GiaNhap
            // 
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.ReadOnly = true;
            GiaNhap.Width = 130;
            // 
            // TTien
            // 
            TTien.HeaderText = "Thành tiền";
            TTien.MinimumWidth = 6;
            TTien.Name = "TTien";
            TTien.ReadOnly = true;
            TTien.Width = 130;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.OrangeRed;
            lblTitle.Location = new Point(266, -2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 33);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "LẬP PHIẾU NHẬP HÀNG";
            // 
            // frmNV_LapPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(844, 677);
            Controls.Add(grbTTChung);
            Controls.Add(grbCTDonHang);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNV_LapPhieuNhap";
            Load += LapPhieuNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbTTChung.ResumeLayout(false);
            grbTTChung.PerformLayout();
            grbCTDonHang.ResumeLayout(false);
            grbCTDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInPN;
        private Button btnLuuPN;
        private Button btnThemHH;
        private Label lblSoLuong;
        private Label lblXoa;
        private Panel panel1;
        private Label lblVND;
        private Label label5;
        private ComboBox cboTenhang;
        private GroupBox grbTTChung;
        private TextBox txtMaNV;
        private TextBox txtMaNCC;
        private TextBox txtSdtNCC;
        private Label lblMaNCC;
        private Label lblTenNV;
        private TextBox txtDiaChiNCC;
        private Label lblSDT;
        private Label lblMaNV;
        private Label lblDiaChi;
        private DateTimePicker dtpNgayLap;
        private Label lblNgayLap;
        private TextBox txtTenNV;
        private Label lblMaPN;
        private TextBox txtMaPN;
        private GroupBox grbCTDonHang;
        private DataGridView dgvThongTinDonHang;
        private Label lblTitle;
        private Label lblTenHang;
        private ComboBox cboNCC;
        private Label lblTenNCC;
        private TextBox txtGiaNhap;
        private Label lblThanhTien;
        private Label lblDonGia;
        private TextBox txtThanhTien;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn TTien;
        private NumericUpDown numSL;
        private Label lblLuuY;
    }
}