using System;
using System.Data;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    public partial class TheLoaiUC : UserControl
    {
        public TheLoaiUC()
        {
            InitializeComponent();
            LoadTheLoai();
        }

        private void LoadTheLoai()
        {
            dtgv_TheLoaiUC.DataSource = DuLieuDAO.GetAll_TheLoai();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_TheLoaiUC.DataSource = DuLieuDAO.Search_TheLoai(
                txt_MaTheLoai.Text.Trim(),
                txt_TenTheLoai.Text.Trim()
            );
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DuLieuDAO.Insert_TheLoai(txt_TenTheLoai.Text.Trim(), richtxt_MoTa.Text.Trim());
                LoadTheLoai();
                MessageBox.Show("Thêm thể loại thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DuLieuDAO.Update_TheLoai(txt_MaTheLoai.Text.Trim(),
                    txt_TenTheLoai.Text.Trim(),
                    richtxt_MoTa.Text.Trim());
                LoadTheLoai();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DuLieuDAO.Delete_TheLoai(txt_MaTheLoai.Text.Trim());
                    LoadTheLoai();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dtgv_TheLoaiUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgv_TheLoaiUC.Rows[e.RowIndex];
            txt_MaTheLoai.Text = row.Cells["MaTheLoai"].Value?.ToString();
            txt_TenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();
            richtxt_MoTa.Text = row.Cells["MoTa"].Value?.ToString();
        }
    }
}
