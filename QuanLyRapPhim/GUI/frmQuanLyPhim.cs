using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmQuanLyPhim : Form
    {
        private readonly PhimBUS _bus = new PhimBUS();
        private List<PhimDTO> _danhSachPhim;
        private PhimDTO _selected;
        private bool _isClearing = false;

        public frmQuanLyPhim()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhim_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadPhim();
        }

        private void LoadTheLoai()
        {
            var theLoais = _bus.GetAllTheLoai();
            cboTheLoai.DataSource = theLoais;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "Id";
        }

        private void LoadPhim()
        {
            _danhSachPhim = _bus.GetAll();
            dgvPhim.AutoGenerateColumns = false;
            dgvPhim.DataSource = null;
            dgvPhim.DataSource = _danhSachPhim;
            lblCount.Text = $"Tổng: {_danhSachPhim.Count} phim";
        }


        private void ClearInput()
        {
            _isClearing = true;
            txtTenPhim.Clear();
            txtThoiLuong.Clear();
            txtDaoDien.Clear();
            chkKhoiChieu.Checked = false;
            chkKetThuc.Checked = false;
            dtpKhoiChieu.Value = DateTime.Today;
            dtpKetThuc.Value = DateTime.Today.AddMonths(1);
            if (cboTheLoai.Items.Count > 0) cboTheLoai.SelectedIndex = 0;
            _selected = null;
            dgvPhim.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            _isClearing = false;
        }

        private void FillInput(PhimDTO p)
        {
            txtTenPhim.Text = p.TenPhim;
            txtThoiLuong.Text = p.ThoiLuong.ToString();
            txtDaoDien.Text = p.DaoDien;
            //obj for sync checkbox state with data
            chkKhoiChieu.Checked = p.NgayKhoiChieu.HasValue;
            chkKetThuc.Checked = p.NgayKetThuc.HasValue;
            dtpKhoiChieu.Value = p.NgayKhoiChieu ?? DateTime.Today;
            dtpKetThuc.Value = p.NgayKetThuc ?? DateTime.Today.AddMonths(1);
            cboTheLoai.SelectedValue = p.IdTheLoai;
        }

        private PhimDTO BuildFromInput()
        {
            return new PhimDTO
            {
                Id = _selected?.Id ?? 0,
                TenPhim = txtTenPhim.Text.Trim(),
                ThoiLuong = double.TryParse(txtThoiLuong.Text, out double tl) ? tl : 0,
                DaoDien = txtDaoDien.Text.Trim(),
                NgayKhoiChieu = chkKhoiChieu.Checked ? dtpKhoiChieu.Value : (DateTime?)null,
                NgayKetThuc = chkKetThuc.Checked ? dtpKetThuc.Value : (DateTime?)null,
                IdTheLoai = (int)cboTheLoai.SelectedValue
            };
        }

        private void dgvPhim_SelectionChanged(object sender, EventArgs e)
        {
            if (_isClearing) return;
            if (dgvPhim.CurrentRow?.DataBoundItem is PhimDTO p)
            {
                _selected = p;
                FillInput(p);
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var phim = BuildFromInput();
            var (ok, msg) = _bus.Insert(phim);
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { LoadPhim(); ClearInput(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selected == null) return;
            var phim = BuildFromInput();
            var (ok, msg) = _bus.Update(phim);
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { LoadPhim(); ClearInput(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selected == null) return;
            if (MessageBox.Show($"Xóa phim '{_selected.TenPhim}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.Delete(_selected.Id);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) { LoadPhim(); ClearInput(); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadPhim();
            ClearInput();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(kw))
                dgvPhim.DataSource = _danhSachPhim;
            else
                dgvPhim.DataSource = _bus.Search(kw);
        }
    }
}
