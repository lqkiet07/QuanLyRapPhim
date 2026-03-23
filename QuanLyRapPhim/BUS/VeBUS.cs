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

        public List<PhimDTO> GetPhimDangChieu()
        {
            var suatChieus = _dalSuatChieu.GetDangChieu();
            var seen = new HashSet<int>();
            var phims = new List<PhimDTO>();
            foreach (var sc in suatChieus)
            {
                if (!seen.Contains(sc.IdPhim))
                {
                    seen.Add(sc.IdPhim);
                    phims.Add(new PhimDTO { Id = sc.IdPhim, TenPhim = sc.TenPhim });
                }
            }
            return phims;
        }

        public List<SuatChieuDTO> GetSuatChieuByPhim(int idPhim) => _dalSuatChieu.GetDangChieuByPhim(idPhim);

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

        public (bool success, string message) BanTapTheVe(int idSuatChieu, List<GheDTO> danhSachGhe, int idNhanVien, decimal giaVeGoc)
        {
            var gheDaBan = _dalGhe.GetGheDaBan(idSuatChieu);
            foreach (var ghe in danhSachGhe)
            {
                if (gheDaBan.Contains(ghe.Id))
                    return (false, $"Ghế {ghe.MaGhe} đã được bán ngay trước đó. Vui lòng chọn lại!");
            }

            int thanhCong = 0;
            foreach (var ghe in danhSachGhe)
            {
                var ve = new VeDTO
                {
                    IdSuatChieu = idSuatChieu,
                    IdGhe = ghe.Id,
                    IdNhanVien = idNhanVien,
                    NgayBan = DateTime.Now,
                    TongTien = giaVeGoc + ghe.PhuPhi
                };
                if (_dalVe.BanVe(ve)) thanhCong++;
            }

            if (thanhCong == danhSachGhe.Count)
                return (true, $"Bán thành công {thanhCong} vé!");
            else
                return (false, $"Chỉ bán được {thanhCong}/{danhSachGhe.Count} vé do lỗi hệ thống SQL!");
        }


        public (bool success, string message) HuyVe(int idVe)
        {
            return _dalVe.Delete(idVe) ? (true, "Hủy vé thành công!") : (false, "Hủy vé thất bại!");
        }

        public List<VeDTO> GetVeBySuatChieu(int idSuatChieu) => _dalVe.GetBySuatChieu(idSuatChieu);
    }
}
