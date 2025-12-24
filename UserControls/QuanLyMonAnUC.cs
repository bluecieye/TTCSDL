using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class QuanLyMonAnUC : UserControl
    {
        public QuanLyMonAnUC()
        {
            InitializeComponent();
            LoadDanhSachMonAn();
            LoadTrangThai();
        }

        void LoadDanhSachMonAn()
        {
            dgvMonAn.DataSource = DuLieuDAO.GetAll_MonAn();
        }

        void LoadTrangThai()
        {
            cboTrangThai.DataSource = new[]
            {
                new { Id = 1, Name = "Đang bán" },
                new { Id = 0, Name = "Ngưng bán" }
            };

            cboTrangThai.DisplayMember = "Name";
            cboTrangThai.ValueMember = "Id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Tên món không được trống");
                return;
            }

            byte[] imgBytes = DuLieuDAO.ImageToByteArray(picHinhAnh.Image);

            int result = DuLieuDAO.Insert_MonAn(
                txtTenMon.Text.Trim(),
                txtMoTa.Text.Trim(),
                decimal.Parse(txtDonGia.Text),
                (int)cboLoaiMon.SelectedValue,
                (int)cboTrangThai.SelectedValue,
                imgBytes
            );

            if (result == 1)
            {
                MessageBox.Show("Thêm món ăn thành công");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Thêm món thất bại");
            }
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMonAn.Rows[e.RowIndex];

            txtMaMon.Text = row.Cells["Mã món"].Value.ToString();
            txtTenMon.Text = row.Cells["Tên món"].Value.ToString();
            txtMoTa.Text = row.Cells["Mô tả"].Value.ToString();
            txtDonGia.Text = row.Cells["Đơn giá"].Value.ToString();
            cboLoaiMon.SelectedValue = row.Cells["Loại món"].Value;
            cboTrangThai.SelectedValue = row.Cells["Trạng thái"].Value;

            if (row.Cells["Hình ảnh"].Value != DBNull.Value)
                picHinhAnh.Image = DuLieuDAO.ByteArrayToImage((byte[])row.Cells["Hình ảnh"].Value);
            else
                picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMon.Text) || txtMaMon.Text == "Tự động")
            {
                MessageBox.Show("Chọn món cần sửa");
                return;
            }

            byte[] imgBytes = DuLieuDAO.ImageToByteArray(picHinhAnh.Image);

            int result = DuLieuDAO.Update_MonAn(
                txtMaMon.Text,
                txtTenMon.Text,
                txtMoTa.Text,
                decimal.Parse(txtDonGia.Text),
                (int)cboLoaiMon.SelectedValue,
                (int)cboTrangThai.SelectedValue,
                imgBytes
            );

            if (result == 1)
            {
                MessageBox.Show("Sửa thành công");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMon.Text) || txtMaMon.Text == "Tự động") return;

            if (MessageBox.Show("Xóa món này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int result = DuLieuDAO.Delete_MonAn(txtMaMon.Text);

            if (result == 1)
            {
                MessageBox.Show("Đã xóa");
                btnLamMoi_Click(null, null);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "Tự động";
            txtTenMon.Clear();
            txtMoTa.Clear();
            txtDonGia.Clear();
            picHinhAnh.Image = null;
            cboTrangThai.SelectedIndex = 0;
            LoadDanhSachMonAn();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            picHinhAnh.Image = null;
        }
    }
}
