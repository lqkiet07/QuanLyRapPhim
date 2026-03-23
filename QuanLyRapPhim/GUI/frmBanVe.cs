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
        private List<GheDTO> _gheChonList = new List<GheDTO>();

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
            lblChuThich.Paint += LblChuThich_Paint;
            //load danh sách phim vào combobox
            var phims = _bus.GetPhimDangChieu();
            cboPhim.DataSource = phims;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "Id";
        }

        private void LblChuThich_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int x = 0;
            DrawLegend(g, ref x, "Trống", C_TRONG);
            DrawLegend(g, ref x, "Đã bán", C_DA_BAN);
            DrawLegend(g, ref x, "Đang chọn", C_CHON);
            DrawLegend(g, ref x, "VIP", C_VIP);
        }

        private void DrawLegend(Graphics g, ref int x, string text, Color color)
        {
            using (var brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, x, 4, 16, 16);
            }
            TextRenderer.DrawText(g, text, lblChuThich.Font, new Point(x + 20, 3), Color.White);
            x += TextRenderer.MeasureText(text, lblChuThich.Font).Width + 35;
        }

        //load suất chiếu theo phim đã chọn
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedItem is PhimDTO phim)
            {
                var suats = _bus.GetSuatChieuByPhim(phim.Id);
                cboSuatChieu.DataSource = suats;
                cboSuatChieu.DisplayMember = "MoTa";
                cboSuatChieu.ValueMember = "Id";

                //tự động load ghế cho suất chiếu đầu tiên
                if (suats.Count > 0)
                {
                    cboSuatChieu.SelectedIndex = 0;
                    _suatChieu = suats[0];
                    lblThongTin.Text = $"Phòng: {_suatChieu.TenPhong}  |  Giờ: {_suatChieu.ThoiGian:dd/MM/yyyy HH:mm}  |  Giá vé: {_suatChieu.GiaVe:N0} đ";
                    LoadGhe(_suatChieu.Id, _suatChieu.IdPhong);
                }
                else
                {
                    panelGhe.Controls.Clear();
                    lblThongTin.Text = "Không có suất chiếu nào cho phim này";
                    lblGheChon.Text = "Ghế đã chọn: (chưa chọn)";
                    lblTongTien.Text = "Tổng tiền: --";
                    btnBanVe.Enabled = false;
                    _gheChonList.Clear();
                }
            }
        }

        private void cboSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSuatChieu.SelectedItem is SuatChieuDTO sc)
            {
                _suatChieu = sc;
                lblThongTin.Text = $"Phòng: {sc.TenPhong}  |  Giờ: {sc.ThoiGian:dd/MM/yyyy HH:mm}  |  Giá vé: {sc.GiaVe:N0} đ";
                LoadGhe(sc.Id, sc.IdPhong);
            }
        }

        private void LoadGhe(int idSuatChieu, int idPhong)
        {
            _danhSachGhe = new List<GheDTO>();
            _gheDaBan = _bus.GetGheDaBan(idSuatChieu);
            _gheChonList.Clear();
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
            var btn = (Button)sender;
            var ghe = (GheDTO)btn.Tag;

            if (_gheChonList.Contains(ghe))
            {
                // Đoạn này là bỏ chọn ghế
                _gheChonList.Remove(ghe);
                btn.BackColor = ghe.PhuPhi > 0 ? C_VIP : C_TRONG;
                btn.ForeColor = Color.White;
            }
            else
            {
                // Đoạn này là thêm ghế vào danh sách
                _gheChonList.Add(ghe);
                btn.BackColor = C_CHON;
                btn.ForeColor = Color.Black;
            }

            if (_gheChonList.Count == 0)
            {
                lblGheChon.Text = "Ghế đã chọn: (chưa chọn)";
                lblTongTien.Text = "Tổng tiền: --";
                btnBanVe.Enabled = false;
                return;
            }

            decimal tongTien = 0;
            var tenGhes = new List<string>();
            foreach (var g in _gheChonList)
            {
                tongTien += _suatChieu.GiaVe + g.PhuPhi;
                tenGhes.Add(g.MaGhe);
            }

            lblGheChon.Text = $"Ghế đã chọn: {string.Join(", ", tenGhes)}";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
            btnBanVe.Enabled = true;
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            if (_gheChonList.Count == 0 || _suatChieu == null) return;
            
            decimal tongTien = 0;
            var tenGhes = new List<string>();
            foreach (var g in _gheChonList)
            {
                tongTien += _suatChieu.GiaVe + g.PhuPhi;
                tenGhes.Add(g.MaGhe);
            }

            string dsGhe = string.Join(", ", tenGhes);
            if (MessageBox.Show($"Xác nhận bán {tenGhes.Count} vé (Ghế: {dsGhe})\nTổng tiền = {tongTien:N0} đ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var (ok, msg) = _bus.BanTapTheVe(_suatChieu.Id, _gheChonList, _nhanVien.Id, _suatChieu.GiaVe);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) LoadGhe(_suatChieu.Id, _suatChieu.IdPhong);
            }
        }
    }
}
