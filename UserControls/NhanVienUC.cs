using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class NhanVienUC : UserControl
    {
        public NhanVienUC()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dtgv_NhanVienUC.DataSource = TaiKhoanDAO.GetAllNhanVien();
        }

        private void dtgv_NhanVienUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dtgv_NhanVienUC.Rows[e.RowIndex];

            txt_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
            txt_HoTen.Text = row.Cells["Họ và Tên"].Value.ToString();
            txt_NgaySinh.Text = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value).ToString("yyyy-MM-dd");
            txt_DiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString();
            txt_SoDienThoai.Text = row.Cells["Số Điện Thoại"].Value?.ToString();
            txt_CMND.Text = row.Cells["CMND"].Value.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string hoTen = txt_HoTen.Text.Trim();
            string cmnd = txt_CMND.Text.Trim();
            string sdt = txt_SoDienThoai.Text.Trim();

            DataTable dt = TaiKhoanDAO.GetNhanVienByMaNV(hoTen, cmnd, sdt);
            dtgv_NhanVienUC.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoTen = txt_HoTen.Text.Trim();
            string ngaySinh = txt_NgaySinh.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();
            string sdt = txt_SoDienThoai.Text.Trim();
            string cmnd = txt_CMND.Text.Trim();

            int result = TaiKhoanDAO.InsertNhanVien(hoTen, ngaySinh, diaChi, sdt, cmnd);
            if (result == 1)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                LoadData();
            }
            else
                MessageBox.Show("Thêm thất bại. Kiểm tra lại dữ liệu.", "Thông báo");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string id = txt_MaNV.Text.Trim();
            string hoTen = txt_HoTen.Text.Trim();
            string ngaySinh = txt_NgaySinh.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();
            string sdt = txt_SoDienThoai.Text.Trim();
            string cmnd = txt_CMND.Text.Trim();

            int result = TaiKhoanDAO.UpdateNhanVien(id, hoTen, ngaySinh, diaChi, sdt, cmnd);
            if (result == 1)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");
                LoadData();
            }
            else
                MessageBox.Show("Cập nhật thất bại. Kiểm tra lại dữ liệu.", "Thông báo");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo");
                return;
            }

            string id = txt_MaNV.Text.Trim();
            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {txt_HoTen.Text}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int result = TaiKhoanDAO.DeleteNhanVien(id);
                if (result == 1)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    LoadData();
                }
                else
                    MessageBox.Show("Xóa thất bại. Kiểm tra lại dữ liệu.", "Thông báo");
            }
        }
    }
}
