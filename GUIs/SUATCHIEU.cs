using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.GUIs
{
    public partial class SUATCHIEU : Form
    {
        private string idPhim;
        private DateTime ngayChieu;
        private DataTable? dtSuatChieu;
        private string? selectedIdLichChieu;

        public SUATCHIEU(string idPhim, DateTime ngayChieu)
        {
            InitializeComponent();
            this.idPhim = idPhim;
            this.ngayChieu = ngayChieu;
            LoadThongTinPhim();
            LoadSuatChieu();
        }

        private void LoadThongTinPhim()
        {
            DataTable dtPhim = DuLieuDAO.LayThongTinPhim(idPhim);
            if (dtPhim.Rows.Count > 0)
            {
                DataRow row = dtPhim.Rows[0];
                labelMovieTitle.Text = row["TenPhim"]?.ToString() ?? "";
                labelMovieInfo.Text = $"Thời lượng: {row["ThoiLuong"]?.ToString() ?? "0"} phút | Năm SX: {row["NamSX"]?.ToString() ?? ""}";

                if (row["ApPhich"] != DBNull.Value && row["ApPhich"] != null)
                {
                    try
                    {
                        byte[] imageData = (byte[])row["ApPhich"];
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            pictureBoxPoster.Image = Image.FromStream(ms);
                        }
                    }
                    catch { }
                }
            }
        }

        private void LoadSuatChieu()
        {
            dtSuatChieu = DuLieuDAO.LaySuatChieuTheoPhim(idPhim, ngayChieu);
            flowLayoutPanelShowtimes.Controls.Clear();

            if (dtSuatChieu != null && dtSuatChieu.Rows.Count > 0)
            {
                foreach (DataRow row in dtSuatChieu.Rows)
                {
                    string? idLichChieu = row["MaLichChieu"]?.ToString();
                    if (string.IsNullOrEmpty(idLichChieu)) continue;

                    DateTime thoiGianChieu = Convert.ToDateTime(row["ThoiGianChieu"]);
                    decimal giaVe = Convert.ToDecimal(row["GiaVe"] ?? 0);

                    int veConTrong = DuLieuDAO.GetSoVeConTrong(idLichChieu);

                    Button btnSuatChieu = new Button
                    {
                        Width = 220,
                        Height = 90,
                        Margin = new Padding(10),
                        Tag = idLichChieu,
                        Text = $"Rạp: {row["TenPhong"]?.ToString() ?? ""}\n" +
                       $"Giờ: {thoiGianChieu:HH:mm}\n" +
                       $"Màn hình: {row["TenLoaiManHinh"]?.ToString() ?? ""}\n" +
                       $"Giá: {giaVe:#,##0} VNĐ\n" +
                       $"Còn trống: {veConTrong} vé",
                        Font = new Font("Arial", 8, FontStyle.Bold),
                        BackColor = veConTrong > 0 ? Color.LightGreen : Color.LightGray,
                        Enabled = veConTrong > 0
                    };

                    btnSuatChieu.Click += BtnSuatChieu_Click;
                    flowLayoutPanelShowtimes.Controls.Add(btnSuatChieu);
                }
            }
            else
            {
                Label lbl = new Label
                {
                    Text = "Không có suất chiếu nào có sẵn vé",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red
                };
                flowLayoutPanelShowtimes.Controls.Add(lbl);
            }
        }

        private void BtnSuatChieu_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                selectedIdLichChieu = btn.Tag.ToString();

                foreach (Control control in flowLayoutPanelShowtimes.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = SystemColors.Control;
                    }
                }

                btn.BackColor = Color.LightGreen;
                btnBookSeats.Enabled = true;
            }
        }

        private void btnBookSeats_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedIdLichChieu))
            {
                this.Hide();
                DATGHE frmDatGhe = new DATGHE(selectedIdLichChieu);
                frmDatGhe.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}