using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmQuanLyPhongChieu : Form
    {
        private readonly PhongChieuBUS _bus = new PhongChieuBUS();
        private List<PhongChieuDTO> _list;
        private PhongChieuDTO _selected;

        public frmQuanLyPhongChieu()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhongChieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _list = _bus.GetAll();
            dgvPhong.DataSource = null;
            dgvPhong.DataSource = _list;
            if (dgvPhong.Columns.Count > 0)
            {
                dgvPhong.Columns["Id"].Visible = false;
                dgvPhong.Columns["TenPhong"].HeaderText = "Tên Phòng";
                dgvPhong.Columns["SoCho"].HeaderText = "Số Chỗ";
                dgvPhong.Columns["TinhTrang"].Visible = false;
                dgvPhong.Columns["TinhTrangText"].HeaderText = "Tình Trạng";
            }
            lblCount.Text = $"Tổng: {_list.Count} phòng";
        }

        private void ClearInput()
        {
            txtTenPhong.Clear();
            txtSoCho.Clear();
            chkHoatDong.Checked = true;
            _selected = null;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow?.DataBoundItem is PhongChieuDTO p)
            {
                _selected = p;
                txtTenPhong.Text = p.TenPhong;
                txtSoCho.Text = p.SoCho.ToString();
                chkHoatDong.Checked = p.TinhTrang;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private PhongChieuDTO BuildFromInput() => new PhongChieuDTO
        {
            Id = _selected?.Id ?? 0,
            TenPhong = txtTenPhong.Text.Trim(),
            SoCho = int.TryParse(txtSoCho.Text, out int s) ? s : 0,
            TinhTrang = chkHoatDong.Checked
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
            if (MessageBox.Show($"Xóa phòng '{_selected.TenPhong}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.Delete(_selected.Id);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) { LoadData(); ClearInput(); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { ClearInput(); LoadData(); }
    }
}
