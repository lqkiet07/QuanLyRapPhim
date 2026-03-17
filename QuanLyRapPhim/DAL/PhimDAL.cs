using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class PhimDAL
    {
        public List<PhimDTO> GetAll()
        {
            string query = @"SELECT p.id, p.TenPhim, p.ThoiLuong, p.NgayKhoiChieu, p.NgayKetThuc,
                                    p.DaoDien, p.idTheLoai, tl.TenTheLoai
                             FROM Phim p JOIN TheLoai tl ON p.idTheLoai = tl.id
                             ORDER BY p.TenPhim";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            var list = new List<PhimDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        public List<PhimDTO> Search(string keyword)
        {
            string query = @"SELECT p.id, p.TenPhim, p.ThoiLuong, p.NgayKhoiChieu, p.NgayKetThuc,
                                    p.DaoDien, p.idTheLoai, tl.TenTheLoai
                             FROM Phim p JOIN TheLoai tl ON p.idTheLoai = tl.id
                             WHERE p.TenPhim LIKE @Keyword OR p.DaoDien LIKE @Keyword";
            SqlParameter[] prms = { new SqlParameter("@Keyword", "%" + keyword + "%") };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, prms);
            var list = new List<PhimDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        public bool Insert(PhimDTO phim)
        {
            string query = @"INSERT INTO Phim(TenPhim, ThoiLuong, NgayKhoiChieu, NgayKetThuc, DaoDien, idTheLoai)
                             VALUES(@TenPhim, @ThoiLuong, @NgayKhoiChieu, @NgayKetThuc, @DaoDien, @IdTheLoai)";
            SqlParameter[] prms = {
                new SqlParameter("@TenPhim", phim.TenPhim),
                new SqlParameter("@ThoiLuong", phim.ThoiLuong),
                new SqlParameter("@NgayKhoiChieu", (object)phim.NgayKhoiChieu ?? DBNull.Value),
                new SqlParameter("@NgayKetThuc", (object)phim.NgayKetThuc ?? DBNull.Value),
                new SqlParameter("@DaoDien", (object)phim.DaoDien ?? DBNull.Value),
                new SqlParameter("@IdTheLoai", phim.IdTheLoai)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Update(PhimDTO phim)
        {
            string query = @"UPDATE Phim SET TenPhim=@TenPhim, ThoiLuong=@ThoiLuong,
                             NgayKhoiChieu=@NgayKhoiChieu, NgayKetThuc=@NgayKetThuc,
                             DaoDien=@DaoDien, idTheLoai=@IdTheLoai WHERE id=@Id";
            SqlParameter[] prms = {
                new SqlParameter("@TenPhim", phim.TenPhim),
                new SqlParameter("@ThoiLuong", phim.ThoiLuong),
                new SqlParameter("@NgayKhoiChieu", (object)phim.NgayKhoiChieu ?? DBNull.Value),
                new SqlParameter("@NgayKetThuc", (object)phim.NgayKetThuc ?? DBNull.Value),
                new SqlParameter("@DaoDien", (object)phim.DaoDien ?? DBNull.Value),
                new SqlParameter("@IdTheLoai", phim.IdTheLoai),
                new SqlParameter("@Id", phim.Id)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM Phim WHERE id=@Id",
                new[] { new SqlParameter("@Id", id) }) > 0;
        }

        private PhimDTO Map(DataRow row)
        {
            return new PhimDTO
            {
                Id = (int)row["id"],
                TenPhim = row["TenPhim"].ToString(),
                ThoiLuong = Convert.ToDouble(row["ThoiLuong"]),
                NgayKhoiChieu = row["NgayKhoiChieu"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKhoiChieu"]),
                NgayKetThuc = row["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKetThuc"]),
                DaoDien = row["DaoDien"] == DBNull.Value ? "" : row["DaoDien"].ToString(),
                IdTheLoai = (int)row["idTheLoai"],
                TenTheLoai = row["TenTheLoai"].ToString()
            };
        }
    }
}
