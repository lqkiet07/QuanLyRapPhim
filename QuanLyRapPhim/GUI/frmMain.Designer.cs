namespace QuanLyRapPhim
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnQuanLyPhim = new System.Windows.Forms.Button();
            this.btnQuanLyPhong = new System.Windows.Forms.Button();
            this.btnQuanLySuatChieu = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblCenter = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(20, 60, 140);
            this.panelSidebar.Controls.Add(this.lblAppName);
            this.panelSidebar.Controls.Add(this.btnQuanLyPhim);
            this.panelSidebar.Controls.Add(this.btnQuanLyPhong);
            this.panelSidebar.Controls.Add(this.btnQuanLySuatChieu);
            this.panelSidebar.Controls.Add(this.btnBanVe);
            this.panelSidebar.Controls.Add(this.btnQuanLyNhanVien);
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 600);
            // lblAppName
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 20);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(220, 60);
            this.lblAppName.Text = "🎬 Rạp Phim";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnQuanLyPhim
            this.btnQuanLyPhim.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnQuanLyPhim.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanLyPhim.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhim.Location = new System.Drawing.Point(10, 100);
            this.btnQuanLyPhim.Name = "btnQuanLyPhim";
            this.btnQuanLyPhim.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLyPhim.Text = "🎥  Quản Lý Phim";
            this.btnQuanLyPhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // btnQuanLyPhong
            this.btnQuanLyPhong.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnQuanLyPhong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanLyPhong.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhong.Location = new System.Drawing.Point(10, 160);
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLyPhong.Text = "🏠  Quản Lý Phòng Chiếu";
            this.btnQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // btnQuanLySuatChieu
            this.btnQuanLySuatChieu.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnQuanLySuatChieu.FlatAppearance.BorderSize = 0;
            this.btnQuanLySuatChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySuatChieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanLySuatChieu.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySuatChieu.Location = new System.Drawing.Point(10, 220);
            this.btnQuanLySuatChieu.Name = "btnQuanLySuatChieu";
            this.btnQuanLySuatChieu.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLySuatChieu.Text = "📅  Quản Lý Suất Chiếu";
            this.btnQuanLySuatChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySuatChieu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // btnBanVe
            this.btnBanVe.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnBanVe.FlatAppearance.BorderSize = 0;
            this.btnBanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanVe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBanVe.ForeColor = System.Drawing.Color.White;
            this.btnBanVe.Location = new System.Drawing.Point(10, 280);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(200, 45);
            this.btnBanVe.Text = "🎫  Bán Vé";
            this.btnBanVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanVe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // btnQuanLyNhanVien
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(10, 340);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLyNhanVien.Text = "👥  Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);

            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(160, 30, 30);
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(10, 530);
            this.btnDangXuat.Size = new System.Drawing.Size(200, 45);
            this.btnDangXuat.Text = "🚪  Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            // Assign click events
            this.btnQuanLyPhim.Click += new System.EventHandler(this.btnQuanLyPhim_Click);
            this.btnQuanLyPhong.Click += new System.EventHandler(this.btnQuanLyPhong_Click);
            this.btnQuanLySuatChieu.Click += new System.EventHandler(this.btnQuanLySuatChieu_Click);
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(780, 50);
            // lblWelcome
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.lblCenter);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            // lblCenter
            this.lblCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCenter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCenter.ForeColor = System.Drawing.Color.LightGray;
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Text = "🎬 Chào mừng đến Hệ thống Quản Lý Rạp Phim";
            this.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Rạp Phim";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnQuanLyPhim;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button btnQuanLySuatChieu;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblCenter;
    }
}
