using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmQuanLySuatChieu : Form
    {
        private readonly SuatChieuBUS _bus = new SuatChieuBUS();
        private List<SuatChieuDTO> _list;
        private SuatChieuDTO _selected;

        public frmQuanLySuatChieu()
        {
            InitializeComponent();
        }

        private void frmQuanLySuatChieu_Load(object sender, EventArgs e)
        {
            var phims = _bus.GetAllPhim();
            cboPhim.DataSource = phims;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "Id";

            var phongs = _bus.GetAllPhong();
            cboPhong.DataSource = phongs;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "Id";

            LoadData();
        }

        private void LoadData()
        {
            _list = _bus.GetAll();
            dgvSuatChieu.DataSource = null;
            dgvSuatChieu.DataSource = _list;
            if (dgvSuatChieu.Columns.Count > 0)
            {
                dgvSuatChieu.Columns["Id"].Visible = false;
                dgvSuatChieu.Columns["IdPhim"].Visible = false;
                dgvSuatChieu.Columns["IdPhong"].Visible = false;
                dgvSuatChieu.Columns["TrangThai"].Visible = false;
                dgvSuatChieu.Columns["TenPhim"].HeaderText = "Phim";
                dgvSuatChieu.Columns["TenPhong"].HeaderText = "Phòng Chiếu";
                dgvSuatChieu.Columns["ThoiGian"].HeaderText = "Thời Gian";
                dgvSuatChieu.Columns["GiaVe"].HeaderText = "Giá Vé";
                dgvSuatChieu.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            }
            lblCount.Text = $"Tổng: {_list.Count} suất chiếu";
        }

        private void ClearInput()
        {
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
            txtGiaVe.Clear();
            dtpThoiGian.Value = DateTime.Now.AddDays(1);
            chkDangChieu.Checked = true;
            _selected = null;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvSuatChieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuatChieu.CurrentRow?.DataBoundItem is SuatChieuDTO sc)
            {
                _selected = sc;
                cboPhim.SelectedValue = sc.IdPhim;
                cboPhong.SelectedValue = sc.IdPhong;
                txtGiaVe.Text = sc.GiaVe.ToString();
                dtpThoiGian.Value = sc.ThoiGian;
                chkDangChieu.Checked = sc.TrangThai;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private SuatChieuDTO BuildFromInput() => new SuatChieuDTO
        {
            Id = _selected?.Id ?? 0,
            IdPhim = (int)cboPhim.SelectedValue,
            IdPhong = (int)cboPhong.SelectedValue,
            GiaVe = decimal.TryParse(txtGiaVe.Text, out decimal g) ? g : 0,
            ThoiGian = dtpThoiGian.Value,
            TrangThai = chkDangChieu.Checked
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
            if (MessageBox.Show("Xóa suất chiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.Delete(_selected.Id);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) { LoadData(); ClearInput(); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { ClearInput(); LoadData(); }
    }
}
