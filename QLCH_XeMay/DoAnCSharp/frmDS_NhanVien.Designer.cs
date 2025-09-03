namespace DoAnCSharp
{
    partial class frmDS_NhanVien
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
            dgvDSNhanVien = new DataGridView();
            lblTieuDe = new Label();
            btnUndo = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            lblGioiTinh = new Label();
            txtChucvu = new TextBox();
            lblNgaySinh = new Label();
            cboPhai = new ComboBox();
            lblChucVu = new Label();
            dtpNgaysinh = new DateTimePicker();
            lblTenNV = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtHoten = new TextBox();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            grbDanhSach = new GroupBox();
            pnlThongTin = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).BeginInit();
            grbDanhSach.SuspendLayout();
            pnlThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSNhanVien
            // 
            dgvDSNhanVien.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSNhanVien.Cursor = Cursors.Hand;
            dgvDSNhanVien.Location = new Point(17, 23);
            dgvDSNhanVien.Name = "dgvDSNhanVien";
            dgvDSNhanVien.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDSNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvDSNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSNhanVien.ShowCellToolTips = false;
            dgvDSNhanVien.Size = new Size(723, 390);
            dgvDSNhanVien.TabIndex = 9;
            dgvDSNhanVien.CellClick += dgvDSNhanVien_CellClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.OrangeRed;
            lblTieuDe.Location = new Point(460, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(209, 40);
            lblTieuDe.TabIndex = 11;
            lblTieuDe.Text = "«NHÂN VIÊN»";
            // 
            // btnUndo
            // 
            btnUndo.BackColor = SystemColors.Control;
            btnUndo.Cursor = Cursors.Hand;
            btnUndo.Enabled = false;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = Properties.Resources.undo;
            btnUndo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUndo.Location = new Point(552, 421);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(122, 33);
            btnUndo.TabIndex = 12;
            btnUndo.Text = "Khôi phục";
            btnUndo.TextAlign = ContentAlignment.MiddleRight;
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Control;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.addtocart;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(17, 421);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 33);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Enabled = false;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = Properties.Resources.update21;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(432, 421);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 33);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Update";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Control;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Enabled = false;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(233, 421);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 33);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.Control;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Enabled = false;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Image = Properties.Resources.cancel2;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(333, 421);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(82, 33);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Enabled = false;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.recycle;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(134, 421);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 33);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = SystemColors.ControlLightLight;
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCCCD.Location = new Point(132, 245);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(194, 25);
            txtCCCD.TabIndex = 4;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCCCD.ForeColor = Color.Blue;
            lblCCCD.Location = new Point(26, 247);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(47, 20);
            lblCCCD.TabIndex = 16;
            lblCCCD.Text = "CCCD";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGioiTinh.ForeColor = Color.Blue;
            lblGioiTinh.Location = new Point(26, 206);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính";
            // 
            // txtChucvu
            // 
            txtChucvu.BackColor = SystemColors.ControlLightLight;
            txtChucvu.BorderStyle = BorderStyle.FixedSingle;
            txtChucvu.Enabled = false;
            txtChucvu.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtChucvu.Location = new Point(132, 327);
            txtChucvu.Name = "txtChucvu";
            txtChucvu.Size = new Size(194, 25);
            txtChucvu.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.ForeColor = Color.Blue;
            lblNgaySinh.Location = new Point(26, 167);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // cboPhai
            // 
            cboPhai.BackColor = SystemColors.ControlLightLight;
            cboPhai.DisplayMember = "Nam";
            cboPhai.Enabled = false;
            cboPhai.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cboPhai.FormattingEnabled = true;
            cboPhai.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboPhai.Location = new Point(132, 203);
            cboPhai.Name = "cboPhai";
            cboPhai.Size = new Size(193, 25);
            cboPhai.TabIndex = 3;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblChucVu.ForeColor = Color.Blue;
            lblChucVu.Location = new Point(26, 329);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(61, 20);
            lblChucVu.TabIndex = 6;
            lblChucVu.Text = "Chức vụ";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaysinh.Enabled = false;
            dtpNgaysinh.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(132, 162);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(193, 25);
            dtpNgaysinh.TabIndex = 2;
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNV.ForeColor = Color.Blue;
            lblTenNV.Location = new Point(26, 123);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(54, 20);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Họ tên";
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.ControlLightLight;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Enabled = false;
            txtSDT.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSDT.Location = new Point(132, 286);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 25);
            txtSDT.TabIndex = 5;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.Blue;
            lblSDT.Location = new Point(26, 288);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 7;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtHoten
            // 
            txtHoten.BackColor = SystemColors.ControlLightLight;
            txtHoten.BorderStyle = BorderStyle.FixedSingle;
            txtHoten.Enabled = false;
            txtHoten.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoten.Location = new Point(132, 121);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(194, 25);
            txtHoten.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNV.ForeColor = Color.Blue;
            lblMaNV.Location = new Point(26, 82);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(97, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.ControlLightLight;
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Enabled = false;
            txtMaNV.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNV.Location = new Point(132, 80);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(194, 25);
            txtMaNV.TabIndex = 0;
            // 
            // grbDanhSach
            // 
            grbDanhSach.BackColor = SystemColors.Control;
            grbDanhSach.Controls.Add(btnUndo);
            grbDanhSach.Controls.Add(pnlThongTin);
            grbDanhSach.Controls.Add(btnLuu);
            grbDanhSach.Controls.Add(dgvDSNhanVien);
            grbDanhSach.Controls.Add(btnXoa);
            grbDanhSach.Controls.Add(btnThem);
            grbDanhSach.Controls.Add(btnSua);
            grbDanhSach.Controls.Add(btnHuy);
            grbDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSach.Location = new Point(4, 50);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(1121, 473);
            grbDanhSach.TabIndex = 21;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = SystemColors.Info;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Controls.Add(label5);
            pnlThongTin.Controls.Add(txtCCCD);
            pnlThongTin.Controls.Add(lblMaNV);
            pnlThongTin.Controls.Add(lblChucVu);
            pnlThongTin.Controls.Add(cboPhai);
            pnlThongTin.Controls.Add(txtMaNV);
            pnlThongTin.Controls.Add(dtpNgaysinh);
            pnlThongTin.Controls.Add(lblCCCD);
            pnlThongTin.Controls.Add(lblNgaySinh);
            pnlThongTin.Controls.Add(txtHoten);
            pnlThongTin.Controls.Add(lblTenNV);
            pnlThongTin.Controls.Add(lblGioiTinh);
            pnlThongTin.Controls.Add(lblSDT);
            pnlThongTin.Controls.Add(txtSDT);
            pnlThongTin.Controls.Add(txtChucvu);
            pnlThongTin.Location = new Point(746, 23);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(359, 390);
            pnlThongTin.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 35);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 17;
            label5.Text = "THÔNG TIN";
            // 
            // frmDS_NhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1130, 528);
            Controls.Add(grbDanhSach);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDS_NhanVien";
            StartPosition = FormStartPosition.CenterParent;
            TopMost = true;
            Activated += frmDS_NhanVien_Activated;
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).EndInit();
            grbDanhSach.ResumeLayout(false);
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDSNhanVien;
        private Label lblTieuDe;
        private Button btnUndo;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuy;
        private Button btnXoa;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private Label lblGioiTinh;
        private TextBox txtChucvu;
        private Label lblNgaySinh;
        private ComboBox cboPhai;
        private Label lblChucVu;
        private DateTimePicker dtpNgaysinh;
        private Label lblTenNV;
        private TextBox txtSDT;
        private Label lblSDT;
        private TextBox txtHoten;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private GroupBox grbDanhSach;
        private Panel pnlThongTin;
        private Label label5;
    }
}