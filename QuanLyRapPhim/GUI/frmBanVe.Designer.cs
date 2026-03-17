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
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblSuatChieu);
            this.panelTop.Controls.Add(this.cboSuatChieu);
            this.panelTop.Controls.Add(this.lblThongTin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 85);
            // lblSuatChieu
            this.lblSuatChieu.Location = new System.Drawing.Point(10, 10);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(80, 20);
            this.lblSuatChieu.Text = "Suất chiếu:";
            // cboSuatChieu
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.Location = new System.Drawing.Point(10, 30);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(500, 23);
            this.cboSuatChieu.SelectedIndexChanged += new System.EventHandler(this.cboSuatChieu_SelectedIndexChanged);
            // lblThongTin
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.lblThongTin.Location = new System.Drawing.Point(10, 60);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(900, 20);
            // panelGhe
            this.panelGhe.AutoScroll = true;
            this.panelGhe.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.panelGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGhe.Location = new System.Drawing.Point(0, 90);
            this.panelGhe.Name = "panelGhe";
            this.panelGhe.Size = new System.Drawing.Size(1000, 430);
            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(30, 60, 130);
            this.panelBottom.Controls.Add(this.lblChuThich);
            this.panelBottom.Controls.Add(this.lblGheChon);
            this.panelBottom.Controls.Add(this.lblTongTien);
            this.panelBottom.Controls.Add(this.btnBanVe);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1000, 80);
            // lblChuThich
            this.lblChuThich.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblChuThich.ForeColor = System.Drawing.Color.White;
            this.lblChuThich.Location = new System.Drawing.Point(10, 10);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(400, 60);
            this.lblChuThich.Text = "🟢 Trống   🔴 Đã bán   🟡 Đang chọn   🟣 VIP";
            this.lblChuThich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblGheChon
            this.lblGheChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGheChon.ForeColor = System.Drawing.Color.White;
            this.lblGheChon.Location = new System.Drawing.Point(430, 10);
            this.lblGheChon.Name = "lblGheChon";
            this.lblGheChon.Size = new System.Drawing.Size(250, 25);
            this.lblGheChon.Text = "Ghế đã chọn: (chưa chọn)";
            // lblTongTien
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Yellow;
            this.lblTongTien.Location = new System.Drawing.Point(430, 38);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(250, 30);
            this.lblTongTien.Text = "Tổng tiền: --";
            // btnBanVe
            this.btnBanVe.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnBanVe.Enabled = false;
            this.btnBanVe.FlatAppearance.BorderSize = 0;
            this.btnBanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBanVe.ForeColor = System.Drawing.Color.White;
            this.btnBanVe.Location = new System.Drawing.Point(850, 15);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(130, 50);
            this.btnBanVe.Text = "🎫 Bán Vé";
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // frmBanVe
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelGhe);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
