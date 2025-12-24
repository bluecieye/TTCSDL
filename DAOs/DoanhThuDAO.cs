using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TTCSDL_NHOM7.DAOs
{
    internal class DoanhThuDAO
    {
        private static object ToDbValue(object value) => value ?? DBNull.Value;

        #region Phim
        public static DataTable GetMovieList()
        {
            SqlParameter[] parameters = { new SqlParameter("@Action", "GET_COMBO") };
            return DataProvider.ExecuteQuery("USP_Phim_CRUD", CommandType.StoredProcedure, parameters);
        }
        #endregion

        #region DoanhThu
        public static DataTable GetRevenueByDay(DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };
            return DataProvider.ExecuteQuery("USP_DoanhThu_TheoNgay", CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetRevenueByWeek(DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };
            return DataProvider.ExecuteQuery("USP_DoanhThu_TheoTuan", CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetRevenueByMovieMonth(string idMovie, int month, int year)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@idMovie", ToDbValue(idMovie)),
                new SqlParameter("@month", month),
                new SqlParameter("@year", year)
            };
            return DataProvider.ExecuteQuery("USP_DoanhThu_TheoPhim_TheoThang", CommandType.StoredProcedure, parameters);
        }
        #endregion
    }
}
