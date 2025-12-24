using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class LichChieuUC : UserControl
    {
        public LichChieuUC()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();

            combox_MaDinhDang.SelectedIndexChanged += combox_MaDinhDang_SelectedIndexChanged;
            dtgv_LichChieuUC.CellClick += dtgv_LichChieuUC_CellClick;
        }

        // ================== Load Data ==================
        private void LoadData()
        {
            dtgv_LichChieuUC.DataSource = DuLieuDAO.GetAll_LichChieu();
        }

        // ================== Load ComboBox ==================
        private void LoadComboBox()
        {
            var dtPhong = DuLieuDAO.GetAll_PhongChieu();
            var dtDinhDang = DuLieuDAO.GetAll_DinhDang();

            SetupComboBox(combox_PhongChieu, dtPhong, "Tên phòng", "Mã phòng");

            SetupComboBox(combox_MaDinhDang, dtDinhDang, "MaDinhDang", "MaDinhDang");
        }

        private void SetupComboBox(ComboBox combo, DataTable dt, string displayMember, string valueMember)
        {
            combo.DataSource = dt;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
        }

        // ================== Event CRUD ==================
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maDinhDang = combox_MaDinhDang.SelectedValue?.ToString();
            string maPhong = combox_PhongChieu.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(maDinhDang) || string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            DateTime thoiGianChieu = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;

            if (!decimal.TryParse(txt_GiaVe.Text, out decimal giaVe))
            {
                MessageBox.Show("Giá vé không hợp lệ!");
                return;
            }

            try
            {
                DuLieuDAO.Insert_LichChieu(maDinhDang, maPhong, thoiGianChieu, giaVe);
                LoadData();
                MessageBox.Show("Thêm lịch chiếu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch chiếu: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maLichChieu = txt_MaLichChieu.Text.Trim();
            string maDinhDang = combox_MaDinhDang.SelectedValue?.ToString();
            string maPhong = combox_PhongChieu.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(maLichChieu) || string.IsNullOrWhiteSpace(maDinhDang) || string.IsNullOrWhiteSpace(maPhong))
                return;

            DateTime thoiGianChieu = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;

            if (!decimal.TryParse(txt_GiaVe.Text, out decimal giaVe))
            {
                MessageBox.Show("Giá vé không hợp lệ!");
                return;
            }

            try
            {
                DuLieuDAO.Update_LichChieu(maLichChieu, maDinhDang, maPhong, thoiGianChieu, giaVe);
                LoadData();
                MessageBox.Show("Cập nhật lịch chiếu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maLichChieu = txt_MaLichChieu.Text.Trim();
            if (string.IsNullOrWhiteSpace(maLichChieu)) return;

            if (MessageBox.Show("Xóa lịch chiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DuLieuDAO.Delete_LichChieu(maLichChieu);
                    LoadData();
                    MessageBox.Show("Xóa lịch chiếu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_LichChieuUC.DataSource = DuLieuDAO.Search_LichChieu(txt_TimKiem_input.Text.Trim());
        }

        // ================== DataGridView CellClick ==================
        private void dtgv_LichChieuUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgv_LichChieuUC.Rows[e.RowIndex];
            txt_MaLichChieu.Text = row.Cells["MaLichChieu"].Value?.ToString();
            txt_GiaVe.Text = row.Cells["GiaVe"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["ThoiGianChieu"].Value?.ToString(), out DateTime tg))
            {
                dateTimePicker1.Value = tg.Date;
                dateTimePicker2.Value = tg;
            }

            combox_PhongChieu.SelectedValue = row.Cells["MaPhong"].Value != DBNull.Value ? row.Cells["MaPhong"].Value : null;
            combox_MaDinhDang.SelectedValue = row.Cells["MaDinhDang"].Value != DBNull.Value ? row.Cells["MaDinhDang"].Value : null;
        }

        // ================== Sync Định dạng ==================
        private void combox_MaDinhDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_MaDinhDang.SelectedItem is DataRowView row)
            {
                txt_TenPhim.Text = row["TenPhim"]?.ToString();
                txt_DinhDangPhim.Text = row["TenManHinh"]?.ToString();
            }
        }
    }
}
