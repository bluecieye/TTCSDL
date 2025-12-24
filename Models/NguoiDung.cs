using System;

namespace RapApp.Models
{
    public class NguoiDung
    {
        public string IDNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string IDTaiKhoan { get; set; }
    }
}
