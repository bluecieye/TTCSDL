using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;
using Microsoft.Data.SqlClient;
using TTCSDL_NHOM7.Utilities;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class HOADON : Form
    {
        // Thông tin từ các form trước
        private string idLichChieu;
        private List<string> danhSachGhe;
        private decimal tongTienVe;
        private List<MonAnItem> gioHangMonAn;
        private string idNhanVien;

        // Biến lưu trữ
        private DataTable dtKhachHang;
        private decimal tongTienMonAn = 0;
        private string maHoaDon = "";
        private int diemSuDung = 0;

        public HOADON(string idLichChieu, List<string> danhSachGhe, decimal tongTienVe, List<MonAnItem> gioHangMonAn)
        {
            InitializeComponent();
            this.idLichChieu = idLichChieu;
            this.danhSachGhe = danhSachGhe ?? new List<string>();
            this.tongTienVe = tongTienVe;
            this.gioHangMonAn = gioHangMonAn ?? new List<MonAnItem>();
            this.idNhanVien = Utilities.UserSession.MaNV ?? "NV001"; // Lấy từ session

            // Khởi tạo form
            KhoiTaoForm();
        }

        private void KhoiTaoForm()
        {
            // 1. Tạo mã hóa đơn
            TaoMaHoaDon();

            // 2. Load thông tin cơ bản
            LoadThongTinCoBan();

            // 3. Load danh sách khách hàng
            LoadDanhSachKhachHang();

            // 4. Load thông tin vé
            LoadThongTinVe();

            // 5. Load thông tin món ăn
            LoadThongTinMonAn();

            // 6. Load phương thức thanh toán
            LoadPhuongThucThanhToan();

            // 7. Tính toán tổng tiền
            TinhToanTongTien();

            // 8. Ẩn các nút không dùng (nếu có)
            //btnChonGhe.Visible = false;
            //btnXoaGhe.Visible = false;
            //btnChonMonAn.Visible = false;
            //btnXoaMon.Visible = false;
        }

        private void TaoMaHoaDon()
        {
            try
            {
                // Lấy số lượng hóa đơn hiện có để tạo mã mới
                string query = "SELECT COUNT(*) FROM HoaDon";
                int count = Convert.ToInt32(DataProvider.ExecuteScalar(query));

                maHoaDon = "HD" + (count + 1).ToString("D4");
                txtMaHoaDon.Text = maHoaDon;
                txtMaHoaDon.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo mã hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongTinCoBan()
        {
            try
            {
                // Ngày lập
                dtpNgayLap.Value = DateTime.Now;
                dtpNgayLap.Enabled = false;

                // Nhân viên
                txtNhanVien.Text = idNhanVien;
                txtNhanVien.Enabled = false;

                // Điểm tích lũy (mặc định 0)
                txtDiemTichLuy.Text = "0";
                txtDiemTichLuy.Enabled = false;

                // Giảm giá mặc định
                txtGiamGia.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load thông tin cơ bản: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {
                // Lấy danh sách khách hàng từ stored procedure
                dtKhachHang = DataProvider.ExecuteQuery(
                    "USP_KhachHang_CRUD",
                    CommandType.StoredProcedure,
                    new SqlParameter("@Action", "GET_ALL")
                );

                // Thêm dòng "Khách vãng lai"
                DataRow newRow = dtKhachHang.NewRow();
                newRow["MaKH"] = "";
                newRow["HoTen"] = "--- KHÁCH VÃNG LAI ---";
                newRow["DiemTichLuy"] = 0;
                dtKhachHang.Rows.InsertAt(newRow, 0);

                // Gán vào ComboBox
                cboKhachHang.DataSource = dtKhachHang;
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load danh sách khách hàng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongTinVe()
        {
            try
            {
                // Clear DataGridView
                dgvVe.Rows.Clear();
                dgvVe.Columns.Clear();

                // Tạo cột
                dgvVe.Columns.Add("MaGhe", "Mã ghế");
                dgvVe.Columns.Add("LoaiGhe", "Loại ghế");
                dgvVe.Columns.Add("GiaVe", "Giá vé");
                dgvVe.Columns.Add("PhiGhe", "Phí ghế");
                dgvVe.Columns.Add("ThanhTien", "Thành tiền");
                dgvVe.Columns.Add("idGhe", "idGhe");
                dgvVe.Columns["idGhe"].Visible = false;

                // Load thông tin từng ghế
                decimal tongTien = 0;

                foreach (string idGhe in danhSachGhe)
                {
                    // Lấy thông tin ghế
                    DataTable dtGhe = DataProvider.ExecuteQuery(
                        "SELECT G.MaGhe, LG.TenLoaiGhe, LG.ChiPhi " +
                        "FROM Ghe G " +
                        "JOIN LoaiGhe LG ON G.idLoaiGhe = LG.idLoaiGhe " +
                        "WHERE G.id = @idGhe",
                        CommandType.Text,
                        new SqlParameter("@idGhe", idGhe)
                    );

                    if (dtGhe.Rows.Count > 0)
                    {
                        DataRow row = dtGhe.Rows[0];
                        string maGhe = row["MaGhe"].ToString();
                        string tenLoaiGhe = row["TenLoaiGhe"].ToString();
                        decimal chiPhi = Convert.ToDecimal(row["ChiPhi"]);

                        // Tính giá vé (chia đều tổng tiền vé cho số ghế)
                        decimal giaVe = danhSachGhe.Count > 0 ? tongTienVe / danhSachGhe.Count : 0;
                        decimal thanhTien = giaVe + chiPhi;
                        tongTien += thanhTien;

                        // Thêm vào DataGridView
                        dgvVe.Rows.Add(maGhe, tenLoaiGhe, giaVe.ToString("N0"),
                                      chiPhi.ToString("N0"), thanhTien.ToString("N0"), idGhe);
                    }
                }

                // Cập nhật tổng tiền vé
                txtTienVe.Text = tongTien.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load thông tin vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongTinMonAn()
        {
            try
            {
                // Clear DataGridView
                dgvMonAn.Rows.Clear();
                dgvMonAn.Columns.Clear();

                // Tạo cột
                dgvMonAn.Columns.Add("MaMon", "Mã món");
                dgvMonAn.Columns.Add("TenMon", "Tên món");
                dgvMonAn.Columns.Add("SoLuong", "Số lượng");
                dgvMonAn.Columns.Add("DonGia", "Đơn giá");
                dgvMonAn.Columns.Add("ThanhTien", "Thành tiền");

                // Load từ giỏ hàng
                tongTienMonAn = 0;

                foreach (MonAnItem item in gioHangMonAn)
                {
                    decimal thanhTien = item.DonGia * item.SoLuong;
                    tongTienMonAn += thanhTien;

                    dgvMonAn.Rows.Add(item.MaMon, item.TenMon, item.SoLuong,
                                      item.DonGia.ToString("N0"), thanhTien.ToString("N0"));
                }

                // Cập nhật tổng tiền món ăn
                txtTienMonAn.Text = tongTienMonAn.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load thông tin món ăn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhuongThucThanhToan()
        {
            cboPhuongThuc.Items.Clear();
            cboPhuongThuc.Items.Add("Tiền mặt");
            cboPhuongThuc.Items.Add("Chuyển khoản");
            cboPhuongThuc.Items.Add("Thẻ");
            cboPhuongThuc.SelectedIndex = 0;
        }

        private void TinhToanTongTien()
        {
            try
            {
                // Tính tổng tiền
                decimal tienVe = Convert.ToDecimal(txtTienVe.Text.Replace(",", "").Replace(".", ""));
                decimal tienMonAn = Convert.ToDecimal(txtTienMonAn.Text.Replace(",", "").Replace(".", ""));
                decimal tongTien = tienVe + tienMonAn;

                txtTongTien.Text = tongTien.ToString("N0");

                // Tính giảm giá
                decimal giamGia = 0;
                if (!string.IsNullOrEmpty(txtGiamGia.Text))
                {
                    giamGia = Convert.ToDecimal(txtGiamGia.Text.Replace(",", "").Replace(".", ""));
                }

                // Tính thành tiền
                decimal thanhTien = tongTien - giamGia;
                if (thanhTien < 0) thanhTien = 0;

                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            catch (Exception)
            {
                // Bỏ qua lỗi format
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (dgvVe.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 vé!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboPhuongThuc.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị xác nhận
                string confirmMessage = $"XÁC NHẬN THANH TOÁN\n\n" +
                    $"Mã hóa đơn: {maHoaDon}\n" +
                    $"Số vé: {dgvVe.Rows.Count}\n" +
                    $"Số món: {dgvMonAn.Rows.Count}\n" +
                    $"Tổng tiền: {txtTongTien.Text} VNĐ\n" +
                    $"Giảm giá: {txtGiamGia.Text} VNĐ\n" +
                    $"Thành tiền: {txtThanhTien.Text} VNĐ\n" +
                    $"Phương thức: {cboPhuongThuc.SelectedItem}\n\n" +
                    "Xác nhận thanh toán?";

                if (MessageBox.Show(confirmMessage, "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thực hiện thanh toán
                    ThanhToanHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhToanHoaDon()
        {
            try
            {
                // 1. Tính toán các giá trị
                decimal tongTien = Convert.ToDecimal(txtTongTien.Text.Replace(",", "").Replace(".", ""));
                decimal giamGia = Convert.ToDecimal(txtGiamGia.Text.Replace(",", "").Replace(".", ""));
                decimal thanhTien = Convert.ToDecimal(txtThanhTien.Text.Replace(",", "").Replace(".", ""));

                // 2. Lấy thông tin khách hàng
                string idKhachHang = cboKhachHang.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(idKhachHang)) idKhachHang = null;

                // 3. Tạo hóa đơn bằng stored procedure
                // Sử dụng stored procedure HoaDon_Insert (cần tạo nếu chưa có)
                // Hoặc dùng query trực tiếp
                string insertHoaDon = @"
                    INSERT INTO HoaDon (id, idKhachHang, idNhanVien, NgayLap, TongTien, 
                                        GiamGia, ThanhTien, PhuongThucTT, TrangThai, idLichChieu, DiemSuDung)
                    VALUES (@id, @idKH, @idNV, GETDATE(), @tongTien, @giamGia, @thanhTien, 
                            @phuongThuc, 1, @idLichChieu, @diemSuDung)";

                DataProvider.ExecuteNonQuery(insertHoaDon, CommandType.Text,
                    new SqlParameter("@id", maHoaDon),
                    new SqlParameter("@idKH", (object)idKhachHang ?? DBNull.Value),
                    new SqlParameter("@idNV", idNhanVien),
                    new SqlParameter("@tongTien", tongTien),
                    new SqlParameter("@giamGia", giamGia),
                    new SqlParameter("@thanhTien", thanhTien),
                    new SqlParameter("@phuongThuc", cboPhuongThuc.SelectedIndex),
                    new SqlParameter("@idLichChieu", idLichChieu),
                    new SqlParameter("@diemSuDung", diemSuDung)
                );

                // 4. Tạo vé cho từng ghế
                foreach (DataGridViewRow row in dgvVe.Rows)
                {
                    if (row.Cells["idGhe"].Value == null) continue;

                    string idGhe = row.Cells["idGhe"].Value.ToString();
                    decimal tienVe = Convert.ToDecimal(row.Cells["ThanhTien"].Value.ToString()
                        .Replace(",", "").Replace(".", ""));

                    string insertVe = @"
                        INSERT INTO Ve (LoaiVe, idLichChieu, idGhe, idHoaDon, idKhachHang, 
                                        TrangThai, TienBanVe)
                        VALUES (0, @idLC, @idGhe, @idHD, @idKH, 2, @tienVe)";

                    DataProvider.ExecuteNonQuery(insertVe, CommandType.Text,
                        new SqlParameter("@idLC", idLichChieu),
                        new SqlParameter("@idGhe", idGhe),
                        new SqlParameter("@idHD", maHoaDon),
                        new SqlParameter("@idKH", (object)idKhachHang ?? DBNull.Value),
                        new SqlParameter("@tienVe", tienVe)
                    );
                }

                // 5. Thêm chi tiết món ăn
                foreach (DataGridViewRow row in dgvMonAn.Rows)
                {
                    string idMonAn = row.Cells["MaMon"].Value?.ToString();
                    if (string.IsNullOrEmpty(idMonAn)) continue;

                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString()
                        .Replace(",", "").Replace(".", ""));
                    decimal thanhTienMon = Convert.ToDecimal(row.Cells["ThanhTien"].Value.ToString()
                        .Replace(",", "").Replace(".", ""));

                    string insertChiTiet = @"
                        INSERT INTO ChiTietMonAn (idHoaDon, idMonAn, SoLuong, DonGia, ThanhTien)
                        VALUES (@idHD, @idMon, @soLuong, @donGia, @thanhTien)";

                    DataProvider.ExecuteNonQuery(insertChiTiet, CommandType.Text,
                        new SqlParameter("@idHD", maHoaDon),
                        new SqlParameter("@idMon", idMonAn),
                        new SqlParameter("@soLuong", soLuong),
                        new SqlParameter("@donGia", donGia),
                        new SqlParameter("@thanhTien", thanhTienMon)
                    );
                }

                // 6. Cập nhật điểm tích lũy nếu có khách hàng
                if (!string.IsNullOrEmpty(idKhachHang))
                {
                    int diemThem = (int)(thanhTien / 1000); // 1000đ = 1 điểm

                    string updateDiem = @"
                        UPDATE KhachHang 
                        SET DiemTichLuy = DiemTichLuy + @diemThem 
                        WHERE id = @idKH";

                    DataProvider.ExecuteNonQuery(updateDiem, CommandType.Text,
                        new SqlParameter("@diemThem", diemThem),
                        new SqlParameter("@idKH", idKhachHang)
                    );
                }

                // 7. Thông báo thành công
                string successMessage = $"✓ THANH TOÁN THÀNH CÔNG!\n\n" +
                    $"Mã hóa đơn: {maHoaDon}\n" +
                    $"Số vé: {dgvVe.Rows.Count}\n" +
                    $"Số món: {dgvMonAn.Rows.Count}\n" +
                    $"Thành tiền: {txtThanhTien.Text} VNĐ";

                MessageBox.Show(successMessage, "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 8. Hỏi có muốn in hóa đơn không
                DialogResult printResult = MessageBox.Show("Bạn có muốn in hóa đơn?", "In hóa đơn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (printResult == DialogResult.Yes)
                {
                    InHoaDon();
                }

                // 9. Đóng form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InHoaDon()
        {
            try
            {
                // Tạo form in hóa đơn đơn giản
                string content = $"HÓA ĐƠN BÁN VÉ\n" +
                    $"Mã: {maHoaDon}\n" +
                    $"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                    $"Nhân viên: {txtNhanVien.Text}\n" +
                    $"Khách hàng: {cboKhachHang.Text}\n" +
                    $"Phương thức: {cboPhuongThuc.Text}\n" +
                    $"--------------------------------\n" +
                    $"Chi tiết vé:\n";

                foreach (DataGridViewRow row in dgvVe.Rows)
                {
                    content += $"- {row.Cells["MaGhe"].Value}: {row.Cells["ThanhTien"].Value} VNĐ\n";
                }

                if (dgvMonAn.Rows.Count > 0)
                {
                    content += $"Chi tiết món ăn:\n";
                    foreach (DataGridViewRow row in dgvMonAn.Rows)
                    {
                        content += $"- {row.Cells["TenMon"].Value} x{row.Cells["SoLuong"].Value}: {row.Cells["ThanhTien"].Value} VNĐ\n";
                    }
                }

                content += $"--------------------------------\n" +
                    $"Tổng tiền: {txtTongTien.Text} VNĐ\n" +
                    $"Giảm giá: {txtGiamGia.Text} VNĐ\n" +
                    $"THÀNH TIỀN: {txtThanhTien.Text} VNĐ\n" +
                    $"--------------------------------\n" +
                    $"Cảm ơn quý khách!";

                MessageBox.Show(content, "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy hóa đơn này?\n\nTất cả thông tin đã nhập sẽ bị xóa!",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void button_closeHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhToanTongTien();
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboKhachHang.SelectedValue != null &&
                    !string.IsNullOrEmpty(cboKhachHang.SelectedValue.ToString()))
                {
                    // Lấy điểm tích lũy của khách hàng
                    string idKH = cboKhachHang.SelectedValue.ToString();
                    if (!string.IsNullOrEmpty(idKH))
                    {
                        DataTable dt = DataProvider.ExecuteQuery(
                            "SELECT DiemTichLuy FROM KhachHang WHERE id = @id",
                            CommandType.Text,
                            new SqlParameter("@id", idKH)
                        );

                        if (dt.Rows.Count > 0)
                        {
                            int diem = Convert.ToInt32(dt.Rows[0]["DiemTichLuy"]);
                            txtDiemTichLuy.Text = diem.ToString();
                        }
                    }
                }
                else
                {
                    txtDiemTichLuy.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load điểm tích lũy: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}