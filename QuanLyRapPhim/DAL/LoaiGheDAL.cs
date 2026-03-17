using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class LoaiGheDAL
    {
        public List<LoaiGheDTO> GetAll()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT id, TenLoai, PhuPhi FROM LoaiGhe ORDER BY TenLoai");
            var list = new List<LoaiGheDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new LoaiGheDTO { Id = (int)row["id"], TenLoai = row["TenLoai"].ToString(), PhuPhi = (decimal)row["PhuPhi"] });
            return list;
        }
    }
}
