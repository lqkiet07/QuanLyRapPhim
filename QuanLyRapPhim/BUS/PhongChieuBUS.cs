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

            int newId = _dalPhong.Insert(phong);
            if (newId <= 0)
                return (false, "Thêm thất bại!");

            //obj for auto generate seats by rows
            int gheConLai = phong.SoCho;
            int soCotMoiHang = 6;
            int hangIndex = 0;
            var loaiGhes = _dalLoaiGhe.GetAll();
            int idThuong = loaiGhes.Count > 0 ? loaiGhes[0].Id : 1;
            int idVIP = loaiGhes.Count > 1 ? loaiGhes[1].Id : idThuong;

            //obj for calculate total rows
            int tongHang = (gheConLai + soCotMoiHang - 1) / soCotMoiHang;

            while (gheConLai > 0)
            {
                string hang = ((char)('A' + hangIndex)).ToString();
                int soGheTrongHang = gheConLai >= soCotMoiHang ? soCotMoiHang : gheConLai;
                bool isLastRow = (hangIndex == tongHang - 1);

                for (int so = 1; so <= soGheTrongHang; so++)
                {
                    _dalGhe.Insert(new GheDTO
                    {
                        IdPhong = newId,
                        Hang = hang,
                        So = so,
                        IdLoaiGhe = isLastRow ? idVIP : idThuong
                    });
                }
                gheConLai -= soGheTrongHang;
                hangIndex++;
            }

            return (true, $"Thêm phòng thành công! Đã tạo {phong.SoCho} ghế ({tongHang} hàng, hàng cuối VIP).");
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
