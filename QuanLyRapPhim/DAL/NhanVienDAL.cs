using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.DAL
{
    public class NhanVienDAL
    {
        public NhanVienDTO DangNhap(string taiKhoan, string matKhau)
        {
            string query = @"SELECT nv.id, nv.HoTen, nv.TaiKhoan, nv.MatKhau, nv.idLoai, ln.TenLoaiNV
                             FROM NhanVien nv
                             JOIN LoaiNV ln ON nv.idLoai = ln.id
                             WHERE nv.TaiKhoan = @TaiKhoan AND nv.MatKhau = @MatKhau";
            SqlParameter[] prms = {
                new SqlParameter("@TaiKhoan", taiKhoan),
                new SqlParameter("@MatKhau", matKhau)
            };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, prms);
            if (dt.Rows.Count == 0) return null;
            return Map(dt.Rows[0]);
        }

        public List<NhanVienDTO> GetAll()
        {
            string query = @"SELECT nv.id, nv.HoTen, nv.TaiKhoan, nv.MatKhau, nv.idLoai, ln.TenLoaiNV
                             FROM NhanVien nv JOIN LoaiNV ln ON nv.idLoai = ln.id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            var list = new List<NhanVienDTO>();
            foreach (DataRow row in dt.Rows) list.Add(Map(row));
            return list;
        }

        //load danh sách loại nhân viên từ database
        public List<LoaiNVDTO> GetAllLoaiNV()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT id, TenLoaiNV FROM LoaiNV ORDER BY id");
            var list = new List<LoaiNVDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new LoaiNVDTO { Id = (int)row["id"], TenLoaiNV = row["TenLoaiNV"].ToString() });
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            string query = "INSERT INTO NhanVien(HoTen, TaiKhoan, MatKhau, idLoai) VALUES(@HoTen, @TaiKhoan, @MatKhau, @IdLoai)";
            SqlParameter[] prms = {
                new SqlParameter("@HoTen", nv.HoTen),
                new SqlParameter("@TaiKhoan", nv.TaiKhoan),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@IdLoai", nv.IdLoai)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Update(NhanVienDTO nv)
        {
            string query = "UPDATE NhanVien SET HoTen=@HoTen, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, idLoai=@IdLoai WHERE id=@Id";
            SqlParameter[] prms = {
                new SqlParameter("@HoTen", nv.HoTen),
                new SqlParameter("@TaiKhoan", nv.TaiKhoan),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@IdLoai", nv.IdLoai),
                new SqlParameter("@Id", nv.Id)
            };
            return DataProvider.Instance.ExecuteNonQuery(query, prms) > 0;
        }

        public bool Delete(int id)
        {
            try
            {
                string query = "DELETE FROM NhanVien WHERE id = @Id";
                return DataProvider.Instance.ExecuteNonQuery(query, new[] { new SqlParameter("@Id", id) }) > 0;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool IsTaiKhoanExist(string taiKhoan, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @TaiKhoan AND id != @ExcludeId";
            SqlParameter[] prms = {
                new SqlParameter("@TaiKhoan", taiKhoan),
                new SqlParameter("@ExcludeId", excludeId)
            };
            return (int)DataProvider.Instance.ExecuteScalar(query, prms) > 0;
        }

        private NhanVienDTO Map(DataRow row)
        {
            return new NhanVienDTO
            {
                Id = (int)row["id"],
                HoTen = row["HoTen"].ToString(),
                TaiKhoan = row["TaiKhoan"].ToString(),
                MatKhau = row["MatKhau"].ToString(),
                IdLoai = (int)row["idLoai"],
                TenLoaiNV = row["TenLoaiNV"].ToString()
            };
        }
    }
}
