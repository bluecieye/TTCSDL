using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;
using TTCSDL_NHOM7.Utilities;
using Microsoft.Data.SqlClient;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class MONAN : Form
    {
        private string idLichChieu;
        private List<string> danhSachGhe;
        private decimal tongTienVe;
        private List<MonAnItem> _gioHang = new List<MonAnItem>();
        public List<MonAnItem> GioHang
        {
            get { return _gioHang; }
        }
        private DataTable allMonAn;

        public MONAN(string idLichChieu, List<string> danhSachGhe, decimal tongTienVe)
        {
            InitializeComponent();
            this.idLichChieu = idLichChieu;
            this.danhSachGhe = danhSachGhe;
            this.tongTienVe = tongTienVe;
            LoadThongTinDatCho();
            LoadAllMonAn();
            HienThiMonAnTheoLoai(1); // Mặc định hiển thị Combo
            CapNhatGioHang();
        }

        private void LoadThongTinDatCho()
        {
            try
            {
                // Lấy thông tin lịch chiếu bằng DuLieuDAO
                var dt = DuLieuDAO.Search_LichChieu(maLichChieu: idLichChieu);

                Console.WriteLine($"=== DEBUG: LoadThongTinDatCho ===");
                Console.WriteLine($"DataTable is null: {dt == null}");
                if (dt != null)
                {
                    Console.WriteLine($"Rows count: {dt.Rows.Count}");
                    Console.WriteLine($"Columns count: {dt.Columns.Count}");
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.WriteLine($"- Column: {col.ColumnName} ({col.DataType})");
                    }
                }
                Console.WriteLine($"=== END DEBUG ===");

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Lấy tên phim
                    string tenPhim = "Không rõ";
                    if (dt.Columns.Contains("TenPhim") && row["TenPhim"] != DBNull.Value)
                    {
                        tenPhim = row["TenPhim"].ToString();
                        Console.WriteLine($"Found TenPhim: {tenPhim}");
                    }
                    else
                    {
                        Console.WriteLine($"TenPhim column not found or is null");
                    }

                    // Lấy thời gian chiếu
                    DateTime thoiGianChieu = DateTime.Now;
                    if (dt.Columns.Contains("ThoiGianChieu") && row["ThoiGianChieu"] != DBNull.Value)
                    {
                        try
                        {
                            thoiGianChieu = Convert.ToDateTime(row["ThoiGianChieu"]);
                            Console.WriteLine($"Found ThoiGianChieu: {thoiGianChieu}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error converting ThoiGianChieu: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ThoiGianChieu column not found or is null");
                    }

                    labelMovieValue.Text = tenPhim;
                    labelShowtimeValue.Text = $"{thoiGianChieu:HH:mm}";
                    labelSeatsValue.Text = GetMaGheList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin lịch chiếu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin đặt chỗ: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllMonAn()
        {
            try
            {
                // Sử dụng DuLieuDAO để lấy tất cả món ăn
                allMonAn = DuLieuDAO.GetAll_MonAn();
                Console.WriteLine($"Đã tải {allMonAn.Rows.Count} món ăn");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                allMonAn = new DataTable();
            }
        }

        private void HienThiMonAnTheoLoai(int loaiMon)
        {
            flowLayoutPanelFood.Controls.Clear();

            if (allMonAn == null || allMonAn.Rows.Count == 0)
            {
                Label lblNoData = new Label
                {
                    Text = "Chưa có món ăn nào trong danh mục này",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanelFood.Controls.Add(lblNoData);
                return;
            }

            // Lọc theo loại món
            var rows = allMonAn.AsEnumerable()
                .Where(row => Convert.ToInt32(row["Loại món"]) == loaiMon)
                .ToList();

            if (rows.Count == 0)
            {
                Label lblNoData = new Label
                {
                    Text = "Chưa có món ăn nào trong danh mục này",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanelFood.Controls.Add(lblNoData);
                return;
            }

            foreach (DataRow row in rows)
            {
                CreateFoodItemPanel(row);
            }
        }

        private void CreateFoodItemPanel(DataRow row)
        {
            try
            {
                string idMonAn = row["Mã món"]?.ToString() ?? "";
                string tenMon = row["Tên món"]?.ToString() ?? "";
                decimal donGia = Convert.ToDecimal(row["Đơn giá"] ?? 0);
                string moTa = row["Mô tả"]?.ToString() ?? "";
                int loaiMon = Convert.ToInt32(row["Loại món"] ?? 0);
                int trangThai = Convert.ToInt32(row["Trạng thái"] ?? 0);

                // Nếu món ăn không hoạt động thì không hiển thị
                if (trangThai != 1) return;

                Panel panelMon = new Panel
                {
                    Width = 200,
                    Height = 280,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                // PictureBox hình ảnh
                PictureBox pic = new PictureBox
                {
                    Width = 180,
                    Height = 120,
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = idMonAn,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray
                };

                // Load hình ảnh từ database
                if (row["Hình ảnh"] != DBNull.Value)
                {
                    try
                    {
                        byte[] imageData = (byte[])row["Hình ảnh"];
                        pic.Image = DuLieuDAO.ByteArrayToImage(imageData);
                    }
                    catch
                    {
                        pic.BackColor = Color.LightGray;
                        pic.Image = null;
                    }
                }
                else
                {
                    // Ảnh mặc định
                    pic.BackColor = Color.LightGray;
                    using (Bitmap bmp = new Bitmap(180, 120))
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.LightGray);
                        g.DrawString("NO IMAGE", new Font("Arial", 12, FontStyle.Bold),
                            Brushes.White, new PointF(60, 50));
                        pic.Image = (Image)bmp.Clone();
                    }
                }

                // Label tên món
                Label lblTen = new Label
                {
                    Text = tenMon,
                    Location = new Point(10, 140),
                    Width = 180,
                    Height = 40,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Label giá
                Label lblGia = new Label
                {
                    Text = $"{donGia:#,##0} VNĐ",
                    Location = new Point(10, 180),
                    Width = 180,
                    Height = 20,
                    ForeColor = Color.Red,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Button thêm vào giỏ
                Button btnThem = new Button
                {
                    Text = "Thêm",
                    Location = new Point(10, 210),
                    Width = 80,
                    Height = 30,
                    Tag = idMonAn,
                    BackColor = Color.LightGreen,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnThem.FlatAppearance.BorderSize = 0;
                btnThem.FlatAppearance.MouseOverBackColor = Color.Green;
                btnThem.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
                btnThem.Click += BtnThem_Click;

                // Button chi tiết
                Button btnChiTiet = new Button
                {
                    Text = "Chi tiết",
                    Location = new Point(100, 210),
                    Width = 80,
                    Height = 30,
                    Tag = new { Id = idMonAn, Ten = tenMon, Gia = donGia, MoTa = moTa },
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnChiTiet.FlatAppearance.BorderSize = 0;
                btnChiTiet.FlatAppearance.MouseOverBackColor = Color.Blue;
                btnChiTiet.FlatAppearance.MouseDownBackColor = Color.DarkBlue;
                btnChiTiet.Click += BtnChiTiet_Click;

                // Tooltip cho toàn bộ panel
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(panelMon, $"Click để xem chi tiết\n{tenMon}\nGiá: {donGia:#,##0} VNĐ");

                // Thêm các control vào panel
                panelMon.Controls.Add(pic);
                panelMon.Controls.Add(lblTen);
                panelMon.Controls.Add(lblGia);
                panelMon.Controls.Add(btnThem);
                panelMon.Controls.Add(btnChiTiet);

                flowLayoutPanelFood.Controls.Add(panelMon);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi tạo panel món ăn: {ex.Message}");
            }
        }

        private string GetMaGheList()
        {
            try
            {
                var maGheList = new List<string>();
                foreach (string idGhe in danhSachGhe)
                {
                    // Sử dụng DataProvider trực tiếp vì đây là query đơn giản
                    var dt = DataProvider.ExecuteQuery(
                        "SELECT MaGhe FROM Ghe WHERE id = @id",
                        CommandType.Text,
                        new SqlParameter("@id", idGhe)
                    );
                    if (dt.Rows.Count > 0)
                        maGheList.Add(dt.Rows[0]["MaGhe"].ToString());
                }
                return string.Join(", ", maGheList);
            }
            catch
            {
                return "Không xác định";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                string idMonAn = btn.Tag.ToString();
                if (string.IsNullOrEmpty(idMonAn)) return;

                // Tìm món ăn trong danh sách đã tải
                var row = allMonAn.AsEnumerable()
                    .FirstOrDefault(r => r["Mã món"].ToString() == idMonAn);

                if (row != null)
                {
                    string tenMon = row["Tên món"].ToString();
                    decimal donGia = Convert.ToDecimal(row["Đơn giá"]);

                    // Kiểm tra xem đã có trong giỏ hàng chưa
                    MonAnItem item = GioHang.Find(x => x.MaMon == idMonAn);
                    if (item != null)
                    {
                        item.SoLuong++;
                    }
                    else
                    {
                        item = new MonAnItem
                        {
                            MaMon = idMonAn,
                            TenMon = tenMon,
                            DonGia = donGia,
                            SoLuong = 1
                        };
                        GioHang.Add(item);
                    }

                    CapNhatGioHang();

                    // Hiệu ứng visual
                    btn.BackColor = Color.Yellow;
                }
            }
        }

        private void BtnChiTiet_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                dynamic tag = btn.Tag;
                string idMonAn = tag.Id;
                string tenMon = tag.Ten;
                decimal gia = tag.Gia;
                string moTa = tag.MoTa;

                string message = $"Tên món: {tenMon}\n";
                message += $"Giá: {gia:#,##0} VNĐ\n";
                message += $"Mô tả: {(string.IsNullOrEmpty(moTa) ? "Không có mô tả" : moTa)}\n";

                MessageBox.Show(message, "Chi tiết món ăn",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CapNhatGioHang()
        {
            listViewCart.Items.Clear();
            decimal tongTienMonAn = 0;

            foreach (MonAnItem item in GioHang)
            {
                ListViewItem lvi = new ListViewItem(item.TenMon);
                lvi.SubItems.Add(item.SoLuong.ToString());
                lvi.SubItems.Add(item.DonGia.ToString("#,##0"));
                lvi.SubItems.Add((item.DonGia * item.SoLuong).ToString("#,##0"));
                listViewCart.Items.Add(lvi);

                tongTienMonAn += item.DonGia * item.SoLuong;
            }

            labelTotalValue.Text = tongTienMonAn.ToString("#,##0") + " VNĐ";
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            HienThiMonAnTheoLoai(1); // Combo
            UpdateButtonColors(btnCombo);
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            HienThiMonAnTheoLoai(2); // Ăn vặt
            UpdateButtonColors(btnSnacks);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            HienThiMonAnTheoLoai(3); // Đồ uống
            UpdateButtonColors(btnDrinks);
        }

        private void UpdateButtonColors(Button selectedButton)
        {
            // Reset tất cả button về màu mặc định
            btnCombo.BackColor = Color.LightGray;
            btnSnacks.BackColor = Color.LightGray;
            btnDrinks.BackColor = Color.LightGray;

            // Đặt màu cho button được chọn
            selectedButton.BackColor = Color.LightBlue;
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (GioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Xóa toàn bộ giỏ hàng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GioHang.Clear();
                CapNhatGioHang();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (GioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!\nVui lòng chọn món ăn trước khi thanh toán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTienMonAn = 0;
            foreach (MonAnItem item in GioHang)
            {
                tongTienMonAn += item.DonGia * item.SoLuong;
            }

            decimal tongTien = tongTienVe + tongTienMonAn;

            string message = "XÁC NHẬN THANH TOÁN\n\n";
            message += $"Thông tin đặt chỗ:\n";
            message += $"• Phim: {labelMovieValue.Text}\n";
            message += $"• Suất chiếu: {labelShowtimeValue.Text}\n";
            message += $"• Ghế: {labelSeatsValue.Text}\n\n";
            message += $"Chi tiết đơn hàng:\n";
            message += $"• Tiền vé: {tongTienVe:#,##0} VNĐ\n";
            message += $"• Tiền món ăn: {tongTienMonAn:#,##0} VNĐ\n";
            message += $"• Tổng cộng: {tongTien:#,##0} VNĐ\n\n";
            message += "Bạn có chắc chắn thanh toán?";

            if (MessageBox.Show(message, "Thanh toán",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Tạo hóa đơn và lưu chi tiết món ăn
                string idHoaDon = LuuHoaDonVaoDatabase(tongTienMonAn, tongTien);

                if (!string.IsNullOrEmpty(idHoaDon))
                {
                    // Lưu chi tiết món ăn
                    foreach (MonAnItem item in GioHang)
                    {
                        LuuChiTietMonAn(idHoaDon, item);
                    }

                    MessageBox.Show("Thanh toán thành công!\nCảm ơn quý khách!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private string LuuHoaDonVaoDatabase(decimal tongTienMonAn, decimal tongTien)
        {
            try
            {
                string idHoaDon = "HDMA" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string idNhanVien = TTCSDL_NHOM7.Utilities.UserSession.MaNV ?? "";

                // Sử dụng DuLieuDAO để thêm hóa đơn
                int result = DuLieuDAO.Insert_HoaDon(idHoaDon, idNhanVien, tongTien);

                if (result > 0)
                    return idHoaDon;
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void LuuChiTietMonAn(string idHoaDon, MonAnItem item)
        {
            try
            {
                // Sử dụng DuLieuDAO để thêm chi tiết món ăn
                DuLieuDAO.Insert_ChiTietMonAn(idHoaDon, item.MaMon, item.SoLuong, item.DonGia, item.DonGia * item.SoLuong);
            }
            catch (Exception)
            {
                // Bỏ qua lỗi từng món
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bỏ qua món ăn và quay lại?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}