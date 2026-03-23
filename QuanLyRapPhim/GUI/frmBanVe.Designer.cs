namespace QuanLyRapPhim
{
    partial class frmBanVe
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.panelGhe = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblChuThich = new System.Windows.Forms.Label();
            this.lblGheChon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblPhim);
            this.panelTop.Controls.Add(this.cboPhim);
            this.panelTop.Controls.Add(this.lblSuatChieu);
            this.panelTop.Controls.Add(this.cboSuatChieu);
            this.panelTop.Controls.Add(this.lblThongTin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1333, 104);
            this.panelTop.TabIndex = 1;
            // 
            // lblPhim
            // 
            this.lblPhim.Location = new System.Drawing.Point(13, 12);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(80, 25);
            this.lblPhim.TabIndex = 10;
            this.lblPhim.Text = "Chọn phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Location = new System.Drawing.Point(13, 37);
            this.cboPhim.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(320, 24);
            this.cboPhim.TabIndex = 11;
            this.cboPhim.SelectedIndexChanged += new System.EventHandler(this.cboPhim_SelectedIndexChanged);
            // 
            // lblSuatChieu
            // 
            this.lblSuatChieu.Location = new System.Drawing.Point(350, 12);
            this.lblSuatChieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(107, 25);
            this.lblSuatChieu.TabIndex = 0;
            this.lblSuatChieu.Text = "Chọn suất:";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.Location = new System.Drawing.Point(353, 37);
            this.cboSuatChieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(330, 24);
            this.cboSuatChieu.TabIndex = 1;
            this.cboSuatChieu.SelectedIndexChanged += new System.EventHandler(this.cboSuatChieu_SelectedIndexChanged);
            // 
            // lblThongTin
            // 
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.lblThongTin.Location = new System.Drawing.Point(13, 74);
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(1200, 25);
            this.lblThongTin.TabIndex = 2;
            // 
            // panelGhe
            // 
            this.panelGhe.AutoScroll = true;
            this.panelGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGhe.Location = new System.Drawing.Point(0, 111);
            this.panelGhe.Margin = new System.Windows.Forms.Padding(4);
            this.panelGhe.Name = "panelGhe";
            this.panelGhe.Size = new System.Drawing.Size(1333, 529);
            this.panelGhe.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.panelBottom.Controls.Add(this.lblChuThich);
            this.panelBottom.Controls.Add(this.lblGheChon);
            this.panelBottom.Controls.Add(this.lblTongTien);
            this.panelBottom.Controls.Add(this.btnBanVe);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 640);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1333, 98);
            this.panelBottom.TabIndex = 2;
            // 
            // lblChuThich
            // 
            this.lblChuThich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChuThich.ForeColor = System.Drawing.Color.White;
            this.lblChuThich.Location = new System.Drawing.Point(13, 25);
            this.lblChuThich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(533, 37);
            this.lblChuThich.TabIndex = 0;
            // 
            // lblGheChon
            // 
            this.lblGheChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGheChon.ForeColor = System.Drawing.Color.White;
            this.lblGheChon.Location = new System.Drawing.Point(573, 12);
            this.lblGheChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGheChon.Name = "lblGheChon";
            this.lblGheChon.Size = new System.Drawing.Size(333, 31);
            this.lblGheChon.TabIndex = 1;
            this.lblGheChon.Text = "Ghế đã chọn: (chưa chọn)";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Yellow;
            this.lblTongTien.Location = new System.Drawing.Point(573, 47);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(333, 37);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền: --";
            // 
            // btnBanVe
            // 
            this.btnBanVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.btnBanVe.Enabled = false;
            this.btnBanVe.FlatAppearance.BorderSize = 0;
            this.btnBanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBanVe.ForeColor = System.Drawing.Color.White;
            this.btnBanVe.Location = new System.Drawing.Point(1133, 18);
            this.btnBanVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(173, 62);
            this.btnBanVe.TabIndex = 3;
            this.btnBanVe.Text = "Bán Vé";
            this.btnBanVe.UseVisualStyleBackColor = false;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.panelGhe);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bán Vé";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Panel panelGhe;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.Label lblGheChon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnBanVe;
    }
}
