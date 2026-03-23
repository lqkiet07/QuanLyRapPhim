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
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInput.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
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
            this.panelInput.Location = new System.Drawing.Point(833, 0);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(459, 658);
            this.panelInput.TabIndex = 2;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(457, 43);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "  Thông tin suất chiếu";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhim
            // 
            this.lblPhim.Location = new System.Drawing.Point(13, 62);
            this.lblPhim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(80, 25);
            this.lblPhim.TabIndex = 1;
            this.lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Location = new System.Drawing.Point(13, 86);
            this.cboPhim.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(425, 24);
            this.cboPhim.TabIndex = 2;
            // 
            // lblPhong
            // 
            this.lblPhong.Location = new System.Drawing.Point(13, 129);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(107, 25);
            this.lblPhong.TabIndex = 3;
            this.lblPhong.Text = "Phòng chiếu:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(13, 154);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(425, 24);
            this.cboPhong.TabIndex = 4;
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.Location = new System.Drawing.Point(13, 197);
            this.lblGiaVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(80, 25);
            this.lblGiaVe.TabIndex = 5;
            this.lblGiaVe.Text = "Giá vé:";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(13, 222);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(425, 22);
            this.txtGiaVe.TabIndex = 6;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(13, 265);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(107, 25);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Text = "Thời gian chiếu:";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(13, 289);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(425, 22);
            this.dtpThoiGian.TabIndex = 8;
            this.dtpThoiGian.Value = new System.DateTime(2026, 3, 20, 10, 0, 34, 164);
            // 
            // chkDangChieu
            // 
            this.chkDangChieu.Checked = true;
            this.chkDangChieu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDangChieu.Location = new System.Drawing.Point(13, 332);
            this.chkDangChieu.Margin = new System.Windows.Forms.Padding(4);
            this.chkDangChieu.Name = "chkDangChieu";
            this.chkDangChieu.Size = new System.Drawing.Size(200, 31);
            this.chkDangChieu.TabIndex = 9;
            this.chkDangChieu.Text = "Đang chiếu";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(7, 603);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(116, 603);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 43);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(225, 603);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 43);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(335, 603);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 43);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lblCount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 49);
            this.panelTop.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(13, 12);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(400, 25);
            this.lblCount.TabIndex = 0;
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.AllowUserToAddRows = false;
            this.dgvSuatChieu.AllowUserToDeleteRows = false;
            this.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuatChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuatChieu.ColumnHeadersHeight = 29;
            this.dgvSuatChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.TenPhong,
            this.ThoiGian,
            this.GiaVe,
            this.TrangThaiText});
            this.dgvSuatChieu.Location = new System.Drawing.Point(0, 55);
            this.dgvSuatChieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSuatChieu.MultiSelect = false;
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.ReadOnly = true;
            this.dgvSuatChieu.RowHeadersWidth = 51;
            this.dgvSuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuatChieu.Size = new System.Drawing.Size(827, 603);
            this.dgvSuatChieu.TabIndex = 1;
            this.dgvSuatChieu.SelectionChanged += new System.EventHandler(this.dgvSuatChieu_SelectionChanged);
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" };
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { Format = "N0" };
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // TrangThaiText
            // 
            this.TrangThaiText.DataPropertyName = "TrangThaiText";
            this.TrangThaiText.HeaderText = "Trạng Thái";
            this.TrangThaiText.MinimumWidth = 6;
            this.TrangThaiText.Name = "TrangThaiText";
            this.TrangThaiText.ReadOnly = true;
            // 
            // frmQuanLySuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 658);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvSuatChieu);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLySuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Suất Chiếu";
            this.Load += new System.EventHandler(this.frmQuanLySuatChieu_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
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
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiText;
    }
}
