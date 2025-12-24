using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.UserControls.DuLieuUC_Controls;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class DuLieuUC : UserControl
    {
        public DuLieuUC()
        {
            InitializeComponent();
        }

        private void lOẠIMÀNHÌNHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            LoaiManHinhUC uc = new LoaiManHinhUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void pHÒNGCHIẾUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            PhongChieuUC uc = new PhongChieuUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void tHỂLOẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            TheLoaiUC uc = new TheLoaiUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void pHIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            PhimUC uc = new PhimUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void đỊNHDẠNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            DinhDangUC uc = new DinhDangUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void lỊCHCHIẾUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            LichChieuUC uc = new LichChieuUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void vÉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DuLieu.Controls.Clear();
            VeUC uc = new VeUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }

        private void gHẾToolStripMenuItem_Click(object sender, EventArgs e)
        {
             panel_DuLieu.Controls.Clear();
            QuanLyGheUC uc = new QuanLyGheUC();
            uc.Dock = DockStyle.Fill;
            panel_DuLieu.Controls.Add(uc);
        }
    }
}
