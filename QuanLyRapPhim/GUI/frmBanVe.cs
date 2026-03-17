using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyRapPhim.BUS;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim
{
    public partial class frmBanVe : Form
    {
        private readonly VeBUS _bus = new VeBUS();
        private readonly NhanVienDTO _nhanVien;
        private SuatChieuDTO _suatChieu;
        private List<GheDTO> _danhSachGhe;
        private List<int> _gheDaBan;
        private GheDTO _gheChon;

        private static readonly Color C_TRONG = Color.FromArgb(100, 180, 100);
        private static readonly Color C_DA_BAN = Color.FromArgb(180, 60, 60);
        private static readonly Color C_CHON = Color.FromArgb(255, 200, 0);
        private static readonly Color C_VIP = Color.FromArgb(120, 60, 200);

        public frmBanVe(NhanVienDTO nv)
        {
            InitializeComponent();
            _nhanVien = nv;
        }

        private void frmBanVe_Load(object sender, EventArgs e)
        {
            var list = _bus.GetSuatChieuDangChieu();
            cboSuatChieu.DataSource = list;
            cboSuatChieu.DisplayMember = "ToString";
            cboSuatChieu.ValueMember = "Id";
        }

        private void cboSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSuatChieu.SelectedItem is SuatChieuDTO sc)
            {
                _suatChieu = sc;
                lblThongTin.Text = $"Phim: {sc.TenPhim}  |  Phòng: {sc.TenPhong}  |  Giờ: {sc.ThoiGian:dd/MM/yyyy HH:mm}  |  Giá vé: {sc.GiaVe:N0} đ";
                LoadGhe(sc.Id, sc.IdPhong);
            }
        }

        private void LoadGhe(int idSuatChieu, int idPhong)
        {
            _danhSachGhe = new List<GheDTO>();
            _gheDaBan = _bus.GetGheDaBan(idSuatChieu);
            _gheChon = null;
            lblGheChon.Text = "Ghế đã chọn: (chưa chọn)";
            lblTongTien.Text = "Tổng tiền: --";
            btnBanVe.Enabled = false;

            panelGhe.Controls.Clear();
            var ghes = _bus.GetGheVaSuatChieu(idSuatChieu, idPhong);
            _danhSachGhe = ghes;

            var hangs = new Dictionary<string, List<GheDTO>>();
            foreach (var g in ghes)
            {
                if (!hangs.ContainsKey(g.Hang)) hangs[g.Hang] = new List<GheDTO>();
                hangs[g.Hang].Add(g);
            }

            int y = 10;
            foreach (var hang in hangs)
            {
                var lblHang = new Label();
                lblHang.Text = $"Hàng {hang.Key}";
                lblHang.Location = new Point(5, y + 5);
                lblHang.Size = new Size(55, 30);
                lblHang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                panelGhe.Controls.Add(lblHang);

                int x = 65;
                foreach (var ghe in hang.Value)
                {
                    bool daBan = _gheDaBan.Contains(ghe.Id);
                    var btn = new Button();
                    btn.Tag = ghe;
                    btn.Text = ghe.MaGhe;
                    btn.Size = new Size(45, 35);
                    btn.Location = new Point(x, y);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
                    btn.ForeColor = Color.White;
                    btn.Enabled = !daBan;
                    if (daBan) btn.BackColor = C_DA_BAN;
                    else if (ghe.PhuPhi > 0) btn.BackColor = C_VIP;
                    else btn.BackColor = C_TRONG;
                    if (!daBan) btn.Click += Ghe_Click;
                    panelGhe.Controls.Add(btn);
                    x += 50;
                }
                y += 45;
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelGhe.Controls)
            {
                if (ctrl is Button b && b.Tag is GheDTO g)
                {
                    if (!_gheDaBan.Contains(g.Id))
                        b.BackColor = g.PhuPhi > 0 ? C_VIP : C_TRONG;
                }
            }
            var btn = (Button)sender;
            _gheChon = (GheDTO)btn.Tag;
            btn.BackColor = C_CHON;
            btn.ForeColor = Color.Black;

            decimal tongTien = _suatChieu.GiaVe + _gheChon.PhuPhi;
            lblGheChon.Text = $"Ghế đã chọn: {_gheChon.MaGhe} ({_gheChon.TenLoaiGhe})";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
            btnBanVe.Enabled = true;
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            if (_gheChon == null || _suatChieu == null) return;
            decimal tongTien = _suatChieu.GiaVe + _gheChon.PhuPhi;
            if (MessageBox.Show($"Xác nhận bán vé ghế {_gheChon.MaGhe} = {tongTien:N0} đ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.BanVe(_suatChieu.Id, _gheChon.Id, _nhanVien.Id, tongTien);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) LoadGhe(_suatChieu.Id, _suatChieu.IdPhong);
            }
        }
    }
}
