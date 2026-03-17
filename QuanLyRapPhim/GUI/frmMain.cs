using System;
using System.Windows.Forms;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmMain : Form
    {
        private readonly NhanVienDTO _currentUser;

        public frmMain(NhanVienDTO user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, {_currentUser.HoTen}  |  {_currentUser.TenLoaiNV}";

            if (!_currentUser.IsQuanLy)
            {
                btnQuanLyNhanVien.Visible = false;
            }
        }


        private void btnQuanLyPhim_Click(object sender, EventArgs e)
        {
            new frmQuanLyPhim().ShowDialog();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            new frmQuanLyPhongChieu().ShowDialog();
        }

        private void btnQuanLySuatChieu_Click(object sender, EventArgs e)
        {
            new frmQuanLySuatChieu().ShowDialog();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            new frmBanVe(_currentUser).ShowDialog();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            new frmQuanLyNhanVien().ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }
    }
}
