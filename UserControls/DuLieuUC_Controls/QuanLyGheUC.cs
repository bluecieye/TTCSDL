using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class QuanLyGheUC : UserControl
    {
        string _idGheDangChon = null;
        bool _isLoading = true;

        public QuanLyGheUC()
        {
            InitializeComponent();
            _isLoading = true;

            LoadComboBoxPhongChieu();
            LoadComboBoxLoaiGhe();
            LoadDataLoaiGhe();

            _isLoading = false;
            LoadDataGhe();
        }

        // Tab quản lý ghế
        #region Ghe
        void LoadDataGhe()
        {
            if (cboPhongChieu.SelectedValue == null) return;

            string idPhong = cboPhongChieu.SelectedValue.ToString();
            DataTable dt = DuLieuDAO.LayDanhSachGheTheoPhong(idPhong);

            dgvGhe.DataSource = dt;
            lblTongGhe.Text = $"Tổng số ghế: {dt.Rows.Count}";
        }

        private void cboPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            LoadDataGhe();
        }


        void LoadComboBoxPhongChieu()
        {
            cboPhongChieu.DataSource = DuLieuDAO.GetAll_PhongChieu();
            cboPhongChieu.DisplayMember = "Tên phòng";
            cboPhongChieu.ValueMember = "Mã phòng";
        }


        private void btnSinhGhe_Click(object sender, EventArgs e)
        {
            if (cboPhongChieu.SelectedValue == null) return;

            if (MessageBox.Show("Sinh lại ghế sẽ xóa toàn bộ ghế cũ. Tiếp tục?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DuLieuDAO.SinhGheTheoPhong(cboPhongChieu.SelectedValue.ToString());
            LoadDataGhe();
        }

        private void btnXoaTatCaGhe_Click(object sender, EventArgs e)
        {
            if (cboPhongChieu.SelectedValue == null) return;

            DuLieuDAO.XoaTatCaGheTheoPhong(cboPhongChieu.SelectedValue.ToString());
            LoadDataGhe();
        }

        private void btnCapNhatLoaiGhe_Click(object sender, EventArgs e)
        {
            if (_idGheDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn ghế");
                return;
            }

            int idLoaiGhe = Convert.ToInt32(cboLoaiGhe.SelectedValue);
            DuLieuDAO.CapNhatLoaiGhe_Ghe(_idGheDangChon, idLoaiGhe);
            LoadDataGhe();
        }

        private void dgvGhe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvGhe.Rows[e.RowIndex];
            _idGheDangChon = row.Cells["id"].Value.ToString();

            lblThongTinGhe.Text = $"Ghế: {row.Cells["MaGhe"].Value}";
        }
        #endregion

        // Tab quan lý loại ghế
        #region Loai Ghe
        void LoadDataLoaiGhe()
        {
            dgvLoaiGhe.DataSource = DuLieuDAO.GetAll_LoaiGhe();

            dgvLoaiGhe.Columns["idLoaiGhe"].HeaderText = "Mã loại ghế";
            dgvLoaiGhe.Columns["TenLoaiGhe"].HeaderText = "Tên loại ghế";
            dgvLoaiGhe.Columns["ChiPhi"].HeaderText = "Chi phí";
        }

        void LoadComboBoxLoaiGhe()
        {
            cboLoaiGhe.DataSource = DuLieuDAO.GetAll_LoaiGhe();
            cboLoaiGhe.DisplayMember = "TenLoaiGhe";
            cboLoaiGhe.ValueMember = "idLoaiGhe";
        }

        private void btnThemLoaiGhe_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtChiPhi.Text, out decimal chiPhi))
            {
                MessageBox.Show("Chi phí không hợp lệ");
                return;
            }
            if (DuLieuDAO.ThemLoaiGhe(txtTenLoaiGhe.Text, decimal.Parse(txtChiPhi.Text)) > 0)
            {
                MessageBox.Show("Thêm loại ghế thành công", "Tingg!", MessageBoxButtons.OK);
                LoadDataLoaiGhe();
                LoadComboBoxLoaiGhe();
            }
        }

        private void btnSuaLoaiGhe_Click(object sender, EventArgs e)
        {
            int idLoaiGhe = int.Parse(txtMaLoaiGhe.Text);
            if (!decimal.TryParse(txtChiPhi.Text, out decimal chiPhi))
            {
                MessageBox.Show("Chi phí không hợp lệ");
                return;
            }
            DuLieuDAO.CapNhatLoaiGhe(
                idLoaiGhe,
                txtTenLoaiGhe.Text,
                decimal.Parse(txtChiPhi.Text)
            );
            LoadDataLoaiGhe();
            LoadComboBoxLoaiGhe();
        }

        private void btnXoaLoaiGhe_Click(object sender, EventArgs e)
        {
            int idLoaiGhe = int.Parse(txtMaLoaiGhe.Text);
            try
            {
                DuLieuDAO.XoaLoaiGhe(idLoaiGhe);
                LoadDataLoaiGhe();
                LoadComboBoxLoaiGhe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nghiệp vụ");
            }
        }

        private void dgvLoaiGhe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvLoaiGhe.Rows[e.RowIndex];
            txtMaLoaiGhe.Text = row.Cells["idLoaiGhe"].Value.ToString();
            txtTenLoaiGhe.Text = row.Cells["TenLoaiGhe"].Value.ToString();
            txtChiPhi.Text = row.Cells["ChiPhi"].Value.ToString();
        }
        #endregion
    }
}
