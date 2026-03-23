using System.Collections.Generic;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL _dal = new NhanVienDAL();


        public NhanVienDTO DangNhap(string taiKhoan, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
                return null;
            return _dal.DangNhap(taiKhoan.Trim(), matKhau.Trim());
        }

        public List<NhanVienDTO> GetAll() => _dal.GetAll();

        public (bool success, string message) Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                return (false, "Vui lòng nhập họ tên nhân viên!");
            if (string.IsNullOrWhiteSpace(nv.TaiKhoan))
                return (false, "Vui lòng nhập tài khoản!");
            if (string.IsNullOrWhiteSpace(nv.MatKhau))
                return (false, "Vui lòng nhập mật khẩu!");
            if (_dal.IsTaiKhoanExist(nv.TaiKhoan.Trim()))
                return (false, "Tài khoản đã tồn tại!");
            nv.TaiKhoan = nv.TaiKhoan.Trim();
            nv.MatKhau = nv.MatKhau.Trim();
            return _dal.Insert(nv) ? (true, "Thêm nhân viên thành công!") : (false, "Thêm nhân viên thất bại!");
        }

        public (bool success, string message) Update(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                return (false, "Vui lòng nhập họ tên nhân viên!");
            if (string.IsNullOrWhiteSpace(nv.TaiKhoan))
                return (false, "Vui lòng nhập tài khoản!");
            if (string.IsNullOrWhiteSpace(nv.MatKhau))
                return (false, "Vui lòng nhập mật khẩu!");
            if (_dal.IsTaiKhoanExist(nv.TaiKhoan.Trim(), nv.Id))
                return (false, "Tài khoản đã tồn tại!");
            return _dal.Update(nv) ? (true, "Cập nhật thành công!") : (false, "Cập nhật thất bại!");
        }

        public (bool success, string message) Delete(int id)
        {
            return _dal.Delete(id) ? (true, "Xóa thành công!") : (false, "Xóa thất bại! Nhân viên đã có vé bán.");
        }
    }
}
