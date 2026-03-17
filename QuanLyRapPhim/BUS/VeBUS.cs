using System;
using System.Collections.Generic;
using QuanLyRapPhim.DAL;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.BUS
{
    public class VeBUS
    {
        private readonly VeDAL _dalVe = new VeDAL();
        private readonly GheDAL _dalGhe = new GheDAL();
        private readonly SuatChieuDAL _dalSuatChieu = new SuatChieuDAL();

        public List<SuatChieuDTO> GetSuatChieuDangChieu() => _dalSuatChieu.GetDangChieu();

        public List<GheDTO> GetGheVaSuatChieu(int idSuatChieu, int idPhong)
        {
            var danhSachGhe = _dalGhe.GetByPhong(idPhong);
            var gheDaBan = new HashSet<int>(_dalGhe.GetGheDaBan(idSuatChieu));
            foreach (var ghe in danhSachGhe)
                if (gheDaBan.Contains(ghe.Id))
                    ghe.TenLoaiGhe = "[ĐÃ BÁN] " + ghe.TenLoaiGhe;
            return danhSachGhe;
        }

        public List<int> GetGheDaBan(int idSuatChieu) => _dalGhe.GetGheDaBan(idSuatChieu);

        public (bool success, string message) BanVe(int idSuatChieu, int idGhe, int idNhanVien, decimal tongTien)
        {
            var gheDaBan = _dalGhe.GetGheDaBan(idSuatChieu);
            if (gheDaBan.Contains(idGhe))
                return (false, "Ghế này đã được bán rồi!");

            var ve = new VeDTO
            {
                IdSuatChieu = idSuatChieu,
                IdGhe = idGhe,
                IdNhanVien = idNhanVien,
                NgayBan = DateTime.Now,
                TongTien = tongTien
            };
            return _dalVe.BanVe(ve) ? (true, "Bán vé thành công!") : (false, "Bán vé thất bại!");
        }

        public (bool success, string message) HuyVe(int idVe)
        {
            return _dalVe.Delete(idVe) ? (true, "Hủy vé thành công!") : (false, "Hủy vé thất bại!");
        }

        public List<VeDTO> GetVeBySuatChieu(int idSuatChieu) => _dalVe.GetBySuatChieu(idSuatChieu);
    }
}
