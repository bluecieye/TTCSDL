using System;

namespace RapApp.Models
{
    public class HoaDon
    {
        public string IDHoaDon { get; set; }
        public string IDNguoiDung { get; set; }
        public DateTime NgayMua { get; set; }
        public string TrangThai { get; set; }
        public decimal TongTien { get; set; }
    }
}
