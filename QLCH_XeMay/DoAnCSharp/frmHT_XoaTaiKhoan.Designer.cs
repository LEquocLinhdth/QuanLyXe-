namespace DoAnCSharp
{
    partial class frmHT_XoaTaiKhoan
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
            btnHuy = new Button();
            cboChonNV = new ComboBox();
            btnXoaTK = new Button();
            lblChonNV = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveCaption;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(223, -6);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(51, 50);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "⨉";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // cboChonNV
            // 
            cboChonNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChonNV.FlatStyle = FlatStyle.Popup;
            cboChonNV.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboChonNV.FormattingEnabled = true;
            cboChonNV.Location = new Point(65, 74);
            cboChonNV.Name = "cboChonNV";
            cboChonNV.Size = new Size(136, 27);
            cboChonNV.TabIndex = 0;
            // 
            // btnXoaTK
            // 
            btnXoaTK.BackColor = Color.FromArgb(255, 192, 192);
            btnXoaTK.FlatStyle = FlatStyle.Flat;
            btnXoaTK.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaTK.ForeColor = Color.FromArgb(0, 0, 192);
            btnXoaTK.Location = new Point(77, 127);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new Size(113, 47);
            btnXoaTK.TabIndex = 1;
            btnXoaTK.Text = "Xóa";
            btnXoaTK.UseVisualStyleBackColor = false;
            btnXoaTK.Click += btnXoaTK_Click;
            // 
            // lblChonNV
            // 
            lblChonNV.AutoSize = true;
            lblChonNV.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChonNV.ForeColor = Color.FromArgb(0, 0, 192);
            lblChonNV.Location = new Point(79, 54);
            lblChonNV.Name = "lblChonNV";
            lblChonNV.Size = new Size(110, 17);
            lblChonNV.TabIndex = 30;
            lblChonNV.Text = "Chọn nhân viên";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 20);
            lblTitle.TabIndex = 31;
            lblTitle.Text = "Xóa tài khoản";
            // 
            // frmHT_XoaTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(267, 206);
            Controls.Add(lblTitle);
            Controls.Add(lblChonNV);
            Controls.Add(btnXoaTK);
            Controls.Add(cboChonNV);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHT_XoaTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmHT_XoaTaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnHuy;
        private ComboBox cboChonNV;
        private Button btnXoaTK;
        private Label lblChonNV;
        private Label lblTitle;
    }
}