namespace TTCSDL_NHOM7.GUIs
{
    partial class DATGHE
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
            grpInfo = new GroupBox();
            lblTime = new Label();
            lblManChieu = new Label();
            pnlGhe = new Panel();
            grpChuThich = new GroupBox();
            pnlDangChon = new Panel();
            lblDangChon = new Label();
            pnlDaMua = new Panel();
            lblDaMua = new Label();
            grpLoaiVe = new GroupBox();
            rdoNguoiLon = new RadioButton();
            rdoSinhVien = new RadioButton();
            rdoTreEm = new RadioButton();
            txtGiaVe = new TextBox();
            grpThanhVien = new GroupBox();
            chkThanhVien = new CheckBox();
            txtTenKH = new TextBox();
            txtDiem = new TextBox();
            nudDoiVe = new NumericUpDown();
            grpThanhToan = new GroupBox();
            txtTongTien = new TextBox();
            txtGiam = new TextBox();
            txtCanTra = new TextBox();
            btnTiepTuc = new Button();
            btnThanhToan = new Button();
            btnHuy = new Button();
            grpInfo.SuspendLayout();
            grpChuThich.SuspendLayout();
            grpLoaiVe.SuspendLayout();
            grpThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDoiVe).BeginInit();
            grpThanhToan.SuspendLayout();
            SuspendLayout();
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblTime);
            grpInfo.Location = new Point(10, 10);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1160, 80);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Information";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(20, 35);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(200, 25);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time";
            // 
            // lblManChieu
            // 
            lblManChieu.BackColor = Color.Gray;
            lblManChieu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblManChieu.Location = new Point(160, 105);
            lblManChieu.Name = "lblManChieu";
            lblManChieu.Size = new Size(700, 50);
            lblManChieu.TabIndex = 1;
            lblManChieu.Text = "Màn Chiếu";
            lblManChieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGhe
            // 
            pnlGhe.AutoScroll = true;
            pnlGhe.BorderStyle = BorderStyle.FixedSingle;
            pnlGhe.Location = new Point(50, 170);
            pnlGhe.Name = "pnlGhe";
            pnlGhe.Size = new Size(900, 350);
            pnlGhe.TabIndex = 2;
            // 
            // grpChuThich
            // 
            grpChuThich.Controls.Add(pnlDangChon);
            grpChuThich.Controls.Add(lblDangChon);
            grpChuThich.Controls.Add(pnlDaMua);
            grpChuThich.Controls.Add(lblDaMua);
            grpChuThich.Location = new Point(970, 250);
            grpChuThich.Name = "grpChuThich";
            grpChuThich.Size = new Size(180, 120);
            grpChuThich.TabIndex = 3;
            grpChuThich.TabStop = false;
            // 
            // pnlDangChon
            // 
            pnlDangChon.BackColor = Color.Yellow;
            pnlDangChon.Location = new Point(20, 30);
            pnlDangChon.Name = "pnlDangChon";
            pnlDangChon.Size = new Size(25, 25);
            pnlDangChon.TabIndex = 0;
            // 
            // lblDangChon
            // 
            lblDangChon.Location = new Point(60, 30);
            lblDangChon.Name = "lblDangChon";
            lblDangChon.Size = new Size(100, 25);
            lblDangChon.TabIndex = 1;
            lblDangChon.Text = "Đang chọn";
            // 
            // pnlDaMua
            // 
            pnlDaMua.BackColor = Color.Red;
            pnlDaMua.Location = new Point(20, 70);
            pnlDaMua.Name = "pnlDaMua";
            pnlDaMua.Size = new Size(25, 25);
            pnlDaMua.TabIndex = 2;
            // 
            // lblDaMua
            // 
            lblDaMua.Location = new Point(60, 70);
            lblDaMua.Name = "lblDaMua";
            lblDaMua.Size = new Size(100, 25);
            lblDaMua.TabIndex = 3;
            lblDaMua.Text = "Đã mua";
            // 
            // grpLoaiVe
            // 
            grpLoaiVe.Controls.Add(rdoNguoiLon);
            grpLoaiVe.Controls.Add(rdoSinhVien);
            grpLoaiVe.Controls.Add(rdoTreEm);
            grpLoaiVe.Controls.Add(txtGiaVe);
            grpLoaiVe.Location = new Point(20, 540);
            grpLoaiVe.Name = "grpLoaiVe";
            grpLoaiVe.Size = new Size(350, 150);
            grpLoaiVe.TabIndex = 4;
            grpLoaiVe.TabStop = false;
            grpLoaiVe.Text = "Loại Vé";
            // 
            // rdoNguoiLon
            // 
            rdoNguoiLon.Location = new Point(20, 30);
            rdoNguoiLon.Name = "rdoNguoiLon";
            rdoNguoiLon.Size = new Size(100, 25);
            rdoNguoiLon.TabIndex = 0;
            rdoNguoiLon.Text = "Người Lớn";
            // 
            // rdoSinhVien
            // 
            rdoSinhVien.Location = new Point(140, 30);
            rdoSinhVien.Name = "rdoSinhVien";
            rdoSinhVien.Size = new Size(100, 25);
            rdoSinhVien.TabIndex = 1;
            rdoSinhVien.Text = "Sinh Viên";
            // 
            // rdoTreEm
            // 
            rdoTreEm.Location = new Point(20, 60);
            rdoTreEm.Name = "rdoTreEm";
            rdoTreEm.Size = new Size(200, 25);
            rdoTreEm.TabIndex = 2;
            rdoTreEm.Text = "Trẻ Em (Dưới 12 tuổi)";
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(90, 100);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(150, 23);
            txtGiaVe.TabIndex = 3;
            // 
            // grpThanhVien
            // 
            grpThanhVien.Controls.Add(chkThanhVien);
            grpThanhVien.Controls.Add(txtTenKH);
            grpThanhVien.Controls.Add(txtDiem);
            grpThanhVien.Controls.Add(nudDoiVe);
            grpThanhVien.Location = new Point(390, 540);
            grpThanhVien.Name = "grpThanhVien";
            grpThanhVien.Size = new Size(400, 150);
            grpThanhVien.TabIndex = 5;
            grpThanhVien.TabStop = false;
            grpThanhVien.Text = "Thành Viên";
            // 
            // chkThanhVien
            // 
            chkThanhVien.Location = new Point(20, 30);
            chkThanhVien.Name = "chkThanhVien";
            chkThanhVien.Size = new Size(200, 25);
            chkThanhVien.TabIndex = 0;
            chkThanhVien.Text = "Khách Hàng Thành Viên";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(150, 60);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(200, 23);
            txtTenKH.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(150, 90);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(80, 23);
            txtDiem.TabIndex = 2;
            // 
            // nudDoiVe
            // 
            nudDoiVe.Location = new Point(150, 120);
            nudDoiVe.Name = "nudDoiVe";
            nudDoiVe.Size = new Size(50, 23);
            nudDoiVe.TabIndex = 3;
            // 
            // grpThanhToan
            // 
            grpThanhToan.Controls.Add(txtTongTien);
            grpThanhToan.Controls.Add(txtGiam);
            grpThanhToan.Controls.Add(txtCanTra);
            grpThanhToan.Controls.Add(btnTiepTuc);
            grpThanhToan.Controls.Add(btnThanhToan);
            grpThanhToan.Controls.Add(btnHuy);
            grpThanhToan.Location = new Point(810, 540);
            grpThanhToan.Name = "grpThanhToan";
            grpThanhToan.Size = new Size(360, 150);
            grpThanhToan.TabIndex = 6;
            grpThanhToan.TabStop = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(130, 30);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(200, 23);
            txtTongTien.TabIndex = 0;
            // 
            // txtGiam
            // 
            txtGiam.Location = new Point(130, 60);
            txtGiam.Name = "txtGiam";
            txtGiam.Size = new Size(200, 23);
            txtGiam.TabIndex = 1;
            // 
            // txtCanTra
            // 
            txtCanTra.Location = new Point(150, 90);
            txtCanTra.Name = "txtCanTra";
            txtCanTra.Size = new Size(180, 23);
            txtCanTra.TabIndex = 2;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(20, 120);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(90, 30);
            btnTiepTuc.TabIndex = 3;
            btnTiepTuc.Text = "Tiếp Tục";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(130, 120);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(100, 30);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(250, 120);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 30);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            // 
            // DATGHE
            // 
            BackColor = Color.Beige;
            ClientSize = new Size(1184, 711);
            Controls.Add(grpInfo);
            Controls.Add(lblManChieu);
            Controls.Add(pnlGhe);
            Controls.Add(grpChuThich);
            Controls.Add(grpLoaiVe);
            Controls.Add(grpThanhVien);
            Controls.Add(grpThanhToan);
            Name = "DATGHE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Ghế";
            grpInfo.ResumeLayout(false);
            grpChuThich.ResumeLayout(false);
            grpLoaiVe.ResumeLayout(false);
            grpLoaiVe.PerformLayout();
            grpThanhVien.ResumeLayout(false);
            grpThanhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDoiVe).EndInit();
            grpThanhToan.ResumeLayout(false);
            grpThanhToan.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox grpInfo;
        private Label lblTime;
        private Label lblManChieu;
        private Panel pnlGhe;
        private GroupBox grpChuThich;
        private Panel pnlDangChon;
        private Panel pnlDaMua;
        private Label lblDangChon;
        private Label lblDaMua;
        private GroupBox grpLoaiVe;
        private RadioButton rdoNguoiLon;
        private RadioButton rdoSinhVien;
        private RadioButton rdoTreEm;
        private TextBox txtGiaVe;
        private GroupBox grpThanhVien;
        private CheckBox chkThanhVien;
        private TextBox txtTenKH;
        private TextBox txtDiem;
        private NumericUpDown nudDoiVe;
        private GroupBox grpThanhToan;
        private TextBox txtTongTien;
        private TextBox txtGiam;
        private TextBox txtCanTra;
        private Button btnTiepTuc;
        private Button btnThanhToan;
        private Button btnHuy;

        #endregion
    }
}