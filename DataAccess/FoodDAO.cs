using System.Data;
using Microsoft.Data.SqlClient;
using RapApp.Models;
using RapApp.DataAccess;

namespace RapApp.DataAccessLayer
{
    public static class FoodDAO
    {
        public static DataTable GetAll()
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var da = new SqlDataAdapter("SELECT * FROM MONAN", conn);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Insert(MonAn f)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO MONAN(IDMonAn, TenMonAn, MoTa, DonGia) VALUES(@id,@ten,@mo,@gia)", conn);
                cmd.Parameters.AddWithValue("@id", f.IDMonAn);
                cmd.Parameters.AddWithValue("@ten", f.TenMonAn);
                cmd.Parameters.AddWithValue("@mo", f.MoTa ?? "");
                cmd.Parameters.AddWithValue("@gia", f.DonGia);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(MonAn f)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE MONAN SET TenMonAn=@ten, MoTa=@mo, DonGia=@gia WHERE IDMonAn=@id", conn);
                cmd.Parameters.AddWithValue("@ten", f.TenMonAn);
                cmd.Parameters.AddWithValue("@mo", f.MoTa ?? "");
                cmd.Parameters.AddWithValue("@gia", f.DonGia);
                cmd.Parameters.AddWithValue("@id", f.IDMonAn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string id)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM MONAN WHERE IDMonAn=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
