namespace TTCSDL_NHOM7.GUIs
{
    partial class HOADON
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOADON));
            groupBox1 = new GroupBox();
            txtDiemTichLuy = new TextBox();
            label11 = new Label();
            txtNhanVien = new TextBox();
            label4 = new Label();
            dtpNgayLap = new DateTimePicker();
            cboKhachHang = new ComboBox();
            txtMaHoaDon = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbox_ThongTinVe = new GroupBox();
            dgvVe = new DataGridView();
            groupBox4 = new GroupBox();
            cboPhuongThuc = new ComboBox();
            label12 = new Label();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtTongTien = new TextBox();
            txtTienMonAn = new TextBox();
            txtTienVe = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnThanhToan = new Button();
            btnHuy = new Button();
            button_closeHoaDon = new Button();
            dgvMonAn = new DataGridView();
            gbox_DoAnDaChon = new GroupBox();
            groupBox1.SuspendLayout();
            gbox_ThongTinVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVe).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            gbox_DoAnDaChon.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiemTichLuy);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(18, 17);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1575, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtDiemTichLuy.Location = new Point(1295, 81);
            txtDiemTichLuy.Margin = new Padding(4, 3, 4, 3);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.ReadOnly = true;
            txtDiemTichLuy.Size = new Size(256, 22);
            txtDiemTichLuy.TabIndex = 9;
            txtDiemTichLuy.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.5F);
            label11.Location = new Point(1167, 84);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(84, 16);
            label11.TabIndex = 8;
            label11.Text = "Điểm tích lũy:";
            // 
            // txtNhanVien
            // 
            txtNhanVien.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtNhanVien.Location = new Point(898, 81);
            txtNhanVien.Margin = new Padding(4, 3, 4, 3);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.Size = new Size(233, 22);
            txtNhanVien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.5F);
            label4.Location = new Point(793, 84);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 6;
            label4.Text = "Nhân viên:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayLap.Font = new Font("Microsoft Sans Serif", 9.5F);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(898, 35);
            dtpNgayLap.Margin = new Padding(4, 3, 4, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(233, 22);
            dtpNgayLap.TabIndex = 5;
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Microsoft Sans Serif", 9.5F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(152, 81);
            cboKhachHang.Margin = new Padding(4, 3, 4, 3);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(606, 24);
            cboKhachHang.TabIndex = 4;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            txtMaHoaDon.Location = new Point(152, 35);
            txtMaHoaDon.Margin = new Padding(4, 3, 4, 3);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(233, 22);
            txtMaHoaDon.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.5F);
            label3.Location = new Point(793, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 2;
            label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.5F);
            label2.Location = new Point(29, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.5F);
            label1.Location = new Point(29, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // gbox_ThongTinVe
            // 
            gbox_ThongTinVe.Controls.Add(dgvVe);
            gbox_ThongTinVe.Enabled = false;
            gbox_ThongTinVe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            gbox_ThongTinVe.Location = new Point(18, 156);
            gbox_ThongTinVe.Margin = new Padding(4, 3, 4, 3);
            gbox_ThongTinVe.Name = "gbox_ThongTinVe";
            gbox_ThongTinVe.Padding = new Padding(4, 3, 4, 3);
            gbox_ThongTinVe.Size = new Size(793, 392);
            gbox_ThongTinVe.TabIndex = 1;
            gbox_ThongTinVe.TabStop = false;
            gbox_ThongTinVe.Text = "Thông tin vé đã đặt";
            // 
            // dgvVe
            // 
            dgvVe.BackgroundColor = Color.White;
            dgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVe.Location = new Point(18, 25);
            dgvVe.Margin = new Padding(4, 3, 4, 3);
            dgvVe.Name = "dgvVe";
            dgvVe.Size = new Size(756, 355);
            dgvVe.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboPhuongThuc);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtThanhTien);
            groupBox4.Controls.Add(txtGiamGia);
            groupBox4.Controls.Add(txtTongTien);
            groupBox4.Controls.Add(txtTienMonAn);
            groupBox4.Controls.Add(txtTienVe);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox4.Location = new Point(18, 560);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(1283, 144);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thanh toán";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhuongThuc.Font = new Font("Microsoft Sans Serif", 10F);
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Location = new Point(1015, 87);
            cboPhuongThuc.Margin = new Padding(4, 3, 4, 3);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(233, 24);
            cboPhuongThuc.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F);
            label12.Location = new Point(840, 90);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 17);
            label12.TabIndex = 10;
            label12.Text = "Phương thức TT:";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtThanhTien.ForeColor = Color.Red;
            txtThanhTien.Location = new Point(1015, 35);
            txtThanhTien.Margin = new Padding(4, 3, 4, 3);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(233, 26);
            txtThanhTien.TabIndex = 9;
            txtThanhTien.Text = "0";
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Font = new Font("Microsoft Sans Serif", 10F);
            txtGiamGia.Location = new Point(583, 87);
            txtGiamGia.Margin = new Padding(4, 3, 4, 3);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(209, 23);
            txtGiamGia.TabIndex = 8;
            txtGiamGia.Text = "0";
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Microsoft Sans Serif", 10F);
            txtTongTien.Location = new Point(583, 35);
            txtTongTien.Margin = new Padding(4, 3, 4, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(209, 23);
            txtTongTien.TabIndex = 7;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTienMonAn
            // 
            txtTienMonAn.Font = new Font("Microsoft Sans Serif", 10F);
            txtTienMonAn.Location = new Point(163, 87);
            txtTienMonAn.Margin = new Padding(4, 3, 4, 3);
            txtTienMonAn.Name = "txtTienMonAn";
            txtTienMonAn.ReadOnly = true;
            txtTienMonAn.Size = new Size(209, 23);
            txtTienMonAn.TabIndex = 6;
            txtTienMonAn.Text = "0";
            txtTienMonAn.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTienVe
            // 
            txtTienVe.Font = new Font("Microsoft Sans Serif", 10F);
            txtTienVe.Location = new Point(163, 35);
            txtTienVe.Margin = new Padding(4, 3, 4, 3);
            txtTienVe.Name = "txtTienVe";
            txtTienVe.ReadOnly = true;
            txtTienVe.Size = new Size(209, 23);
            txtTienVe.TabIndex = 5;
            txtTienVe.Text = "0";
            txtTienVe.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.Location = new Point(840, 38);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 4;
            label10.Text = "Thành tiền:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.Location = new Point(443, 90);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 17);
            label9.TabIndex = 3;
            label9.Text = "Giảm giá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.Location = new Point(443, 38);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 2;
            label8.Text = "Tổng tiền:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F);
            label13.Location = new Point(29, 90);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(91, 17);
            label13.TabIndex = 1;
            label13.Text = "Tiền món ăn:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10F);
            label14.Location = new Point(29, 38);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(59, 17);
            label14.TabIndex = 0;
            label14.Text = "Tiền vé:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(0, 123, 255);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1318, 600);
            btnThanhToan.Margin = new Padding(4, 3, 4, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(128, 52);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(108, 117, 125);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(1458, 600);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(128, 52);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // button_closeHoaDon
            // 
            button_closeHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_closeHoaDon.BackgroundImage = (Image)resources.GetObject("button_closeHoaDon.BackgroundImage");
            button_closeHoaDon.BackgroundImageLayout = ImageLayout.Center;
            button_closeHoaDon.FlatStyle = FlatStyle.Popup;
            button_closeHoaDon.Location = new Point(1578, -1);
            button_closeHoaDon.Margin = new Padding(4, 3, 4, 3);
            button_closeHoaDon.Name = "button_closeHoaDon";
            button_closeHoaDon.RightToLeft = RightToLeft.No;
            button_closeHoaDon.Size = new Size(40, 37);
            button_closeHoaDon.TabIndex = 6;
            button_closeHoaDon.TextImageRelation = TextImageRelation.ImageAboveText;
            button_closeHoaDon.UseVisualStyleBackColor = true;
            button_closeHoaDon.Click += button_closeHoaDon_Click;
            // 
            // dgvMonAn
            // 
            dgvMonAn.BackgroundColor = Color.White;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Location = new Point(13, 25);
            dgvMonAn.Margin = new Padding(4, 3, 4, 3);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.Size = new Size(732, 355);
            dgvMonAn.TabIndex = 6;
            // 
            // gbox_DoAnDaChon
            // 
            gbox_DoAnDaChon.Controls.Add(dgvMonAn);
            gbox_DoAnDaChon.Enabled = false;
            gbox_DoAnDaChon.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            gbox_DoAnDaChon.Location = new Point(818, 156);
            gbox_DoAnDaChon.Margin = new Padding(4, 3, 4, 3);
            gbox_DoAnDaChon.Name = "gbox_DoAnDaChon";
            gbox_DoAnDaChon.Padding = new Padding(4, 3, 4, 3);
            gbox_DoAnDaChon.Size = new Size(751, 392);
            gbox_DoAnDaChon.TabIndex = 2;
            gbox_DoAnDaChon.TabStop = false;
            gbox_DoAnDaChon.Text = "Đồ ăn đã chọn";
            // 
            // HOADON
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 728);
            Controls.Add(button_closeHoaDon);
            Controls.Add(btnHuy);
            Controls.Add(btnThanhToan);
            Controls.Add(groupBox4);
            Controls.Add(gbox_DoAnDaChon);
            Controls.Add(gbox_ThongTinVe);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HOADON";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbox_ThongTinVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVe).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            gbox_DoAnDaChon.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_ThongTinVe;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienMonAn;
        private System.Windows.Forms.TextBox txtTienVe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button_closeHoaDon;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.GroupBox gbox_DoAnDaChon;
        #endregion
    }
}