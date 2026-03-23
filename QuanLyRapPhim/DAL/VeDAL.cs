using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;


namespace QuanLyRapPhim.DAL
{
    public class VeDAL
    {
        public bool BanVe(VeDTO ve)
        {
            string query = @"INSERT INTO Ve(idSuatChieu, idGhe, idNhanVien, NgayBan, TongTien)
                             VALUES(@IdSuatChieu, @IdGhe, @IdNhanVien, @NgayBan, @TongTien)";
            SqlParameter[] prms = {
                new SqlParameter("@IdSuatChieu", ve.IdSuatChieu),
                new SqlParameter("@IdGhe", ve.IdGhe),
                new SqlParameter("@IdNhanVien", ve.IdNhanVien),
                new SqlParameter("@NgayBan", ve.NgayBan),
                new SqlParameter("@TongTien", ve.TongTien)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public List<VeDTO> GetBySuatChieu(int idSuatChieu)
        {
            string query = @"SELECT v.id, v.idSuatChieu, v.idGhe, v.idNhanVien, v.NgayBan, v.TongTien,
                                    g.Hang + CAST(g.So AS varchar) AS MaGhe,
                                    p.TenPhim, pc.TenPhong, sc.ThoiGian AS ThoiGianChieu,
                                    nv.HoTen AS TenNhanVien
                             FROM Ve v
                             JOIN Ghe g ON v.idGhe = g.id
                             JOIN SuatChieu sc ON v.idSuatChieu = sc.id
                             JOIN Phim p ON sc.idPhim = p.id
                             JOIN PhongChieu pc ON sc.idPhong = pc.id
                             JOIN NhanVien nv ON v.idNhanVien = nv.id
                             WHERE v.idSuatChieu = @IdSuatChieu";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new[] { new SqlParameter("@IdSuatChieu", idSuatChieu) });
            var list = new List<VeDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        public bool Delete(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM Ve WHERE id=@Id",
                new[] { new SqlParameter("@Id", id) }) > 0;
        }

        private VeDTO Map(DataRow row)
        {
            return new VeDTO
            {
                Id = (int)row["id"],
                IdSuatChieu = (int)row["idSuatChieu"],
                IdGhe = (int)row["idGhe"],
                IdNhanVien = (int)row["idNhanVien"],
                NgayBan = Convert.ToDateTime(row["NgayBan"]),
                TongTien = (decimal)row["TongTien"],
                MaGhe = row["MaGhe"].ToString(),
                TenPhim = row["TenPhim"].ToString(),
                TenPhong = row["TenPhong"].ToString(),
                ThoiGianChieu = Convert.ToDateTime(row["ThoiGianChieu"]),
                TenNhanVien = row["TenNhanVien"].ToString()
            };
        }
    }
}
