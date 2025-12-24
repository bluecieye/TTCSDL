using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class PhongChieuUC : UserControl
    {
        private BindingSource bsPhongChieu = new BindingSource();

        public PhongChieuUC()
        {
            InitializeComponent();
            InitializeBinding();
            LoadData();
        }

        #region Load & Binding
        private void LoadData()
        {
            bsPhongChieu.DataSource = DuLieuDAO.GetAll_PhongChieu();
            dtgv_PhongChieuUC.DataSource = bsPhongChieu;

            combox_LoaiManHinh.DataSource = DuLieuDAO.GetAll_ManHinh();
            combox_LoaiManHinh.DisplayMember = "TenMH";
            combox_LoaiManHinh.ValueMember = "id";
        }

        private void InitializeBinding()
        {
            txt_MaPhongChieu.DataBindings.Add("Text", bsPhongChieu, "Mã phòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_TenPhongChieu.DataBindings.Add("Text", bsPhongChieu, "Tên phòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_SoGhe.DataBindings.Add("Text", bsPhongChieu, "Số chỗ ngồi", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_TinhTrangPhong.DataBindings.Add("Text", bsPhongChieu, "Tình trạng", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_SoHangGhe.DataBindings.Add("Text", bsPhongChieu, "Số hàng ghế", true, DataSourceUpdateMode.OnPropertyChanged);
            txt_SoCotGhe.DataBindings.Add("Text", bsPhongChieu, "Ghế mỗi hàng", true, DataSourceUpdateMode.OnPropertyChanged);
            combox_LoaiManHinh.DataBindings.Add("SelectedValue", bsPhongChieu, "Mã màn hình", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        #region CRUD
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_SoGhe.Text.Trim(), out int soGhe);
            int.TryParse(txt_TinhTrangPhong.Text.Trim(), out int tinhTrang);

            bsPhongChieu.DataSource = DuLieuDAO.Search_PhongChieu(
                txt_TenPhongChieu.Text.Trim(),
                soGhe.ToString(),
                tinhTrang.ToString()
            );
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out int soGhe, out int tinhTrang, out int soHang, out int soCot)) return;

            int rows = DuLieuDAO.Insert_PhongChieu(
                txt_TenPhongChieu.Text.Trim(),
                combox_LoaiManHinh.SelectedValue?.ToString(),
                soGhe,
                tinhTrang,
                soHang,
                soCot
            );

            if (rows > 0)
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
                LoadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaPhongChieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu để sửa.");
                return;
            }

            if (!ValidateInput(out int soGhe, out int tinhTrang, out int soHang, out int soCot)) return;

            int rows = DuLieuDAO.Update_PhongChieu(
                txt_MaPhongChieu.Text.Trim(),
                txt_TenPhongChieu.Text.Trim(),
                combox_LoaiManHinh.SelectedValue?.ToString(),
                soGhe,
                tinhTrang,
                soHang,
                soCot
            );

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaPhongChieu.Text)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rows = DuLieuDAO.Delete_PhongChieu(txt_MaPhongChieu.Text.Trim());
                if (rows > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
        }
        #endregion

        #region Helpers
        private bool ValidateInput(out int soGhe, out int tinhTrang, out int soHang, out int soCot)
        {
            soGhe = tinhTrang = soHang = soCot = 0;

            if (string.IsNullOrWhiteSpace(txt_TenPhongChieu.Text) ||
                string.IsNullOrWhiteSpace(txt_SoGhe.Text) ||
                string.IsNullOrWhiteSpace(txt_TinhTrangPhong.Text))
            {
                MessageBox.Show("Tên phòng chiếu, số ghế và tình trạng không được để trống.");
                return false;
            }

            if (!int.TryParse(txt_SoGhe.Text.Trim(), out soGhe) ||
                !int.TryParse(txt_TinhTrangPhong.Text.Trim(), out tinhTrang) ||
                !int.TryParse(txt_SoHangGhe.Text.Trim(), out soHang) ||
                !int.TryParse(txt_SoCotGhe.Text.Trim(), out soCot))
            {
                MessageBox.Show("Các giá trị số phải hợp lệ.");
                return false;
            }

            return true;
        }
        #endregion
    }
}
