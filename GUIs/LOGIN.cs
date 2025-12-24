using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;
using TTCSDL_NHOM7.Utilities;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();

            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        private void TxtUsername_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TxtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void PassVisible_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PassVisible_checkbox.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            DataTable dt = TaiKhoanDAO.Login(username, password);

            if (dt.Rows.Count > 0)
            {
                // Lưu session
                UserSession.UserName = dt.Rows[0]["UserName"].ToString();
                UserSession.LoaiTK = Convert.ToInt32(dt.Rows[0]["LoaiTK"]);
                UserSession.MaNV = dt.Rows[0]["MaNV"].ToString();
                UserSession.HoTen = dt.Rows[0]["HoTen"].ToString();

                this.Hide();
                DASHBOARD main = new DASHBOARD();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
