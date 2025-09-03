namespace DoAnCSharp
{
    partial class frmDS_HangHoa
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
            grbDanhSach = new GroupBox();
            chbTimKiem = new CheckBox();
            txtTimKiem = new TextBox();
            pnlThongTin = new Panel();
            lblMaHH = new Label();
            lblTenHH = new Label();
            txtHangSX = new TextBox();
            label5 = new Label();
            txtGiaBan = new TextBox();
            cboLoaiHH = new ComboBox();
            txtMaHH = new TextBox();
            lblGiaBan = new Label();
            lblLoaiHH = new Label();
            txtTenHH = new TextBox();
            lblHangSX = new Label();
            lblSLTon = new Label();
            txtSLTon = new TextBox();
            btnLuu = new Button();
            dgvDSHangHoa = new DataGridView();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnHuy = new Button();
            lblTitle = new Label();
            grbDanhSach.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoa).BeginInit();
            SuspendLayout();
            // 
            // grbDanhSach
            // 
            grbDanhSach.BackColor = SystemColors.Control;
            grbDanhSach.Controls.Add(chbTimKiem);
            grbDanhSach.Controls.Add(txtTimKiem);
            grbDanhSach.Controls.Add(pnlThongTin);
            grbDanhSach.Controls.Add(btnLuu);
            grbDanhSach.Controls.Add(dgvDSHangHoa);
            grbDanhSach.Controls.Add(btnXoa);
            grbDanhSach.Controls.Add(btnThem);
            grbDanhSach.Controls.Add(btnSua);
            grbDanhSach.Controls.Add(btnHuy);
            grbDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSach.Location = new Point(5, 49);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(989, 466);
            grbDanhSach.TabIndex = 23;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH";
            // 
            // chbTimKiem
            // 
            chbTimKiem.AutoSize = true;
            chbTimKiem.Location = new Point(719, 432);
            chbTimKiem.Name = "chbTimKiem";
            chbTimKiem.Size = new Size(18, 17);
            chbTimKiem.TabIndex = 27;
            chbTimKiem.UseVisualStyleBackColor = true;
            chbTimKiem.CheckedChanged += chbTimKiem_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Enabled = false;
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.Silver;
            txtTimKiem.Location = new Point(743, 427);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(229, 27);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = SystemColors.Info;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Controls.Add(lblMaHH);
            pnlThongTin.Controls.Add(lblTenHH);
            pnlThongTin.Controls.Add(txtHangSX);
            pnlThongTin.Controls.Add(label5);
            pnlThongTin.Controls.Add(txtGiaBan);
            pnlThongTin.Controls.Add(cboLoaiHH);
            pnlThongTin.Controls.Add(txtMaHH);
            pnlThongTin.Controls.Add(lblGiaBan);
            pnlThongTin.Controls.Add(lblLoaiHH);
            pnlThongTin.Controls.Add(txtTenHH);
            pnlThongTin.Controls.Add(lblHangSX);
            pnlThongTin.Controls.Add(lblSLTon);
            pnlThongTin.Controls.Add(txtSLTon);
            pnlThongTin.Location = new Point(533, 23);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(439, 390);
            pnlThongTin.TabIndex = 24;
            // 
            // lblMaHH
            // 
            lblMaHH.AutoSize = true;
            lblMaHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHH.ForeColor = Color.Blue;
            lblMaHH.Location = new Point(19, 90);
            lblMaHH.Name = "lblMaHH";
            lblMaHH.Size = new Size(49, 20);
            lblMaHH.TabIndex = 19;
            lblMaHH.Text = "Mã số";
            // 
            // lblTenHH
            // 
            lblTenHH.AutoSize = true;
            lblTenHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenHH.ForeColor = Color.Blue;
            lblTenHH.Location = new Point(19, 131);
            lblTenHH.Name = "lblTenHH";
            lblTenHH.Size = new Size(69, 20);
            lblTenHH.TabIndex = 20;
            lblTenHH.Text = "Tên hàng";
            // 
            // txtHangSX
            // 
            txtHangSX.BackColor = SystemColors.ControlLightLight;
            txtHangSX.BorderStyle = BorderStyle.FixedSingle;
            txtHangSX.Enabled = false;
            txtHangSX.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtHangSX.Location = new Point(125, 235);
            txtHangSX.Name = "txtHangSX";
            txtHangSX.Size = new Size(288, 25);
            txtHangSX.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(166, 39);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 17;
            label5.Text = "THÔNG TIN";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = SystemColors.ControlLightLight;
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Enabled = false;
            txtGiaBan.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGiaBan.Location = new Point(125, 274);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(288, 25);
            txtGiaBan.TabIndex = 4;
            // 
            // cboLoaiHH
            // 
            cboLoaiHH.BackColor = SystemColors.ControlLightLight;
            cboLoaiHH.DisplayMember = "Nam";
            cboLoaiHH.Enabled = false;
            cboLoaiHH.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cboLoaiHH.FormattingEnabled = true;
            cboLoaiHH.Items.AddRange(new object[] { "Xe máy", "Phụ tùng" });
            cboLoaiHH.Location = new Point(125, 193);
            cboLoaiHH.Name = "cboLoaiHH";
            cboLoaiHH.Size = new Size(287, 25);
            cboLoaiHH.TabIndex = 3;
            cboLoaiHH.SelectedIndexChanged += cboLoaiHH_SelectedIndexChanged;
            // 
            // txtMaHH
            // 
            txtMaHH.BackColor = SystemColors.ControlLightLight;
            txtMaHH.BorderStyle = BorderStyle.FixedSingle;
            txtMaHH.Enabled = false;
            txtMaHH.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaHH.Location = new Point(125, 90);
            txtMaHH.Name = "txtMaHH";
            txtMaHH.Size = new Size(288, 25);
            txtMaHH.TabIndex = 0;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiaBan.ForeColor = Color.Blue;
            lblGiaBan.Location = new Point(19, 276);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(60, 20);
            lblGiaBan.TabIndex = 16;
            lblGiaBan.Text = "Giá bán";
            // 
            // lblLoaiHH
            // 
            lblLoaiHH.AutoSize = true;
            lblLoaiHH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiHH.ForeColor = Color.Blue;
            lblLoaiHH.Location = new Point(19, 195);
            lblLoaiHH.Name = "lblLoaiHH";
            lblLoaiHH.Size = new Size(74, 20);
            lblLoaiHH.TabIndex = 2;
            lblLoaiHH.Text = "Loại hàng";
            // 
            // txtTenHH
            // 
            txtTenHH.BackColor = SystemColors.ControlLightLight;
            txtTenHH.BorderStyle = BorderStyle.FixedSingle;
            txtTenHH.Enabled = false;
            txtTenHH.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenHH.Location = new Point(125, 131);
            txtTenHH.Multiline = true;
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(288, 45);
            txtTenHH.TabIndex = 1;
            // 
            // lblHangSX
            // 
            lblHangSX.AutoSize = true;
            lblHangSX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHangSX.ForeColor = Color.Blue;
            lblHangSX.Location = new Point(19, 235);
            lblHangSX.Name = "lblHangSX";
            lblHangSX.Size = new Size(103, 20);
            lblHangSX.TabIndex = 3;
            lblHangSX.Text = "Hãng sản xuất";
            // 
            // lblSLTon
            // 
            lblSLTon.AutoSize = true;
            lblSLTon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLTon.ForeColor = Color.Blue;
            lblSLTon.Location = new Point(19, 317);
            lblSLTon.Name = "lblSLTon";
            lblSLTon.Size = new Size(95, 20);
            lblSLTon.TabIndex = 7;
            lblSLTon.Text = "Số lượng tồn";
            // 
            // txtSLTon
            // 
            txtSLTon.BackColor = SystemColors.ControlLightLight;
            txtSLTon.BorderStyle = BorderStyle.FixedSingle;
            txtSLTon.Enabled = false;
            txtSLTon.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSLTon.Location = new Point(125, 315);
            txtSLTon.Name = "txtSLTon";
            txtSLTon.Size = new Size(288, 25);
            txtSLTon.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Enabled = false;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = Properties.Resources.update21;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(424, 421);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 33);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Update";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // dgvDSHangHoa
            // 
            dgvDSHangHoa.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHangHoa.Cursor = Cursors.Hand;
            dgvDSHangHoa.Location = new Point(17, 23);
            dgvDSHangHoa.Name = "dgvDSHangHoa";
            dgvDSHangHoa.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDSHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDSHangHoa.RowHeadersVisible = false;
            dgvDSHangHoa.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvDSHangHoa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDSHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSHangHoa.ShowCellToolTips = false;
            dgvDSHangHoa.Size = new Size(510, 390);
            dgvDSHangHoa.TabIndex = 9;
            dgvDSHangHoa.CellClick += dgvDSHangHoa_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Enabled = false;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.recycle;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(132, 421);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 33);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Control;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Enabled = false;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(229, 421);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 33);
            btnSua.TabIndex = 12;
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
            btnHuy.Location = new Point(327, 421);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(82, 33);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.OrangeRed;
            lblTitle.Location = new Point(323, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(352, 40);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "«XE MÁY VÀ PHỤ TÙNG»";
            // 
            // frmDS_HangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(997, 519);
            Controls.Add(grbDanhSach);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDS_HangHoa";
            Activated += frmDS_HangHoa_Activated;
            Load += frmDS_HangHoa_Load;
            grbDanhSach.ResumeLayout(false);
            grbDanhSach.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLuuY;
        private GroupBox grbDanhSach;
        private Label label1;
        private Label label7;
        private Label label2;
        private Button btnLuu;
        private DataGridView dgvDSHangHoa;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnHuy;
        private Label lblTitle;
        private Panel pnlThongTin;
        private Label lblMaHH;
        private Label lblTenHH;
        private TextBox txtHangSX;
        private Label label5;
        private TextBox txtGiaBan;
        private ComboBox cboLoaiHH;
        private TextBox txtMaHH;
        private Label lblGiaBan;
        private Label lblLoaiHH;
        private TextBox txtTenHH;
        private Label lblHangSX;
        private Label lblSLTon;
        private TextBox txtSLTon;
        private CheckBox chbTimKiem;
        private TextBox txtTimKiem;
    }
}