using System;
using System.Windows.Forms;
using RapApp.UserControls;
using RapApp.Forms;

namespace RapApp.Forms
{
    public class DashboardForm : Form
    {
        private Panel leftPanel;
        private Panel panelMain;
        private Button btnAccount, btnCustomer, btnFood, btnPayment, btnChangePass, btnLogout;
        private string currentAccountId;
        private string currentRole;

        public DashboardForm(string idTaiKhoan, string role)
        {
            currentAccountId = idTaiKhoan;
            currentRole = role;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Dashboard";
            this.WindowState = FormWindowState.Maximized;

            leftPanel = new Panel() { Width = 200, Dock = DockStyle.Left, Padding = new Padding(10) };
            panelMain = new Panel() { Dock = DockStyle.Fill };

            btnAccount = new Button() { Text = "Tài khoản", Dock = DockStyle.Top, Height = 40 };
            btnCustomer = new Button() { Text = "Khách hàng", Dock = DockStyle.Top, Height = 40 };
            btnFood = new Button() { Text = "Thức ăn", Dock = DockStyle.Top, Height = 40 };
            btnPayment = new Button() { Text = "Thanh toán", Dock = DockStyle.Top, Height = 40 };
            btnChangePass = new Button() { Text = "Đổi mật khẩu", Dock = DockStyle.Top, Height = 40 };
            btnLogout = new Button() { Text = "Đăng xuất", Dock = DockStyle.Bottom, Height = 40 };

            btnAccount.Click += BtnAccount_Click;
            btnCustomer.Click += BtnCustomer_Click;
            btnFood.Click += BtnFood_Click;
            btnPayment.Click += BtnPayment_Click;
            btnChangePass.Click += BtnChangePass_Click;
            btnLogout.Click += (s, e) => { this.Close(); };

            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnChangePass);
            leftPanel.Controls.Add(btnPayment);
            leftPanel.Controls.Add(btnFood);
            leftPanel.Controls.Add(btnCustomer);
            leftPanel.Controls.Add(btnAccount);

            this.Controls.Add(panelMain);
            this.Controls.Add(leftPanel);

            // default load
            LoadControl(new AccountUC());
        }

        private void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void BtnAccount_Click(object sender, EventArgs e) => LoadControl(new AccountUC());
        private void BtnCustomer_Click(object sender, EventArgs e) => LoadControl(new CustomerUC());
        private void BtnFood_Click(object sender, EventArgs e)
        {
            // Food is a form (to allow add/edit modal) but we can host as UserControl - for simplicity open form
            var f = new FoodForm();
            f.ShowDialog();
        }
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            var f = new PaymentForm();
            f.ShowDialog();
        }
        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            var f = new ChangePasswordForm(currentAccountId);
            f.ShowDialog();
        }
    }
}
