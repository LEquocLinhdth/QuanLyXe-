

namespace DoAnCSharp
{
    public partial class frmHT_DangNhap : Form
    {
        public frmHT_DangNhap()
        {
            InitializeComponent();
        }

        private void cboxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxHienMK.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }
    }

}
