using System;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmLogin : Form
    {
        private readonly NhanVienBUS _bus = new NhanVienBUS();

        public frmLogin()
        {
            InitializeComponent(); 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVienDTO nv = _bus.DangNhap(taiKhoan, matKhau);
                if (nv == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                this.Hide();
                var frm = new frmMain(nv);
                frm.ShowDialog();
                
                if (frm.IsLogout)
                {
                    this.Show();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(
                    $"Không thể kết nối SQL Server!\n\n" +
                    $"Kiểm tra:\n" +
                    $"1. SQL Server (SQLEXPRESS) đang chạy chưa?\n" +
                    $"2. Database 'QuanLyRapPhim' đã được tạo chưa?\n\n" +
                    $"Chi tiết: {sqlEx.Message}",
                    "Lỗi kết nối Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangNhap_Click(sender, e);
            }
        }
    }
}

