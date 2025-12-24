namespace TTCSDL_NHOM7.UserControls
{
    partial class DoanhThuUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlMain = new Panel();
            pnlContent = new Panel();
            linechart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvRevenue = new DataGridView();
            pnlControls = new Panel();
            combox_TheoPhim = new ComboBox();
            label2 = new Label();
            btn_Print = new Button();
            label1 = new Label();
            lblTotalRevenue = new Label();
            btn_Export_Excel = new Button();
            btn_Filter = new Button();
            datepick_ToiNgay = new DateTimePicker();
            datepick_TuNgay = new DateTimePicker();
            radiobutton_TheoPhim = new RadioButton();
            radiobtn_TheoTuan = new RadioButton();
            radiobtn_TheoNgay = new RadioButton();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linechart_DoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            pnlControls.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(24, 24, 37);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Controls.Add(pnlControls);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1012, 516);
            pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(255, 192, 128);
            pnlContent.Controls.Add(linechart_DoanhThu);
            pnlContent.Controls.Add(dgvRevenue);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 161);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(23);
            pnlContent.Size = new Size(1012, 355);
            pnlContent.TabIndex = 2;
            // 
            // linechart_DoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            linechart_DoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            linechart_DoanhThu.Legends.Add(legend1);
            linechart_DoanhThu.Location = new Point(23, 0);
            linechart_DoanhThu.Name = "linechart_DoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            linechart_DoanhThu.Series.Add(series1);
            linechart_DoanhThu.Size = new Size(965, 226);
            linechart_DoanhThu.TabIndex = 1;
            linechart_DoanhThu.Text = "chart1";
            // 
            // dgvRevenue
            // 
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.AllowUserToDeleteRows = false;
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Dock = DockStyle.Bottom;
            dgvRevenue.Location = new Point(23, 225);
            dgvRevenue.Margin = new Padding(4, 3, 4, 3);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.ReadOnly = true;
            dgvRevenue.RowHeadersVisible = false;
            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenue.Size = new Size(966, 107);
            dgvRevenue.TabIndex = 0;
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(255, 224, 192);
            pnlControls.Controls.Add(combox_TheoPhim);
            pnlControls.Controls.Add(label2);
            pnlControls.Controls.Add(btn_Print);
            pnlControls.Controls.Add(label1);
            pnlControls.Controls.Add(lblTotalRevenue);
            pnlControls.Controls.Add(btn_Export_Excel);
            pnlControls.Controls.Add(btn_Filter);
            pnlControls.Controls.Add(datepick_ToiNgay);
            pnlControls.Controls.Add(datepick_TuNgay);
            pnlControls.Controls.Add(radiobutton_TheoPhim);
            pnlControls.Controls.Add(radiobtn_TheoTuan);
            pnlControls.Controls.Add(radiobtn_TheoNgay);
            pnlControls.Dock = DockStyle.Top;
            pnlControls.Location = new Point(0, 69);
            pnlControls.Margin = new Padding(4, 3, 4, 3);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1012, 92);
            pnlControls.TabIndex = 1;
            // 
            // combox_TheoPhim
            // 
            combox_TheoPhim.Enabled = false;
            combox_TheoPhim.FormattingEnabled = true;
            combox_TheoPhim.Location = new Point(305, 29);
            combox_TheoPhim.Name = "combox_TheoPhim";
            combox_TheoPhim.Size = new Size(155, 23);
            combox_TheoPhim.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(619, 7);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 11;
            label2.Text = "Tới Ngày:";
            // 
            // btn_Print
            // 
            btn_Print.BackColor = Color.FromArgb(168, 85, 247);
            btn_Print.Cursor = Cursors.Hand;
            btn_Print.FlatStyle = FlatStyle.Flat;
            btn_Print.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(898, 51);
            btn_Print.Margin = new Padding(4, 3, 4, 3);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(86, 35);
            btn_Print.TabIndex = 8;
            btn_Print.Text = "IN BÁO CÁO";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(467, 7);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 10;
            label1.Text = "Từ Ngày:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.FromArgb(34, 197, 94);
            lblTotalRevenue.Location = new Point(341, 67);
            lblTotalRevenue.Margin = new Padding(4, 0, 4, 0);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(118, 19);
            lblTotalRevenue.TabIndex = 9;
            lblTotalRevenue.Text = "Tổng doanh thu:";
            // 
            // btn_Export_Excel
            // 
            btn_Export_Excel.BackColor = Color.FromArgb(34, 197, 94);
            btn_Export_Excel.Cursor = Cursors.Hand;
            btn_Export_Excel.FlatStyle = FlatStyle.Flat;
            btn_Export_Excel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Export_Excel.ForeColor = Color.White;
            btn_Export_Excel.Location = new Point(898, 7);
            btn_Export_Excel.Margin = new Padding(4, 3, 4, 3);
            btn_Export_Excel.Name = "btn_Export_Excel";
            btn_Export_Excel.Size = new Size(86, 35);
            btn_Export_Excel.TabIndex = 7;
            btn_Export_Excel.Text = "XUẤT EXCEL";
            btn_Export_Excel.UseVisualStyleBackColor = false;
            btn_Export_Excel.Click += btn_Export_Excel_Click;
            // 
            // btn_Filter
            // 
            btn_Filter.BackColor = Color.FromArgb(59, 130, 246);
            btn_Filter.Cursor = Cursors.Hand;
            btn_Filter.FlatStyle = FlatStyle.Flat;
            btn_Filter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Filter.ForeColor = Color.White;
            btn_Filter.Location = new Point(783, 22);
            btn_Filter.Margin = new Padding(4, 3, 4, 3);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(86, 35);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "LỌC";
            btn_Filter.UseVisualStyleBackColor = false;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // datepick_ToiNgay
            // 
            datepick_ToiNgay.Format = DateTimePickerFormat.Short;
            datepick_ToiNgay.Location = new Point(619, 29);
            datepick_ToiNgay.Margin = new Padding(4, 3, 4, 3);
            datepick_ToiNgay.Name = "datepick_ToiNgay";
            datepick_ToiNgay.Size = new Size(139, 23);
            datepick_ToiNgay.TabIndex = 5;
            // 
            // datepick_TuNgay
            // 
            datepick_TuNgay.Format = DateTimePickerFormat.Short;
            datepick_TuNgay.Location = new Point(467, 29);
            datepick_TuNgay.Margin = new Padding(4, 3, 4, 3);
            datepick_TuNgay.Name = "datepick_TuNgay";
            datepick_TuNgay.Size = new Size(139, 23);
            datepick_TuNgay.TabIndex = 4;
            // 
            // radiobutton_TheoPhim
            // 
            radiobutton_TheoPhim.AutoSize = true;
            radiobutton_TheoPhim.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radiobutton_TheoPhim.ForeColor = Color.ForestGreen;
            radiobutton_TheoPhim.Location = new Point(204, 27);
            radiobutton_TheoPhim.Margin = new Padding(4, 3, 4, 3);
            radiobutton_TheoPhim.Name = "radiobutton_TheoPhim";
            radiobutton_TheoPhim.Size = new Size(94, 23);
            radiobutton_TheoPhim.TabIndex = 2;
            radiobutton_TheoPhim.Text = "Theo phim";
            radiobutton_TheoPhim.UseVisualStyleBackColor = true;
            radiobutton_TheoPhim.CheckedChanged += radiobutton_TheoPhim_CheckedChanged;
            // 
            // radiobtn_TheoTuan
            // 
            radiobtn_TheoTuan.AutoSize = true;
            radiobtn_TheoTuan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radiobtn_TheoTuan.ForeColor = Color.ForestGreen;
            radiobtn_TheoTuan.Location = new Point(106, 27);
            radiobtn_TheoTuan.Margin = new Padding(4, 3, 4, 3);
            radiobtn_TheoTuan.Name = "radiobtn_TheoTuan";
            radiobtn_TheoTuan.Size = new Size(90, 23);
            radiobtn_TheoTuan.TabIndex = 1;
            radiobtn_TheoTuan.Text = "Theo tuần";
            radiobtn_TheoTuan.UseVisualStyleBackColor = true;
            radiobtn_TheoTuan.CheckedChanged += radiobtn_TheoTuan_CheckedChanged;
            // 
            // radiobtn_TheoNgay
            // 
            radiobtn_TheoNgay.AutoSize = true;
            radiobtn_TheoNgay.Checked = true;
            radiobtn_TheoNgay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            radiobtn_TheoNgay.ForeColor = Color.ForestGreen;
            radiobtn_TheoNgay.Location = new Point(6, 27);
            radiobtn_TheoNgay.Margin = new Padding(4, 3, 4, 3);
            radiobtn_TheoNgay.Name = "radiobtn_TheoNgay";
            radiobtn_TheoNgay.Size = new Size(92, 23);
            radiobtn_TheoNgay.TabIndex = 0;
            radiobtn_TheoNgay.TabStop = true;
            radiobtn_TheoNgay.Text = "Theo ngày";
            radiobtn_TheoNgay.UseVisualStyleBackColor = true;
            radiobtn_TheoNgay.CheckedChanged += radiobtn_TheoNgay_CheckedChanged;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(59, 130, 246);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 69);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 128, 0);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1012, 69);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 THỐNG KÊ DOANH THU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoanhThuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DoanhThuUC";
            Size = new Size(1012, 516);
            pnlMain.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)linechart_DoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent; 
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Export_Excel;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DateTimePicker datepick_ToiNgay;
        private System.Windows.Forms.DateTimePicker datepick_TuNgay;
        private System.Windows.Forms.RadioButton radiobutton_TheoPhim;
        private System.Windows.Forms.RadioButton radiobtn_TheoTuan;
        private System.Windows.Forms.RadioButton radiobtn_TheoNgay;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalRevenue;
        private Label label1;
        private Label label2;
        private ComboBox combox_TheoPhim;
        private System.Windows.Forms.DataVisualization.Charting.Chart linechart_DoanhThu;
    }
}
