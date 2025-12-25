using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class VeUC : UserControl
    {
        public VeUC()
        {
            InitializeComponent();
            LoadTatCaLichChieu();
        }

        #region Load Lịch chiếu
        private void LoadTatCaLichChieu()
        {
            LoadListView(DuLieuDAO.GetAll_LichChieu(), showStatus: true);
        }

        private void LoadLichChieuChuaTaoVe()
        {
            LoadListView(DuLieuDAO.Get_LichChieu_ChuaTaoVe(), showStatus: false);
        }

        private void LoadListView(DataTable dt, bool showStatus)
        {
            listview_TatCaLichChieu.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhong"].ToString());

                string phim = row.Table.Columns.Contains("TenPhim") ? row["TenPhim"].ToString() : row.Table.Columns.Contains("MaDinhDang") ? row["MaDinhDang"].ToString() : "";
                item.SubItems.Add(phim);
                item.SubItems.Add(Convert.ToDateTime(row["ThoiGianChieu"]).ToString("dd/MM/yyyy HH:mm"));

                string maLichChieu = row["MaLichChieu"].ToString();
                DataTable dtVe = DuLieuDAO.GetAll_Ve(maLichChieu);
                item.SubItems.Add(dtVe.Rows.Count > 0 ? "Đã tạo" : "Chưa tạo vé");

                item.Tag = maLichChieu;
                listview_TatCaLichChieu.Items.Add(item);
            }

            dtgvVe.DataSource = null;
        }
        #endregion

        #region Nút hành động
        private void btnThemVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (!GetSelectedMaLichChieu(out string maLichChieu)) return;

            try
            {
                DuLieuDAO.AutoAdd_Ve(maLichChieu);
                MessageBox.Show("Đã tạo vé cho lịch chiếu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSelectedLichChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (!GetSelectedMaLichChieu(out string maLichChieu)) return;

            try
            {
                DuLieuDAO.Delete_Ve_TheoLichChieu(maLichChieu);
                MessageBox.Show("Đã xóa vé theo lịch chiếu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSelectedLichChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVeDaMuaTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (!GetSelectedMaLichChieu(out string maLichChieu)) return;
            dtgvVe.DataSource = DuLieuDAO.Get_VeDaBan(maLichChieu);
        }

        private void btn_TatCaVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (!GetSelectedMaLichChieu(out string maLichChieu)) return;
            dtgvVe.DataSource = DuLieuDAO.GetAll_Ve(maLichChieu);
        }

        private void btnXemLichChieuChuaTaoVe_Click(object sender, EventArgs e)
        {
            LoadLichChieuChuaTaoVe();
        }

        private void btnXemTatCaLichChieu_Click(object sender, EventArgs e)
        {
            LoadTatCaLichChieu();
        }
        #endregion

        #region ListView Selection
        private void listview_TatCaLichChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!GetSelectedMaLichChieu(out string maLichChieu)) return;

            try
            {
                // Mặc định load vé đã bán
                dtgvVe.DataSource = DuLieuDAO.Get_VeDaBan(maLichChieu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetSelectedMaLichChieu(out string maLichChieu)
        {
            maLichChieu = null;
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();
            return true;
        }
        #endregion

        #region Helpers
        private void RefreshSelectedLichChieu()
        {
            // refresh ListView: đánh dấu "Đã tạo" / "Chưa tạo vé"
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                LoadTatCaLichChieu();
                return;
            }

            string maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();
            var dtChuaTao = DuLieuDAO.Get_LichChieu_ChuaTaoVe();

            bool isChuaTao = dtChuaTao.Select($"MaLichChieu='{maLichChieu}'").Length > 0;
            listview_TatCaLichChieu.SelectedItems[0].SubItems[3].Text = isChuaTao ? "Chưa tạo vé" : "Đã tạo";

            // Refresh DataGridView
            dtgvVe.DataSource = DuLieuDAO.GetAll_Ve(maLichChieu);
        }
        #endregion
    }
}
