using System;
using System.Collections.Generic;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS
{
    public class SuatChieuBUS
    {
        private readonly SuatChieuDAL _dal = new SuatChieuDAL();
        private readonly PhimDAL _dalPhim = new PhimDAL();
        private readonly PhongChieuDAL _dalPhong = new PhongChieuDAL();

        public List<SuatChieuDTO> GetAll() => _dal.GetAll();
        public List<SuatChieuDTO> GetDangChieu() => _dal.GetDangChieu();
        public List<PhimDTO> GetAllPhim() => _dalPhim.GetAll();
        public List<PhongChieuDTO> GetAllPhong() => _dalPhong.GetAll();

        public (bool success, string message) Insert(SuatChieuDTO sc)
        {
            if (sc.IdPhim <= 0) return (false, "Vui lòng chọn phim!");
            if (sc.IdPhong <= 0) return (false, "Vui lòng chọn phòng chiếu!");
            if (sc.GiaVe <= 0) return (false, "Giá vé phải lớn hơn 0!");
            if (sc.ThoiGian <= DateTime.Now)
                return (false, "Thời gian chiếu phải sau thời điểm hiện tại!");
            if (_dal.IsConflict(sc.IdPhong, sc.ThoiGian))
                return (false, "Phòng chiếu đã có suất khác trong khung giờ này (cách < 3 tiếng)!");
            return _dal.Insert(sc) ? (true, "Thêm suất chiếu thành công!") : (false, "Thêm thất bại!");
        }

        public (bool success, string message) Update(SuatChieuDTO sc)
        {
            if (sc.IdPhim <= 0) return (false, "Vui lòng chọn phim!");
            if (sc.IdPhong <= 0) return (false, "Vui lòng chọn phòng chiếu!");
            if (sc.GiaVe <= 0) return (false, "Giá vé phải lớn hơn 0!");
            if (_dal.IsConflict(sc.IdPhong, sc.ThoiGian, sc.Id))
                return (false, "Phòng chiếu đã có suất khác trong khung giờ này!");
            return _dal.Update(sc) ? (true, "Cập nhật suất chiếu thành công!") : (false, "Cập nhật thất bại!");
        }

        public (bool success, string message) Delete(int id)
        {
            return _dal.Delete(id) ? (true, "Xóa suất chiếu thành công!") : (false, "Xóa thất bại! Suất chiếu đã có vé.");
        }
    }
}
