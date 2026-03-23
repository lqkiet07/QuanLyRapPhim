namespace QuanLyRapPhim.DTO
{

    public class PhongChieuDTO
    {
        public int Id { get; set; }
        public string TenPhong { get; set; }
        public int SoCho { get; set; }
        public bool TinhTrang { get; set; }

        public string TinhTrangText => TinhTrang ? "Hoạt động" : "Ngừng hoạt động";
        public override string ToString() => TenPhong;
    }
}
