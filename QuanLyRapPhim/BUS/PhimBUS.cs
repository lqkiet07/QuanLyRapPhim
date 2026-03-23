using System.Collections.Generic;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS
{
    public class PhimBUS
    {
        private readonly PhimDAL _dalPhim = new PhimDAL();
        private readonly TheLoaiDAL _dalTheLoai = new TheLoaiDAL();

        public List<PhimDTO> GetAll() => _dalPhim.GetAll();
        public List<PhimDTO> Search(string keyword) => _dalPhim.Search(keyword);
        public List<TheLoaiDTO> GetAllTheLoai() => _dalTheLoai.GetAll();

        public (bool success, string message) Insert(PhimDTO phim)
        {
            if (string.IsNullOrWhiteSpace(phim.TenPhim))
                return (false, "Vui lòng nhập tên phim!");
            if (phim.ThoiLuong <= 0)
                return (false, "Thời lượng phải lớn hơn 0!");
            if (phim.IdTheLoai < 0)
                return (false, "Vui lòng chọn thể loại!");
            return _dalPhim.Insert(phim) ? (true, "Thêm phim thành công!") : (false, "Thêm phim thất bại!");
        }

        public (bool success, string message) Update(PhimDTO phim)
        {
            if (string.IsNullOrWhiteSpace(phim.TenPhim))
                return (false, "Vui lòng nhập tên phim!");
            if (phim.ThoiLuong <= 0)
                return (false, "Thời lượng phải lớn hơn 0!");
            if (phim.IdTheLoai < 0)
                return (false, "Vui lòng chọn thể loại!");
            return _dalPhim.Update(phim) ? (true, "Cập nhật phim thành công!") : (false, "Cập nhật thất bại!");
        }

        public (bool success, string message) Delete(int id)
        {
            return _dalPhim.Delete(id)
                ? (true, "Xóa phim thành công!")
                : (false, "Xóa thất bại! Phim đang có suất chiếu.");
        }

        public (bool success, string message) InsertTheLoai(TheLoaiDTO tl)
        {
            if (string.IsNullOrWhiteSpace(tl.TenTheLoai)) return (false, "Vui lòng nhập tên thể loại!");
            return _dalTheLoai.Insert(tl) ? (true, "Thêm thể loại thành công!") : (false, "Thêm thất bại!");
        }

        public (bool success, string message) DeleteTheLoai(int id)
        {
            return _dalTheLoai.Delete(id) ? (true, "Xóa thể loại thành công!") : (false, "Xóa thất bại! Thể loại đang được sử dụng.");
        }
    }
}
