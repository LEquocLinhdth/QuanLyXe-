namespace DoAnCSharp
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            menuStrip1 = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            htDangNhap = new ToolStripMenuItem();
            htThem = new ToolStripMenuItem();
            htXoa = new ToolStripMenuItem();
            htDoiMK = new ToolStripMenuItem();
            htDangXuat = new ToolStripMenuItem();
            menuDanhSach = new ToolStripMenuItem();
            dsKhachHang = new ToolStripMenuItem();
            dsNhanVien = new ToolStripMenuItem();
            dsHangHoa = new ToolStripMenuItem();
            dsHoaDon = new ToolStripMenuItem();
            dsNhaCungCap = new ToolStripMenuItem();
            menuNghiepVu = new ToolStripMenuItem();
            nvLapHoaDon = new ToolStripMenuItem();
            nvLapPhieuNhap = new ToolStripMenuItem();
            menuThongKe = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            sttUser = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            sttLoggedTime = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHeThong, menuDanhSach, menuNghiepVu, menuThongKe, menuHelp });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1220, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.BackColor = SystemColors.GradientActiveCaption;
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { htDangNhap, htThem, htXoa, htDoiMK, htDangXuat });
            menuHeThong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuHeThong.ForeColor = Color.DarkBlue;
            menuHeThong.Image = Properties.Resources.system1;
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(121, 27);
            menuHeThong.Text = "Hệ thống";
            // 
            // htDangNhap
            // 
            htDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htDangNhap.Image = Properties.Resources.login2;
            htDangNhap.Name = "htDangNhap";
            htDangNhap.Size = new Size(232, 26);
            htDangNhap.Text = "Đăng nhập";
            htDangNhap.Click += htDangNhap_Click;
            // 
            // htThem
            // 
            htThem.Enabled = false;
            htThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htThem.Image = Properties.Resources.adduser;
            htThem.Name = "htThem";
            htThem.Size = new Size(232, 26);
            htThem.Text = "Thêm người dùng";
            htThem.Click += htThem_Click;
            // 
            // htXoa
            // 
            htXoa.Enabled = false;
            htXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htXoa.Image = Properties.Resources.delete_user;
            htXoa.Name = "htXoa";
            htXoa.Size = new Size(232, 26);
            htXoa.Text = "Xóa người dùng";
            htXoa.Click += htXoa_Click;
            // 
            // htDoiMK
            // 
            htDoiMK.Enabled = false;
            htDoiMK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htDoiMK.Image = Properties.Resources.reset_password;
            htDoiMK.Name = "htDoiMK";
            htDoiMK.Size = new Size(232, 26);
            htDoiMK.Text = "Đổi mật khẩu";
            htDoiMK.Click += htDoiMK_Click;
            // 
            // htDangXuat
            // 
            htDangXuat.Enabled = false;
            htDangXuat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htDangXuat.Image = Properties.Resources.log_out;
            htDangXuat.Name = "htDangXuat";
            htDangXuat.Size = new Size(232, 26);
            htDangXuat.Text = "Đăng xuất";
            htDangXuat.Click += htDangXuat_Click;
            // 
            // menuDanhSach
            // 
            menuDanhSach.DropDownItems.AddRange(new ToolStripItem[] { dsKhachHang, dsNhanVien, dsHangHoa, dsHoaDon, dsNhaCungCap });
            menuDanhSach.Enabled = false;
            menuDanhSach.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuDanhSach.ForeColor = Color.DarkBlue;
            menuDanhSach.Image = Properties.Resources.files;
            menuDanhSach.Name = "menuDanhSach";
            menuDanhSach.Size = new Size(135, 27);
            menuDanhSach.Text = "Danh sách ";
            // 
            // dsKhachHang
            // 
            dsKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsKhachHang.Image = Properties.Resources.client;
            dsKhachHang.Name = "dsKhachHang";
            dsKhachHang.Size = new Size(249, 26);
            dsKhachHang.Text = "Khách hàng";
            dsKhachHang.Click += dsKhachHang_Click;
            // 
            // dsNhanVien
            // 
            dsNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsNhanVien.Image = Properties.Resources.staff;
            dsNhanVien.Name = "dsNhanVien";
            dsNhanVien.Size = new Size(249, 26);
            dsNhanVien.Text = "Nhân viên";
            dsNhanVien.Click += dsNhanVien_Click;
            // 
            // dsHangHoa
            // 
            dsHangHoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsHangHoa.Image = Properties.Resources.motorcycle;
            dsHangHoa.Name = "dsHangHoa";
            dsHangHoa.Size = new Size(249, 26);
            dsHangHoa.Text = "Xe máy và phụ tùng";
            dsHangHoa.Click += dsXeMay_Click;
            // 
            // dsHoaDon
            // 
            dsHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsHoaDon.Image = Properties.Resources.invoice;
            dsHoaDon.Name = "dsHoaDon";
            dsHoaDon.Size = new Size(249, 26);
            dsHoaDon.Text = "Hóa đơn";
            dsHoaDon.Click += dsHoaDon_Click;
            // 
            // dsNhaCungCap
            // 
            dsNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsNhaCungCap.Image = Properties.Resources.supplier;
            dsNhaCungCap.Name = "dsNhaCungCap";
            dsNhaCungCap.Size = new Size(249, 26);
            dsNhaCungCap.Text = "Nhà cung cấp";
            dsNhaCungCap.Click += dsNhaCungCap_Click;
            // 
            // menuNghiepVu
            // 
            menuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { nvLapHoaDon, nvLapPhieuNhap });
            menuNghiepVu.Enabled = false;
            menuNghiepVu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuNghiepVu.ForeColor = Color.DarkBlue;
            menuNghiepVu.Image = Properties.Resources.working;
            menuNghiepVu.Name = "menuNghiepVu";
            menuNghiepVu.Size = new Size(128, 27);
            menuNghiepVu.Text = "Nghiệp vụ";
            // 
            // nvLapHoaDon
            // 
            nvLapHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nvLapHoaDon.Image = Properties.Resources.generateinvoice;
            nvLapHoaDon.Name = "nvLapHoaDon";
            nvLapHoaDon.Size = new Size(214, 26);
            nvLapHoaDon.Text = "Lập hóa đơn";
            nvLapHoaDon.Click += nvLapHoaDon_Click_1;
            // 
            // nvLapPhieuNhap
            // 
            nvLapPhieuNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nvLapPhieuNhap.Image = Properties.Resources.inventory;
            nvLapPhieuNhap.Name = "nvLapPhieuNhap";
            nvLapPhieuNhap.Size = new Size(214, 26);
            nvLapPhieuNhap.Text = "Lập phiếu nhập";
            nvLapPhieuNhap.Click += nvLapPhieuNhap_Click;
            // 
            // menuThongKe
            // 
            menuThongKe.Enabled = false;
            menuThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuThongKe.ForeColor = Color.DarkBlue;
            menuThongKe.Image = Properties.Resources.statistical;
            menuThongKe.Name = "menuThongKe";
            menuThongKe.Size = new Size(206, 27);
            menuThongKe.Text = "Báo cáo - Thống kê";
            menuThongKe.Click += menuThongKe_Click;
            // 
            // menuHelp
            // 
            menuHelp.ForeColor = Color.DarkBlue;
            menuHelp.Image = Properties.Resources.help;
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(80, 24);
            menuHelp.Text = "Help";
            menuHelp.Click += helpToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.GradientActiveCaption;
            statusStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sttUser, toolStripStatusLabel2, sttLoggedTime });
            statusStrip1.Location = new Point(0, 904);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1220, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // sttUser
            // 
            sttUser.Name = "sttUser";
            sttUser.Size = new Size(56, 23);
            sttUser.Text = "User:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(14, 23);
            toolStripStatusLabel2.Text = "|";
            // 
            // sttLoggedTime
            // 
            sttLoggedTime.Name = "sttLoggedTime";
            sttLoggedTime.Size = new Size(125, 23);
            sttLoggedTime.Text = "Logged Time:";
            // 
            // frmHeThong
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.background_last_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1220, 933);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ CỬA HÀNG BÁN XE MÁY";
            WindowState = FormWindowState.Maximized;
            Load += frmHeThong_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuDanhSach;
        private ToolStripMenuItem dsKhachHang;
        private ToolStripMenuItem menuNghiepVu;
        private ToolStripMenuItem htDangNhap;
        private ToolStripMenuItem dsNhanVien;
        private ToolStripMenuItem dsHangHoa;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sttUser;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel sttLoggedTime;
        private ToolStripMenuItem htThem;
        private ToolStripMenuItem htXoa;
        private ToolStripMenuItem htDoiMK;
        private ToolStripMenuItem htDangXuat;
        private ToolStripMenuItem nvLapHoaDon;
        private ToolStripMenuItem menuThongKe;
        private ToolStripMenuItem nvLapPhieuNhap;
        private ToolStripMenuItem dsHoaDon;
        private ToolStripMenuItem dsNhaCungCap;
        private ToolStripMenuItem menuHelp;
    }
}