using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TTCSDL_NHOM7.DAOs
{
    internal class TaiKhoanDAO
    {
        private static object ToDbValue(object value) => string.IsNullOrWhiteSpace(value?.ToString()) ? DBNull.Value : value;

        #region CRUD dùng USP_TaiKhoan_CRUD

        private static DataTable TaiKhoan_CRUD(
            string action,
            string oldUsername = null,
            string newUsername = null,
            string password = null,
            int? loaiTK = null,
            string maNV = null,
            string hoTen = null)
        {
            return DataProvider.ExecuteQuery(
                "USP_TaiKhoan_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", action),
                new SqlParameter("@OldUsername", ToDbValue(oldUsername)),
                new SqlParameter("@NewUsername", ToDbValue(newUsername)),
                new SqlParameter("@NewPassword", ToDbValue(password)),
                new SqlParameter("@LoaiTK", ToDbValue(loaiTK)),
                new SqlParameter("@MaNV", ToDbValue(maNV)),
                new SqlParameter("@HoTen", ToDbValue(hoTen)),
                new SqlParameter("@Pass", ToDbValue(password))
            );
        }

        // Lấy tất cả tài khoản cùng thông tin nhân viên
        public static DataTable GetAll() => TaiKhoan_CRUD("GET_ALL");

        // Tìm kiếm tài khoản theo tên nhân viên hoặc mã NV
        public static DataTable Search(string hoTen = null, string maNV = null) =>
            TaiKhoan_CRUD("SEARCH", hoTen: hoTen, maNV: maNV);

        // Thêm tài khoản mới
        public static int Insert(string username, string password, int loaiTK, string maNV)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(maNV))
                return 0;

            var dt = TaiKhoan_CRUD("INSERT", newUsername: username, password: password, loaiTK: loaiTK, maNV: maNV);
            return dt != null ? 1 : 0;
        }

        // Cập nhật tài khoản
        public static int Update(string oldUsername, string newUsername, int loaiTK, string newPassword = null)
        {
            if (string.IsNullOrWhiteSpace(oldUsername) || string.IsNullOrWhiteSpace(newUsername))
                return 0;

            var dt = TaiKhoan_CRUD("UPDATE", oldUsername: oldUsername, newUsername: newUsername, password: newPassword, loaiTK: loaiTK);
            return dt != null ? 1 : 0;
        }

        // Xóa tài khoản
        public static int Delete(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return 0;

            var dt = TaiKhoan_CRUD("DELETE", oldUsername: username);
            return dt != null ? 1 : 0;
        }

        // Đăng nhập
        public static DataTable Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return TaiKhoan_CRUD("LOGIN", oldUsername: username, password: password);
        }

        #endregion

        #region Dùng USP_NhanVien_CRUD để lấy thông tin NV

        // Lấy nhân viên theo mã NV
        public static DataTable GetNhanVienByMaNV(string maNV, string cmnd, string sdt)
        {
            if (string.IsNullOrWhiteSpace(maNV) && string.IsNullOrWhiteSpace(cmnd) && string.IsNullOrWhiteSpace(sdt))
                return null;

            return DataProvider.ExecuteQuery(
                "USP_NhanVien_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", "SEARCH"),
                new SqlParameter("@MaNV", ToDbValue(maNV)),
                new SqlParameter("@CMND", ToDbValue(cmnd)),
                new SqlParameter("@SDT", ToDbValue(sdt))
            );
        }
        // Lấy tất cả nhân viên
        public static DataTable GetAllNhanVien()
        {
            return DataProvider.ExecuteQuery(
                "USP_NhanVien_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", "GET_ALL")
            );
        }
        public static int DeleteNhanVien(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                return 0;
            var dt = DataProvider.ExecuteQuery(
                "USP_NhanVien_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", "DELETE"),
                new SqlParameter("@MaNV", ToDbValue(maNV))
            );
            return dt != null ? 1 : 0;
        }
        public static int InsertNhanVien(string hoTen, string ngaySinh,  string diaChi, string sdt, string cmnd)
        {
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(ngaySinh))
                return 0;
            var dt = DataProvider.ExecuteQuery(
                "USP_NhanVien_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", "INSERT"),
                new SqlParameter("@HoTen", ToDbValue(hoTen)),
                new SqlParameter("@NgaySinh", ToDbValue(ngaySinh)),
                new SqlParameter("@DiaChi", ToDbValue(diaChi)),
                new SqlParameter("@SDT", ToDbValue(sdt)),
                new SqlParameter("@CMND", ToDbValue(cmnd))
            );
            return dt != null ? 1 : 0;
        }
        public static int UpdateNhanVien(string maNV, string hoTen, string ngaySinh, string diaChi, string sdt, string cmnd)
        {
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(ngaySinh))
                return 0;
            var dt = DataProvider.ExecuteQuery(
                "USP_NhanVien_CRUD",
                CommandType.StoredProcedure,
                new SqlParameter("@Action", "UPDATE"),
                new SqlParameter("@MaNV", ToDbValue(maNV)),
                new SqlParameter("@HoTen", ToDbValue(hoTen)),
                new SqlParameter("@NgaySinh", ToDbValue(ngaySinh)),
                new SqlParameter("@DiaChi", ToDbValue(diaChi)),
                new SqlParameter("@SDT", ToDbValue(sdt)),
                new SqlParameter("@CMND", ToDbValue(cmnd))
            );
            return dt != null ? 1 : 0;
        }
        #endregion
    }
}
