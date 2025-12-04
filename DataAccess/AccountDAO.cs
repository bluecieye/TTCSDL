using Microsoft.Data.SqlClient;
using RapApp.DataAccess;
using RapApp.Models;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace RapApp.DataAccessLayer
{
    public static class AccountDAO
    {
        public static TaiKhoan GetByEmailAndPass(string email, string pass)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM TAIKHOAN WHERE Email=@e AND MatKhau=@m AND TrangThai='Actived'", conn);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@m", pass);
                var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return new TaiKhoan
                    {
                        IDTaiKhoan = rd["IDTaiKhoan"].ToString(),
                        Email = rd["Email"].ToString(),
                        MatKhau = rd["MatKhau"].ToString(),
                        TrangThai = rd["TrangThai"].ToString(),
                        IDVaiTro = rd["IDVaiTro"].ToString()
                    };
                }
                return null;
            }
        }

        public static DataTable GetAll()
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var da = new SqlDataAdapter(@"SELECT tk.IDTaiKhoan, tk.Email, tk.MatKhau, tk.TrangThai, vt.TenVaiTro 
                                              FROM TAIKHOAN tk
                                              LEFT JOIN VAITRO vt ON tk.IDVaiTro = vt.IDVaiTro", conn);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Insert(TaiKhoan t)
        {
            using (var conn = DBConnect.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO TAIKHOAN(IDTaiKhoan, Email, MatKhau, TrangThai, IDVaiTro) VALUES(@id,@e,@m,@st,@vt)", conn);
                cmd.Parameters.AddWithValue("@id", t.IDTaiKhoan);
                cmd.Parameters.AddWithValue("@e", t.Email);
                cmd.Parameters.AddWithValue("@m", t.MatKhau);
                cmd.Parameters.AddWithValue("@st", t.TrangThai);
                cmd.Parameters.AddWithValue("@vt", t.IDVaiTro);
                cmd.ExecuteNonQuery();
            }
        }
        public static string HashPassword(string pass)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(pass ?? ""));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        public static bool UpdatePassword(string id, string newPass)
        {
            using (SqlConnection conn = DBConnect.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE TAIKHOAN SET MatKhau=@m WHERE IDTaiKhoan=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@m", HashPassword(newPass));

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
