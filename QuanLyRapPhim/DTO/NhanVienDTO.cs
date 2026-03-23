namespace QuanLyRapPhim.DTO
{
    public class NhanVienDTO
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int IdLoai { get; set; }

        public string TenLoaiNV { get; set; }

        public bool IsQuanLy => IdLoai == 1;

        public override string ToString() => HoTen;
    }
}
