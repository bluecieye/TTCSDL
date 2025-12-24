using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class PhimUC : UserControl
    {
        private byte[] posterBytes = null;

        public PhimUC()
        {
            InitializeComponent();
            LoadPhim();
            LoadTheLoai();
        }

        #region Load Data
        private void LoadPhim()
        {
            dtgv_PhimUC.DataSource = DuLieuDAO.GetAll_Phim();
        }

        private void LoadTheLoai()
        {
            checklist_TheLoai.DataSource = DuLieuDAO.GetAll_TheLoai();
            checklist_TheLoai.DisplayMember = "TenTheLoai";
            checklist_TheLoai.ValueMember = "MaTheLoai";
            // Reset tất cả checked
            for (int i = 0; i < checklist_TheLoai.Items.Count; i++)
                checklist_TheLoai.SetItemChecked(i, false);
        }

        private void LoadCheckedTheLoai(string maPhim)
        {
            DataTable dt = DuLieuDAO.Get_Phim_TheLoai(maPhim);
            for (int i = 0; i < checklist_TheLoai.Items.Count; i++)
            {
                DataRowView item = (DataRowView)checklist_TheLoai.Items[i];
                checklist_TheLoai.SetItemChecked(i,
                    dt.AsEnumerable().Any(r => r["MaTheLoai"].ToString() == item["MaTheLoai"].ToString()));
            }
        }
        #endregion

        #region CRUD
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string namSX = string.IsNullOrWhiteSpace(txt_NamSX.Text) ? null : txt_NamSX.Text.Trim();
            dtgv_PhimUC.DataSource = DuLieuDAO.Search_Phim(
                txt_MaPhim.Text.Trim(),
                txt_TenPhim.Text.Trim(),
                namSX
            );
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenPhim.Text))
            {
                MessageBox.Show("Tên phim không được để trống");
                return;
            }

            if (!float.TryParse(txt_ThoiLuongPhim.Text, out float thoiLuong))
            {
                MessageBox.Show("Thời lượng không hợp lệ");
                return;
            }

            if (!int.TryParse(txt_NamSX.Text, out int namSX))
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return;
            }

            DuLieuDAO.Insert_Phim(
                txt_TenPhim.Text.Trim(),
                richtxt_MoTa.Text.Trim(),
                thoiLuong,
                datepick_KhoiChieu.Value,
                datepicker_KetThuc.Value,
                txt_SanXuat.Text.Trim(),
                txt_DaoDien.Text.Trim(),
                namSX,
                posterBytes
            );

            string maPhimMoi = DuLieuDAO.GetLasted_Phim();
            SaveCheckedTheLoai(maPhimMoi);
            LoadPhim();
            MessageBox.Show("Thêm phim thành công");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaPhim.Text))
            {
                MessageBox.Show("Chưa chọn phim cần sửa");
                return;
            }

            if (!float.TryParse(txt_ThoiLuongPhim.Text, out float thoiLuong))
            {
                MessageBox.Show("Thời lượng không hợp lệ");
                return;
            }

            if (!int.TryParse(txt_NamSX.Text, out int namSX))
            {
                MessageBox.Show("Năm sản xuất không hợp lệ");
                return;
            }

            DuLieuDAO.Update_Phim(
                txt_MaPhim.Text.Trim(),
                txt_TenPhim.Text.Trim(),
                richtxt_MoTa.Text.Trim(),
                thoiLuong,
                datepick_KhoiChieu.Value,
                datepicker_KetThuc.Value,
                txt_SanXuat.Text.Trim(),
                txt_DaoDien.Text.Trim(),
                namSX,
                posterBytes
            );

            DuLieuDAO.Delete_PhimTheLoai(txt_MaPhim.Text.Trim());
            SaveCheckedTheLoai(txt_MaPhim.Text.Trim());

            LoadPhim();
            MessageBox.Show("Cập nhật phim thành công");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaPhim.Text)) return;
            if (MessageBox.Show("Xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DuLieuDAO.Delete_Phim(txt_MaPhim.Text.Trim());
            DuLieuDAO.Delete_PhimTheLoai(txt_MaPhim.Text.Trim());

            LoadPhim();
            MessageBox.Show("Đã xóa phim");
        }

        private void SaveCheckedTheLoai(string maPhim)
        {
            foreach (DataRowView item in checklist_TheLoai.CheckedItems)
            {
                DuLieuDAO.Insert_PhimTheLoai(maPhim, item["MaTheLoai"].ToString());
            }
        }
        #endregion

        #region Image
        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                posterBytes = File.ReadAllBytes(ofd.FileName);
                using MemoryStream ms = new MemoryStream(posterBytes);
                picture_AnhPhim.Image = Image.FromStream(ms);
            }
        }
        #endregion

        #region DataGridView
        private void dtgv_PhimUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dtgv_PhimUC.Rows[e.RowIndex];

            txt_MaPhim.Text = r.Cells["MaPhim"].Value?.ToString();
            txt_TenPhim.Text = r.Cells["TenPhim"].Value?.ToString();
            richtxt_MoTa.Text = r.Cells["MoTa"].Value?.ToString();
            txt_ThoiLuongPhim.Text = r.Cells["ThoiLuong"].Value?.ToString();
            txt_SanXuat.Text = r.Cells["SanXuat"].Value?.ToString();
            txt_DaoDien.Text = r.Cells["DaoDien"].Value?.ToString();
            txt_NamSX.Text = r.Cells["NamSX"].Value?.ToString();

            datepick_KhoiChieu.Value = r.Cells["NgayKhoiChieu"].Value != DBNull.Value
                ? Convert.ToDateTime(r.Cells["NgayKhoiChieu"].Value)
                : DateTime.Today;
            datepicker_KetThuc.Value = r.Cells["NgayKetThuc"].Value != DBNull.Value
                ? Convert.ToDateTime(r.Cells["NgayKetThuc"].Value)
                : DateTime.Today;

            if (r.Cells["ApPhich"].Value != DBNull.Value)
            {
                posterBytes = (byte[])r.Cells["ApPhich"].Value;
                using MemoryStream ms = new MemoryStream(posterBytes);
                picture_AnhPhim.Image = Image.FromStream(ms);
            }
            else
            {
                posterBytes = null;
                picture_AnhPhim.Image = null;
            }

            LoadCheckedTheLoai(txt_MaPhim.Text);
        }
        #endregion
    }
}
