using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class GheDAL
    {
        /// <summary>Lấy tất cả ghế của một phòng, kèm thông tin loại ghế và trạng thái đặt cho 1 suất chiếu</summary>
        public List<GheDTO> GetByPhong(int idPhong)
        {
            string query = @"SELECT g.id, g.idPhong, g.Hang, g.So, g.idLoaiGhe,
                                    lg.TenLoai AS TenLoaiGhe, lg.PhuPhi
                             FROM Ghe g
                             JOIN LoaiGhe lg ON g.idLoaiGhe = lg.id
                             WHERE g.idPhong = @IdPhong
                             ORDER BY g.Hang, g.So";
            SqlParameter[] prms = { new SqlParameter("@IdPhong", idPhong) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, prms);
            var list = new List<GheDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        /// <summary>Lấy danh sách id ghế đã bán cho 1 suất chiếu</summary>
        public List<int> GetGheDaBan(int idSuatChieu)
        {
            string query = "SELECT idGhe FROM Ve WHERE idSuatChieu = @IdSuatChieu";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new[] { new SqlParameter("@IdSuatChieu", idSuatChieu) });
            var list = new List<int>();
            foreach (DataRow row in dt.Rows) list.Add((int)row["idGhe"]);
            return list;
        }

        public bool Insert(GheDTO ghe)
        {
            string query = "INSERT INTO Ghe(idPhong, Hang, So, idLoaiGhe) VALUES(@IdPhong, @Hang, @So, @IdLoaiGhe)";
            SqlParameter[] prms = {
                new SqlParameter("@IdPhong", ghe.IdPhong),
                new SqlParameter("@Hang", ghe.Hang),
                new SqlParameter("@So", ghe.So),
                new SqlParameter("@IdLoaiGhe", ghe.IdLoaiGhe)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM Ghe WHERE id=@Id",
                new[] { new SqlParameter("@Id", id) }) > 0;
        }

        public bool DeleteByPhong(int idPhong)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM Ghe WHERE idPhong=@IdPhong",
                new[] { new SqlParameter("@IdPhong", idPhong) }) >= 0;
        }

        private GheDTO Map(DataRow row)
        {
            return new GheDTO
            {
                Id = (int)row["id"],
                IdPhong = (int)row["idPhong"],
                Hang = row["Hang"].ToString(),
                So = (int)row["So"],
                IdLoaiGhe = (int)row["idLoaiGhe"],
                TenLoaiGhe = row["TenLoaiGhe"].ToString(),
                PhuPhi = (decimal)row["PhuPhi"]
            };
        }
    }
}
