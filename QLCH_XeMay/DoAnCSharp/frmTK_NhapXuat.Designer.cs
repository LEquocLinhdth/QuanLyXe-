namespace DoAnCSharp
{
    partial class frmTK_NhapXuat
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tabThongKe = new TabControl();
            pageNhapXuat = new TabPage();
            lblTitlePage1 = new Label();
            gbHangHoaBanRa = new GroupBox();
            pnlThongTin = new Panel();
            lblThongTin = new Label();
            txtSLTON = new TextBox();
            lblMaHH = new Label();
            txtLoaiHH = new TextBox();
            txtGiaBan = new TextBox();
            lblHangSX = new Label();
            txtHangSX = new TextBox();
            lblSLTon = new Label();
            lblLoaiHH = new Label();
            lblTenHH = new Label();
            txtMaHH = new TextBox();
            lblGiaBan = new Label();
            txtTenHH = new TextBox();
            dgvNhapXuat = new DataGridView();
            pageDoanhThu = new TabPage();
            lblTitlePage2 = new Label();
            grbDoanhThu = new GroupBox();
            pnlThongTin2 = new Panel();
            lblTienNhap = new Label();
            lblTienNhapHang = new Label();
            lblDoanhThu = new Label();
            lblThangNam = new Label();
            lblTongDoanhThu = new Label();
            dgvHoaDon = new DataGridView();
            groupBox3 = new GroupBox();
            numNam = new NumericUpDown();
            numThang = new NumericUpDown();
            cboLoai = new ComboBox();
            rdoNhap = new RadioButton();
            rdoXuat = new RadioButton();
            btnXuatExcel = new Button();
            lblLoai = new Label();
            btnThongKe = new Button();
            btnChonLai = new Button();
            lblNam = new Label();
            lblThang = new Label();
            panel1.SuspendLayout();
            tabThongKe.SuspendLayout();
            pageNhapXuat.SuspendLayout();
            gbHangHoaBanRa.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).BeginInit();
            pageDoanhThu.SuspendLayout();
            grbDoanhThu.SuspendLayout();
            pnlThongTin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabThongKe);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 563);
            panel1.TabIndex = 0;
            // 
            // tabThongKe
            // 
            tabThongKe.Appearance = TabAppearance.FlatButtons;
            tabThongKe.Controls.Add(pageNhapXuat);
            tabThongKe.Controls.Add(pageDoanhThu);
            tabThongKe.Dock = DockStyle.Fill;
            tabThongKe.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabThongKe.Location = new Point(0, 0);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.SelectedIndex = 0;
            tabThongKe.Size = new Size(1069, 563);
            tabThongKe.TabIndex = 1;
            tabThongKe.SelectedIndexChanged += tabThongKe_SelectedIndexChanged;
            // 
            // pageNhapXuat
            // 
            pageNhapXuat.BackColor = SystemColors.GradientActiveCaption;
            pageNhapXuat.Controls.Add(lblTitlePage1);
            pageNhapXuat.Controls.Add(gbHangHoaBanRa);
            pageNhapXuat.Location = new Point(4, 33);
            pageNhapXuat.Name = "pageNhapXuat";
            pageNhapXuat.Padding = new Padding(3);
            pageNhapXuat.Size = new Size(1061, 526);
            pageNhapXuat.TabIndex = 1;
            pageNhapXuat.Text = "Nhập - Xuất";
            // 
            // lblTitlePage1
            // 
            lblTitlePage1.AutoSize = true;
            lblTitlePage1.BackColor = SystemColors.ControlLightLight;
            lblTitlePage1.BorderStyle = BorderStyle.FixedSingle;
            lblTitlePage1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitlePage1.ForeColor = Color.OrangeRed;
            lblTitlePage1.Location = new Point(230, 25);
            lblTitlePage1.Name = "lblTitlePage1";
            lblTitlePage1.Size = new Size(605, 35);
            lblTitlePage1.TabIndex = 56;
            lblTitlePage1.Text = "THỐNG KÊ HÀNG NHẬP VÀ XUẤT THEO THÁNG";
            // 
            // gbHangHoaBanRa
            // 
            gbHangHoaBanRa.BackColor = SystemColors.Control;
            gbHangHoaBanRa.Controls.Add(pnlThongTin);
            gbHangHoaBanRa.Controls.Add(dgvNhapXuat);
            gbHangHoaBanRa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbHangHoaBanRa.Location = new Point(8, 68);
            gbHangHoaBanRa.Name = "gbHangHoaBanRa";
            gbHangHoaBanRa.Size = new Size(1042, 448);
            gbHangHoaBanRa.TabIndex = 53;
            gbHangHoaBanRa.TabStop = false;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = SystemColors.Info;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Controls.Add(lblThongTin);
            pnlThongTin.Controls.Add(txtSLTON);
            pnlThongTin.Controls.Add(lblMaHH);
            pnlThongTin.Controls.Add(txtLoaiHH);
            pnlThongTin.Controls.Add(txtGiaBan);
            pnlThongTin.Controls.Add(lblHangSX);
            pnlThongTin.Controls.Add(txtHangSX);
            pnlThongTin.Controls.Add(lblSLTon);
            pnlThongTin.Controls.Add(lblLoaiHH);
            pnlThongTin.Controls.Add(lblTenHH);
            pnlThongTin.Controls.Add(txtMaHH);
            pnlThongTin.Controls.Add(lblGiaBan);
            pnlThongTin.Controls.Add(txtTenHH);
            pnlThongTin.Location = new Point(643, 29);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(386, 400);
            pnlThongTin.TabIndex = 57;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThongTin.Location = new Point(99, 38);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(202, 23);
            lblThongTin.TabIndex = 45;
            lblThongTin.Text = "THÔNG TIN HÀNG HÓA";
            // 
            // txtSLTON
            // 
            txtSLTON.BackColor = SystemColors.ControlLightLight;
            txtSLTON.BorderStyle = BorderStyle.FixedSingle;
            txtSLTON.Enabled = false;
            txtSLTON.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLTON.Location = new Point(130, 336);
            txtSLTON.Name = "txtSLTON";
            txtSLTON.Size = new Size(236, 25);
            txtSLTON.TabIndex = 42;
            // 
            // lblMaHH
            // 
            lblMaHH.AutoSize = true;
            lblMaHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHH.ForeColor = Color.Blue;
            lblMaHH.Location = new Point(14, 90);
            lblMaHH.Name = "lblMaHH";
            lblMaHH.Size = new Size(96, 20);
            lblMaHH.TabIndex = 40;
            lblMaHH.Text = "Mã hàng hóa";
            // 
            // txtLoaiHH
            // 
            txtLoaiHH.BackColor = SystemColors.ControlLightLight;
            txtLoaiHH.BorderStyle = BorderStyle.FixedSingle;
            txtLoaiHH.Enabled = false;
            txtLoaiHH.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoaiHH.Location = new Point(130, 210);
            txtLoaiHH.Name = "txtLoaiHH";
            txtLoaiHH.Size = new Size(236, 25);
            txtLoaiHH.TabIndex = 35;
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = SystemColors.ControlLightLight;
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Enabled = false;
            txtGiaBan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaBan.Location = new Point(130, 294);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(236, 25);
            txtGiaBan.TabIndex = 41;
            // 
            // lblHangSX
            // 
            lblHangSX.AutoSize = true;
            lblHangSX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHangSX.ForeColor = Color.Blue;
            lblHangSX.Location = new Point(15, 251);
            lblHangSX.Name = "lblHangSX";
            lblHangSX.Size = new Size(103, 20);
            lblHangSX.TabIndex = 37;
            lblHangSX.Text = "Hãng sản xuất";
            // 
            // txtHangSX
            // 
            txtHangSX.BackColor = SystemColors.ControlLightLight;
            txtHangSX.BorderStyle = BorderStyle.FixedSingle;
            txtHangSX.Enabled = false;
            txtHangSX.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHangSX.Location = new Point(130, 252);
            txtHangSX.Name = "txtHangSX";
            txtHangSX.Size = new Size(236, 25);
            txtHangSX.TabIndex = 36;
            // 
            // lblSLTon
            // 
            lblSLTon.AutoSize = true;
            lblSLTon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLTon.ForeColor = Color.Blue;
            lblSLTon.Location = new Point(14, 335);
            lblSLTon.Name = "lblSLTon";
            lblSLTon.Size = new Size(95, 20);
            lblSLTon.TabIndex = 43;
            lblSLTon.Text = "Số lượng tồn";
            // 
            // lblLoaiHH
            // 
            lblLoaiHH.AutoSize = true;
            lblLoaiHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiHH.ForeColor = Color.Blue;
            lblLoaiHH.Location = new Point(14, 209);
            lblLoaiHH.Name = "lblLoaiHH";
            lblLoaiHH.Size = new Size(103, 20);
            lblLoaiHH.TabIndex = 38;
            lblLoaiHH.Text = "Loại hàng hóa";
            // 
            // lblTenHH
            // 
            lblTenHH.AutoSize = true;
            lblTenHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenHH.ForeColor = Color.Blue;
            lblTenHH.Location = new Point(15, 134);
            lblTenHH.Name = "lblTenHH";
            lblTenHH.Size = new Size(98, 20);
            lblTenHH.TabIndex = 39;
            lblTenHH.Text = "Tên hàng hóa";
            // 
            // txtMaHH
            // 
            txtMaHH.BackColor = SystemColors.ControlLightLight;
            txtMaHH.BorderStyle = BorderStyle.FixedSingle;
            txtMaHH.Enabled = false;
            txtMaHH.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHH.Location = new Point(130, 91);
            txtMaHH.Name = "txtMaHH";
            txtMaHH.Size = new Size(236, 25);
            txtMaHH.TabIndex = 33;
            txtMaHH.TabStop = false;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiaBan.ForeColor = Color.Blue;
            lblGiaBan.Location = new Point(15, 293);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(60, 20);
            lblGiaBan.TabIndex = 44;
            lblGiaBan.Text = "Giá bán";
            // 
            // txtTenHH
            // 
            txtTenHH.BackColor = SystemColors.ControlLightLight;
            txtTenHH.BorderStyle = BorderStyle.FixedSingle;
            txtTenHH.Enabled = false;
            txtTenHH.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenHH.Location = new Point(130, 133);
            txtTenHH.Multiline = true;
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(236, 58);
            txtTenHH.TabIndex = 34;
            // 
            // dgvNhapXuat
            // 
            dgvNhapXuat.AllowUserToDeleteRows = false;
            dgvNhapXuat.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvNhapXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvNhapXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapXuat.Location = new Point(14, 29);
            dgvNhapXuat.Name = "dgvNhapXuat";
            dgvNhapXuat.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvNhapXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvNhapXuat.RowHeadersVisible = false;
            dgvNhapXuat.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhapXuat.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvNhapXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapXuat.Size = new Size(623, 400);
            dgvNhapXuat.TabIndex = 52;
            dgvNhapXuat.CellClick += dgvNhapXuat_CellClick;
            // 
            // pageDoanhThu
            // 
            pageDoanhThu.BackColor = SystemColors.GradientActiveCaption;
            pageDoanhThu.Controls.Add(lblTitlePage2);
            pageDoanhThu.Controls.Add(grbDoanhThu);
            pageDoanhThu.Location = new Point(4, 33);
            pageDoanhThu.Name = "pageDoanhThu";
            pageDoanhThu.Padding = new Padding(3);
            pageDoanhThu.Size = new Size(1061, 526);
            pageDoanhThu.TabIndex = 2;
            pageDoanhThu.Text = "Doanh thu";
            // 
            // lblTitlePage2
            // 
            lblTitlePage2.AutoSize = true;
            lblTitlePage2.BackColor = SystemColors.ControlLightLight;
            lblTitlePage2.BorderStyle = BorderStyle.FixedSingle;
            lblTitlePage2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitlePage2.ForeColor = Color.OrangeRed;
            lblTitlePage2.Location = new Point(371, 25);
            lblTitlePage2.Name = "lblTitlePage2";
            lblTitlePage2.Size = new Size(317, 35);
            lblTitlePage2.TabIndex = 57;
            lblTitlePage2.Text = "DOANH THU BÁN HÀNG";
            // 
            // grbDoanhThu
            // 
            grbDoanhThu.BackColor = SystemColors.Control;
            grbDoanhThu.Controls.Add(pnlThongTin2);
            grbDoanhThu.Controls.Add(dgvHoaDon);
            grbDoanhThu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDoanhThu.Location = new Point(8, 68);
            grbDoanhThu.Name = "grbDoanhThu";
            grbDoanhThu.Size = new Size(1042, 448);
            grbDoanhThu.TabIndex = 54;
            grbDoanhThu.TabStop = false;
            // 
            // pnlThongTin2
            // 
            pnlThongTin2.BackColor = SystemColors.Info;
            pnlThongTin2.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin2.Controls.Add(lblTienNhap);
            pnlThongTin2.Controls.Add(lblTienNhapHang);
            pnlThongTin2.Controls.Add(lblDoanhThu);
            pnlThongTin2.Controls.Add(lblThangNam);
            pnlThongTin2.Controls.Add(lblTongDoanhThu);
            pnlThongTin2.Location = new Point(723, 29);
            pnlThongTin2.Name = "pnlThongTin2";
            pnlThongTin2.Size = new Size(306, 400);
            pnlThongTin2.TabIndex = 57;
            // 
            // lblTienNhap
            // 
            lblTienNhap.AutoSize = true;
            lblTienNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienNhap.ForeColor = Color.Blue;
            lblTienNhap.Location = new Point(94, 300);
            lblTienNhap.Name = "lblTienNhap";
            lblTienNhap.Size = new Size(0, 25);
            lblTienNhap.TabIndex = 49;
            // 
            // lblTienNhapHang
            // 
            lblTienNhapHang.AutoSize = true;
            lblTienNhapHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienNhapHang.Location = new Point(32, 241);
            lblTienNhapHang.Name = "lblTienNhapHang";
            lblTienNhapHang.Size = new Size(247, 25);
            lblTienNhapHang.TabIndex = 48;
            lblTienNhapHang.Text = "Tiền nhập hàng cùng tháng";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoanhThu.ForeColor = Color.FromArgb(192, 0, 0);
            lblDoanhThu.Location = new Point(37, 155);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(0, 41);
            lblDoanhThu.TabIndex = 47;
            // 
            // lblThangNam
            // 
            lblThangNam.AutoSize = true;
            lblThangNam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThangNam.Location = new Point(128, 107);
            lblThangNam.Name = "lblThangNam";
            lblThangNam.Size = new Size(0, 23);
            lblThangNam.TabIndex = 46;
            lblThangNam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongDoanhThu.Location = new Point(62, 65);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(197, 28);
            lblTongDoanhThu.TabIndex = 45;
            lblTongDoanhThu.Text = "TỔNG DOANH THU";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(14, 29);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(703, 400);
            dgvHoaDon.TabIndex = 52;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(numNam);
            groupBox3.Controls.Add(numThang);
            groupBox3.Controls.Add(cboLoai);
            groupBox3.Controls.Add(rdoNhap);
            groupBox3.Controls.Add(rdoXuat);
            groupBox3.Controls.Add(btnXuatExcel);
            groupBox3.Controls.Add(lblLoai);
            groupBox3.Controls.Add(btnThongKe);
            groupBox3.Controls.Add(btnChonLai);
            groupBox3.Controls.Add(lblNam);
            groupBox3.Controls.Add(lblThang);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Location = new Point(0, 569);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1069, 73);
            groupBox3.TabIndex = 55;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc";
            // 
            // numNam
            // 
            numNam.Location = new Point(822, 30);
            numNam.Maximum = new decimal(new int[] { 2040, 0, 0, 0 });
            numNam.Minimum = new decimal(new int[] { 2022, 0, 0, 0 });
            numNam.Name = "numNam";
            numNam.Size = new Size(83, 27);
            numNam.TabIndex = 66;
            numNam.TextAlign = HorizontalAlignment.Center;
            numNam.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // numThang
            // 
            numThang.Location = new Point(708, 30);
            numThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numThang.Name = "numThang";
            numThang.Size = new Size(83, 27);
            numThang.TabIndex = 65;
            numThang.TextAlign = HorizontalAlignment.Center;
            numThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboLoai
            // 
            cboLoai.FormattingEnabled = true;
            cboLoai.Items.AddRange(new object[] { "-Tất cả-", "Xe máy", "Phụ tùng" });
            cboLoai.Location = new Point(934, 29);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(107, 28);
            cboLoai.TabIndex = 60;
            // 
            // rdoNhap
            // 
            rdoNhap.AutoSize = true;
            rdoNhap.Checked = true;
            rdoNhap.Location = new Point(582, 11);
            rdoNhap.Name = "rdoNhap";
            rdoNhap.Size = new Size(103, 24);
            rdoNhap.TabIndex = 64;
            rdoNhap.TabStop = true;
            rdoNhap.Text = "Hàng nhập";
            rdoNhap.UseVisualStyleBackColor = true;
            // 
            // rdoXuat
            // 
            rdoXuat.AutoSize = true;
            rdoXuat.Location = new Point(582, 41);
            rdoXuat.Name = "rdoXuat";
            rdoXuat.Size = new Size(98, 24);
            rdoXuat.TabIndex = 63;
            rdoXuat.Text = "Hàng xuất";
            rdoXuat.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Enabled = false;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.Image = Properties.Resources.sheet;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(307, 26);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(127, 33);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất excel";
            btnXuatExcel.TextAlign = ContentAlignment.MiddleRight;
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoai.ForeColor = Color.Black;
            lblLoai.Location = new Point(946, 11);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(38, 20);
            lblLoai.TabIndex = 61;
            lblLoai.Text = "Loại";
            // 
            // btnThongKe
            // 
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.Image = Properties.Resources.find;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(26, 26);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(122, 33);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleRight;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnChonLai
            // 
            btnChonLai.Enabled = false;
            btnChonLai.FlatStyle = FlatStyle.Flat;
            btnChonLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonLai.Image = Properties.Resources.refresh;
            btnChonLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonLai.Location = new Point(170, 26);
            btnChonLai.Name = "btnChonLai";
            btnChonLai.Size = new Size(115, 33);
            btnChonLai.TabIndex = 1;
            btnChonLai.Text = "Chọn lại";
            btnChonLai.TextAlign = ContentAlignment.MiddleRight;
            btnChonLai.UseVisualStyleBackColor = true;
            btnChonLai.Click += btnChonLai_Click;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNam.ForeColor = Color.Black;
            lblNam.Location = new Point(832, 11);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(43, 20);
            lblNam.TabIndex = 56;
            lblNam.Text = "Năm";
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblThang.ForeColor = Color.Black;
            lblThang.Location = new Point(714, 11);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(53, 20);
            lblThang.TabIndex = 55;
            lblThang.Text = "Tháng";
            // 
            // frmTK_NhapXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1068, 646);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmTK_NhapXuat";
            Text = "Báo cáo - Thống kê";
            Load += frmTK_NhapXuat_Load;
            panel1.ResumeLayout(false);
            tabThongKe.ResumeLayout(false);
            pageNhapXuat.ResumeLayout(false);
            pageNhapXuat.PerformLayout();
            gbHangHoaBanRa.ResumeLayout(false);
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).EndInit();
            pageDoanhThu.ResumeLayout(false);
            pageDoanhThu.PerformLayout();
            grbDoanhThu.ResumeLayout(false);
            pnlThongTin2.ResumeLayout(false);
            pnlThongTin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabThongKe;
        private TabPage pageNhapXuat;
        private TabPage pageDoanhThu;
        private GroupBox gbHangHoaBanRa;
        private DataGridView dgvNhapXuat;
        private Label lblTitle;
        private TextBox txtMaHH;
        private TextBox txtHangSX;
        private Label lblMaHH;
        private TextBox txtLoaiHH;
        private Label lblHangSX;
        private Label lblLoaiHH;
        private TextBox txtTenHH;
        private Label lblTenHH;
        private TextBox txtSLTON;
        private TextBox txtGiaBan;
        private Label lblSLTon;
        private Label lblGiaBan;
        private ComboBox cboNam;
        private ComboBox cboThang;
        private Panel pnlThongTin;
        private Label lblThongTin;
        private GroupBox grbDoanhThu;
        private Panel panel1;
        private Label lblTongDoanhThu;
        private DataGridView dataGridView1;
        private Label label12;
        private Label lblTitlePage1;
        private Label lblTitlePage2;
        private DataGridView dgvHoaDon;
        private Panel pnlThongTin2;
        private GroupBox groupBox3;
        private NumericUpDown numNam;
        private NumericUpDown numThang;
        private ComboBox cboLoai;
        private RadioButton rdoNhap;
        private RadioButton rdoXuat;
        private Button btnXuatExcel;
        private Label lblLoai;
        private Button btnThongKe;
        private Button btnChonLai;
        private Label lblNam;
        private Label lblThang;
        private Label lblThangNam;
        private Label lblDoanhThu;
        private Label lblTienNhapHang;
        private Label lblTienNhap;
    }
}