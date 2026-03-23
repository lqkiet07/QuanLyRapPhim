using System;

namespace QuanLyRapPhim.DTO
{
    public class PhimDTO
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public double ThoiLuong { get; set; }
        public DateTime? NgayKhoiChieu { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string DaoDien { get; set; }
        public int IdTheLoai { get; set; }

        public string TenTheLoai { get; set; }

        public override string ToString() => TenPhim;
    }
}
