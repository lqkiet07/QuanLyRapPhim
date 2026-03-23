using System;

namespace QuanLyRapPhim.DTO
{
    public class VeDTO
    {
        public int Id { get; set; }
        public int IdSuatChieu { get; set; }
        public int IdGhe { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }

        //obj for display properties
        public string MaGhe { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public string TenNhanVien { get; set; }
    }
}
