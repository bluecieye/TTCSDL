using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;
using TTCSDL_NHOM7.UserControls;
using TTCSDL_NHOM7.Utilities;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class QUANLY : Form
    {
        public QUANLY()
        {
            InitializeComponent();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            DoanhThuUC uc = new DoanhThuUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }

        private void btn_DuLieu_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            DuLieuUC uc = new DuLieuUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            NhanVienUC uc = new NhanVienUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            KhachHangUC uc = new KhachHangUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            TaiKhoanUC uc = new TaiKhoanUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }

        private void btn_MonAn_Click(object sender, EventArgs e)
        {
            panel_ADMIN.Controls.Clear();
            QuanLyMonAnUC uc = new QuanLyMonAnUC();
            uc.Dock = DockStyle.Fill;
            panel_ADMIN.Controls.Add(uc);
        }
    }
}
