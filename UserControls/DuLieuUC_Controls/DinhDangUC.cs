using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class DinhDangUC : UserControl
    {
        public DinhDangUC()
        {
            InitializeComponent();
            LoadDinhDang();
            LoadComboBox();
        }

        // ================== Load Data ==================
        private void LoadDinhDang()
        {
            dtgv_DinhDangUC.DataSource = DuLieuDAO.GetAll_DinhDang();
        }

        // ================== ComboBox ==================
        private void LoadComboBox()
        {
            DataTable dtPhim = DuLieuDAO.loadComboBox_DinhDang();
            DataTable dtManHinh = DuLieuDAO.GetAll_ManHinh();

            SetupComboBox(combox_MaPhim, dtPhim, "MaPhim", "MaPhim");
            SetupComboBox(combox_TenPhim, dtPhim.Copy(), "TenPhim", "MaPhim");
            SetupComboBox(combox_MaManHinh, dtManHinh, "id", "id");
            SetupComboBox(combox_TenManHinh, dtManHinh.Copy(), "TenMH", "id");
        }

        private void SetupComboBox(ComboBox combo, DataTable dt, string displayMember, string valueMember)
        {
            combo.DataSource = dt;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
        }

        // ================== Sync ComboBox ==================
        private void SyncComboBox(ComboBox source, ComboBox target)
        {
            if (source.SelectedValue != null && source.SelectedValue != DBNull.Value)
                target.SelectedValue = source.SelectedValue;
        }

        private void combox_MaPhim_SelectedIndexChanged(object sender, EventArgs e) => SyncComboBox(combox_MaPhim, combox_TenPhim);
        private void combox_TenPhim_SelectedIndexChanged(object sender, EventArgs e) => SyncComboBox(combox_TenPhim, combox_MaPhim);
        private void combox_MaManHinh_SelectedIndexChanged(object sender, EventArgs e) => SyncComboBox(combox_MaManHinh, combox_TenManHinh);
        private void combox_TenManHinh_SelectedIndexChanged(object sender, EventArgs e) => SyncComboBox(combox_TenManHinh, combox_MaManHinh);

        // ================== Event ==================
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_DinhDangUC.DataSource = DuLieuDAO.Search_DinhDang(
                txt_MaDinhDang.Text.Trim(),
                combox_MaPhim.SelectedValue?.ToString(),
                combox_MaManHinh.SelectedValue?.ToString(),
                combox_TenPhim.Text.Trim(),
                combox_TenManHinh.Text.Trim()
            );
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim = combox_MaPhim.SelectedValue?.ToString();
                string maManHinh = combox_MaManHinh.SelectedValue?.ToString();

                if (string.IsNullOrWhiteSpace(maPhim) || string.IsNullOrWhiteSpace(maManHinh))
                    throw new ArgumentException("Phim và Màn hình phải được chọn.");

                DuLieuDAO.Insert_DinhDang(maPhim, maManHinh);
                LoadDinhDang();
                MessageBox.Show("Thêm định dạng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maLich = txt_MaDinhDang.Text.Trim();
                string maPhim = combox_MaPhim.SelectedValue?.ToString();
                string maManHinh = combox_MaManHinh.SelectedValue?.ToString();

                if (string.IsNullOrWhiteSpace(maLich) || string.IsNullOrWhiteSpace(maPhim) || string.IsNullOrWhiteSpace(maManHinh))
                    throw new ArgumentException("Mã định dạng, Phim và Màn hình không được để trống.");

                DuLieuDAO.Update_DinhDang(maLich, maPhim, maManHinh);
                LoadDinhDang();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string maLich = txt_MaDinhDang.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maLich))
                        throw new ArgumentException("Chưa chọn định dạng để xóa.");

                    DuLieuDAO.Delete_DinhDang(maLich);
                    LoadDinhDang();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgv_DinhDangUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgv_DinhDangUC.Rows[e.RowIndex];
            txt_MaDinhDang.Text = row.Cells["MaDinhDang"].Value?.ToString();
            combox_MaPhim.SelectedValue = row.Cells["MaPhim"].Value ?? DBNull.Value;
            combox_MaManHinh.SelectedValue = row.Cells["MaManHinh"].Value ?? DBNull.Value;
        }
    }
}
