namespace QuanLyRapPhim
{
    partial class frmQuanLySuatChieu
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
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.chkDangChieu = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // dgvSuatChieu
            this.dgvSuatChieu.AllowUserToAddRows = false;
            this.dgvSuatChieu.AllowUserToDeleteRows = false;
            this.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuatChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuatChieu.Location = new System.Drawing.Point(0, 45);
            this.dgvSuatChieu.MultiSelect = false;
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.ReadOnly = true;
            this.dgvSuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuatChieu.Size = new System.Drawing.Size(620, 490);
            this.dgvSuatChieu.SelectionChanged += new System.EventHandler(this.dgvSuatChieu_SelectionChanged);
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.panelTop.Controls.Add(this.lblCount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(620, 40);
            // lblCount
            this.lblCount.Location = new System.Drawing.Point(10, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(300, 20);
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // panelInput
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblTitle2);
            this.panelInput.Controls.Add(this.lblPhim);
            this.panelInput.Controls.Add(this.cboPhim);
            this.panelInput.Controls.Add(this.lblPhong);
            this.panelInput.Controls.Add(this.cboPhong);
            this.panelInput.Controls.Add(this.lblGiaVe);
            this.panelInput.Controls.Add(this.txtGiaVe);
            this.panelInput.Controls.Add(this.lblThoiGian);
            this.panelInput.Controls.Add(this.dtpThoiGian);
            this.panelInput.Controls.Add(this.chkDangChieu);
            this.panelInput.Controls.Add(this.btnThem);
            this.panelInput.Controls.Add(this.btnSua);
            this.panelInput.Controls.Add(this.btnXoa);
            this.panelInput.Controls.Add(this.btnLamMoi);
            this.panelInput.Location = new System.Drawing.Point(625, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(345, 535);
            // lblTitle2
            this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle2.Size = new System.Drawing.Size(345, 35);
            this.lblTitle2.Text = "  Thông tin suất chiếu";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblPhim
            this.lblPhim.Location = new System.Drawing.Point(10, 50);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(60, 20);
            this.lblPhim.Text = "Phim:";
            // cboPhim
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Location = new System.Drawing.Point(10, 70);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(320, 23);
            // lblPhong
            this.lblPhong.Location = new System.Drawing.Point(10, 105);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(80, 20);
            this.lblPhong.Text = "Phòng chiếu:";
            // cboPhong
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(10, 125);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(320, 23);
            // lblGiaVe
            this.lblGiaVe.Location = new System.Drawing.Point(10, 160);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(60, 20);
            this.lblGiaVe.Text = "Giá vé:";
            // txtGiaVe
            this.txtGiaVe.Location = new System.Drawing.Point(10, 180);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(320, 23);
            // lblThoiGian
            this.lblThoiGian.Location = new System.Drawing.Point(10, 215);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(80, 20);
            this.lblThoiGian.Text = "Thời gian chiếu:";
            // dtpThoiGian
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(10, 235);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(320, 23);
            this.dtpThoiGian.Value = System.DateTime.Now.AddDays(1);
            // chkDangChieu
            this.chkDangChieu.Location = new System.Drawing.Point(10, 270);
            this.chkDangChieu.Name = "chkDangChieu";
            this.chkDangChieu.Size = new System.Drawing.Size(150, 25);
            this.chkDangChieu.Text = "Đang chiếu";
            this.chkDangChieu.Checked = true;
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(5, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(87, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(169, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(251, 490);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 35);
            this.btnLamMoi.Text = "🔄 Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // frmQuanLySuatChieu
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvSuatChieu);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLySuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Suất Chiếu";
            this.Load += new System.EventHandler(this.frmQuanLySuatChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.CheckBox chkDangChieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCount;
    }
}
