namespace QuanLyRapPhim
{
    partial class frmQuanLyPhim
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
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.lblDaoDien = new System.Windows.Forms.Label();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.chkKhoiChieu = new System.Windows.Forms.CheckBox();
            this.dtpKhoiChieu = new System.Windows.Forms.DateTimePicker();
            this.chkKetThuc = new System.Windows.Forms.CheckBox();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // dgvPhim
            this.dgvPhim.AllowUserToAddRows = false;
            this.dgvPhim.AllowUserToDeleteRows = false;
            this.dgvPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhim.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Location = new System.Drawing.Point(0, 50);
            this.dgvPhim.MultiSelect = false;
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.ReadOnly = true;
            this.dgvPhim.RowHeadersWidth = 30;
            this.dgvPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhim.Size = new System.Drawing.Size(600, 500);
            this.dgvPhim.SelectionChanged += new System.EventHandler(this.dgvPhim_SelectionChanged);
            // panelSearch
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.panelSearch.Controls.Add(this.lblTimKiem);
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.lblCount);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(600, 45);
            // lblTimKiem
            this.lblTimKiem.Location = new System.Drawing.Point(5, 12);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(60, 20);
            this.lblTimKiem.Text = "Tìm kiếm:";
            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(70, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 23);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // lblCount
            this.lblCount.Location = new System.Drawing.Point(340, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(200, 20);
            // panelInput
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblTitle2);
            this.panelInput.Controls.Add(this.lblTenPhim);
            this.panelInput.Controls.Add(this.txtTenPhim);
            this.panelInput.Controls.Add(this.lblThoiLuong);
            this.panelInput.Controls.Add(this.txtThoiLuong);
            this.panelInput.Controls.Add(this.lblDaoDien);
            this.panelInput.Controls.Add(this.txtDaoDien);
            this.panelInput.Controls.Add(this.lblTheLoai);
            this.panelInput.Controls.Add(this.cboTheLoai);
            this.panelInput.Controls.Add(this.chkKhoiChieu);
            this.panelInput.Controls.Add(this.dtpKhoiChieu);
            this.panelInput.Controls.Add(this.chkKetThuc);
            this.panelInput.Controls.Add(this.dtpKetThuc);
            this.panelInput.Controls.Add(this.btnThem);
            this.panelInput.Controls.Add(this.btnSua);
            this.panelInput.Controls.Add(this.btnXoa);
            this.panelInput.Controls.Add(this.btnLamMoi);
            this.panelInput.Location = new System.Drawing.Point(605, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(370, 560);
            // lblTitle2
            this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(370, 35);
            this.lblTitle2.Text = "  Thông tin phim";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblTenPhim
            this.lblTenPhim.Location = new System.Drawing.Point(10, 50);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(100, 20);
            this.lblTenPhim.Text = "Tên phim:";
            // txtTenPhim
            this.txtTenPhim.Location = new System.Drawing.Point(10, 70);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(345, 23);
            // lblThoiLuong
            this.lblThoiLuong.Location = new System.Drawing.Point(10, 105);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(100, 20);
            this.lblThoiLuong.Text = "Thời lượng:";
            // txtThoiLuong
            this.txtThoiLuong.Location = new System.Drawing.Point(10, 125);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(345, 23);
            // lblDaoDien
            this.lblDaoDien.Location = new System.Drawing.Point(10, 160);
            this.lblDaoDien.Name = "lblDaoDien";
            this.lblDaoDien.Size = new System.Drawing.Size(100, 20);
            this.lblDaoDien.Text = "Đạo diễn:";
            // txtDaoDien
            this.txtDaoDien.Location = new System.Drawing.Point(10, 180);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(345, 23);
            // lblTheLoai
            this.lblTheLoai.Location = new System.Drawing.Point(10, 215);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(100, 20);
            this.lblTheLoai.Text = "Thể loại:";
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(10, 235);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(345, 23);
            this.chkKhoiChieu.Location = new System.Drawing.Point(10, 270);
            this.chkKhoiChieu.Name = "chkKhoiChieu";
            this.chkKhoiChieu.Size = new System.Drawing.Size(130, 20);
            this.chkKhoiChieu.Text = "Ngày khởi chiếu:";
            this.dtpKhoiChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKhoiChieu.Location = new System.Drawing.Point(10, 290);
            this.dtpKhoiChieu.Name = "dtpKhoiChieu";
            this.dtpKhoiChieu.Size = new System.Drawing.Size(345, 23);
            this.chkKetThuc.Location = new System.Drawing.Point(10, 325);
            this.chkKetThuc.Name = "chkKetThuc";
            this.chkKetThuc.Size = new System.Drawing.Size(130, 20);
            this.chkKetThuc.Text = "Ngày kết thúc:";
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(10, 345);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(345, 23);
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(100, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(190, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(275, 490);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 35);
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            btnSua.Enabled = false; btnXoa.Enabled = false;
            // frmQuanLyPhim
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dgvPhim);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phim";
            this.Load += new System.EventHandler(this.frmQuanLyPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.Label lblDaoDien;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.CheckBox chkKhoiChieu;
        private System.Windows.Forms.DateTimePicker dtpKhoiChieu;
        private System.Windows.Forms.CheckBox chkKetThuc;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblCount;
    }
}
