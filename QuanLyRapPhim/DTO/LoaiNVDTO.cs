namespace QuanLyRapPhim.DTO
{

    public class LoaiNVDTO
    {
        public int Id { get; set; }
        public string TenLoaiNV { get; set; }

        public override string ToString() => TenLoaiNV;
    }
}
