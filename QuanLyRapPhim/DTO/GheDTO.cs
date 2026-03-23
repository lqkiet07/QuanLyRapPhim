namespace QuanLyRapPhim.DTO
{
    public class GheDTO
    {
        public int Id { get; set; }
        public int IdPhong { get; set; }
        public string Hang { get; set; }
        public int So { get; set; } 
        public int IdLoaiGhe { get; set; }

        public string TenLoaiGhe { get; set; }
        public decimal PhuPhi { get; set; }
        public string TenPhong { get; set; }

        public string MaGhe => $"{Hang}{So}"; 

        public override string ToString() => MaGhe;
    }
}
