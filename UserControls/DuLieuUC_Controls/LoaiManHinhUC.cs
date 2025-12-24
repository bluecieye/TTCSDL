using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class LoaiManHinhUC : UserControl
    {
        public LoaiManHinhUC()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtgv_LoaiManHinhUC.DataSource = DuLieuDAO.GetAll_ManHinh();
                if (dtgv_LoaiManHinhUC.Rows.Count > 0)
                    dtgv_LoaiManHinhUC.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại màn hình: " + ex.Message);
            }
        }

        private void dtgv_LoaiManHinhUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgv_LoaiManHinhUC.Rows[e.RowIndex];

            txt_MaManHinh.Text = row.Cells["id"].Value?.ToString();
            txt_TenManHinh.Text = row.Cells["TenMH"].Value?.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string ten = txt_TenManHinh.Text.Trim();
            dtgv_LoaiManHinhUC.DataSource = DuLieuDAO.Search_ManHinh(ten);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ten = txt_TenManHinh.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên loại màn hình.");
                return;
            }

            try
            {
                DuLieuDAO.Insert_ManHinh(ten, "Hoạt động"); // Mặc định trạng thái
                MessageBox.Show("Thêm loại màn hình thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string id = txt_MaManHinh.Text.Trim();
            string ten = txt_TenManHinh.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng chọn màn hình và nhập tên mới.");
                return;
            }

            try
            {
                DuLieuDAO.Update_ManHinh(id, ten, "Hoạt động"); // Mặc định trạng thái
                MessageBox.Show("Cập nhật loại màn hình thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string id = txt_MaManHinh.Text.Trim();
            if (string.IsNullOrEmpty(id)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DuLieuDAO.Delete_ManHinh(id);
                    MessageBox.Show("Xóa thành công.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
    }
}
