namespace DoAnCSharp
{
    partial class frmHT_LapTaiKhoan
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
            btnTaoTK = new Button();
            chbQuyenQT = new CheckBox();
            cboChonNV = new ComboBox();
            picSignUp = new PictureBox();
            btnHuy = new Button();
            lblChonNV = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            ((System.ComponentModel.ISupportInitialize)picSignUp).BeginInit();
            SuspendLayout();
            // 
            // btnTaoTK
            // 
            btnTaoTK.BackColor = Color.FromArgb(255, 192, 192);
            btnTaoTK.FlatStyle = FlatStyle.Flat;
            btnTaoTK.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoTK.ForeColor = Color.FromArgb(0, 0, 192);
            btnTaoTK.Location = new Point(90, 357);
            btnTaoTK.Name = "btnTaoTK";
            btnTaoTK.Size = new Size(113, 47);
            btnTaoTK.TabIndex = 4;
            btnTaoTK.Text = "Tạo";
            btnTaoTK.UseVisualStyleBackColor = false;
            btnTaoTK.Click += btnTaoTK_Click;
            // 
            // chbQuyenQT
            // 
            chbQuyenQT.AutoSize = true;
            chbQuyenQT.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbQuyenQT.Location = new Point(42, 316);
            chbQuyenQT.Name = "chbQuyenQT";
            chbQuyenQT.Size = new Size(134, 22);
            chbQuyenQT.TabIndex = 3;
            chbQuyenQT.Text = "Quyền quản trị";
            chbQuyenQT.UseVisualStyleBackColor = true;
            // 
            // cboChonNV
            // 
            cboChonNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChonNV.FlatStyle = FlatStyle.Popup;
            cboChonNV.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboChonNV.FormattingEnabled = true;
            cboChonNV.Location = new Point(42, 166);
            cboChonNV.Name = "cboChonNV";
            cboChonNV.Size = new Size(216, 27);
            cboChonNV.TabIndex = 0;
            // 
            // picSignUp
            // 
            picSignUp.Image = Properties.Resources.signup;
            picSignUp.Location = new Point(102, 30);
            picSignUp.Name = "picSignUp";
            picSignUp.Size = new Size(100, 100);
            picSignUp.SizeMode = PictureBoxSizeMode.StretchImage;
            picSignUp.TabIndex = 25;
            picSignUp.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveCaption;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(254, -5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(51, 50);
            btnHuy.TabIndex = 26;
            btnHuy.Text = "⨉";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblChonNV
            // 
            lblChonNV.AutoSize = true;
            lblChonNV.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChonNV.ForeColor = Color.FromArgb(0, 0, 192);
            lblChonNV.Location = new Point(39, 149);
            lblChonNV.Name = "lblChonNV";
            lblChonNV.Size = new Size(110, 17);
            lblChonNV.TabIndex = 27;
            lblChonNV.Text = "Chọn nhân viên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.Info;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(42, 276);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(216, 33);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = SystemColors.Info;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(42, 221);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(216, 33);
            txtTaiKhoan.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(39, 258);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(78, 20);
            lblMatKhau.TabIndex = 31;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaiKhoan.Location = new Point(39, 203);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(82, 20);
            lblTaiKhoan.TabIndex = 29;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // frmHT_LapTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(299, 429);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblChonNV);
            Controls.Add(btnHuy);
            Controls.Add(picSignUp);
            Controls.Add(btnTaoTK);
            Controls.Add(chbQuyenQT);
            Controls.Add(cboChonNV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHT_LapTaiKhoan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmThemTaiKhoan";
            Load += frmHT_LapTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)picSignUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTaoTK;
        private CheckBox chbQuyenQT;
        private ComboBox cboChonNV;
        private PictureBox picSignUp;
        public Button btnHuy;
        private Label lblChonNV;
        public TextBox txtMatKhau;
        public TextBox txtTaiKhoan;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
    }
}