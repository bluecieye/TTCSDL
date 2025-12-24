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
    public partial class VeUC : UserControl
    {
        public VeUC()
        {
            InitializeComponent();
            Load_TatCaLichChieu();
        }

        void Load_TatCaLichChieu()
        {
            listview_TatCaLichChieu.Items.Clear();
            DataTable dt = DuLieuDAO.GetAll_LichChieu();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhong"].ToString());
                item.SubItems.Add(row["TenPhim"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ThoiGianChieu"]).ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add("Đã tạo");

                item.Tag = row["MaLichChieu"].ToString();
                listview_TatCaLichChieu.Items.Add(item);
            }
        }


        private void btnThemVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu");
                return;
            }

            string maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();
            DuLieuDAO.AutoAdd_Ve(maLichChieu);
            MessageBox.Show("Đã tạo vé cho lịch chiếu");
        }


        private void btnXoaVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn lịch chiếu cần xóa vé");
                return;
            }

            string maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();
            DuLieuDAO.Delete_Ve_TheoLichChieu(maLichChieu);
            MessageBox.Show("Đã xóa vé theo lịch chiếu");
        }


        private void btnVeDaMuaTheoLichChieu_Click(object sender, EventArgs e)
        {
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn lịch chiếu");
                return;
            }

            string maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();
            dtgvVe.DataSource = DuLieuDAO.Get_VeDaBan(maLichChieu);
        }


        private void btn_TatCaVeTheoLichChieu_Click(object sender, EventArgs e)
        {
            dtgvVe.DataSource = DuLieuDAO.GetAll_Ve();
        }


        private void btnXemLichChieuChuaTaoVe_Click(object sender, EventArgs e)
        {
            listview_TatCaLichChieu.Items.Clear();
            DataTable dt = DuLieuDAO.Get_LichChieu_ChuaTaoVe();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhong"].ToString());
                item.SubItems.Add(row["MaDinhDang"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ThoiGianChieu"]).ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add("Chưa tạo vé");

                item.Tag = row["MaLichChieu"].ToString();
                listview_TatCaLichChieu.Items.Add(item);
            }
        }


        private void btnXemTatCaLichChieu_Click(object sender, EventArgs e)
        {
            listview_TatCaLichChieu.Items.Clear();
            Load_TatCaLichChieu();
        }

        private void listview_TatCaLichChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi có ít nhất 1 item được chọn
            if (listview_TatCaLichChieu.SelectedItems.Count == 0)
            {
                dtgvVe.DataSource = null; // Xóa dữ liệu cũ nếu không chọn gì
                return;
            }

            // Lấy mã lịch chiếu từ Tag của item được chọn
            string maLichChieu = listview_TatCaLichChieu.SelectedItems[0].Tag.ToString();

            // Load danh sách vé đã bán của lịch chiếu đó vào DataGridView
            DataTable dtVeDaBan = DuLieuDAO.Get_VeDaBan(maLichChieu);

            dtgvVe.DataSource = dtVeDaBan;
        }
    }
}
