using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class CHONPHIM : Form
    {
        private DataTable? dtPhim;

        public CHONPHIM()
        {
            InitializeComponent();
            dtpNgayChieu.Value = DateTime.Now;
            LoadPhimTheoNgay(DateTime.Now);
        }

        private void LoadPhimTheoNgay(DateTime ngay)
        {
            try
            {
                lbphim.Text = "Đang tải phim...";
                flowLayoutPanelPhim.Controls.Clear();

                // Ưu tiên dùng phiên bản nhẹ (nhanh hơn)
                dtPhim = DuLieuDAO.LayPhimDangChieu_Simple(ngay);

                // Nếu không có phim nào (có thể do ngày không có lịch), fallback lấy full (có poster)
                if (dtPhim == null || dtPhim.Rows.Count == 0)
                    dtPhim = DuLieuDAO.LayPhimDangChieu(ngay);

                if (dtPhim != null && dtPhim.Rows.Count > 0)
                {
                    lbphim.Text = $"Có {dtPhim.Rows.Count} phim đang chiếu ngày {ngay:dd/MM/yyyy}";

                    foreach (DataRow row in dtPhim.Rows)
                    {
                        string idPhim = row["id"]?.ToString() ?? "";
                        if (string.IsNullOrEmpty(idPhim)) continue;

                        Button btnPhim = new Button
                        {
                            Width = 190,
                            Height = 300,
                            Margin = new Padding(15),
                            Tag = idPhim,
                            FlatStyle = FlatStyle.Flat,
                            FlatAppearance = { BorderSize = 0 },
                            Cursor = Cursors.Hand,
                            BackColor = Color.FromArgb(45, 45, 45),
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                            TextAlign = ContentAlignment.BottomCenter
                        };

                        // Load poster riêng (vì phiên bản Simple không có ApPhich)
                        byte[]? imgData = DuLieuDAO.LayPosterPhim(idPhim);

                        if (imgData != null && imgData.Length > 0)
                        {
                            using (var ms = new MemoryStream(imgData))
                            {
                                Image poster = Image.FromStream(ms);
                                btnPhim.BackgroundImage = poster;
                                btnPhim.BackgroundImageLayout = ImageLayout.Stretch;
                                // Chỉ hiện tên phim ở dưới khi có poster
                                btnPhim.Text = row["TenPhim"]?.ToString() ?? "Không tên";
                            }
                        }
                        else
                        {
                            // Không có poster → hiện full thông tin
                            btnPhim.Text = $"{row["TenPhim"]}\n\n" +
                                           $"Thời lượng: {row["ThoiLuong"]} phút\n" +
                                           $"Đạo diễn: {row["DaoDien"]}\n" +
                                           $"Năm: {row["NamSX"]}\n" +
                                           $"KC: {row.Field<DateTime>("NgayKhoiChieu"):dd/MM}\n" +
                                           $"KT: {row.Field<DateTime>("NgayKetThuc"):dd/MM}";
                        }

                        // Hover effect đẹp
                        btnPhim.MouseEnter += (s, e) => btnPhim.BackColor = Color.FromArgb(80, 80, 80);
                        btnPhim.MouseLeave += (s, e) => btnPhim.BackColor = Color.FromArgb(45, 45, 45);

                        btnPhim.Click += BtnPhim_Click;
                        flowLayoutPanelPhim.Controls.Add(btnPhim);
                    }
                }
                else
                {
                    lbphim.Text = $"Không có phim chiếu ngày {ngay:dd/MM/yyyy}";
                    Label lbl = new Label
                    {
                        Text = "Chưa có lịch chiếu cho ngày này.\nVui lòng kiểm tra dữ liệu lịch chiếu.",
                        ForeColor = Color.Red,
                        Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    flowLayoutPanelPhim.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải phim: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbphim.Text = "Lỗi tải dữ liệu";
            }
        }

        private void BtnPhim_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string idPhim && !string.IsNullOrEmpty(idPhim))
            {
                this.Hide();
                var frmSuatChieu = new SUATCHIEU(idPhim, dtpNgayChieu.Value);
                frmSuatChieu.ShowDialog();
                this.Show();

                // Refresh lại sau khi quay về (tránh lỗi cache nếu thêm lịch mới)
                LoadPhimTheoNgay(dtpNgayChieu.Value);
            }
        }

        private void btnSearchdate_Click(object sender, EventArgs e)
        {
            LoadPhimTheoNgay(dtpNgayChieu.Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}