namespace QuanLyRapPhim.DTO
{
    public class TheLoaiDTO
    {
        public int Id { get; set; }
        public string TenTheLoai { get; set; }

        public override string ToString() => TenTheLoai;
    }
}
