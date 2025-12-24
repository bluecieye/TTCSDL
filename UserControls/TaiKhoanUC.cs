using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class TaiKhoanUC : UserControl
    {
        public TaiKhoanUC()
        {
            InitializeComponent();
            dtgv_TaiKhoanUC.CellClick += dtgv_TaiKhoanUC_CellClick;
        }


        private void TaiKhoanUC_Load(object sender, EventArgs e)
        {
            LoadAccountList();
            LoadLoaiTaiKhoan();
        }

        private void LoadAccountList()
        {
            DataTable dt = TaiKhoanDAO.GetAll();
            dtgv_TaiKhoanUC.DataSource = dt;
        }

        void LoadLoaiTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(int));
            dt.Columns.Add("Text", typeof(string));

            dt.Rows.Add(1, "Admin");
            dt.Rows.Add(2, "Nhân viên");

            combox_LoaiTaiKhoan.DataSource = dt;
            combox_LoaiTaiKhoan.DisplayMember = "Text";
            combox_LoaiTaiKhoan.ValueMember = "Value";
        }

        private void dtgv_TaiKhoanUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dtgv_TaiKhoanUC.Rows[e.RowIndex];
            txt_UserName.Text = row.Cells["Username"].Value.ToString();
            txt_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
            txt_TenNV.Text = row.Cells["Tên nhân viên"].Value.ToString();
            txt_MatKhau.Text = row.Cells["Mật khẩu"].Value.ToString();

            int loai = Convert.ToInt32(row.Cells["Loại tài khoản"].Value);
            combox_LoaiTaiKhoan.SelectedValue = loai;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string HoTen = txt_TenNV.Text.Trim();
            string MaNV = txt_MaNV.Text.Trim();

            DataTable dt = TaiKhoanDAO.Search(
                string.IsNullOrEmpty(HoTen) ? null : HoTen, 
                string.IsNullOrEmpty(MaNV) ? null : MaNV
            );
            dtgv_TaiKhoanUC.DataSource = dt;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                MessageBox.Show("Vui lòng nhập Username mới!", "Thông báo");
                return;
            }

            if (dtgv_TaiKhoanUC.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa!", "Thông báo");
                return;
            }

            string oldUsername = dtgv_TaiKhoanUC.CurrentRow.Cells["Username"].Value.ToString();
            string newUsername = txt_UserName.Text.Trim();
            int loaiTK = (int)combox_LoaiTaiKhoan.SelectedValue;
            string newPassword = txt_MatKhau.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
                newPassword = null;

            try
            {
                TaiKhoanDAO.Update(oldUsername, newUsername, loaiTK, newPassword);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
                LoadAccountList(); // reload danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
