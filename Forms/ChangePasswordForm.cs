using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RapApp.DataAccess;           // DBConnect
using RapApp.DataAccessLayer;      // AccountDAO

namespace RapApp.Forms
{
    public class ChangePasswordForm : Form
    {
        private readonly string idTaiKhoan;
        private TextBox txtOld, txtNew, txtConfirm;
        private Button btnSave, btnCancel;

        public ChangePasswordForm(string id)
        {
            idTaiKhoan = id ?? throw new ArgumentNullException(nameof(id));
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Đổi mật khẩu";
            this.Width = 420;
            this.Height = 240;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Label l1 = new Label() { Text = "Mật khẩu cũ:", Left = 20, Top = 20, Width = 120 };
            txtOld = new TextBox() { Left = 150, Top = 18, Width = 230, UseSystemPasswordChar = true };

            Label l2 = new Label() { Text = "Mật khẩu mới:", Left = 20, Top = 60, Width = 120 };
            txtNew = new TextBox() { Left = 150, Top = 58, Width = 230, UseSystemPasswordChar = true };

            Label l3 = new Label() { Text = "Xác nhận mật khẩu:", Left = 20, Top = 100, Width = 120 };
            txtConfirm = new TextBox() { Left = 150, Top = 98, Width = 230, UseSystemPasswordChar = true };

            btnSave = new Button() { Text = "Lưu", Left = 150, Top = 140, Width = 100 };
            btnCancel = new Button() { Text = "Huỷ", Left = 280, Top = 140, Width = 100 };

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] { l1, txtOld, l2, txtNew, l3, txtConfirm, btnSave, btnCancel });
        }


        // copy of the same SHA256 hashing used in AccountDAO
        private static string HashPassword(string pass)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(pass ?? ""));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(txtOld.Text) ||
                string.IsNullOrWhiteSpace(txtNew.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1) Lấy mật khẩu (hash) hiện tại trong DB
                string storedHash = null;
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT MatKhau FROM TAIKHOAN WHERE IDTaiKhoan = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idTaiKhoan);
                        var obj = cmd.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value) storedHash = obj.ToString();
                    }
                }

                if (string.IsNullOrEmpty(storedHash))
                {
                    MessageBox.Show("Không tìm thấy tài khoản hoặc mật khẩu chưa được thiết lập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2) So sánh hash mật khẩu cũ
                string oldHash = HashPassword(txtOld.Text);
                if (!string.Equals(oldHash, storedHash, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3) Cập nhật mật khẩu mới (AccountDAO.UpdatePassword đã hash lại)
                bool ok = AccountDAO.UpdatePassword(idTaiKhoan, txtNew.Text);
                if (ok)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
