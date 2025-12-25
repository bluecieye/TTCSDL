using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;
using Microsoft.Data.SqlClient;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class DATGHE : Form
    {
        private string idLichChieu;
        private string idPhong;
        private List<string> danhSachGheChon = new List<string>();
        private List<string> danhSachGheDaDat = new List<string>();
        private decimal tongTien = 0;
        private decimal giaVeCoBan = 0;

        public DATGHE(string idLichChieu)
        {
            InitializeComponent();
            this.idLichChieu = idLichChieu;
            LoadThongTinLichChieu();
            LoadPhongChieu();
            LoadDanhSachGhe();
            LoadGheDaDat();
            SetupEventHandlers();
        }

        private void LoadThongTinLichChieu()
        {
            try
            {
                // Sử dụng DuLieuDAO để lấy thông tin lịch chiếu
                var dt = DuLieuDAO.Search_LichChieu(maLichChieu: idLichChieu);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Kiểm tra null cho ThoiGianChieu
                    DateTime thoiGianChieu = DateTime.Now;
                    if (row["ThoiGianChieu"] != null && row["ThoiGianChieu"] != DBNull.Value)
                    {
                        thoiGianChieu = Convert.ToDateTime(row["ThoiGianChieu"]);
                    }

                    // Kiểm tra null cho GiaVe
                    if (row["GiaVe"] != null && row["GiaVe"] != DBNull.Value)
                    {
                        giaVeCoBan = Convert.ToDecimal(row["GiaVe"]);
                    }
                    else
                    {
                        giaVeCoBan = 80000; // Giá mặc định
                    }

                    lblTime.Text = $"{thoiGianChieu:dd/MM/yyyy HH:mm}";

                    // Kiểm tra xem có cột TenPhim không
                    string tenPhim = "";
                    if (dt.Columns.Contains("TenPhim") && row["TenPhim"] != DBNull.Value)
                    {
                        tenPhim = row["TenPhim"].ToString();
                    }

                    // Kiểm tra xem có cột TenPhong không
                    string tenPhong = "";
                    if (dt.Columns.Contains("TenPhong") && row["TenPhong"] != DBNull.Value)
                    {
                        tenPhong = row["TenPhong"].ToString();
                    }

                    // Chỉ hiển thị nếu có dữ liệu
                    if (!string.IsNullOrEmpty(tenPhim) || !string.IsNullOrEmpty(tenPhong))
                    {
                        lblManChieu.Text = $"{tenPhim} - {tenPhong}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin lịch chiếu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhongChieu()
        {
            try
            {
                // Lấy idPhong từ lịch chiếu
                var dt = DataProvider.ExecuteQuery(
                    "SELECT idPhong FROM LichChieu WHERE id = @id",
                    CommandType.Text,
                    new SqlParameter("@id", idLichChieu)
                );

                if (dt.Rows.Count > 0)
                {
                    idPhong = dt.Rows[0]["idPhong"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng chiếu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phòng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachGhe()
        {
            try
            {
                if (string.IsNullOrEmpty(idPhong))
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sử dụng DuLieuDAO để lấy danh sách ghế
                var dtGhe = DuLieuDAO.LayDanhSachGheTheoPhong(idPhong);

                // Kiểm tra xem có ghế không
                if (dtGhe == null || dtGhe.Rows.Count == 0)
                {
                    MessageBox.Show("Phòng chiếu chưa có ghế được tạo!\nVui lòng tạo ghế trước.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Hiển thị thông báo trong panel
                    var lbl = new Label
                    {
                        Text = "PHÒNG CHƯA CÓ GHẾ\nVui lòng tạo ghế trong phần quản lý",
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Red,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    pnlGhe.Controls.Add(lbl);
                    return;
                }

                // Render layout ghế
                RenderGheLayout(dtGhe);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách ghế: {ex.Message}\n{ex.StackTrace}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGheDaDat()
        {
            try
            {
                // Lấy danh sách ghế đã đặt cho lịch chiếu này bằng DuLieuDAO
                var dtGheDaDat = DataProvider.ExecuteQuery(
                    "SELECT idGhe FROM Ve WHERE idLichChieu = @idLichChieu AND TrangThai = 2",
                    CommandType.Text,
                    new SqlParameter("@idLichChieu", idLichChieu)
                );

                // Debug: In ra số ghế đã đặt
                Console.WriteLine($"=== DEBUG: LoadGheDaDat ===");
                Console.WriteLine($"Số ghế đã đặt: {dtGheDaDat.Rows.Count}");

                danhSachGheDaDat.Clear(); // Xóa danh sách cũ trước khi thêm mới

                foreach (DataRow row in dtGheDaDat.Rows)
                {
                    string idGhe = row["idGhe"].ToString().Trim();
                    danhSachGheDaDat.Add(idGhe);
                    Console.WriteLine($"Đã thêm ghế vào danh sách đã đặt: {idGhe}");
                }
                Console.WriteLine($"=== END DEBUG ===");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ghế đã đặt: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderGheLayout(DataTable dtGhe)
        {
            pnlGhe.Controls.Clear();

            int buttonSize = 50;
            int spacing = 30;
            int startX = 50;
            int startY = 10;
            int currentX = startX;
            int currentY = startY;

            // Tìm số hàng và số cột tối đa
            int maxHang = 0;
            int maxCot = 0;
            foreach (DataRow row in dtGhe.Rows)
            {
                int hang = Convert.ToInt32(row["Hang"]);
                int cot = Convert.ToInt32(row["Cot"]);
                if (hang > maxHang) maxHang = hang;
                if (cot > maxCot) maxCot = cot;
            }

            Console.WriteLine($"Số hàng: {maxHang}, Số cột: {maxCot}");

            // Tạo chữ cái cho hàng
            string[] hangLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" };

            // Vẽ label cột (số thứ tự cột)
            currentX = startX + 25;
            for (int cot = 1; cot <= maxCot; cot++)
            {
                Label lblCot = new Label
                {
                    Text = cot.ToString(),
                    Location = new Point(currentX, currentY),
                    Size = new Size(buttonSize, 25),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray
                };
                pnlGhe.Controls.Add(lblCot);
                currentX += buttonSize + spacing;
            }

            currentY += 30;

            // Tạo dictionary để lưu ghế theo vị trí
            var gheDict = new Dictionary<(int Hang, int Cot), DataRow>();
            foreach (DataRow row in dtGhe.Rows)
            {
                int hang = Convert.ToInt32(row["Hang"]);
                int cot = Convert.ToInt32(row["Cot"]);
                gheDict[(hang, cot)] = row;
            }

            // Vẽ từng hàng
            for (int hang = 1; hang <= maxHang; hang++)
            {
                // Label cho hàng (chữ cái)
                string hangLetter = (hang <= hangLetters.Length) ? hangLetters[hang - 1] : hang.ToString();
                Label lblHang = new Label
                {
                    Text = hangLetter,
                    Location = new Point(startX, currentY + 10),
                    Size = new Size(25, buttonSize),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray
                };
                pnlGhe.Controls.Add(lblHang);

                currentX = startX + 30;

                // Vẽ từng cột trong hàng
                for (int cot = 1; cot <= maxCot; cot++)
                {
                    if (gheDict.ContainsKey((hang, cot)))
                    {
                        DataRow row = gheDict[(hang, cot)];
                        string idGhe = row["id"].ToString().Trim();
                        string maGhe = row["MaGhe"].ToString();
                        string tenLoaiGhe = row["TenLoaiGhe"].ToString();
                        string trangThaiGhe = row["TrangThai"].ToString();
                        decimal chiPhi = Convert.ToDecimal(row["ChiPhi"] ?? 0);

                        Button btnGhe = new Button
                        {
                            Width = buttonSize,
                            Height = buttonSize,
                            Location = new Point(currentX, currentY),
                            Text = cot.ToString(),
                            Tag = idGhe,
                            Font = new Font("Arial", 9, FontStyle.Bold),
                            ForeColor = Color.Black,
                            FlatStyle = FlatStyle.Flat
                        };

                        // Debug: Kiểm tra ghế này có trong danh sách đã đặt không
                        bool isDaDat = danhSachGheDaDat.Contains(idGhe);
                        Console.WriteLine($"Ghế {idGhe} (Mã: {maGhe}) - Đã đặt: {isDaDat}");

                        // Kiểm tra ghế đã đặt chưa
                        if (isDaDat)
                        {
                            // Ghế đã đặt - màu đỏ, disabled
                            btnGhe.BackColor = Color.Red;
                            btnGhe.Enabled = false;
                            btnGhe.ForeColor = Color.White;
                            btnGhe.FlatAppearance.BorderColor = Color.DarkRed;
                            btnGhe.Text = "X";
                        }
                        else if (trangThaiGhe == "Đang sửa")
                        {
                            // Ghế đang sửa - màu xám, disabled
                            btnGhe.BackColor = Color.Gray;
                            btnGhe.Enabled = false;
                            btnGhe.ForeColor = Color.White;
                            btnGhe.FlatAppearance.BorderColor = Color.DarkGray;
                            btnGhe.Text = "S";
                        }
                        else
                        {
                            // Ghế bình thường, có thể chọn
                            btnGhe.BackColor = Color.LightGreen;
                            btnGhe.FlatAppearance.BorderColor = Color.DarkGreen;
                            btnGhe.Click += BtnGhe_Click;

                            // Tooltip hiển thị thông tin ghế
                            ToolTip toolTip = new ToolTip();
                            toolTip.SetToolTip(btnGhe, $"Ghế {hangLetter}{cot}\nMã: {maGhe}\nLoại: {tenLoaiGhe}\nPhụ phí: {chiPhi:#,##0} VNĐ");
                        }

                        pnlGhe.Controls.Add(btnGhe);
                    }
                    else
                    {
                        // Vị trí trống (không có ghế)
                        Panel pnlEmpty = new Panel
                        {
                            Width = buttonSize,
                            Height = buttonSize,
                            Location = new Point(currentX, currentY),
                            BackColor = Color.Transparent,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        pnlGhe.Controls.Add(pnlEmpty);
                    }

                    currentX += buttonSize + spacing;
                }

                currentY += buttonSize + spacing;
            }

            // Tạo label màn hình
            Label lblScreen = new Label
            {
                Text = "MÀN HÌNH",
                Location = new Point(startX + 30, currentY + 10),
                Size = new Size((buttonSize + spacing) * maxCot - spacing, 30),
                Font = new Font("Arial", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlGhe.Controls.Add(lblScreen);

            // Thêm chú thích
            AddLegend(currentY + 50);
        }

        private void AddLegend(int startY)
        {
            int legendX = 50;
            int legendY = startY;
            int boxSize = 20;
            int spacing = 10;

            // Ghế trống (có thể chọn)
            Panel pnlTrong = new Panel
            {
                Width = boxSize,
                Height = boxSize,
                Location = new Point(legendX, legendY),
                BackColor = Color.LightGreen,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlGhe.Controls.Add(pnlTrong);

            Label lblTrong = new Label
            {
                Text = "Ghế trống",
                Location = new Point(legendX + boxSize + 5, legendY),
                Size = new Size(80, 20),
                Font = new Font("Arial", 9)
            };
            pnlGhe.Controls.Add(lblTrong);

            // Ghế đã chọn
            Panel pnlChon = new Panel
            {
                Width = boxSize,
                Height = boxSize,
                Location = new Point(legendX + 120, legendY),
                BackColor = Color.Yellow,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlGhe.Controls.Add(pnlChon);

            Label lblChon = new Label
            {
                Text = "Đã chọn",
                Location = new Point(legendX + 120 + boxSize + 5, legendY),
                Size = new Size(80, 20),
                Font = new Font("Arial", 9)
            };
            pnlGhe.Controls.Add(lblChon);

            // Ghế đã đặt
            Panel pnlDaDat = new Panel
            {
                Width = boxSize,
                Height = boxSize,
                Location = new Point(legendX + 240, legendY),
                BackColor = Color.Red,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlGhe.Controls.Add(pnlDaDat);

            Label lblDaDat = new Label
            {
                Text = "Đã đặt",
                Location = new Point(legendX + 240 + boxSize + 5, legendY),
                Size = new Size(80, 20),
                Font = new Font("Arial", 9)
            };
            pnlGhe.Controls.Add(lblDaDat);

            // Ghế đang sửa
            Panel pnlSua = new Panel
            {
                Width = boxSize,
                Height = boxSize,
                Location = new Point(legendX + 360, legendY),
                BackColor = Color.Gray,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlGhe.Controls.Add(pnlSua);

            Label lblSua = new Label
            {
                Text = "Đang sửa",
                Location = new Point(legendX + 360 + boxSize + 5, legendY),
                Size = new Size(80, 20),
                Font = new Font("Arial", 9)
            };
            pnlGhe.Controls.Add(lblSua);
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            if (sender is Button btnGhe && btnGhe.Tag != null)
            {
                string idGhe = btnGhe.Tag.ToString();
                if (string.IsNullOrEmpty(idGhe)) return;

                if (danhSachGheChon.Contains(idGhe))
                {
                    // Bỏ chọn ghế
                    danhSachGheChon.Remove(idGhe);
                    btnGhe.BackColor = Color.LightGreen;
                    btnGhe.ForeColor = Color.Black;
                }
                else
                {
                    // Chọn ghế
                    danhSachGheChon.Add(idGhe);
                    btnGhe.BackColor = Color.Yellow;
                    btnGhe.ForeColor = Color.Black;
                }

                CapNhatTongTien();
            }
        }

        private void SetupEventHandlers()
        {
            rdoNguoiLon.CheckedChanged += RdoLoaiVe_CheckedChanged;
            rdoSinhVien.CheckedChanged += RdoLoaiVe_CheckedChanged;
            rdoTreEm.CheckedChanged += RdoLoaiVe_CheckedChanged;
            btnTiepTuc.Click += BtnTiepTuc_Click;
            btnThanhToan.Click += BtnThanhToan_Click;
            btnHuy.Click += BtnHuy_Click;
        }

        private void RdoLoaiVe_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal giaVe = giaVeCoBan;

            if (rdoSinhVien.Checked)
                giaVe = giaVeCoBan * 0.8m; // Giảm 20% cho sinh viên
            else if (rdoTreEm.Checked)
                giaVe = giaVeCoBan * 0.7m; // Giảm 30% cho trẻ em

            txtGiaVe.Text = giaVe.ToString("#,##0");
            tongTien = danhSachGheChon.Count * giaVe;

            txtTongTien.Text = tongTien.ToString("#,##0");
        }

        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            if (danhSachGheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            var frmMonAn = new MONAN(idLichChieu, danhSachGheChon, tongTien);

            if (frmMonAn.ShowDialog() == DialogResult.OK)
            {
                // Sau khi thanh toán món ăn thành công, cập nhật lại danh sách ghế đã đặt
                LoadGheDaDat();
                LoadDanhSachGhe();
                MessageBox.Show("Thanh toán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachGheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = $"Xác nhận thanh toán:\n\n";
            message += $"Số ghế: {danhSachGheChon.Count} ghế\n";
            message += $"Tổng tiền: {tongTien:#,##0} VNĐ\n";
            message += $"Loại vé: {(rdoNguoiLon.Checked ? "Người lớn" : rdoSinhVien.Checked ? "Sinh viên" : "Trẻ em")}\n\n";
            message += "Bạn có chắc chắn?";

            if (MessageBox.Show(message, "Xác nhận thanh toán",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LuuVeVaoDatabase())
                {
                    // Cập nhật lại danh sách ghế đã đặt
                    LoadGheDaDat();
                    // Tải lại danh sách ghế để cập nhật giao diện
                    LoadDanhSachGhe();

                    MessageBox.Show("Thanh toán thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private bool LuuVeVaoDatabase()
        {
            try
            {
                // Tạo hóa đơn trước
                string idHoaDon = TaoHoaDon();

                if (string.IsNullOrEmpty(idHoaDon))
                {
                    MessageBox.Show("Lỗi khi tạo hóa đơn!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Lưu từng vé với trạng thái ĐÃ BÁN (TrangThai = 2)
                foreach (string idGhe in danhSachGheChon)
                {
                    decimal tienBanVe = tongTien / danhSachGheChon.Count;

                    DataProvider.ExecuteNonQuery(
                        "INSERT INTO Ve (idLichChieu, idGhe, idHoaDon, TrangThai, TienBanVe) " +
                        "VALUES (@idLichChieu, @idGhe, @idHoaDon, 2, @tienBanVe)",
                        CommandType.Text,
                        new SqlParameter("@idLichChieu", idLichChieu),
                        new SqlParameter("@idGhe", idGhe),
                        new SqlParameter("@idHoaDon", idHoaDon),
                        new SqlParameter("@tienBanVe", tienBanVe)
                    );
                }

                // Debug: Kiểm tra đã lưu bao nhiêu vé
                var dtCheck = DataProvider.ExecuteQuery(
                    "SELECT COUNT(*) as SoVe FROM Ve WHERE idLichChieu = @idLichChieu AND TrangThai = 2",
                    CommandType.Text,
                    new SqlParameter("@idLichChieu", idLichChieu)
                );

                Console.WriteLine($"=== DEBUG: Đã lưu {dtCheck.Rows[0]["SoVe"]} vé ===");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu vé: {ex.Message}\n{ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string TaoHoaDon()
        {
            try
            {
                string idHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string idNhanVien = TTCSDL_NHOM7.Utilities.UserSession.MaNV ?? "";

                // Sử dụng DuLieuDAO để tạo hóa đơn
                int result = DuLieuDAO.Insert_HoaDon(idHoaDon, idNhanVien, tongTien, idLichChieu);

                if (result > 0)
                    return idHoaDon;
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn hủy đặt ghế?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTestGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idPhong))
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sử dụng DuLieuDAO để tạo ghế tự động
                DuLieuDAO.SinhGheTheoPhong(idPhong);

                MessageBox.Show("Đã tạo ghế tự động thành công!\nVui lòng tải lại form.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách ghế
                LoadDanhSachGhe();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo ghế: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm sự kiện Form Activated để cập nhật lại dữ liệu khi form được kích hoạt lại
        private void DATGHE_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("=== Form DATGHE được kích hoạt lại ===");
            LoadGheDaDat();
            LoadDanhSachGhe();
        }
    }
}