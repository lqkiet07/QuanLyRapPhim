using System.Collections.Generic;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS
{
    public class PhongChieuBUS
    {
        private readonly PhongChieuDAL _dalPhong = new PhongChieuDAL();
        private readonly GheDAL _dalGhe = new GheDAL();
        private readonly LoaiGheDAL _dalLoaiGhe = new LoaiGheDAL();

        public List<PhongChieuDTO> GetAll() => _dalPhong.GetAll();
        public List<GheDTO> GetGheByPhong(int idPhong) => _dalGhe.GetByPhong(idPhong);
        public List<LoaiGheDTO> GetAllLoaiGhe() => _dalLoaiGhe.GetAll();

        public (bool success, string message) Insert(PhongChieuDTO phong)
        {
            if (string.IsNullOrWhiteSpace(phong.TenPhong))
                return (false, "Vui lòng nhập tên phòng!");
            if (phong.SoCho <= 0)
                return (false, "Số chỗ phải lớn hơn 0!");
            return _dalPhong.Insert(phong) ? (true, "Thêm phòng chiếu thành công!") : (false, "Thêm thất bại!");
        }

        public (bool success, string message) Update(PhongChieuDTO phong)
        {
            if (string.IsNullOrWhiteSpace(phong.TenPhong))
                return (false, "Vui lòng nhập tên phòng!");
            if (phong.SoCho <= 0)
                return (false, "Số chỗ phải lớn hơn 0!");
            return _dalPhong.Update(phong) ? (true, "Cập nhật thành công!") : (false, "Cập nhật thất bại!");
        }

        public (bool success, string message) Delete(int id)
        {
            return _dalPhong.Delete(id)
                ? (true, "Xóa phòng chiếu thành công!")
                : (false, "Xóa thất bại! Phòng đang có suất chiếu.");
        }
    }
}
