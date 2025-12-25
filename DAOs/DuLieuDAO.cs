using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace TTCSDL_NHOM7.DAOs
{
    internal class DuLieuDAO
    {
        private static object ToDbValue(object value) => value == null || string.IsNullOrWhiteSpace(value.ToString()) ? DBNull.Value : value;

        // Thao tác với bảng thể loại
        #region TheLoai
        private static DataTable TheLoai_CRUD(string action, string maTheLoai = null, string tenTheLoai = null, string moTa = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_TheLoai_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@MaTheLoai", ToDbValue(maTheLoai)),
                new SqlParameter("@TenTheLoai", ToDbValue(tenTheLoai)),
                new SqlParameter("@MoTa", ToDbValue(moTa))
            );
        }

        public static DataTable GetAll_TheLoai() => TheLoai_CRUD("GET_ALL");
        public static DataTable Search_TheLoai(string maTheLoai = null, string tenTheLoai = null) => TheLoai_CRUD("SEARCH", maTheLoai, tenTheLoai);

        public static int Insert_TheLoai(string tenTheLoai, string moTa)
        {
            var dt = TheLoai_CRUD("INSERT", tenTheLoai: tenTheLoai, moTa: moTa);
            return dt != null ? 1 : 0;
        }

        public static int Update_TheLoai(string maTheLoai, string tenTheLoai, string moTa)
        {
            var dt = TheLoai_CRUD("UPDATE", maTheLoai, tenTheLoai, moTa);
            return dt != null ? 1 : 0;
        }
        public static int Delete_TheLoai(string maTheLoai)
        {
            var dt = TheLoai_CRUD("DELETE", maTheLoai);
            return dt != null ? 1 : 0;
        }

        #endregion /

        // Thao tác với bảng định dạng
        #region DinhDang
        private static DataTable DinhDang_CRUD(string action, string maDinhDang = null, string maPhim = null, string maManHinh = null,
            string tenPhim = null, string tenManHinh = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_DinhDang_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@MaDinhDang", ToDbValue(maDinhDang)),
                new SqlParameter("@MaPhim", ToDbValue(maPhim)),
                new SqlParameter("@MaManHinh", ToDbValue(maManHinh)),
                new SqlParameter("@TenPhim", ToDbValue(tenPhim)),
                new SqlParameter("@TenManHinh", ToDbValue(tenManHinh))
            );
        }

        public static DataTable GetAll_DinhDang() => DinhDang_CRUD("GET_ALL");
        public static DataTable Search_DinhDang(string maDinhDang = null, string maPhim = null, string maManHinh = null,
            string tenPhim = null, string tenManHinh = null) => DinhDang_CRUD("SEARCH", maDinhDang, maPhim, maManHinh, tenPhim, tenManHinh);

        public static int Insert_DinhDang(string maPhim, string maManHinh)
        {
            var dt = DinhDang_CRUD("INSERT", maPhim: maPhim, maManHinh: maManHinh);
            return dt != null ? 1 : 0;
        }

        public static int Update_DinhDang(string maDinhDang, string maPhim, string maManHinh)
        {
            var dt = DinhDang_CRUD("UPDATE", maDinhDang: maDinhDang, maPhim: maPhim, maManHinh: maManHinh);
            return dt != null ? 1 : 0;
        }

        public static int Delete_DinhDang(string maDinhDang)
        {
            var dt = DinhDang_CRUD("DELETE", maDinhDang: maDinhDang);
            return dt != null ? 1 : 0;
        }
        #endregion

        // Thao tác với bảng lịch chiếu
        #region LichChieu
        private static DataTable LichChieu_CRUD(string action, string maLichChieu = null, string maDinhDang = null, string maPhong = null,
            DateTime? thoiGianChieu = null, decimal? giaVe = null, string tenPhim = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_LichChieu_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@MaLichChieu", ToDbValue(maLichChieu)),
                new SqlParameter("@MaDinhDang", ToDbValue(maDinhDang)),
                new SqlParameter("@MaPhong", ToDbValue(maPhong)),
                new SqlParameter("@ThoiGianChieu", ToDbValue(thoiGianChieu)),
                new SqlParameter("@GiaVe", ToDbValue(giaVe)),
                new SqlParameter("@TenPhim", ToDbValue(tenPhim))
            );
        }

        public static DataTable GetAll_LichChieu() => LichChieu_CRUD("GET_ALL");
        public static DataTable Search_LichChieu(string tenPhim = null, string maLichChieu = null) => LichChieu_CRUD("SEARCH", tenPhim: tenPhim, maLichChieu: maLichChieu);

        public static int Insert_LichChieu(string maDinhDang, string maPhong, DateTime thoiGianChieu, decimal giaVe)
        {
            var dt = LichChieu_CRUD("INSERT", maDinhDang: maDinhDang, maPhong: maPhong, thoiGianChieu: thoiGianChieu, giaVe: giaVe);
            return dt != null ? 1 : 0;
        }

        public static int Update_LichChieu(string maLichChieu, string maDinhDang, string maPhong, DateTime thoiGianChieu, decimal giaVe)
        {
            var dt = LichChieu_CRUD("UPDATE", maLichChieu: maLichChieu, maDinhDang: maDinhDang, maPhong: maPhong, thoiGianChieu: thoiGianChieu, giaVe: giaVe);
            return dt != null ? 1 : 0;
        }

        public static int Delete_LichChieu(string maLichChieu)
        {
            var dt = LichChieu_CRUD("DELETE", maLichChieu: maLichChieu);
            return dt != null ? 1 : 0;
        }
        #endregion

        // Thao tác với bảng phòng chiếu
        #region PhongChieu
        private static DataTable PhongChieu_CRUD(string action, string idPhong = null, string tenPhong = null, string idMH = null,
            int? soChoNgoi = null, int? tinhTrang = null, int? soHangGhe = null, int? soGheMotHang = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_PhongChieu_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@idPhong", ToDbValue(idPhong)),
                new SqlParameter("@tenPhong", ToDbValue(tenPhong)),
                new SqlParameter("@idMH", ToDbValue(idMH)),
                new SqlParameter("@soChoNgoi", ToDbValue(soChoNgoi)),
                new SqlParameter("@tinhTrang", ToDbValue(tinhTrang)),
                new SqlParameter("@soHangGhe", ToDbValue(soHangGhe)),
                new SqlParameter("@soGheMotHang", ToDbValue(soGheMotHang))
            );
        }

        public static DataTable GetAll_PhongChieu() => PhongChieu_CRUD("GET_ALL");

        public static DataTable Search_PhongChieu(string tenPhong = null, string soChoNgoi = null, string tinhTrang = null)
        {
            int? soChoNgoi_int = null;
            int? tinhTrang_int = null;
            if (!string.IsNullOrWhiteSpace(soChoNgoi) && int.TryParse(soChoNgoi, out int tmpSoCho))
                soChoNgoi_int = tmpSoCho;
            if (!string.IsNullOrWhiteSpace(tinhTrang) && int.TryParse(tinhTrang, out int tmpTinhTrang))
                tinhTrang_int = tmpTinhTrang;

            return PhongChieu_CRUD("SEARCH", tenPhong: tenPhong, soChoNgoi: soChoNgoi_int, tinhTrang: tinhTrang_int);
        }

        public static int Insert_PhongChieu(string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMotHang)
        {
            var dt = PhongChieu_CRUD("INSERT", tenPhong: tenPhong, idMH: idMH, soChoNgoi: soChoNgoi,
                                      tinhTrang: tinhTrang, soHangGhe: soHangGhe, soGheMotHang: soGheMotHang);
            return dt != null ? 1 : 0;
        }

        public static int Update_PhongChieu(string idPhong, string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMotHang)
        {
            var dt = PhongChieu_CRUD("UPDATE", idPhong: idPhong, tenPhong: tenPhong, idMH: idMH, soChoNgoi: soChoNgoi,
                                      tinhTrang: tinhTrang, soHangGhe: soHangGhe, soGheMotHang: soGheMotHang);
            return dt != null ? 1 : 0;
        }

        public static int Delete_PhongChieu(string idPhong)
        {
            var dt = PhongChieu_CRUD("DELETE", idPhong: idPhong);
            return dt != null ? 1 : 0;
        }
        #endregion

        // Thao tác với bảng phim
        #region Phim
        private static DataTable Phim_CRUD(
            string action,
            string maPhim = null,
            string tenPhim = null,
            string moTa = null,
            float? thoiLuong = null,
            DateTime? ngayKhoiChieu = null,
            DateTime? ngayKetThuc = null,
            string sanXuat = null,
            string daoDien = null,
            int? namSX = null,
            byte[] apPhich = null,
            string maTheLoai = null
        )
        {
            return DataProvider.ExecuteQuery(
                "USP_Phim_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@MaPhim", ToDbValue(maPhim)),
                new SqlParameter("@TenPhim", ToDbValue(tenPhim)),
                new SqlParameter("@MoTa", ToDbValue(moTa)),
                new SqlParameter("@ThoiLuong", ToDbValue(thoiLuong)),
                new SqlParameter("@NgayKhoiChieu", ToDbValue(ngayKhoiChieu)),
                new SqlParameter("@NgayKetThuc", ToDbValue(ngayKetThuc)),
                new SqlParameter("@SanXuat", ToDbValue(sanXuat)),
                new SqlParameter("@DaoDien", ToDbValue(daoDien)),
                new SqlParameter("@NamSX", ToDbValue(namSX)),
                new SqlParameter("@ApPhich", SqlDbType.Image) { Value = ToDbValue(apPhich) },
                new SqlParameter("@MaTheLoai", ToDbValue(maTheLoai))
            );
        }
        public static DataTable GetAll_Phim()
            => Phim_CRUD("GET_ALL");
        public static DataTable Search_Phim(string maPhim, string tenPhim, string namSX)
        {
            int? nam = int.TryParse(namSX, out int n) ? n : null;
            return Phim_CRUD("SEARCH", maPhim, tenPhim, namSX: nam);
        }
        public static void Insert_Phim(
            string tenPhim,
            string moTa,
            float thoiLuong,
            DateTime ngayKhoiChieu,
            DateTime ngayKetThuc,
            string sanXuat,
            string daoDien,
            int namSX,
            byte[] apPhich
        )
        {
            Phim_CRUD(
                "INSERT",
                tenPhim: tenPhim,
                moTa: moTa,
                thoiLuong: thoiLuong,
                ngayKhoiChieu: ngayKhoiChieu,
                ngayKetThuc: ngayKetThuc,
                sanXuat: sanXuat,
                daoDien: daoDien,
                namSX: namSX,
                apPhich: apPhich
            );
        }
        public static void Update_Phim(
            string maPhim,
            string tenPhim,
            string moTa,
            float thoiLuong,
            DateTime ngayKhoiChieu,
            DateTime ngayKetThuc,
            string sanXuat,
            string daoDien,
            int namSX,
            byte[] apPhich
        )
        {
            Phim_CRUD(
                "UPDATE",
                maPhim: maPhim,
                tenPhim: tenPhim,
                moTa: moTa,
                thoiLuong: thoiLuong,
                ngayKhoiChieu: ngayKhoiChieu,
                ngayKetThuc: ngayKetThuc,
                sanXuat: sanXuat,
                daoDien: daoDien,
                namSX: namSX,
                apPhich: apPhich
            );
        }
        public static void Delete_Phim(string maPhim)
            => Phim_CRUD("DELETE", maPhim);
        public static DataTable Get_Phim_TheLoai(string maPhim)
            => Phim_CRUD("GET_THELOAI", maPhim);

        public static void Insert_PhimTheLoai(string maPhim, string maTheLoai)
            => Phim_CRUD("ADD_THELOAI", maPhim: maPhim, maTheLoai: maTheLoai);

        public static void Delete_PhimTheLoai(string maPhim)
            => Phim_CRUD("DELETE_THELOAI", maPhim);
        public static string GetLasted_Phim()
        {
            var dt = Phim_CRUD("GET_LASTED");
            return dt.Rows[0]["MaPhim"].ToString();
        }
        public static DataTable LaySuatChieuTheoPhim(string idPhim, DateTime ngayChieu)
        {
            return Phim_CRUD("GET_SUATCHIEU_PHIM", maPhim: idPhim, ngayKhoiChieu: ngayChieu);
        }
        public static DataTable LayThongTinPhim(string maPhim)
        {
            return Phim_CRUD("GET_INFO", maPhim: maPhim);
        }

        #region BanVe
        public static DataTable LayPhimDangChieu(DateTime ngay)
        {
            return Phim_CRUD(
                "GET_PHIM_DANG_CHIEU",
                ngayKhoiChieu: ngay
            );
        }

        public static DataTable LayPhimDangChieu_Simple(DateTime ngay)
        {
            return Phim_CRUD(
                "GET_PHIM_DANG_CHIEU_SIMPLE",
                ngayKhoiChieu: ngay
            );
        }
        public static byte[]? LayPosterPhim(string maPhim)
        {
            var dt = Phim_CRUD(
                "GET_POSTER",
                maPhim: maPhim
            );

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["ApPhich"] != DBNull.Value)
                return (byte[])dt.Rows[0]["ApPhich"];

            return null;
        }
        #endregion

        #endregion

        // Thao tác với bảng món ăn
        #region MonAn
        private static DataTable MonAn_CRUD(string action, string id = null, string tenMon = null, string moTa = null,
            decimal? donGia = null, int? loaiMon = null, int? trangThai = null, byte[] hinhAnh = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_MonAn_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@id", ToDbValue(id)),
                new SqlParameter("@tenMon", ToDbValue(tenMon)),
                new SqlParameter("@moTa", ToDbValue(moTa)),
                new SqlParameter("@donGia", ToDbValue(donGia)),
                new SqlParameter("@loaiMon", ToDbValue(loaiMon)),
                new SqlParameter("@trangThai", ToDbValue(trangThai)),
                new SqlParameter("@hinhAnh", SqlDbType.Image) { Value = ToDbValue(hinhAnh) });
            }

        public static DataTable GetAll_MonAn() => MonAn_CRUD("SELECT");
        public static DataTable Search_MonAn(string tenMon = null) => MonAn_CRUD("SEARCH", tenMon: tenMon);

        public static int Insert_MonAn(string tenMon, string moTa, decimal donGia, int loaiMon, int trangThai, byte[] hinhAnh)
        {
            var dt = MonAn_CRUD("INSERT", tenMon: tenMon, moTa: moTa, donGia: donGia, loaiMon: loaiMon, trangThai: trangThai, hinhAnh: hinhAnh);
            return dt != null ? 1 : 0;
        }

        public static int Update_MonAn(string id, string tenMon, string moTa, decimal donGia, int loaiMon, int trangThai, byte[] hinhAnh)
        {
            var dt = MonAn_CRUD("UPDATE", id: id, tenMon: tenMon, moTa: moTa, donGia: donGia, loaiMon: loaiMon, trangThai: trangThai, hinhAnh: hinhAnh);
            return dt != null ? 1 : 0;
        }

        public static int Delete_MonAn(string id)
        {
            var dt = MonAn_CRUD("DELETE", id: id);
            return dt != null ? 1 : 0;
        }
        #endregion

        // Thao tác với bảng màn hình
        #region ManHinh
        private static DataTable ManHinh_CRUD(string action, string idScreenType = null, string ten = null, string tinhTrang = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_ManHinh_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@idScreenType", ToDbValue(idScreenType)),
                new SqlParameter("@ten", ToDbValue(ten)),
                new SqlParameter("@tinhTrang", ToDbValue(tinhTrang))
            );
        }

        public static DataTable GetAll_ManHinh() => ManHinh_CRUD("GET_ALL");
        public static DataTable Search_ManHinh(string tenMH = null) => ManHinh_CRUD("SEARCH", ten: tenMH);

        public static int Insert_ManHinh(string tenMH, string tinhTrang)
        {
            var dt = ManHinh_CRUD("INSERT", ten: tenMH, tinhTrang: tinhTrang);
            return dt != null ? 1 : 0;
        }

        public static int Update_ManHinh(string idMH, string tenMH, string tinhTrang)
        {
            var dt = ManHinh_CRUD("UPDATE", idScreenType: idMH, ten: tenMH, tinhTrang: tinhTrang);
            return dt != null ? 1 : 0;
        }

        public static int Delete_ManHinh(string idMH)
        {
            var dt = ManHinh_CRUD("DELETE", idScreenType: idMH);
            return dt != null ? 1 : 0;
        }
        #endregion

        // Thao tác với bảng ghế
        #region Ghe
        internal enum GheAction
        {
            GET_BY_PHONG,
            GET_BY_LICHCHIEU,
            GENERATE_BY_PHONG,
            DELETE_ALL_BY_PHONG,
            UPDATE_LOAIGHE_GHE,
            SEARCH,

            LOAIGHE_GET_ALL,
            LOAIGHE_ADD,
            LOAIGHE_UPDATE,
            LOAIGHE_DELETE
        }
        private static DataTable Ghe_Service(
            GheAction action,
            string idPhong = null,
            string idGhe = null,
            int? idLoaiGhe = null,
            string keyword = null,
            string tenLoaiGhe = null,
            decimal? chiPhi = null,
            string idLichChieu = null
        )
        {
            return DataProvider.ExecuteQuery(
                "USP_Ghe_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action.ToString()),
                new SqlParameter("@IdPhong", ToDbValue(idPhong)),
                new SqlParameter("@IdGhe", ToDbValue(idGhe)),
                new SqlParameter("@IdLoaiGhe", ToDbValue(idLoaiGhe)),
                new SqlParameter("@Keyword", ToDbValue(keyword)),
                new SqlParameter("@TenLoaiGhe", ToDbValue(tenLoaiGhe)),
                new SqlParameter("@ChiPhi", ToDbValue(chiPhi)),
                new SqlParameter("@idLichChieu", ToDbValue(idLichChieu))
            );
        }
        public static DataTable LayDanhSachGheTheoPhong(string idPhong)
        {
            return Ghe_Service(
                GheAction.GET_BY_PHONG,
                idPhong: idPhong
            );
        }
        public static void SinhGheTheoPhong(string idPhong)
        {
            Ghe_Service(
                GheAction.GENERATE_BY_PHONG,
                idPhong: idPhong
            );
        }
        public static void XoaTatCaGheTheoPhong(string idPhong)
        {
            Ghe_Service(
                GheAction.DELETE_ALL_BY_PHONG,
                idPhong: idPhong
            );
        }
        public static int CapNhatLoaiGhe_Ghe(string idGhe, int idLoaiGhe)
        {
            var dt = Ghe_Service(
                GheAction.UPDATE_LOAIGHE_GHE,
                idGhe: idGhe,
                idLoaiGhe: idLoaiGhe
            );
            return dt != null ? 1 : 0;
        }
        public static DataTable TimKiemGhe(string idPhong, string keyword)
        {
            return Ghe_Service(
                GheAction.SEARCH,
                idPhong: idPhong,
                keyword: keyword
            );
        }
        public static DataTable GetAll_LoaiGhe()
        {
            return Ghe_Service(GheAction.LOAIGHE_GET_ALL);
        }
        public static int ThemLoaiGhe(string tenLoaiGhe, decimal giaTien)
        {
            var dt = Ghe_Service(
                GheAction.LOAIGHE_ADD,
                tenLoaiGhe: tenLoaiGhe,
                chiPhi: giaTien
            );
            return dt != null ? 1 : 0;
        }
        public static int CapNhatLoaiGhe(int idLoaiGhe, string tenLoaiGhe, decimal giaTien)
        {
            var dt = Ghe_Service(
                GheAction.LOAIGHE_UPDATE,
                idLoaiGhe: idLoaiGhe,
                tenLoaiGhe: tenLoaiGhe,
                chiPhi: giaTien
            );
            return dt != null ? 1 : 0;
        }
        public static int XoaLoaiGhe(int idLoaiGhe)
        {
            var dt = Ghe_Service(
                GheAction.LOAIGHE_DELETE,
                idLoaiGhe: idLoaiGhe
            );
            return dt != null ? 1 : 0;  
        }
        public static DataTable LayGheDaDatTheoLichChieu(string idLichChieu)
        {
            return Ghe_Service(
                GheAction.GET_BY_LICHCHIEU,
                idLichChieu: idLichChieu
            );
        }
        #endregion

        // Thao tác với bảng vé
        #region Ve
        private static DataTable Ve_CRUD(string action, string maLichChieu = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_Ve_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@MaLichChieu", ToDbValue(maLichChieu))
            );
        }

        // Lấy tất cả vé
        public static DataTable GetAll_Ve()
            => Ve_CRUD("GET_ALL");

        // Tự động tạo vé theo lịch chiếu
        public static void AutoAdd_Ve(string maLichChieu)
            => Ve_CRUD("AUTO_ADD", maLichChieu);

        // Xóa vé theo lịch chiếu
        public static void Delete_Ve_TheoLichChieu(string maLichChieu)
            => Ve_CRUD("DELETE", maLichChieu);

        // Vé đã bán theo lịch chiếu
        public static DataTable Get_VeDaBan(string maLichChieu = null)
            => Ve_CRUD("FIND", maLichChieu);

        // Lịch chiếu chưa tạo vé
        public static DataTable Get_LichChieu_ChuaTaoVe()
            => Ve_CRUD("GET_LICHCHIEU_CHUA_TAO_VE");
        #endregion

        //Thao tác với bảng hóa đơn
        #region HoaDon
        public static int Insert_HoaDon(string id, string idNhanVien, decimal tongTien, string idLichChieu = null)
        {
            try
            {
                string query = "INSERT INTO HoaDon (id, idNhanVien, NgayLap, TongTien, GiamGia, ThanhTien, PhuongThucTT, TrangThai, idLichChieu) " +
                              "VALUES (@id, @idNhanVien, GETDATE(), @tongTien, 0, @tongTien, 0, 1, @idLichChieu)";

                var parameters = new List<SqlParameter>
        {
            new SqlParameter("@id", id),
            new SqlParameter("@idNhanVien", idNhanVien),
            new SqlParameter("@tongTien", tongTien)
        };

                if (!string.IsNullOrEmpty(idLichChieu))
                    parameters.Add(new SqlParameter("@idLichChieu", idLichChieu));
                else
                    parameters.Add(new SqlParameter("@idLichChieu", DBNull.Value));

                return DataProvider.ExecuteNonQuery(query, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm hóa đơn: {ex.Message}");
                return 0;
            }
        }
        #endregion

        //Thao tác với bảng chi tiết món ăn
        #region ChiTietMonAn
        public static int Insert_ChiTietMonAn(string idHoaDon, string idMonAn, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "INSERT INTO ChiTietMonAn (idHoaDon, idMonAn, SoLuong, DonGia, ThanhTien) " +
                          "VALUES (@idHoaDon, @idMonAn, @soLuong, @donGia, @thanhTien)";
            return DataProvider.ExecuteNonQuery(query, CommandType.Text,
                new SqlParameter("@idHoaDon", idHoaDon),
                new SqlParameter("@idMonAn", idMonAn),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter("@donGia", donGia),
                new SqlParameter("@thanhTien", thanhTien));
        }
        #endregion

        // Các hàm tiện ích chuyển đổi hình ảnh
        #region Image Utils
        public static byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        #endregion
    }
}
