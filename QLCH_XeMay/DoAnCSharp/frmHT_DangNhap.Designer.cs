namespace DoAnCSharp
{
    partial class frmHT_DangNhap
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
            label1 = new Label();
            lblMK = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuy = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            picLogin = new PictureBox();
            cboxHienMK = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 149);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMK.Location = new Point(48, 204);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(78, 20);
            lblMK.TabIndex = 1;
            lblMK.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(51, 167);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(216, 33);
            txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(51, 222);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(216, 33);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 192);
            btnDangNhap.DialogResult = DialogResult.OK;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(50, 294);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(218, 41);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveCaption;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(268, -4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(51, 50);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "⨉";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(242, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(242, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // picLogin
            // 
            picLogin.BackgroundImageLayout = ImageLayout.None;
            picLogin.Image = Properties.Resources.loginlogo;
            picLogin.Location = new Point(110, 34);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(100, 100);
            picLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogin.TabIndex = 9;
            picLogin.TabStop = false;
            // 
            // cboxHienMK
            // 
            cboxHienMK.AutoSize = true;
            cboxHienMK.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboxHienMK.Location = new Point(50, 259);
            cboxHienMK.Name = "cboxHienMK";
            cboxHienMK.Size = new Size(125, 22);
            cboxHienMK.TabIndex = 2;
            cboxHienMK.Text = "Hiện mật khẩu";
            cboxHienMK.UseVisualStyleBackColor = true;
            cboxHienMK.CheckedChanged += cboxHienMK_CheckedChanged;
            // 
            // frmHT_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(316, 374);
            Controls.Add(cboxHienMK);
            Controls.Add(picLogin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMK);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHT_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMK;
        public TextBox txtTaiKhoan;
        public TextBox txtMatKhau;
        public Button btnDangNhap;
        public Button btnHuy;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picLogin;
        private CheckBox cboxHienMK;
    }
}