namespace DoAnCSharp
{
    partial class frmDS_KhachHang
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grbCTHD = new GroupBox();
            btnXemCTHD = new Button();
            dgvHoaDon = new DataGridView();
            grbDanhSach = new GroupBox();
            pnlThongTin = new Panel();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblThongTin = new Label();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            btnLuu = new Button();
            btnSua = new Button();
            chbTimKiem = new CheckBox();
            txtTimKiem = new TextBox();
            btnHuy = new Button();
            btnXoa = new Button();
            dgvDSKhachHang = new DataGridView();
            lblTieuDe = new Label();
            grbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            grbDanhSach.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grbCTHD
            // 
            grbCTHD.BackColor = SystemColors.Control;
            grbCTHD.Controls.Add(btnXemCTHD);
            grbCTHD.Controls.Add(dgvHoaDon);
            grbCTHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbCTHD.Location = new Point(4, 495);
            grbCTHD.Name = "grbCTHD";
            grbCTHD.Size = new Size(907, 188);
            grbCTHD.TabIndex = 58;
            grbCTHD.TabStop = false;
            grbCTHD.Text = "HÓA ĐƠN:";
            // 
            // btnXemCTHD
            // 
            btnXemCTHD.BackColor = SystemColors.Control;
            btnXemCTHD.FlatStyle = FlatStyle.Flat;
            btnXemCTHD.Image = Properties.Resources.next;
            btnXemCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemCTHD.Location = new Point(755, 140);
            btnXemCTHD.Name = "btnXemCTHD";
            btnXemCTHD.Size = new Size(133, 33);
            btnXemCTHD.TabIndex = 10;
            btnXemCTHD.Text = "Xem CTHD";
            btnXemCTHD.TextAlign = ContentAlignment.MiddleRight;
            btnXemCTHD.UseVisualStyleBackColor = false;
            btnXemCTHD.Click += btnXemCTHD_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Cursor = Cursors.Hand;
            dgvHoaDon.Location = new Point(17, 25);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(712, 148);
            dgvHoaDon.TabIndex = 52;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // grbDanhSach
            // 
            grbDanhSach.BackColor = SystemColors.Control;
            grbDanhSach.Controls.Add(pnlThongTin);
            grbDanhSach.Controls.Add(btnLuu);
            grbDanhSach.Controls.Add(btnSua);
            grbDanhSach.Controls.Add(chbTimKiem);
            grbDanhSach.Controls.Add(txtTimKiem);
            grbDanhSach.Controls.Add(btnHuy);
            grbDanhSach.Controls.Add(btnXoa);
            grbDanhSach.Controls.Add(dgvDSKhachHang);
            grbDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSach.Location = new Point(4, 48);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(907, 441);
            grbDanhSach.TabIndex = 57;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH:";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = SystemColors.Info;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Controls.Add(lblSDT);
            pnlThongTin.Controls.Add(txtSDT);
            pnlThongTin.Controls.Add(lblDiaChi);
            pnlThongTin.Controls.Add(txtDiaChi);
            pnlThongTin.Controls.Add(lblTenKH);
            pnlThongTin.Controls.Add(txtTenKH);
            pnlThongTin.Controls.Add(lblThongTin);
            pnlThongTin.Controls.Add(lblMaKH);
            pnlThongTin.Controls.Add(txtMaKH);
            pnlThongTin.Location = new Point(595, 23);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(293, 360);
            pnlThongTin.TabIndex = 38;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.Blue;
            lblSDT.Location = new Point(18, 274);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(36, 20);
            lblSDT.TabIndex = 22;
            lblSDT.Text = "SĐT";
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.ControlLightLight;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Enabled = false;
            txtSDT.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(78, 275);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 25);
            txtSDT.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = Color.Blue;
            lblDiaChi.Location = new Point(18, 206);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 20;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.ControlLightLight;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Enabled = false;
            txtDiaChi.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(78, 206);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(194, 46);
            txtDiaChi.TabIndex = 2;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKH.ForeColor = Color.Blue;
            lblTenKH.Location = new Point(18, 156);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(56, 20);
            lblTenKH.TabIndex = 18;
            lblTenKH.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            txtTenKH.BackColor = SystemColors.ControlLightLight;
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Enabled = false;
            txtTenKH.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKH.Location = new Point(78, 156);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(194, 25);
            txtTenKH.TabIndex = 1;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblThongTin.Location = new Point(99, 52);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(114, 25);
            lblThongTin.TabIndex = 17;
            lblThongTin.Text = "THÔNG TIN";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKH.ForeColor = Color.Blue;
            lblMaKH.Location = new Point(18, 106);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(54, 20);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = SystemColors.ControlLightLight;
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Enabled = false;
            txtMaKH.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(78, 106);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(194, 25);
            txtMaKH.TabIndex = 0;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Enabled = false;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = Properties.Resources.update21;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(121, 393);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 33);
            btnLuu.TabIndex = 5;
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
            btnSua.Location = new Point(17, 393);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 33);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // chbTimKiem
            // 
            chbTimKiem.AutoSize = true;
            chbTimKiem.Location = new Point(635, 398);
            chbTimKiem.Name = "chbTimKiem";
            chbTimKiem.Size = new Size(18, 17);
            chbTimKiem.TabIndex = 8;
            chbTimKiem.UseVisualStyleBackColor = true;
            chbTimKiem.CheckedChanged += chbTimKiem_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Enabled = false;
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.Silver;
            txtTimKiem.Location = new Point(659, 393);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(229, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.Control;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Enabled = false;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Image = Properties.Resources.cancel2;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(245, 393);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(90, 33);
            btnHuy.TabIndex = 6;
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
            btnXoa.Location = new Point(356, 393);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 33);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa KH";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvDSKhachHang
            // 
            dgvDSKhachHang.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDSKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSKhachHang.Cursor = Cursors.Hand;
            dgvDSKhachHang.Location = new Point(17, 23);
            dgvDSKhachHang.Name = "dgvDSKhachHang";
            dgvDSKhachHang.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDSKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDSKhachHang.RowHeadersVisible = false;
            dgvDSKhachHang.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvDSKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDSKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSKhachHang.ShowCellToolTips = false;
            dgvDSKhachHang.Size = new Size(572, 360);
            dgvDSKhachHang.TabIndex = 9;
            dgvDSKhachHang.CellClick += dgvDSKhachHang_CellClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.OrangeRed;
            lblTieuDe.Location = new Point(354, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(239, 40);
            lblTieuDe.TabIndex = 56;
            lblTieuDe.Text = "«KHÁCH HÀNG»";
            // 
            // frmDS_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(907, 686);
            Controls.Add(grbCTHD);
            Controls.Add(grbDanhSach);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDS_KhachHang";
            Activated += frmDS_KhachHang_Activated;
            Load += frmDS_KhachHang_Load;
            grbCTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            grbDanhSach.ResumeLayout(false);
            grbDanhSach.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbCTHD;
        private DataGridView dgvHoaDon;
        private GroupBox grbDanhSach;
        private Button btnXoa;
        private DataGridView dgvDSKhachHang;
        private Label lblTieuDe;
        private CheckBox chbTimKiem;
        private TextBox txtTimKiem;
        private Button btnSua;
        private Button btnHuy;
        private Button btnLuu;
        private Label label4;
        private Button btnXemCTHD;
        private Panel pnlThongTin;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblThongTin;
        private Label lblMaKH;
        private TextBox txtMaKH;
    }
}