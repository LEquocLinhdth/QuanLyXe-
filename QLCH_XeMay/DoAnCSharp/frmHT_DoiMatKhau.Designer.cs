namespace DoAnCSharp
{
    partial class frmHT_DoiMatKhau
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
            picChangePass = new PictureBox();
            btnHuy = new Button();
            txtMatKhauCu = new TextBox();
            txtTaiKhoan = new TextBox();
            lblMatKhauCu = new Label();
            lblTaiKhoan = new Label();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtXacNhan = new TextBox();
            lblXacNhan = new Label();
            btnDoiMK = new Button();
            ((System.ComponentModel.ISupportInitialize)picChangePass).BeginInit();
            SuspendLayout();
            // 
            // picChangePass
            // 
            picChangePass.Image = Properties.Resources.password_code;
            picChangePass.Location = new Point(113, 28);
            picChangePass.Name = "picChangePass";
            picChangePass.Size = new Size(100, 100);
            picChangePass.SizeMode = PictureBoxSizeMode.StretchImage;
            picChangePass.TabIndex = 0;
            picChangePass.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveCaption;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(271, -3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(51, 50);
            btnHuy.TabIndex = 27;
            btnHuy.Text = "⨉";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BackColor = SystemColors.Info;
            txtMatKhauCu.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauCu.Location = new Point(43, 217);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(233, 33);
            txtMatKhauCu.TabIndex = 34;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = SystemColors.ControlLight;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(43, 161);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(233, 33);
            txtTaiKhoan.TabIndex = 32;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhauCu.Location = new Point(40, 199);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(100, 20);
            lblMatKhauCu.TabIndex = 35;
            lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaiKhoan.Location = new Point(40, 143);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(82, 20);
            lblTaiKhoan.TabIndex = 33;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BackColor = SystemColors.Info;
            txtMatKhauMoi.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauMoi.Location = new Point(43, 273);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(233, 33);
            txtMatKhauMoi.TabIndex = 36;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhauMoi.Location = new Point(40, 255);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(111, 20);
            lblMatKhauMoi.TabIndex = 37;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtXacNhan
            // 
            txtXacNhan.BackColor = SystemColors.Info;
            txtXacNhan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtXacNhan.Location = new Point(43, 329);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(233, 33);
            txtXacNhan.TabIndex = 38;
            txtXacNhan.UseSystemPasswordChar = true;
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblXacNhan.Location = new Point(40, 311);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(183, 20);
            lblXacNhan.TabIndex = 39;
            lblXacNhan.Text = "Xác nhận mật khẩu mới";
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = Color.FromArgb(255, 192, 192);
            btnDoiMK.FlatStyle = FlatStyle.Flat;
            btnDoiMK.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiMK.ForeColor = Color.FromArgb(0, 0, 192);
            btnDoiMK.Location = new Point(94, 383);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(130, 47);
            btnDoiMK.TabIndex = 40;
            btnDoiMK.Text = "Đổi";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnTaoTK_Click;
            // 
            // frmHT_DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(317, 458);
            Controls.Add(btnDoiMK);
            Controls.Add(txtXacNhan);
            Controls.Add(lblXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhauCu);
            Controls.Add(lblTaiKhoan);
            Controls.Add(btnHuy);
            Controls.Add(picChangePass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHT_DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHT_DoiMatKhau";
            Load += frmHT_DoiMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)picChangePass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChangePass;
        public Button btnHuy;
        public TextBox txtMatKhauCu;
        public TextBox txtTaiKhoan;
        private Label lblMatKhauCu;
        private Label lblTaiKhoan;
        public TextBox txtMatKhauMoi;
        private Label lblMatKhauMoi;
        public TextBox txtXacNhan;
        private Label lblXacNhan;
        private Button btnDoiMK;
    }
}