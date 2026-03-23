using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class PhongChieuDAL
    {
        public List<PhongChieuDTO> GetAll()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT id, TenPhong, SoCho, TinhTrang FROM PhongChieu ORDER BY TenPhong");
            var list = new List<PhongChieuDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        //trả về ID phòng mới sau khi thêm
        public int Insert(PhongChieuDTO p)
        {
            string query = @"INSERT INTO PhongChieu(TenPhong, SoCho, TinhTrang) VALUES(@TenPhong, @SoCho, @TinhTrang);
                             SELECT CAST(SCOPE_IDENTITY() AS INT)";
            SqlParameter[] prms = {
                new SqlParameter("@TenPhong", p.TenPhong),
                new SqlParameter("@SoCho", p.SoCho),
                new SqlParameter("@TinhTrang", p.TinhTrang)
            };
            object result = DataProvider.Instance.ExecuteScalar(query, prms);
            return result != null ? (int)result : 0;
        }

        public bool Update(PhongChieuDTO p)
        {
            string query = "UPDATE PhongChieu SET TenPhong=@TenPhong, SoCho=@SoCho, TinhTrang=@TinhTrang WHERE id=@Id";
            SqlParameter[] prms = {
                new SqlParameter("@TenPhong", p.TenPhong),
                new SqlParameter("@SoCho", p.SoCho),
                new SqlParameter("@TinhTrang", p.TinhTrang),
                new SqlParameter("@Id", p.Id)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("DELETE FROM PhongChieu WHERE id=@Id",
                    new[] { new SqlParameter("@Id", id) }) > 0;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        private PhongChieuDTO Map(DataRow row)
        {
            return new PhongChieuDTO
            {
                Id = (int)row["id"],
                TenPhong = row["TenPhong"].ToString(),
                SoCho = (int)row["SoCho"],
                TinhTrang = (bool)row["TinhTrang"]
            };
        }
    }
}
