using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class TheLoaiDAL
    {
        public List<TheLoaiDTO> GetAll()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT id, TenTheLoai FROM TheLoai ORDER BY TenTheLoai");
            var list = new List<TheLoaiDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new TheLoaiDTO { Id = (int)row["id"], TenTheLoai = row["TenTheLoai"].ToString() });
            return list;
        }

        public bool Insert(TheLoaiDTO tl)
        {
            string query = "INSERT INTO TheLoai(TenTheLoai) VALUES(@Ten)";
            return DataProvider.Instance.ExecuteNonQuery(query, new[] { new SqlParameter("@Ten", tl.TenTheLoai) }) > 0;
        }

        public bool Update(TheLoaiDTO tl)
        {
            string query = "UPDATE TheLoai SET TenTheLoai=@Ten WHERE id=@Id";
            SqlParameter[] prms = { new SqlParameter("@Ten", tl.TenTheLoai), new SqlParameter("@Id", tl.Id) };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("DELETE FROM TheLoai WHERE id=@Id",
                    new[] { new SqlParameter("@Id", id) }) > 0;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
