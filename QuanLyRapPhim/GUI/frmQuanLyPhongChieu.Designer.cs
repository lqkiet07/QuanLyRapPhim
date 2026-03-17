namespace QuanLyRapPhim
{
    partial class frmQuanLyPhongChieu
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblSoCho = new System.Windows.Forms.Label();
            this.txtSoCho = new System.Windows.Forms.TextBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // dgvPhong
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.Location = new System.Drawing.Point(0, 45);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(560, 490);
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // panelSearch
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.panelSearch.Controls.Add(this.lblCount);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(560, 40);
            // lblCount
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(10, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(200, 20);
            // panelInput
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblTitle2);
            this.panelInput.Controls.Add(this.lblTenPhong);
            this.panelInput.Controls.Add(this.txtTenPhong);
            this.panelInput.Controls.Add(this.lblSoCho);
            this.panelInput.Controls.Add(this.txtSoCho);
            this.panelInput.Controls.Add(this.chkHoatDong);
            this.panelInput.Controls.Add(this.btnThem);
            this.panelInput.Controls.Add(this.btnSua);
            this.panelInput.Controls.Add(this.btnXoa);
            this.panelInput.Controls.Add(this.btnLamMoi);
            this.panelInput.Location = new System.Drawing.Point(565, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(330, 535);
            // lblTitle2
            this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(330, 35);
            this.lblTitle2.Text = "  Thông tin phòng chiếu";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblTenPhong
            this.lblTenPhong.Location = new System.Drawing.Point(10, 50);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(100, 20);
            this.lblTenPhong.Text = "Tên phòng:";
            // txtTenPhong
            this.txtTenPhong.Location = new System.Drawing.Point(10, 70);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(305, 23);
            // lblSoCho
            this.lblSoCho.Location = new System.Drawing.Point(10, 105);
            this.lblSoCho.Name = "lblSoCho";
            this.lblSoCho.Size = new System.Drawing.Size(100, 20);
            this.lblSoCho.Text = "Số chỗ:";
            // txtSoCho
            this.txtSoCho.Location = new System.Drawing.Point(10, 125);
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.Size = new System.Drawing.Size(305, 23);
            // chkHoatDong
            this.chkHoatDong.Location = new System.Drawing.Point(10, 160);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(150, 25);
            this.chkHoatDong.Text = "Đang hoạt động";
            this.chkHoatDong.Checked = true;
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 480);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(90, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 35);
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(170, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 35);
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(248, 480);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(70, 35);
            this.btnLamMoi.Text = "🔄 Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // frmQuanLyPhongChieu
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyPhongChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phòng Chiếu";
            this.Load += new System.EventHandler(this.frmQuanLyPhongChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblSoCho;
        private System.Windows.Forms.TextBox txtSoCho;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblCount;
    }
}
