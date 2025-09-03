namespace DoAnCSharp
{
    partial class frmDS_HoaDon
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
            dgvDSHoaDon = new DataGridView();
            btnXoa = new Button();
            btnInHD = new Button();
            btnThem = new Button();
            dgvChiTietHD = new DataGridView();
            lblTieuDe = new Label();
            grbDanhSach = new GroupBox();
            chbTimKiem = new CheckBox();
            txtTimKiem = new TextBox();
            btnHuyHD = new Button();
            panel1 = new Panel();
            lblThongTin = new Label();
            lblMaHD = new Label();
            lblMaKH = new Label();
            lblNgayLap = new Label();
            txtMaKH = new TextBox();
            txtMaNVLap = new TextBox();
            txtMaHD = new TextBox();
            dtpNgayLap = new DateTimePicker();
            lblMaNV = new Label();
            lblTongTT = new Label();
            txtTongTT = new TextBox();
            grbCTHD = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            grbDanhSach.SuspendLayout();
            panel1.SuspendLayout();
            grbCTHD.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSHoaDon
            // 
            dgvDSHoaDon.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHoaDon.Cursor = Cursors.Hand;
            dgvDSHoaDon.Location = new Point(17, 23);
            dgvDSHoaDon.Name = "dgvDSHoaDon";
            dgvDSHoaDon.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDSHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDSHoaDon.RowHeadersVisible = false;
            dgvDSHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvDSHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDSHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSHoaDon.ShowCellToolTips = false;
            dgvDSHoaDon.Size = new Size(533, 360);
            dgvDSHoaDon.TabIndex = 0;
            dgvDSHoaDon.CellClick += dgvDSHoaDon_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.recycle;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(393, 393);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 33);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa HĐ";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnInHD
            // 
            btnInHD.BackColor = SystemColors.Control;
            btnInHD.Cursor = Cursors.Hand;
            btnInHD.FlatStyle = FlatStyle.Flat;
            btnInHD.Image = Properties.Resources.generateinvoice;
            btnInHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnInHD.Location = new Point(153, 393);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(104, 33);
            btnInHD.TabIndex = 6;
            btnInHD.Text = "In HĐ";
            btnInHD.TextAlign = ContentAlignment.MiddleRight;
            btnInHD.UseVisualStyleBackColor = false;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Control;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.addtocart1;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(17, 393);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 33);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm HĐ";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Cursor = Cursors.Hand;
            dgvChiTietHD.Location = new Point(17, 25);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvChiTietHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvChiTietHD.RowHeadersVisible = false;
            dgvChiTietHD.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvChiTietHD.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTietHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHD.Size = new Size(827, 154);
            dgvChiTietHD.TabIndex = 52;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.OrangeRed;
            lblTieuDe.Location = new Point(341, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(186, 40);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "«HÓA ĐƠN»";
            // 
            // grbDanhSach
            // 
            grbDanhSach.BackColor = SystemColors.Control;
            grbDanhSach.Controls.Add(chbTimKiem);
            grbDanhSach.Controls.Add(txtTimKiem);
            grbDanhSach.Controls.Add(btnHuyHD);
            grbDanhSach.Controls.Add(panel1);
            grbDanhSach.Controls.Add(btnInHD);
            grbDanhSach.Controls.Add(btnXoa);
            grbDanhSach.Controls.Add(btnThem);
            grbDanhSach.Controls.Add(dgvDSHoaDon);
            grbDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSach.Location = new Point(4, 46);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(860, 441);
            grbDanhSach.TabIndex = 0;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH:";
            // 
            // chbTimKiem
            // 
            chbTimKiem.AutoSize = true;
            chbTimKiem.Location = new Point(590, 404);
            chbTimKiem.Name = "chbTimKiem";
            chbTimKiem.Size = new Size(18, 17);
            chbTimKiem.TabIndex = 9;
            chbTimKiem.UseVisualStyleBackColor = true;
            chbTimKiem.CheckedChanged += chbTimKiem_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Enabled = false;
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.Silver;
            txtTimKiem.Location = new Point(614, 399);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(229, 27);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnHuyHD
            // 
            btnHuyHD.BackColor = SystemColors.Control;
            btnHuyHD.Cursor = Cursors.Hand;
            btnHuyHD.FlatStyle = FlatStyle.Flat;
            btnHuyHD.Image = Properties.Resources.cancel2;
            btnHuyHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyHD.Location = new Point(271, 393);
            btnHuyHD.Name = "btnHuyHD";
            btnHuyHD.Size = new Size(108, 33);
            btnHuyHD.TabIndex = 7;
            btnHuyHD.Text = "Hủy HĐ";
            btnHuyHD.TextAlign = ContentAlignment.MiddleRight;
            btnHuyHD.UseVisualStyleBackColor = false;
            btnHuyHD.Click += btnHuyHD_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblThongTin);
            panel1.Controls.Add(lblMaHD);
            panel1.Controls.Add(lblMaKH);
            panel1.Controls.Add(lblNgayLap);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(txtMaNVLap);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(dtpNgayLap);
            panel1.Controls.Add(lblMaNV);
            panel1.Controls.Add(lblTongTT);
            panel1.Controls.Add(txtTongTT);
            panel1.Location = new Point(558, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 360);
            panel1.TabIndex = 27;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThongTin.Location = new Point(98, 36);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(104, 23);
            lblThongTin.TabIndex = 27;
            lblThongTin.Text = "THÔNG TIN";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHD.ForeColor = Color.Blue;
            lblMaHD.Location = new Point(25, 93);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(56, 20);
            lblMaHD.TabIndex = 17;
            lblMaHD.Text = "Mã HĐ";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKH.ForeColor = Color.Blue;
            lblMaKH.Location = new Point(25, 240);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(54, 20);
            lblMaKH.TabIndex = 26;
            lblMaKH.Text = "Mã KH";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayLap.ForeColor = Color.Blue;
            lblNgayLap.Location = new Point(25, 145);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(69, 20);
            lblNgayLap.TabIndex = 21;
            lblNgayLap.Text = "Ngày lập";
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = SystemColors.ControlLightLight;
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Enabled = false;
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(95, 238);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(159, 27);
            txtMaKH.TabIndex = 3;
            // 
            // txtMaNVLap
            // 
            txtMaNVLap.BackColor = SystemColors.ControlLightLight;
            txtMaNVLap.BorderStyle = BorderStyle.FixedSingle;
            txtMaNVLap.Enabled = false;
            txtMaNVLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNVLap.Location = new Point(95, 189);
            txtMaNVLap.Name = "txtMaNVLap";
            txtMaNVLap.Size = new Size(159, 27);
            txtMaNVLap.TabIndex = 2;
            // 
            // txtMaHD
            // 
            txtMaHD.BackColor = SystemColors.ControlLightLight;
            txtMaHD.BorderStyle = BorderStyle.FixedSingle;
            txtMaHD.Enabled = false;
            txtMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHD.Location = new Point(95, 91);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(159, 27);
            txtMaHD.TabIndex = 0;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.CustomFormat = "dd/MM/yyy HH:mm:ss";
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(95, 140);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(159, 27);
            dtpNgayLap.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNV.ForeColor = Color.Blue;
            lblMaNV.Location = new Point(25, 191);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(54, 20);
            lblMaNV.TabIndex = 19;
            lblMaNV.Text = "Mã NV";
            // 
            // lblTongTT
            // 
            lblTongTT.AutoSize = true;
            lblTongTT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTT.ForeColor = Color.Blue;
            lblTongTT.Location = new Point(25, 289);
            lblTongTT.Name = "lblTongTT";
            lblTongTT.Size = new Size(63, 20);
            lblTongTT.TabIndex = 25;
            lblTongTT.Text = "Tổng TT";
            // 
            // txtTongTT
            // 
            txtTongTT.BackColor = SystemColors.ControlLightLight;
            txtTongTT.BorderStyle = BorderStyle.FixedSingle;
            txtTongTT.Enabled = false;
            txtTongTT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTT.Location = new Point(95, 287);
            txtTongTT.Name = "txtTongTT";
            txtTongTT.Size = new Size(159, 27);
            txtTongTT.TabIndex = 4;
            // 
            // grbCTHD
            // 
            grbCTHD.BackColor = SystemColors.Control;
            grbCTHD.Controls.Add(dgvChiTietHD);
            grbCTHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbCTHD.Location = new Point(3, 493);
            grbCTHD.Name = "grbCTHD";
            grbCTHD.Size = new Size(861, 188);
            grbCTHD.TabIndex = 11;
            grbCTHD.TabStop = false;
            grbCTHD.Text = "CHI TIẾT:";
            // 
            // frmDS_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(868, 686);
            Controls.Add(grbCTHD);
            Controls.Add(grbDanhSach);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDS_HoaDon";
            Activated += frmDS_HoaDon_Activated;
            Load += frmDS_HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            grbDanhSach.ResumeLayout(false);
            grbDanhSach.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCTHD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnXoa;
        private Button btnThem;
        private Button btnInHD;
        private DataGridView dgvDSHoaDon;
        private DataGridView dgvChiTietHD;
        private Label lblTieuDe;
        private GroupBox grbDanhSach;
        private GroupBox grbCTHD;
        private TextBox txtMaKH;
        private Label lblMaKH;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private Label lblMaNV;
        private TextBox txtTongTT;
        private Label lblTongTT;
        private TextBox txtMaNVLap;
        private Label lblMaHD;
        private TextBox txtMaHD;
        private Panel panel1;
        private Label lblThongTin;
        private Button btnHuyHD;
        private CheckBox chbTimKiem;
        private TextBox txtTimKiem;
    }
}