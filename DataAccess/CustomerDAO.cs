using RapApp.DataAccess;
using RapApp.Models;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RapApp.DataAccessLayer
{
    public static class CustomerDAO
    {
        public static DataTable GetAll()
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG", conn);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Insert(NguoiDung nd)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO NGUOIDUNG(IDNguoiDung, TenNguoiDung, GioiTinh, NgaySinh, SoDienThoai, DiaChi, IDTaiKhoan)
                                           VALUES(@id,@ten,@gt,@ns,@sdt,@dc,@tk)", conn);
                cmd.Parameters.AddWithValue("@id", nd.IDNguoiDung);
                cmd.Parameters.AddWithValue("@ten", nd.TenNguoiDung);
                cmd.Parameters.AddWithValue("@gt", nd.GioiTinh);
                cmd.Parameters.AddWithValue("@ns", (object)nd.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sdt", nd.SoDienThoai);
                cmd.Parameters.AddWithValue("@dc", nd.DiaChi);
                cmd.Parameters.AddWithValue("@tk", nd.IDTaiKhoan);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(NguoiDung nd)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE NGUOIDUNG SET TenNguoiDung=@ten, GioiTinh=@gt, NgaySinh=@ns, SoDienThoai=@sdt, DiaChi=@dc 
                                           WHERE IDNguoiDung=@id", conn);
                cmd.Parameters.AddWithValue("@ten", nd.TenNguoiDung);
                cmd.Parameters.AddWithValue("@gt", nd.GioiTinh);
                cmd.Parameters.AddWithValue("@ns", (object)nd.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sdt", nd.SoDienThoai);
                cmd.Parameters.AddWithValue("@dc", nd.DiaChi);
                cmd.Parameters.AddWithValue("@id", nd.IDNguoiDung);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string id)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM NGUOIDUNG WHERE IDNguoiDung=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
