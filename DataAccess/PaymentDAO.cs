using System.Data;
using Microsoft.Data.SqlClient;
using RapApp.DataAccess;

namespace RapApp.DataAccessLayer
{
    public static class PaymentDAO
    {
        public static DataTable GetAllHoaDon()
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var da = new SqlDataAdapter(@"SELECT hd.IDHoaDon, nd.TenNguoiDung, hd.NgayMua, hd.TongTien, hd.TrangThai
                                              FROM HOADON hd
                                              LEFT JOIN NGUOIDUNG nd ON hd.IDNguoiDung = nd.IDNguoiDung", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetCTMonAnByHoaDon(string idHoaDon)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var da = new SqlDataAdapter(
                    @"SELECT ct.IDChiTietMonAn, m.TenMonAn, ct.SoLuong, m.DonGia, (ct.SoLuong * m.DonGia) AS ThanhTien
                      FROM CT_MONAN ct
                      JOIN MONAN m ON m.IDMonAn = ct.IDMonAn
                      WHERE ct.IDHoaDon = @id", conn);

                da.SelectCommand.Parameters.AddWithValue("@id", idHoaDon);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void UpdateTrangThai(string idHoaDon, string trangThai)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE HOADON SET TrangThai = @tt WHERE IDHoaDon = @id", conn);

                cmd.Parameters.AddWithValue("@tt", trangThai);
                cmd.Parameters.AddWithValue("@id", idHoaDon);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
