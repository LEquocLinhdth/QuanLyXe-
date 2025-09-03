using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class frmDS_HangHoa : Form
    {
        public frmDS_HangHoa()
        {
            InitializeComponent();
        }
        int IndexXE, IndexPT;
        bool them;
        Modify modify = new Modify();

        private string generateMAXE()
        {
            IndexXE = Program.loadIndex(Program.filePathIndex("MaXE.txt"));
            string newMAXE = $"XE{IndexXE:D5}";
            return newMAXE;
        }
        private string generateMAPT()
        {
            IndexPT = Program.loadIndex(Program.filePathIndex("MaPT.txt"));
            string newMAPT = $"PT{IndexPT:D5}";
            return newMAPT;
        }

        public void enableTextBox()
        {
            txtTenHH.Enabled = true;
            cboLoaiHH.Enabled = true;
            txtHangSX.Enabled = true;
            txtGiaBan.Enabled = true;
            txtSLTon.Enabled = true;
        }
        public void clear_disableTextBox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            cboLoaiHH.Text = string.Empty;
            txtHangSX.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtSLTon.Text = string.Empty;


            txtTenHH.Enabled = false;
            cboLoaiHH.Enabled = false;
            txtHangSX.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSLTon.Enabled = false;
        }
        public bool checkTextBox()
        {
            if (txtMaHH.Text == "" || cboLoaiHH.Text == "" || txtTenHH.Text == "" || txtGiaBan.Text == "" || txtHangSX.Text == "" || txtHangSX.Text == "")
                return false;
            else
                return true;
        }
        private void frmDS_HangHoa_Load(object sender, EventArgs e)
        {

            //logic
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            clear_disableTextBox();
            if (chbTimKiem.Checked == false)
                dgvDSHangHoa.DataSource = modify.Table("Select * from HANGHOA");
            else
                dgvDSHangHoa.DataSource = modify.Table("Select * from HANGHOA where MAHH like '" + txtTimKiem.Text + "%' OR TENHH like N'%" + txtTimKiem.Text + "%' or HANGSX like '%" + txtTimKiem.Text + "%'");

            dgvDSHangHoa.Columns["MAHH"].HeaderText = "Mã số";
            dgvDSHangHoa.Columns["MAHH"].Width = 85;
            dgvDSHangHoa.Columns["TENHH"].HeaderText = "Tên hàng";
            dgvDSHangHoa.Columns["TENHH"].Width = 300;
            dgvDSHangHoa.Columns["LOAIHH"].HeaderText = "Loại hàng";
            dgvDSHangHoa.Columns["LOAIHH"].Width = 100;
            dgvDSHangHoa.Columns["HANGSX"].HeaderText = "Hãng sản xuất";
            dgvDSHangHoa.Columns["HANGSX"].Width = 150;
            dgvDSHangHoa.Columns["GIABAN"].HeaderText = "Giá bán";
            dgvDSHangHoa.Columns["GIABAN"].Width = 130;
            dgvDSHangHoa.Columns["SLTON"].HeaderText = "Tồn";

            dgvDSHangHoa.ClearSelection();
            dgvDSHangHoa.Enabled = true;

        }

        private void cboPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmDS_HangHoa_Load(sender, e);
        }

        private void dgvDSHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDSHangHoa.Rows.Count - 1 || e.RowIndex == -1)
            {
                frmDS_HangHoa_Load(sender, e);
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                txtMaHH.Text = dgvDSHangHoa.SelectedCells[0].Value.ToString();
                txtTenHH.Text = dgvDSHangHoa.SelectedCells[1].Value.ToString();
                cboLoaiHH.Text = dgvDSHangHoa.SelectedCells[2].Value.ToString();
                txtHangSX.Text = dgvDSHangHoa.SelectedCells[3].Value.ToString();
                txtGiaBan.Text = dgvDSHangHoa.SelectedCells[4].Value.ToString();
                txtSLTon.Text = dgvDSHangHoa.SelectedCells[5].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            //logic
            clear_disableTextBox();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            enableTextBox();
            dgvDSHangHoa.Enabled = false;
            dgvDSHangHoa.ClearSelection();
            txtTenHH.Focus();
            txtSLTon.Text = "0";
            txtSLTon.Enabled = false;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            //logic
            btnSua.Enabled = true;
            enableTextBox();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dgvDSHangHoa.Enabled = false;
            txtTenHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + txtMaHH.Text + " không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = @"Delete from HANGHOA where MAHH = " + "'" + txtMaHH.Text + "'";
                    modify.Command(query);
                    frmDS_HangHoa_Load(sender, e);
                    MessageBox.Show("Xóa thành công", "Hệ thống");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin hàng hóa còn giá trị, không thể xóa lúc này!", "Hệ thống");
            }
        }

        private void cboLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (them == false)
                return;
            if (cboLoaiHH.SelectedIndex == 0)
                txtMaHH.Text = generateMAXE();
            else
                txtMaHH.Text = generateMAPT();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDS_HangHoa_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true && checkTextBox())
            {
                string query = "Insert into HANGHOA values ('" + txtMaHH.Text + "', N'" + txtTenHH.Text + "', N'" + cboLoaiHH.Text + "', N'" + txtHangSX.Text + "', '" + txtGiaBan.Text + "', '" + txtSLTon.Text + "')";
                try
                {
                    modify.Command(query);
                    frmDS_HangHoa_Load(sender, e);
                    MessageBox.Show("Thêm thành công", "Thông báo!");
                    if (cboLoaiHH.SelectedIndex == 0)
                    {
                        IndexXE++;
                        Program.saveIndex(Program.filePathIndex("MaXE.txt"), IndexXE);
                    }
                    else
                    {
                        IndexPT++;
                        Program.saveIndex(Program.filePathIndex("MaPT.txt"), IndexPT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                    return;
                }
            }
            else if (them == false && checkTextBox())
            {
                string query = "Update HANGHOA Set TENHH = N'" + txtTenHH.Text + "', LOAIHH = N'" + cboLoaiHH.Text + "', HANGSX = N'" + txtHangSX.Text + "', GIABAN = '" + txtGiaBan.Text + "', SLTON = '" + txtSLTon.Text + "'";
                query += " where MAHH = '" + txtMaHH.Text + "'";
                try
                {
                    modify.Command(query);
                    frmDS_HangHoa_Load(sender, e);
                    MessageBox.Show("Sửa thành công", "Hệ thống");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Hệ thống");
                return;
            }
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimKiem.Checked == false)
            {
                frmDS_HangHoa_Load(sender, e);
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Enabled = false;
            }
            else
            {
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Clear();
                txtTimKiem.Enabled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            frmDS_HangHoa_Load(sender, e);
        }

        private void frmDS_HangHoa_Activated(object sender, EventArgs e)
        {
            dgvDSHangHoa.ClearSelection();
        }
    }
}
