using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.Utilities;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
            txt_Ten.Text = UserSession.HoTen;

            if (UserSession.LoaiTK == 1)
            {
                btn_QuanLy.Enabled = true;
            }
            else
            {
                btn_QuanLy.Enabled = false;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            UserSession.UserName = null;
            UserSession.MaNV = null;
            UserSession.HoTen = null;
            UserSession.LoaiTK = 0;

            this.Close();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLY ql = new QUANLY();
            ql.ShowDialog();
            this.Show();
        }

        private void btn_BanVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHONPHIM cp = new CHONPHIM();
            cp.ShowDialog();
            this.Show();
        }
    }
}
