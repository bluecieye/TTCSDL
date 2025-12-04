using System;
using System.Windows.Forms;
using RapApp.DataAccessLayer;
using RapApp.Models;

namespace RapApp.Forms
{
    public class LoginForm : Form
    {
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Button btnLogin;
        private Label lblEmail, lblPass;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Đăng nhập";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 380;
            this.Height = 220;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            lblEmail = new Label() { Text = "Email:", Left = 20, Top = 20, Width = 80 };
            txtEmail = new TextBox() { Left = 110, Top = 18, Width = 220 };

            lblPass = new Label() { Text = "Mật khẩu:", Left = 20, Top = 60, Width = 80 };
            txtMatKhau = new TextBox() { Left = 110, Top = 58, Width = 220, UseSystemPasswordChar = true };

            btnLogin = new Button() { Text = "Đăng nhập", Left = 110, Top = 100, Width = 120 };
            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblPass);
            this.Controls.Add(txtMatKhau);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var pass = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập email và mật khẩu.");
                return;
            }

            var tk = AccountDAO.GetByEmailAndPass(email, pass);
            if (tk != null)
            {
                var dash = new DashboardForm(tk.IDTaiKhoan, tk.IDVaiTro);
                dash.FormClosed += (s, ev) => this.Show();
                this.Hide();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng / tài khoản không active.");
            }
        }
    }
}
