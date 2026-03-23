using System;

namespace QuanLyRapPhim.DTO
{
    public class SuatChieuDTO
    {
        public int Id { get; set; }
        public int IdPhim { get; set; }
        public int IdPhong { get; set; }
        public decimal GiaVe { get; set; }
        public bool TrangThai { get; set; }
        public DateTime ThoiGian { get; set; }

        public string TenPhim { get; set; }
        public string TenPhong { get; set; }

        public string TrangThaiText => TrangThai ? "Đang chiếu" : "Kết thúc";

        //obj for display in ComboBox
        public string MoTa => TenPhong;

        public override string ToString() =>
            $"{TenPhim} - {TenPhong} ({ThoiGian:dd/MM/yyyy HH:mm})";
    }
}
