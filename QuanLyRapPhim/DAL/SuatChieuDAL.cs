using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class SuatChieuDAL
    {
        public List<SuatChieuDTO> GetAll()
        {
            string query = @"SELECT sc.id, sc.idPhim, sc.idPhong, sc.GiaVe, sc.TrangThai, sc.ThoiGian,
                                    p.TenPhim, pc.TenPhong
                             FROM SuatChieu sc
                             JOIN Phim p ON sc.idPhim = p.id
                             JOIN PhongChieu pc ON sc.idPhong = pc.id
                             ORDER BY sc.ThoiGian DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            var list = new List<SuatChieuDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        public List<SuatChieuDTO> GetDangChieu()
        {
            string query = @"SELECT sc.id, sc.idPhim, sc.idPhong, sc.GiaVe, sc.TrangThai, sc.ThoiGian,
                                    p.TenPhim, pc.TenPhong
                             FROM SuatChieu sc
                             JOIN Phim p ON sc.idPhim = p.id
                             JOIN PhongChieu pc ON sc.idPhong = pc.id
                             WHERE sc.TrangThai = 1
                             ORDER BY sc.ThoiGian";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            var list = new List<SuatChieuDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        public bool Insert(SuatChieuDTO sc)
        {
            string query = @"INSERT INTO SuatChieu(idPhim, idPhong, GiaVe, TrangThai, ThoiGian)
                             VALUES(@IdPhim, @IdPhong, @GiaVe, @TrangThai, @ThoiGian)";
            SqlParameter[] prms = {
                new SqlParameter("@IdPhim", sc.IdPhim),
                new SqlParameter("@IdPhong", sc.IdPhong),
                new SqlParameter("@GiaVe", sc.GiaVe),
                new SqlParameter("@TrangThai", sc.TrangThai),
                new SqlParameter("@ThoiGian", sc.ThoiGian)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Update(SuatChieuDTO sc)
        {
            string query = @"UPDATE SuatChieu SET idPhim=@IdPhim, idPhong=@IdPhong,
                             GiaVe=@GiaVe, TrangThai=@TrangThai, ThoiGian=@ThoiGian WHERE id=@Id";
            SqlParameter[] prms = {
                new SqlParameter("@IdPhim", sc.IdPhim),
                new SqlParameter("@IdPhong", sc.IdPhong),
                new SqlParameter("@GiaVe", sc.GiaVe),
                new SqlParameter("@TrangThai", sc.TrangThai),
                new SqlParameter("@ThoiGian", sc.ThoiGian),
                new SqlParameter("@Id", sc.Id)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM SuatChieu WHERE id=@Id",
                new[] { new SqlParameter("@Id", id) }) > 0;
        }

        /// <summary>Kiểm tra xung đột: cùng phòng, thời gian chênh lệch < 3 tiếng</summary>
        public bool IsConflict(int idPhong, DateTime thoiGian, int excludeId = 0)
        {
            string query = @"SELECT COUNT(*) FROM SuatChieu
                             WHERE idPhong = @IdPhong AND id != @ExcludeId
                             AND ABS(DATEDIFF(MINUTE, ThoiGian, @ThoiGian)) < 180";
            SqlParameter[] prms = {
                new SqlParameter("@IdPhong", idPhong),
                new SqlParameter("@ThoiGian", thoiGian),
                new SqlParameter("@ExcludeId", excludeId)
            };
            return (int)DataProvider.Instance.ExecuteScalar(query, prms) > 0;
        }

        private SuatChieuDTO Map(DataRow row)
        {
            return new SuatChieuDTO
            {
                Id = (int)row["id"],
                IdPhim = (int)row["idPhim"],
                IdPhong = (int)row["idPhong"],
                GiaVe = (decimal)row["GiaVe"],
                TrangThai = (bool)row["TrangThai"],
                ThoiGian = Convert.ToDateTime(row["ThoiGian"]),
                TenPhim = row["TenPhim"].ToString(),
                TenPhong = row["TenPhong"].ToString()
            };
        }
    }
}
