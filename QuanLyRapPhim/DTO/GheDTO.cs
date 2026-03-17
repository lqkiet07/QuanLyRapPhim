namespace QuanLyRapPhim.DTO
{
    public class GheDTO
    {
        public int Id { get; set; }
        public int IdPhong { get; set; }
        public string Hang { get; set; }   // VD: "A", "B", "C"
        public int So { get; set; }        // VD: 1, 2, 3
        public int IdLoaiGhe { get; set; }

        // Dùng để hiển thị
        public string TenLoaiGhe { get; set; }
        public decimal PhuPhi { get; set; }
        public string TenPhong { get; set; }

        public string MaGhe => $"{Hang}{So}";  // VD: "A1", "B3"

        public override string ToString() => MaGhe;
    }
}
