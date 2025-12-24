using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class KhachHangUC : UserControl
    {
        private BindingSource bsKhachHang = new BindingSource();

        public KhachHangUC()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dtgv_KhachHangUC.AutoGenerateColumns = false;
            dtgv_KhachHangUC.DataSource = bsKhachHang;
            dtgv_KhachHangUC.Columns.Clear();

            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaKH", HeaderText = "Mã KH" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgaySinh", HeaderText = "Ngày sinh" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SDT", HeaderText = "SĐT" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CMND", HeaderText = "CMND" });
            dtgv_KhachHangUC.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiemTichLuy", HeaderText = "Điểm TL" });

            dtgv_KhachHangUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_KhachHangUC.MultiSelect = false;
        }
        private void LoadData()
        {
            DataTable dt = KhachHangDAO.GetAll();
            bsKhachHang.DataSource = dt;
            //string columns = string.Join("\n", dt.Columns.Cast<DataColumn>().Select(c => $"\"{c.ColumnName}\""));
            //MessageBox.Show("Tên cột thực tế từ SP:\n" + columns, "DEBUG");
        }

        private bool TryGetCustomerInput(out string hoTen, out DateTime ngaySinh, out string diaChi, out string sdt, out int cmnd, out int diem)
        {
            hoTen = txt_HoTenKH.Text?.Trim();
            diaChi = txt_DiaChiKH.Text?.Trim();
            sdt = txt_SoDienThoaiKH.Text?.Trim();
            cmnd = 0;
            diem = (int)numeric_DiemTichLuyKH.Value;

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ngaySinh = default;
                return false;
            }

            if (!DateTime.TryParseExact(txt_NgaySinhKH.Text?.Trim(),
                    new[] { "yyyy-MM-dd", "yyyy/MM/dd", "dd/MM/yyyy", "dd-MM-yyyy" },
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(sdt, @"^\+?\d{9,15}$"))
            {
                MessageBox.Show("SĐT không hợp lệ (9-15 chữ số, có thể có +).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txt_CMNDKH.Text?.Trim(), out cmnd))
            {
                MessageBox.Show("CMND phải là số nguyên.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // =================== EVENTS ===================

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bsKhachHang.DataSource = string.IsNullOrWhiteSpace(txt_TimKiemTheoTen.Text)
                ? KhachHangDAO.GetAll()
                : KhachHangDAO.Search(txt_TimKiemTheoTen.Text.Trim());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!TryGetCustomerInput(out var hoTen, out var ngaySinh, out var diaChi, out var sdt, out var cmnd, out var diem))
                return;

            // Convert ngaySinh to string in the required format
            string ngaySinhStr = ngaySinh.ToString("yyyy-MM-dd");

            if (KhachHangDAO.Insert(hoTen, diaChi, sdt, cmnd, diem) > 0)
                MessageBox.Show("Thêm khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKH.Text)) return;
            if (!TryGetCustomerInput(out var hoTen, out var ngaySinh, out var diaChi, out var sdt, out var cmnd, out var diem))
                return;


            if (KhachHangDAO.Update(txt_MaKH.Text, hoTen, diaChi, sdt, cmnd, diem) > 0)
                MessageBox.Show("Cập nhật khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cập nhật khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKH.Text)) return;

            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (KhachHangDAO.Delete(txt_MaKH.Text) > 0)
                    MessageBox.Show("Xóa khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LoadData();
            }
        }

        private void dtgv_KhachHangUC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dtgv_KhachHangUC.Rows[e.RowIndex];

            txt_MaKH.Text = row.Cells["MaKH"].Value?.ToString() ?? string.Empty;
            txt_HoTenKH.Text = row.Cells["HoTen"].Value?.ToString() ?? string.Empty;
            txt_DiaChiKH.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;
            txt_SoDienThoaiKH.Text = row.Cells["SDT"].Value?.ToString() ?? string.Empty;
            txt_CMNDKH.Text = row.Cells["CMND"].Value?.ToString() ?? string.Empty;

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out var ns))
                txt_NgaySinhKH.Text = ns.ToString("yyyy-MM-dd");
            else
                txt_NgaySinhKH.Text = string.Empty;

            if (int.TryParse(row.Cells["DiemTichLuy"].Value?.ToString(), out var diem))
                numeric_DiemTichLuyKH.Value = Math.Clamp(diem, numeric_DiemTichLuyKH.Minimum, numeric_DiemTichLuyKH.Maximum);
            else
                numeric_DiemTichLuyKH.Value = numeric_DiemTichLuyKH.Minimum;
        }
    }
}
