namespace QuanLyRapPhim.DTO
{

    public class LoaiGheDTO
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public decimal PhuPhi { get; set; }

        public override string ToString() => TenLoai;
    }
}
