using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TTCSDL_NHOM7.DAOs;

namespace TTCSDL_NHOM7.UserControls
{
    public partial class DoanhThuUC : UserControl
    {
        public DoanhThuUC()
        {
            InitializeComponent();
            InitLineChart();
            radiobtn_TheoNgay.Checked = true;
            datepick_TuNgay.Value = DateTime.Now.AddDays(-7);
            datepick_ToiNgay.Value = DateTime.Now;
            LoadTheoNgay();
            LoadMovieCombox();
        }

        #region Load Data
        void LoadMovieCombox()
        {
            DataTable dt = DoanhThuDAO.GetMovieList();
            combox_TheoPhim.DataSource = null;
            combox_TheoPhim.DisplayMember = "";
            combox_TheoPhim.ValueMember = "";

            combox_TheoPhim.DataSource = dt;
            combox_TheoPhim.DisplayMember = "TenPhim";
            combox_TheoPhim.ValueMember = "MaPhim";

            combox_TheoPhim.SelectedIndex = -1;
        }

        void LoadTheoNgay()
        {
            DataTable dt = DoanhThuDAO.GetRevenueByDay(
                datepick_TuNgay.Value.Date,
                datepick_ToiNgay.Value.Date
            );
            BindData(dt);
            DrawLineChart(dt, "Doanh thu theo ngày");
        }

        void LoadTheoTuan()
        {
            DataTable dt = DoanhThuDAO.GetRevenueByWeek(
                datepick_TuNgay.Value.Date,
                datepick_ToiNgay.Value.Date
            );
            BindData(dt);
            DrawLineChart(dt, "Doanh thu theo tuần");
        }

        void LoadTheoPhim()
        {
            if (combox_TheoPhim.SelectedValue == null) return;

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            string idMovie = combox_TheoPhim.SelectedValue.ToString();

            DataTable dt = DoanhThuDAO.GetRevenueByMovieMonth(idMovie, month, year);
            BindData(dt);
            DrawLineChart(dt, "Doanh thu theo phim");
        }

        void BindData(DataTable dt)
        {
            dgvRevenue.DataSource = dt;

            decimal total = 0;
            if (dt.Columns.Contains("TongDoanhThu"))
            {
                foreach (DataRow r in dt.Rows)
                    total += Convert.ToDecimal(r["TongDoanhThu"]);
            }

            lblTotalRevenue.Text = $"Tổng doanh thu: {total:N0} VNĐ";
        }
        #endregion

        #region Function
        private void radiobtn_TheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (!radiobtn_TheoNgay.Checked) return;

            combox_TheoPhim.Enabled = false;
            datepick_TuNgay.Enabled = true;
            datepick_ToiNgay.Enabled = true;
        }

        private void radiobtn_TheoTuan_CheckedChanged(object sender, EventArgs e)
        {
            if (!radiobtn_TheoTuan.Checked) return;

            combox_TheoPhim.Enabled = false;
            datepick_TuNgay.Enabled = true;
            datepick_ToiNgay.Enabled = true;
        }

        private void radiobutton_TheoPhim_CheckedChanged(object sender, EventArgs e)
        {
            if (!radiobutton_TheoPhim.Checked) return;

            combox_TheoPhim.Enabled = true;
            datepick_TuNgay.Enabled = false;
            datepick_ToiNgay.Enabled = false;

            LoadTheoPhim();
        }

        private void combobox_TheoPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radiobutton_TheoPhim.Checked) return;
            LoadTheoPhim();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (radiobtn_TheoNgay.Checked)
                LoadTheoNgay();
            else if (radiobtn_TheoTuan.Checked)
                LoadTheoTuan();
            else if (radiobutton_TheoPhim.Checked)
                LoadTheoPhim();
        }

        private void btn_Export_Excel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel sẽ triển khai sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in báo cáo sẽ triển khai sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Chart
        void InitLineChart()
        {
            linechart_DoanhThu.Series.Clear();
            linechart_DoanhThu.ChartAreas.Clear();
            linechart_DoanhThu.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            area.AxisX.LabelStyle.Format = "dd/MM";
            area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Doanh thu (VNĐ)";

            linechart_DoanhThu.ChartAreas.Add(area);

            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            linechart_DoanhThu.Legends.Add(legend);
        }

        void DrawLineChart(DataTable dt, string seriesName)
        {
            linechart_DoanhThu.Series.Clear();

            Series series = new Series(seriesName);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 6;
            series.XValueType = ChartValueType.Date;
            series.YValueType = ChartValueType.Double;

            foreach (DataRow row in dt.Rows)
            {
                DateTime x;
                decimal y;

                // Tùy theo SP trả cột nào
                if (dt.Columns.Contains("Ngay"))
                    x = Convert.ToDateTime(row["Ngay"]);
                else if (dt.Columns.Contains("NgayChieu"))
                    x = Convert.ToDateTime(row["NgayChieu"]);
                else
                    x = Convert.ToDateTime(row[0]); // fallback

                y = Convert.ToDecimal(row["TongDoanhThu"]);

                series.Points.AddXY(x, y);
            }

            linechart_DoanhThu.Series.Add(series);
        }

        #endregion
    }
}
