using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmQuanLyNhanVien : Form
    {
        private readonly NhanVienBUS _bus = new NhanVienBUS();
        private List<NhanVienDTO> _list;
        private NhanVienDTO _selected;
        private bool _isClearing = false;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadLoaiNV();
            LoadData();
        }

        private void LoadLoaiNV()
        {
            //load danh sách loại nhân viên từ database
            var dal = new QuanLyRapPhim.DAL.NhanVienDAL();
            var loais = dal.GetAllLoaiNV();
            cboLoai.DataSource = loais;
            cboLoai.DisplayMember = "TenLoaiNV";
            cboLoai.ValueMember = "Id";
            if (cboLoai.Items.Count > 1) cboLoai.SelectedIndex = 1;
        }

        private void LoadData()
        {
            _list = _bus.GetAll();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = _list;
            lblCount.Text = $"Tổng: {_list.Count} nhân viên";
        }

        private void ClearInput()
        {
            _isClearing = true;
            txtHoTen.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cboLoai.SelectedIndex = 1;
            _selected = null;
            dgvNhanVien.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            _isClearing = false;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (_isClearing) return;
            if (dgvNhanVien.CurrentRow?.DataBoundItem is NhanVienDTO nv)
            {
                _selected = nv;
                txtHoTen.Text = nv.HoTen;
                txtTaiKhoan.Text = nv.TaiKhoan;
                txtMatKhau.Text = nv.MatKhau;
                foreach (LoaiNVDTO item in cboLoai.Items)
                    if (item.Id == nv.IdLoai) { cboLoai.SelectedItem = item; break; }
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private NhanVienDTO BuildFromInput() => new NhanVienDTO
        {
            Id = _selected?.Id ?? 0,
            HoTen = txtHoTen.Text.Trim(),
            TaiKhoan = txtTaiKhoan.Text.Trim(),
            MatKhau = txtMatKhau.Text.Trim(),
            IdLoai = ((LoaiNVDTO)cboLoai.SelectedItem).Id
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            var (ok, msg) = _bus.Insert(BuildFromInput());
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { LoadData(); ClearInput(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selected == null) return;
            var (ok, msg) = _bus.Update(BuildFromInput());
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { LoadData(); ClearInput(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selected == null) return;
            if (MessageBox.Show($"Xóa nhân viên '{_selected.HoTen}'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.Delete(_selected.Id);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) { LoadData(); ClearInput(); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); ClearInput(); }
    }
}
