using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TTCSDL_NHOM7.DAOs
{
    internal class KhachHangDAO
    {
        private static object ToDbValue(object value) => string.IsNullOrWhiteSpace(value?.ToString()) ? DBNull.Value : value;
        private const string SP_NAME = "USP_KhachHang_CRUD";

        private static DataTable KhachHang_CRUD(string action, string maKH = null, string hoTen = null, string diaChi = null, string sdt = null,
            int? cmnd = null, int? diemTichLuy = null)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Action", action),
                new SqlParameter("@MaKH", ToDbValue(maKH)),
                new SqlParameter("@HoTen", ToDbValue(hoTen)),
                new SqlParameter("@DiaChi", ToDbValue(diaChi)),
                new SqlParameter("@SDT", ToDbValue(sdt)),
                new SqlParameter("@CMND", ToDbValue(cmnd)),
                new SqlParameter("@DiemTichLuy", ToDbValue(diemTichLuy))
            };
            return DataProvider.ExecuteQuery(SP_NAME, CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetAll() => KhachHang_CRUD("GET_ALL");

        public static DataTable Search(string hoTen = null)
            => KhachHang_CRUD("SEARCH", hoTen: hoTen);

        public static int Insert(string hoTen, string diaChi, string sdt, int cmnd, int diemtichluy)
        {
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt))
                return 0;
            var dt = KhachHang_CRUD("INSERT", hoTen: hoTen, diaChi: diaChi, sdt: sdt, cmnd: cmnd, diemTichLuy: diemtichluy);
            return dt != null ? 1 : 0;
        }

        public static int Update(string maKH, string hoTen, string diaChi, string sdt, int cmnd, int diemTichLuy)
        {
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt))
                return 0;
            var dt = KhachHang_CRUD("UPDATE", maKH: maKH, hoTen: hoTen, diaChi: diaChi, sdt: sdt, cmnd: cmnd, diemTichLuy: diemTichLuy);
            return dt != null ? 1 : 0;
        }

        public static int Delete(string maKH)
        {
            if (string.IsNullOrWhiteSpace(maKH)) return 0;
            var dt = KhachHang_CRUD("DELETE", maKH: maKH);
            return dt != null ? 1 : 0;
        }
    }
}
